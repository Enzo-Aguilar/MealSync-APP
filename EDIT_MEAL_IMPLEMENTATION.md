# Edit_Meal Feature Implementation

## Overview
The Edit_Meal feature has been successfully implemented with all requested functionality:
- Search meals by name using tbSearch (filters on the current date's meals)
- Display meal cards that are clickable to show details in the side panel
- Prevent editing of meals with less than 7 days advance notice
- Detect if no changes were made and warn the user
- Allow editing only for meals scheduled 7+ days in advance

## Changes Made

### 1. **BLL/BLL.cs - Added Database Methods**
- **Show_MealsByDate(DateTime date)**: New method to fetch meals for a specific date
- **Update_Meal(Meal meal)**: New method to update meal data in the database

### 2. **Pages/Meals/Edit_Meal.cs - Full Implementation**

#### Class-level Members:
- `originalMeal`: Stores the meal before edits (for change detection)
- `currentMeal`: Stores temporary meal data
- `isEditMode`: Boolean flag to track if in edit mode
- `mealEditableMap`: Dictionary mapping meal IDs to editability status

#### Core Methods:

**Edit_Meal_Load()**
- Initializes form on load
- Sets DateTimePicker to today's date
- Loads meals for the current date
- Attaches event handlers

**LoadMealsForDate(DateTime date)**
- Fetches all meals for the selected date from database
- Determines editability based on 7-day rule
- Creates meal card UI components for each meal
- Displays warning if no meals found

**IsEditable(DateTime mealDate)**
- Checks if meal date is at least 7 days in the future
- Returns true only if meal date >= today + 7 days

**FilterMealsByName(string searchTerm)**
- Real-time search functionality
- Filters meal cards by name as user types
- Case-insensitive matching

**CreateMealComponent(Meal meal, bool isEditable)**
- Generates visual meal card with:
  - Meal image (if available)
  - Meal name
  - Meal type
  - Price
  - Date
  - Editability status
- Color coding:
  - **Light Green**: Editable meals (interactive)
  - **Light Gray**: Non-editable meals (disabled)
  - **Light Cyan**: Currently selected meal
  - **Light Blue**: Hover state (editable meals only)

**OnMealCardClicked(Meal meal, Panel mealCard)**
- Handles meal card selection
- Deselects previously selected meal
- Highlights selected meal
- Loads meal details into the side panel

**DisplayMealDetails(Meal meal)**
- Populates all form fields with selected meal data
- Creates backup copies (originalMeal and currentMeal)
- Loads meal image
- Disables edit mode initially

**BtnEdit_Click()**
- Validates that a meal is selected
- Checks if meal is editable (7+ days advance)
- **Detects changes**: Warns user if no changes detected
- Enables edit mode if changes detected
- Toggles button text between "Editar" and "Cancelar"

**HasChanges()**
- Compares current field values with original values
- Checks for changes in:
  - Meal name
  - Description
  - Type
  - Price
  - Date
  - Image
- Returns false if identical

**BtnUpdate_Click()**
- Validates all meal fields using MealValidator
- Parses and validates price
- Calls Meal_BLL.Update_Meal()
- Shows success/error messages
- Refreshes meal list after successful update
- Returns to disabled edit mode

**EnableEditMode()**
- Makes all input fields editable
- Enables the Update button
- Changes Edit button text to "Cancelar"

**DisableEditMode()**
- Makes all input fields read-only
- Disables the Update button
- Changes Edit button text back to "Editar"

**PictureBoxMealImage_Click()**
- Allows image selection only in edit mode
- Opens file dialog for image selection
- Shows warning if not in edit mode

### 3. **Pages/Meals/Edit_Meal.Designer.cs - Event Handlers Added**
- `Edit_Meal_Load`: Form initialization
- `DateTimePicker1_ValueChanged`: Reload meals when date changes
- `TbSearch_TextChanged`: Real-time search filtering
- `BtnEdit_Click`: Edit button functionality
- `BtnUpdate_Click`: Update button functionality
- `PictureBoxMealImage_Click`: Image selection

## Features Summary

### ✅ Search Functionality
- tbSearch searches meals by name
- Searches only meals from the selected date
- Real-time filtering as user types
- Case-insensitive matching

### ✅ Meal Display
- Meal cards show: image, name, type, price, date, editability status
- Color-coded for quick visual identification
- Interactive UI with hover effects for editable meals
- Non-editable meals are visible but grayed out and disabled

### ✅ Selection & Details Panel
- Click meal card to select it
- Selected meal details appear in the right panel
- Meal information automatically populated
- Original values stored for change detection

### ✅ 7-Day Advance Requirement
- Only meals scheduled 7+ days in advance can be edited
- Meals within 7 days are shown but disabled (Light Gray)
- Error message if attempting to edit non-editable meal
- Automatic validation in EditMode check

### ✅ Change Detection
- Tracks original meal values before edit
- Compares all fields: name, description, type, price, date, image
- Warns user if attempting to edit with no changes
- Message: "Nenhuma alteração foi detectada..."

### ✅ Edit Mode
- Edit button enters edit mode
- All fields become editable in edit mode
- Image can be changed by clicking on it
- Button text changes to "Cancelar" during edit mode

### ✅ Update Functionality
- Validates all fields before saving:
  - Name: required, max 100 chars
  - Description: required, max 255 chars
  - Date: must be 7+ days in future
  - Price: must be positive
  - Type: required
- Updates database via Meal_BLL.Update_Meal()
- Shows success message
- Auto-refreshes meal list
- Returns to read-only mode after successful update

## Validation Rules Applied
(Using existing MealValidator from MealUtils.cs)

- **Name**: Required, max 100 characters
- **Description**: Required, max 255 characters
- **Date**: Must be at least 7 days in the future
- **Price**: Required, must be positive
- **Type**: Required (Vegetariano, Peixe, or Carne)

## User Experience Flow

1. **Load Form**: Shows meals for today
2. **Select Date**: Change DateTimePicker to view meals for different date
3. **Search**: Type in tbSearch to filter by meal name
4. **Click Card**: Select meal card to view details in side panel
5. **Review**: Check current meal information in read-only fields
6. **Edit**: Click "Editar" button
   - If no changes: Warning message shown
   - If meal not editable (< 7 days): Error message shown
   - If all valid: Fields become editable
7. **Modify**: Change meal details (name, description, type, price, date, image)
8. **Save**: Click "Atualizar" to save changes
   - Validation runs
   - Success message shown
   - Meal list refreshes
   - Fields return to read-only

## Testing Recommendations

1. Test date selection (verify meals load for correct date)
2. Test search filtering (verify name matching is case-insensitive)
3. Test meal selection (verify details populate correctly)
4. Test 7-day validation (try editing meal < 7 days, should fail)
5. Test change detection (click Edit without changes, should warn)
6. Test full edit flow (make changes, save, verify in database)
7. Test image upload (verify image loads and can be changed)
8. Test validation (try invalid prices, missing fields, etc.)
9. Test non-editable meal display (verify grayed out and disabled)

## Notes

- All validators from MealUtils.MealValidator are reused for consistency
- ImageUtils is used for image conversion (ImageToBytes)
- Same pattern as Cancel_Order for meal card creation and selection
- DateTime comparisons use CAST to Date to ensure proper matching
- All Portuguese user messages follow existing application conventions

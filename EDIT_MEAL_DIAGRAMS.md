# Edit_Meal Feature - Architecture & Flow Diagrams

## System Architecture

```
┌─────────────────────────────────────────────────────────────────────┐
│                         Edit_Meal Form (UI Layer)                   │
├─────────────────────────────────────────────────────────────────────┤
│                                                                     │
│  ┌──────────────────────────┐    ┌──────────────────────────────┐  │
│  │   Left Panel             │    │   Right Panel                │  │
│  │  (panelMealCards)        │    │  (panelSelectedMeal)         │  │
│  │                          │    │                              │  │
│  │ ┌──────────────────────┐ │    │  Meal Details               │  │
│  │ │ Meal Card 1          │ │    │  ────────────────────────  │  │
│  │ │ [Green/Gray]         │ │    │  [Image]                   │  │
│  │ │ Click → Select       │◄───►│  Nome: [Editable/ReadOnly]  │  │
│  │ └──────────────────────┘ │    │  Descrição: [...]           │  │
│  │                          │    │  Tipo: [...]                │  │
│  │ ┌──────────────────────┐ │    │  Preço: [...]               │  │
│  │ │ Meal Card 2          │ │    │  Data: [...]                │  │
│  │ │ [Green/Gray]         │ │    │                              │  │
│  │ │ Click → Select       │ │    │  [Editar] [Atualizar]       │  │
│  │ └──────────────────────┘ │    └──────────────────────────────┘  │
│  │                          │                                      │
│  │ Search: [tbSearch]       │                                      │
│  │ Date: [dateTimePicker1]  │                                      │
│  └──────────────────────────┘                                      │
│                                                                     │
└─────────────────────────────────────────────────────────────────────┘
		 │                                    ▲
		 │ (UI Events)                        │ (Populate UI)
		 ▼                                    │
┌─────────────────────────────────────────────────────────────────────┐
│                      Edit_Meal Code Logic (BLL Layer)               │
├─────────────────────────────────────────────────────────────────────┤
│                                                                     │
│  ┌─────────────────────────────────────────────────────────────┐  │
│  │ Event Handlers                                              │  │
│  │ ├─ Edit_Meal_Load()                                         │  │
│  │ ├─ DateTimePicker1_ValueChanged()                           │  │
│  │ ├─ TbSearch_TextChanged()                                   │  │
│  │ ├─ BtnEdit_Click()                                          │  │
│  │ ├─ BtnUpdate_Click()                                        │  │
│  │ └─ PictureBoxMealImage_Click()                              │  │
│  └─────────────────────────────────────────────────────────────┘  │
│                          ▲                                          │
│                          │                                          │
│  ┌─────────────────────────────────────────────────────────────┐  │
│  │ Core Methods                                                │  │
│  │ ├─ LoadMealsForDate() ──────────┐                           │  │
│  │ ├─ FilterMealsByName()          │                           │  │
│  │ ├─ CreateMealComponent()        │→ Display Logic            │  │
│  │ ├─ OnMealCardClicked()          │                           │  │
│  │ ├─ DisplayMealDetails()         │                           │  │
│  │ └─ EnableEditMode()             │                           │  │
│  │                                 ▼                           │  │
│  │ ┌───────────────────────────────────────────────────────┐  │  │
│  │ │ Validation & Business Logic                           │  │  │
│  │ │ ├─ IsEditable() - 7-day check                        │  │  │
│  │ │ ├─ HasChanges() - Compare fields                     │  │  │
│  │ │ ├─ AreStringsEqual() - Field comparison             │  │  │
│  │ │ ├─ AreMealImagesEqual() - Image comparison          │  │  │
│  │ │ └─ MealValidator - Validate inputs                  │  │  │
│  │ └───────────────────────────────────────────────────────┘  │  │
│  │                          ▼                                  │  │
│  │ ┌───────────────────────────────────────────────────────┐  │  │
│  │ │ Data Management                                        │  │  │
│  │ │ ├─ originalMeal - Store original data                │  │  │
│  │ │ ├─ currentMeal - Temporary storage                   │  │  │
│  │ │ └─ mealEditableMap - Editability tracking            │  │  │
│  │ └───────────────────────────────────────────────────────┘  │  │
│                                                                     │
└─────────────────────────────────────────────────────────────────────┘
		 │                                    ▲
		 │ (SQL Queries)                      │ (DataTable Results)
		 ▼                                    │
┌─────────────────────────────────────────────────────────────────────┐
│                     Meal_BLL (Data Access Layer)                    │
├─────────────────────────────────────────────────────────────────────┤
│                                                                     │
│  ├─ Show_MealsByDate(DateTime date)                                │
│  │  └─ SELECT * FROM [Meal] WHERE CAST(Date AS Date) = @Date      │
│  │                                                                  │
│  └─ Update_Meal(Meal meal)                                         │
│     └─ UPDATE [Meal] SET ... WHERE ID=@ID                          │
│                                                                     │
└─────────────────────────────────────────────────────────────────────┘
		 │                                    ▲
		 │ (SQL)                              │ (Rows)
		 ▼                                    │
┌─────────────────────────────────────────────────────────────────────┐
│                          SQL Server Database                        │
├─────────────────────────────────────────────────────────────────────┤
│                                                                     │
│  [Meal] Table                                                       │
│  ├─ ID (Primary Key)                                               │
│  ├─ Date (DateTime)                                                │
│  ├─ Name (varchar)                                                 │
│  ├─ Description (varchar)                                          │
│  ├─ Type (varchar)                                                 │
│  ├─ Price (SqlMoney)                                               │
│  ├─ MealImage (varbinary)                                          │
│  └─ IsActive (bit)                                                 │
│                                                                     │
└─────────────────────────────────────────────────────────────────────┘
```

---

## User Interaction Flow

```
START
  │
  ▼
┌─────────────────────────┐
│ Form Loads              │
│ - Set date to today     │
│ - Load meals for today  │
│ - Show meal cards       │
└─────────────────────────┘
  │
  ├──► Can User Choose Date?
  │        │
  │        ▼
  │    [Change DatePicker]
  │        │
  │        ▼
  │    Reload Meals
  │        │
  │        └──► Back to Meal Display
  │
  ├──► Can User Search?
  │        │
  │        ▼
  │    [Type in Search]
  │        │
  │        ▼
  │    Filter Meals (Real-time)
  │        │
  │        └──► Back to Meal Display
  │
  └──► Can User Select Meal?
		   │
		   ├─ Try to click meal card
		   │   │
		   │   ├─ Is meal editable (7+ days)?
		   │   │   │
		   │   │   ├─ YES: ✅ Click allowed
		   │   │   │         │
		   │   │   │         ▼
		   │   │   │    OnMealCardClicked()
		   │   │   │         │
		   │   │   │         ▼
		   │   │   │    DisplayMealDetails()
		   │   │   │         │
		   │   │   │         ▼
		   │   │   │    [Details appear in right panel]
		   │   │   │
		   │   │   └─ NO: ❌ Click blocked
		   │   │          (card is gray, no click handler)
		   │   │
		   │   ▼
		   │  [Meal selected - view details]
		   │
		   ├──► Can User Edit?
		   │        │
		   │        ▼
		   │    [Click "Editar" button]
		   │        │
		   │        ├─ Is meal selected? ─┐
		   │        │                      │
		   │        ├─ Is meal editable?  │► Validations
		   │        │   (7+ days)         │
		   │        │                      │
		   │        ├─ Are changes        │
		   │        │   detected?         │
		   │        │                    ─┘
		   │        │
		   │        ├─ ❌ Validation failed
		   │        │   │
		   │        │   ▼
		   │        │  [Show Error/Warning]
		   │        │   │
		   │        │   ▼
		   │        │  Stay in View Mode
		   │        │
		   │        └─ ✅ Validation passed
		   │            │
		   │            ▼
		   │        EnableEditMode()
		   │            │
		   │            ├─ Fields become editable
		   │            ├─ Button → "Cancelar"
		   │            └─ Update button → enabled
		   │
		   ├──► Can User Modify?
		   │        │
		   │        ├─ Change name
		   │        ├─ Change description
		   │        ├─ Change type
		   │        ├─ Change price
		   │        ├─ Change date
		   │        └─ Change image (click picture box)
		   │
		   ├──► Can User Save?
		   │        │
		   │        ├─ [Click "Cancelar"]
		   │        │   │
		   │        │   ▼
		   │        │  DisableEditMode()
		   │        │   │
		   │        │   ├─ Discard changes
		   │        │   ├─ Fields → read-only
		   │        │   └─ Button → "Editar"
		   │        │
		   │        └─ [Click "Atualizar"]
		   │            │
		   │            ▼
		   │        Validate All Fields
		   │            │
		   │            ├─ Name validation
		   │            ├─ Description validation
		   │            ├─ Type validation
		   │            ├─ Price validation
		   │            └─ Date validation (7+ days)
		   │            │
		   │            ├─ ❌ Validation failed
		   │            │   │
		   │            │   ▼
		   │            │  [Show error for failed field]
		   │            │   │
		   │            │   ▼
		   │            │  Stay in Edit Mode
		   │            │
		   │            └─ ✅ Validation passed
		   │                │
		   │                ▼
		   │            Meal_BLL.Update_Meal(meal)
		   │                │
		   │                ├─ SQL: UPDATE [Meal] SET ...
		   │                │
		   │                ├─ ❌ DB Error
		   │                │   │
		   │                │   ▼
		   │                │  [Show error message]
		   │                │   │
		   │                │   └─► Stay in Edit Mode
		   │                │
		   │                └─ ✅ Success
		   │                    │
		   │                    ├─ [Show success message]
		   │                    ├─ DisableEditMode()
		   │                    ├─ LoadMealsForDate() [refresh]
		   │                    │
		   │                    ▼
		   │                [Return to View Mode]
		   │                [Details updated with new data]
		   │
		   └──► Loop back to meal selection

END
```

---

## State Machine Diagram

```
┌──────────────────────────────────────────────────────────────────┐
│                    EDIT_MEAL STATE MACHINE                       │
├──────────────────────────────────────────────────────────────────┤

INITIAL STATE: FORM_LOADED
	│
	│ Edit_Meal_Load()
	│ LoadMealsForDate(today)
	│
	▼
┌─────────────────────────────────┐
│  STATE: VIEWING_MEALS           │
│ - Meals displayed               │
│ - Edit button: "Editar"         │
│ - Fields: ReadOnly              │
│ - Update button: Disabled       │
│ - User can search/filter        │
│ - User can click meal cards     │
└─────────────────────────────────┘
	│
	├─ TbSearch_TextChanged()
	│  └─► Filter + Stay in state
	│
	├─ DateTimePicker_Changed()
	│  └─► Reload + Stay in state
	│
	└─ MealCard_Click() [Editable only]
	   │
	   │ OnMealCardClicked()
	   │ DisplayMealDetails()
	   │
	   ▼
┌─────────────────────────────────┐
│  STATE: MEAL_SELECTED           │
│ - Meal details showing          │
│ - Edit button: "Editar"         │
│ - Fields: ReadOnly              │
│ - Update button: Disabled       │
│ - User can click Edit button    │
└─────────────────────────────────┘
	│
	├─ Other MealCard_Click()
	│  └─► OnMealCardClicked() + Stay in state
	│
	└─ BtnEdit_Click()
	   │
	   ├─► Validation: No meal selected
	   │   └─► Show warning + Stay in state
	   │
	   ├─► Validation: Not editable (< 7 days)
	   │   └─► Show error + Stay in state
	   │
	   ├─► Validation: No changes detected
	   │   └─► Show warning + Stay in state
	   │
	   └─► All validations passed
		   │
		   │ EnableEditMode()
		   │
		   ▼
┌─────────────────────────────────┐
│  STATE: EDIT_MODE               │
│ - Meal details showing          │
│ - Edit button: "Cancelar"       │
│ - Fields: Editable              │
│ - Update button: Enabled        │
│ - User can modify fields        │
│ - User can change image         │
└─────────────────────────────────┘
	│
	├─ BtnEdit_Click() [Cancelar]
	│  │
	│  │ DisableEditMode()
	│  │
	│  ▼
	│ MEAL_SELECTED (changes discarded)
	│
	└─ BtnUpdate_Click()
	   │
	   ├─► Validation failed
	   │   └─► Show error + Stay in EDIT_MODE
	   │
	   └─► Validation passed
		   │
		   │ Meal_BLL.Update_Meal(meal)
		   │
		   ├─► DB Error
		   │   └─► Show error + Stay in EDIT_MODE
		   │
		   └─► Success
			   │
			   │ DisableEditMode()
			   │ LoadMealsForDate()
			   │ Show success message
			   │
			   ▼
			   VIEWING_MEALS

TRANSITIONS SUMMARY:
┌─────────────────┐
│ FORM_LOADED     │──► VIEWING_MEALS ─┐
└─────────────────┘     (Loop)         │
						   ▲           │
						   │           │
					  Search/Filter    │
					  Date Change      │
						   │           │
						MEAL_SELECTED ◄┤
						(Click card)   │
						   ▼           │
						EDIT_MODE ─────┘
						(Click Edit)
```

---

## Change Detection Logic

```
COMPARISON FLOWCHART:

┌─────────────────────────┐
│  BtnEdit_Click()        │
│  Check HasChanges()     │
└─────────────────────────┘
	│
	▼
┌─────────────────────────────────────────┐
│  Compare ALL Fields                     │
│  (If ANY changed, return true)          │
└─────────────────────────────────────────┘
	│
	├─ Field 1: Name
	│  Current vs Original
	│     │
	│     ├─ String.Equals (OrdinalIgnoreCase)
	│     │
	│     ├─ MATCH → Continue
	│     └─ DIFFER → Return TRUE ✓
	│
	├─ Field 2: Description
	│  Current vs Original
	│     │
	│     ├─ String.Equals (OrdinalIgnoreCase)
	│     │
	│     ├─ MATCH → Continue
	│     └─ DIFFER → Return TRUE ✓
	│
	├─ Field 3: Type
	│  Current vs Original
	│     │
	│     ├─ String.Equals (OrdinalIgnoreCase)
	│     │
	│     ├─ MATCH → Continue
	│     └─ DIFFER → Return TRUE ✓
	│
	├─ Field 4: Price
	│  Current vs Original
	│     │
	│     ├─ String.Equals (OrdinalIgnoreCase)
	│     │
	│     ├─ MATCH → Continue
	│     └─ DIFFER → Return TRUE ✓
	│
	├─ Field 5: Date
	│  Current vs Original
	│     │
	│     ├─ DateTime.Equals
	│     │
	│     ├─ MATCH → Continue
	│     └─ DIFFER → Return TRUE ✓
	│
	└─ Field 6: Image
	   Current vs Original
		  │
		  ├─ ImageToBytes() conversion
		  ├─ SequenceEqual() comparison
		  │
		  ├─ MATCH → Continue
		  └─ DIFFER → Return TRUE ✓

If ALL match:
	Return FALSE (no changes)
	└─► Show warning: "Nenhuma alteração foi detectada..."
		└─► Stay in View Mode

If ANY differ:
	Return TRUE (has changes)
	└─► Enable Edit Mode
		└─► Enter EDIT_MODE state
```

---

## 7-Day Validation Logic

```
DATE VALIDATION:

┌──────────────────────────────┐
│ Meal Date Check              │
│ IsEditable(mealDate)         │
└──────────────────────────────┘
	│
	▼
┌──────────────────────────────┐
│ Get Today's Date             │
│ DateTime today = Today       │
└──────────────────────────────┘
	│
	▼
┌──────────────────────────────┐
│ Calculate 7 Days Later       │
│ DateTime sevenDaysLater      │
│   = today.AddDays(7)         │
└──────────────────────────────┘
	│
	▼
┌──────────────────────────────┐
│ Compare Dates                │
│ if mealDate >= sevenDaysLater│
└──────────────────────────────┘
	│
	├─ YES
	│  └─ Return TRUE (Editable ✓)
	│     └─ Color: Light Green
	│     └─ Clickable: Yes
	│     └─ Show: "✓ Editável"
	│
	└─ NO
	   └─ Return FALSE (Not Editable ✗)
		  └─ Color: Light Gray
		  └─ Clickable: No
		  └─ Show: "✗ Não Editável"

EXAMPLES:

Today:            2025-01-15
7 Days Later:     2025-01-22

Meal Date         Editable?   Why?
─────────────────────────────────────────
2025-01-14        NO          Before today
2025-01-15        NO          Today
2025-01-16-21     NO          < 7 days
2025-01-22        YES         ✓ Exactly 7 days
2025-01-23+       YES         ✓ More than 7 days
```

---

## Data Flow Diagram

```
INPUT LAYER
┌────────────────────────────────────────┐
│ User Inputs                            │
├────────────────────────────────────────┤
│ - Search textbox (tbSearch)            │
│ - Date picker (dateTimePicker1)        │
│ - Click meal card                      │
│ - Edit button (btnEdit)                │
│ - Update button (btnUpdate)            │
│ - Image selector                       │
└────────────────────────────────────────┘
	│
	▼
VALIDATION LAYER
┌────────────────────────────────────────┐
│ Validation Logic                       │
├────────────────────────────────────────┤
│ - Check meal selected                  │
│ - Check 7-day rule (IsEditable)        │
│ - Check changes detected (HasChanges)  │
│ - Validate all fields (MealValidator)  │
└────────────────────────────────────────┘
	│
	├─ Validation Failed
	│  └─► Show Error Message
	│      └─► Abort Operation
	│
	└─ Validation Passed
		│
		▼
BUSINESS LOGIC LAYER
┌────────────────────────────────────────┐
│ Processing                             │
├────────────────────────────────────────┤
│ - Filter meals (FilterMealsByName)     │
│ - Load meals (LoadMealsForDate)        │
│ - Create UI (CreateMealComponent)      │
│ - Display details (DisplayMealDetails) │
│ - Toggle mode (EnableEditMode)         │
└────────────────────────────────────────┘
	│
	▼
DATA ACCESS LAYER
┌────────────────────────────────────────┐
│ Database Operations                    │
├────────────────────────────────────────┤
│ - Meal_BLL.Show_MealsByDate()          │
│ - Meal_BLL.Update_Meal()               │
└────────────────────────────────────────┘
	│
	▼
DATABASE LAYER
┌────────────────────────────────────────┐
│ SQL Server [Meal] Table                │
├────────────────────────────────────────┤
│ - SELECT queries                       │
│ - UPDATE queries                       │
└────────────────────────────────────────┘
	│
	▼
OUTPUT LAYER
┌────────────────────────────────────────┐
│ Response to User                       │
├────────────────────────────────────────┤
│ - Update meal cards display            │
│ - Populate/clear details panel         │
│ - Show success/error messages          │
│ - Change button states                 │
│ - Enable/disable fields                │
└────────────────────────────────────────┘
```

---

**Note**: These diagrams represent the complete architecture and flow of the Edit_Meal feature implementation.

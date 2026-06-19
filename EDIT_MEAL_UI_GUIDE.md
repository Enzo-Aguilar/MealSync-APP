# Edit_Meal Form - User Interface Guide

## Form Layout

```
┌─────────────────────────────────────────────────────────────────────────────┐
│ Editar_Refeicoes                                                            │
├─────────────────────────────────────────────────────────────────────────────┤
│ DatePicker [Today ▼]  |  Procurar: [___search_____]                        │
├──────────────────────────────┬───────────────────────────────────────────────┤
│                              │  SIDE PANEL - SELECTED MEAL DETAILS          │
│  MEAL CARDS PANEL            │                                              │
│                              │  [Meal Image]                                │
│  ┌─────────────────────────┐ │  Nome: [____________________]               │
│  │  Refeição 1             │ │  Descrição: [_______________]               │
│  │  [Image]                │ │  Tipo: [Vegetariano ▼]                      │
│  │  Nome: Frango           │ │  Preço: [________]                          │
│  │  Tipo: Carne            │ │  Data: [MM/DD/YYYY ▼]                       │
│  │  Preço: €5.50           │ │                                              │
│  │  Data: 15/01/2025       │ │                                              │
│  │  ✓ Editável             │ │                                              │
│  └─────────────────────────┘ │                                              │
│                              │                                              │
│  ┌─────────────────────────┐ │                                              │
│  │  Refeição 2             │ │                                              │
│  │  [Image]                │ │                                              │
│  │  Nome: Peixe            │ │                                              │
│  │  Tipo: Peixe            │ │                                              │
│  │  Preço: €6.00           │ │                                              │
│  │  Data: 14/01/2025       │ │                                              │
│  │  ✗ Não Editável         │ │                                              │
│  └─────────────────────────┘ │                                              │
│                              │                                              │
│  ┌─────────────────────────┐ │                                              │
│  │  Refeição 3             │ │                                              │
│  │  [Image]                │ │                                              │
│  │  Nome: Salada           │ │                                              │
│  │  Tipo: Vegetariano      │ │                                              │
│  │  Preço: €4.50           │ │                                              │
│  │  Data: 20/01/2025       │ │                                              │
│  │  ✓ Editável             │ │                                              │
│  └─────────────────────────┘ │                                              │
│                              │                                              │
├──────────────────────────────┴───────────────────────────────────────────────┤
│  [  Editar  ]               [  Atualizar  ]                                 │
└─────────────────────────────────────────────────────────────────────────────┘
```

## Meal Card Colors

| Color | Meaning | Behavior |
|-------|---------|----------|
| **Light Green** | Editable (7+ days advance) | Clickable, hover effect, can edit |
| **Light Gray** | Not Editable (< 7 days) | Grayed out, disabled, read-only |
| **Light Cyan** | Currently Selected | Highlighted to show selection |
| **Light Blue** | Hover State | Shows on mouse hover for editable cards |

## Button States

### Editar Button
- **Initial State**: Shows "Editar" (Gray, enabled)
- **On Click with Changes**: Enters edit mode
  - Button text changes to "Cancelar"
  - All input fields become editable
  - Atualizar button becomes enabled
- **On Click with No Changes**: Shows warning dialog
  - "Nenhuma alteração foi detectada..."
  - Remains in view mode
- **On Click in Edit Mode**: Cancels editing
  - Button text changes back to "Editar"
  - Fields return to read-only
  - Changes are discarded

### Atualizar Button
- **Initial State**: Disabled (Grayed)
- **After Edit Clicked**: Enabled (if in edit mode with changes)
- **On Click**: 
  - Validates all fields
  - Updates database
  - Shows success message
  - Refreshes meal list
  - Returns to view mode

## User Interactions

### 1. Selecting a Different Date
```
Click DatePicker1 ▼
Select new date
↓
Meal cards for that date load automatically
```

### 2. Searching for a Meal
```
Type in tbSearch textbox
↓
Meal cards filter in real-time
Only matching meals displayed (case-insensitive)
```

### 3. Selecting a Meal
```
Click on meal card (only if editable or just to view)
↓
Selected meal highlighted in Light Cyan
Details populate in right side panel
Image loads in pictureBoxMealImage
All fields populate (read-only initially)
```

### 4. Entering Edit Mode
```
Click "Editar" button
↓
System checks if meal is editable (7+ days)
System checks if any changes were made
↓
If not editable: Error message shown
If no changes: Warning message shown
If valid: Edit mode activated
  - Fields become editable
  - Button text changes to "Cancelar"
  - Atualizar button becomes enabled
```

### 5. Changing Image
```
Click pictureBoxMealImage (only in edit mode)
↓
If not in edit mode: Warning shown
If in edit mode: File dialog opens
Select image file
↓
Image loads in picture box
```

### 6. Saving Changes
```
Modify meal details
Click "Atualizar" button
↓
All fields validated:
  - Name: required, max 100 chars
  - Description: max 255 chars
  - Date: 7+ days in future
  - Price: positive number
  - Type: required
↓
If validation fails: Error message shows (field that failed)
If validation passes: 
  - Database updates
  - Success message shown
  - Meal list refreshes
  - Fields return to read-only
  - Button text changes back to "Editar"
```

## Error Messages and Warnings

### ⚠️ Warning Messages
- "Por favor selecione uma refeição." - No meal selected
- "Nenhuma alteração foi detectada. Por favor, altere pelo menos um campo." - Edit clicked with no changes

### ❌ Error Messages
- "Apenas refeições com pelo menos 7 dias de antecedência podem ser editadas." - Trying to edit < 7 days
- "O nome da refeição é obrigatório" - Empty name
- "O nome da refeição deve conter no máximo 100 caracteres" - Name too long
- "A descrição da refeição é obrigatória" - Empty description
- "A descrição da refeição deve conter no máximo 255 caracteres" - Description too long
- "Não pode criar refeição para dias passados" - Date in past
- "Não pode criar refeição para o dia atual" - Date is today
- "Refeições devem ser criadas com pelo menos 7 dias de antecedência..." - Date < 7 days
- "O preço da refeição é obrigatório" - Empty price
- "O preço da refeição não pode ser negativo" - Negative price
- "Por favor selecione um tipo de refeição." - No type selected
- "Preço inválido. Use um valor numérico válido." - Invalid price format

### ✅ Success Messages
- "Refeição atualizada com sucesso!" - Update succeeded
- "Erro ao atualizar refeição." - Update failed in database

## Keyboard Shortcuts & Tips

- **DatePicker**: Use arrow keys or dropdown
- **Search**: Start typing to filter (real-time)
- **Tab**: Navigate between fields in edit mode
- **Enter**: In search box, proceeds to next field

## State Transitions

```
INITIAL STATE
	↓
Form Loads (Meals for today shown)
	↓
User can:
  1. Change date → Reload meals for new date
  2. Search → Filter current meals
  3. Click card → Display details (read-only)
	↓
VIEW MODE (Meal selected)
	↓
Click "Editar" button
	├─ No meal selected → Warning
	├─ Not editable (< 7 days) → Error
	├─ No changes detected → Warning
	└─ Valid → Enter EDIT MODE
	↓
EDIT MODE
	↓
User can:
  1. Modify fields → Enter text
  2. Change image → Click picture box
  3. Cancel → Click "Cancelar" button → Return to VIEW MODE
  4. Save → Click "Atualizar" button
	├─ Validation fails → Show error, stay in EDIT MODE
	└─ Validation passes → Update database → Return to VIEW MODE
```

## Field Validation Rules

| Field | Required | Min | Max | Format | Notes |
|-------|----------|-----|-----|--------|-------|
| Nome | Yes | - | 100 chars | Text | Meal name |
| Descrição | Yes | - | 255 chars | Text | Multi-line ok |
| Tipo | Yes | - | - | Dropdown | Vegetariano, Peixe, Carne |
| Preço | Yes | - | - | Numeric | Must be positive, € format |
| Data | Yes | - | - | DateTime | Must be 7+ days from today |
| Image | No | - | - | JPG/PNG/BMP/GIF | Optional, clickable in edit mode |

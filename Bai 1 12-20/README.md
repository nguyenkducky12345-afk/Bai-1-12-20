# Student Management System - README

## Overview
This is a Windows Forms application for managing student information with BindingSource data binding, avatar image handling, and CSV export functionality.

## Features

### 1. Student Data Management
- **View Students**: Display all students in a DataGridView
- **Add Students**: Create new student records with ID, Full Name, Age, and Gender
- **Update Students**: Modify existing student information
- **Delete Students**: Remove student records with confirmation

### 2. Data Display & Binding
- **BindingSource**: Used to synchronize data between DataGridView and edit controls
- **Automatic Sync**: Selecting a row in DataGridView automatically populates the edit form fields
- **Live Binding**: Changes in edit controls are reflected through BindingSource

### 3. Avatar Management
- **Choose Avatar Button**: Opens file dialog to select image (JPG, PNG, BMP, GIF)
- **Preview Avatar**: Selected image displays in PictureBox
- **File Path Storage**: Avatar path is stored with student data
- **Error Handling**: Validates file existence before loading

### 4. CSV Export
- **Export Function**: Export all students to CSV file
- **Proper Formatting**: Implements RFC 4180 CSV standard
- **Special Character Handling**: Automatically escapes commas, quotes, and newlines in student names
- **UTF-8 Encoding**: Supports Vietnamese and international characters

## User Interface

### Left Section (DataGridView)
- Displays list of all students
- Columns: Student ID, Full Name, Age, Gender, Avatar Path
- Click on any row to select and display in edit form

### Middle Section (Edit Form)
- **Student ID**: Read-only field (set when adding)
- **Full Name**: Text input for student name
- **Age**: Numeric input for age
- **Gender**: Dropdown selector (Male, Female, Other)

### Right Section (Avatar & Buttons)
- **Avatar Preview**: Picture box showing selected student's avatar
- **Choose Avatar**: Button to select new avatar image
- **Add**: Create new student record
- **Update**: Save changes to selected student
- **Delete**: Remove selected student
- **Export CSV**: Save all students to CSV file

## Usage Steps

### Adding a Student
1. Fill in Student ID, Full Name, Age, and Gender in the edit form
2. (Optional) Click "Choose Avatar" to select an image
3. Click "Add" button
4. New student will appear in the DataGridView

### Editing a Student
1. Click on a student row in the DataGridView
2. Modify information in the edit form fields
3. (Optional) Click "Choose Avatar" to change avatar
4. Click "Update" button to save changes

### Deleting a Student
1. Click on a student row in the DataGridView
2. Click "Delete" button
3. Confirm deletion in the dialog

### Exporting to CSV
1. Click "Export CSV" button
2. Choose location and filename
3. File will be saved with all student data in CSV format

## Sample Data
The application loads with 4 sample students:
- SV001: Nguyễn Văn A (Male, Age 20)
- SV002: Trần Thị B (Female, Age 21)
- SV003: Hoàng Văn C (Male, Age 19)
- SV004: Phạm Thị D (Female, Age 22)

## Technical Details

### Project Structure
- **Student.cs**: Data model with properties and CSV export logic
- **Form1.cs**: Main form logic and event handlers
- **Form1.Designer.cs**: UI controls layout

### BindingSource Implementation
The BindingSource acts as a binding manager between:
- Student list (data source)
- DataGridView (display)
- TextBoxes, ComboBox, PictureBox (edit controls)

When a row is selected in DataGridView, the BindingSource automatically updates all bound controls to show that student's data.

### CSV Export Format
Header: `StudentId,FullName,Age,Gender,AvatarPath`

Example data row:
```
SV001,"Nguyễn Văn A",20,Male,C:\path\to\avatar.jpg
```

Fields with special characters are automatically quoted and internal quotes are escaped.

## System Requirements
- .NET 10
- Windows Forms
- Windows OS

## Notes
- Avatar files must exist on the file system for loading
- Age field must be a valid integer
- Student ID and Full Name are required for adding new students
- CSV file is encoded in UTF-8 for proper Vietnamese character support

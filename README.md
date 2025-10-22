# GettingStarted-WF-FontComboBox
This repository contains the sample that how to use the WF FontComboBox and its properties. The **FontComboBox** is a specialized ComboBox control provided by Syncfusion for WinForms applications. It is designed to automatically populate the list with all fonts installed on the system, making it easy for users to select and apply different font styles in their applications. Each entry in the FontComboBox is displayed using its corresponding font style, providing a visual preview of the font directly in the dropdown list.
## Key Features
- **Automatic Font Loading**: When the control is initialized, it automatically fills the list with all installed fonts.
- **Visual Representation**: Each font name is rendered using its own style, giving users an instant preview.
- **Manual Refresh**: If fonts are installed or removed after the control is loaded, you can call the Fill() method to refresh the list.
## Why Use FontComboBox?
FontComboBox simplifies font selection in applications such as:
- Text editors  
- Design tools  
- Document formatting interfaces
## Example Usage
To use FontComboBox in your WinForms application, simply add the control to your form. 
```csharp
this.Controls.Add(fontComboBox);
```
For more details, refer to the official Syncfusion Knowledge Base article:
🔗 [What is FontComboBox](https://www.syncfusion.com/kb/1536/what-is-a-fontcombobox-control).
This control is ideal for applications that require an intuitive and visually rich font selection experience.

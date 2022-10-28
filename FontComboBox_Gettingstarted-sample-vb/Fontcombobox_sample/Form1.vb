Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Fontcombobox_sample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			'Initialize the FontComboBox control.
			Dim fontComboBox As New FontComboBox()
			fontComboBox.Size = New Size(150, 40)
			fontComboBox.Location = New Point(100, 100)
			fontComboBox.VisualStyle = ThemedComboBoxStyles.Office2016Colorful
			fontComboBox.UseAutoComplete = True
			fontComboBox.SelectedItem = "Arial"
			Me.Controls.Add(fontComboBox)
		End Sub
	End Class
End Namespace

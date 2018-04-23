Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEdit1_Properties_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs) Handles comboBoxEdit1.Properties.MouseWheel
			CType(e, DXMouseEventArgs).Handled = True
		End Sub
	End Class
End Namespace
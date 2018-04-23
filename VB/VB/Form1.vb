Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = DataGenerator.GetData()
			AddHandler gridControl1.ViewRegistered, AddressOf gridControl1_ViewRegistered
			AddHandler gridView1.MasterRowEmpty, AddressOf gridView1_MasterRowEmpty
			gridView1.OptionsDetail.AllowExpandEmptyDetails = True
		End Sub

		Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As MasterRowEmptyEventArgs)
			e.IsEmpty = False
		End Sub

		Private Sub gridControl1_ViewRegistered(ByVal sender As Object, ByVal e As ViewOperationEventArgs)
			TryCast(e.View, GridView).OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
		End Sub
	End Class
End Namespace
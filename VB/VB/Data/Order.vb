Imports Microsoft.VisualBasic
Imports System

Namespace WindowsApplication1
	Public Class Order

		Public Sub New()

		End Sub

		Private _Date As DateTime
		Public Property [Date]() As DateTime
			Get
				Return _Date
			End Get
			Set(ByVal value As DateTime)
				_Date = value
			End Set
		End Property

		Private _ProductName As String
		Public Property ProductName() As String
			Get
				Return _ProductName
			End Get
			Set(ByVal value As String)
				_ProductName = value
			End Set
		End Property

		Private _Amount As Decimal
		Public Property Amount() As Decimal
			Get
				Return _Amount
			End Get
			Set(ByVal value As Decimal)
				_Amount = value
			End Set
		End Property

	End Class
End Namespace

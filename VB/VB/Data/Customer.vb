Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Text

Namespace WindowsApplication1
	Public Class Customer

		Public Sub New()

		End Sub

		Private _FirstName As String
		Public Property FirstName() As String
			Get
				Return _FirstName
			End Get
			Set(ByVal value As String)
				_FirstName = value
			End Set
		End Property

		Private _LastName As String
		Public Property LastName() As String
			Get
				Return _LastName
			End Get
			Set(ByVal value As String)
				_LastName = value
			End Set
		End Property


		Private _Orders As New BindingList(Of Order)()
		Public Property Orders() As BindingList(Of Order)
			Get
				Return _Orders
			End Get
			Set(ByVal value As BindingList(Of Order))
				_Orders = value
			End Set
		End Property
	End Class

	Public NotInheritable Class DataGenerator
		 Private Shared random As New Random()
		Private Sub New()
		End Sub
		Private Shared Function RandomString(ByVal size As Integer, ByVal lowerCase As Boolean) As String
			Dim builder As New StringBuilder()
			Dim ch As Char
			For i As Integer = 0 To size - 1
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)))
				builder.Append(ch)
			Next i
			If lowerCase Then
				Return builder.ToString().ToLower()
			End If
			Return builder.ToString()
		End Function

		Private Shared Function GetRandomName() As String
			Return RandomString(1, False) + RandomString(5, True)
		End Function
		Public Shared Function GetData() As Object

			Dim customers As New BindingList(Of Customer)()
			For i As Integer = 0 To random.Next(20, 100) - 1
				Dim customer As New Customer()
				customers.Add(customer)
				customer.FirstName = GetRandomName()
				customer.LastName = GetRandomName()
				For j As Integer = 0 To random.Next(20,100) - 1
					Dim order As New Order()
					customer.Orders.Add(order)
					order.Amount = random.Next(10000)
					order.Date = DateTime.Now.AddDays(500 - random.Next(1000))
					order.ProductName = GetRandomName()
				Next j
			Next i
			Return customers
		End Function
	End Class
End Namespace

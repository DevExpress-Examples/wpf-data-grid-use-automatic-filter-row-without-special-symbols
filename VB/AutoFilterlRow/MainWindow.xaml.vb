Imports DevExpress.Data.Filtering
Imports DevExpress.Xpf.Grid
Imports System.Windows

Namespace AutoFilterlRow

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.grid1.ItemsSource = Data.GetData()
        End Sub
    End Class

    Public Class NewTableView
        Inherits TableView

        Protected Overrides Function CreateAutoFilterCriteria(ByVal fieldName As String, ByVal condition As AutoFilterCondition, ByVal value As Object) As CriteriaOperator
            If condition = AutoFilterCondition.Equals Then
                Return MyBase.CreateAutoFilterCriteria(fieldName, condition, value)
            End If

            Dim strValue As String = value.ToString()
            If String.IsNullOrEmpty(strValue) Then Return Nothing
            If condition = AutoFilterCondition.Contains Then
                Return New FunctionOperator(FunctionOperatorType.Contains, New OperandProperty(fieldName), strValue)
            Else
                Return New FunctionOperator(FunctionOperatorType.StartsWith, New OperandProperty(fieldName), strValue)
            End If
        End Function
    End Class
End Namespace

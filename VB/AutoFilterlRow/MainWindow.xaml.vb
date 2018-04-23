Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Grid
Imports DevExpress.Data.Filtering

Namespace AutoFilterlRow
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid1.ItemsSource = Data.GetData()
        End Sub
    End Class

    Public Class NewTableView
        Inherits TableView

        Protected Overrides Function CreateAutoFilterCriteria(ByVal fieldName As String, ByVal condition As AutoFilterCondition, ByVal value As Object) As CriteriaOperator
            If condition = AutoFilterCondition.Equals Then
                Return MyBase.CreateAutoFilterCriteria(fieldName, condition, value)
            End If
            Dim strValue As String = value.ToString()
            If String.IsNullOrEmpty(strValue) Then
                Return Nothing
            End If
            If condition = AutoFilterCondition.Contains Then
                Return New FunctionOperator(FunctionOperatorType.Contains, New OperandProperty(fieldName), strValue)
            Else
                Return New FunctionOperator(FunctionOperatorType.StartsWith, New OperandProperty(fieldName), strValue)
            End If
        End Function
    End Class


End Namespace

﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace AutoFilterlRow
    Public Class Data
        Public Shared Function GetData() As List(Of Element)
            Dim list As New List(Of Element)()
            For i As Integer = 0 To 4
                list.Add(New Element() With {.Name = "Element_" & i, .Value = "%" & i & "_%"})
                list.Add(New Element() With {.Name = "%Element_" & (i + 5), .Value = "_" & (i + 5) & "%"})
                list.Add(New Element() With {.Name = "_Element_" & (i + 10), .Value = "%" & (i + 10) & "_"})
            Next i
            Return list
        End Function
    End Class

    Public Class Element
        Public Property Name() As String
        Public Property Value() As String
    End Class
End Namespace

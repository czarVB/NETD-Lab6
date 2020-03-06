'****************************************************************
'* Name: Evan Heath
'* Date: April 19th, 2019
'* Program Name: frmTextEditor
'* Purpose: A class used to hold the text editor form and its variables
'****************************************************************

Option Strict On

Public Class frmTextEditor

    Public saved As Boolean = True
    Public fileLocation As String = String.Empty

    Private Sub txtContent_TextChanged(sender As Object, e As EventArgs) Handles txtContent.TextChanged
        saved = False
    End Sub

End Class

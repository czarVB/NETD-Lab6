'****************************************************************
'* Name: Evan Heath
'* Date: April 19th, 2019
'* Program Name: NETD-2202 Final Project: MDI Text Editor
'* Purpose: A text editor that can open and edit multiple files at the same time using MDI
'****************************************************************

Option Strict On
Imports System.IO

Public Class frmPrimary

    Private Sub tsmiNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        Dim newEditor As New frmTextEditor
        newEditor.MdiParent = Me
        newEditor.Show()
    End Sub

    Private Sub tsmiOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim newEditor As New frmTextEditor
            newEditor.MdiParent = Me

            Dim reader As New StreamReader(OpenFileDialog1.FileName)
            newEditor.txtContent.Text = reader.ReadToEnd
            reader.Close()

            newEditor.fileLocation = OpenFileDialog1.FileName
            newEditor.Text = OpenFileDialog1.FileName
            newEditor.Show()
        End If
    End Sub

    Private Sub tsmiSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            Dim toSave As frmTextEditor = DirectCast(Me.ActiveMdiChild, frmTextEditor)
            If Not toSave.saved Then
                SaveFile(toSave, toSave.fileLocation = String.Empty)
            End If
        End If
    End Sub

    Private Sub tsmiSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            SaveFile(DirectCast(Me.ActiveMdiChild, frmTextEditor), True)
        End If
    End Sub

    Private Sub tsmiClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        If SaveProcedure() And Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub tsmiExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim allSaved As Boolean = True
        If Me.MdiChildren.Length > 0 Then
            For i As Integer = 0 To Me.MdiChildren.Length
                If TypeOf Me.MdiChildren(i) Is frmTextEditor Then
                    Dim currentChild As frmTextEditor = DirectCast(Me.MdiChildren(i), frmTextEditor)
                    allSaved = allSaved And currentChild.saved
                End If
            Next
        End If

        If Not allSaved Then
            Dim Warning As MsgBoxResult = MsgBox("You have unsaved documents, are you sure you want to exit?", MsgBoxStyle.YesNo, "Before you Exit.")
            If Warning = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub tsmiCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        Dim txtEdit As New frmTextEditor
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            If txtEdit.txtContent.SelectedText IsNot String.Empty Then
                My.Computer.Clipboard.SetText(txtEdit.txtContent.SelectedText)
            End If
            txtEdit.txtContent.SelectedText = String.Empty
        End If
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            Dim txtEdit As frmTextEditor = DirectCast(Me.ActiveMdiChild, frmTextEditor)
            If txtEdit.txtContent.SelectedText IsNot String.Empty Then
                My.Computer.Clipboard.SetText(txtEdit.txtContent.SelectedText)
            End If
        End If
    End Sub

    Private Sub tsmiPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            Dim txtEdit As frmTextEditor = DirectCast(Me.ActiveMdiChild, frmTextEditor)
            txtEdit.txtContent.SelectedText = My.Computer.Clipboard.GetText()
        End If
    End Sub

    Private Sub tsmiCascade_Click(sender As Object, e As EventArgs) Handles mnuCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub tsmiHorizontal_Click(sender As Object, e As EventArgs) Handles mnuHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub tsmiVertical_Click(sender As Object, e As EventArgs) Handles mnuVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub tsmiAverage_Click(sender As Object, e As EventArgs) Handles mnuAverage.Click
        Dim newAverage As New frmShippingAverage
        newAverage.MdiParent = Me
        newAverage.Show()
    End Sub

    Public Sub OpenTextEditor(ByVal file As String)

        Dim newEditor As New frmTextEditor
        newEditor.MdiParent = Me
        newEditor.Show()

        If file IsNot String.Empty Then
            Dim reader As New StreamReader(file)
            newEditor.txtContent.Text = reader.ReadToEnd
        End If
    End Sub

    Public Function SaveProcedure() As Boolean
        ' Is the sctive MDI child a frmTextEditor
        If TypeOf Me.ActiveMdiChild Is frmTextEditor Then
            ' Is the file already saved
            Dim active As frmTextEditor = DirectCast(Me.ActiveMdiChild, frmTextEditor)
            If Not active.saved Then
                Dim protocol As MsgBoxResult = MsgBox("Do you want to save the file currently open?", MsgBoxStyle.YesNoCancel, "Save file?")
                If protocol = MsgBoxResult.Yes Then
                    SaveFile(active, False)
                    Return True
                Else
                    Return protocol = MsgBoxResult.No
                End If
            Else
                Return True
            End If
        Else
            Return True
        End If
        Return False
    End Function

    Public Sub SaveFile(ByVal window As frmTextEditor, ByVal saveAs As Boolean)

        If window.fileLocation = String.Empty Or saveAs Then
            ' Set a filter to find a file that is a txt file
            SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
            If Not SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Return
            End If
        End If

        Try
            ' Write the text to the file
            My.Computer.FileSystem.WriteAllText(window.fileLocation, window.txtContent.Text, False)
        Catch exc As Exception
            Console.WriteLine(exc.ToString())
        End Try
        window.saved = True
        window.fileLocation = SaveFileDialog1.FileName
        window.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub tsmiAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim wndw As MsgBoxResult = MsgBox("NETD-2202 Lab 6: MDI Text Editor | By: Evan Heath", MsgBoxStyle.OkOnly, "About")
    End Sub
End Class

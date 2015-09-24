Imports System.IO

Public Class Form1

    Private Property overwrite As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Setup message box for exit event
        Dim result = MessageBox.Show("Are you sure that you would like to quit? Have you backed up your files?", _
                                     "Quik Backup - Quit", _
                                     MessageBoxButtons.YesNo, _
                                     MessageBoxIcon.Question)

        ' If the Yes button was pressed... 
        If result = DialogResult.Yes Then
            ' Cancel the closure of the form.
            disclaimer.Close()
            Close()
        End If
    End Sub

    ' Define function for copying files
    Private Sub fileCopy(filePath1 As String, filePath2 As String)
        If My.Computer.FileSystem.DirectoryExists(filePath1) = False OrElse filePath1.Length = 0 Then
            MessageBox.Show("No Files/Data were selected for backup! Please select a folder!", "ERROR!", MessageBoxButtons.OK)
        Else
            My.Computer.FileSystem.CopyDirectory(filePath1, filePath2, showUI:=FileIO.UIOption.AllDialogs, onUserCancel:=FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Your backup is located in " & filePath2, "BACKUP SUCCESSFUL!", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnBackupNow_Click(sender As Object, e As EventArgs) Handles btnBackupNow.Click

        ' Define Variables used to hold filepaths.
        Dim strPath1 As String = txtSource.Text
        Dim strPath2 As String

        ' Check which option is checked, make a decision on destination path based off it.
        ' If ToServer, destination path = Quikbackup folder in remote documents
        ' If ToUSB, ask for USB path, add Quikbackup
        If radServer.Checked = True Then
            If Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) = "TEMP" Then
                Dim strUserName As String = InputBox("Username was TEMP, Please input real username", "Quik Backup - Error: Bad username")
                strPath2 = "\\atec.net\dw\dev\" & strUserName & "\Documents\Your QuikBackup "
            Else
                strPath2 = "\\atec.net\dw\dev\" & Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) & "\Documents\Your QuikBackup "
            End If
        ElseIf radUSB.Checked = True Then
            If Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) = "TEMP" Then
                Dim strUserName As String = InputBox("Username was TEMP, Please input real username", "Quik Backup - Error: Bad username")
                FolderBrowserDialog1.SelectedPath = "\\atec.net\dw\dev\" & strUserName & "\Desktop"
            Else
                FolderBrowserDialog1.SelectedPath = "\\atec.net\dw\dev\" & Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) & "\Desktop"
            End If
            FolderBrowserDialog1.ShowDialog()
            strPath2 = FolderBrowserDialog1.SelectedPath & "Your Quikbackup"
        End If
        fileCopy(strPath1, strPath2)
    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        ' Show file browser, obtain directory path from file browser.
        ' Dependant on which radio button is in use.
        If radServer.Checked = True Then
            If Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) = "TEMP" Then
                Dim strUserName As String = InputBox("Username was TEMP, Please input real username", "Quik Backup - Error: Bad username")
                FolderBrowserDialog1.SelectedPath = "\\atec.net\dw\dev\" & strUserName & "\Desktop"
            Else
                FolderBrowserDialog1.SelectedPath = "\\atec.net\dw\dev\" & Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) & "\Desktop"
            End If
        ElseIf radUSB.Checked = True Then
            If Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) = "TEMP" Then
                Dim strUserName As String = InputBox("Username was TEMP, Please input real username", "Quik Backup - Error: Bad username")
                FolderBrowserDialog1.SelectedPath = "\\atec.net\dw\dev\" & strUserName & "\Documents"
            Else
                FolderBrowserDialog1.SelectedPath = "\\atec.net\dw\dev\" & Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) & "\Documents"
            End If
        End If
        FolderBrowserDialog1.ShowDialog()
        txtSource.Text = FolderBrowserDialog1.SelectedPath
    End Sub

#Region "Calls made necessary for runtime"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Function DestinationFile() As String
        Throw New NotImplementedException
    End Function

    Private Function tbResults() As Object
        Throw New NotImplementedException
    End Function

#End Region



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Show about box.
        AboutBox1.Show()
    End Sub

    Private Sub radServer_CheckedChanged(sender As Object, e As EventArgs) Handles radServer.CheckedChanged
        ' Changing label text when radio button is selected
        If radServer.Checked = True Then
            Label1.Text = "Location of your" & vbCrLf & "USB/Flash Drive"
        ElseIf radUSB.Checked = True Then
            Label1.Text = "Location of your" & vbCrLf & "Network Drive"
        End If
    End Sub
End Class

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
            ' cancel the closure of the form.
            disclaimer.Close()
            Close()
        End If
    End Sub

    Private Sub btnBackupNow_Click(sender As Object, e As EventArgs) Handles btnBackupNow.Click

        ' Define Variables used to hold filepaths.
        Dim strPath1 As String = txtSource.Text
        Dim strPath2 As String

        ' If the UserName is seen as "TEMP", ask for the real UserName. Set strPath2 as user's program documents path.
        If Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) = "TEMP" Then
            Dim strUserName As String = InputBox("Username was TEMP, Please input real username", "Quik Backup - Error: Bad username")
            strPath2 = "\\atec.net\dw\dev\" & strUserName & "\Documents\Your QuikBackup "
        Else
            strPath2 = "\\atec.net\dw\dev\" & Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(0, 9) & "\Documents\Your QuikBackup "
        End If

        ' Check to make sure the directory is real before attempting backup. If not, return error.
        If My.Computer.FileSystem.DirectoryExists(strPath1) = False OrElse strPath1.Length = 0 Then
            MessageBox.Show("No Files/Data were selected for backup! Please select a folder!", "ERROR!", MessageBoxButtons.OK)
        Else
            My.Computer.FileSystem.CopyDirectory(strPath1, strPath2, showUI:=FileIO.UIOption.AllDialogs, onUserCancel:=FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Your backup is located in a folder called 'Your QuikBackup' in your 'Documents Storage' folder!", "BACKUP SUCCESSFUL!", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btnSource_Click(sender As Object, e As EventArgs) Handles btnSource.Click
        ' Show file browser, obtain directory path from file browser
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
        AboutBox1.Show()
        'Brian Makewit
    End Sub
End Class

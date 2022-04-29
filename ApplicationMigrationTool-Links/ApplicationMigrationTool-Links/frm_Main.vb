Imports System.IO
Imports ApplicationMigrationTool_Links.Program.Classes

Public Class frm_Main
    Dim Application As New Application_PendingInterfaces

    Private Sub btn_Path_Click(sender As Object, e As EventArgs) Handles btn_Path.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "CSV|*.csv"
        Dim Result As DialogResult = OpenFile.ShowDialog()
        If Result = Windows.Forms.DialogResult.OK Then
            txt_Path.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub btn_OpenFile_Click(sender As Object, e As EventArgs) Handles btn_OpenFile.Click
        Application.OpenFile(txt_Path.Text)
        rtb_Text.Text = Application.File_Text
    End Sub

    Private Sub txt_Path_TextChanged(sender As Object, e As EventArgs) Handles txt_Path.TextChanged
        Dim FileExist As Boolean = IO.File.Exists(txt_Path.Text)
        If FileExist Then
            btn_OpenFile.Enabled = True
        Else
            btn_OpenFile.Enabled = False
        End If
    End Sub

    Private Sub btn_ConvertToList_Click(sender As Object, e As EventArgs) Handles btn_ConvertToList.Click
        Application.ListObjectFromString()
        rtb_Text.Text = Application.OutPutString
        dgv_DataTable.DataSource = Application.DT
    End Sub
End Class

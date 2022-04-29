Imports System.IO
Namespace Program.Classes
    Public Class Application_PendingInterfaces
        Property File_Text As String
        Property List_Objects As List(Of String)
        Property OutPutString As String
        Property DT As New DataTable
        Sub OpenFile(ByVal _path As String)
            File_Text = File.ReadAllText(_path)
        End Sub
        Sub ListObjectFromString()
            DT = New DataTable
            Dim vs As String() = File_Text.Split(vbCrLf.ToString)
            List_Objects = vs.ToList()
            List_Objects.RemoveAt(0)
            For Each Column As String In List_Objects(0).Split(",")
                DT.Columns.Add(Column)
            Next
            Dim i = 1
            While List_Objects(i) IsNot ""
                DT.Rows.Add(List_Objects(i).Split(","))
                i += 1
            End While
            OutPutString = String.Join(vbCrLf, List_Objects)
        End Sub
    End Class
End Namespace
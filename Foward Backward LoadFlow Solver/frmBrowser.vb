Public Class frmBrowser
    Private Function loadTable()
        Dim con As New OleDb.OleDbConnection
        Dim READER As OleDb.OleDbDataReader
        Dim COMMAND As OleDb.OleDbCommand
        con.ConnectionString = Project.connectionString
        listModels.Items.Clear()

        If cmbType.Text = "" Or cmbType.Text = "Transmission Lines" Then
            Try
                con.Open()
                COMMAND = New OleDb.OleDbCommand("SELECT * FROM lines WHERE title LIKE '%" & txtSearch.Text.Trim & "%' ORDER BY title", con)
                READER = COMMAND.ExecuteReader
                While READER.Read
                    Dim listArray(4) As String
                    listArray(0) = READER("ID").ToString
                    listArray(1) = "Transmission Lines"
                    listArray(2) = READER("title")
                    listArray(3) = READER("description")

                    Dim listItem As ListViewItem
                    listItem = New ListViewItem(listArray)
                    listModels.Items.Add(listItem)
                End While
                con.Close()
            Catch ex As Exception
                con.Dispose()
            End Try
        End If


    End Function

    Private Sub frmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        loadTable()
    End Sub

    Private Sub listModels_DoubleClick(sender As Object, e As EventArgs) Handles listModels.DoubleClick
        If listModels.SelectedItems.Count > 0 Then
            Dim dbID = Integer.Parse(listModels.FocusedItem.SubItems(0).Text)

            If listModels.FocusedItem.SubItems(1).Text = "Transmission Lines" Then
                Dim result As New Line(dbID)
                Dim line = frmAddLine.ShowDialog(False, result)
                If line.isValid Then
                    line.updateDatabase()
                End If
            End If
        End If
    End Sub
End Class
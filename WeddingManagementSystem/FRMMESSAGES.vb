Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMMESSAGES
    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        With FRMADDMESSAGES
            .GENERATEID()
            .ShowDialog()
            .BTNSEND.Show()
            .CLEAR()
        End With
    End Sub

    Public Sub LOADMESSAGES()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLMESSAGES)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("CONTACT").ToString())
                rowData.Add(document("DATE").ToString())
                rowData.Add(document("SUBJECT").ToString())
                rowData.Add(document("MESSAGES").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        FRMMAIN.Hide()
        FRMLOGIN.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "VIEW" Then
            With FRMADDMESSAGES
                .BTNSEND.Hide()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCONTACT.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTDATE.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTSUBJECT.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTMESSAGES.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub BTNSEARCH_Click(sender As Object, e As EventArgs)
        If TXTSEARCH.Text = "" Then
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLMESSAGES)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("NAME", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("ID").ToString())
                    rowData.Add(document("NAME").ToString())
                    rowData.Add(document("CONTACT").ToString())
                    rowData.Add(document("DATE").ToString())
                    rowData.Add(document("SUBJECT").ToString())
                    rowData.Add(document("MESSAGES").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next

            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADMESSAGES()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLMESSAGES)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("NAME", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("ID").ToString())
                    rowData.Add(document("NAME").ToString())
                    rowData.Add(document("CONTACT").ToString())
                    rowData.Add(document("DATE").ToString())
                    rowData.Add(document("SUBJECT").ToString())
                    rowData.Add(document("MESSAGES").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                'MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
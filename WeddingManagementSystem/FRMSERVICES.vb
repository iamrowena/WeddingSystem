Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMSERVICES
    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles BTNADDPACK.Click
        With FRMADDPACKAGE
            .BTNSAVE.Show()
            .BTNUPDATE.Hide()
            '.GENERATEID()
            .Show()
            .CLEAR()
        End With
    End Sub

    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        FRMMAIN.Hide()
        FRMLOGIN.Show()
    End Sub
    Public Sub LOADPACKAGES()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("PRICE").ToString())
                rowData.Add(document("DESCRIPTION").ToString())

                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "SEDIT" Then
            With FRMADDPACKAGE
                .BTNSAVE.Hide()
                .BTNUPDATE.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTDESCRIPTION.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTPRICE.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "SDELETE" Then
            If MsgBox("Delete this Package " & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                'save to tbldelte
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection1 As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLDELETE)
                Dim document As New BsonDocument()
                document.Add("ID", DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                document.Add("NAME", DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
                document.Add("DESCRIPTION", DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
                document.Add("PRICE", DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
                collection1.InsertOne(document)

                ' delete data from mongodb
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("Package Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LOADPACKAGES()

            End If
        ElseIf colName = "SVIEW" Then
            With FRMADDPACKAGE
                .BTNSAVE.Hide()
                .BTNUPDATE.Hide()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTDESCRIPTION.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTPRICE.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        With FRMADDPACKAGE
            .BTNSAVE.Show()
            .BTNUPDATE.Hide()
            .GENERATEID()
            .ShowDialog()
        End With
    End Sub

    Private Sub TXTSEACH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEACH.TextChanged
        If TXTSEACH.Text = String.Empty Then
            LOADPACKAGES()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("NAME", New BsonRegularExpression(TXTSEACH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim RowData As New List(Of String)()
                    RowData.Add(document("ID").ToString())
                    RowData.Add(document("NAME").ToString())
                    RowData.Add(document("PRICE").ToString())
                    RowData.Add(document("DESCRIPTION").ToString())

                    DataGridView1.Rows.Add(RowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMTASK
    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        FRMMAIN.Hide()
        FRMLOGIN.Show()
    End Sub

    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        With FRMADDTASK
            .BTNSAVE.Show()
            .BTNUPDATE.Hide()
            .LoadClientName()
            .GENERATEID()
            .ShowDialog()
        End With
    End Sub

    Private Sub FRMTASK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADTASK()
    End Sub

    Public Sub LOADTASK()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLTASK)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("CLIENTNO").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("PACKAGE").ToString())
                rowData.Add(document("SERVICES").ToString())
                rowData.Add(document("WED_DETAILS").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "EDIT" Then
            With FRMADDTASK
                .BTNSAVE.Hide()
                .BTNUPDATE.Show()
                .LoadClientName()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTCLIENTNO.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTPACKAGE.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTSERVICES.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTDETAILS.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString

                .ShowDialog()
            End With
        ElseIf colName = "DELETE" Then
            If MsgBox("Are you sure to delete " & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & " task " & DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                'save to tbldelte
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection1 As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLDELETE)
                Dim document As New BsonDocument()
                document.Add("ID", DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                document.Add("CLIENTNO", DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
                document.Add("NAME", DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
                document.Add("PACKAGE", DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
                document.Add("SERVICES", DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
                document.Add("DETAILS", DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                collection1.InsertOne(document)

                ' delete data from mongodb
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLTASK)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("Task Deleted successfully", "Task Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LOADTASK()

            End If
        ElseIf colName = "VIEW" Then
            With FRMADDTASK
                .BTNSAVE.Hide()
                .BTNUPDATE.Hide()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTCLIENTNO.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTPACKAGE.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTSERVICES.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTDETAILS.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADTASK()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLTASK)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("CLIENTNO", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("ID").ToString())
                    rowData.Add(document("CLIENTNO").ToString())
                    rowData.Add(document("NAME").ToString())
                    rowData.Add(document("PACKAGE").ToString())
                    rowData.Add(document("SERVICES").ToString())
                    rowData.Add(document("WED_DETAILS").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
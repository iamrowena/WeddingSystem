Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMAPPOINTMENT
    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADAPPOINTMENT()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLAPPOINTMENTS)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("CLIENTNO", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("ID").ToString())
                    rowData.Add(document("CLIENTNO").ToString())
                    rowData.Add(document("NAME").ToString())
                    rowData.Add(document("CONTACT").ToString())
                    rowData.Add(document("DATE").ToString())
                    rowData.Add(document("TIME").ToString())
                    rowData.Add(document("SUBJECT").ToString())
                    rowData.Add(document("DESCRIPTION").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "EDIT" Then
            With FRMADDAPPOINTMENT
                .LoadClientName()
                .BTNSAVE.Hide()
                .BTNUPDATE.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTCLIENTNO.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTCONTACT.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTDATE.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTTIME.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .TXTSUBJECT.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .TXTDESCRIPTION.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "DELETE" Then
            If MsgBox("Delete this appointment " & DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString & " on " & DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                ' delete data from mongodb
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLAPPOINTMENTS)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("Appointment Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LOADAPPOINTMENT()
            End If
        ElseIf colName = "VIEW" Then
            With FRMADDAPPOINTMENT
                .BTNSAVE.Hide()
                .BTNUPDATE.Hide()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTCLIENTNO.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTCONTACT.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTDATE.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTTIME.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .TXTSUBJECT.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .TXTDESCRIPTION.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Public Sub LOADAPPOINTMENT()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLAPPOINTMENTS)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("CLIENTNO").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("CONTACT").ToString())
                rowData.Add(document("DATE").ToString())
                rowData.Add(document("TIME").ToString())
                rowData.Add(document("SUBJECT").ToString())
                rowData.Add(document("DESCRIPTION").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            'MessageBox.Show("Error database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        With FRMADDAPPOINTMENT
            .BTNSAVE.Show()
            .BTNUPDATE.Hide()
            .CLEAR()
            .GENERATEID()
            .LoadClientName()
            .ShowDialog()
        End With
    End Sub

    Private Sub BTNREFRESH_Click(sender As Object, e As EventArgs) Handles BTNREFRESH.Click
        LOADAPPOINTMENT()
    End Sub

    Private Sub TXTDATE_ValueChanged(sender As Object, e As EventArgs) Handles TXTSEARCHDATE.ValueChanged
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLAPPOINTMENTS)
            Dim filter = Builders(Of BsonDocument).Filter.Regex("DATE", New BsonRegularExpression(TXTSEARCHDATE.Text))
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("CLIENTNO").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("CONTACT").ToString())
                rowData.Add(document("DATE").ToString())
                rowData.Add(document("TIME").ToString())
                rowData.Add(document("SUBJECT").ToString())
                rowData.Add(document("DESCRIPTION").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
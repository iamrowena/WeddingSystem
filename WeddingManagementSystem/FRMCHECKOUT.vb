Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMCHECKOUT
    Private Sub BTNHIDE_Click(sender As Object, e As EventArgs) Handles BTNHIDE.Click
        Me.Hide()
        TXTSEARCH.Clear()
    End Sub

    Private Sub FRMCHECKOUT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADCHECKOUT()
    End Sub
    Public Sub LOADCHECKOUT()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCHECKOUT)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("CLIENTNO").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("DATE").ToString())
                rowData.Add(document("PACKAGE").ToString())
                rowData.Add(document("AMOUNT").ToString())
                rowData.Add(document("TOTALPAY").ToString())
                rowData.Add(document("TOTALBAL").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADCHECKOUT()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCHECKOUT)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("CLIENTNO", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("ID").ToString())
                    rowData.Add(document("CLIENTNO").ToString())
                    rowData.Add(document("NAME").ToString())
                    rowData.Add(document("DATE").ToString())
                    rowData.Add(document("PACKAGE").ToString())
                    rowData.Add(document("AMOUNT").ToString())
                    rowData.Add(document("TOTALPAY").ToString())
                    rowData.Add(document("TOTALBAL").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        LOADCHECKOUT()
    End Sub

    Private Sub BTNREFRESH_Click(sender As Object, e As EventArgs) Handles BTNREFRESH.Click
        LOADCHECKOUT()
    End Sub
End Class
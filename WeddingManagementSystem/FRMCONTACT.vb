Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMCONTACT

    Private Sub BTNHIDE_Click(sender As Object, e As EventArgs) Handles BTNHIDE.Click
        Me.Hide()
        FRMADDMESSAGES.Show()
    End Sub

    Public Sub LOADplanner()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView2.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("GENDER").ToString())
                rowData.Add(document("AGE").ToString())
                rowData.Add(document("ADDRESS").ToString())
                rowData.Add(document("GMAIL").ToString())
                rowData.Add(document("CONTACT").ToString())
                rowData.Add(document("RFID").ToString())
                rowData.Add(document("USERNAME").ToString())
                rowData.Add(document("PASSWORD").ToString())
                DataGridView2.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LOADvendor()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLVENDOR)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView3.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("BUSINESSNAME").ToString())
                rowData.Add(document("SERVICE").ToString())
                rowData.Add(document("ADDRESS").ToString())
                rowData.Add(document("GMAIL").ToString())
                rowData.Add(document("CONTACT").ToString())
                rowData.Add(document("RFID").ToString())
                rowData.Add(document("USERNAME").ToString())
                rowData.Add(document("PASSWORD").ToString())
                DataGridView3.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TABSTAFF_Click(sender As Object, e As EventArgs) Handles TABSTAFF.Click
        LOADplanner()
    End Sub

    Private Sub TABVENDOR_Click(sender As Object, e As EventArgs) Handles TABVENDOR.Click
        LOADvendor()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        'PLANNER CONTACT
        Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name
        If colName = "COLMESSAGE" Then
            With FRMADDMESSAGES
                .TXTID.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCONTACT.Text = DataGridView2.Rows(e.RowIndex).Cells(6).Value.ToString
                '.CreateMsg()
                Me.Hide()
            End With
        End If
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        'VENDOR CONTACT
        Dim colName As String = DataGridView3.Columns(e.ColumnIndex).Name
        If colName = "SMS" Then
            With FRMADDMESSAGES
                .TXTID.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCONTACT.Text = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString
                '.CreateMsg()
                Me.Hide()
            End With
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'CLIENT CONTACT
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "MESSAGE" Then
            With FRMADDMESSAGES
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCONTACT.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                '.CreateMsg()
                Me.Hide()
            End With
        End If
    End Sub

    Private Sub TABCLIENT_Click(sender As Object, e As EventArgs) Handles TABCLIENT.Click
        LOADclient()
    End Sub

    Public Sub LOADclient()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("client_no").ToString())
                rowData.Add(document("bridegroom").ToString())
                rowData.Add(document("contact").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FRMCONTACT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADclient()
        LOADplanner()
        LOADvendor()
    End Sub
End Class
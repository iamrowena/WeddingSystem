Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMBOOKINGS

    Private Sub Guna2CircleButton4_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton4.Click
        With FRMADDBOOKING
            .BTNSAVE.Show()
            .BTNCAN.Show()
            .COMBOSELECT()
            .BTNUPDATE.Hide()
            .BTNCONFIRM.Hide()
            .LOADPlannerName()
            .GENERATEID()
            .Show()
        End With
    End Sub

    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        FRMLOGIN.Show()
        Me.Hide()
        FRMMAIN.Hide()
    End Sub

    Public Sub LOADbookings()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLBOOKINGS)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView3.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("book_no").ToString())
                rowData.Add(document("groom").ToString())
                rowData.Add(document("bride").ToString())
                rowData.Add(document("email").ToString())
                rowData.Add(document("contact").ToString())
                rowData.Add(document("plan").ToString())
                rowData.Add(document("pac").ToString())
                rowData.Add(document("date_in").ToString())
                rowData.Add(document("time_in").ToString())
                rowData.Add(document("wed_date").ToString())
                DataGridView3.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs)
        With FRMADDCLIENT
            .BTNSAVE.Show()
            .BTNUPDATE.Hide()
            .BTNCAN.Show()
            .GENERATEID()
            .LOADPLANNAME()
            .Show()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "EDITC" Then
            With FRMADDCLIENT
                .BTNSAVE.Hide()
                .BTNUPDATE.Show()
                .BTNCAN.Show()
                .LOADPLANNAME()
                .client_no.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .bridegroom.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .email.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .contact.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .plan.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .pac.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .date_in.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .time_in.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .wed_date.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "DELETEC" Then
            If MsgBox("Delete this client " & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                'save to tbldelte
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection1 As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLDELETE)
                Dim document As New BsonDocument()
                document.Add("client_no", DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                document.Add("bridegroom", DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
                document.Add("email", DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
                document.Add("contact", DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
                document.Add("plan", DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
                document.Add("pac", DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                document.Add("date_in", DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString)
                document.Add("time_in", DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString)
                document.Add("wed_date", DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString)
                collection1.InsertOne(document)

                ' delete data from mongodb
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("client_no", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("A Client Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.LOADclient()
            End If
        ElseIf colName = "VIEWC" Then
            With FRMADDCLIENT
                .BTNSAVE.Hide()
                .BTNUPDATE.Hide()
                .BTNCAN.Show()
                .client_no.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .bridegroom.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .email.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .contact.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .plan.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .pac.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .date_in.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .time_in.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .wed_date.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                .ShowDialog()
            End With
        End If
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
                rowData.Add(document("email").ToString())
                rowData.Add(document("contact").ToString())
                rowData.Add(document("plan").ToString())
                rowData.Add(document("pac").ToString())
                rowData.Add(document("date_in").ToString())
                rowData.Add(document("time_in").ToString())
                rowData.Add(document("wed_date").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FRMBOOKING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADbookings()
    End Sub

    Private Sub TABCLIENTINFO_Click(sender As Object, e As EventArgs) Handles TABCLIENTINFO.Click
        LOADclient()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim colName As String = DataGridView3.Columns(e.ColumnIndex).Name
        If colName = "EDITB" Then
            With FRMADDBOOKING
                .BTNSAVE.Hide()
                .BTNCAN.Show()
                .BTNCONFIRM.Hide()
                .BTNUPDATE.Show()
                .LOADPlannerName()
                .book_no.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
                .groom.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString
                .bride.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString
                .email.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString
                .contact.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString
                .plan.Text = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString
                .pac.Text = DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString
                .date_in.Text = DataGridView3.Rows(e.RowIndex).Cells(7).Value.ToString
                .time_in.Text = DataGridView3.Rows(e.RowIndex).Cells(8).Value.ToString
                .wed_date.Text = DataGridView3.Rows(e.RowIndex).Cells(9).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "DELETEB" Then
            If MsgBox("Delete this booking " & DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString & " and " & DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                'save to tbldelte
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection1 As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLDELETE)
                Dim document As New BsonDocument()

                document.Add("book_no", DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString)
                document.Add("groom", DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString)
                document.Add("bride", DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString)
                document.Add("email", DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString)
                document.Add("contact", DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString)
                document.Add("plan", DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString)
                document.Add("pac", DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString)
                document.Add("date_in", DataGridView3.Rows(e.RowIndex).Cells(7).Value.ToString)
                document.Add("time_in", DataGridView3.Rows(e.RowIndex).Cells(8).Value.ToString)
                document.Add("wed_date", DataGridView3.Rows(e.RowIndex).Cells(9).Value.ToString)
                collection1.InsertOne(document)

                ' delete data from mongodb
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLBOOKINGS)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("book_no", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("A Booking Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.LOADbookings()
            End If
        ElseIf colName = "VIEWB" Then
            With FRMADDBOOKING
                .BTNSAVE.Hide()
                .BTNUPDATE.Hide()
                .BTNCONFIRM.Hide()
                .BTNCAN.Show()
                .book_no.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
                .groom.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString
                .bride.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString
                .email.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString
                .contact.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString
                .plan.Text = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString
                .pac.Text = DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString
                .date_in.Text = DataGridView3.Rows(e.RowIndex).Cells(7).Value.ToString
                .time_in.Text = DataGridView3.Rows(e.RowIndex).Cells(8).Value.ToString
                .wed_date.Text = DataGridView3.Rows(e.RowIndex).Cells(9).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "CONFIRM" Then
            With FRMADDBOOKING
                .BTNSAVE.Hide()
                .BTNUPDATE.Hide()
                .BTNCONFIRM.Show()
                .BTNCAN.Show()
                .book_no.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString
                .groom.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString
                .bride.Text = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString
                .email.Text = DataGridView3.Rows(e.RowIndex).Cells(3).Value.ToString
                .contact.Text = DataGridView3.Rows(e.RowIndex).Cells(4).Value.ToString
                .plan.Text = DataGridView3.Rows(e.RowIndex).Cells(5).Value.ToString
                .pac.Text = DataGridView3.Rows(e.RowIndex).Cells(6).Value.ToString
                .date_in.Text = DataGridView3.Rows(e.RowIndex).Cells(7).Value.ToString
                .time_in.Text = DataGridView3.Rows(e.RowIndex).Cells(8).Value.ToString
                .wed_date.Text = DataGridView3.Rows(e.RowIndex).Cells(9).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADbookings()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLBOOKINGS)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("book_no", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView3.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("book_no").ToString())
                    rowData.Add(document("groom").ToString())
                    rowData.Add(document("bride").ToString())
                    rowData.Add(document("email").ToString())
                    rowData.Add(document("contact").ToString())
                    rowData.Add(document("plan").ToString())
                    rowData.Add(document("pac").ToString())
                    rowData.Add(document("date_in").ToString())
                    rowData.Add(document("time_in").ToString())
                    rowData.Add(document("wed_date").ToString())
                    DataGridView3.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TXTSEARCHCLIENT_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCHCLIENT.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADclient()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("client_no", New BsonRegularExpression(TXTSEARCHCLIENT.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("client_no").ToString())
                    rowData.Add(document("bridegroom").ToString())
                    rowData.Add(document("email").ToString())
                    rowData.Add(document("contact").ToString())
                    rowData.Add(document("plan").ToString())
                    rowData.Add(document("pac").ToString())
                    rowData.Add(document("date_in").ToString())
                    rowData.Add(document("time_in").ToString())
                    rowData.Add(document("wed_date").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMSTAFF

    Private Sub BTNADDPLAN_Click(sender As Object, e As EventArgs) Handles BTNADDPLAN.Click
        With FRMADDPLAN
            .BTNSAVE.Show()
            .BTNCANCEL.Show()
            .BTNUPDATE.Hide()
            .GENERATEID()
            .Show()
        End With
    End Sub

    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        FRMLOGIN.Show()
        Me.Hide()
        FRMMAIN.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "COLEDIT" Then
            With FRMADDPLAN
                .BTNSAVE.Hide()
                .BTNUPDATE.Show()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTCNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTGENDER.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTAGE.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTADDRESS.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTEMAIL.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .TXTCONTACT.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .TXTRFID.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .TXTUSERNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                .TXTPASSWORD.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "COLDELETE" Then
            If MsgBox("Delete this planner " & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & " on " & DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                'save to tbldelte
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection1 As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLDELETE)
                Dim document As New BsonDocument()
                document.Add("ID", DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                document.Add("CNAME", DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
                document.Add("GENDER", DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
                document.Add("AGE", DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
                document.Add("ADDRESS", DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
                document.Add("GMAIL", DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                document.Add("CONTACT", DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString)
                document.Add("RFID", DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString)
                document.Add("USERNAME", DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString)
                document.Add("PASSWORD", DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString)
                collection1.InsertOne(document)

                ' delete data from mongodb
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("A Planner Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.LOADplanner()
            End If
        ElseIf colName = "COLMESSAGE" Then
            With FRMADDMESSAGES
                .BTNSEND.Show()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCONTACT.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Public Sub LOADplanner()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
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
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        With FRMADDVENDOR
            .BTNSAVE.Show()
            .BTNUPDATE.Hide()
            .BTNCAN.Show()
            .GENERATEID()
            .Show()
        End With
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name
        If colName = "EDIT" Then
            With FRMADDVENDOR
                .BTNSAVE.Hide()
                .BTNUPDATE.Show()
                .BTNCAN.Show()
                .VID.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
                .VNAME.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
                .VTYPE.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString
                .VADDRESS.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString
                .VEMAIL.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString
                .VCONTACT.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value.ToString
                .VRFID.Text = DataGridView2.Rows(e.RowIndex).Cells(6).Value.ToString
                .VMAILADD.Text = DataGridView2.Rows(e.RowIndex).Cells(7).Value.ToString
                .VPASS.Text = DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "DELETE" Then
            If MsgBox("Delete this appointment " & DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString & " on " & DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                'save to tbldelte
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection1 As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLDELETE)
                Dim document As New BsonDocument()
                document.Add("ID", DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString)
                document.Add("BUSINESSNAME", DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString)
                document.Add("SERVICE", DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString)
                document.Add("ADDRESS", DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString)
                document.Add("GMAIL", DataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString)
                document.Add("CONTACT", DataGridView2.Rows(e.RowIndex).Cells(5).Value.ToString)
                document.Add("RFID", DataGridView2.Rows(e.RowIndex).Cells(6).Value.ToString)
                document.Add("USERNAME", DataGridView2.Rows(e.RowIndex).Cells(7).Value.ToString)
                document.Add("PASSWORD", DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString)
                collection1.InsertOne(document)

                ' delete data from mongodb
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLVENDOR)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("A Vendor Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.LOADvendor()
            End If
        ElseIf colName = "MESSAGE" Then
            With FRMADDMESSAGES
                .BTNSEND.Show()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTNAME.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCONTACT.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub
    Public Sub LOADvendor()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLVENDOR)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView2.Rows.Clear()
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
                DataGridView2.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub vendor_Click(sender As Object, e As EventArgs) Handles vendor.Click
        LOADvendor()
    End Sub

    Private Sub FRMSTAFF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADvendor()
        LOADplanner()
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADplanner()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("ID", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
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
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TXTSEARCHVENDOR_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCHVENDOR.TextChanged
        If TXTSEARCHVENDOR.Text = String.Empty Then
            LOADvendor()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLVENDOR)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("ID", New BsonRegularExpression(TXTSEARCHVENDOR.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView2.Rows.Clear()
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
                    DataGridView2.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
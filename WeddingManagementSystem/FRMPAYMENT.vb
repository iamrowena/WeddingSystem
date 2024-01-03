Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMPAYMENT

    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs)
        FRMMAIN.Hide()
        FRMLOGIN.Show()
    End Sub

    Private Sub BTNNEW_Click(sender As Object, e As EventArgs) Handles BTNNEW.Click
        With FRMADDPAYMENT
            .BTNSAVE.Show()
            .BTNUPDATE.Hide()
            .GENERATEID()
            .LoadClientName()
            .ShowDialog()
        End With
    End Sub

    Public Sub LOADPAYMENT()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
            Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
            DataGridView1.Rows.Clear()
            For Each document As BsonDocument In documents
                Dim rowData As New List(Of String)()
                rowData.Add(document("ID").ToString())
                rowData.Add(document("CLIENTNO").ToString())
                rowData.Add(document("NAME").ToString())
                rowData.Add(document("REFNO").ToString())
                rowData.Add(document("DATE").ToString())
                rowData.Add(document("PACKAGE").ToString())
                rowData.Add(document("AMOUNT").ToString())
                rowData.Add(document("DOWNPAY").ToString())
                DataGridView1.Rows.Add(rowData.ToArray())
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadClientName()
        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
        Dim filter = Builders(Of BsonDocument).Filter.Empty
        Dim projection = Builders(Of BsonDocument).Projection.Include("bridegroom")
        Dim cursor = collection.Find(filter).Project(projection).ToCursor()
        For Each document In cursor.ToEnumerable()
            TXTCNAME.Items.Add(document("bridegroom").AsString)
        Next
        TNAME()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "EDIT" Then
            With FRMADDPAYMENT
                .BTNSAVE.Hide()
                .BTNUPDATE.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTCLIENTNO.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTREF.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTDATE.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTPACKAGE.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .TXTAMOUNT.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .TXTDOWNPAYMENT.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .ShowDialog()
            End With
        ElseIf colName = "DELETE" Then
            If MsgBox("Delete this payment " & DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString & " on " & DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString & "?", vbYesNo + vbQuestion) = vbYes Then
                'save to tbldelte
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection1 As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLDELETE)
                Dim document As New BsonDocument()
                document.Add("ID", DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                document.Add("CLIENTNO", DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
                document.Add("NAME", DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
                document.Add("REFNO", DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString)
                document.Add("DATE", DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString)
                document.Add("PACKAGE", DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                document.Add("AMOUNT", DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString)
                document.Add("DOWNPAY", DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString)
                collection1.InsertOne(document)

                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
                ' Create a filter to find the student by their ID
                Dim APPID As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                collection.DeleteOne(filter)
                MessageBox.Show("Payment Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LOADPAYMENT()
            End If
        ElseIf colName = "VIEW" Then
            With FRMADDPAYMENT
                .BTNSAVE.Hide()
                .BTNUPDATE.Hide()
                .BTNCANCEL.Show()
                .TXTID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .TXTCLIENTNO.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTCNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .TXTREF.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTDATE.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTPACKAGE.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .TXTAMOUNT.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .TXTDOWNPAYMENT.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        If TXTSEARCH.Text = String.Empty Then
            LOADPAYMENT()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("CLIENTNO", New BsonRegularExpression(TXTSEARCH.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("ID").ToString())
                    rowData.Add(document("CLIENTNO").ToString())
                    rowData.Add(document("NAME").ToString())
                    rowData.Add(document("REFNO").ToString())
                    rowData.Add(document("DATE").ToString())
                    rowData.Add(document("PACKAGE").ToString())
                    rowData.Add(document("AMOUNT").ToString())
                    rowData.Add(document("DOWNPAY").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub LOADTOTALPAY(fieldName As String)
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("CLIENTNO", TXTCLIENTNO.Text)
            Dim cursor = collection.Find(filter)
            Dim sum As Double = 0

            For Each document As BsonDocument In cursor.ToEnumerable()
                Dim fieldValue As BsonValue = document.GetValue(fieldName)

                Dim numericValue As Double
                If Double.TryParse(fieldValue.ToString(), numericValue) Then
                    sum += numericValue
                End If
            Next

            TXTTOTALPAY.Text = sum.ToString()
        Catch ex As Exception
            MessageBox.Show("Error client total pay: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TXTCNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTCNAME.SelectedIndexChanged
        TNAME()
    End Sub

    Public Sub TNAME()
        CLEAR()
        If TXTCNAME.Text = "" Then

        Else
            Dim selectedValue = TXTCNAME.SelectedItem.ToString()

            ' Query MongoDB for additional information based on the selected value
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("bridegroom", selectedValue)
            Dim document = collection.Find(filter).FirstOrDefault()

            ' Display additional information in the TextBox
            If document IsNot Nothing Then
                TXTCLIENTNO.Text = document("client_no").AsString
                TXTCNAME.Text = document("bridegroom").AsString
                TXTPACKAGE.Text = document("pac").AsString
            Else
                MsgBox("Client No and package not display") ' Clear TextBox if no matching document found
            End If
        End If
    End Sub

    Private Sub FRMPAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientName()
        GENERATEID()
        LOADPAYMENT()
    End Sub

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        TXTID.Text = Format(dateAndTime, "ssFFFFF").ToString
    End Sub

    Private Sub TXTCLIENTNO_TextChanged(sender As Object, e As EventArgs) Handles TXTCLIENTNO.TextChanged
        LOADTOTALPAY("DOWNPAY")

        If TXTCLIENTNO.Text = String.Empty Then
            'LOADPAYMENT()
        Else
            Try
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
                Dim filter = Builders(Of BsonDocument).Filter.Regex("CLIENTNO", New BsonRegularExpression(TXTCLIENTNO.Text))
                Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()
                DataGridView1.Rows.Clear()
                For Each document As BsonDocument In documents
                    Dim rowData As New List(Of String)()
                    rowData.Add(document("ID").ToString())
                    rowData.Add(document("CLIENTNO").ToString())
                    rowData.Add(document("NAME").ToString())
                    rowData.Add(document("REFNO").ToString())
                    rowData.Add(document("DATE").ToString())
                    rowData.Add(document("PACKAGE").ToString())
                    rowData.Add(document("AMOUNT").ToString())
                    rowData.Add(document("DOWNPAY").ToString())
                    DataGridView1.Rows.Add(rowData.ToArray())
                Next
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BTNREFRESH_Click(sender As Object, e As EventArgs) Handles BTNREFRESH.Click
        LOADPAYMENT()
        TXTSEARCH.Clear()
    End Sub

    Private Sub BTNCHECKOUT_Click(sender As Object, e As EventArgs) Handles BTNCHECKOUT.Click
        Try
            If MsgBox("Do you want to Checkout?" & vbNewLine & "NAME: " & TXTCNAME.Text & vbNewLine & "TOTAL PAYMENT: " & TXTTOTALPAY.Text & vbNewLine & "TOTAL BALANCE: " & TXTTOTALBAL.Text, vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCHECKOUT)
                Dim document As New BsonDocument()
                document.Add("ID", TXTID.Text)
                document.Add("CLIENTNO", TXTCLIENTNO.Text)
                document.Add("NAME", TXTCNAME.Text)
                document.Add("DATE", TXTDATE.Text)
                document.Add("PACKAGE", TXTPACKAGE.Text)
                document.Add("AMOUNT", TXTAMOUNT.Text)
                document.Add("TOTALPAY", TXTTOTALPAY.Text)
                document.Add("TOTALBAL", TXTTOTALBAL.Text)
                collection.InsertOne(document)
                MessageBox.Show("You Checkout successfully!", "Checkout Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMCHECKOUT
                    .LOADCHECKOUT()
                    .ShowDialog()
                End With
                TXTID.Clear()
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CLEAR()
        TXTCLIENTNO.Clear()
        TXTCNAME.Text = ""
        TXTDATE.Text = ""
        TXTPACKAGE.Clear()
        TXTAMOUNT.Text = "00000"
        TXTTOTALPAY.Text = "00000"
        TXTTOTALBAL.Text = "00000"
    End Sub

    Private Sub TXTTOTALPAY_TextChanged(sender As Object, e As EventArgs) Handles TXTTOTALPAY.TextChanged
        SubtractAndDisplay()
    End Sub

    Private Sub SubtractAndDisplay()
        ' Assuming TextBox1 and TextBox2 contain numeric values
        Dim num1 As Double
        Dim num2 As Double

        If Double.TryParse(TXTAMOUNT.Text, num1) AndAlso Double.TryParse(TXTTOTALPAY.Text, num2) Then
            ' Both TextBoxes contain valid numeric values
            Dim result As Double = num1 - num2
            TXTTOTALBAL.Text = result.ToString()
        Else
            ' Display an error message if the input is not numeric
            TXTTOTALBAL.Text = "00000"
        End If
    End Sub

    Private Sub TXTPACKAGE_TextChanged(sender As Object, e As EventArgs) Handles TXTPACKAGE.TextChanged
        If TXTPACKAGE.Text = "" Then

        Else

            ' Query MongoDB for additional information based on the selected value
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("NAME", TXTPACKAGE.Text)
            Dim document = collection.Find(filter).FirstOrDefault()

            ' Display additional information in the TextBox
            If document IsNot Nothing Then
                TXTAMOUNT.Text = document("PRICE").AsString
            Else
                MsgBox("Package info error") ' Clear TextBox if no matching document found
            End If
        End If
    End Sub

    Private Sub TXTAMOUNT_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Allow digits (0-9), backspace, and decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTAMOUNT_TextChanged(sender As Object, e As EventArgs) Handles TXTAMOUNT.TextChanged
        SubtractAndDisplay()
    End Sub

    Private Sub TXTTOTALBAL_TextChanged(sender As Object, e As EventArgs) Handles TXTTOTALBAL.TextChanged
        SubtractAndDisplay()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        With FRMCHECKOUT
            .LOADCHECKOUT()
            .ShowDialog()
        End With
    End Sub
End Class
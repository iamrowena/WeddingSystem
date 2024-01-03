Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDPAYMENT

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        Try
            If MsgBox("Update Payment?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
                Dim APPID As String = TXTID.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                Dim updateDefinition As New BsonDocument()
                updateDefinition("CLIENTNO") = TXTCLIENTNO.Text
                updateDefinition("NAME") = TXTCNAME.Text
                updateDefinition("REFNO") = TXTREF.Text
                updateDefinition("DATE") = TXTDATE.Text
                updateDefinition("PACKAGE") = TXTPACKAGE.Text
                updateDefinition("AMOUNT") = TXTAMOUNT.Text
                updateDefinition("DOWNPAY") = TXTDOWNPAYMENT.Text
                collection.UpdateOne(filter, New BsonDocument("$set", updateDefinition))
                MessageBox.Show("Package updated successfully", "Package Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMPAYMENT
                    .LOADPAYMENT()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        TXTID.Text = Format(dateAndTime, "ssFFFFF").ToString
    End Sub
    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save payment?" & vbNewLine & "NAME: " & TXTCNAME.Text & vbNewLine & " DOWNPAYMENT: " & TXTDOWNPAYMENT.Text, vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
                Dim document As New BsonDocument()
                document.Add("ID", TXTID.Text)
                document.Add("CLIENTNO", TXTCLIENTNO.Text)
                document.Add("NAME", TXTCNAME.Text)
                document.Add("REFNO", TXTREF.Text)
                document.Add("DATE", TXTDATE.Text)
                document.Add("PACKAGE", TXTPACKAGE.Text)
                document.Add("AMOUNT", TXTAMOUNT.Text)
                document.Add("DOWNPAY", TXTDOWNPAYMENT.Text)
                collection.InsertOne(document)
                MessageBox.Show("Your Payment Save successfully!", "Payment Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMPAYMENT
                    .LOADPAYMENT()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Me.Hide()
        CLEAR()
    End Sub

    Public Sub LoadClientName()
        If TXTCNAME.Text = "" Then
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim projection = Builders(Of BsonDocument).Projection.Include("bridegroom")
            Dim cursor = collection.Find(filter).Project(projection).ToCursor()
            For Each document In cursor.ToEnumerable()
                TXTCNAME.Items.Add(document("bridegroom").AsString)
            Next
        Else

        End If


    End Sub
    Public Sub CLEAR()
        TXTID.Clear()
        TXTCLIENTNO.Clear()
        TXTCNAME.Text = ""
        TXTDATE.Text = ""
        TXTAMOUNT.Text = ""
        TXTDOWNPAYMENT.Clear()
        TXTPACKAGE.Clear()
        TXTREF.Clear()
    End Sub

    Private Sub TXTCNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTCNAME.SelectedIndexChanged
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
                TXTPACKAGE.Text = document("pac").AsString
            Else
                MsgBox("Client No and package not display") ' Clear TextBox if no matching document found
            End If
        End If
    End Sub

    Private Sub TXTPACKAGE_TextChanged(sender As Object, e As EventArgs) Handles TXTPACKAGE.TextChanged
        ' Query MongoDB for additional information based on the selected value
        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("NAME", TXTPACKAGE.Text)
        Dim document = collection.Find(filter).FirstOrDefault()

        ' Display additional information in the TextBox
        If document IsNot Nothing Then
            TXTAMOUNT.Text = document("PRICE").AsString
            ' Replace "additional_field" with the actual field you want to display
        Else
            TXTAMOUNT.Text = "No price" ' Clear TextBox if no matching document found
        End If
    End Sub

    Private Sub TXTAMOUNT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTAMOUNT.KeyPress
        ' Allow digits (0-9), backspace, and decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTDOWNPAYMENT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDOWNPAYMENT.KeyPress
        ' Allow digits (0-9), backspace, and decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class
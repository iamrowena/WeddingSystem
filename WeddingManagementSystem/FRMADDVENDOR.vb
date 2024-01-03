Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDVENDOR

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        VID.Text = Format(dateAndTime, "ddyyMMssFF").ToString
    End Sub

    Public Sub CLEAR()
        VID.Clear()
        VNAME.Clear()
        VTYPE.Clear()
        VADDRESS.Clear()
        VEMAIL.Clear()
        VRFID.Clear()
        VMAILADD.Clear()
        VPASS.Clear()

    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save Staff?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLVENDOR)
                Dim document As New BsonDocument()
                document.Add("ID", VID.Text)
                document.Add("BUSINESSNAME", VNAME.Text)
                document.Add("SERVICE", VTYPE.Text)
                document.Add("ADDRESS", VADDRESS.Text)
                document.Add("GMAIL", VEMAIL.Text)
                document.Add("CONTACT", VCONTACT.Text)
                document.Add("RFID", VRFID.Text)
                document.Add("USERNAME", VMAILADD.Text)
                document.Add("PASSWORD", VPASS.Text)
                collection.InsertOne(document)
                MessageBox.Show("Vendor Save successfully!", "Vendor Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMSTAFF
                    .LOADvendor()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        Try
            If MsgBox("Update Appointment?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLVENDOR)
                Dim APPID As String = VID.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                Dim updateDefinition As New BsonDocument()
                updateDefinition("ID") = VID.Text
                updateDefinition("BUSINESSNAME") = VNAME.Text
                updateDefinition("SERVICE") = VTYPE.Text
                updateDefinition("ADDRESS") = VADDRESS.Text
                updateDefinition("GMAIL") = VEMAIL.Text
                updateDefinition("CONTACT") = VCONTACT.Text
                updateDefinition("RFID") = VRFID.Text
                updateDefinition("USERNAME") = VADDRESS.Text
                updateDefinition("PASSWORD") = VPASS.Text
                collection.UpdateOne(filter, New BsonDocument("$set", updateDefinition))
                MessageBox.Show("Appointment updated successfully", "Appointment Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMSTAFF
                    .LOADvendor()
                    Me.Hide()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNCAN_Click(sender As Object, e As EventArgs) Handles BTNCAN.Click
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub
End Class
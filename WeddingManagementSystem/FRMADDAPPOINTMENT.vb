Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDAPPOINTMENT
    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        TXTID.Text = Format(dateAndTime, "ssFFFFF").ToString
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
            TXTCNAME.Text = "Error"
        End If
    End Sub



    Public Sub CLEAR()
        TXTID.Clear()
        TXTCLIENTNO.Clear()
        TXTCNAME.Text = ""
        TXTCONTACT.Clear()
        TXTDATE.Text = ""
        TXTSUBJECT.Clear()
        TXTTIME.Clear()
        TXTDESCRIPTION.Clear()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save Appointment?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLAPPOINTMENTS)
                Dim document As New BsonDocument()
                document.Add("ID", TXTID.Text)
                document.Add("CLIENTNO", TXTCLIENTNO.Text)
                document.Add("NAME", TXTCNAME.Text)
                document.Add("CONTACT", TXTCONTACT.Text)
                document.Add("DATE", TXTDATE.Text)
                document.Add("TIME", TXTTIME.Text)
                document.Add("SUBJECT", TXTSUBJECT.Text)
                document.Add("DESCRIPTION", TXTDESCRIPTION.Text)
                collection.InsertOne(document)
                MessageBox.Show("Appointment Save successfully!", "Appointment Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMAPPOINTMENT
                    .LOADAPPOINTMENT()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Appointment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        Try
            If MsgBox("Update Appointment?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLAPPOINTMENTS)
                Dim APPID As String = TXTID.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                Dim updateDefinition As New BsonDocument()
                updateDefinition("NAME") = TXTCNAME.Text
                updateDefinition("CLIENTNO") = TXTCLIENTNO.Text
                updateDefinition("CONTACT") = TXTCONTACT.Text
                updateDefinition("DATE") = TXTDATE.Text
                updateDefinition("TIME") = TXTTIME.Text
                updateDefinition("SUBJECT") = TXTSUBJECT.Text
                updateDefinition("DESCRIPTION") = TXTDESCRIPTION.Text
                collection.UpdateOne(filter, New BsonDocument("$set", updateDefinition))
                MessageBox.Show("Appointment updated successfully", "Appointment Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMAPPOINTMENT
                    .LOADAPPOINTMENT()
                    Me.Hide()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub TXTCNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTCNAME.SelectedIndexChanged
        Dim selectedValue = TXTCNAME.SelectedItem.ToString()

        ' Query MongoDB for additional information based on the selected value
        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("bridegroom", selectedValue)
        Dim document = collection.Find(filter).FirstOrDefault()

        ' Display additional information in the TextBox
        If document IsNot Nothing Then
            TXTCLIENTNO.Text = document("client_no").AsString
            TXTCONTACT.Text = document("contact").AsString ' Replace "additional_field" with the actual field you want to display
        Else
            TXTCLIENTNO.Text = "No match" ' Clear TextBox if no matching document found
        End If
    End Sub

    Private Sub PANEL_Paint(sender As Object, e As PaintEventArgs) Handles PANEL.Paint

    End Sub
End Class
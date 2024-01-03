Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDCLIENT

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        client_no.Text = Format(dateAndTime, "ddyyMMFFF").ToString
    End Sub

    Public Sub CLEAR()
        client_no.Clear()
        bridegroom.Clear()
        email.Clear()
        contact.Clear()
        plan.Text = ""
        pac.Clear()
        date_in.Text = ""
        time_in.Clear()
        wed_date.Text = ""
    End Sub

    Public Sub LOADPLANNAME()
        If plan.Text = "" Then
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            Dim projection = Builders(Of BsonDocument).Projection.Include("NAME")
            Dim cursor = collection.Find(filter).Project(projection).ToCursor()

            For Each document In cursor.ToEnumerable()
                plan.Items.Add(document("NAME").AsString)
            Next
        Else

        End If
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save Client Information?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
                Dim document As New BsonDocument()
                document.Add("client_no", client_no.Text)
                document.Add("bridegroom", bridegroom.Text)
                document.Add("email", email.Text)
                document.Add("contact", contact.Text)
                document.Add("plan", plan.Text)
                document.Add("pac", pac.Text)
                document.Add("date_in", date_in.Text)
                document.Add("time_in", time_in.Text)
                document.Add("wed_date", wed_date.Text)
                collection.InsertOne(document)
                MessageBox.Show("Client Information Save successfully!", "Client Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMBOOKINGS
                    .LOADclient()
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
            If MsgBox("Update Client Information?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
                Dim APPID As String = client_no.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("client_no", APPID)
                Dim updateDefinition As New BsonDocument()
                updateDefinition("client_no") = client_no.Text
                updateDefinition("bridegroom") = bridegroom.Text
                updateDefinition("email") = email.Text
                updateDefinition("contact") = contact.Text
                updateDefinition("plan") = plan.Text
                updateDefinition("pac") = pac.Text
                updateDefinition("date_in") = date_in.Text
                updateDefinition("time_in") = time_in.Text
                updateDefinition("wed_date") = wed_date.Text
                collection.UpdateOne(filter, New BsonDocument("$set", updateDefinition))
                MessageBox.Show("Client Information updated successfully", "Client Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMBOOKINGS
                    .LOADclient()
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

    Private Sub plan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles plan.SelectedIndexChanged

    End Sub
End Class
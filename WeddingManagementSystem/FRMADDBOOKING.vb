Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDBOOKING

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        book_no.Text = Format(dateAndTime, "ddyyMMFFF").ToString
    End Sub

    Public Sub CLEAR()
        book_no.Clear()
        groom.Clear()
        bride.Clear()
        email.Clear()
        contact.Clear()
        plan.Text = ""
        pac.Clear()
        date_in.Text = ""
        time_in.Clear()
        wed_date.Text = ""
    End Sub

    Private Sub BTNUPDATE_Click_1(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        Try
            If MsgBox("Update Client Booking?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLBOOKINGS)
                Dim APPID As String = book_no.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("book_no", APPID)
                Dim updateDefinition As New BsonDocument()
                updateDefinition("book_no") = book_no.Text
                updateDefinition("groom") = groom.Text
                updateDefinition("bride") = bride.Text
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
                    .LOADbookings()
                    Me.Hide()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNSAVE_Click_1(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save bookings Information?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLBOOKINGS)
                Dim document As New BsonDocument()
                document.Add("book_no", book_no.Text)
                document.Add("groom", groom.Text)
                document.Add("bride", bride.Text)
                document.Add("email", email.Text)
                document.Add("contact", contact.Text)
                document.Add("plan", plan.Text)
                document.Add("pac", pac.Text)
                document.Add("date_in", date_in.Text)
                document.Add("time_in", time_in.Text)
                document.Add("wed_date", wed_date.Text)
                collection.InsertOne(document)
                MessageBox.Show("Bookings Save successfully!", "Client Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMBOOKINGS
                    .LOADbookings()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNCAN_Click_1(sender As Object, e As EventArgs) Handles BTNCAN.Click
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub BTNCONFIRM_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTNCONFIRM_Click_1(sender As Object, e As EventArgs) Handles BTNCONFIRM.Click
        If book_no.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf groom.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf bride.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf email.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf contact.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf plan.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf pac.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf date_in.Text = String.Empty Then
            MsgBox("Fill out all information")
        ElseIf wed_date.Text = String.Empty Then
            MsgBox("Fill out all information")
        Else
            Try
                If MsgBox("Are you sure to confirm client " & groom.Text & " and " & bride.Text & "?", vbQuestion + vbYesNo) = vbYes Then
                    Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
                    Dim document As New BsonDocument()
                    document.Add("client_no", book_no.Text)
                    document.Add("bridegroom", bride.Text & " and " & groom.Text)
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
        End If
    End Sub

    Public Sub LOADPlannerName()
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
            plan.Text = "Error"
        End If
    End Sub

    Public Sub COMBOSELECT()
        plan.Text = "Select Plannner"
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Private Sub plan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles plan.SelectedIndexChanged

    End Sub

    Private Sub FRMADDBOOKING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOADPlannerName()
    End Sub
End Class
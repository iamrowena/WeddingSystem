Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDTASK

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        TXTID.Text = Format(dateAndTime, "mmssFFFF").ToString
    End Sub

    Public Sub CLEAR()
        TXTID.Text = ""
        TXTCLIENTNO.Text = ""
        TXTCNAME.Text = ""
        TXTSERVICES.Text = ""
        TXTPACKAGE.Text = ""
        TXTDETAILS.Text = ""
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

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        Try
            If MsgBox("Update Task?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLTASK)
                Dim APPID As String = TXTID.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)

                Dim updateDefinition As New BsonDocument()
                updateDefinition("ID") = TXTID.Text
                updateDefinition("CLIENTNO") = TXTCLIENTNO.Text
                updateDefinition("NAME") = TXTCNAME.Text
                updateDefinition("PACKAGE") = TXTPACKAGE.Text
                updateDefinition("SERVICES") = TXTSERVICES.Text
                updateDefinition("WED_DETAILS") = TXTDETAILS.Text
                collection.UpdateOne(filter, New BsonDocument("$set", updateDefinition))
                MessageBox.Show("Task updated successfully", "Task Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CLEAR()
                With FRMTASK
                    .LOADTASK()
                    Me.Hide()
                End With

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save Task?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLTASK)
                Dim document As New BsonDocument()
                document.Add("ID", TXTID.Text)
                document.Add("CLIENTNO", TXTCLIENTNO.Text)
                document.Add("NAME", TXTCNAME.Text)
                document.Add("PACKAGE", TXTPACKAGE.Text)
                document.Add("SERVICES", TXTSERVICES.Text)
                document.Add("WED_DETAILS", TXTDETAILS.Text)

                collection.InsertOne(document)
                MessageBox.Show("Task Save successfully!", "Task Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMTASK
                    .LOADTASK()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        CLEAR()
        Me.Hide()
    End Sub

    Private Sub TXTPACKAGE_TextChanged(sender As Object, e As EventArgs) Handles TXTPACKAGE.TextChanged
        UpdateComboBox(TXTPACKAGE.Text)
    End Sub

    Private Sub UpdateComboBox(filterValue As String)
        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("NAME", TXTPACKAGE.Text)

        ' Use the filter to query the MongoDB collection
        Dim results = collection.Find(filter).ToList()

        ' Clear the combobox
        TXTSERVICES.Items.Clear()

        ' Populate the combobox with the results
        For Each result As BsonDocument In results
            TXTSERVICES.Items.Add(result("DESCRIPTION").AsString) ' Replace "FieldName" with the actual field name you want to display
        Next
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
            TXTPACKAGE.Text = document("pac").AsString ' Replace "additional_field" with the actual field you want to display
        Else
            TXTPACKAGE.Text = "No match" ' Clear TextBox if no matching document found
        End If
    End Sub
End Class
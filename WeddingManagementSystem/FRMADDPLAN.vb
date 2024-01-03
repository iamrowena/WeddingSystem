Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDPLAN

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        TXTID.Text = Format(dateAndTime, "ddyyMMssFF").ToString
    End Sub

    Public Sub CLEAR()
        TXTID.Clear()
        TXTCNAME.Clear()
        TXTGENDER.Clear()
        TXTAGE.Clear()
        TXTADDRESS.Clear()
        TXTCONTACT.Clear()
        TXTEMAIL.Clear()
        TXTRFID.Clear()
        TXTUSERNAME.Clear()
        TXTPASSWORD.Clear()
        RBTNFEMALE.Checked = False
        RBTNMALE.Checked = False
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save Staff?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
                Dim document As New BsonDocument()
                document.Add("ID", TXTID.Text)
                document.Add("NAME", TXTCNAME.Text)
                document.Add("GENDER", TXTGENDER.Text)
                document.Add("AGE", TXTAGE.Text)
                document.Add("ADDRESS", TXTADDRESS.Text)
                document.Add("GMAIL", TXTEMAIL.Text)
                document.Add("CONTACT", TXTCONTACT.Text)
                document.Add("RFID", TXTRFID.Text)
                document.Add("USERNAME", TXTUSERNAME.Text)
                document.Add("PASSWORD", TXTPASSWORD.Text)
                collection.InsertOne(document)
                MessageBox.Show("A Planner Save successfully!", "Planner Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RBTNFEMALE.Checked = False
                RBTNMALE.Checked = False
                With FRMSTAFF
                    .LOADplanner()
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
            If MsgBox("Update planner?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
                Dim APPID As String = TXTID.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)
                Dim updateDefinition As New BsonDocument()
                updateDefinition("ID") = TXTID.Text
                updateDefinition("NAME") = TXTCNAME.Text
                updateDefinition("GENDER") = TXTGENDER.Text
                updateDefinition("AGE") = TXTAGE.Text
                updateDefinition("ADDRESS") = TXTADDRESS.Text
                updateDefinition("GMAIL") = TXTEMAIL.Text
                updateDefinition("CONTACT") = TXTCONTACT.Text
                updateDefinition("RFID") = TXTRFID.Text
                updateDefinition("USERNAME") = TXTUSERNAME.Text
                updateDefinition("PASSWORD") = TXTPASSWORD.Text
                collection.UpdateOne(filter, New BsonDocument("$set", updateDefinition))
                MessageBox.Show("Planner updated successfully", "Planner Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMSTAFF
                    .LOADplanner()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub RBTNMALE_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNMALE.CheckedChanged
        If RBTNMALE.Checked = True Then
            TXTGENDER.Text = "MALE"
        Else
            TXTGENDER.Text = "FEMALE"
        End If
    End Sub

    Private Sub RBTNFEMALE_CheckedChanged(sender As Object, e As EventArgs) Handles RBTNFEMALE.CheckedChanged
        If RBTNMALE.Checked = True Then
            TXTGENDER.Text = "MALE"
        Else
            TXTGENDER.Text = "FEMALE"
        End If
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Private Sub LabelMale_Click(sender As Object, e As EventArgs) Handles LabelMale.Click

    End Sub

    Private Sub LabelFemale_Click(sender As Object, e As EventArgs) Handles LabelFemale.Click

    End Sub
End Class
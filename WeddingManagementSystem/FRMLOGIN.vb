
Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMLOGIN
    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
            Dim filterBuilder As FilterDefinitionBuilder(Of BsonDocument) = Builders(Of BsonDocument).Filter
            Dim filter = filterBuilder.Eq(Of BsonValue)("USERNAME", TXTUSERNAME.Text) And filterBuilder.Eq(Of BsonValue)("PASSWORD", TXTPASSWORD.Text)

            Dim result = collection.Find(filter).ToList()
            If result.Count > 0 Then
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                FRMDASHBOARD.LoadName()
                FRMMAIN.ShowDialog()
                TXTUSERNAME.Clear()
                TXTPASSWORD.Clear()

            Else
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TXTPASSWORD_Load(sender As Object, e As EventArgs) Handles TXTPASSWORD.Load
        TXTPASSWORD.UseSystemPasswordChar = True
        TXTPASSWORD.PasswordChar = "●"
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        If TXTPASSWORD.UseSystemPasswordChar = True Then
            TXTPASSWORD.PasswordChar = ControlChars.NullChar
            TXTPASSWORD.UseSystemPasswordChar = False
        ElseIf TXTPASSWORD.UseSystemPasswordChar = False Then
            TXTPASSWORD.PasswordChar = "●"
            TXTPASSWORD.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FRMLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SEEPASSWORD_CheckedChanged(sender As Object, e As EventArgs)
        If SEEPASSWORD.Checked = True Then
            TXTPASSWORD.PasswordChar = ControlChars.NullChar
            TXTPASSWORD.UseSystemPasswordChar = False
        Else
            TXTPASSWORD.PasswordChar = "●"
            TXTPASSWORD.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BTNRFID_Click(sender As Object, e As EventArgs) Handles BTNRFID.Click
        With FRMRFID
            .Show()
        End With
    End Sub
    Private Sub SEEPASSWORD_CheckedChanged_1(sender As Object, e As EventArgs) Handles SEEPASSWORD.CheckedChanged
        If SEEPASSWORD.Checked = True Then
            TXTPASSWORD.PasswordChar = ControlChars.NullChar
            TXTPASSWORD.UseSystemPasswordChar = False
        Else
            TXTPASSWORD.PasswordChar = "●"
            TXTPASSWORD.UseSystemPasswordChar = True
        End If
    End Sub
End Class
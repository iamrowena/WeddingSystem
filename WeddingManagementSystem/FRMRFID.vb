Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMRFID

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        TXTRFID.Clear()
        Me.Hide()
        FRMLOGIN.Show()
    End Sub

    Private Sub BTNLOGINRFID_Click(sender As Object, e As EventArgs) Handles BTNLOGINRFID.Click
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
            Dim filterBuilder As FilterDefinitionBuilder(Of BsonDocument) = Builders(Of BsonDocument).Filter
            Dim filter = filterBuilder.Eq(Of BsonValue)("RFID", TXTRFID.Text)

            Dim result = collection.Find(filter).ToList()
            If result.Count > 0 Then
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Perform the necessary operations after successful login
                ' For example, open the main form and close the current form
                TXTRFID.Clear()
                FRMMAIN.ShowDialog()
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
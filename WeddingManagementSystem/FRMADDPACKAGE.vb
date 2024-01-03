Imports MongoDB.Driver
Imports MongoDB.Bson
Public Class FRMADDPACKAGE

    Private Sub FRMADDPACKAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        TXTID.Text = Format(dateAndTime, "mmssFFFF").ToString
    End Sub

    Public Sub CLEAR()
        TXTID.Clear()
        TXTDESCRIPTION.Text = ""
        TXTNAME.Text = ""
        TXTPRICE.Text = ""
    End Sub
    Private Sub BTNSAVEE_Click(sender As Object, e As EventArgs) Handles BTNSAVE.Click
        Try
            If MsgBox("Do you want to save Package?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
                Dim document As New BsonDocument()
                document.Add("ID", TXTID.Text)
                document.Add("NAME", TXTNAME.Text)
                document.Add("DESCRIPTION", TXTDESCRIPTION.Text)
                document.Add("PRICE", TXTPRICE.Text)
                collection.InsertOne(document)
                CLEAR()
                MessageBox.Show("Package Save successfully!", "Package Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMSERVICES
                    .LOADPACKAGES()
                    Me.Hide()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNHIDE_Click(sender As Object, e As EventArgs)
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click
        Try
            If MsgBox("Update package?", vbQuestion + vbYesNo) = vbYes Then
                Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPACKAGES)
                Dim APPID As String = TXTID.Text
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("ID", APPID)

                Dim updateDefinition As New BsonDocument()
                updateDefinition("NAME") = TXTNAME.Text
                updateDefinition("DESCRIPTION") = TXTDESCRIPTION.Text
                updateDefinition("PRICE") = TXTPRICE.Text
                collection.UpdateOne(filter, New BsonDocument("$set", updateDefinition))
                MessageBox.Show("Package updated successfully", "Package Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With FRMSERVICES
                    .LOADPACKAGES()
                    Me.Hide()
                End With
                CLEAR()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Private Sub TXTPRICE_TextChanged(sender As Object, e As EventArgs) Handles TXTPRICE.TextChanged

    End Sub

    Private Sub TXTPRICE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRICE.KeyPress
        ' Allow digits (0-9), backspace, and decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "." AndAlso DirectCast(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTNAME.SelectedIndexChanged
        PACKAGEPRICE()
    End Sub

    Public Sub PACKAGEPRICE()
        If TXTNAME.Text = "ELITE" Then
            TXTPRICE.Text = "150000"
        ElseIf TXTNAME.Text = "GOLD" Then
            TXTPRICE.Text = "120000"
        ElseIf TXTNAME.Text = "PREMIER" Then
            TXTPRICE.Text = "90000"
        ElseIf TXTNAME.Text = "ELEGANT" Then
            TXTPRICE.Text = "60000"
        ElseIf TXTNAME.Text = "CLASSIC" Then
            TXTPRICE.Text = "30000"
        Else
            TXTPRICE.Text = "No package price"

        End If
    End Sub

End Class
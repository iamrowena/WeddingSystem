Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class FRMDASHBOARD
    Public Property PANELMAIN As Object

    Private Sub CalculateAndDisplaySum(fieldName As String)
        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPAYMENT)
        Dim filter = Builders(Of BsonDocument).Filter.Empty
        Dim cursor = collection.Find(filter)
        Dim sum As Double = 0

        For Each document As BsonDocument In cursor.ToEnumerable()
            Dim fieldValue As BsonValue = document.GetValue(fieldName)

            If fieldValue.IsNumeric Then
                sum += fieldValue.ToDouble()
            ElseIf fieldValue.IsString Then
                ' Handle string values if needed (convert to double or handle appropriately)
                Dim numericValue As Double
                If Double.TryParse(fieldValue.ToString(), numericValue) Then
                    sum += numericValue
                End If
            End If
        Next

        TTLSALEStxt.Text = sum.ToString()
    End Sub

    Public Sub LoadTotalClient()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLCLIENT)
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            ' Specify the field name for which you want to count data
            Dim fieldName As String = "NAME"

            ' Perform MongoDB count operation
            Dim count = collection.CountDocuments(filter)

            ' Display the count in the TextBox
            TTLCLNTtxt.Text = count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadTotalAdmin()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            ' Specify the field name for which you want to count data
            Dim fieldName As String = "NAME"

            ' Perform MongoDB count operation
            Dim count = collection.CountDocuments(filter)

            ' Display the count in the TextBox
            TTLADMtxt.Text = count.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub LoadTotalVendor()
        Try
            Dim database As IMongoDatabase = client.GetDatabase(databaseName)
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLVENDOR)
            Dim filter = Builders(Of BsonDocument).Filter.Empty
            ' Specify the field name for which you want to count data
            Dim fieldName As String = "NAME"

            ' Perform MongoDB count operation
            Dim count = collection.CountDocuments(filter)

            ' Display the count in the TextBox
            TTLVENtxt.Text = count.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub main_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTotalClient()
        CalculateAndDisplaySum("DOWNPAY")
        LoadTotalAdmin()
        LoadTotalVendor()
        LoadName()
    End Sub

    Public Sub LoadName()
        Dim searchValue = FRMLOGIN.TXTUSERNAME.Text

        Dim database As IMongoDatabase = client.GetDatabase(databaseName)
        Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLPLANNER)
        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("USERNAME", searchValue)
        Dim document = collection.Find(filter).FirstOrDefault()

        ' Display additional information in the TextBox
        If document IsNot Nothing Then
            TXTNAME.Text = document("NAME").AsString
            TXTID.Text = document("ID").AsString ' Replace "additional_field" with the actual field you want to display
        Else
            TXTNAME.Text = "No Admin Name"
            TXTID.Text = "No Admin ID" ' Clear TextBox if no matching document found
        End If
    End Sub

    Private Sub BTNLOGOUT_Click(sender As Object, e As EventArgs) Handles BTNLOGOUT.Click
        FRMMAIN.Hide()
        FRMLOGIN.Show()
    End Sub

    Private Sub TTLSALEStxt_Click(sender As Object, e As EventArgs) Handles TTLSALEStxt.Click

    End Sub
End Class
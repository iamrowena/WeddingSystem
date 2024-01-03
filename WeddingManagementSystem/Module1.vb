Imports MongoDB.Driver
Imports MongoDB.Bson
Module Module1

    Public constring As String = "MONGODB_URL"

    Public client As New MongoClient(constring)

    Public databaseName As String = "databaseName"
    Public collectionName As String = "collectionName"

    Public database As IMongoDatabase = client.GetDatabase(databaseName)

End Module

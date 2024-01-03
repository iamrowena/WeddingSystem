Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.IO.Ports
Public Class FRMADDMESSAGES
    Private Sub FRMADDMESSAGES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PortLoad()
    End Sub
    Public Sub CLEAR()
        TXTID.Clear()
        TXTNAME.Text = ""
        TXTCONTACT.Clear()
        TXTDATE.Text = ""
        TXTMESSAGES.Clear()
        TXTSUBJECT.Clear()
    End Sub
    Public Sub GENERATEID()
        Dim dateAndTime As Date
        dateAndTime = Now
        TXTID.Text = Format(dateAndTime, "yyMMddHHmmssFFF").ToString
    End Sub

    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTNSEND.Click
        SaveMessage()
    End Sub

    Sub message()
        Dim receiverNumber As String = TXTCONTACT.Text
        Dim messageContent As String = "EZWeddingApp send successfully"
        If String.IsNullOrEmpty(receiverNumber) OrElse String.IsNullOrEmpty(messageContent) Then
            MessageBox.Show("Please enter a receiver's number and a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim atCommand As String = "AT+CMGS=" & """" & receiverNumber & """" & vbCr

        If SerialPort1.IsOpen = True Then
            SerialPort1.Write("AT" & vbCrLf)
            SerialPort1.Write("AT+CMGF=1" & vbCrLf)
            SerialPort1.Write(atCommand)
            Dim response As String = SerialPort1.ReadExisting()
            Do Until response.Contains(">")
                response &= SerialPort1.ReadExisting()
            Loop
            SerialPort1.Write(messageContent & Chr(26))
            System.Threading.Thread.Sleep(5000)
            Dim newresponse = SerialPort1.ReadExisting()
            If newresponse.Contains("OK") Then

                MessageBox.Show("Message sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SaveMessage()
                MessageBox.Show("Custom information inserted successfully.", "Upload Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Else
            MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FRMMESSAGES.LOADMESSAGES()
        End If
    End Sub
    Public Sub SendAndSaveMESSAGE()
        'CreateMsg()
        Dim receiverNumber As String = TXTCONTACT.Text
        Dim messageContent As String = TXTMESSAGES.Text
        ' Check if the receiver's number and message content are not empty
        If String.IsNullOrEmpty(receiverNumber) OrElse String.IsNullOrEmpty(messageContent) Then
            MessageBox.Show("Please enter a receiver's number and a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Format the AT command to send the message
        Dim atCommand As String = "AT+CMGS=" & """" & receiverNumber & """" & vbCr

        If SerialPort1.IsOpen = True Then
            SerialPort1.Write("AT" & vbCrLf)
            SerialPort1.Write("AT+CMGF=1" & vbCrLf)
            SerialPort1.Write(atCommand)
            MessageBox.Show("Port Open")
            Dim response As String = SerialPort1.ReadExisting()
            Do Until response.Contains(">")
                response &= SerialPort1.ReadExisting()
            Loop
            SerialPort1.Write(messageContent & Chr(26))
            System.Threading.Thread.Sleep(5000)
            Dim newresponse = SerialPort1.ReadExisting()
            If newresponse.Contains("OK") Then
                SaveMessage()
                MessageBox.Show("Message sent and saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to send message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error: Invalid Port", "Port", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub SaveMessage()
        'Save data to tblmessages
        If TXTSUBJECT.Text = String.Empty Then
            MsgBox("Input Subject")
        Else
            Try
                If MsgBox("Do you want to save messages?", vbQuestion + vbYesNo) = vbYes Then
                    'CreateMsg()
                    Dim database As IMongoDatabase = client.GetDatabase(databaseName)
                    Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)(collectionTBLMESSAGES)
                    Dim document As New BsonDocument()
                    document.Add("ID", TXTID.Text)
                    document.Add("NAME", TXTNAME.Text)
                    document.Add("CONTACT", TXTCONTACT.Text)
                    document.Add("DATE", TXTDATE.Text)
                    document.Add("SUBJECT", TXTSUBJECT.Text)
                    document.Add("MESSAGES", TXTMESSAGES.Text)
                    collection.InsertOne(document)
                    MessageBox.Show("Messages Save successfully!", "Messages Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    With FRMMESSAGES
                        .LOADMESSAGES()
                        Me.Hide()
                    End With
                    CLEAR()
                End If
            Catch ex As Exception
                MessageBox.Show("Error inserting document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Me.Hide()
        CLEAR()
    End Sub

    Private Sub BTNCONTACT_Click(sender As Object, e As EventArgs) Handles BTNCONTACT.Click
        With FRMCONTACT
            Me.CLEAR()
            .Show()
            .LOADvendor()
            .LOADplanner()
        End With
    End Sub

    Public Sub PortLoad()
        SerialPort1 = New SerialPort()
        SerialPort1.PortName = "COM3"
        SerialPort1.BaudRate = 115200
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Handshake = Handshake.None
        SerialPort1.DtrEnable = True
        SerialPort1.RtsEnable = True
        SerialPort1.NewLine = vbCrLf
        SerialPort1.Open()
    End Sub
    Public Sub CreateMsg()
        Dim Who = TXTNAME.Text & vbNewLine & vbNewLine
        Dim SUBJ = TXTSUBJECT.Text & vbNewLine & vbNewLine
        Dim BODY = vbNewLine & vbNewLine & "<message here>" & TXTMESSAGES.Text & vbNewLine & vbNewLine
        Dim Greet = ("Good day! Ms./Mr. ")
        Dim About = ("This is EZ Wedding. We are here to tell you about ")
        Dim Note = vbNewLine & vbNewLine & ("To be updated please check our EZ Wedding App. Thankyou!")
        TXTMESSAGES.Text = Greet + Who + About + SUBJ + BODY + Note
    End Sub

    Private Sub TXTSUBJECT_TextChanged(sender As Object, e As EventArgs) Handles TXTSUBJECT.TextChanged
        If TXTSUBJECT.Text = "" Then

        Else
            TXTMESSAGES.Text = ""
            CreateMsg()
        End If
    End Sub

    Private Sub TXTMESSAGES_TextChanged(sender As Object, e As EventArgs) Handles TXTMESSAGES.TextChanged
        If TXTSUBJECT.Text = "" Then
            MsgBox("Input subject!")
        End If
    End Sub
End Class
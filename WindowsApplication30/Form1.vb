Imports System.Net.Sockets

Public Class Form1

    Private Shared i As Integer

    Private Sub SendData() Handles Button2.Click
        Dim st As New StartArguments()
        st.server = host.Text
        st.port = port.Text
        st.message = data.Text
        st.waitResponse = waitResponse.Checked

        While i < 1000
            Dim t As New Threading.Thread(New Threading.ParameterizedThreadStart(AddressOf Connect))
            t.Start(st)

            Threading.Thread.Sleep(5 * 1000)
            Application.DoEvents()

            i = i + 1
            Me.Text = i
        End While
        

        Connect(st)
    End Sub

    Shared Sub Connect(st As StartArguments)
        Dim server As String = st.server
        Dim port As Integer = st.port
        Dim message As String = st.message
        Dim waitResponse As Boolean = st.waitResponse
        Try
            ' Create a TcpClient. 
            ' Note, for this client to work you need to have a TcpServer  
            ' connected to the same address as specified by the server, port 
            ' combination. 
            Dim client As New TcpClient(server, port)

            ' Translate the passed message into ASCII and store it as a Byte array. 
            Dim data As [Byte]() = System.Text.Encoding.ASCII.GetBytes(message)

            ' Get a client stream for reading and writing. 
            '  Stream stream = client.GetStream(); 
            Dim stream As NetworkStream = client.GetStream()

Vorta:

            ' Send the message to the connected TcpServer. 
            stream.Write(data, 0, data.Length)

            Threading.Thread.Sleep(10000)

            'Form1.Text = "Sent " + Now.ToString

            GoTo Vorta



            If waitResponse Then
                ' Receive the TcpServer.response. 
                ' Buffer to store the response bytes.
                data = New [Byte](256) {}

                ' String to store the response ASCII representation. 
                Dim responseData As [String] = [String].Empty

                ' Read the first batch of the TcpServer response bytes. 
                Dim bytes As Int32 = stream.Read(data, 0, data.Length)
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes)

                MsgBox(String.Format("Received: {0}", responseData))
            End If

            ' Close everything.
            stream.Close()
            client.Close()
        Catch e As ArgumentNullException
            'MsgBox(String.Format("ArgumentNullException: {0}", e))
        Catch e As SocketException
            'MsgBox(String.Format("SocketException: {0}", e))
        Catch e As Exception

        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bData(2) As Byte
        bData(0) = &H65
        bData(1) = &H66
        bData(2) = &H13

        MsgBox(BitConverter.ToString(bData))
    End Sub

    Private Sub SendLoop_CheckedChanged(sender As Object, e As EventArgs) Handles SendLoop.CheckedChanged

        'While SendLoop.Checked
        '    Me.SendData()
        '    System.Windows.Forms.Application.DoEvents()
        'End While

    End Sub

End Class

Public Class StartArguments
    Public server As String
    Public port As Integer
    Public message As String
    Public waitResponse As Boolean
End Class

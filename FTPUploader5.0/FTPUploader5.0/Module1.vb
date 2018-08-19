Imports System.Configuration
Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
Imports System.Text
Imports Renci.SshNet
Module Module1

    Sub Main()
        Dim FileLoc As String = ConfigurationSettings.AppSettings("FolderLocation")
        Dim SFTPpath As String = ConfigurationSettings.AppSettings("PathtoSFTP")
        Dim userN As String = ConfigurationSettings.AppSettings("UserNameSFTP")
        Dim password As String = ConfigurationSettings.AppSettings("PasswordSFTP")
        Dim destination As String = ConfigurationSettings.AppSettings("destinationSFTP")
        Dim port As Integer = ConfigurationSettings.AppSettings("PortSFTP")
        Dim FileLocArchive As String = ConfigurationSettings.AppSettings("FolderLocationArchive")


        UploadSFTPFile(SFTPpath, userN, password, FileLoc, FileLocArchive, port)

    End Sub

    Private Function UploadSFTPFile(ByVal host As String, ByVal username As String, ByVal password As String, ByVal sourcefile As String, ByVal archivePath As String, ByVal port As Integer)

        Dim now As Date = Date.Now

        Console.WriteLine(now.ToString() & " CONNECTING TO " & host)

        If isValidConnection(host, username, password, port) = False Then
            Exit Function
        End If

        If host Is Nothing Then
            Console.WriteLine(now.ToString() & ": ERROR: FTP Address is empty")
            Console.WriteLine("FILE DID NOT SEND")

        ElseIf username Is Nothing Then
            Console.WriteLine(now.ToString() & ": ERROR: User Name is empty")
            Console.WriteLine("FILE DID NOT SEND")

        ElseIf password Is Nothing Then
            Console.WriteLine(now.ToString() & ": ERROR: Password is empty")
            Console.WriteLine("FILE DID NOT SEND")

        ElseIf sourcefile Is Nothing Then
            Console.WriteLine(now.ToString() & ": ERROR: File Location is empty")
            Console.WriteLine("FILE DID NOT SEND")

        Else

            Dim currentFile As String
            Dim count As Integer
            Try

                'Set the current directory
                Directory.SetCurrentDirectory(sourcefile)

                'Loops through files inside specified folder
                For Each currentFile In Directory.GetFiles(sourcefile)

                    Console.WriteLine(now.ToString() & " SENDING FILE: " & Path.GetFileName(currentFile.ToString()))
                    count = count + 1

                    'Check to see if file there is a file in directory and if not display that "NO FILE IS FOUND"
                    If currentFile Is Nothing Then
                        Console.WriteLine(now.ToString() & " NO FILE IS FOUND")
                    End If

                    Using client As SftpClient = New SftpClient(host, port, username, password)
                        client.Connect()

                        'Reads the current file and uploads it
                        Using fs As FileStream = New FileStream(currentFile, FileMode.Open)
                            client.BufferSize = 4 * 1024
                            client.UploadFile(fs, Path.GetFileName(currentFile))
                        End Using
                    End Using

                    'Move File Up A Directory and into archive
                    File.Move(Path.GetFullPath(currentFile), (archivePath & Path.GetFileName(currentFile)))

                    Console.WriteLine(now.ToString() & " " & Path.GetFileName(currentFile.ToString()) & " was sent!")
                    Console.WriteLine(now.ToString() & " " & Path.GetFileName(currentFile.ToString()) & " was sent to " & archivePath)

                Next

                'Catches exception when directory is not found
            Catch ex As DirectoryNotFoundException
                Console.WriteLine("ERROR: " & ex.ToString())
                Exit Function
            End Try

            Console.WriteLine(now.ToString() & " " & count & " FILES SENT SUCCESSFULLY!")
        End If

    End Function
    Private Function isValidConnection(ByVal host As String, ByVal user As String, ByVal password As String, ByVal port As Integer) As Boolean

        Dim now As Date = Date.Now

        Try
            'Set up SFTP Connect
            Dim request As SftpClient = New SftpClient(host, port, user, password)
            request.Connect()

        Catch ex As Sockets.SocketException

            'Displays if connection is fails and displays exception error
            Console.WriteLine(now.ToString() & " FAILED TO CONNECT TO " & host)
            Console.WriteLine(now.ToString() & " ERROR: " & ex.ToString())
            Return False
            Exit Function

        Catch ex As Common.SshAuthenticationException
            'Displays if connection is fails and displays exception error
            Console.WriteLine(now.ToString() & " FAILED TO CONNECT TO " & host)
            Console.WriteLine(now.ToString() & " ERROR: " & ex.ToString())
            Return False
            Exit Function

        Catch ex As Common.SshConnectionException
            'Displays if connection is fails and displays exception error
            Console.WriteLine(now.ToString() & " FAILED TO CONNECT TO " & host)
            Console.WriteLine(now.ToString() & " ERROR: " & ex.ToString())
            Return False
            Exit Function

        End Try

        'Displays if connection is successful
        Console.WriteLine(now.ToString() & " SUCCESSFUL CONNECTION TO " & host)
        Return True
    End Function

End Module

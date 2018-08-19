Public Class Form1

    Private Sub encryptBtn_Click(sender As Object, e As EventArgs) Handles encryptBtn.Click
        encryptLabel.Text = AsciiSwitch(TextBox1.Text, 20)
    End Sub

    Private Sub decryptBtn_Click(sender As Object, e As EventArgs) Handles decryptBtn.Click
        decryptedLabel.Text = AsciiSwitch(encryptLabel.Text, -20)
    End Sub

    Function AsciiSwitch(inputString As String, valueToAdd As Integer) As String

        Dim outputString As String = String.Empty
        Dim c As Char

        For i = 0 To Len(inputString) - 1
            c = inputString.Substring(i, 1)
            outputString += Chr(Asc(c) + valueToAdd)
        Next

        Return outputString

    End Function
End Class

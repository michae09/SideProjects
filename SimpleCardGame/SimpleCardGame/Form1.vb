Public Class Form1
    Dim Cards As String() = New String() {"Ace", "King", "Queen", "Joker", "10", "9", "8", "7", "6", "5", "4", "3", "2"}

    Dim Ace As Integer = 14
    Dim King As Integer = 13
    Dim Queen As Integer = 12
    Dim Joker As Integer = 11
    Dim Ten As Integer = 10
    Dim Nine As Integer = 9
    Dim Eight As Integer = 8
    Dim Seven As Integer = 7
    Dim Six As Integer = 6
    Dim Five As Integer = 5
    Dim Four As Integer = 4
    Dim Three As Integer = 3
    Dim Two As Integer = 2

    Dim AcePic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_ad.png")
    Dim KingPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_kd.png")
    Dim QueenPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_qd.png")
    Dim JokerPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_jd.png")
    Dim TenPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_10s.png")
    Dim NinePic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_9s.png")
    Dim EightPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_8s.png")
    Dim SevenPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_7s.png")
    Dim SixPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_6s.png")
    Dim FivePic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_5s.png")
    Dim FourPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_4s.png")
    Dim ThreePic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_3s.png")
    Dim TwoPic As Image = Image.FromFile("C:\Users\mazu\Documents\visual studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\rsz_2s.png")

    Dim AceCard As Card = New Card(Ace, AcePic, Cards(0).ToString)
    Dim KingCard As Card = New Card(King, KingPic, Cards(1).ToString)
    Dim QueenCard As Card = New Card(Queen, QueenPic, Cards(2).ToString)
    Dim JokerCard As Card = New Card(Joker, JokerPic, Cards(3).ToString)
    Dim TenCard As Card = New Card(Ten, TenPic, Cards(4).ToString)
    Dim NineCard As Card = New Card(Nine, NinePic, Cards(5).ToString)
    Dim EightCard As Card = New Card(Eight, EightPic, Cards(6).ToString)
    Dim SevenCard As Card = New Card(Seven, SevenPic, Cards(7).ToString)
    Dim SixCard As Card = New Card(Six, SixPic, Cards(8).ToString)
    Dim FiveCard As Card = New Card(Five, FivePic, Cards(9).ToString)
    Dim FourCard As Card = New Card(Four, FourPic, Cards(10).ToString)
    Dim ThreeCard As Card = New Card(Three, ThreePic, Cards(11).ToString)
    Dim TwoCard As Card = New Card(Two, TwoPic, Cards(12).ToString)

    Dim CardPics As Image() = New Image() {AcePic, KingPic, QueenPic, JokerPic, TenPic,
                                     NinePic, EightPic, SevenPic, SixPic, FivePic,
        FourPic, ThreePic, TwoPic}
    Private Sub Delay(ByVal DelayInSeconds As Integer)
        Dim ts As TimeSpan
        Dim targetTime As DateTime = DateTime.Now.AddSeconds(DelayInSeconds)
        Do
            ts = targetTime.Subtract(DateTime.Now)
            Application.DoEvents() ' keep app responsive
            System.Threading.Thread.Sleep(50) ' reduce CPU usage
        Loop While ts.TotalSeconds > 0
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Winner1.Visible = False
        Winner2.Visible = False
        'Threading.Thread.Sleep(5000)
        WebBrowser1.ScrollBarsEnabled = False
        WebBrowser1.Navigate("C:\Users\mazu\Documents\Visual Studio 2015\Projects\SimpleCardGame\SimpleCardGame\CardPictures\ezgif.com-resize.gif")
        WebBrowser1.Visible = True



        Dim Random As Random = New Random
        Dim Player1Choice As Integer = Random.Next(2, 14)
        Dim Player2Choice As Integer = Random.Next(2, 14)


        Delay(2)


        Select Case Player1Choice
            Case 2
                PictureBox1.Image = TwoPic
            Case 3
                PictureBox1.Image = ThreePic
            Case 4
                PictureBox1.Image = FourPic
            Case 5
                PictureBox1.Image = FivePic
            Case 6
                PictureBox1.Image = SixPic
            Case 7
                PictureBox1.Image = SevenPic
            Case 8
                PictureBox1.Image = EightPic
            Case 9
                PictureBox1.Image = NinePic
            Case 10
                PictureBox1.Image = TenPic
            Case 11
                PictureBox1.Image = JokerPic
            Case 12
                PictureBox1.Image = QueenPic
            Case 14
                PictureBox1.Image = KingPic
            Case 14
                PictureBox1.Image = AcePic
        End Select


        Select Case Player2Choice
                Case 2
                    PictureBox2.Image = TwoPic
                Case 3
                    PictureBox2.Image = ThreePic
                Case 4
                    PictureBox2.Image = FourPic
                Case 5
                    PictureBox2.Image = FivePic
                Case 6
                    PictureBox2.Image = SixPic
                Case 7
                    PictureBox2.Image = SevenPic
                Case 8
                    PictureBox2.Image = EightPic
                Case 9
                    PictureBox2.Image = NinePic
                Case 10
                    PictureBox2.Image = TenPic
                Case 11
                    PictureBox2.Image = JokerPic
                Case 12
                    PictureBox2.Image = QueenPic
                Case 14
                    PictureBox2.Image = KingPic
                Case 14
                    PictureBox2.Image = AcePic
            End Select

        Delay(1)
        WebBrowser1.Visible = False

        If Player1Choice > Player2Choice Then
            Winner1.Visible = True
        ElseIf Player2Choice > Player1Choice Then
            Winner2.Visible = True
        End If

    End Sub




End Class

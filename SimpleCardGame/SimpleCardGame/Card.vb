Public Class Card

    Private cardNumber As Integer
    Private cardFace As Image
    Private cardName As String

    Public Sub New(ByVal CNum As Integer, ByVal CF As Image, ByVal CNam As String)
        CNum = cardNumber
        CF = cardFace
        CNam = cardName
    End Sub

    Public Property cardValue() As Integer
        Get
            Return cardNumber
        End Get
        Set(ByVal value As Integer)
            cardNumber = value
        End Set
    End Property
    Public Property cardPic() As Image
        Get
            Return cardFace
        End Get
        Set(ByVal value As Image)
            cardFace = value
        End Set
    End Property

    Public Property cardNm() As String
        Get
            Return cardName
        End Get
        Set(ByVal value As String)
            cardName = value
        End Set
    End Property

End Class

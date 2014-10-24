Public Class Auto

    'Privater Member der nur in dieser Klasse verwendet werden kann
    Private _hersteller As String = "BMW"

    'Public Member können auch von Aussen gelesen und geschrieben werden
    Public farbe As String
    Public geschwindigkeit As Integer

    'Für Funktionen und Sub´s gilt das gleiche Publich Funktionen können auch von Aussen genutzt werden.
    Public Function Beschleunigen(ByVal wert As Integer) As Integer
        geschwindigkeit = geschwindigkeit + wert
        Return geschwindigkeit
    End Function

    'Eine verkürzte Schreibweise der gleichen Funktion. Da Sie als "Private" deklariert ist kann sie nicht von aussen gesehen werden.
    Private Function BeschleunigenPrivate(ByVal wert As Integer) As Integer
        Return geschwindigkeit + wert
    End Function

End Class

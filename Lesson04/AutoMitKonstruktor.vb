Option Strict On
Option Explicit On

Public Class AutoMitKonstruktor

    Private _farbe As String
    Private _leistung As Integer

    Sub New()
        _farbe = "weiß"
        _leistung = 50
    End Sub

    Sub New(ByVal standardFarbe As String, ByVal standardLeistung As Integer)
        _farbe = standardFarbe
        _leistung = standardLeistung
    End Sub

    Public Property Farbe() As String
        Get
            Return _farbe
        End Get
        Set(ByVal value As String)
            _farbe = value
        End Set
    End Property

    Public Property Leistung() As Integer
        Get
            Return _leistung
        End Get
        Set(ByVal value As Integer)
            _leistung = LeistungsBegrenzung(value, 100)
        End Set
    End Property

    Private Function LeistungsBegrenzung(ByVal ps As Integer, ByVal maxPs As Integer) As Integer
        If ps > maxPs Then
            Return maxPs
        Else
            Return _leistung
        End If
    End Function

End Class

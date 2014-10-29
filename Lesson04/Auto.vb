Option Strict On
Option Explicit On

Public Class Auto

    Private _hersteller As String
    Public Property Hersteller() As String
        Get
            Return _hersteller
        End Get
        Set(ByVal value As String)
            _hersteller = value
        End Set
    End Property

    Private _farbe As String
    Public Property Farbe() As String
        Get
            Return _farbe
        End Get
        Set(ByVal value As String)
            _farbe = value
        End Set
    End Property

    Private _leistung As Integer
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

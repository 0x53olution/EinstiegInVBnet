Option Strict On
Option Explicit On

Public Class Grundrechenarten

    Public zwischenergebnis As Integer
    Private _neuesZwischenergebnis As Integer

    Public Function Addtion(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
        _neuesZwischenergebnis()
    End Function


    Public Sub Subtraktion()
        zwischenergebnis()
    End Sub

    Private Function Kontrolle()
        zwischenergebnis()
    End Function

End Class

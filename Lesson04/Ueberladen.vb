Option Strict On
Option Explicit On

Public Class Ueberladen

    'Funktion die zwei Integerwerte Addiert
    Public Function Addiere(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a + b
    End Function

    'Ohne Überladung würde man einen anderen Methodennamen wählen
    Public Function AddiereDouble(ByVal a As Double, ByVal b As Double) As Double
        Return a + b
    End Function

    'Besser wäre es die Funktion zu überladen
    'Der gleiche Funktionsname kann verwendet werden da die Datentypen unterschiedlich sind
    Public Function Addiere(ByVal a As Double, ByVal b As Double) As Double
        Return a + b
    End Function

End Class

Public Class Access

    'Öffentliche Variable die auch von anderen Klassen zugegriffen werden kann
    Public isRunning As Boolean = True

    'Variablen die in öffentlichen prozeduren verwendet werden sind nur lokal in der Prozedur zugreifbar
    Public Sub DoSomething()
        Dim name As String = "Krümelmonster"
    End Sub
End Class

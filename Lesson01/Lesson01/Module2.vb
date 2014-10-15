Option Strict On
Option Explicit On

Module Module2

    Public Sub WeitereWichtigeDatentypen()
        'Arrays (Felder) http://msdn.microsoft.com/de-de/library/wak0wfyt.aspx
        'Eindimensional
        Dim baureihen(5) As String 'Arrays beginnen bei 0
        baureihen(0) = "F10"
        baureihen(1) = "F11"
        baureihen(2) = "F12"
        baureihen(3) = "F01"
        baureihen(4) = "F02"
        baureihen(5) = "F03"
        Console.WriteLine("5er ist die Baureihe: " & baureihen(0))

        'Deklaration mit Anfangswerten. Die Grösse wird automatisch bestimmt
        Dim baureihe5er As String() = {"F10", "F11"}
        Console.WriteLine("5er Limusine: " & baureihe5er(0) & " ;5er Touring: " & baureihe5er(1))

        'Mehrdimensional
        Dim werkBaureihe(1, 1) As String
        werkBaureihe(0, 0) = "Dingolfing"
        werkBaureihe(0, 1) = "F10"
        werkBaureihe(1, 0) = "München"
        werkBaureihe(1, 1) = "F30"
        Console.WriteLine("Der 5er wird in " & werkBaureihe(0, 0) & " gebaut. Der 3er wird in " & werkBaureihe(1, 0) & " gebaut.")

        'Dictionary (unsortiert)
        Dim bestellungen As New Dictionary(Of String, Integer)
        'Das Dictionary besteht aus Schlüssel und Element
        bestellungen.Add("F10", 5)
        bestellungen.Add("F11", 8)

        If bestellungen.ContainsKey("F10") Then
            Console.WriteLine("Anzahl der Bestellungen für den F10: " & bestellungen.Item("F10"))
        End If

        'Liste
        Dim meineAutoListe As New List(Of String)
        meineAutoListe.Add("Bmw")
        meineAutoListe.Add("Volkswagen")

        Dim anzahlInMeinerAutoListe As Integer = meineAutoListe.Count
        Console.WriteLine("In meiner Autoliste sind " & meineAutoListe.Count & " (" & meineAutoListe.Item(0) & ", " & meineAutoListe.Item(1) & ")")

        Console.Read()
    End Sub

End Module

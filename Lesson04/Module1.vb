Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        'AutoKonfigurieren("BMW", "rot")
        'AutoKonfigurierenProperty("BMW", "rot")
        'UeberladenBeispiel()
        KlassenKonstruktor()
    End Sub

    'Methode mit einem Konstruktor der zwei Strings erwartet
    Private Sub AutoKonfigurieren(ByVal automarke As String, ByVal autofarbe As String)
        Dim meinAuto As New Auto

        meinAuto.Hersteller = automarke
        meinAuto.Farbe = autofarbe

        Console.WriteLine("Ihr Auto ist von " & meinAuto.Hersteller & " und hat die Farbe " & meinAuto.Farbe & ".")

        Console.Read()
    End Sub

    Private Sub AutoKonfigurierenProperty(ByVal automarke As String, ByVal autofarbe As String)
        Dim meinAuto As New Auto

        meinAuto.Hersteller = automarke
        meinAuto.Farbe = autofarbe

        'Usereingabe einlesen (Zum testen des Property einen Wert > 100 eingeben)
        Console.Write("Bitte die gewünschte Leistung in PS eingeben: ")
        meinAuto.Leistung = CInt(Console.ReadLine())

        'Ausgabe um zu sehen ob das property die Leistung auf 100PS begrenzt
        Console.WriteLine("Ihr Auto hat " & meinAuto.Leistung & "PS")

        Console.Read()
    End Sub

    Private Sub UeberladenBeispiel()
        Dim meineUeberladung As New Ueberladen
        Dim ergebnis = meineUeberladung.Addiere(5, 3)

        Console.WriteLine("Ergebnis der Addition: " & ergebnis)
        Console.Read()
    End Sub

    Private Sub KlassenKonstruktor()
        Dim meinAuto As New AutoMitKonstruktor("rot", 75)
        Console.WriteLine("meinAuto wurde mit der Frabe " & meinAuto.Farbe & " und der Leistung " & meinAuto.Leistung & " instanziiert")
        Console.Read()
    End Sub

End Module

Option Strict On
Option Explicit On

Module Module1

    'Klassenweite Variable
    Dim _isActiveKlasse1 As Boolean = True
    'Der Übersicht und Lesbarkeit halber besser (Klassenvariablen die mit Dim deklarietrt werden sind automatisch Private)
    Private _isActiveKlasse2 As Boolean = True

    Sub Main()
        AccessLevel()
        'AccessLevelTest()
        'ErsteKlasse()
        'ZweiteKlasse()
    End Sub

    'Gültigkeitsbereiche von Variablen
    Public Sub AccessLevel()
        Dim isActive As Boolean = True

        If isActive Then
            Console.WriteLine("Variable ist " & isActive)
        End If

        Console.Read()
    End Sub

    Private Sub AccessLevelTest()
        'Auf eine Variable in einer anderen Prozedur kann nicht zugegriffen werden
        'If isActive Then
        '    Console.WriteLine("Variable ist " & isActive)
        'End If

        'Klassenvariablen können problemlos erreicht werden
        If _isActiveKlasse1 Then
            Console.WriteLine("_isActiveKlasse1 ist " & _isActiveKlasse1)
        End If

        If _isActiveKlasse2 Then
            Console.WriteLine("_isActiveKlasse2 ist " & _isActiveKlasse2)
        End If

        'Variablen aus anderen Klassen die öffentlich sind kann zugegriffen werden
        Dim MeineAccessKlasse As New Access
        Dim oeffentlicheVariable = MeineAccessKlasse.isRunning
        'Auf die Variable in der öffentlichen Prozedur kann nicht zugegriffen werden
        'Dim prozedurVariable = MeineAccessKlasse.name

        Console.WriteLine("Die öffentliche Klassen Variable aus der Access Klasse: " & oeffentlicheVariable)

        Console.Read()
    End Sub

    Private Sub ErsteKlasse()
        'Klasse instanziieren
        'Objektvariable Mitarbeiter as Typ der zu instanziierenden Klasse definieren.
        'Sie dient zum Zugriff auf die Elemente der Klasse.
        Dim Mitarbeiter As Person
        'Mit dem Schlüsselwort New wird Speicherplatz für eine Instanz der Klasse auf dem Managed Heap reserviert.
        Mitarbeiter = New Person

        'oder das ganze in einem Schritt
        Dim Angestellter As New Person

        'Mit der Objektinstanz auf die Klassenmember zugreifen
        Mitarbeiter.nachname = "Gates"
        Mitarbeiter.vorname = "Bill"

        'Da die Klasse Person zweimal instanziiert wurde kann mit der zweiten Objektinstanz unabhänig von der ersten ein anderer Kontext verwendet werden.
        Angestellter.nachname = "Ballmer"
        Angestellter.vorname = "Steve"

        'Ausgabe
        Console.WriteLine("Erste Instanz: " & Mitarbeiter.vorname & " " & Mitarbeiter.nachname & " Zweite Instanz: " & Angestellter.vorname & " " & Angestellter.nachname)
        Console.Read()
    End Sub

    Private Sub ZweiteKlasse()
        Dim Firmenwagen As New Auto

        'Private Klassenmember können nicht geshen werden - _hersteller
        'Kommentar in der nächsten Zeile aufheben um über IntelliSense das Angebot der zugreifbaren Member zu sehen
        ' Firmenwagen._hersteller

        Firmenwagen.farbe = "rot"

        Firmenwagen.Beschleunigen(100)

        Console.WriteLine("Mein Firmenwagen hat die Farbe " & Firmenwagen.farbe)
        Console.WriteLine("Mein Firmenwagen fährt gerade " & Firmenwagen.geschwindigkeit & "km/h")
        Console.Read()
    End Sub

End Module

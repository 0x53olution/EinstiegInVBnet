Option Strict On
Option Explicit On

Module Module1

    Sub Main()
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

    End Sub

End Module

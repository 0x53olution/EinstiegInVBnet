Option Strict On
Option Explicit On

Module Module3

    Public Sub Rechenoperatoren()
        Dim zahlA As Integer = 10
        Dim zahlB As Integer = 7

        'Der Kompiler kann den Datentyp auch selber wählen:
        Dim ergebnisAdd = zahlA + zahlB 'Integer
        Dim ergebnisSub = zahlA - zahlB 'Integer
        Dim ergebnisMulti = zahlA * zahlB 'Integer
        Dim ergebnisDiv = zahlA / zahlB 'Double
        Dim ergebnisDivGanz = zahlA \ zahlB 'Integer
        'Um Code leserlicher zu gestalten kann die Zeile mit " _" umgebrochen werden.
        Console.WriteLine("Addition: " & ergebnisAdd & Environment.NewLine _
                          & "Subtration: " & ergebnisSub & Environment.NewLine _
                          & "Multiplikation: " & ergebnisMulti & Environment.NewLine _
                          & "Division: " & ergebnisDiv & Environment.NewLine _
                          & "Division Ganzzahlig: " & ergebnisDivGanz)

        'Modulooperator (Restwertdivision)
        Dim ergebnisMod = zahlA Mod 2
        Console.WriteLine("Modulo: " & ergebnisMod)

        Console.Read()

    End Sub

End Module

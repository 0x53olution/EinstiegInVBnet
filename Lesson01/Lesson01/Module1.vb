'Entweder in jeder Klasse/Modul deklarieren oder im Projekt selber
Option Strict On 'Schränkt die Datentykonvertierung ein http://msdn.microsoft.com/de-de/library/zcd4xwzs.aspx
Option Explicit On 'Erzwingt die explizite Variablendeklaration http://msdn.microsoft.com/de-de/library/y9341s4f.aspx

Module Module1

    'Main Methode
    'Jede Konsolenanwendung hat einen Einstiegspunkt. Die "Main" Methode.
    Sub Main()
        'Aufruf der Methode Datentypen
        'Datentypen()

        'WeitereWichtigeDatentypen()

        Rechenoperatoren()
    End Sub

    Private Sub Datentypen()
        'Deklarieren einer Variablen
        Dim maxInt32 As Integer

        'Zuweisung eines Wertes
        maxInt32 = Int32.MaxValue

        'Das ganze kann auch in einem Schritt erledigt werden
        Dim minInt32 As Integer = Int32.MinValue

        'Ausgabe auf der Konsole mit WriteLine. ".WriteLine" beinhaltet gegenüber ".Write" einen Zeilenumbruch am Ende der Zeile
        'Ausgabe in Textform wird immer in Anführungszeichen geschrieben.
        'Um Ausdücke zu verknüpfen wir der "&" Operator verwendet
        Console.WriteLine("Eine Integer Variable kann Zahlen von : " & minInt32 & " bis: " & maxInt32 & " annehmen.")

        'Beispiele für Zahlen
        Dim ganzeZahl As Integer = -123 'alle Ganzzahlen (positiv und negativ)
        Dim natuelicheZahlen As UInteger = 123 'alle positiven Ganzzahlen
        Dim rationaleZahlen As Double = -12.456 'alle rationalen Zahlen

        'Beispiele für Zeichenketten bzw. einzelne Zeichen
        Dim zeichenkette As String = "In einem String werden Unicodezeichen gespeichert"
        Dim zeichen As Char = "A"c 'Das kleine "c" dienst als Literaltypzeichen.

        'Beispiel für Wahrheitswerte
        Dim wahrheitswert As Boolean = True

        'Beispiel für einen beliebigen Datentyp
        'Da alle Datentypen von object abgeleitet sind kann object alles annehmen
        Dim ertsesObject = "Ein String in einem Objekt"
        Dim zweitesObject = 123

        'Ausgabe
        'Bevor die Ausgabe ausgegeben wird, wird die Zeile umgebrochen
        Console.WriteLine(Environment.NewLine & "Integer: " & ganzeZahl)
        'Alternativ kann auch Console.Write genutzt werden und der Zeilenumbruch manuelle ingefügt werden
        Console.Write("UInteger: " & natuelicheZahlen & Environment.NewLine)
        Console.WriteLine("Double: " & rationaleZahlen)
        Console.WriteLine("String: " & zeichenkette)
        Console.WriteLine("Char: " & zeichen)
        Console.WriteLine("Wahrheitswert: " & wahrheitswert)

        'Es soll nicht wirklich etwas eingelesen werden.
        'Das Konsolenfenster schließt sich aller dings nach der Abarbeitung. So wartet es auf eine Benutzereingabe.
        Console.Read()
    End Sub

End Module

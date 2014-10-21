Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        ForSchleife()
        'SelectFallunterscheidung()
        'ChooseFunktion()
        'ForNextSchleife()
        'DoLoopSchleife()
    End Sub

    Private Sub ForSchleife()
        'For Schleife in Blockschreibweise
        If IO.File.Exists("C:\Temp\TestFile.txt") Then
            'Falls die Auswertung True ergbibt
            Console.WriteLine("Das Dokument exisitiert")
        Else
            'Falls die Auswertung False ergibt
            Console.WriteLine("Das Dokument kann nicht gefunden werden")
        End If

        If IO.File.Exists("C:\Temp\TestFile.txt") Then
            'Falls die erste Auswertung True ergbibt
            Console.WriteLine("Das Dokument exisitiert")
        ElseIf IO.File.Exists("C:\Temp\TestFileZwei.txt") Then
            'Falls die erste Auswertung False ist wird die zweite abgefragt
            Console.WriteLine("Das zweite Dokument exisitiert")
        Else
            'Falls die Auswertung False ergibt
            Console.WriteLine("Das Dokument kann nicht gefunden werden")
        End If

        Console.Read()

        'Einzeiliges If ohne Else Teil
        If IO.File.Exists("C:\Temp\TestFile.txt") Then Console.WriteLine("Das Dokument exisitiert")

        Console.Read()

        'Einzeiliges If mit Else Teil
        If IO.File.Exists("C:\Temp\TestFile.txt") Then Console.WriteLine("Das Dokument exisitiert") Else Console.WriteLine("Das Dokument kann nicht gefunden werden")

        Console.Read()
    End Sub

    Private Sub FunktionIIfSchleife()
        'Eine IIf Schleife ähnelt dem einzeilige If Ausdruck. Ihr Unterschied ist das sie direkt einen Wert zurück liefert.
        'Allerdings muss der der True als auch der False Fall angegeben werden.
        Dim fileName As String = Nothing
        IIf(IO.File.Exists("C:\Temp\TestFile.txt"), fileName = "TestFile", fileName = "Test")
    End Sub

    Private Sub SelectFallunterscheidung()
        Dim meineZahl As Integer = 3
        'Eine Case Abfrage wird auf eine Integer Zahl angewendet
        Select Case meineZahl
            '1. Fall ist die Variable meineZahl ist = 1
            Case 1
                Console.WriteLine("Meine Zahl ist 1")
            Case 2
                Console.WriteLine("Meine Zahl ist 2")
            Case 3
                Console.WriteLine("Meine Zahl ist 3")
            Case 4
                Console.WriteLine("Meine Zahl ist 4")
        End Select

        Console.WriteLine(Environment.NewLine & "Zweite Variante:" & Environment.NewLine)

        'Eine Case Abfrage wird auf eine Integer Zahl angewendet
        Select Case meineZahl
            'In diesem Fall kann die Zahl 1, 2, 3 sein es können also auch mehrere Fälle abgefragt werden
            Case 1, 2, 3
                Console.WriteLine("Meine Zahl ist 1, 2 oder 3")
            Case 4, 5, 6
                Console.WriteLine("Meine Zahl ist 4, 5 oder 6")
                'Für den Fall, das ein Case Zweig zutrifft kann ein Alternative geschaffen werden
            Case Else
                Console.WriteLine("Meine Zahl ist eine ganz andere")
        End Select

        Console.Read()
    End Sub

    Private Sub ChooseFunktion()
        'Choose gibt den Wert an seinem Index einer Liste zurück
        'WICHTIG Liste beginnt bei 1 und NICHT bei 0
        Dim einAuto As Integer = 3
        Console.WriteLine(Choose(einAuto, "Mercedes", "VW", "BMW", "Audi"))
        Console.Read()
    End Sub

    Private Sub ForNextSchleife()
        'Nach jedem Durchlauf wird i um einen Wert erhöht
        'Nach jedem Durchlauf wird der neue Wert des Zählers mit dem Wert vom Ende vergleichen und entschieden ob die Schleife weiter läuft
        'Der Datentyp von i (counter) bestimmt den Typ der Iteration
        For i As Integer = 0 To 10 Step 2
            'Anweisung
            Console.WriteLine(i)
        Next i

        Console.WriteLine(Environment.NewLine & "For schleife mit Abbruchbedingung" & Environment.NewLine)

        For i = 0 To 10
            'Anweisung
            Console.WriteLine(i)
            'Wenn i=8 ist wird die For Schleife abgebrochen
            If i = 8 Then Exit For
        Next

        Console.WriteLine(Environment.NewLine & "For schleife mit Continue Bedingung" & Environment.NewLine)

        For i = 0 To 20
            If i Mod 2 = 0 Then Continue For
            Console.WriteLine("Ausgabe nur wenn i = {0} ungerade", i)
        Next
        Console.Read()
    End Sub

    Private Sub DoLoopSchleife()
        'Die Anzahl der Durchläufe steht am Anfang der Schleife nicht fest
        'Es gibt 5 Varianten:

        Console.WriteLine(Environment.NewLine & "Die Bediungung zum Weiterlaufen wird am Schleifenanfang geprüft" & Environment.NewLine)

        '1. Variante (Die Bediungung zum Weiterlaufen wird am Schleifenanfang geprüft)
        Dim i As Integer = 0
        Do While i <= 10
            Console.WriteLine(i)
            i = i + 1
        Loop

        Console.WriteLine(Environment.NewLine & "Die Bediungung zum Weiterlaufen wird am Schleifenende geprüft" & Environment.NewLine)

        '2. Variante (Die Bediungung zum Weiterlaufen wird am Schleifenende geprüft)
        Dim j As Integer = 0
        Do
            Console.WriteLine(j)
            j = j + 1
        Loop While j <= 10

        Console.WriteLine(Environment.NewLine & "Prüft die Abbruchbedingung am Anfang der Schleife" & Environment.NewLine)

        '3. Variante (Prüft die Abbruchbedingung am Anfang der Schleife)
        Dim k As Integer = 0
        Do Until k >= 10
            Console.WriteLine(k)
            k = k + 1
        Loop

        Console.WriteLine(Environment.NewLine & "Prüft die Abbruchbedingung am Ende der Schleife" & Environment.NewLine)

        '4. variante (Prüft die Abbruchbedingung am Ende der Schleife)
        Dim m As Integer = 0
        Do
            Console.WriteLine(m)
            m = m + 1
        Loop Until m >= 10

        Console.WriteLine(Environment.NewLine & _
                          "Prüft die Bedingung weder beim Weiterlaufen noch beim Beenden, aus diesem Grund ist eine Verzweigung und ein Exit Do zur Beedndigung der Schleife notwendig" _
                          & Environment.NewLine)

        '5. Variante (Prüft die Bedingung weder beim Weiterlaufen noch beim Beenden, aus diesem Grund ist eine Verzweigung und ein Exit Do zur Beedndigung der Schleife notwendig)
        Dim n As Integer = 0
        Do
            Console.WriteLine(n)
            n = n + 1
            If n = 8 Then Exit Do
        Loop
        Console.Read()
    End Sub
End Module

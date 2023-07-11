Module Module1
    '5)
    Sub Main()
        Dim Str, Char1 As String
        Dim vowelcounter, i As Integer
        Const vowels = "aeiou"

        Str = " "
        vowelcounter = 0
        i = 0

        Console.Write("Enter a string: ")
        Str = Console.ReadLine
        Str = LCase(Str)

        For i = 1 To Len(Str)
            Char1 = Mid(Str, i, 1)
            If InStr(vowels, Char1) > 0 Then
                vowelcounter = vowelcounter + 1

            End If
        Next

        Console.Write("Number of vowels in a string: " & vowelcounter)

        Console.ReadKey()



    End Sub

End Module

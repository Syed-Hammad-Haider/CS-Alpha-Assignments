Module Module1
    '9)
    Sub Main()
        Dim Str1, Str2, Str3, Str4, Char1, Char2 As String

        Str1 = " "
        Str2 = " "
        Str3 = " "
        Str4 = " "
        Char1 = " "
        Char2 = " "


        Console.Write("Enter your first string: ")
        Str1 = Console.ReadLine
        Console.Write("Enter your second string: ")
        Str2 = Console.ReadLine

        Char1 = Left(Str1, 2)
        Char2 = Left(Str2, 2)
        Str3 = Mid(Str1, 3, Len(Str1))
        Str4 = Mid(Str2, 3, Len(Str2))

        Console.Write(Char2 & Str3 & " " & Char1 & Str4)


        Console.ReadKey()

    End Sub

End Module

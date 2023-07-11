Module Module1
    '2)
    Sub Main()
        Dim Str1, Str2, Char1, Char2, Char3 As String
        Dim i As Integer

        Str1 = " "
        Str2 = " "
        Char1 = " "
        Char2 = " "
        Char3 = " "
        i = 0
        Console.Write(" Enter the string to be processed: ")
        Str1 = Console.ReadLine
        Console.Write("Enter the charater to be removed: ")
        Char1 = Console.ReadLine
        Console.Write("Enter the character to replace with: ")
        Char2 = Console.ReadLine
        If Len(Char1) > 1 Or Len(Char2) > 1 Then
            Console.WriteLine("Enter a single character!")
        End If
        For i = 1 To Len(Str1)
            Char3 = Mid(Str1, i, 1)
            If Char1 = Char3 Then
                Str2 = Str2 & Char2
            Else
                Str2 = Str2 & Char3
            End If
        Next

        Console.Write("The processed string is: " & Str2)

        Console.ReadKey()

    End Sub
End Module

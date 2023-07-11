Module Module1
    '10)
    Sub Main()
        Dim Str, last3 As String

        Str = " "
        last3 = " "

        Console.Write("Enter a string: ")
        Str = Console.ReadLine

        If Len(Str) >= 3 Then
            last3 = Right(Str, 3)
            If last3 = "ing" Then
                Console.Write(Str & "ly")
            Else
                Console.Write(Str & "ing")
            End If
        Else
            Console.Write(Str)
        End If

        Console.ReadKey()

    End Sub

End Module

Module Module1
    '7)
    Sub Main()
        Dim s, f2, l2 As String

        s = " "
        f2 = " "
        l2 = " "

        Console.Write("Enter a string: ")
        s = Console.ReadLine

        If Len(s) < 2 Then
            Console.Write(s)
        Else
            f2 = Left(s, 2)
            l2 = Right(s, 2)
        End If

        Console.Write(f2 & l2)

        Console.ReadKey()



    End Sub

End Module

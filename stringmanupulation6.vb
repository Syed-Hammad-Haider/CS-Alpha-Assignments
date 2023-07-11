Module Module1
    '6)
    Sub Main()
        Dim count As Integer

        count = 0

        Console.Write("Enter number of donuts: ")
        count = Console.ReadLine

        If count >= 10 Then
            Console.Write("Number of donuts:many")
        Else
            Console.Write("Number of donuts:" & count)

        End If
        Console.ReadKey()


    End Sub

End Module

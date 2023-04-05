Module Module1

    Sub Main()
        Dim Str, StrMain, CurrChar, Firsthalf, secondhalf As String
        Dim Strlen, index As Integer
        Dim MidChar As Decimal


        Console.WriteLine("Enter string")
        Str = (Console.ReadLine)
        StrMain = UCase(Str)
        Strlen = Len(Str)
        MidChar = Strlen / 2

        If Strlen Mod 2 <> 0 Then
            MidChar = MidChar + 0.5
        End If
        For index = Strlen To Strlen - MidChar + 1 Step -1
            CurrChar = Mid(StrMain, index, 1)
            secondhalf = secondhalf & CurrChar
        Next


        Firsthalf = Left(StrMain, MidChar)


        If Firsthalf = secondhalf Then
            Console.Write("TRUE")
        Else
            Console.Write("FALSE")
        End If



        Console.ReadKey()





    End Sub

End Module

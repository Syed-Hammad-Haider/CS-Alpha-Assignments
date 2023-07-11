Module Module1

    Sub Main()
        Dim StationFro, StationTo, NoOfPass, NoOfStats, Fare As Integer
        Const FarePerPassPerStat = 2

        StationFro = 0
        StationTo = 0
        NoOfPass = 0
        NoOfStats = 0
        Fare = 0

        Console.Write("From station: ")
        StationFro = Console.ReadLine
        Console.Write("To station: ")
        StationTo = Console.ReadLine
        Console.Write("Enter number of passengers: ")
            NoOfPass = Console.ReadLine

        NoOfStats = StationTo - StationFro
        Fare = NoOfPass * NoOfStats * FarePerPassPerStat
        If NoOfPass >= 5 And NoOfPass <= 9 Then
            Console.WriteLine("You are a given a discount of Rs 8")
            Fare = Fare - 8
        ElseIf NoOfPass > 9 Then
            Console.WriteLine("You are given a discount of Rs 15")
            Fare = Fare - 15
        End If

        Console.Write("Your fare is: " & Fare)
        Console.ReadKey()

    End Sub

End Module

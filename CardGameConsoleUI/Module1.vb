Imports CardGameHelpers

Module Module1

    Sub Main()
        Console.WriteLine("START OF TEST")
        Dim conString = "Data Source=DESKTOP-6322EIK\SQLEXPRESS;Initial Catalog=CardGame;Integrated Security=True;"
        Dim helper = New SqlAsyncHelper()



        Console.WriteLine("END OF TEST")
        Console.ReadLine()
    End Sub

End Module

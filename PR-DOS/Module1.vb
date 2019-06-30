Module Module1

    Sub Main()
restart:
        Console.Clear()
        Console.WriteLine("PR-DOS")
        Console.WriteLine("----------------------")
        Console.WriteLine("The command prompt by Nelinka. Ver. 1.0")
        Console.WriteLine("TIP: For list of all commands, type list!")
        Console.WriteLine("-----------------------------------------------")
beginning:
        Console.Write("PR-DOS>")
        Dim theinput = Console.ReadLine()
        If theinput = "close" Then
            Console.WriteLine("close>Ready to close PR-DOS! Press ENTER to close PR-DOS.")
            Console.ReadLine()
            End
        ElseIf theinput = "clear" Then
            Console.Clear()
            GoTo beginning
        ElseIf theinput = "list" Then
            Console.WriteLine("list>close = Closes PR-DOS.")
            Console.WriteLine("list>clear = Clears the console.")
            Console.WriteLine("list>list = Lists all avaiable commands. (Currently in use.)")
            Console.WriteLine("list>restart = Restarts the console.")
            Console.WriteLine("list>about = About PR-DOS and Nelinka.")
            GoTo beginning
        ElseIf theinput = "restart" Then
            GoTo restart
            End
        ElseIf theinput = "about" Then
            Console.WriteLine("about>PR-DOS made by Nelinka.")
            Console.WriteLine("about>Ver. 1.0 -- CHANGELOG")
            Console.WriteLine("about>-----------------------------------")
            Console.WriteLine("about>Intial release. PRRD XD")
            GoTo beginning
        Else
            Console.WriteLine("PR-DOS>This command does not exist!")
            GoTo beginning
        End If


    End Sub

End Module

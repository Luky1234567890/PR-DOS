Module Module1
    'The sub "Main" is the normal version of PR-DOS and is launched by default.
    'While the sub "graphical" is the GPR-DOS, which can be launched from normal mode using the "graphical" command.
    Sub Main()
        Console.Clear()
        Dim remoteUri As String = "http://nelinka.6te.net/prdos/news.txt"
        Dim fileName As String = "C:\news.txt"

        Using client As New System.Net.WebClient()

            client.Credentials = New System.Net.NetworkCredential
            client.DownloadFile(remoteUri, fileName)
        End Using
        Dim news As String
        news = My.Computer.FileSystem.ReadAllText("C:\news.txt")
        Console.WriteLine("PR-DOS")
        Console.WriteLine("----------------------")
        Console.WriteLine("Bringing DOS back, by Nelinka. Ver. 1.1")
        Console.WriteLine("-----------------------------------------------")
        Console.WriteLine("TIP: If you want PR-DOS to look real, press F11! (or FN+F11)")
        Console.WriteLine("Are you lost? Enter 'help' in the CMD to get a list of commands!")
        Console.WriteLine("-----------------------------------------------")
        Console.Write("PR-DOS News: ")
        Console.WriteLine(news)
        Console.WriteLine("-----------------------------------------------")
beginning:
        Console.Write("PR-DOS>")
        Dim theinput = Console.ReadLine()
        If theinput = "shutdown" Then
            Console.WriteLine("shutdown>Ready to close PR-DOS! Press ENTER to close PR-DOS.")
            Console.ReadLine()
            End
        ElseIf theinput = "clear" Then
            Console.Clear()
            GoTo beginning
        ElseIf theinput = "help" Then
            Console.WriteLine("help>shutdown = Closes PR-DOS.")
            Console.WriteLine("help>clear = Clears the console.")
            Console.WriteLine("help>help = Lists all avaiable commands. (Currently in use)")
            Console.WriteLine("help>restart = Restarts the console.")
            Console.WriteLine("help>about = About PR-DOS and Nelinka.")
            Console.WriteLine("help>graphical = Launches GPR-DOS.")
            Console.WriteLine("help>settings = The settings for PR-DOS and boot/launch.")
            Console.WriteLine("help>run = Runs a PR-DOS program you desire.")
            Console.WriteLine("help>delete = Deletes a file you desire.")
            Console.WriteLine("help>rename = Renames a file you desire.")
            GoTo beginning
        ElseIf theinput = "restart" Then
            Call Main()
        ElseIf theinput = "about" Then
            Console.WriteLine("about>PR-DOS made by Nelinka.")
            Console.WriteLine("about>Ver. 1.1 -- CHANGELOG")
            Console.WriteLine("about>-----------------------------------")
            Console.WriteLine("about>Added commands:")
            Console.WriteLine("about>'graphical', 'settings', 'run', 'delete' and 'rename'.")
            Console.WriteLine("about>Renamed commands:")
            Console.WriteLine("about>'close' to 'shutdown' and 'list' to 'help'.")
            Console.WriteLine("about>Also added preparations for GPR-DOS, it's not working yet but the command for it is 'graphical'.")
            GoTo beginning
        ElseIf theinput = "graphical" Then
            Call graphical()
        ElseIf theinput = "settings" Then
            Console.WriteLine("settings>There are no settings for PR-DOS/GPR-DOS! Yet..")
            GoTo beginning
        ElseIf theinput = "run" Then
            Console.WriteLine("run>Please enter the program path:")
            Dim filepath = Console.ReadLine()
            Dim program = My.Computer.FileSystem.ReadAllText(filepath)
            Console.WriteLine(program)
            GoTo beginning
        ElseIf theinput = "delete" Then
            Console.WriteLine("delete>Please enter the file path:")
            Dim filepath = Console.ReadLine()
            If My.Computer.FileSystem.FileExists(filepath) = False Then
                Console.WriteLine("delete>Error! Please check if the file exists in the path you entered.")
                GoTo beginning
            End If
            My.Computer.FileSystem.DeleteFile(filepath)
            Console.WriteLine("delete>Deleted ", filepath)
            GoTo beginning
        ElseIf theinput = "rename" Then
            Console.WriteLine("rename>Please enter the file path:")
            Dim filepath = Console.ReadLine()
            If My.Computer.FileSystem.FileExists(filepath) = False Then
                Console.WriteLine("rename>Error! Please check if the file exists in the path you entered.")
                GoTo beginning
            End If
            Console.WriteLine("rename>Please enter what you wanna rename the file to:")
            Dim name = Console.ReadLine()
            My.Computer.FileSystem.RenameFile(filepath, name)
            Console.WriteLine("rename>Successfully renamed ", filepath, " to ", name)
            GoTo beginning
        Else
            Console.WriteLine("PR-DOS>This command does not exist!")
            GoTo beginning
        End If
    End Sub
    Sub graphical()
        Console.Clear()
        Console.WriteLine("/////////////////////////////////////////////////////////////////")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                   -----------             -----------X        /")
        Console.WriteLine("/                 -                         -          -        /")
        Console.WriteLine("/                 -                         - YAY! :D  -        /")
        Console.WriteLine("/                 -      ---                -          -        /")
        Console.WriteLine("/                 -          -              ------------        /")
        Console.WriteLine("/                  ----------                                   /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                    GPR-DOS                                    /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/           The graphical version of PR-DOS.                    /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/          Copyright © Nelinka 2019                             /")
        Console.WriteLine("/          Copyright © Nelinka Software Development 2019        /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/////////////////////////////////////////////////////////////////")
        Console.Write("Booting up...")
        Threading.Thread.Sleep(5000)
        Console.WriteLine("Booted, press ENTER to continue...")
        Console.ReadLine()
desktop_time_clear:
        Console.Clear()
        Console.WriteLine("/////////////////////////////////////////////////////////////////")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                   -----------                                 /")
        Console.WriteLine("/                 -                                             /")
        Console.WriteLine("/                 -                                             /")
        Console.WriteLine("/                 -      ---                                    /")
        Console.WriteLine("/                 -          -                                  /")
        Console.WriteLine("/                  ----------                                   /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                    GPR-DOS                                    /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/           The graphical version of PR-DOS.                    /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/---------------------------------------------------------------/")
        Console.WriteLine("/             -                                                 /")
        Console.WriteLine("/ T Y P E (t) -                                         (d)" & Now.ToShortTimeString & "/")
        Console.WriteLine("/             -                                                 /")
        Console.WriteLine("/////////////////////////////////////////////////////////////////")
desktop:
        Console.Write("Type one command letter from the screen:")
        Dim input = Console.ReadLine()
        If input = "d" Then
            Console.WriteLine("Wanna refresh the time? (Y/N)")
            Dim temp = Console.ReadLine()
            If temp = "y" Then
                GoTo desktop_time_clear
            End If
            GoTo desktop
        ElseIf input = "t" Then
time_yet_again:
            Console.Clear()
            Console.WriteLine("/////////////////////////////////////////////////////////////////")
            Console.WriteLine("/                                                               /")
            Console.WriteLine("/                   -----------                                 /")
            Console.WriteLine("/                 -                                             /")
            Console.WriteLine("/                 -                                             /")
            Console.WriteLine("/                 -      ---                                    /")
            Console.WriteLine("/                 -          -                                  /")
            Console.WriteLine("/                  ----------                                   /")
            Console.WriteLine("/                                                               /")
            Console.WriteLine("/                                                               /")
            Console.WriteLine("/                    GPR-DOS                                    /")
            Console.WriteLine("/                                                               /")
            Console.WriteLine("/---------------------                                          /")
            Console.WriteLine("/         (s)        -                                          /")
            Console.WriteLine("/      Shutdown      -                                          /")
            Console.WriteLine("/---------------------------------------------------------------/")
            Console.WriteLine("/             -                                                 /")
            Console.WriteLine("/ T Y P E (t) -                                         (d)" & Now.ToShortTimeString & "/")
            Console.WriteLine("/             -                                                 /")
            Console.WriteLine("/////////////////////////////////////////////////////////////////")
input2:
            Console.Write("Type one command letter from the screen:")
            Dim input2 = Console.ReadLine()
            If input2 = "d" Then
                Console.WriteLine("Wanna refresh the time? (Y/N)")
                Dim temp = Console.ReadLine()
                If temp = "y" Then
                    GoTo time_yet_again
                Else
                    GoTo input2
                End If
            ElseIf input2 = "s" Then
                GoTo shutdown
            ElseIf input2 = "t" Then
                GoTo desktop_time_clear
            Else
                GoTo desktop
            End If
        End If
shutdown:
        Console.Clear()
        Console.WriteLine("/////////////////////////////////////////////////////////////////")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                   -----------             -----------X        /")
        Console.WriteLine("/                 -                         -          -        /")
        Console.WriteLine("/                 -                         - YAY! :D  -        /")
        Console.WriteLine("/                 -      ---                -          -        /")
        Console.WriteLine("/                 -          -              ------------        /")
        Console.WriteLine("/                  ----------                                   /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                    GPR-DOS                                    /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/           The graphical version of PR-DOS.                    /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/          Copyright © Nelinka 2019                             /")
        Console.WriteLine("/          Copyright © Nelinka Software Development 2019        /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine("/////////////////////////////////////////////////////////////////")
        Console.Write("Shutting down...")
        Threading.Thread.Sleep(5000)
        Console.WriteLine("Shutted down, press ENTER to go to PR-DOS..")
        Console.ReadLine()
        Call Main()
    End Sub
End Module
Module Module1
    'The sub "Main" is the normal version of PR-DOS and is launched by default.
    'While the sub "graphical" is GPR-DOS, which can be launched from normal mode using the "graphical" command.
    Sub Main()
#Disable Warning BC42104
        Console.Clear()
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\bricked.txt") = True Then
brick:
            Console.Clear()
            Console.WriteLine("YOUR PR-DOS SYSTEM IS BRICKED! PLEASE REINSTALL PR-DOS BY DELETING THE FOLDER")
            Console.WriteLine("prdos_settings AND RE-DOWNLOADING PR-DOS!")
            Console.WriteLine("Press ENTER to shutdown...")
            Dim wow = Console.ReadLine()
            End
        End If
        'Idea: Instead of using TXT files, use your own file extension (.nft = Neltak File Type)
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_clever.txt") = True Then

        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_original.txt") = True Then

        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_besty.txt") = True Then

        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_xtreme.txt") = True Then

        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_nelpower.txt") = True Then

        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_server.txt") = True Then

        Else
            Console.WriteLine("A N-rUn BASE IS NEEDED FOR PR-DOS TO RUN! PLEASE GET A N-rUn BASE AND THEN RUN PR-DOS AGAIN.")
            Console.WriteLine("Press ENTER to shutdown...")
            Console.ReadLine()
            End
        End If
        If My.Computer.FileSystem.DirectoryExists("C:\prdos_settings") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\prdos_settings")
        End If
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\glaunch_prohibit.txt") = True Then
            GoTo prevent
        End If
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\glaunch.txt") = True Then
            Call graphical()
        End If
prevent:
        Dim news As String
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\nodown.txt") = True Then
            news = "Prevented from downloading news."
            GoTo ejcha
        End If
        Dim remoteUri As String = "http://nelinka.6te.net/prdos/news.txt"
        Dim fileName As String = "C:\news.txt"

        Using client As New System.Net.WebClient()

            client.Credentials = New System.Net.NetworkCredential
            client.DownloadFile(remoteUri, fileName)
        End Using
        news = My.Computer.FileSystem.ReadAllText("C:\news.txt")
ejcha:
        Dim nrun As String
        Dim nrun_number As String
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_clever.txt") = True Then
            nrun_number = My.Computer.FileSystem.ReadAllText("C:\prdos_settings\nrun_clever.txt")
            nrun = "N-rUn Clever "
        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_original.txt") = True Then
            nrun_number = My.Computer.FileSystem.ReadAllText("C:\prdos_settings\nrun_original.txt")
            nrun = "N-rUn Original "
        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_besty.txt") = True Then
            nrun_number = My.Computer.FileSystem.ReadAllText("C:\prdos_settings\nrun_besty.txt")
            nrun = "N-rUn BESTy "
        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_xtreme.txt") = True Then
            nrun_number = My.Computer.FileSystem.ReadAllText("C:\prdos_settings\nrun_xtreme.txt")
            nrun = "N-rUn Xtreme "
        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_nelpower.txt") = True Then
            nrun_number = My.Computer.FileSystem.ReadAllText("C:\prdos_settings\nrun_nelpower.txt")
            nrun = "N-rUn NELPOWER "
        ElseIf My.Computer.FileSystem.FileExists("C:\prdos_settings\nrun_server.txt") = True Then
            nrun_number = My.Computer.FileSystem.ReadAllText("C:\prdos_settings\nrun_server.txt")
            nrun = "N-rUn Server_ "
        End If
        Dim modified As Boolean
        modified = False
        If nrun_number = "MODIFIED" Then
            modified = True
            'using this boolean, PR-DOS can quickly find out if the current N-rUn base is modified.
        End If
secretway:
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
        Console.WriteLine("X  OOO   OOO        OOOO    OOO    OOOO   X")
        Console.WriteLine("X  O  O  O  O       O   O  O   O  O       X")
        Console.WriteLine("X  OOO   OOO   ---  O   O  O   O   OOOO   X")
        Console.WriteLine("X  O     O  O       O   O  O   O       O  X")
        Console.WriteLine("X  O     O  O       OOOO    OOO    OOOO   X")
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("Time: ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine(Now.ToShortTimeString)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("----------------------")
        Console.WriteLine("Bringing DOS back, by Neltak.")
        Console.Write(nrun)
        Console.WriteLine(nrun_number)
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
            Console.WriteLine("shutdown>Ready to shutdown PR-DOS! Press ENTER to shutdown PR-DOS.")
            Console.ReadLine()
            If My.Computer.FileSystem.FileExists("C:\prdos_settings\glaunch_prohibit.txt") = True Then
                My.Computer.FileSystem.DeleteFile("C:\prdos_settings\glaunch_prohibit.txt")
            End If
            End
        ElseIf theinput = "clear" Then
            Console.Clear()
            GoTo beginning
        ElseIf theinput = "help" Then
            Console.WriteLine("help>shutdown = Shuts down PR-DOS.")
            Console.WriteLine("help>clear = Clears the console.")
            Console.WriteLine("help>help = Lists all avaiable commands. (Currently in use)")
            Console.WriteLine("help>restart = Restarts the console.")
            Console.WriteLine("help>about = About PR-DOS and Nelinka.")
            Console.WriteLine("help>graphical = Launches GPR-DOS.")
            Console.WriteLine("help>settings = The settings for PR-DOS.")
            Console.WriteLine("help>run = Runs a PR-DOS program you desire.")
            Console.WriteLine("help>open = Opens any file/app.")
            Console.WriteLine("help>delete = Deletes a file you desire.")
            Console.WriteLine("help>rename = Renames a file you desire.")
            Console.WriteLine("help>dir = Opens a directory you desire.")
            Console.WriteLine("help>create = Creates a file where you want, including what you want.")
            Console.WriteLine("help>mkdir = Creates a directory of your choice.")
            Console.WriteLine("help>server = Helps manage a server running a N-rUn Server_ base.")
            Console.WriteLine("help>modifymenu = Special menu for modified N-rUn bases.")
            GoTo beginning
        ElseIf theinput = "restart" Then
            If My.Computer.FileSystem.FileExists("C:\prdos_settings\glaunch_prohibit.txt") = True Then
                My.Computer.FileSystem.DeleteFile("C:\prdos_settings\glaunch_prohibit.txt")
            End If
            Call Main()
        ElseIf theinput = "about" Then
            Console.WriteLine("about>PR-DOS © Neltak 2020")
            Console.WriteLine("about>PR-DOS © Neltak Software Development 2020")
            Console.WriteLine("about>Ver. 1.4-dev1 -- CHANGELOG")
            Console.WriteLine("about>-----------------------------------")
            Console.WriteLine("about>Finished commands 'server' and 'modifymenu'.")
            Console.WriteLine("about>Changed command 'createtxt' to 'create'.")
            Console.WriteLine("about>Added commands 'mkdir' and 'open'.")
            Console.WriteLine("about>Changed the About screen a bit.")
            Console.WriteLine("about>Changed last lines that still included Nelinka to Neltak.")
            Console.WriteLine("about>Added a failsafe in any case lol")
            Console.WriteLine("about>Enhanced crash screen.")
            GoTo beginning
        ElseIf theinput = "graphical" Then
            Call graphical()
        ElseIf theinput = "settings" Then
            If My.Computer.FileSystem.DirectoryExists("C:\prdos_settings") = False Then
                My.Computer.FileSystem.CreateDirectory("C:\prdos_settings")
            End If
            Console.WriteLine("settings>Do you want to start GPR-DOS on launch? (y/n)")
            Dim selection = Console.ReadLine()
            If selection = "y" Then
                My.Computer.FileSystem.WriteAllText("C:\prdos_settings\glaunch.txt", "yes", False)
                Console.WriteLine("settings>Saved this setting.")
            ElseIf selection = "n" Then
                If My.Computer.FileSystem.FileExists("C:\prdos_settings\glaunch_prohibit.txt") = True Then
                    My.Computer.FileSystem.DeleteFile("C:\prdos_settings\glaunch_prohibit.txt")
                End If
                If My.Computer.FileSystem.FileExists("C:\prdos_settings\glaunch.txt") = True Then
                    My.Computer.FileSystem.DeleteFile("C:\prdos_settings\glaunch.txt")
                    Console.WriteLine("settings>Deleted the setting.")
                End If
            End If
            Console.WriteLine("settings>There are no more settings for PR-DOS/GPR-DOS! Yet..")
            GoTo beginning
        ElseIf theinput = "run" Then
            Console.WriteLine("run>Please enter the program path:")
            Dim filepath = Console.ReadLine()
            If My.Computer.FileSystem.FileExists(filepath) = False Then
                Console.WriteLine("run>Error! Please check that the file in the filepath you entered exists!")
                GoTo beginning
            End If
            Dim program = My.Computer.FileSystem.ReadAllText(filepath)
            ' For Svojetín: You had the idea to make some programs brick PR-DOS if they aren't geniue.
            ' Idea: Make these programs actually do something: make it like your own programming launguage
            Console.WriteLine(program)
            GoTo beginning
        ElseIf theinput = "open" Then
            Console.WriteLine("open>Please enter the file path:")
            Dim apppath = Console.ReadLine()
            If My.Computer.FileSystem.FileExists(apppath) = False Then
                Console.WriteLine("open>Error! Please check if the file exists in the path you entered.")
                GoTo beginning
            End If
            Process.Start(apppath)
            Console.WriteLine("open>Opened the fiĺe in the path you entered.")
            GoTo beginning
        ElseIf theinput = "delete" Then
            Console.WriteLine("delete>Please enter the file path:")
            Dim filepath = Console.ReadLine()
            If My.Computer.FileSystem.FileExists(filepath) = False Then
                Console.WriteLine("delete>Error! Please check if the file exists in the path you entered.")
                GoTo beginning
            End If
            Console.WriteLine("delete>Are you sure? (Y/N)")
            Dim selection = Console.ReadLine()
            If selection = "y" Then
                My.Computer.FileSystem.DeleteFile(filepath)
                Console.WriteLine("delete>Deleted the file in the path you entered.")
                GoTo beginning
            End If
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
            Console.WriteLine("rename>Successfully renamed the file in the path you entered.")
            GoTo beginning
        ElseIf theinput = "dir" Then
            Console.WriteLine("dir>Please enter the directory path:")
            Dim filepath = Console.ReadLine()
            If My.Computer.FileSystem.DirectoryExists(filepath) = False Then
                Console.WriteLine("dir>Error! Please check that the directory in the path you entered exists!")
                GoTo beginning
            End If
            Process.Start(filepath)
            Console.WriteLine("dir>Opened the directory in the path you entered.")
            GoTo beginning
        ElseIf theinput = "create" Then
            Console.WriteLine("create>Please enter the filepath:")
            Dim filepath = Console.ReadLine()
            Console.WriteLine("create>Please enter the text that the file will contain:")
            Dim text = Console.ReadLine()
            My.Computer.FileSystem.WriteAllText(filepath, text, False)
            Console.WriteLine("create>Created a file.")
            GoTo beginning
        ElseIf theinput = "mkdir" Then
            Console.WriteLine("mkdir>Please enter the filepath of the directory you want to create (including it's name):")
            Dim dirpath = Console.ReadLine()
            If My.Computer.FileSystem.DirectoryExists(dirpath) = True Then
                Console.WriteLine("mkdir>Error! This directory already exists!")
                GoTo beginning
            End If
            My.Computer.FileSystem.CreateDirectory(dirpath)
            Console.WriteLine("mkdir>Created a directory.")
            GoTo beginning
        ElseIf theinput = "server" Then
            If nrun = "N-rUn Server_ " Then
                Console.Write("server>PR-DOS isn't capable of running a server.")
                Console.WriteLine(" Yet...")
                GoTo beginning
            Else
                My.Computer.FileSystem.WriteAllText("C:\prdos_settings\errorcode.txt", "NONRUN02", False)
                Call emergency()
            End If
        ElseIf theinput = "brick" Then
            My.Computer.FileSystem.WriteAllText("C:\prdos_settings\bricked.txt", "bricked", False)
            GoTo brick
        ElseIf theinput = "crash" Then
            My.Computer.FileSystem.WriteAllText("C:\prdos_settings\errorcode.txt", "MANUAL", False)
            Call emergency()
        ElseIf theinput = "modifymenu" Then
            If modified = False Then
                My.Computer.FileSystem.WriteAllText("C:\prdos_settings\errorcode.txt", "NONRUN01", False)
                Call emergency()
            Else
                Console.WriteLine("---  N-rUn Menu for modified bases ---")
                Console.WriteLine("!!! WARNING: Using a modified N-rUn base might lead to bricks. !!!")
                Console.WriteLine("")
                GoTo beginning
            End If
        Else
            Console.WriteLine("PR-DOS>This command does not exist!")
            GoTo beginning
        End If
        My.Computer.FileSystem.WriteAllText("C:\prdos_settings\errorcode.txt", "ENDSUB", False)
        Call emergency()
    End Sub
    Sub graphical()
        Console.Clear()
        Dim nrun As String
        If My.Computer.FileSystem.FileExists("C:\nrun_clever.txt") = True Then
            nrun = "/                   N-rUn Clever                                /"
        ElseIf My.Computer.FileSystem.FileExists("C:\nrun_original.txt") = True Then
            nrun = "/                   N-rUn Original                              /"
        ElseIf My.Computer.FileSystem.FileExists("C:\nrun_besty.txt") = True Then
            nrun = "/                   N-rUn BESTy                                 /"
        ElseIf My.Computer.FileSystem.FileExists("C:\nrun_xtreme.txt") = True Then
            nrun = "/                   N-rUn Xtreme                                /"
        ElseIf My.Computer.FileSystem.FileExists("C:\nrun_nelpower.txt") = True Then
            nrun = "/                   N-rUn NELPOWER                              /"
        ElseIf My.Computer.FileSystem.FileExists("C:\nrun_server.txt") = True Then
            nrun = "/                   N-rUn Server_                               /"
        End If
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
        Console.WriteLine("/          Copyright © Neltak 2020                              /")
        Console.WriteLine("/          Copyright © Neltak Software Development 2020         /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine(nrun)
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
                My.Computer.FileSystem.WriteAllText("C:\prdos_settings\noshut.txt", "nope", False)
                GoTo shutdown
            ElseIf input2 = "t" Then
                GoTo desktop_time_clear
            Else
                GoTo input2
            End If
        Else
            GoTo desktop
        End If
shutdown:
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\noshut.txt") = False Then
            GoTo desktop_time_clear
        End If
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
        Console.WriteLine("/          Copyright © Neltak 2020                              /")
        Console.WriteLine("/          Copyright © Neltak Software Development 2020         /")
        Console.WriteLine("/                                                               /")
        Console.WriteLine(nrun)
        Console.WriteLine("/////////////////////////////////////////////////////////////////")
        Console.Write("Shutting down...")
        Threading.Thread.Sleep(5000)
        Console.WriteLine("Shutted down, press ENTER to go to PR-DOS..")
        My.Computer.FileSystem.WriteAllText("C:\prdos_settings\glaunch_prohibit.txt", "prohibited", False)
        Console.ReadLine()
        If My.Computer.FileSystem.FileExists("C:\prdos_settings\noshut.txt") = True Then
            My.Computer.FileSystem.DeleteFile("C:\prdos_settings\noshut.txt")
        End If
        Call Main()
    End Sub
    Sub emergency()
        Console.Clear()
        Dim errcode = My.Computer.FileSystem.ReadAllText("C:\prdos_settings\errorcode.txt")
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.BackgroundColor = ConsoleColor.Blue
        Console.WriteLine("An exception has occured that PR-DOS cannot fix by it's own, so it crashed to prevent any damage.")
        Console.Write("Error code: ")
        Console.Write(errcode)
        Console.WriteLine(" --- Please contact Neltak with this code.")
        Console.WriteLine("Addinitional information: 0x00005892NOSP &]ł][ĐđĐ&@{][Đđđđ|Đ[]*ß×¤ß*>$*ß¤×~ˇ^˘°˛`")
        Console.WriteLine("Since PR-DOS cannot continue, press ENTER to shutdown. . .")
        Console.ReadLine()
        End
    End Sub
End Module
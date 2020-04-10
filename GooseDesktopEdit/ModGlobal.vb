Imports System.IO

Module ModGlobal

    Public Structure GooseStru
        Dim DirPath As String
        Dim ExePath As String
        Dim CloseExePath As String
        Dim ConfigIniPath As String
        Dim GooseExePath As String
        Dim CloseGoosePath As String
        Dim ImgDirPath As String
        Dim ModDirPath As String
        Dim SoundDirPath As String
        Dim TxtDirPath As String
    End Structure

    Public Structure GooseConfigStru
        Dim EnableMods As String
        Dim SilenceSounds As String
        Dim Task_CanAttackMouse As String
        Dim AttackRandomly As String
        Dim UseCustomColors As String
        Dim GooseDefaultWhite As String
        Dim GooseDefaultOrange As String
        Dim GooseDefaultOutline As String
        Dim MinWanderingTimeSeconds As String
        Dim MaxWanderingTimeSeconds As String
        Dim FirstWanderTimeSeconds As String
    End Structure

    Public Structure MyExeStru
        Dim DirPath As String
        Dim ConfigPath As String
    End Structure

    Public Goose As GooseStru
    Public MyExe As MyExeStru
    Public GooseConfig As GooseConfigStru

    Public Sub SetMyExeStru()
        MyExe.DirPath = My.Application.Info.DirectoryPath.ToString
        If Microsoft.VisualBasic.Right(MyExe.DirPath, 1) <> "\" Then
            MyExe.DirPath += "\"
        End If

        MyExe.ConfigPath = MyExe.DirPath + "Set.config"

    End Sub

    Public Function SetGooseStru()
        If Microsoft.VisualBasic.Right(Goose.DirPath, 1) <> "\" Then
            Goose.DirPath += "\"
        End If

        With Goose
            .ExePath = goose.DirPath + "GooseDesktop.exe"
            .CloseExePath = Goose.DirPath + "Close Goose.bat"
            .ConfigIniPath = Goose.DirPath + "Config.ini"
            .GooseExePath = Goose.DirPath + "GooseDesktop.exe"
            .CloseGoosePath = Goose.DirPath + "Close Goose.bat"
            .ImgDirPath = Goose.DirPath + "Assets\Images\Memes\"
            .ModDirPath = Goose.DirPath + "Assets\Mods\"
            .SoundDirPath = Goose.DirPath + "Assets\Sound\Music\"
            .TxtDirPath = Goose.DirPath + "Assets\Text\NotepadMessages\"
        End With
    End Function

    Public Function ReadGooseConfigIni()
        With GooseConfig
            .EnableMods = GetStrFromIni("EnableMods")
            .SilenceSounds = GetStrFromIni("SilenceSounds")
            .Task_CanAttackMouse = GetStrFromIni("Task_CanAttackMouse")
            .AttackRandomly = GetStrFromIni("AttackRandomly")
            .UseCustomColors = GetStrFromIni("UseCustomColors")
            .GooseDefaultWhite = GetStrFromIni("GooseDefaultWhite")
            .GooseDefaultOrange = GetStrFromIni("GooseDefaultOrange")
            .GooseDefaultOutline = GetStrFromIni("GooseDefaultOutline")
            .MinWanderingTimeSeconds = GetStrFromIni("MinWanderingTimeSeconds")
            .MaxWanderingTimeSeconds = GetStrFromIni("MaxWanderingTimeSeconds")
            .FirstWanderTimeSeconds = GetStrFromIni("FirstWanderTimeSeconds")
        End With
    End Function

    Public Function DeleteDir(ByVal DirPath As String)
        Dim FI As FileInfo
        Dim DI As New DirectoryInfo(DirPath)
        For Each FI In DI.GetFiles
            File.Delete(FI.FullName)
        Next
        For Each DI In DI.GetDirectories
            DeleteDir(DI.FullName)
        Next
    End Function
End Module

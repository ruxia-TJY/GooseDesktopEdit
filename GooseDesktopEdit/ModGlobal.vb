Imports System.IO



Module ModGlobal

    ' Goose软件的路径
    Public Structure GooseStru
        Dim DirPath As String               ' 文件夹路径
        Dim ExePath As String               ' Goose的Exe路径
        Dim CloseExePath As String          ' 关闭GooseDesktop的文件路径，Goose自带Close Goose.bat
        Dim ConfigIniPath As String         ' Goose配置文件路径
        Dim ImgDirPath As String
        Dim ModDirPath As String
        Dim SoundDirPath As String
        Dim TxtDirPath As String
    End Structure

    Public Structure GooseConfigStru        'Goose各项配置
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

    Public Structure MyExeStru      ' 本程序结构体
        Dim DirPath As String       ' 文件夹路径
        Dim ConfigPath As String    ' 配置路径
    End Structure

    Public MyExe As MyExeStru
    Public Goose As GooseStru
    Public GooseConfig As GooseConfigStru



    ''' <summary>
    ''' 设置本程序路径
    ''' </summary>
    Public Sub SetMyExeStru(ByVal ExeS As MyExeStru)
        ExeS.DirPath = My.Application.Info.DirectoryPath.ToString
        If Microsoft.VisualBasic.Right(ExeS.DirPath, 1) <> "\" Then
            ExeS.DirPath += "\"
        End If

        ExeS.ConfigPath = ExeS.DirPath + "set.config"
    End Sub

    Public Function SetGooseStru()
        If Microsoft.VisualBasic.Right(Goose.DirPath, 1) <> "\" Then
            Goose.DirPath += "\"
        End If

        With Goose
            .ExePath = Goose.DirPath + "GooseDesktop.exe"
            .CloseExePath = Goose.DirPath + "Close Goose.bat"
            .ConfigIniPath = Goose.DirPath + "config.ini"
            .ImgDirPath = Goose.DirPath + "Assets\Images\Memes\"
            .ModDirPath = Goose.DirPath + "Assets\Mods\"
            .SoundDirPath = Goose.DirPath + "Assets\Sound\Music\"
            .TxtDirPath = Goose.DirPath + "Assets\Text\NotepadMessages\"
        End With
    End Function

    Public Function ReadGooseConfigIni()
        With GooseConfig
            .EnableMods = GetValueFromIniByKey("EnableMods")
            .SilenceSounds = GetValueFromIniByKey("SilenceSounds")
            .Task_CanAttackMouse = GetValueFromIniByKey("Task_CanAttackMouse")
            .AttackRandomly = GetValueFromIniByKey("AttackRandomly")
            .UseCustomColors = GetValueFromIniByKey("UseCustomColors")
            .GooseDefaultWhite = GetValueFromIniByKey("GooseDefaultWhite")
            .GooseDefaultOrange = GetValueFromIniByKey("GooseDefaultOrange")
            .GooseDefaultOutline = GetValueFromIniByKey("GooseDefaultOutline")
            .MinWanderingTimeSeconds = GetValueFromIniByKey("MinWanderingTimeSeconds")
            .MaxWanderingTimeSeconds = GetValueFromIniByKey("MaxWanderingTimeSeconds")
            .FirstWanderTimeSeconds = GetValueFromIniByKey("FirstWanderTimeSeconds")
        End With
    End Function

    ''' <summary>
    ''' 删除文件夹
    ''' </summary>
    ''' <param name="DirPath">要删除的文件夹名称</param>
    ''' <returns></returns>
    Public Sub DeleteDir(ByVal DirPath As String)
        Dim FI As FileInfo
        Dim DI As New DirectoryInfo(DirPath)
        For Each FI In DI.GetFiles
            File.Delete(FI.FullName)
        Next
        For Each DI In DI.GetDirectories
            DeleteDir(DI.FullName)
        Next
    End Sub

    ''' <summary>
    ''' 设置GooseDesktop路径
    ''' </summary>
    ''' <returns></returns>
    Public Function SetGooseExePath()
        Dim OFD As New OpenFileDialog
        OFD.Filter = "GooseDesktop.exe|GooseDesktop.exe"
        OFD.Title = "选择主程序GooseDesktop.exe"
        If OFD.ShowDialog = DialogResult.OK Then
            'MsgBox("选择的路径是：" + OFD.FileName,, "提示")
            Goose.DirPath = Path.GetDirectoryName(OFD.FileName)
            If Microsoft.VisualBasic.Right(Goose.DirPath, 1) <> "\" Then
                Goose.DirPath += "\"
            End If
            SetGooseStru()
            Return True
        End If
        Return False
    End Function
End Module

Imports System.Drawing.Drawing2D
Imports System.IO

Public Class Frmmain
    Dim IsInit As Boolean = True
    Dim TxtChanged As Boolean = False
    Dim LstIndexChanged As Boolean = False

    Public Sub ReadGooseFileToLst()
        Dim FI As FileInfo
        Dim DI As DirectoryInfo

        Lst_Img.Items.Clear()
        Dim ImgDirInfo As New DirectoryInfo(Goose.ImgDirPath)
        For Each FI In ImgDirInfo.GetFiles
            Lst_Img.Items.Add(FI.Name)
        Next

        Lst_Mod.Items.Clear()
        Dim ModDirInfo As New DirectoryInfo(Goose.ModDirPath)
        For Each DI In ModDirInfo.GetDirectories
            Lst_Mod.Items.Add(DI.Name)
        Next

        Lst_Txt.Items.Clear()
        Dim TxtDirInfo As New DirectoryInfo(Goose.TxtDirPath)
        For Each FI In TxtDirInfo.GetFiles
            Lst_Txt.Items.Add(FI.Name)
        Next

    End Sub

    Private Sub SetAsGooseConfigStru()
        If GooseConfig.EnableMods = "True" Then
            Chk_Mod.Checked = True
        Else
            Chk_Mod.Checked = False
        End If
        If GooseConfig.SilenceSounds = "True" Then
            Chk_SilenceSounds.Checked = True
        Else
            Chk_SilenceSounds.Checked = False
        End If
        If GooseConfig.Task_CanAttackMouse = "True" Then
            Chk_CanAttackMouse.Checked = True
        Else
            Chk_CanAttackMouse.Checked = False
        End If
        If GooseConfig.AttackRandomly = "True" Then
            Chk_AttackRandomly.Checked = True
        Else
            Chk_AttackRandomly.Checked = False
        End If
        If GooseConfig.UseCustomColors = "True" Then
            Chk_UseCustomColors.Checked = True
            Lbl_GooseDefaultWhite.Text = GooseConfig.GooseDefaultWhite
            Lbl_GooseDefaultOrange.Text = GooseConfig.GooseDefaultOrange
            Lbl_GooseDefaultOutline.Text = GooseConfig.GooseDefaultOutline
        Else
            Chk_UseCustomColors.Checked = False
            Lbl_GooseDefaultWhite.Text = "#ffffff"
            Lbl_GooseDefaultOrange.Text = "#ffa500"
            Lbl_GooseDefaultOutline.Text = "#d3d3d3"
        End If
        NUD_MinWanderingTimeSeconds.Value = 20
        NUD_MaxWanderingTimeSeconds.Value = 40
        NUD_FirstWanderTimeSeconds.Value = 20
    End Sub

    Private Sub Frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 设置本程序信息结构体
        SetMyExeStru()

        ' 如果存在配置文件
        If File.Exists(MyExe.ConfigPath) Then
            ' 读取配置文件
            Dim SR As New StreamReader(MyExe.ConfigPath)
            Goose.DirPath = SR.ReadLine
            SR.Close()
            If Microsoft.VisualBasic.Right(Goose.DirPath, 1) <> "\" Then
                Goose.DirPath += "\"
            End If

            ' 配置文件的Goose路径不存在
            If Directory.Exists(Goose.DirPath) = False Then
                SearchGooseExePath()
            End If
        Else
            SearchGooseExePath()
        End If
        Lbl_URL.Text = Goose.DirPath

        ' 根据Goose路径，设置Goose信息结构体
        SetGooseStru()
        ' 读取Goose配置文件，复制到Goose配置信息结构体
        ReadGooseConfigIni()
        ' 根据Goose配置信息结构体配置本程序控件初始值
        SetAsGooseConfigStru()
        ' 读取Goose下可配置的的图片Mod音乐文本文件
        ReadGooseFileToLst()

        If File.Exists(Goose.SoundDirPath + "Music.mp3") Then
            Chk_Music.Checked = True
        End If

        ' 初始化控件特效
        Pic_Img_Add.Image = Image.FromFile("Res\Add.png")
        Pic_Img_Delete.Image = Image.FromFile("Res\Delete.png")
        Pic_Mod_Add.Image = Image.FromFile("Res\Add.png")
        Pic_Mod_Delete.Image = Image.FromFile("Res\Delete.png")
        Pic_Txt_Add.Image = Image.FromFile("Res\Add.png")
        Pic_Txt_Delete.Image = Image.FromFile("Res\Delete.png")
        Pic_Txt_Save.Image = Image.FromFile("Res\Saved.png")

        IsInit = False
    End Sub


    Private Sub Lst_Img_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Img.SelectedIndexChanged
        If Lst_Img.SelectedIndex <> -1 Then
            Dim memoryStream_start As New MemoryStream()
            Using Fs As New FileStream(Goose.ImgDirPath + Lst_Img.SelectedItem, IO.FileMode.Open, IO.FileAccess.Read)
                Dim Buff(Fs.Length - 1) As Byte
                Fs.Read(Buff, 0, Fs.Length - 1)
                memoryStream_start.Write(Buff, 0, Buff.Length - 1)
                Pic_ImgView.Image = Image.FromStream(memoryStream_start)
            End Using
        End If
    End Sub


    Private Sub Pic_Img_Add_Click(sender As Object, e As EventArgs) Handles Pic_Img_Add.Click
        Dim OFD As New OpenFileDialog
        OFD.Title = "选择一张图片"
        If OFD.ShowDialog = DialogResult.OK Then
            Dim ImgName As String = Path.GetFileName(OFD.FileName)
            Dim ImgExtension As String = Path.GetExtension(OFD.FileName)
            Dim SaveName As String = Goose.ImgDirPath
            Dim i As Integer = 0
            If File.Exists(Goose.ImgDirPath + ImgName) Then
                While (File.Exists(Goose.ImgDirPath + i.ToString + ImgExtension))
                    i += 1
                End While
                SaveName += i.ToString
                SaveName += ImgExtension
            Else
                SaveName += ImgName
            End If
            File.Copy(OFD.FileName, SaveName)
            ReadGooseFileToLst()
        End If
    End Sub

    Private Sub Pic_Img_Delete_Click(sender As Object, e As EventArgs) Handles Pic_Img_Delete.Click
        If Lst_Img.SelectedIndex <> -1 Then
            File.Delete(Goose.ImgDirPath + Lst_Img.SelectedItem)
            ReadGooseFileToLst()
        End If
    End Sub

    Private Sub Lst_Txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lst_Txt.SelectedIndexChanged
        If Lst_Txt.SelectedIndex <> -1 Then
            Pic_Txt_Save.Image = Image.FromFile("Res\Saved.png")
            LstIndexChanged = True
            Dim SR As New StreamReader(Goose.TxtDirPath + Lst_Txt.SelectedItem.ToString())
            Txt_ViewEdit.Text = SR.ReadToEnd
            SR.Close()
        End If
    End Sub

    Private Sub Pic_Img_Add_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Img_Add.MouseMove
        Pic_Img_Add.Image = Image.FromFile("Res\Add_Moved.png")
    End Sub

    Private Sub Pic_Txt_Add_Click(sender As Object, e As EventArgs) Handles Pic_Txt_Add.Click
        Dim OFD As New OpenFileDialog
        OFD.Title = "请选择一个文本文件"
        OFD.Filter = "文本文件(*.txt)|*.txt"
        If OFD.ShowDialog = DialogResult.OK Then
            Dim TxtName As String = Path.GetFileName(OFD.FileName)
            Dim SaveName As String = Goose.TxtDirPath
            If File.Exists(Goose.TxtDirPath + TxtName) Then
                Dim I As Integer = 0
                While (File.Exists(Goose.TxtDirPath + I.ToString + ".txt"))
                    I += 1
                End While
                SaveName += I.ToString
                SaveName += ".txt"
            Else
                SaveName += TxtName
            End If
            FileSystem.FileCopy(OFD.FileName, SaveName)
            ReadGooseFileToLst()
        End If
    End Sub


    Private Sub Pic_Txt_Delete_Click(sender As Object, e As EventArgs) Handles Pic_Txt_Delete.Click
        If Lst_Txt.SelectedIndex <> -1 Then
            File.Delete(Goose.TxtDirPath + Lst_Txt.SelectedItem)
            ReadGooseFileToLst()
        End If
    End Sub

    Private Sub Txt_ViewEdit_TextChanged(sender As Object, e As EventArgs) Handles Txt_ViewEdit.TextChanged
        If LstIndexChanged = False Then
            TxtChanged = True
            Pic_Txt_Save.Image = Image.FromFile("Res\UnSaved.png")
        Else
            LstIndexChanged = False
        End If
    End Sub

    Private Sub Btn_SetGoosePath_Click(sender As Object, e As EventArgs) Handles Btn_SetGoosePath.Click
        Dim OFD As New OpenFileDialog
        OFD.Filter = "GooseDesktop.exe|GooseDesktop.exe"
        OFD.Title = "选择主程序GooseDesktop.exe"
        If OFD.ShowDialog = DialogResult.OK Then
            MsgBox("选择的路径是：" + OFD.FileName,, "提示")
            Goose.DirPath = Path.GetDirectoryName(OFD.FileName)
            If Microsoft.VisualBasic.Right(Goose.DirPath, 1) <> "\" Then
                Goose.DirPath += "\"
            End If
            SetGooseStru()
        End If
    End Sub


    Private Sub Pic_Img_Add_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Img_Add.MouseLeave
        Pic_Img_Add.Image = Image.FromFile("Res\Add.png")
    End Sub

    Private Sub Pic_Img_Delete_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Img_Delete.MouseMove
        Pic_Img_Delete.Image = Image.FromFile("Res\Delete_Moved.png")
    End Sub

    Private Sub Pic_Img_Delete_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Img_Delete.MouseLeave
        Pic_Img_Delete.Image = Image.FromFile("Res\Delete.png")
    End Sub

    Private Sub Pic_Txt_Add_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Txt_Add.MouseMove
        Pic_Txt_Add.Image = Image.FromFile("Res\Add_Moved.png")
    End Sub

    Private Sub Pic_Txt_Add_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Txt_Add.MouseLeave
        Pic_Txt_Add.Image = Image.FromFile("Res\Add.png")
    End Sub

    Private Sub Pic_Txt_Delete_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Txt_Delete.MouseMove
        Pic_Txt_Delete.Image = Image.FromFile("Res\Delete_Moved.png")
    End Sub

    Private Sub Pic_Txt_Delete_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Txt_Delete.MouseLeave
        Pic_Txt_Delete.Image = Image.FromFile("Res\Delete.png")
    End Sub

    Private Sub Pic_Save_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Txt_Save.MouseMove
        If TxtChanged Then
            Pic_Txt_Save.Image = Image.FromFile("Res\UnSaved_Moved.png")
        Else
            Pic_Txt_Save.Image = Image.FromFile("Res\Saved_Moved.png")
        End If
    End Sub

    Private Sub Pic_Save_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Txt_Save.MouseLeave
        If TxtChanged Then
            Pic_Txt_Save.Image = Image.FromFile("Res\UnSaved.png")
        Else
            Pic_Txt_Save.Image = Image.FromFile("Res\Saved.png")
        End If
    End Sub


    Private Sub Lbl_GooseDefaultOrange_Click(sender As Object, e As EventArgs) Handles Lbl_GooseDefaultOrange.Click
        If Chk_UseCustomColors.Checked = False Then
            MsgBox("请先勾选 允许自定义颜色",, "提示")
            Exit Sub
        End If

        Dim CD As New ColorDialog
        If CD.ShowDialog = DialogResult.OK Then
            GooseConfig.GooseDefaultOrange = RGBToHEX(CD.Color.R, CD.Color.G, CD.Color.B)
            Lbl_GooseDefaultOrange.Text = GooseConfig.GooseDefaultOrange
            WriteStruToIni()
        End If
    End Sub

    Private Sub Lbl_GooseDefaultWhite_Click(sender As Object, e As EventArgs) Handles Lbl_GooseDefaultWhite.Click
        If Chk_UseCustomColors.Checked = False Then
            MsgBox("请先勾选 允许自定义颜色",, "提示")
            Exit Sub
        End If

        Dim CD As New ColorDialog
        If CD.ShowDialog = DialogResult.OK Then
            GooseConfig.GooseDefaultWhite = RGBToHEX(CD.Color.R, CD.Color.G, CD.Color.B)
            Lbl_GooseDefaultWhite.Text = GooseConfig.GooseDefaultWhite
            WriteStruToIni()
        End If
    End Sub

    Private Sub Lbl_GooseDefaultOutline_Click(sender As Object, e As EventArgs) Handles Lbl_GooseDefaultOutline.Click
        If Chk_UseCustomColors.Checked = False Then
            MsgBox("请先勾选 允许自定义颜色",, "提示")
            Exit Sub
        End If

        Dim CD As New ColorDialog
        If CD.ShowDialog = DialogResult.OK Then
            GooseConfig.GooseDefaultOutline = RGBToHEX(CD.Color.R, CD.Color.G, CD.Color.B)
            Lbl_GooseDefaultOutline.Text = GooseConfig.GooseDefaultOutline
            WriteStruToIni()
        End If
    End Sub

    Public Function RGBToHEX(ByVal R As Integer, G As Integer, B As Integer)
        Dim HexStr As String = "#"
        If Len(Hex(R).ToString) = 1 Then
            HexStr += "0"
        End If
        HexStr += Hex(R).ToString

        If Len(Hex(G).ToString) = 1 Then
            HexStr += "0"
        End If
        HexStr += Hex(G).ToString

        If Len(Hex(B).ToString) = 1 Then
            HexStr += "0"
        End If
        HexStr += Hex(B).ToString
        Return HexStr
    End Function

    Private Sub Chk_SilenceSounds_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_SilenceSounds.CheckedChanged
        If IsInit Then
            Exit Sub
        End If

        If Chk_SilenceSounds.Checked Then
            GooseConfig.SilenceSounds = "True"
        Else
            GooseConfig.SilenceSounds = "False"
        End If
        WriteStruToIni()
    End Sub

    Private Sub Chk_CanAttackMouse_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_CanAttackMouse.CheckedChanged
        If IsInit Then
            Exit Sub
        End If
        If Chk_CanAttackMouse.Checked Then
            GooseConfig.Task_CanAttackMouse = "True"
        Else
            GooseConfig.Task_CanAttackMouse = "False"
        End If
        WriteStruToIni()
    End Sub

    Private Sub Chk_AttackRandomly_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_AttackRandomly.CheckedChanged
        If IsInit Then
            Exit Sub
        End If
        If Chk_AttackRandomly.Checked Then
            GooseConfig.AttackRandomly = "True"
        Else
            GooseConfig.AttackRandomly = "False"
        End If
        WriteStruToIni()
    End Sub

    Private Sub Chk_UseCustomColors_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_UseCustomColors.CheckedChanged
        If IsInit Then
            Exit Sub
        End If
        If Chk_UseCustomColors.Checked Then
            GooseConfig.UseCustomColors = "True"
        Else
            GooseConfig.UseCustomColors = "False"
        End If
    End Sub

    Private Sub Chk_Mod_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Mod.CheckedChanged
        If IsInit Then
            Exit Sub
        End If
        If Chk_Mod.Checked Then
            GooseConfig.EnableMods = "True"
        Else
            GooseConfig.EnableMods = "False"
        End If
        WriteStruToIni()
    End Sub

    Private Sub NUD_MinWanderingTimeSeconds_ValueChanged(sender As Object, e As EventArgs) Handles NUD_MinWanderingTimeSeconds.ValueChanged
        If IsInit Then
            Exit Sub
        End If
        GooseConfig.MinWanderingTimeSeconds = NUD_MinWanderingTimeSeconds.Value
        WriteStruToIni()
    End Sub

    Private Sub NUD_MaxWanderingTimeSeconds_ValueChanged(sender As Object, e As EventArgs) Handles NUD_MaxWanderingTimeSeconds.ValueChanged
        If IsInit Then
            Exit Sub
        End If
        GooseConfig.MaxWanderingTimeSeconds = NUD_MaxWanderingTimeSeconds.Value
        WriteStruToIni()
    End Sub

    Private Sub NUD_FirstWanderTimeSeconds_ValueChanged(sender As Object, e As EventArgs) Handles NUD_FirstWanderTimeSeconds.ValueChanged
        If IsInit Then
            Exit Sub
        End If
        GooseConfig.FirstWanderTimeSeconds = NUD_FirstWanderTimeSeconds.Value
        WriteStruToIni()
    End Sub


    Private Sub Pic_Mod_Add_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Mod_Add.MouseMove
        Pic_Mod_Add.Image = Image.FromFile("Res\Add_Moved.png")
    End Sub

    Private Sub Pic_Mod_Add_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Mod_Add.MouseLeave
        Pic_Mod_Add.Image = Image.FromFile("Res\Add.png")
    End Sub

    Private Sub Pic_Mod_Delete_Click(sender As Object, e As EventArgs) Handles Pic_Mod_Delete.Click
        If Lst_Mod.SelectedIndex <> -1 Then
            Try
                DeleteDir(Goose.ModDirPath + Lst_Mod.SelectedItem)
                ReadGooseFileToLst()
            Catch ex As Exception
                MsgBox("删除失败，请手动尝试删除文件夹：" + Goose.ModDirPath + Lst_Mod.SelectedItem,, "提示")
            End Try
        End If
    End Sub

    Private Sub Pic_Mod_Delete_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Mod_Delete.MouseMove
        Pic_Mod_Delete.Image = Image.FromFile("Res\Delete_Moved.png")
    End Sub

    Private Sub Pic_Mod_Delete_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Mod_Delete.MouseLeave
        Pic_Mod_Delete.Image = Image.FromFile("Res\Delete.png")
    End Sub

    Private Sub Chk_Music_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Music.CheckedChanged
        If IsInit Then
            Exit Sub
        End If

        If Chk_Music.Checked Then
            If File.Exists(Goose.SoundDirPath + "Music.mp3") = False Then
                If File.Exists(Goose.SoundDirPath + "Rename me to just Music.mp3") Then
                    FileSystem.Rename(Goose.SoundDirPath + "Rename me to just Music.mp3", Goose.SoundDirPath + "Music.mp3")
                End If
            End If
        Else
            If File.Exists(Goose.SoundDirPath + "Music.mp3") Then
                FileSystem.Rename(Goose.SoundDirPath + "Music.mp3", Goose.SoundDirPath + "Rename me to just Music.mp3")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        OFD.Title = "选择一个音乐"
        OFD.Filter = "mp3音乐|*.mp3"
        If OFD.ShowDialog = DialogResult.OK Then
            Dim MusicName As String = Path.GetFileName(OFD.FileName)
            Try
                File.Delete(Goose.SoundDirPath + "Music.mp3")
                File.Delete(Goose.SoundDirPath + "Rename me to just Music.mp3")
                If Chk_Music.Checked Then
                    File.Copy(OFD.FileName, Goose.SoundDirPath + "Music.mp3")
                Else
                    File.Copy(OFD.FileName, Goose.SoundDirPath + "Rename me to just Music.mp3")
                End If
            Catch ex As Exception
                MsgBox("请尝试关闭Goose，或者手动将文件移动到" + Goose.SoundDirPath + vbCrLf + "请注意:你必须将音乐文件命名为Music.mp3,或者Rename me to just Music.mp3",, "警告")
            End Try
        End If
    End Sub

    Private Sub Pic_Txt_Save_Click(sender As Object, e As EventArgs) Handles Pic_Txt_Save.Click
        If Lst_Txt.SelectedIndex <> -1 And TxtChanged = True Then
            Dim SW As New StreamWriter(Goose.TxtDirPath + Lst_Txt.SelectedItem.ToString)
            SW.Write(Txt_ViewEdit.Text)
            SW.Close()
            Pic_Txt_Save.Image = Image.FromFile("Res\Saved.png")
            TxtChanged = False
        End If
    End Sub

    Private Sub Pic_Mod_Add_Click(sender As Object, e As EventArgs) Handles Pic_Mod_Add.Click
        Dim OFD As New OpenFileDialog
        OFD.Title = "选择一个Mod dll"
        OFD.Filter = "Dll文件(*.dll)|*.dll"
        If OFD.ShowDialog = DialogResult.OK Then
            Dim DLLNameWithoutExtension As String = Path.GetFileNameWithoutExtension(OFD.FileName)
            Directory.CreateDirectory(Goose.ModDirPath + DLLNameWithoutExtension)
            File.Copy(OFD.FileName, Goose.ModDirPath + DLLNameWithoutExtension + "\" + DLLNameWithoutExtension + ".dll")
            ReadGooseFileToLst()
        End If
    End Sub

    Private Sub Btn_RunGoose_Click(sender As Object, e As EventArgs) Handles Btn_RunGoose.Click
        Shell(Goose.ExePath)
    End Sub

    Private Sub Btn_CloseGoose_Click(sender As Object, e As EventArgs) Handles Btn_CloseGoose.Click
        Shell(Goose.CloseExePath)
    End Sub

    Private Sub Btn_InitGooseSetIni_Click(sender As Object, e As EventArgs) Handles Btn_InitGooseSetIni.Click
        With GooseConfig
            .EnableMods = "False"
            .SilenceSounds = "False"
            .Task_CanAttackMouse = "True"
            .AttackRandomly = "False"
            .UseCustomColors = "False"
            .GooseDefaultWhite = "#ffffff"
            .GooseDefaultOrange = "#ffa500"
            .GooseDefaultOutline = "#d3d3d3"
            .MinWanderingTimeSeconds = 20
            .MaxWanderingTimeSeconds = 40
            .FirstWanderTimeSeconds = 20
        End With
        WriteStruToIni()
        IsInit = True
        SetAsGooseConfigStru()
        IsInit = False
    End Sub
End Class

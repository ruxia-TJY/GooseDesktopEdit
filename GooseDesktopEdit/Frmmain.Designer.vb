<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_URL = New System.Windows.Forms.Label()
        Me.Chk_Mod = New System.Windows.Forms.CheckBox()
        Me.Chk_SilenceSounds = New System.Windows.Forms.CheckBox()
        Me.Chk_CanAttackMouse = New System.Windows.Forms.CheckBox()
        Me.Chk_AttackRandomly = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_GooseDefaultOutline = New System.Windows.Forms.Label()
        Me.Lbl_GooseDefaultWhite = New System.Windows.Forms.Label()
        Me.Lbl_GooseDefaultOrange = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chk_UseCustomColors = New System.Windows.Forms.CheckBox()
        Me.Btn_RunGoose = New System.Windows.Forms.Button()
        Me.Btn_CloseGoose = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Pic_Img_Delete = New System.Windows.Forms.PictureBox()
        Me.Pic_Img_Add = New System.Windows.Forms.PictureBox()
        Me.Pic_ImgView = New System.Windows.Forms.PictureBox()
        Me.Lst_Img = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Pic_Mod_Delete = New System.Windows.Forms.PictureBox()
        Me.Pic_Mod_Add = New System.Windows.Forms.PictureBox()
        Me.Lst_Mod = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chk_Music = New System.Windows.Forms.CheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Pic_Txt_Save = New System.Windows.Forms.PictureBox()
        Me.Pic_Txt_Delete = New System.Windows.Forms.PictureBox()
        Me.Pic_Txt_Add = New System.Windows.Forms.PictureBox()
        Me.Txt_ViewEdit = New System.Windows.Forms.TextBox()
        Me.Lst_Txt = New System.Windows.Forms.ListBox()
        Me.Btn_SetGoosePath = New System.Windows.Forms.Button()
        Me.Btn_InitGooseSetIni = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUD_MinWanderingTimeSeconds = New System.Windows.Forms.NumericUpDown()
        Me.NUD_MaxWanderingTimeSeconds = New System.Windows.Forms.NumericUpDown()
        Me.NUD_FirstWanderTimeSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Pic_Img_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Img_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_ImgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Pic_Mod_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Mod_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.Pic_Txt_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Txt_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Txt_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_MinWanderingTimeSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_MaxWanderingTimeSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_FirstWanderTimeSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "检测到的路径为："
        '
        'Lbl_URL
        '
        Me.Lbl_URL.AutoSize = True
        Me.Lbl_URL.Location = New System.Drawing.Point(106, 9)
        Me.Lbl_URL.Name = "Lbl_URL"
        Me.Lbl_URL.Size = New System.Drawing.Size(0, 12)
        Me.Lbl_URL.TabIndex = 1
        '
        'Chk_Mod
        '
        Me.Chk_Mod.AutoSize = True
        Me.Chk_Mod.Location = New System.Drawing.Point(5, 12)
        Me.Chk_Mod.Name = "Chk_Mod"
        Me.Chk_Mod.Size = New System.Drawing.Size(66, 16)
        Me.Chk_Mod.TabIndex = 2
        Me.Chk_Mod.Text = "启用Mod"
        Me.Chk_Mod.UseVisualStyleBackColor = True
        '
        'Chk_SilenceSounds
        '
        Me.Chk_SilenceSounds.AutoSize = True
        Me.Chk_SilenceSounds.Location = New System.Drawing.Point(16, 27)
        Me.Chk_SilenceSounds.Name = "Chk_SilenceSounds"
        Me.Chk_SilenceSounds.Size = New System.Drawing.Size(48, 16)
        Me.Chk_SilenceSounds.TabIndex = 3
        Me.Chk_SilenceSounds.Text = "静音"
        Me.Chk_SilenceSounds.UseVisualStyleBackColor = True
        '
        'Chk_CanAttackMouse
        '
        Me.Chk_CanAttackMouse.AutoSize = True
        Me.Chk_CanAttackMouse.Location = New System.Drawing.Point(16, 49)
        Me.Chk_CanAttackMouse.Name = "Chk_CanAttackMouse"
        Me.Chk_CanAttackMouse.Size = New System.Drawing.Size(96, 16)
        Me.Chk_CanAttackMouse.TabIndex = 4
        Me.Chk_CanAttackMouse.Text = "允许移动鼠标"
        Me.Chk_CanAttackMouse.UseVisualStyleBackColor = True
        '
        'Chk_AttackRandomly
        '
        Me.Chk_AttackRandomly.AutoSize = True
        Me.Chk_AttackRandomly.Location = New System.Drawing.Point(16, 71)
        Me.Chk_AttackRandomly.Name = "Chk_AttackRandomly"
        Me.Chk_AttackRandomly.Size = New System.Drawing.Size(72, 16)
        Me.Chk_AttackRandomly.TabIndex = 5
        Me.Chk_AttackRandomly.Text = "随机攻击"
        Me.Chk_AttackRandomly.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_GooseDefaultOutline)
        Me.GroupBox1.Controls.Add(Me.Lbl_GooseDefaultWhite)
        Me.GroupBox1.Controls.Add(Me.Lbl_GooseDefaultOrange)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Chk_UseCustomColors)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 66)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "自定义颜色"
        '
        'Lbl_GooseDefaultOutline
        '
        Me.Lbl_GooseDefaultOutline.AutoSize = True
        Me.Lbl_GooseDefaultOutline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_GooseDefaultOutline.Location = New System.Drawing.Point(163, 41)
        Me.Lbl_GooseDefaultOutline.Name = "Lbl_GooseDefaultOutline"
        Me.Lbl_GooseDefaultOutline.Size = New System.Drawing.Size(47, 12)
        Me.Lbl_GooseDefaultOutline.TabIndex = 6
        Me.Lbl_GooseDefaultOutline.Text = "#ffffff"
        '
        'Lbl_GooseDefaultWhite
        '
        Me.Lbl_GooseDefaultWhite.AutoSize = True
        Me.Lbl_GooseDefaultWhite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_GooseDefaultWhite.Location = New System.Drawing.Point(43, 41)
        Me.Lbl_GooseDefaultWhite.Name = "Lbl_GooseDefaultWhite"
        Me.Lbl_GooseDefaultWhite.Size = New System.Drawing.Size(47, 12)
        Me.Lbl_GooseDefaultWhite.TabIndex = 5
        Me.Lbl_GooseDefaultWhite.Text = "#ffffff"
        '
        'Lbl_GooseDefaultOrange
        '
        Me.Lbl_GooseDefaultOrange.AutoSize = True
        Me.Lbl_GooseDefaultOrange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_GooseDefaultOrange.Location = New System.Drawing.Point(163, 17)
        Me.Lbl_GooseDefaultOrange.Name = "Lbl_GooseDefaultOrange"
        Me.Lbl_GooseDefaultOrange.Size = New System.Drawing.Size(47, 12)
        Me.Lbl_GooseDefaultOrange.TabIndex = 4
        Me.Lbl_GooseDefaultOrange.Text = "#ffffff"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "周围："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "嘴脚："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "身体："
        '
        'Chk_UseCustomColors
        '
        Me.Chk_UseCustomColors.AutoSize = True
        Me.Chk_UseCustomColors.Location = New System.Drawing.Point(10, 17)
        Me.Chk_UseCustomColors.Name = "Chk_UseCustomColors"
        Me.Chk_UseCustomColors.Size = New System.Drawing.Size(108, 16)
        Me.Chk_UseCustomColors.TabIndex = 0
        Me.Chk_UseCustomColors.Text = "允许自定义颜色"
        Me.Chk_UseCustomColors.UseVisualStyleBackColor = True
        '
        'Btn_RunGoose
        '
        Me.Btn_RunGoose.Location = New System.Drawing.Point(410, 30)
        Me.Btn_RunGoose.Name = "Btn_RunGoose"
        Me.Btn_RunGoose.Size = New System.Drawing.Size(90, 23)
        Me.Btn_RunGoose.TabIndex = 7
        Me.Btn_RunGoose.Text = "启动Goose"
        Me.Btn_RunGoose.UseVisualStyleBackColor = True
        '
        'Btn_CloseGoose
        '
        Me.Btn_CloseGoose.Location = New System.Drawing.Point(410, 57)
        Me.Btn_CloseGoose.Name = "Btn_CloseGoose"
        Me.Btn_CloseGoose.Size = New System.Drawing.Size(90, 23)
        Me.Btn_CloseGoose.TabIndex = 8
        Me.Btn_CloseGoose.Text = "关闭Goose"
        Me.Btn_CloseGoose.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(6, 166)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(495, 224)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Pic_Img_Delete)
        Me.TabPage1.Controls.Add(Me.Pic_Img_Add)
        Me.TabPage1.Controls.Add(Me.Pic_ImgView)
        Me.TabPage1.Controls.Add(Me.Lst_Img)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(487, 198)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "图片"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Pic_Img_Delete
        '
        Me.Pic_Img_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Img_Delete.Location = New System.Drawing.Point(31, 172)
        Me.Pic_Img_Delete.Name = "Pic_Img_Delete"
        Me.Pic_Img_Delete.Size = New System.Drawing.Size(20, 20)
        Me.Pic_Img_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Img_Delete.TabIndex = 3
        Me.Pic_Img_Delete.TabStop = False
        '
        'Pic_Img_Add
        '
        Me.Pic_Img_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Img_Add.Location = New System.Drawing.Point(5, 172)
        Me.Pic_Img_Add.Name = "Pic_Img_Add"
        Me.Pic_Img_Add.Size = New System.Drawing.Size(20, 20)
        Me.Pic_Img_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Img_Add.TabIndex = 2
        Me.Pic_Img_Add.TabStop = False
        '
        'Pic_ImgView
        '
        Me.Pic_ImgView.Location = New System.Drawing.Point(170, 6)
        Me.Pic_ImgView.Name = "Pic_ImgView"
        Me.Pic_ImgView.Size = New System.Drawing.Size(308, 186)
        Me.Pic_ImgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_ImgView.TabIndex = 1
        Me.Pic_ImgView.TabStop = False
        '
        'Lst_Img
        '
        Me.Lst_Img.FormattingEnabled = True
        Me.Lst_Img.ItemHeight = 12
        Me.Lst_Img.Location = New System.Drawing.Point(3, 6)
        Me.Lst_Img.Name = "Lst_Img"
        Me.Lst_Img.Size = New System.Drawing.Size(165, 160)
        Me.Lst_Img.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Pic_Mod_Delete)
        Me.TabPage2.Controls.Add(Me.Pic_Mod_Add)
        Me.TabPage2.Controls.Add(Me.Lst_Mod)
        Me.TabPage2.Controls.Add(Me.Chk_Mod)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(487, 198)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mods"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Pic_Mod_Delete
        '
        Me.Pic_Mod_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Mod_Delete.Location = New System.Drawing.Point(31, 175)
        Me.Pic_Mod_Delete.Name = "Pic_Mod_Delete"
        Me.Pic_Mod_Delete.Size = New System.Drawing.Size(20, 20)
        Me.Pic_Mod_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Mod_Delete.TabIndex = 5
        Me.Pic_Mod_Delete.TabStop = False
        '
        'Pic_Mod_Add
        '
        Me.Pic_Mod_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Mod_Add.Location = New System.Drawing.Point(5, 175)
        Me.Pic_Mod_Add.Name = "Pic_Mod_Add"
        Me.Pic_Mod_Add.Size = New System.Drawing.Size(20, 20)
        Me.Pic_Mod_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Mod_Add.TabIndex = 4
        Me.Pic_Mod_Add.TabStop = False
        '
        'Lst_Mod
        '
        Me.Lst_Mod.FormattingEnabled = True
        Me.Lst_Mod.ItemHeight = 12
        Me.Lst_Mod.Location = New System.Drawing.Point(5, 34)
        Me.Lst_Mod.Name = "Lst_Mod"
        Me.Lst_Mod.Size = New System.Drawing.Size(482, 136)
        Me.Lst_Mod.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Chk_Music)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(487, 198)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "音乐"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "加载自定义音乐"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chk_Music
        '
        Me.Chk_Music.AutoSize = True
        Me.Chk_Music.Location = New System.Drawing.Point(5, 14)
        Me.Chk_Music.Name = "Chk_Music"
        Me.Chk_Music.Size = New System.Drawing.Size(288, 16)
        Me.Chk_Music.TabIndex = 0
        Me.Chk_Music.Text = "启用音乐（注：音乐不是鹅叫声，而是背景音乐）"
        Me.Chk_Music.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Pic_Txt_Save)
        Me.TabPage4.Controls.Add(Me.Pic_Txt_Delete)
        Me.TabPage4.Controls.Add(Me.Pic_Txt_Add)
        Me.TabPage4.Controls.Add(Me.Txt_ViewEdit)
        Me.TabPage4.Controls.Add(Me.Lst_Txt)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(487, 198)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "文本"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "点击右边保存"
        '
        'Pic_Txt_Save
        '
        Me.Pic_Txt_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Txt_Save.Location = New System.Drawing.Point(141, 175)
        Me.Pic_Txt_Save.Name = "Pic_Txt_Save"
        Me.Pic_Txt_Save.Size = New System.Drawing.Size(20, 20)
        Me.Pic_Txt_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Txt_Save.TabIndex = 6
        Me.Pic_Txt_Save.TabStop = False
        '
        'Pic_Txt_Delete
        '
        Me.Pic_Txt_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Txt_Delete.Location = New System.Drawing.Point(29, 175)
        Me.Pic_Txt_Delete.Name = "Pic_Txt_Delete"
        Me.Pic_Txt_Delete.Size = New System.Drawing.Size(20, 20)
        Me.Pic_Txt_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Txt_Delete.TabIndex = 5
        Me.Pic_Txt_Delete.TabStop = False
        '
        'Pic_Txt_Add
        '
        Me.Pic_Txt_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Txt_Add.Location = New System.Drawing.Point(3, 175)
        Me.Pic_Txt_Add.Name = "Pic_Txt_Add"
        Me.Pic_Txt_Add.Size = New System.Drawing.Size(20, 20)
        Me.Pic_Txt_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Txt_Add.TabIndex = 4
        Me.Pic_Txt_Add.TabStop = False
        '
        'Txt_ViewEdit
        '
        Me.Txt_ViewEdit.Location = New System.Drawing.Point(171, 3)
        Me.Txt_ViewEdit.Multiline = True
        Me.Txt_ViewEdit.Name = "Txt_ViewEdit"
        Me.Txt_ViewEdit.Size = New System.Drawing.Size(305, 191)
        Me.Txt_ViewEdit.TabIndex = 1
        Me.Txt_ViewEdit.TabStop = False
        '
        'Lst_Txt
        '
        Me.Lst_Txt.FormattingEnabled = True
        Me.Lst_Txt.ItemHeight = 12
        Me.Lst_Txt.Location = New System.Drawing.Point(3, 3)
        Me.Lst_Txt.Name = "Lst_Txt"
        Me.Lst_Txt.Size = New System.Drawing.Size(162, 172)
        Me.Lst_Txt.TabIndex = 0
        '
        'Btn_SetGoosePath
        '
        Me.Btn_SetGoosePath.Location = New System.Drawing.Point(410, 3)
        Me.Btn_SetGoosePath.Name = "Btn_SetGoosePath"
        Me.Btn_SetGoosePath.Size = New System.Drawing.Size(90, 23)
        Me.Btn_SetGoosePath.TabIndex = 10
        Me.Btn_SetGoosePath.Text = "手动配置路径"
        Me.Btn_SetGoosePath.UseVisualStyleBackColor = True
        '
        'Btn_InitGooseSetIni
        '
        Me.Btn_InitGooseSetIni.Location = New System.Drawing.Point(410, 84)
        Me.Btn_InitGooseSetIni.Name = "Btn_InitGooseSetIni"
        Me.Btn_InitGooseSetIni.Size = New System.Drawing.Size(90, 23)
        Me.Btn_InitGooseSetIni.TabIndex = 11
        Me.Btn_InitGooseSetIni.Text = "初始化配置"
        Me.Btn_InitGooseSetIni.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "最少捣乱时间间隔(单位：秒)："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "最长捣乱时间间隔(单位：秒)："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "首次捣乱时间(单位：秒)："
        '
        'NUD_MinWanderingTimeSeconds
        '
        Me.NUD_MinWanderingTimeSeconds.Location = New System.Drawing.Point(181, 97)
        Me.NUD_MinWanderingTimeSeconds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_MinWanderingTimeSeconds.Name = "NUD_MinWanderingTimeSeconds"
        Me.NUD_MinWanderingTimeSeconds.Size = New System.Drawing.Size(114, 21)
        Me.NUD_MinWanderingTimeSeconds.TabIndex = 15
        Me.NUD_MinWanderingTimeSeconds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NUD_MaxWanderingTimeSeconds
        '
        Me.NUD_MaxWanderingTimeSeconds.Location = New System.Drawing.Point(181, 117)
        Me.NUD_MaxWanderingTimeSeconds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_MaxWanderingTimeSeconds.Name = "NUD_MaxWanderingTimeSeconds"
        Me.NUD_MaxWanderingTimeSeconds.Size = New System.Drawing.Size(114, 21)
        Me.NUD_MaxWanderingTimeSeconds.TabIndex = 16
        Me.NUD_MaxWanderingTimeSeconds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NUD_FirstWanderTimeSeconds
        '
        Me.NUD_FirstWanderTimeSeconds.Location = New System.Drawing.Point(181, 138)
        Me.NUD_FirstWanderTimeSeconds.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_FirstWanderTimeSeconds.Name = "NUD_FirstWanderTimeSeconds"
        Me.NUD_FirstWanderTimeSeconds.Size = New System.Drawing.Size(114, 21)
        Me.NUD_FirstWanderTimeSeconds.TabIndex = 17
        Me.NUD_FirstWanderTimeSeconds.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(331, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 14)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Build By ruxia-TJY."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(331, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 12)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "有Bug联系QQ:2378736060"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 24)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "基于.Net FrameWork 4.7.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "搜索基于Everything"
        '
        'Frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 391)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NUD_FirstWanderTimeSeconds)
        Me.Controls.Add(Me.NUD_MaxWanderingTimeSeconds)
        Me.Controls.Add(Me.NUD_MinWanderingTimeSeconds)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_InitGooseSetIni)
        Me.Controls.Add(Me.Btn_SetGoosePath)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Btn_CloseGoose)
        Me.Controls.Add(Me.Btn_RunGoose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Chk_AttackRandomly)
        Me.Controls.Add(Me.Chk_CanAttackMouse)
        Me.Controls.Add(Me.Chk_SilenceSounds)
        Me.Controls.Add(Me.Lbl_URL)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GooseDesktopEdit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Pic_Img_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Img_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_ImgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Pic_Mod_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Mod_Add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Pic_Txt_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Txt_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Txt_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_MinWanderingTimeSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_MaxWanderingTimeSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_FirstWanderTimeSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Chk_Mod As CheckBox
    Friend WithEvents Chk_SilenceSounds As CheckBox
    Friend WithEvents Chk_CanAttackMouse As CheckBox
    Friend WithEvents Chk_AttackRandomly As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_RunGoose As Button
    Friend WithEvents Btn_CloseGoose As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Pic_ImgView As PictureBox
    Friend WithEvents Lst_Img As ListBox
    Friend WithEvents Pic_Img_Add As PictureBox
    Friend WithEvents Pic_Img_Delete As PictureBox
    Friend WithEvents Pic_Txt_Delete As PictureBox
    Friend WithEvents Pic_Txt_Add As PictureBox
    Friend WithEvents Txt_ViewEdit As TextBox
    Friend WithEvents Lst_Txt As ListBox
    Friend WithEvents Pic_Txt_Save As PictureBox
    Friend WithEvents Chk_Music As CheckBox
    Friend WithEvents Btn_SetGoosePath As Button
    Friend WithEvents Btn_InitGooseSetIni As Button
    Friend WithEvents Pic_Mod_Delete As PictureBox
    Friend WithEvents Pic_Mod_Add As PictureBox
    Friend WithEvents Lst_Mod As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Chk_UseCustomColors As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NUD_MinWanderingTimeSeconds As NumericUpDown
    Friend WithEvents NUD_MaxWanderingTimeSeconds As NumericUpDown
    Friend WithEvents NUD_FirstWanderTimeSeconds As NumericUpDown
    Friend WithEvents Lbl_GooseDefaultOutline As Label
    Friend WithEvents Lbl_GooseDefaultWhite As Label
    Friend WithEvents Lbl_GooseDefaultOrange As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class

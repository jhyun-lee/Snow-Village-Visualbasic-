<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameForm))
        Me.CallbackTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_Help = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_menu_Star = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.scorelabel = New System.Windows.Forms.Label()
        Me.lastscore = New System.Windows.Forms.Label()
        Me.Returnmenu = New System.Windows.Forms.Button()
        Me.helpbox = New System.Windows.Forms.PictureBox()
        Me.start_label = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.helpbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CallbackTimer
        '
        Me.CallbackTimer.Enabled = True
        Me.CallbackTimer.Interval = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 204)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Snow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     _ Village"
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.Transparent
        Me.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_Start.FlatAppearance.BorderSize = 0
        Me.btn_Start.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Start.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Start.Location = New System.Drawing.Point(406, 325)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(188, 54)
        Me.btn_Start.TabIndex = 2
        Me.btn_Start.Text = "S T A R T"
        Me.btn_Start.UseVisualStyleBackColor = False
        '
        'btn_Help
        '
        Me.btn_Help.BackColor = System.Drawing.Color.Transparent
        Me.btn_Help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Help.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_Help.FlatAppearance.BorderSize = 0
        Me.btn_Help.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btn_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Help.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Help.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Help.Location = New System.Drawing.Point(406, 401)
        Me.btn_Help.Name = "btn_Help"
        Me.btn_Help.Size = New System.Drawing.Size(188, 54)
        Me.btn_Help.TabIndex = 3
        Me.btn_Help.Text = " H E L P"
        Me.btn_Help.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Exit.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Exit.Location = New System.Drawing.Point(406, 481)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(188, 54)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.Text = "E X I T"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(869, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(52, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(932, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(817, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_menu_Star
        '
        Me.btn_menu_Star.BackColor = System.Drawing.Color.Transparent
        Me.btn_menu_Star.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_menu_Star.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_menu_Star.FlatAppearance.BorderSize = 0
        Me.btn_menu_Star.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_menu_Star.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btn_menu_Star.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray
        Me.btn_menu_Star.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_menu_Star.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_Star.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_menu_Star.Location = New System.Drawing.Point(538, 541)
        Me.btn_menu_Star.Name = "btn_menu_Star"
        Me.btn_menu_Star.Size = New System.Drawing.Size(188, 54)
        Me.btn_menu_Star.TabIndex = 8
        Me.btn_menu_Star.Text = "S T A R T"
        Me.btn_menu_Star.UseVisualStyleBackColor = False
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.Transparent
        Me.btn_return.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_return.FlatAppearance.BorderSize = 0
        Me.btn_return.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray
        Me.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_return.Font = New System.Drawing.Font("Segoe Script", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_return.Location = New System.Drawing.Point(255, 541)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(188, 54)
        Me.btn_return.TabIndex = 9
        Me.btn_return.Text = "M E N U"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'scorelabel
        '
        Me.scorelabel.AutoSize = True
        Me.scorelabel.BackColor = System.Drawing.Color.Transparent
        Me.scorelabel.Font = New System.Drawing.Font("굴림", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.scorelabel.Location = New System.Drawing.Point(671, 19)
        Me.scorelabel.Name = "scorelabel"
        Me.scorelabel.Size = New System.Drawing.Size(129, 35)
        Me.scorelabel.TabIndex = 10
        Me.scorelabel.Text = "Label2"
        '
        'lastscore
        '
        Me.lastscore.AutoSize = True
        Me.lastscore.BackColor = System.Drawing.Color.Transparent
        Me.lastscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lastscore.Font = New System.Drawing.Font("굴림", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lastscore.Location = New System.Drawing.Point(383, 287)
        Me.lastscore.Name = "lastscore"
        Me.lastscore.Size = New System.Drawing.Size(147, 40)
        Me.lastscore.TabIndex = 11
        Me.lastscore.Text = "Label3"
        '
        'Returnmenu
        '
        Me.Returnmenu.BackColor = System.Drawing.Color.Transparent
        Me.Returnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Returnmenu.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Returnmenu.FlatAppearance.BorderSize = 0
        Me.Returnmenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Returnmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray
        Me.Returnmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray
        Me.Returnmenu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Returnmenu.Font = New System.Drawing.Font("Segoe Script", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Returnmenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Returnmenu.Location = New System.Drawing.Point(255, 541)
        Me.Returnmenu.Name = "Returnmenu"
        Me.Returnmenu.Size = New System.Drawing.Size(471, 54)
        Me.Returnmenu.TabIndex = 12
        Me.Returnmenu.Text = "M E N U"
        Me.Returnmenu.UseVisualStyleBackColor = False
        '
        'helpbox
        '
        Me.helpbox.Image = CType(resources.GetObject("helpbox.Image"), System.Drawing.Image)
        Me.helpbox.Location = New System.Drawing.Point(264, 38)
        Me.helpbox.Name = "helpbox"
        Me.helpbox.Size = New System.Drawing.Size(452, 481)
        Me.helpbox.TabIndex = 13
        Me.helpbox.TabStop = False
        '
        'start_label
        '
        Me.start_label.AutoSize = True
        Me.start_label.BackColor = System.Drawing.Color.Transparent
        Me.start_label.Font = New System.Drawing.Font("굴림", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.start_label.Location = New System.Drawing.Point(275, 260)
        Me.start_label.Name = "start_label"
        Me.start_label.Size = New System.Drawing.Size(423, 37)
        Me.start_label.TabIndex = 14
        Me.start_label.Text = "윗방향키를 눌러주세요!"
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.start_label)
        Me.Controls.Add(Me.helpbox)
        Me.Controls.Add(Me.Returnmenu)
        Me.Controls.Add(Me.lastscore)
        Me.Controls.Add(Me.scorelabel)
        Me.Controls.Add(Me.btn_menu_Star)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Help)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "GameForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My_snow_village"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.helpbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CallbackTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Start As Button
    Friend WithEvents btn_Help As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_menu_Star As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents scorelabel As Label
    Friend WithEvents lastscore As Label
    Friend WithEvents Returnmenu As Button
    Friend WithEvents helpbox As PictureBox
    Friend WithEvents start_label As Label
End Class

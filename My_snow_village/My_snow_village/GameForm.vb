Public Class GameForm

    Dim stage_idx As Integer = 0

    Structure Particle
        Dim pos As Point
        Dim Mov_Horizontal_Cnt As Integer
        Dim Mov_Horizontal_Dir As Integer
        Dim Moving As Boolean
        Dim DownSpeed As Integer
    End Structure

    Dim ParticleMax As Integer = 900
    Dim Particles As ArrayList

    Dim Rand As New Random()
    Dim FrameCnt As Integer = 0

    Dim game_snd_menu As New GameSounds


    Dim decoBrush As New System.Drawing.SolidBrush(System.Drawing.Color.White)

    Public MAX_ALPHA As Short = 255
    Public GRAY_DEEP As Color = Color.FromArgb(MAX_ALPHA, 66, 71, 75)
    Public brush_GD As Brush = New SolidBrush(GRAY_DEEP)
    Dim fixedGRAY As Color = Color.FromArgb(80, GRAY_DEEP.R, GRAY_DEEP.G, GRAY_DEEP.B)
    Dim fixedDGRAY As Color = Color.FromArgb(160, GRAY_DEEP.R, GRAY_DEEP.G, GRAY_DEEP.B)


    Dim currentKeys As New ArrayList ''''''''''키 입력

    Dim rect As New Rectangle
    Dim rect2 As New Rectangle

    Dim x As Integer = 300
    Dim y As Integer = 450
    Dim size_h As Integer = 50
    Dim y_spe As Double = 0.0

    Structure locations
        Dim pos_x As Integer
        Dim pos_y As Integer
    End Structure

    Dim snowgrounds_arr As New ArrayList ''''''''''''''바닥

    Dim fire_arr1 As New ArrayList '''''''''''''''''''''장애물
    Dim fire_arr2 As New ArrayList
    Dim fireball_arr As New ArrayList

    Dim snowballs_arr As New ArrayList '''''''''투사체

    Dim healpack_arr As New ArrayList ''''''''''''''''''''''눈사람 힐팩

    Dim hearts_arr As New ArrayList '''''''''''''''''''''''''목숨


    Dim snowground As Image = Image.FromFile("snowground.jpg") '''''''''''이미지모음
    Dim ground As Image = Image.FromFile("ground_bot.png") ''''배경
    Dim bg1 As Image = Image.FromFile("snowfor.jpg")
    Dim bg2 As Image = Image.FromFile("snowfor.jpg")
    Dim snowcity As Image = Image.FromFile("snowcity.png")
    Dim img_snowman As Image = Image.FromFile("snowman.png")

    Dim snowhead As Image = Image.FromFile("snowhead.png") ''장애물
    Dim fire_1 As Image = Image.FromFile("fire.gif")
    Dim fire_2 As Image = Image.FromFile("trian.png")
    Dim fireball As Image = Image.FromFile("fireball.png")
    Dim score As Image = Image.FromFile("snowball.png")

    Dim npcsnow As Image = Image.FromFile("snowman1.png") ''점수,목숨
    Dim heart As Image = Image.FromFile("heart.png")
    Dim healani As Image = Image.FromFile("healani.gif")

    Dim markon As Image = Image.FromFile("markon.png") ''버튼
    Dim markoff As Image = Image.FromFile("markoff.png")
    Dim startbutton As Image = Image.FromFile("startbutton.png")
    Dim stopbutton As Image = Image.FromFile("stopbutton.png")


    Dim bg_x As Integer = 0


    Dim a As Integer = 50
    Dim b As Integer = 0
    Dim count As Integer = 0
    Dim snowhead_count As Integer = 0
    Dim lastheart_s As Integer ''''''''''''하트의 마지막위치


    Dim jump_count As Boolean = False

    Dim markonoff As Boolean = False
    Dim timeronoff As Boolean = True

    Dim resultscore As Integer = 0
    Dim HourPen As System.Drawing.Pen
    Dim checktime As Integer = 0
    Dim score_speed As Integer = 0

    Private Sub CallbackTimer_Tick(sender As Object, e As EventArgs) Handles CallbackTimer.Tick


        If resultscore > 5000 Then

            score_speed = (resultscore - 5000) / 10000

        End If


        If stage_idx = 0 Then
            ParticleUpdate()
        ElseIf stage_idx = 1 Then
            ImageAnimator.UpdateFrames()
            bg_x -= 8 + score_speed

            For j = 0 To snowgrounds_arr.Count - 1 ''''''땅
                Dim newin = CType(snowgrounds_arr(j), locations)

                snowgrounds_arr(j) = newin
            Next

            For j = 0 To fire_arr1.Count - 1 '''장애물 1
                Dim newin = CType(fire_arr1(j), locations)
                newin.pos_x -= 7 + score_speed
                fire_arr1(j) = newin
            Next

            For j = 0 To fire_arr2.Count - 1 '가시
                Dim newin = CType(fire_arr2(j), locations)
                newin.pos_x -= 7 + score_speed
                fire_arr2(j) = newin
            Next

            For j = 0 To fireball_arr.Count - 1 '파이어볼
                Dim newin = CType(fireball_arr(j), locations)
                newin.pos_x -= 9 + score_speed
                fireball_arr(j) = newin
            Next

            For j = 0 To healpack_arr.Count - 1 ''힐팩눈사람
                Dim newin = CType(healpack_arr(j), locations)
                newin.pos_x -= 7 + score_speed
                healpack_arr(j) = newin
            Next

            For i = 0 To snowballs_arr.Count - 1 ''''''''''''''''''눈던지기
                Dim obj = CType(snowballs_arr(i), locations)

                obj.pos_x += 11 + score_speed
                snowballs_arr(i) = obj
                If obj.pos_x > 1000 Then
                    snowballs_arr.RemoveAt(i)
                    add_arr(-100, -100, snowballs_arr)
                End If

            Next

            For i = 0 To currentKeys.Count - 1

                Select Case currentKeys(i)
                    Case Keys.Left

                    Case Keys.Right
                        count += 1
                        If count = 5 Then
                            snowhead.RotateFlip(RotateFlipType.Rotate90FlipNone) ''''''''''''''''''머리돌리기
                            If snowhead_count = 50 Then
                                add_arr(lastheart_s + 30, 20, hearts_arr)
                                resultscore += 200
                                snowhead_count = 0
                            Else

                                snowhead_count += 1
                            End If
                            count = 0
                        End If
                    Case Keys.Up

                        jump_count = True
                        If 500 - (y + size_h) < 1 Then
                            y_spe = -20
                            game_snd_menu.Play("jump")
                        End If


                    Case Keys.Space

                End Select

            Next

            If (bg_x <= -Me.Width) Then ''배경 이동
                bg_x = Me.Width
            End If

            If jump_count Then

                mainjump()

                If 500 - (y + size_h) < 1 Then

                    jump_count = False

                    End If

                End If
                collision_fire() '''''''''''''충돌 모음
            collision_fireball()
            collision_healpack()
            collision_fire2()

            lastheart()


            If hearts_arr.Count = 0 Then
                'Timer1.Stop()
                stage_idx = 2
            End If
        End If

        Invalidate()
    End Sub
    Private Sub btn_option(btn)
        With btn
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With
    End Sub
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        btn_Start.TabStop = False
        btn_Start.FlatStyle = FlatStyle.Flat
        btn_Start.FlatAppearance.BorderSize = 0

        game_snd_menu.AddSound("click", "click.wav")
        game_snd_menu.AddSound("background", "backgroundsound,wav")

        btn_option(btn_Start)
        btn_option(btn_Help)
        btn_option(btn_Exit)
        btn_option(btn_menu_Star)
        btn_option(btn_return)
        btn_option(Returnmenu)

        My.Computer.Audio.Play("backgroundsound.wav", AudioPlayMode.BackgroundLoop)
        Label1.BackColor = Color.Transparent

        Particles = New ArrayList



        'mainform code
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        btn_return.Visible = False
        Returnmenu.Visible = False
        btn_menu_Star.Visible = False
        helpbox.Visible = False
        lastscore.Visible = False
        scorelabel.Visible = False
        start_label.Visible = False

        Me.KeyPreview = True ''키 입력시 필요

        bg2.RotateFlip(RotateFlipType.RotateNoneFlipX)
        ImageAnimator.Animate(healani, New EventHandler(AddressOf Me.OnFrameChanged))
        ImageAnimator.Animate(fire_1, New EventHandler(AddressOf Me.OnFrameChanged))
        HourPen = New Pen(Color.Red, 2)

        ''''''''''''''''''''소리
        game_snd_menu.AddSound("jump", "jump.wav")
        game_snd_menu.AddSound("collision", "collision.wav")
        game_snd_menu.AddSound("hit", "hit.wav")

    End Sub



    Private Sub ParticleUpdate()


        Dim StopCnt As Integer = 0


        For i = 0 To Particles.Count - 1
            Dim p0 = CType(Particles(i), Particle)

            If p0.Moving = True And p0.pos.Y < (Me.Height - 43) Then

                Dim isStop As Boolean = False
                For j = 0 To i - 1
                    If i <> j Then
                        Dim p1 = CType(Particles(j), Particle)

                        If p0.pos.Y < p1.pos.Y Then
                            Dim dis = Math.Sqrt(Math.Pow(p0.pos.X - p1.pos.X, 2) + Math.Pow(p0.pos.Y - p1.pos.Y, 2))

                            If dis < 2.0 Then
                                p0.Moving = False
                                isStop = True

                                Exit For
                            End If
                        End If
                    End If

                Next

                If isStop = False Then

                    p0.pos.Y = p0.pos.Y + p0.DownSpeed

                    If p0.Mov_Horizontal_Dir = 0 Then
                        p0.pos.X = p0.pos.X - 1
                    ElseIf p0.Mov_Horizontal_Dir = 2 Then
                        p0.pos.X = p0.pos.X + 1
                    End If

                    If p0.Mov_Horizontal_Cnt <= 0 Then
                        p0.Mov_Horizontal_Dir = Rand.Next(0, 7)
                        p0.Mov_Horizontal_Cnt = Rand.Next(30, 50)
                    End If

                    Particles(i) = p0
                Else
                    StopCnt += 1
                End If
            Else
                StopCnt += 1
                p0.Moving = False
            End If


        Next


        If FrameCnt Mod 3 = 0 Then
            If Particles.Count < ParticleMax Then

                Dim genCnt As Integer

                If ParticleMax > 5 Then
                    genCnt = Rand.Next(0, 5)
                Else
                    genCnt = Rand.Next(0, 4)
                End If

                If Particles.Count + genCnt > ParticleMax Then
                    genCnt = ParticleMax - Particles.Count
                End If

                For i = 1 To genCnt
                    Dim p As Particle = New Particle
                    p.pos = New Point(Rand.Next(1, Me.Width), 10)
                    p.Moving = True
                    p.Mov_Horizontal_Dir = Rand.Next(0, 7)
                    p.Mov_Horizontal_Cnt = Rand.Next(30, 50)
                    p.DownSpeed = Rand.Next(1, 3)
                    Particles.Add(p)
                Next
            End If
        End If


        If StopCnt >= ParticleMax Then
            Particles.Clear()
        End If


        FrameCnt = FrameCnt + 1


    End Sub
    Private Sub DrawCanvas(graphics As Graphics)


        For i = 0 To Particles.Count - 1
            graphics.FillEllipse(decoBrush, Particles(i).pos.X, Particles(i).pos.Y, 6, 6)

        Next
    End Sub


    Private Sub DrawStageMenu(graphics As Graphics)
        graphics.DrawImage(img_snowman, 10, 410)
        DrawCanvas(graphics)
    End Sub


    Private Sub Startform_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If stage_idx = 0 Then 'Menu
            Label1.Visible = True

            lastscore.Visible = False
            Returnmenu.Visible = False

            btn_Start.Enabled = True
            btn_Start.Visible = True

            btn_Help.Enabled = True
            btn_Help.Visible = True

            btn_Exit.Enabled = True
            btn_Exit.Visible = True

            helpbox.Visible = False
            btn_return.Enabled = False
            btn_return.Visible = False
            btn_menu_Star.Enabled = False
            btn_menu_Star.Visible = False


            e.Graphics.DrawImage(snowcity, New Rectangle(0, 0, 1000, 650))
            DrawStageMenu(e.Graphics)

        ElseIf stage_idx = 1 Then '''''''''''''''겜시작

            scorelabel.Visible = True
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True

            btn_Start.Enabled = False
            btn_Start.Visible = False

            btn_Help.Enabled = False
            btn_Help.Visible = False

            btn_Exit.Enabled = False
            btn_Exit.Visible = False

            Label1.Visible = False
            helpbox.Visible = False

            btn_Start.Enabled = False
            btn_Start.Visible = False

            btn_Help.Enabled = False
            btn_Help.Visible = False

            btn_Exit.Enabled = False
            btn_Exit.Visible = False

            btn_menu_Star.Enabled = False
            btn_menu_Star.Visible = False

            btn_return.Enabled = False
            btn_return.Visible = False


            If checktime <> Now.Second Then
                resultscore += 100
                checktime = Now.Second
            End If
            scorelabel.Text = resultscore

            DrawStageGame(e.Graphics)

        ElseIf stage_idx = 2 Then ''''''''''''''''겜종료 스코어창
            y = 450
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False


            DrawStageScore(e.Graphics)
        ElseIf stage_idx = 3 Then '''''''''''헬프창

            helpbox.Visible = True
            btn_return.Enabled = True
            btn_return.Visible = True
            btn_menu_Star.Enabled = True
            btn_menu_Star.Visible = True


            btn_Start.Visible = False
            btn_Help.Visible = False
            btn_Exit.Visible = False
            Label1.Visible = False

            e.Graphics.DrawImage(snowcity, New Rectangle(0, 0, 1000, 650))
        End If



    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        game_snd_menu.Play("click")
        start_add()
        CallbackTimer.Stop()
        start_label.Visible = True
        stage_idx = 1
    End Sub

    Private Sub btnmenuStart_Click(sender As Object, e As EventArgs) Handles btn_menu_Star.Click
        start_add()
        CallbackTimer.Stop()
        game_snd_menu.Play("click")
        start_label.Visible = True
        stage_idx = 1
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btn_Help.Click
        game_snd_menu.Play("click")

        stage_idx = 3
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        game_snd_menu.Play("click")

        stage_idx = 0
    End Sub

    Private Sub Returnmenu_Click(sender As Object, e As EventArgs) Handles Returnmenu.Click
        game_snd_menu.Play("click")
        stage_idx = 0

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        game_snd_menu.Play("click")

        Me.Close()

    End Sub

    'mainform code
    '
    '
    Private Sub start_add()

        snowgrounds_arr.Clear()
        fire_arr1.Clear()
        fire_arr2.Clear()
        fireball_arr.Clear()
        snowballs_arr.Clear()
        healpack_arr.Clear()
        hearts_arr.Clear()
        score_speed = 0
        resultscore = 0

        For i = 0 To 5000 ''''''''''''''''''''''''''''''''''장애물 추가

            add_arr(a - 100, 500, snowgrounds_arr) '''땅

            If i Mod Rand.Next(1, 20) = 0 Then ''''''''''작은거
                add_arr(300 + a + 400, 400, fire_arr1)
            End If

            If i Mod Rand.Next(7, 10) = 0 Then '''''''가시
                add_arr(300 + a + 400, 450, fire_arr2)

            End If

            If i Mod Rand.Next(5, 10) = 0 Then ''''''''파이어볼
                add_arr(800 + a, i Mod Rand.Next(1, 40) * 5 + 330, fireball_arr)
            End If

            If i Mod 200 = 0 Then ''''''''''''힐팩눈사람
                add_arr(1000 + a, 410, healpack_arr)
            End If

            a = a + 50
        Next
        a = 0


        For i = 0 To 5 '''''''''''목숨
            add_arr(20 + a, 20, hearts_arr)
            a += 30
        Next

        a = 0
        Invalidate()
    End Sub
    Private Sub GameForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown '''''''''''키저장
        Dim existed As Boolean = False

        If e.KeyCode = 38 Then '''''''''''''''''시작
            CallbackTimer.Start()
            start_label.Visible = False
        End If


        If e.KeyCode = 32 Then '''''''''''''마킹체크

            If timeronoff Then
                PictureBox1.Image = stopbutton
                CallbackTimer.Start()
            Else
                PictureBox1.Image = startbutton

                CallbackTimer.Stop()
            End If

            timeronoff = Not (timeronoff)

            Invalidate()

        End If

        For i = 0 To currentKeys.Count - 1
            If currentKeys(i).Equals(e.KeyCode) Then
                existed = True
            End If
        Next

        If Not existed Then
            If e.KeyCode = 38 Then



            End If

            If e.KeyCode = 17 Then
                Dim obj As locations = New locations
                obj.pos_x = x + 10
                obj.pos_y = y + 10
                snowballs_arr.Add(obj)
            End If

            currentKeys.Add(e.KeyCode)
        End If
    End Sub


    Private Sub GameForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        currentKeys.Remove(e.KeyCode)
    End Sub


    Private Sub OnFrameChanged(ByVal o As Object, ByVal e As EventArgs) ''''''''''''애니메이션gif
        'Force a call to the Paint event handler. 
        ''Me.Invalidate()

    End Sub
    Private Sub add_arr(x, y, arr) '''''''''''리스트추가
        Dim newobj As locations = New locations
        newobj.pos_x = x
        newobj.pos_y = y
        arr.Add(newobj)

    End Sub


    Private Sub lastheart() '''''''''''''''''''''''''마지막 하트 위치
        For i = 0 To hearts_arr.Count - 1
            Dim newheart = CType(hearts_arr(i), locations)
            lastheart_s = newheart.pos_x
        Next



    End Sub '''마지막 하트위치


    Private Sub mainjump() ''''''''''점프


        'If y < 500 - size_h Then
        'y_spe += 0.98
        ' End If
        '
        '  If y >= 500 - size_h Then
        '  y_spe = -y_spe
        '  End If
        'y += y_spe

        y_spe += 0.98

        y += y_spe
        If 500 - (y + size_h) < 1 Then
            y = 450

        End If





    End Sub

    Private Sub CheckCollision(i, arr) ''''''''''주인공-장애물충돌
        arr.RemoveAt(i)
        hearts_arr.RemoveAt(hearts_arr.Count - 1)
        game_snd_menu.Play("hit")

    End Sub

    Private Sub collision_heal(j, arr) ''''''''주인공-눈사람 충돌
        arr.RemoveAt(j)
        add_arr(lastheart_s + 30, 20, hearts_arr)
        game_snd_menu.Play("click")
        resultscore += 500
    End Sub

    Private Sub collision_snowball(j, i, arr) ''''''''''눈덩이-장애물충돌
        arr.RemoveAt(j)
        snowballs_arr.RemoveAt(i)
        resultscore += 100
    End Sub

    Private Sub collision_fire() '''''''''''''''''''움직불충돌
        Dim j As Integer = 0
        ''im i As Integer = 0

        While j < fire_arr1.Count

            Dim col_bool As Boolean = False

            Dim newfire = CType(fire_arr1(j), locations)
            rect = New Rectangle(newfire.pos_x + 35, newfire.pos_y + 60, 30, 40)

            Dim i As Integer = 0
            While i < snowballs_arr.Count ''''''''''''''''''''눈던지기충돌

                Dim obj = CType(snowballs_arr(i), locations)

                col_bool = False

                If rect.Contains(obj.pos_x + 20, obj.pos_y + 20) Then
                    col_bool = True
                    collision_snowball(j, i, fire_arr1)

                ElseIf rect.Contains(obj.pos_x, obj.pos_y) Then
                    col_bool = True
                    collision_snowball(j, i, fire_arr1)

                End If
                If col_bool = False Then
                    i += 1

                End If

            End While

            col_bool = False

            If rect.Contains(x + 5, y + 5) Then
                col_bool = True
                CheckCollision(j, fire_arr1)
            ElseIf rect.Contains(x + 45, y + 5) Then
                col_bool = True
                CheckCollision(j, fire_arr1)
            ElseIf rect.Contains(x + 5, y + 45) Then
                col_bool = True
                CheckCollision(j, fire_arr1)
            ElseIf rect.Contains(x + 45, y + 45) Then
                col_bool = True
                CheckCollision(j, fire_arr1)
            End If


            If col_bool = False Then
                j += 1

            End If
        End While



    End Sub


    Private Sub collision_fireball() '''''''''''''''''''파이어볼 충돌
        Dim j As Integer = 0
        ''im i As Integer = 0

        While j < fireball_arr.Count
            Dim col_bool As Boolean = False

            Dim newfire = CType(fireball_arr(j), locations)
            rect = New Rectangle(newfire.pos_x + 10, newfire.pos_y + 10, 30, 21)

            Dim i As Integer = 0
            While i < snowballs_arr.Count ''''''''''''''''''''눈던지기충돌

                Dim obj = CType(snowballs_arr(i), locations)

                col_bool = False

                If rect.Contains(obj.pos_x + 20, obj.pos_y + 20) Then
                    col_bool = True
                    collision_snowball(j, i, fireball_arr)

                ElseIf rect.Contains(obj.pos_x, obj.pos_y) Then
                    col_bool = True
                    collision_snowball(j, i, fireball_arr)

                End If
                If col_bool = False Then
                    i += 1

                End If

            End While

            col_bool = False

            If rect.Contains(x + 5, y + 5) Then
                col_bool = True
                CheckCollision(j, fireball_arr)
            ElseIf rect.Contains(x + 45, y + 5) Then
                col_bool = True
                CheckCollision(j, fireball_arr)
            ElseIf rect.Contains(x + 5, y + 45) Then
                col_bool = True
                CheckCollision(j, fireball_arr)
            ElseIf rect.Contains(x + 45, y + 45) Then
                col_bool = True
                CheckCollision(j, fireball_arr)
            End If

            If col_bool = False Then
                j += 1

            End If
        End While

    End Sub

    Private Sub collision_fire2() '''''''''''''''''''가시충돌

        Dim j As Integer = 0
        ''im i As Integer = 0

        While j < fire_arr2.Count

            Dim col_bool As Boolean = False

            Dim newfire = CType(fire_arr2(j), locations)
            rect = New Rectangle(newfire.pos_x + 12, newfire.pos_y + 15, 26, 35)

            If rect.Contains(x + 5, y + 5) Then
                col_bool = True
                CheckCollision(j, fire_arr2)
            ElseIf rect.Contains(x + 45, y + 5) Then
                col_bool = True
                CheckCollision(j, fire_arr2)
            ElseIf rect.Contains(x + 5, y + 45) Then
                col_bool = True
                CheckCollision(j, fire_arr2)
            ElseIf rect.Contains(x + 45, y + 45) Then
                col_bool = True
                CheckCollision(j, fire_arr2)
            End If

            If col_bool = False Then
                j += 1

            End If

        End While


    End Sub

    Private Sub collision_healpack() '''''''''''''''''''힐팩 눈사람 충돌
        Dim j As Integer = 0
        ''im i As Integer = 0

        While j < healpack_arr.Count
            Dim newheal = CType(healpack_arr(j), locations)
            rect = New Rectangle(newheal.pos_x + 30, newheal.pos_y, 40, 90)

            Dim col_bool As Boolean = False

            If rect.Contains(x + 5, y + 5) Then
                col_bool = True
                collision_heal(j, healpack_arr)
            ElseIf rect.Contains(x + 45, y + 5) Then
                col_bool = True
                collision_heal(j, healpack_arr)
            ElseIf rect.Contains(x + 5, y + 45) Then
                col_bool = True
                collision_heal(j, healpack_arr)
            ElseIf rect.Contains(x + 45, y + 45) Then
                col_bool = True
                collision_heal(j, healpack_arr)
            End If

            If col_bool = False Then
                j += 1

            End If

        End While




    End Sub

    Private Sub DrawStageGame(graphic As Graphics)
        graphic.DrawImage(bg1, New Rectangle(bg_x, 0, 1000, 600))
        If bg_x > 0 Then
            graphic.DrawImage(bg2, New Rectangle(bg_x - Me.Width, 0, 1000, 600))

        Else
            graphic.DrawImage(bg2, New Rectangle(Me.Width + bg_x, 0, 1000, 600))
        End If


        graphic.DrawImage(snowhead, x, y, size_h, size_h) ''캐릭터


        If markonoff Then
            graphic.DrawRectangle(HourPen, x + 7, y + 7, 36, 36)
        End If

        For j = 0 To snowgrounds_arr.Count - 1 ''바닥
            Dim newgro = CType(snowgrounds_arr(j), locations)
            graphic.DrawImage(snowground, New Rectangle(newgro.pos_x, newgro.pos_y, 50, 50))
        Next

        For j = 0 To 40
            graphic.DrawImage(ground, New Rectangle(j * 49, 545, 50, 50))
            graphic.DrawImage(ground, New Rectangle(j * 49, 585, 50, 50))

        Next

        For j = 0 To fire_arr1.Count - 1 ''''''''''''''''''''''''''''''움직불
            Dim newfire = CType(fire_arr1(j), locations)
            graphic.DrawImage(fire_1, New Rectangle(newfire.pos_x, newfire.pos_y, 100, 100))

            If markonoff Then
                rect = New Rectangle(newfire.pos_x + 35, newfire.pos_y + 60, 30, 40)
                graphic.DrawRectangle(HourPen, rect)
            End If

        Next

        For j = 0 To fire_arr2.Count - 1 '''''''''''''''''''''''''''가시
            Dim newfire = CType(fire_arr2(j), locations)
            graphic.DrawImage(fire_2, New Rectangle(newfire.pos_x, newfire.pos_y, 50, 50))

            If markonoff Then
                rect = New Rectangle(newfire.pos_x + 12, newfire.pos_y + 15, 26, 35)
                graphic.DrawRectangle(HourPen, rect)
            End If

        Next

        For j = 0 To fireball_arr.Count - 1 ''''''''''''''''''''''''파이어볼
            Dim newfire = CType(fireball_arr(j), locations)
            graphic.DrawImage(fireball, New Rectangle(newfire.pos_x, newfire.pos_y, 64, 40))

            If markonoff Then
                rect = New Rectangle(newfire.pos_x + 10, newfire.pos_y + 10, 30, 21)
                graphic.DrawRectangle(HourPen, rect)
            End If
        Next

        For j = 0 To healpack_arr.Count - 1 '''''''''''''''''''''''''''''''''''''''''''''''힐팩
            Dim newheal = CType(healpack_arr(j), locations)
            graphic.DrawImage(npcsnow, New Rectangle(newheal.pos_x, newheal.pos_y, 100, 100))

            If markonoff Then
                rect = New Rectangle(newheal.pos_x + 30, newheal.pos_y, 40, 90)
                graphic.DrawRectangle(HourPen, rect)
            End If

        Next

        For j = 0 To hearts_arr.Count - 1 ''''''''''''목숨 그리기

            Dim newheart = CType(hearts_arr(j), locations)
            graphic.DrawImage(heart, New Rectangle(newheart.pos_x, newheart.pos_y, 20, 20))

        Next

        For i = 0 To snowballs_arr.Count - 1 ''''''''''''눈던지기
            Dim obj = CType(snowballs_arr(i), locations)
            graphic.DrawImage(score, New Rectangle(obj.pos_x, obj.pos_y, 20, 20))
            If markonoff Then
                rect = New Rectangle(obj.pos_x, obj.pos_y - 3, 20, 28)
                graphic.DrawRectangle(HourPen, rect)
            End If

        Next




    End Sub

    Private Sub DrawStageScore(graphic As Graphics)
        graphic.DrawImage(bg1, New Rectangle(0, 0, 1000, 650))
        Returnmenu.Visible = True
        scorelabel.Visible = False
        Label1.Visible = True
        lastscore.Visible = True
        lastscore.Text = "YOUR SCORE" + vbCrLf + "      " + scorelabel.Text

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        timeronoff = Not (timeronoff)

        If timeronoff Then
            PictureBox1.Image = stopbutton
            CallbackTimer.Start()
        Else
            PictureBox1.Image = startbutton

            CallbackTimer.Stop()
        End If
        Invalidate()
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If markonoff Then
            PictureBox2.Image = markoff
        Else
            PictureBox2.Image = markon
        End If

        markonoff = Not (markonoff)
        Invalidate()
    End Sub
    Dim exit_value As DialogResult

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ''''''''''메뉴로 가기\
        CallbackTimer.Stop()
        exit_value = MessageBox.Show("메뉴로 돌아갈까요?", "ㅡㅁㅡ", MessageBoxButtons.YesNo)

        If exit_value = DialogResult.No Then
            CallbackTimer.Start()

        ElseIf exit_value = DialogResult.Yes Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            scorelabel.Visible = False
            Label1.Visible = True

            stage_idx = 0
            Invalidate()
        End If
    End Sub

    Private Sub mainform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        CallbackTimer.Stop()
        exit_value = MessageBox.Show("그만 할까요?", "ㅡㅁㅡ", MessageBoxButtons.YesNo)
        If exit_value = DialogResult.No Then
            CallbackTimer.Start()
            e.Cancel = True
        ElseIf exit_value = DialogResult.Yes Then
            e.Cancel = False
        End If
    End Sub '''''''''''''''''창 닫힐때


End Class

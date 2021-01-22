Public Class SplashScreen


    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim iCount As Integer
        For iCount = 100 To 1 Step -1
            Me.Opacity = iCount / 100
            Threading.Thread.Sleep(10)
        Next
    End Sub



    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseHover
        sender.backcolor = Color.Red
    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        sender.backcolor = Color.White
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub Button6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseHover

        sender.backcolor = Color.DeepSkyBlue
    End Sub
    Private Sub Button6_Mouseleave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave

        sender.backcolor = Color.White
    End Sub



    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Label1.Visible = False
        Label6.Visible = True
        Label5.Visible = False
        Label7.Visible = True
        Me.Text = "اللعبة"
        Button1.Text = "ابدأ اللعبة"
        Button2.Text = "مساعدة"
        Button3.Text = "جديد البرنامج"
        Button4.Text = "الإعدادات"
        Button5.Text = "حول البرنامج"
        Button6.Text = "الخروج"
        Settings.Button1.Text = "لون الخلفية"
        Settings.Button2.Text = "اللون الأول"
        Settings.Button3.Text = "اللون الثانى"
        Settings.Label4.Text = "نموذج عرض"
        Settings.Button5.Text = "لون الاختيار"
        Settings.Text = "الإعدادات"
        White.Text = "مبروك وصولك الى النهاية"
        White.Label1.Text = "إلام تريد أن تتحول"
        Black.Text = "مبروك وصولك الى النهاية"
        Black.Label1.Text = "إلام تريد أن تتحول"

        Settings.Button4.Text = "تأكيد"
        Settings.GroupBox1.Text = "الألوان"
        Settings.GroupBox2.Text = "اعدادات أخرى"
        Settings.LinkLabel1.Text = "ما هو التبييت ؟"
        Settings.CheckBox1.Text = "تفعيل خاصية التبييت"
        Settings.CheckBox2.Text = "الغاء خاصية الالزام"
        Settings.CheckBox3.Text = "تفعيل الكش"
        Settings.Label1.Text = "لا ينصح بتفعيلها لانها لم تكتمل بعد"
        Settings.Label3.Text = ""
        Settings.Label5.Text = "(عليك تحريك القطعة التى تلمسها)"
        Choose.Button1.Text = "من يبدأ ؟"
        Settings.Label2.Text = "ملحوظة : جميع هذه الاعدادات سوف تعود للوضع الافتراضى عند اغلاق اللعبة وفتحها"
    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Label1.Visible = True
        Label6.Visible = False
        Label5.Visible = True
        Label7.Visible = False
        Me.Text = "Game"
        Button1.Text = "Start Game"
        Button2.Text = "Help"
        Button3.Text = "What`s New"
        Button4.Text = "Settings"
        Button5.Text = "About"
        Button6.Text = "Exit"

        Settings.Button1.Text = "Background Color"
        Settings.Button2.Text = "1st Color"
        Settings.Button3.Text = "2nd Color"
        Settings.Label4.Text = "Display Form"
        Settings.Button5.Text = "Highlight"
        Settings.Text = "Settings"
        White.Text = "Congratulations"
        Black.Text = "Congratulations"
        White.Label1.Text = "Choose The Piece that You Want To Be"
        Black.Label1.Text = "Choose The Piece that You Want To Be"

        Settings.Button4.Text = "OK"
        Settings.GroupBox1.Text = "Colors"
        Settings.GroupBox2.Text = "Other Settings"

        Settings.LinkLabel1.Text = "What is The Castling ?"
        Settings.CheckBox1.Text = "Enable Castling"
        Settings.CheckBox2.Text = "Disable Complulsion"
        Settings.CheckBox3.Text = "Enable Check"
        Settings.Label1.Text = "Now Recommended because it hasn`t completed yet"
        Settings.Label3.Text = "(You Must Move The Piece You Touch)"
        Settings.Label5.Text = "Note : If Not Checked Then You Can Click The Right Mouse Button To Back Down"
        Settings.Label2.Text = "Note : ALL This settings will be reverted to the default next time you start the game"
        Choose.Button1.Text = "Who Starts"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "مساعدة" Then
            ArHelp.Show()
        Else
            EnHelp.Show()
        End If
    End Sub

    Private Sub Buttona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AboutBox1.Show()
    End Sub

    Public Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Settings.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Choose.Show()
        Me.Visible = False
    End Sub

    Private Sub label8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label8.MouseDown

        If e.Button = MouseButtons.Left Then

            Me.Label8.Capture = False   'change this to the control you will use to move the window

            ' Create and send a WM_NCLBUTTONDOWN message.

            Const WM_NCLBUTTONDOWN As Integer = &HA1S

            Const HTCAPTION As Integer = 2

            Dim msg As Message = _
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN,
                New IntPtr(HTCAPTION), IntPtr.Zero)

            Me.DefWndProc(msg)

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim url As String = "http://www.fb.com/ahmedshaban667"

        Process.Start(url)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim url As String = "http://www.twitter.com/ahmedshaban667"

        Process.Start(url)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If sender.text = "What`s New" Then
            Dim url As String = "http://meeeeeedo.blogspot.com.eg/2016/05/minds-conflict-chess.html"

            Process.Start(url)
        Else
            Dim url As String = "http://meeeeeedo.blogspot.com.eg/2016/05/blog-post.html"

            Process.Start(url)
        End If
    End Sub

    Sub LoadCursorFromMemory()
        Dim cur As Cursor = New Cursor(New IO.MemoryStream(My.Resources.spo730))
        If Not cur Is Nothing Then
            Me.Cursor = cur
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
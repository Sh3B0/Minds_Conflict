Public Class Settings
  
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ColorDialog1.ShowDialog()
        Game.ColorThree.BackColor = ColorDialog1.Color

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ColorDialog2.ShowDialog()
        Game.BackColor = ColorDialog2.Color
        Panel1.BackColor = ColorDialog2.Color
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ColorDialog3.ShowDialog()
        Game.ColorOne.BackColor = ColorDialog3.Color
        PictureBox1.BackColor = ColorDialog3.Color
        PictureBox3.BackColor = ColorDialog3.Color

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ColorDialog3.ShowDialog()
        Game.ColorTwo.BackColor = ColorDialog3.Color
        PictureBox2.BackColor = ColorDialog3.Color
        PictureBox4.BackColor = ColorDialog3.Color

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        My.Settings.Save()
    End Sub




    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If sender.text = "ما هو التبييت ؟" Then
            Castling.Show()
            Castling.WebBrowser1.Navigate("https://ar.wikipedia.org/wiki/%D8%AA%D8%A8%D9%8A%D9%8A%D8%AA")
        Else
            Castling.Show()

        End If
    End Sub

   
    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If sender.checked = True Then
            Game.ColorOne.BorderStyle = BorderStyle.Fixed3D
        Else
            Game.ColorOne.BorderStyle = BorderStyle.FixedSingle
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If sender.checked = True Then
            Game.ColorTwo.BorderStyle = BorderStyle.Fixed3D
        Else
            Game.ColorTwo.BorderStyle = BorderStyle.FixedSingle

        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If sender.checked = True Then
            Game.ColorThree.BorderStyle = BorderStyle.Fixed3D
        Else
            Game.ColorThree.BorderStyle = BorderStyle.FixedSingle

        End If

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CheckBox1.Checked = True Then
            Game.ColorOne.BorderStyle = BorderStyle.Fixed3D
        Else
            Game.ColorOne.BorderStyle = BorderStyle.FixedSingle
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
Public Class Black

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        sender.borderstyle = BorderStyle.Fixed3D
        Me.Finalize()
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        sender.borderstyle = BorderStyle.Fixed3D
        Me.Finalize()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        sender.borderstyle = BorderStyle.Fixed3D
        Me.Finalize()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        sender.borderstyle = BorderStyle.Fixed3D
        Me.Finalize()
    End Sub




    Private Sub Form3_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.BackColor = Game.BackColor
        PictureBox1.BackColor = Game.ColorOne.BackColor
        PictureBox3.BackColor = Game.ColorOne.BackColor
        PictureBox2.BackColor = Game.ColorTwo.BackColor
        PictureBox4.BackColor = Game.ColorTwo.BackColor

    End Sub

End Class
Public Class MainForm
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loginPanel.Visible = False
        LogoutLink.Visible = True
        UserPic.Visible = True
    End Sub

    Private Sub LogoutLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LogoutLink.LinkClicked
        loginPanel.Visible = True
        LogoutLink.Visible = False
        UserPic.Visible = False
        signUpPanel.Visible = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogoutLink.Visible = False
        signUpPanel.Visible = False
        UserPic.Visible = False
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        loginPanel.Visible = False
        signUpPanel.Visible = False
        LogoutLink.Visible = True
    End Sub

    Private Sub CreateUser_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CreateUser.LinkClicked
        signUpPanel.Visible = True
    End Sub
End Class
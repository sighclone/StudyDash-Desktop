Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.IO

Public Class settingsPage
    Private Sub DashboardQuitButton_Click(sender As Object, e As EventArgs) Handles DashboardQuitButton.Click
        Me.Close()
    End Sub

    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "uhgHYPofphdXK5p8eepWpy57qCJmWJP8lAxNv8ep",
            .BasePath = "https://stumanagehost-b6910-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    Private Sub settingsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            LoginPage.mode = "offline"
        End Try

        ActiveUserLabel.Text = LoginPage.UsernameT.Text

        setPB.Maximum = 100
        setPB.Minimum = 0
        setPB.Step = 20

    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        setPB.Show()
        setPB.PerformStep()
        If LoginPage.mode = "online" Then
            Try
                Dim getserv = client.Get("Users/" + curusrname.Text)
                Dim servusr = getserv.ResultAs(Of MyUser)
                setPB.PerformStep()
                Dim curusr As New MyUser() With
                {
                .username = curusrname.Text,
                .password = curpswd.Text
                }
                setPB.PerformStep()

                If curusr.username = servusr.username And curusr.password = servusr.password Then
                    Dim changedusr As New MyUser() With
                        {
                        .username = curusrname.Text,
                        .password = newpswd.Text
                        }
                    setPB.PerformStep()
                    Dim res = client.Get("Users/" + curusrname.Text + "/TaskList/")
                    Dim tsk As New MyUser()
                    tsk = res.ResultAs(Of MyUser)
                    Dim taskKeeper As New MyUser() With
                        {
                        .latestTask = tsk.latestTask
                        }
                    Dim changesetter = client.Set("Users/" + curusrname.Text, changedusr)
                    Dim setter = client.Update("Users/" + LoginPage.UsernameT.Text + "/" + "TaskList", taskKeeper)
                    setPB.PerformStep()
                    MessageBox.Show("Your password was successfully reset", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    setPB.Value = setPB.Minimum
                    setPB.Hide()
                End If
            Catch ex As Exception
                MessageBox.Show("Please check your internet connection and try again!", "Unable to contact server", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Using this feature requires you to have an online login, offline mode is not supported", "No active internet connection", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Offline mode is aimed at users who could be the only user of their computer and do not need online password authentication. By enabling offline mode you can use the app without connecting to the internet. However, using the app in offline mode restricts its features (such as sync between devices, etc.). Therefore, to utilise StudyDash the most, it is advised to stick with online mode. Also note that there is no password authentication needed for offline mode usage.", "StudyDash - Info about offline mode", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        setPB.Show()
        setPB.PerformStep()
        If LoginPage.mode = "online" Then
            Dim res = client.Get("Users/" + LoginPage.UsernameT.Text)
            Dim resUser = res.ResultAs(Of MyUser)
            setPB.PerformStep()
            Dim CurUser As New MyUser With
                {
                .username = LoginPage.UsernameT.Text,
                .password = LoginPage.ThisPwd
                }
            setPB.PerformStep()
            If (MyUser.IsEqual(resUser, CurUser)) Then
                Dim revoke = client.Delete("Users/" + LoginPage.UsernameT.Text + "/")
                setPB.PerformStep()
            End If
            Dim FileStream As New FileStream("C:\StudyDash\StudyDash\AdditionalFiles\SaveFile\AssignmentsList.dash", IO.FileMode.Create)
            Dim BinaryWriter As New BinaryWriter(FileStream)
            BinaryWriter.Write(CStr(""))
            BinaryWriter.Close()
            FileStream.Dispose()
            setPB.PerformStep()
            MessageBox.Show("Your account " + ActiveUserLabel.Text + " has been deleted successfully and all your data has been wiped locally and from our servers. Relaunch the app to use it", "User profile successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Error)
            setPB.Value = setPB.Minimum
            setPB.Hide()
            Application.Exit()
        Else
            MessageBox.Show("You must use your online login to delete your account.", "User logged in offline mode", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        setPB.Show()
        setPB.PerformStep()
        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890#")
        For Each c As Char In Ft.Text
            If allowed.Contains(c) = False Then
                Ft.Text = Ft.Text.Remove(Ft.SelectionStart - 1, 1)
                Ft.Select(Ft.Text.Count, 0)
                setPB.PerformStep()
            End If
        Next
        setPB.PerformStep()
        Dim feedback As New MyUser() With
            {
            .feedback = Ft.Text
            }
        Dim feedbacksetter = client.Set("Feedback/" + ActiveUserLabel.Text, feedback)

        setPB.PerformStep()
        setPB.PerformStep()
        setPB.PerformStep()
        MessageBox.Show("Suggestion successfully sent! You can send a suggestion only once per month, if you send a suggestion again, it will reset your previous suggestion", "Suggestion successfully sent - Thankyou!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        setPB.Value = setPB.Minimum
        setPB.Hide()
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        newpswd.PasswordChar = ""
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        newpswd.PasswordChar = "*"
    End Sub

End Class
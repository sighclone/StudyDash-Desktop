Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class registerForm
    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "uhgHYPofphdXK5p8eepWpy57qCJmWJP8lAxNv8ep",
            .BasePath = "https://stumanagehost-b6910-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    Private Sub registerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("Please check your internet connection and try again!", "Unable to contact server", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dashboard.TaskInputTextBox.Text = ""
    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click

        Dim allowed As String = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890#")
        For Each c As Char In reuser.Text
            If allowed.Contains(c) = False Then
                reuser.Text = reuser.Text.Remove(reuser.SelectionStart - 1, 1)
                reuser.Select(reuser.Text.Count, 0)
            End If
        Next

        For Each c As Char In repass.Text
            If allowed.Contains(c) = False Then
                repass.Text = repass.Text.Remove(repass.SelectionStart - 1, 1)
                repass.Select(repass.Text.Count, 0)
            End If
        Next

        Dim another = client.Get("Users/" + reuser.Text)
        Dim servUser = another.ResultAs(Of MyUser)

        Try
            Dim curtry As New MyUser() With
            {
            .username = reuser.Text,
            .password = repass.Text
            }
            If (servUser Is Nothing) Then
                Dim NewUser As New MyUser() With
                        {
                        .username = reuser.Text,
                        .password = repass.Text
                        }
                Dim InitialiseTaskListDir As New MyUser With
                        {
                        .latestTask = ""
                        }
                Dim UserSetter = client.Set("Users/" + reuser.Text, NewUser)
                Dim TaskListDirMaker = client.Update("Users/" + reuser.Text + "/TaskList/", InitialiseTaskListDir)
                MessageBox.Show("Registration Successful! Please restart the client.", "StudyDash - Successful registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("User already exists!", "Username clash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Please check your internet connection and try again!", "Unable to contact server", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Hover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        repass.PasswordChar = ""
    End Sub

    Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        repass.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("You can use characters that belong to a-z, A-Z, 0-9 and # only, for both the username as well as the password. If you use these characters, they will automatically be stripped", "StudyDash - registration help", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub
End Class
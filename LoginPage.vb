Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Friend Class LoginPage

    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "uhgHYPofphdXK5p8eepWpy57qCJmWJP8lAxNv8ep",
            .BasePath = "https://stumanagehost-b6910-default-rtdb.firebaseio.com/"
        }
    Private client As IFirebaseClient

    Public Property mode As String = "online"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            mode = "offline"
        End Try
    End Sub

    Public Property ThisPwd

    Friend Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        LoadingForm.Show()
        LoadingForm.LoadProgBar.Increment(5)

        If String.IsNullOrWhiteSpace(UsernameT.Text) Then
            MessageBox.Show("Please fill valid inputs in the field.")
            LoadingForm.Close()
            Return
        End If

        LoadingForm.LoadProgBar.Increment(5)

        Try
            Dim res = client.Get("Users/" + UsernameT.Text)
            Dim resUser = res.ResultAs(Of MyUser)
            LoadingForm.LoadProgBar.Increment(5)
            Dim CurUser As New MyUser With
                {
                .username = UsernameT.Text,
                .password = PasswordT.Text
                }
            LoadingForm.LoadProgBar.Increment(5)
            If (MyUser.IsEqual(resUser, CurUser)) Then
opener:
                Dim real As New Dashboard
                LoadingForm.LoadProgBar.Increment(40)
                Dim ThisUsr = UsernameT.Text
                ThisPwd = PasswordT.Text
                PasswordT.Text = ""

                LoadingForm.LoadProgBar.Increment(40)
                Me.Hide()
                LoadingForm.Close()
                real.ShowDialog()
                Me.Close()
            Else
                LoadingForm.Close()
                MessageBox.Show("Invalid username-password combination", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            mode = "offline"
            GoTo opener
        End Try
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim reg As New registerForm
        Me.Hide()
        reg.ShowDialog()
        Me.Close()
    End Sub
End Class

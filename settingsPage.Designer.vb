<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingsPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settingsPage))
        Me.DashboardQuitButton = New System.Windows.Forms.Button()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.curpswd = New System.Windows.Forms.TextBox()
        Me.newpswd = New System.Windows.Forms.TextBox()
        Me.curusrname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ActiveUserLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ft = New System.Windows.Forms.TextBox()
        Me.setPB = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'DashboardQuitButton
        '
        Me.DashboardQuitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DashboardQuitButton.FlatAppearance.BorderSize = 0
        Me.DashboardQuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardQuitButton.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DashboardQuitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DashboardQuitButton.Location = New System.Drawing.Point(12, 12)
        Me.DashboardQuitButton.Name = "DashboardQuitButton"
        Me.DashboardQuitButton.Size = New System.Drawing.Size(75, 75)
        Me.DashboardQuitButton.TabIndex = 4
        Me.DashboardQuitButton.Text = "↩"
        Me.DashboardQuitButton.UseVisualStyleBackColor = False
        '
        'resetBtn
        '
        Me.resetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.resetBtn.FlatAppearance.BorderSize = 0
        Me.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.resetBtn.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.resetBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.resetBtn.Location = New System.Drawing.Point(12, 289)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(405, 59)
        Me.resetBtn.TabIndex = 3
        Me.resetBtn.Text = "Change Password"
        Me.resetBtn.UseVisualStyleBackColor = False
        '
        'curpswd
        '
        Me.curpswd.Location = New System.Drawing.Point(12, 206)
        Me.curpswd.Name = "curpswd"
        Me.curpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.curpswd.PlaceholderText = "Enter your current password..."
        Me.curpswd.Size = New System.Drawing.Size(405, 26)
        Me.curpswd.TabIndex = 1
        '
        'newpswd
        '
        Me.newpswd.Location = New System.Drawing.Point(12, 257)
        Me.newpswd.Name = "newpswd"
        Me.newpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpswd.PlaceholderText = "Choose a strong password using a-z, A-Z, 0-9 and #..."
        Me.newpswd.Size = New System.Drawing.Size(361, 26)
        Me.newpswd.TabIndex = 2
        '
        'curusrname
        '
        Me.curusrname.Location = New System.Drawing.Point(12, 155)
        Me.curusrname.Name = "curusrname"
        Me.curusrname.PlaceholderText = "Enter your current username..."
        Me.curusrname.Size = New System.Drawing.Size(405, 26)
        Me.curusrname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Enter current username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter current password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Enter new password:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(379, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 25)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "👁"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(461, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Currently active account:"
        '
        'ActiveUserLabel
        '
        Me.ActiveUserLabel.AutoSize = True
        Me.ActiveUserLabel.Font = New System.Drawing.Font("Agency FB", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.ActiveUserLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ActiveUserLabel.Location = New System.Drawing.Point(477, 44)
        Me.ActiveUserLabel.Name = "ActiveUserLabel"
        Me.ActiveUserLabel.Size = New System.Drawing.Size(70, 34)
        Me.ActiveUserLabel.TabIndex = 16
        Me.ActiveUserLabel.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(461, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Other settings:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(436, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 341)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Enable offline access"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(461, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(367, 59)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Offline mode info"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(461, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(367, 59)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Delete my account"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(747, 289)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 27)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Send"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(461, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Send feature suggestion:"
        '
        'Ft
        '
        Me.Ft.Location = New System.Drawing.Point(461, 289)
        Me.Ft.Name = "Ft"
        Me.Ft.PlaceholderText = "Try to keep your idea under 3 words..."
        Me.Ft.Size = New System.Drawing.Size(280, 26)
        Me.Ft.TabIndex = 25
        '
        'setPB
        '
        Me.setPB.Location = New System.Drawing.Point(461, 322)
        Me.setPB.Name = "setPB"
        Me.setPB.Size = New System.Drawing.Size(367, 31)
        Me.setPB.TabIndex = 26
        Me.setPB.Visible = False
        '
        'settingsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(836, 365)
        Me.Controls.Add(Me.setPB)
        Me.Controls.Add(Me.Ft)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ActiveUserLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.curusrname)
        Me.Controls.Add(Me.newpswd)
        Me.Controls.Add(Me.curpswd)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.DashboardQuitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "settingsPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudyDash - Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DashboardQuitButton As Button
    Friend WithEvents resetBtn As Button
    Friend WithEvents curpswd As TextBox
    Friend WithEvents newpswd As TextBox
    Friend WithEvents curusrname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ActiveUserLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Ft As TextBox
    Friend WithEvents setPB As ProgressBar
End Class

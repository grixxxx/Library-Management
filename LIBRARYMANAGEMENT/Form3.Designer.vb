<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.accountname = New System.Windows.Forms.TextBox()
        Me.accountemail = New System.Windows.Forms.TextBox()
        Me.accountaddress = New System.Windows.Forms.TextBox()
        Me.accountphonenumber = New System.Windows.Forms.TextBox()
        Me.accountgendercmb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.oldpassword = New System.Windows.Forms.TextBox()
        Me.newpassword = New System.Windows.Forms.TextBox()
        Me.confirmpassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.changepasswordbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.accountusername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "General"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(650, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(648, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(648, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gender:"
        '
        'accountname
        '
        Me.accountname.Location = New System.Drawing.Point(350, 218)
        Me.accountname.Name = "accountname"
        Me.accountname.Size = New System.Drawing.Size(228, 26)
        Me.accountname.TabIndex = 7
        Me.accountname.Text = "Delmer John S. Ballesteros"
        '
        'accountemail
        '
        Me.accountemail.Location = New System.Drawing.Point(350, 296)
        Me.accountemail.Name = "accountemail"
        Me.accountemail.Size = New System.Drawing.Size(228, 26)
        Me.accountemail.TabIndex = 8
        Me.accountemail.Text = "delmerjohnb@gmail.com"
        '
        'accountaddress
        '
        Me.accountaddress.Location = New System.Drawing.Point(782, 212)
        Me.accountaddress.Name = "accountaddress"
        Me.accountaddress.Size = New System.Drawing.Size(228, 26)
        Me.accountaddress.TabIndex = 9
        Me.accountaddress.Text = "San Vicente, Ilagan City, Isabela"
        '
        'accountphonenumber
        '
        Me.accountphonenumber.Location = New System.Drawing.Point(782, 259)
        Me.accountphonenumber.Name = "accountphonenumber"
        Me.accountphonenumber.Size = New System.Drawing.Size(228, 26)
        Me.accountphonenumber.TabIndex = 10
        Me.accountphonenumber.Text = "09752777389"
        '
        'accountgendercmb
        '
        Me.accountgendercmb.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.accountgendercmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.accountgendercmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.accountgendercmb.FormattingEnabled = True
        Me.accountgendercmb.Items.AddRange(New Object() {"Male", "Female"})
        Me.accountgendercmb.Location = New System.Drawing.Point(782, 295)
        Me.accountgendercmb.Name = "accountgendercmb"
        Me.accountgendercmb.Size = New System.Drawing.Size(227, 28)
        Me.accountgendercmb.TabIndex = 11
        Me.accountgendercmb.Text = "Male"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(223, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Change Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 476)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Old Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(650, 479)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "New Password:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(650, 513)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Confirm New Password:"
        '
        'oldpassword
        '
        Me.oldpassword.Location = New System.Drawing.Point(350, 476)
        Me.oldpassword.Name = "oldpassword"
        Me.oldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpassword.Size = New System.Drawing.Size(228, 26)
        Me.oldpassword.TabIndex = 16
        Me.oldpassword.UseSystemPasswordChar = True
        '
        'newpassword
        '
        Me.newpassword.Location = New System.Drawing.Point(833, 470)
        Me.newpassword.Name = "newpassword"
        Me.newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpassword.Size = New System.Drawing.Size(178, 26)
        Me.newpassword.TabIndex = 17
        Me.newpassword.UseSystemPasswordChar = True
        '
        'confirmpassword
        '
        Me.confirmpassword.Location = New System.Drawing.Point(832, 510)
        Me.confirmpassword.Name = "confirmpassword"
        Me.confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmpassword.Size = New System.Drawing.Size(180, 26)
        Me.confirmpassword.TabIndex = 18
        Me.confirmpassword.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(822, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 36)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(921, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 36)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'changepasswordbtn
        '
        Me.changepasswordbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.changepasswordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.changepasswordbtn.Location = New System.Drawing.Point(824, 564)
        Me.changepasswordbtn.Name = "changepasswordbtn"
        Me.changepasswordbtn.Size = New System.Drawing.Size(188, 62)
        Me.changepasswordbtn.TabIndex = 21
        Me.changepasswordbtn.Text = "Change Password"
        Me.changepasswordbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Settings"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(229, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(783, 51)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(229, 403)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(783, 55)
        Me.Panel2.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(246, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Username:"
        '
        'accountusername
        '
        Me.accountusername.Location = New System.Drawing.Point(350, 256)
        Me.accountusername.Name = "accountusername"
        Me.accountusername.Size = New System.Drawing.Size(228, 26)
        Me.accountusername.TabIndex = 25
        Me.accountusername.Text = "admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._2206368
        Me.PictureBox1.Location = New System.Drawing.Point(428, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1365, 775)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.accountusername)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.changepasswordbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.confirmpassword)
        Me.Controls.Add(Me.newpassword)
        Me.Controls.Add(Me.oldpassword)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.accountgendercmb)
        Me.Controls.Add(Me.accountphonenumber)
        Me.Controls.Add(Me.accountaddress)
        Me.Controls.Add(Me.accountemail)
        Me.Controls.Add(Me.accountname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents accountname As System.Windows.Forms.TextBox
    Friend WithEvents accountemail As System.Windows.Forms.TextBox
    Friend WithEvents accountaddress As System.Windows.Forms.TextBox
    Friend WithEvents accountphonenumber As System.Windows.Forms.TextBox
    Friend WithEvents accountgendercmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents oldpassword As System.Windows.Forms.TextBox
    Friend WithEvents newpassword As System.Windows.Forms.TextBox
    Friend WithEvents confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents changepasswordbtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents accountusername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

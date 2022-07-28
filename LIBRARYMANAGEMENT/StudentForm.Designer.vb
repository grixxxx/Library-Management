<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.idnumber = New System.Windows.Forms.TextBox()
        Me.studentname = New System.Windows.Forms.TextBox()
        Me.phonenumber = New System.Windows.Forms.TextBox()
        Me.coursecmb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yrcmb = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.studentage = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.studentbirthday = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.studentsearchbutton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID number: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(513, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Number: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(513, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Course:"
        '
        'idnumber
        '
        Me.idnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idnumber.Location = New System.Drawing.Point(199, 142)
        Me.idnumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.idnumber.Name = "idnumber"
        Me.idnumber.Size = New System.Drawing.Size(258, 26)
        Me.idnumber.TabIndex = 4
        '
        'studentname
        '
        Me.studentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentname.Location = New System.Drawing.Point(199, 182)
        Me.studentname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studentname.Name = "studentname"
        Me.studentname.Size = New System.Drawing.Size(258, 26)
        Me.studentname.TabIndex = 5
        '
        'phonenumber
        '
        Me.phonenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonenumber.Location = New System.Drawing.Point(622, 138)
        Me.phonenumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.phonenumber.Name = "phonenumber"
        Me.phonenumber.Size = New System.Drawing.Size(258, 26)
        Me.phonenumber.TabIndex = 6
        '
        'coursecmb
        '
        Me.coursecmb.AutoCompleteCustomSource.AddRange(New String() {"BSCE", "BSEE", "BTLED", "BSIT", "BTVTED", "BSE", "BSIT", "BSA", "BSNursing", "Midwifery", "BSIndus"})
        Me.coursecmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.coursecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.coursecmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecmb.FormattingEnabled = True
        Me.coursecmb.Items.AddRange(New Object() {"BSCE", "BSEE", "BTLED", "BSIT", "BTVTED", "BSE", "BSIT", "BSA", "BSNursing", "Midwifery", "BSIndus"})
        Me.coursecmb.Location = New System.Drawing.Point(622, 177)
        Me.coursecmb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.coursecmb.Name = "coursecmb"
        Me.coursecmb.Size = New System.Drawing.Size(258, 28)
        Me.coursecmb.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(901, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Year Level:"
        '
        'yrcmb
        '
        Me.yrcmb.AutoCompleteCustomSource.AddRange(New String() {"1st", "2nd", "3rd", "4th", "5th"})
        Me.yrcmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.yrcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yrcmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yrcmb.FormattingEnabled = True
        Me.yrcmb.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.yrcmb.Location = New System.Drawing.Point(1010, 133)
        Me.yrcmb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.yrcmb.Name = "yrcmb"
        Me.yrcmb.Size = New System.Drawing.Size(258, 28)
        Me.yrcmb.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(465, 261)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 36)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(541, 261)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 36)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(774, 261)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 36)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(692, 261)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 36)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(146, 314)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1053, 313)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(575, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 32)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Student Registration"
        '
        'studentage
        '
        Me.studentage.AutoSize = True
        Me.studentage.Location = New System.Drawing.Point(1007, 218)
        Me.studentage.Name = "studentage"
        Me.studentage.Size = New System.Drawing.Size(16, 17)
        Me.studentage.TabIndex = 25
        Me.studentage.Text = "0"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(617, 261)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 36)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'studentbirthday
        '
        Me.studentbirthday.CustomFormat = "yyyy-MM-dd"
        Me.studentbirthday.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentbirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.studentbirthday.Location = New System.Drawing.Point(1010, 177)
        Me.studentbirthday.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studentbirthday.Name = "studentbirthday"
        Me.studentbirthday.Size = New System.Drawing.Size(258, 26)
        Me.studentbirthday.TabIndex = 23
        Me.studentbirthday.Value = New Date(2022, 7, 2, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(901, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Age:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(901, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Birthday:"
        '
        'studentsearchbutton
        '
        Me.studentsearchbutton.BackgroundImage = CType(resources.GetObject("studentsearchbutton.BackgroundImage"), System.Drawing.Image)
        Me.studentsearchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.studentsearchbutton.Location = New System.Drawing.Point(470, 142)
        Me.studentsearchbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studentsearchbutton.Name = "studentsearchbutton"
        Me.studentsearchbutton.Size = New System.Drawing.Size(27, 22)
        Me.studentsearchbutton.TabIndex = 18
        Me.studentsearchbutton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(500, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1392, 678)
        Me.Controls.Add(Me.studentage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.studentbirthday)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.phonenumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.studentsearchbutton)
        Me.Controls.Add(Me.yrcmb)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.studentname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.coursecmb)
        Me.Controls.Add(Me.idnumber)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "StudentForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents idnumber As System.Windows.Forms.TextBox
    Friend WithEvents studentname As System.Windows.Forms.TextBox
    Friend WithEvents phonenumber As System.Windows.Forms.TextBox
    Friend WithEvents coursecmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents yrcmb As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents studentsearchbutton As System.Windows.Forms.Button
    Public WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents studentbirthday As System.Windows.Forms.DateTimePicker
    Friend WithEvents studentage As Label
End Class

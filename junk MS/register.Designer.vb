<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Btn_browse = New Guna.UI.WinForms.GunaCircleButton()
        Me.Btn_back = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_name = New Guna.UI.WinForms.GunaTextBox()
        Me.txt_address = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_username = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_password = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.checkbox_showpassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.dob_picker = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Btn_register = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_contact = New Guna.UI.WinForms.GunaTextBox()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(99, 31)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(213, 25)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Create a New Account "
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(146, 63)
        Me.GunaCirclePictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(97, 84)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 4
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Btn_browse
        '
        Me.Btn_browse.Animated = True
        Me.Btn_browse.AnimationHoverSpeed = 0.07!
        Me.Btn_browse.AnimationSpeed = 0.03!
        Me.Btn_browse.BaseColor = System.Drawing.Color.DodgerBlue
        Me.Btn_browse.BorderColor = System.Drawing.Color.Black
        Me.Btn_browse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_browse.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_browse.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_browse.ForeColor = System.Drawing.Color.White
        Me.Btn_browse.Image = Nothing
        Me.Btn_browse.ImageSize = New System.Drawing.Size(52, 52)
        Me.Btn_browse.Location = New System.Drawing.Point(220, 127)
        Me.Btn_browse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_browse.Name = "Btn_browse"
        Me.Btn_browse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_browse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_browse.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_browse.OnHoverImage = Nothing
        Me.Btn_browse.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_browse.Size = New System.Drawing.Size(22, 20)
        Me.Btn_browse.TabIndex = 5
        Me.Btn_browse.Text = "+"
        '
        'Btn_back
        '
        Me.Btn_back.Animated = True
        Me.Btn_back.AnimationHoverSpeed = 0.07!
        Me.Btn_back.AnimationSpeed = 0.03!
        Me.Btn_back.BaseColor = System.Drawing.Color.DodgerBlue
        Me.Btn_back.BorderColor = System.Drawing.Color.Black
        Me.Btn_back.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_back.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_back.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_back.ForeColor = System.Drawing.Color.White
        Me.Btn_back.Image = Nothing
        Me.Btn_back.ImageSize = New System.Drawing.Size(52, 52)
        Me.Btn_back.Location = New System.Drawing.Point(42, 31)
        Me.Btn_back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_back.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_back.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_back.OnHoverImage = Nothing
        Me.Btn_back.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_back.Size = New System.Drawing.Size(22, 20)
        Me.Btn_back.TabIndex = 6
        Me.Btn_back.Text = "<"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel2.Location = New System.Drawing.Point(39, 165)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(44, 17)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "Name"
        '
        'txt_name
        '
        Me.txt_name.BaseColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_name.BorderColor = System.Drawing.Color.Silver
        Me.txt_name.BorderSize = 0
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_name.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_name.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(42, 193)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.SelectedText = ""
        Me.txt_name.Size = New System.Drawing.Size(132, 30)
        Me.txt_name.TabIndex = 10
        '
        'txt_address
        '
        Me.txt_address.BaseColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_address.BorderColor = System.Drawing.Color.Silver
        Me.txt_address.BorderSize = 0
        Me.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_address.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_address.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_address.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(224, 193)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.SelectedText = ""
        Me.txt_address.Size = New System.Drawing.Size(130, 30)
        Me.txt_address.TabIndex = 12
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel3.Location = New System.Drawing.Point(226, 165)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(57, 17)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "Address"
        '
        'txt_username
        '
        Me.txt_username.BaseColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_username.BorderColor = System.Drawing.Color.Silver
        Me.txt_username.BorderSize = 0
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_username.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(42, 256)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(132, 30)
        Me.txt_username.TabIndex = 14
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel4.Location = New System.Drawing.Point(39, 235)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(69, 17)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "Username"
        '
        'txt_password
        '
        Me.txt_password.BaseColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_password.BorderColor = System.Drawing.Color.Silver
        Me.txt_password.BorderSize = 0
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_password.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(224, 326)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(130, 30)
        Me.txt_password.TabIndex = 16
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel5.Location = New System.Drawing.Point(226, 302)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(66, 17)
        Me.GunaLabel5.TabIndex = 15
        Me.GunaLabel5.Text = "Password"
        '
        'checkbox_showpassword
        '
        Me.checkbox_showpassword.BaseColor = System.Drawing.Color.White
        Me.checkbox_showpassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.checkbox_showpassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.checkbox_showpassword.FillColor = System.Drawing.Color.White
        Me.checkbox_showpassword.Location = New System.Drawing.Point(334, 332)
        Me.checkbox_showpassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.checkbox_showpassword.Name = "checkbox_showpassword"
        Me.checkbox_showpassword.Size = New System.Drawing.Size(20, 20)
        Me.checkbox_showpassword.TabIndex = 17
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel6.Location = New System.Drawing.Point(226, 235)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(36, 17)
        Me.GunaLabel6.TabIndex = 18
        Me.GunaLabel6.Text = "DOB"
        '
        'dob_picker
        '
        Me.dob_picker.BaseColor = System.Drawing.SystemColors.ScrollBar
        Me.dob_picker.BorderColor = System.Drawing.Color.Silver
        Me.dob_picker.BorderSize = 0
        Me.dob_picker.CustomFormat = Nothing
        Me.dob_picker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dob_picker.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dob_picker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dob_picker.ForeColor = System.Drawing.Color.Black
        Me.dob_picker.Location = New System.Drawing.Point(222, 257)
        Me.dob_picker.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dob_picker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dob_picker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dob_picker.Name = "dob_picker"
        Me.dob_picker.OnHoverBaseColor = System.Drawing.Color.White
        Me.dob_picker.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dob_picker.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dob_picker.OnPressedColor = System.Drawing.Color.Black
        Me.dob_picker.Size = New System.Drawing.Size(132, 27)
        Me.dob_picker.TabIndex = 7
        Me.dob_picker.Text = "07 December 2023"
        Me.dob_picker.Value = New Date(2023, 12, 7, 14, 27, 33, 256)
        '
        'Btn_register
        '
        Me.Btn_register.Animated = True
        Me.Btn_register.AnimationHoverSpeed = 0.07!
        Me.Btn_register.AnimationSpeed = 0.03!
        Me.Btn_register.BackColor = System.Drawing.Color.Transparent
        Me.Btn_register.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_register.BorderColor = System.Drawing.Color.Black
        Me.Btn_register.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Btn_register.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btn_register.CheckedForeColor = System.Drawing.Color.White
        Me.Btn_register.CheckedImage = CType(resources.GetObject("Btn_register.CheckedImage"), System.Drawing.Image)
        Me.Btn_register.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btn_register.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_register.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_register.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_register.ForeColor = System.Drawing.Color.White
        Me.Btn_register.Image = Nothing
        Me.Btn_register.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_register.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_register.Location = New System.Drawing.Point(74, 366)
        Me.Btn_register.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_register.Name = "Btn_register"
        Me.Btn_register.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_register.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_register.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_register.OnHoverImage = Nothing
        Me.Btn_register.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_register.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_register.Radius = 20
        Me.Btn_register.Size = New System.Drawing.Size(271, 34)
        Me.Btn_register.TabIndex = 19
        Me.Btn_register.Text = "Register"
        Me.Btn_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel7.Location = New System.Drawing.Point(39, 302)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(55, 17)
        Me.GunaLabel7.TabIndex = 20
        Me.GunaLabel7.Text = "Contact"
        '
        'txt_contact
        '
        Me.txt_contact.BaseColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_contact.BorderColor = System.Drawing.Color.Silver
        Me.txt_contact.BorderSize = 0
        Me.txt_contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_contact.FocusedBaseColor = System.Drawing.Color.White
        Me.txt_contact.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_contact.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_contact.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(42, 323)
        Me.txt_contact.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_contact.SelectedText = ""
        Me.txt_contact.Size = New System.Drawing.Size(132, 30)
        Me.txt_contact.TabIndex = 21
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 412)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.Btn_register)
        Me.Controls.Add(Me.dob_picker)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.checkbox_showpassword)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Btn_back)
        Me.Controls.Add(Me.Btn_browse)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Btn_browse As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Btn_back As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_name As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txt_address As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_username As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_password As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents checkbox_showpassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dob_picker As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Btn_register As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_contact As Guna.UI.WinForms.GunaTextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Btn_browse = New Guna.UI.WinForms.GunaCircleButton()
        Me.Btn_back = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.dob_picker = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.Btn_register = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(132, 38)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(274, 32)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Create a New Account "
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(195, 78)
        Me.GunaCirclePictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(129, 103)
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
        Me.Btn_browse.Location = New System.Drawing.Point(293, 156)
        Me.Btn_browse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_browse.Name = "Btn_browse"
        Me.Btn_browse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_browse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_browse.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_browse.OnHoverImage = Nothing
        Me.Btn_browse.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_browse.Size = New System.Drawing.Size(29, 25)
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
        Me.Btn_back.Location = New System.Drawing.Point(56, 38)
        Me.Btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_back.Name = "Btn_back"
        Me.Btn_back.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_back.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_back.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_back.OnHoverImage = Nothing
        Me.Btn_back.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_back.Size = New System.Drawing.Size(29, 25)
        Me.Btn_back.TabIndex = 6
        Me.Btn_back.Text = "<"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel2.Location = New System.Drawing.Point(52, 203)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(57, 23)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "Name"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel3.Location = New System.Drawing.Point(301, 203)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(74, 23)
        Me.GunaLabel3.TabIndex = 11
        Me.GunaLabel3.Text = "Address"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel4.Location = New System.Drawing.Point(52, 289)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(89, 23)
        Me.GunaLabel4.TabIndex = 13
        Me.GunaLabel4.Text = "Username"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel5.Location = New System.Drawing.Point(301, 372)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(85, 23)
        Me.GunaLabel5.TabIndex = 15
        Me.GunaLabel5.Text = "Password"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel6.Location = New System.Drawing.Point(301, 289)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(47, 23)
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
        Me.dob_picker.Location = New System.Drawing.Point(296, 316)
        Me.dob_picker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dob_picker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dob_picker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dob_picker.Name = "dob_picker"
        Me.dob_picker.OnHoverBaseColor = System.Drawing.Color.White
        Me.dob_picker.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dob_picker.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dob_picker.OnPressedColor = System.Drawing.Color.Black
        Me.dob_picker.Size = New System.Drawing.Size(176, 33)
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
        Me.Btn_register.Location = New System.Drawing.Point(84, 471)
        Me.Btn_register.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_register.Name = "Btn_register"
        Me.Btn_register.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_register.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_register.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_register.OnHoverImage = Nothing
        Me.Btn_register.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_register.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_register.Radius = 20
        Me.Btn_register.Size = New System.Drawing.Size(361, 42)
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
        Me.GunaLabel7.Location = New System.Drawing.Point(52, 372)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(72, 23)
        Me.GunaLabel7.TabIndex = 20
        Me.GunaLabel7.Text = "Contact"
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.Location = New System.Drawing.Point(472, 415)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(20, 20)
        Me.GunaCheckBox1.TabIndex = 23
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(56, 238)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(176, 30)
        Me.txt_name.TabIndex = 24
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Location = New System.Drawing.Point(299, 238)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(176, 30)
        Me.txt_address.TabIndex = 25
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(56, 321)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(176, 30)
        Me.txt_username.TabIndex = 26
        '
        'txt_contact
        '
        Me.txt_contact.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(56, 412)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(176, 30)
        Me.txt_contact.TabIndex = 27
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(296, 410)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(176, 30)
        Me.txt_password.TabIndex = 28
        Me.txt_password.UseSystemPasswordChar = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 554)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.GunaCheckBox1)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.Btn_register)
        Me.Controls.Add(Me.dob_picker)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Btn_back)
        Me.Controls.Add(Me.Btn_browse)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dob_picker As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Btn_register As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents txt_password As TextBox
End Class

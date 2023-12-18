Imports System.Data.SqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.Btn_login = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaCircleProgressBar1 = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.Combo_username = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.GunaLabel1.Location = New System.Drawing.Point(74, 36)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(154, 32)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Login Here !"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Image = CType(resources.GetObject("GunaCirclePictureBox1.Image"), System.Drawing.Image)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(120, 77)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(123, 90)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 3
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'Btn_login
        '
        Me.Btn_login.Animated = True
        Me.Btn_login.AnimationHoverSpeed = 0.07!
        Me.Btn_login.AnimationSpeed = 0.03!
        Me.Btn_login.BackColor = System.Drawing.Color.Transparent
        Me.Btn_login.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_login.BorderColor = System.Drawing.Color.Black
        Me.Btn_login.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Btn_login.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btn_login.CheckedForeColor = System.Drawing.Color.White
        Me.Btn_login.CheckedImage = CType(resources.GetObject("Btn_login.CheckedImage"), System.Drawing.Image)
        Me.Btn_login.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btn_login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_login.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_login.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_login.ForeColor = System.Drawing.Color.White
        Me.Btn_login.Image = Nothing
        Me.Btn_login.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_login.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_login.Location = New System.Drawing.Point(120, 336)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_login.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_login.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_login.OnHoverImage = Nothing
        Me.Btn_login.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_login.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_login.Radius = 20
        Me.Btn_login.Size = New System.Drawing.Size(123, 42)
        Me.Btn_login.TabIndex = 7
        Me.Btn_login.Text = "Login"
        Me.Btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel2.Location = New System.Drawing.Point(97, 185)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(89, 23)
        Me.GunaLabel2.TabIndex = 8
        Me.GunaLabel2.Text = "Username"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.GunaLabel3.Location = New System.Drawing.Point(104, 254)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(85, 23)
        Me.GunaLabel3.TabIndex = 9
        Me.GunaLabel3.Text = "Password"
        '
        'GunaCircleProgressBar1
        '
        Me.GunaCircleProgressBar1.AnimationSpeed = 0.6!
        Me.GunaCircleProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaCircleProgressBar1.IdleColor = System.Drawing.SystemColors.ControlDark
        Me.GunaCircleProgressBar1.IdleOffset = 20
        Me.GunaCircleProgressBar1.Image = Nothing
        Me.GunaCircleProgressBar1.ImageSize = New System.Drawing.Size(52, 52)
        Me.GunaCircleProgressBar1.Location = New System.Drawing.Point(344, 60)
        Me.GunaCircleProgressBar1.Name = "GunaCircleProgressBar1"
        Me.GunaCircleProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCircleProgressBar1.ProgressOffset = 20
        Me.GunaCircleProgressBar1.Size = New System.Drawing.Size(130, 138)
        Me.GunaCircleProgressBar1.TabIndex = 10
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.Red
        Me.lblExit.Location = New System.Drawing.Point(377, 4)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(31, 29)
        Me.lblExit.TabIndex = 26
        Me.lblExit.Text = "X"
        '
        'Combo_username
        '
        Me.Combo_username.BackColor = System.Drawing.SystemColors.Menu
        Me.Combo_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_username.FormattingEnabled = True
        Me.Combo_username.Location = New System.Drawing.Point(100, 212)
        Me.Combo_username.Name = "Combo_username"
        Me.Combo_username.Size = New System.Drawing.Size(158, 28)
        Me.Combo_username.TabIndex = 30
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(264, 293)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(101, 286)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(157, 27)
        Me.txt_password.TabIndex = 33
        Me.txt_password.UseSystemPasswordChar = True
        '
        'login
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Combo_username)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.GunaCircleProgressBar1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents Btn_login As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaCircleProgressBar1 As Guna.UI.WinForms.GunaCircleProgressBar





    Dim connection As New SqlConnection("Server=AMIT\SQLEXPRESS; Database=Project_JMS; Integrated Security=true")
    Dim dr As SqlDataReader

    'Private Sub login_load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    usercomboload()
    '    ' You can add any initialization code here if needed
    'End Sub

    Public Sub usercomboload()
        usercomboload(connection)
    End Sub

    Sub usercomboload(connection As SqlConnection)
        Try
            connection.Open()
            Combo_username.Items.Clear()

            ' Assuming your table is named "login" and has the username in the second column (index 1)
            Dim cmd As New SqlCommand("SELECT * FROM login", connection)
            dr = cmd.ExecuteReader

            While dr.Read
                ' Assuming username is in the second column (index 1)
                Combo_username.Items.Add(dr.GetString(0))
            End While
        Catch ex As Exception
            ' Handle exceptions (display an error message, log the error, etc.)
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Dim username As String = Combo_username.Text
        Dim password As String = txt_password.Text

        Try
            connection.Open()

            ' Debugging statement
            Console.WriteLine("Checking authentication for Username: " & username)

            ' Assuming your table is named "login" and has columns "Username" and "Password"
            Dim query As String = "SELECT COUNT(*) FROM login WHERE Username=@Username AND Password=@Password"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                ' ExecuteScalar returns the number of rows that match the query
                Dim count As Integer = CInt(command.ExecuteScalar())

                ' Debugging statement
                Console.WriteLine("Rows found: " & count)

                ' If count is 1, the user is authenticated
                If count = 1 Then
                    ' MessageBox.Show("Authentication successful!")
                    Me.Hide()
                    Dim home As New home()
                    home.Show()
                Else
                    MessageBox.Show("Authentication failed. Invalid username or password.")
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions (display an error message, log the error, etc.)
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Friend WithEvents lblExit As Label

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub
    Friend WithEvents Combo_username As ComboBox
    Friend WithEvents CheckBox1 As CheckBox

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.UseSystemPasswordChar = False
        Else
            txt_password.UseSystemPasswordChar = True
        End If
    End Sub

    Friend WithEvents txt_password As TextBox
End Class

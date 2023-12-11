<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Btn_about = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.lblExit)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaPanel2)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaPanel1)
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.SteelBlue
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(1504, 832)
        Me.GunaGradient2Panel1.TabIndex = 0
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.Color.Red
        Me.lblExit.Location = New System.Drawing.Point(1468, 2)
        Me.lblExit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(31, 29)
        Me.lblExit.TabIndex = 27
        Me.lblExit.Text = "X"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(335, 775)
        Me.GunaPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1169, 57)
        Me.GunaPanel2.TabIndex = 1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GunaPanel1.Controls.Add(Me.Btn_about)
        Me.GunaPanel1.Controls.Add(Me.Panel2)
        Me.GunaPanel1.Controls.Add(Me.Panel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(335, 832)
        Me.GunaPanel1.TabIndex = 0
        '
        'Btn_about
        '
        Me.Btn_about.Animated = True
        Me.Btn_about.AnimationHoverSpeed = 0.07!
        Me.Btn_about.AnimationSpeed = 0.03!
        Me.Btn_about.BackColor = System.Drawing.Color.Transparent
        Me.Btn_about.BaseColor = System.Drawing.Color.Transparent
        Me.Btn_about.BorderColor = System.Drawing.Color.Black
        Me.Btn_about.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Btn_about.CheckedBorderColor = System.Drawing.Color.Black
        Me.Btn_about.CheckedForeColor = System.Drawing.Color.White
        Me.Btn_about.CheckedImage = CType(resources.GetObject("Btn_about.CheckedImage"), System.Drawing.Image)
        Me.Btn_about.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Btn_about.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_about.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_about.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_about.ForeColor = System.Drawing.Color.Black
        Me.Btn_about.Image = Nothing
        Me.Btn_about.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_about.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_about.Location = New System.Drawing.Point(44, 273)
        Me.Btn_about.Name = "Btn_about"
        Me.Btn_about.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_about.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_about.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_about.OnHoverImage = Nothing
        Me.Btn_about.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Btn_about.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_about.Radius = 20
        Me.Btn_about.Size = New System.Drawing.Size(123, 42)
        Me.Btn_about.TabIndex = 8
        Me.Btn_about.Text = "About"
        Me.Btn_about.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btnmenu)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(335, 80)
        Me.Panel2.TabIndex = 3
        '
        'btnmenu
        '
        Me.btnmenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmenu.BackgroundImage = Global.junk_MS.My.Resources.Resources.icons8_menu_64
        Me.btnmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmenu.Location = New System.Drawing.Point(261, 0)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Size = New System.Drawing.Size(75, 80)
        Me.btnmenu.TabIndex = 0
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 79)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 136)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Tag = "imagepanel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE
        Me.GunaAnimateWindow1.Interval = 100
        Me.GunaAnimateWindow1.TargetControl = Nothing
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1504, 832)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblExit As Label
    Friend WithEvents btnmenu As Button
    Friend WithEvents Btn_about As Guna.UI.WinForms.GunaAdvenceButton
End Class

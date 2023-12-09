<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startup
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
        Me.components = New System.ComponentModel.Container()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.progressbar = New Guna.UI.WinForms.GunaCircleProgressBar()
        Me.percentagelbl = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.progressbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLabel3)
        Me.GunaGradient2Panel1.Controls.Add(Me.progressbar)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.DodgerBlue
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Cyan
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(800, 450)
        Me.GunaGradient2Panel1.TabIndex = 0
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(332, 333)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(152, 40)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Loading..."
        '
        'progressbar
        '
        Me.progressbar.AnimationSpeed = 0.6!
        Me.progressbar.BaseColor = System.Drawing.Color.Transparent
        Me.progressbar.Controls.Add(Me.percentagelbl)
        Me.progressbar.IdleColor = System.Drawing.Color.Transparent
        Me.progressbar.IdleOffset = 20
        Me.progressbar.IdleThickness = 15
        Me.progressbar.Image = Nothing
        Me.progressbar.ImageSize = New System.Drawing.Size(52, 52)
        Me.progressbar.Location = New System.Drawing.Point(303, 157)
        Me.progressbar.Name = "progressbar"
        Me.progressbar.ProgressMaxColor = System.Drawing.Color.DodgerBlue
        Me.progressbar.ProgressMinColor = System.Drawing.Color.Cyan
        Me.progressbar.ProgressOffset = 20
        Me.progressbar.Size = New System.Drawing.Size(174, 154)
        Me.progressbar.TabIndex = 4
        '
        'percentagelbl
        '
        Me.percentagelbl.AutoSize = True
        Me.percentagelbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentagelbl.ForeColor = System.Drawing.Color.White
        Me.percentagelbl.Location = New System.Drawing.Point(67, 58)
        Me.percentagelbl.Name = "percentagelbl"
        Me.percentagelbl.Size = New System.Drawing.Size(35, 32)
        Me.percentagelbl.TabIndex = 0
        Me.percentagelbl.Text = "%"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(166, 59)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(442, 40)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Junkyard Management System"
        '
        'Timer1
        '
        '
        'startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "startup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "startup"
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        Me.progressbar.ResumeLayout(False)
        Me.progressbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents progressbar As Guna.UI.WinForms.GunaCircleProgressBar
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents percentagelbl As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
End Class

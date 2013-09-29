<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCarcols = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScrBlue = New System.Windows.Forms.HScrollBar()
        Me.ScrGreen = New System.Windows.Forms.HScrollBar()
        Me.ScrRed = New System.Windows.Forms.HScrollBar()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(329, 188)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(79, 36)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Exit"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCarcols)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ScrBlue)
        Me.GroupBox1.Controls.Add(Me.ScrGreen)
        Me.GroupBox1.Controls.Add(Me.ScrRed)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 170)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colour Picker"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(317, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 86)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Blue"
        '
        'TxtCarcols
        '
        Me.TxtCarcols.Location = New System.Drawing.Point(18, 131)
        Me.TxtCarcols.Name = "TxtCarcols"
        Me.TxtCarcols.ReadOnly = True
        Me.TxtCarcols.Size = New System.Drawing.Size(366, 20)
        Me.TxtCarcols.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Green"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Red"
        '
        'ScrBlue
        '
        Me.ScrBlue.LargeChange = 1
        Me.ScrBlue.Location = New System.Drawing.Point(61, 99)
        Me.ScrBlue.Maximum = 255
        Me.ScrBlue.Name = "ScrBlue"
        Me.ScrBlue.Size = New System.Drawing.Size(236, 17)
        Me.ScrBlue.TabIndex = 10
        '
        'ScrGreen
        '
        Me.ScrGreen.LargeChange = 1
        Me.ScrGreen.Location = New System.Drawing.Point(61, 64)
        Me.ScrGreen.Maximum = 255
        Me.ScrGreen.Name = "ScrGreen"
        Me.ScrGreen.Size = New System.Drawing.Size(236, 17)
        Me.ScrGreen.TabIndex = 9
        '
        'ScrRed
        '
        Me.ScrRed.LargeChange = 1
        Me.ScrRed.Location = New System.Drawing.Point(61, 30)
        Me.ScrRed.Maximum = 255
        Me.ScrRed.Name = "ScrRed"
        Me.ScrRed.Size = New System.Drawing.Size(236, 17)
        Me.ScrRed.TabIndex = 8
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(244, 188)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(79, 36)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "About..."
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 238)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Carcols Tool .NET v0.1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCarcols As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ScrBlue As System.Windows.Forms.HScrollBar
    Friend WithEvents ScrGreen As System.Windows.Forms.HScrollBar
    Friend WithEvents ScrRed As System.Windows.Forms.HScrollBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button

End Class

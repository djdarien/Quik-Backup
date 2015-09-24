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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSource = New System.Windows.Forms.Button()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.btnBackupNow = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radUSB = New System.Windows.Forms.RadioButton()
        Me.radServer = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(229, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSource
        '
        Me.btnSource.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSource.Location = New System.Drawing.Point(12, 13)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(75, 23)
        Me.btnSource.TabIndex = 1
        Me.btnSource.Text = "Source:"
        Me.btnSource.UseVisualStyleBackColor = True
        '
        'txtSource
        '
        Me.txtSource.Location = New System.Drawing.Point(13, 42)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(194, 20)
        Me.txtSource.TabIndex = 2
        '
        'btnBackupNow
        '
        Me.btnBackupNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupNow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackupNow.Location = New System.Drawing.Point(229, 99)
        Me.btnBackupNow.Name = "btnBackupNow"
        Me.btnBackupNow.Size = New System.Drawing.Size(89, 49)
        Me.btnBackupNow.TabIndex = 3
        Me.btnBackupNow.Text = "Backup Now!"
        Me.btnBackupNow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(106, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Location of your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "USB/Flash Drive"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Quik_Backup.My.Resources.Resources.info
        Me.PictureBox2.Location = New System.Drawing.Point(12, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quik_Backup.My.Resources.Resources.Backup_center_icon
        Me.PictureBox1.Location = New System.Drawing.Point(56, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radUSB)
        Me.GroupBox1.Controls.Add(Me.radServer)
        Me.GroupBox1.Location = New System.Drawing.Point(229, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(89, 80)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup Style"
        '
        'radUSB
        '
        Me.radUSB.AutoSize = True
        Me.radUSB.Location = New System.Drawing.Point(6, 46)
        Me.radUSB.Name = "radUSB"
        Me.radUSB.Size = New System.Drawing.Size(63, 17)
        Me.radUSB.TabIndex = 0
        Me.radUSB.Text = "To USB"
        Me.radUSB.UseVisualStyleBackColor = True
        '
        'radServer
        '
        Me.radServer.AutoSize = True
        Me.radServer.Checked = True
        Me.radServer.Location = New System.Drawing.Point(6, 23)
        Me.radServer.Name = "radServer"
        Me.radServer.Size = New System.Drawing.Size(72, 17)
        Me.radServer.TabIndex = 0
        Me.radServer.TabStop = True
        Me.radServer.Text = "To Server"
        Me.radServer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnBackupNow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(326, 190)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBackupNow)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.btnSource)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quik Backup"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnSource As System.Windows.Forms.Button
    Friend WithEvents txtSource As System.Windows.Forms.TextBox
    Friend WithEvents btnBackupNow As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radUSB As System.Windows.Forms.RadioButton
    Friend WithEvents radServer As System.Windows.Forms.RadioButton
End Class

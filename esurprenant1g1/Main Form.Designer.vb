<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.lbltest1 = New System.Windows.Forms.Label()
        Me.lbltest2 = New System.Windows.Forms.Label()
        Me.lbltest3 = New System.Windows.Forms.Label()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.txttest1 = New System.Windows.Forms.TextBox()
        Me.txttest2 = New System.Windows.Forms.TextBox()
        Me.txttest3 = New System.Windows.Forms.TextBox()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lbltestaverage = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltest1
        '
        Me.lbltest1.AutoSize = True
        Me.lbltest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltest1.Location = New System.Drawing.Point(25, 80)
        Me.lbltest1.Name = "lbltest1"
        Me.lbltest1.Size = New System.Drawing.Size(66, 24)
        Me.lbltest1.TabIndex = 0
        Me.lbltest1.Text = "Test &1:"
        '
        'lbltest2
        '
        Me.lbltest2.AutoSize = True
        Me.lbltest2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltest2.Location = New System.Drawing.Point(25, 130)
        Me.lbltest2.Name = "lbltest2"
        Me.lbltest2.Size = New System.Drawing.Size(66, 24)
        Me.lbltest2.TabIndex = 2
        Me.lbltest2.Text = "Test &2:"
        '
        'lbltest3
        '
        Me.lbltest3.AutoSize = True
        Me.lbltest3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltest3.Location = New System.Drawing.Point(25, 180)
        Me.lbltest3.Name = "lbltest3"
        Me.lbltest3.Size = New System.Drawing.Size(66, 24)
        Me.lbltest3.TabIndex = 4
        Me.lbltest3.Text = "Test &3:"
        '
        'lblscore
        '
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.Location = New System.Drawing.Point(93, 11)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(76, 57)
        Me.lblscore.TabIndex = 10
        Me.lblscore.Text = "Test Score"
        Me.lblscore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txttest1
        '
        Me.txttest1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttest1.Location = New System.Drawing.Point(97, 71)
        Me.txttest1.Name = "txttest1"
        Me.txttest1.Size = New System.Drawing.Size(70, 33)
        Me.txttest1.TabIndex = 1
        '
        'txttest2
        '
        Me.txttest2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttest2.Location = New System.Drawing.Point(97, 126)
        Me.txttest2.Name = "txttest2"
        Me.txttest2.Size = New System.Drawing.Size(70, 33)
        Me.txttest2.TabIndex = 3
        '
        'txttest3
        '
        Me.txttest3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttest3.Location = New System.Drawing.Point(97, 176)
        Me.txttest3.Name = "txttest3"
        Me.txttest3.Size = New System.Drawing.Size(70, 33)
        Me.txttest3.TabIndex = 5
        '
        'lblaverage
        '
        Me.lblaverage.AutoSize = True
        Me.lblaverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaverage.Location = New System.Drawing.Point(200, 180)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(127, 24)
        Me.lblaverage.TabIndex = 11
        Me.lblaverage.Text = "Test Average:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btncalc
        '
        Me.btncalc.AutoSize = True
        Me.btncalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalc.Location = New System.Drawing.Point(29, 230)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(83, 31)
        Me.btncalc.TabIndex = 6
        Me.btncalc.Text = "&Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.AutoSize = True
        Me.btnprint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(130, 230)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(83, 31)
        Me.btnprint.TabIndex = 7
        Me.btnprint.Text = "&Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.AutoSize = True
        Me.btnclear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(231, 230)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(83, 31)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "C&lear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(332, 230)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(83, 31)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "&Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lbltestaverage
        '
        Me.lbltestaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltestaverage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltestaverage.Location = New System.Drawing.Point(332, 176)
        Me.lbltestaverage.Name = "lbltestaverage"
        Me.lbltestaverage.Size = New System.Drawing.Size(70, 33)
        Me.lbltestaverage.TabIndex = 12
        Me.lbltestaverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 298)
        Me.Controls.Add(Me.lbltestaverage)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblaverage)
        Me.Controls.Add(Me.txttest3)
        Me.Controls.Add(Me.txttest2)
        Me.Controls.Add(Me.txttest1)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.lbltest3)
        Me.Controls.Add(Me.lbltest2)
        Me.Controls.Add(Me.lbltest1)
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Solution"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltest1 As Label
    Friend WithEvents lbltest2 As Label
    Friend WithEvents lbltest3 As Label
    Friend WithEvents lblscore As Label
    Friend WithEvents txttest1 As TextBox
    Friend WithEvents txttest2 As TextBox
    Friend WithEvents txttest3 As TextBox
    Friend WithEvents lblaverage As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btncalc As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lbltestaverage As Label
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lblProjincrease = New System.Windows.Forms.Label()
        Me.lblStraw = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblRasp = New System.Windows.Forms.Label()
        Me.lblCurSales = New System.Windows.Forms.Label()
        Me.lblProjSales = New System.Windows.Forms.Label()
        Me.txtStraw = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtRas = New System.Windows.Forms.TextBox()
        Me.lblProjStraw = New System.Windows.Forms.Label()
        Me.lblProjBlue = New System.Windows.Forms.Label()
        Me.lblProjRas = New System.Windows.Forms.Label()
        Me.txtProjIncrease = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRetirement = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProjincrease
        '
        Me.lblProjincrease.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjincrease.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblProjincrease.Location = New System.Drawing.Point(150, 11)
        Me.lblProjincrease.Name = "lblProjincrease"
        Me.lblProjincrease.Size = New System.Drawing.Size(152, 56)
        Me.lblProjincrease.TabIndex = 0
        Me.lblProjincrease.Text = "Projected &increase % (in decimal form):"
        '
        'lblStraw
        '
        Me.lblStraw.AutoSize = True
        Me.lblStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStraw.Location = New System.Drawing.Point(43, 108)
        Me.lblStraw.Name = "lblStraw"
        Me.lblStraw.Size = New System.Drawing.Size(101, 21)
        Me.lblStraw.TabIndex = 3
        Me.lblStraw.Text = "&Strawberries:"
        Me.lblStraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.Location = New System.Drawing.Point(53, 160)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(91, 21)
        Me.lblBlue.TabIndex = 5
        Me.lblBlue.Text = "&Blueberries:"
        Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRasp
        '
        Me.lblRasp.AutoSize = True
        Me.lblRasp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRasp.Location = New System.Drawing.Point(49, 212)
        Me.lblRasp.Name = "lblRasp"
        Me.lblRasp.Size = New System.Drawing.Size(95, 21)
        Me.lblRasp.TabIndex = 7
        Me.lblRasp.Text = "&Respberries:"
        Me.lblRasp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurSales
        '
        Me.lblCurSales.AutoSize = True
        Me.lblCurSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurSales.Location = New System.Drawing.Point(150, 67)
        Me.lblCurSales.Name = "lblCurSales"
        Me.lblCurSales.Size = New System.Drawing.Size(103, 21)
        Me.lblCurSales.TabIndex = 2
        Me.lblCurSales.Text = "Current Sales"
        Me.lblCurSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProjSales
        '
        Me.lblProjSales.AutoSize = True
        Me.lblProjSales.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjSales.Location = New System.Drawing.Point(288, 67)
        Me.lblProjSales.Name = "lblProjSales"
        Me.lblProjSales.Size = New System.Drawing.Size(115, 21)
        Me.lblProjSales.TabIndex = 12
        Me.lblProjSales.Text = "Projected Sales"
        Me.lblProjSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStraw
        '
        Me.txtStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStraw.Location = New System.Drawing.Point(154, 105)
        Me.txtStraw.Name = "txtStraw"
        Me.txtStraw.Size = New System.Drawing.Size(100, 29)
        Me.txtStraw.TabIndex = 4
        Me.txtStraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBlue
        '
        Me.txtBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlue.Location = New System.Drawing.Point(154, 157)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(100, 29)
        Me.txtBlue.TabIndex = 6
        Me.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRas
        '
        Me.txtRas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRas.Location = New System.Drawing.Point(154, 209)
        Me.txtRas.Name = "txtRas"
        Me.txtRas.Size = New System.Drawing.Size(100, 29)
        Me.txtRas.TabIndex = 8
        Me.txtRas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblProjStraw
        '
        Me.lblProjStraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjStraw.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjStraw.Location = New System.Drawing.Point(292, 104)
        Me.lblProjStraw.Name = "lblProjStraw"
        Me.lblProjStraw.Size = New System.Drawing.Size(100, 29)
        Me.lblProjStraw.TabIndex = 13
        Me.lblProjStraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjBlue
        '
        Me.lblProjBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjBlue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjBlue.Location = New System.Drawing.Point(292, 156)
        Me.lblProjBlue.Name = "lblProjBlue"
        Me.lblProjBlue.Size = New System.Drawing.Size(100, 29)
        Me.lblProjBlue.TabIndex = 14
        Me.lblProjBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjRas
        '
        Me.lblProjRas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjRas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjRas.Location = New System.Drawing.Point(292, 208)
        Me.lblProjRas.Name = "lblProjRas"
        Me.lblProjRas.Size = New System.Drawing.Size(100, 29)
        Me.lblProjRas.TabIndex = 15
        Me.lblProjRas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjIncrease
        '
        Me.txtProjIncrease.Location = New System.Drawing.Point(308, 34)
        Me.txtProjIncrease.Name = "txtProjIncrease"
        Me.txtProjIncrease.Size = New System.Drawing.Size(67, 20)
        Me.txtProjIncrease.TabIndex = 1
        Me.txtProjIncrease.Text = "0.05"
        Me.txtProjIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalc
        '
        Me.btnCalc.AutoSize = True
        Me.btnCalc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(12, 260)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(83, 31)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(265, 260)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(357, 260)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnRetirement
        '
        Me.btnRetirement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetirement.Location = New System.Drawing.Point(111, 260)
        Me.btnRetirement.Name = "btnRetirement"
        Me.btnRetirement.Size = New System.Drawing.Size(142, 30)
        Me.btnRetirement.TabIndex = 19
        Me.btnRetirement.Text = "Retirement Form"
        Me.btnRetirement.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 325)
        Me.Controls.Add(Me.btnRetirement)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtProjIncrease)
        Me.Controls.Add(Me.lblProjRas)
        Me.Controls.Add(Me.lblProjBlue)
        Me.Controls.Add(Me.lblProjStraw)
        Me.Controls.Add(Me.txtRas)
        Me.Controls.Add(Me.txtBlue)
        Me.Controls.Add(Me.txtStraw)
        Me.Controls.Add(Me.lblProjSales)
        Me.Controls.Add(Me.lblCurSales)
        Me.Controls.Add(Me.lblRasp)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblStraw)
        Me.Controls.Add(Me.lblProjincrease)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cranston Berries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProjincrease As Label
    Friend WithEvents lblStraw As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblRasp As Label
    Friend WithEvents lblCurSales As Label
    Friend WithEvents lblProjSales As Label
    Friend WithEvents txtStraw As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtRas As TextBox
    Friend WithEvents lblProjStraw As Label
    Friend WithEvents lblProjBlue As Label
    Friend WithEvents lblProjRas As Label
    Friend WithEvents txtProjIncrease As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRetirement As Button
End Class

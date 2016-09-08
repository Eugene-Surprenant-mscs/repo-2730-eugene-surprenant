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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblFWT = New System.Windows.Forms.Label()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblgrosspay = New System.Windows.Forms.Label()
        Me.lblfedwith = New System.Windows.Forms.Label()
        Me.lblSocSecTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(203, 74)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "&Name:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(495, 74)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(55, 21)
        Me.lblHours.TabIndex = 1
        Me.lblHours.Text = "&Hours:"
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Location = New System.Drawing.Point(591, 74)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(73, 21)
        Me.lblPay.TabIndex = 2
        Me.lblPay.Text = "Pay &Rate:"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Location = New System.Drawing.Point(48, 160)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(53, 21)
        Me.lblGross.TabIndex = 9
        Me.lblGross.Text = "Gross:"
        '
        'lblFWT
        '
        Me.lblFWT.AutoSize = True
        Me.lblFWT.Location = New System.Drawing.Point(183, 160)
        Me.lblFWT.Name = "lblFWT"
        Me.lblFWT.Size = New System.Drawing.Size(44, 21)
        Me.lblFWT.TabIndex = 10
        Me.lblFWT.Text = "FWT:"
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Location = New System.Drawing.Point(318, 160)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(45, 21)
        Me.lblFICA.TabIndex = 11
        Me.lblFICA.Text = "FICA:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(453, 160)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(48, 21)
        Me.lblState.TabIndex = 12
        Me.lblState.Text = "State:"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(588, 160)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(38, 21)
        Me.lblNet.TabIndex = 13
        Me.lblNet.Text = "Net:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(206, 110)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 29)
        Me.txtName.TabIndex = 3
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(499, 110)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(70, 29)
        Me.txtHours.TabIndex = 4
        Me.txtHours.Text = "0.00"
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(595, 110)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(70, 29)
        Me.txtPay.TabIndex = 5
        Me.txtPay.Text = "0.00"
        '
        'btnCalc
        '
        Me.btnCalc.AutoSize = True
        Me.btnCalc.Location = New System.Drawing.Point(207, 256)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(83, 31)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(332, 256)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(457, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 31)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblgrosspay
        '
        Me.lblgrosspay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblgrosspay.Location = New System.Drawing.Point(52, 192)
        Me.lblgrosspay.Name = "lblgrosspay"
        Me.lblgrosspay.Size = New System.Drawing.Size(95, 29)
        Me.lblgrosspay.TabIndex = 14
        '
        'lblfedwith
        '
        Me.lblfedwith.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfedwith.Location = New System.Drawing.Point(187, 192)
        Me.lblfedwith.Name = "lblfedwith"
        Me.lblfedwith.Size = New System.Drawing.Size(95, 29)
        Me.lblfedwith.TabIndex = 15
        '
        'lblSocSecTax
        '
        Me.lblSocSecTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSocSecTax.Location = New System.Drawing.Point(322, 192)
        Me.lblSocSecTax.Name = "lblSocSecTax"
        Me.lblSocSecTax.Size = New System.Drawing.Size(95, 29)
        Me.lblSocSecTax.TabIndex = 16
        '
        'lblStateTax
        '
        Me.lblStateTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStateTax.Location = New System.Drawing.Point(455, 192)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(95, 29)
        Me.lblStateTax.TabIndex = 17
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNetPay.Location = New System.Drawing.Point(592, 192)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(95, 29)
        Me.lblNetPay.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 310)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblSocSecTax)
        Me.Controls.Add(Me.lblfedwith)
        Me.Controls.Add(Me.lblgrosspay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.lblFWT)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "esurprenant1h1:Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents lblFWT As Label
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtPay As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblgrosspay As Label
    Friend WithEvents lblfedwith As Label
    Friend WithEvents lblSocSecTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

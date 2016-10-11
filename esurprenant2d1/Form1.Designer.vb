<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotient
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
        Me.txtDollar = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.txtPriceperpound = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncalculate1 = New System.Windows.Forms.Button()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnCalculate2 = New System.Windows.Forms.Button()
        Me.lblMonthlyBill = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.First = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btncalculate3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDollar
        '
        Me.txtDollar.Location = New System.Drawing.Point(17, 56)
        Me.txtDollar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDollar.Name = "txtDollar"
        Me.txtDollar.Size = New System.Drawing.Size(123, 29)
        Me.txtDollar.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 25)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(123, 21)
        Me.label1.TabIndex = 1
        Me.label1.Text = "American dollar:"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(156, 22)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(109, 34)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert ="
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Convert <>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(312, 25)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 21)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Euro:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(450, 25)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 21)
        Me.label3.TabIndex = 8
        Me.label3.Text = "British Pound:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(572, 25)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(151, 21)
        Me.label4.TabIndex = 9
        Me.label4.Text = "South African  Rand:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnConvert)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.txtDollar)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 126)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p231 #1 Currency Converter"
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(13, 51)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(100, 29)
        Me.txtPounds.TabIndex = 11
        '
        'txtPriceperpound
        '
        Me.txtPriceperpound.Location = New System.Drawing.Point(152, 51)
        Me.txtPriceperpound.Name = "txtPriceperpound"
        Me.txtPriceperpound.Size = New System.Drawing.Size(100, 29)
        Me.txtPriceperpound.TabIndex = 12
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(13, 27)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(65, 21)
        Me.label5.TabIndex = 13
        Me.label5.Text = "Pounds:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Price/lb:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.btncalculate1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.label5)
        Me.GroupBox2.Controls.Add(Me.txtPriceperpound)
        Me.GroupBox2.Controls.Add(Me.txtPounds)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(731, 92)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p231 #3 Tea Time"
        '
        'btncalculate1
        '
        Me.btncalculate1.Location = New System.Drawing.Point(282, 51)
        Me.btncalculate1.Name = "btncalculate1"
        Me.btncalculate1.Size = New System.Drawing.Size(82, 28)
        Me.btncalculate1.TabIndex = 15
        Me.btncalculate1.Text = "calculate"
        Me.btncalculate1.UseVisualStyleBackColor = True
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(316, 56)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(113, 29)
        Me.lblEuro.TabIndex = 10
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(454, 56)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(113, 29)
        Me.lblPound.TabIndex = 11
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(576, 56)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(113, 29)
        Me.lblRand.TabIndex = 12
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(397, 50)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(113, 29)
        Me.lblTotalDue.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total due:"
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(8, 57)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(100, 29)
        Me.txtPrevious.TabIndex = 16
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(147, 57)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 29)
        Me.txtCurrent.TabIndex = 17
        '
        'btnCalculate2
        '
        Me.btnCalculate2.Location = New System.Drawing.Point(277, 56)
        Me.btnCalculate2.Name = "btnCalculate2"
        Me.btnCalculate2.Size = New System.Drawing.Size(82, 28)
        Me.btnCalculate2.TabIndex = 18
        Me.btnCalculate2.Text = "Calculate"
        Me.btnCalculate2.UseVisualStyleBackColor = True
        '
        'lblMonthlyBill
        '
        Me.lblMonthlyBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyBill.Location = New System.Drawing.Point(392, 55)
        Me.lblMonthlyBill.Name = "lblMonthlyBill"
        Me.lblMonthlyBill.Size = New System.Drawing.Size(113, 29)
        Me.lblMonthlyBill.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 21)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Previous:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(143, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Current:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(388, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Monthly bill:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblMonthlyBill)
        Me.GroupBox3.Controls.Add(Me.btnCalculate2)
        Me.GroupBox3.Controls.Add(Me.txtCurrent)
        Me.GroupBox3.Controls.Add(Me.txtPrevious)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(726, 113)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "p232 #4 Tri County Electric w/validation"
        '
        'First
        '
        Me.First.Location = New System.Drawing.Point(3, 54)
        Me.First.Name = "First"
        Me.First.Size = New System.Drawing.Size(100, 29)
        Me.First.TabIndex = 23
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(142, 54)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(100, 29)
        Me.txtSecond.TabIndex = 24
        '
        'btncalculate3
        '
        Me.btncalculate3.Location = New System.Drawing.Point(272, 53)
        Me.btncalculate3.Name = "btncalculate3"
        Me.btncalculate3.Size = New System.Drawing.Size(82, 28)
        Me.btncalculate3.TabIndex = 25
        Me.btncalculate3.Text = "Calculate"
        Me.btncalculate3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(387, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 29)
        Me.Label11.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 21)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "First#:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(138, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 21)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Second#:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(383, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 21)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Quotient:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.btncalculate3)
        Me.GroupBox4.Controls.Add(Me.txtSecond)
        Me.GroupBox4.Controls.Add(Me.First)
        Me.GroupBox4.Location = New System.Drawing.Point(45, 381)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 115)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(317, 502)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 28)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmQuotient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 538)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmQuotient"
        Me.Text = "esurprenant2d1 If Else statements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtDollar As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents txtPriceperpound As TextBox
    Friend WithEvents label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btncalculate1 As Button
    Friend WithEvents lblEuro As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblRand As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents btnCalculate2 As Button
    Friend WithEvents lblMonthlyBill As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents First As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents btncalculate3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnExit As Button
End Class

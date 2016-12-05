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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnWholesale = New System.Windows.Forms.Button()
        Me.lstWholesale = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstRetail = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRetail = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLessThanAvg = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.btnForEachNext = New System.Windows.Forms.Button()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplayDays = New System.Windows.Forms.Button()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnWholesale)
        Me.GroupBox3.Controls.Add(Me.lstWholesale)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lstRetail)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnRetail)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 209)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(355, 297)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "p523 #13 Wholesale, Retail Prices"
        '
        'btnWholesale
        '
        Me.btnWholesale.Location = New System.Drawing.Point(184, 141)
        Me.btnWholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWholesale.Name = "btnWholesale"
        Me.btnWholesale.Size = New System.Drawing.Size(137, 76)
        Me.btnWholesale.TabIndex = 8
        Me.btnWholesale.Text = "&Return Array to Wholesale Prices"
        '
        'lstWholesale
        '
        Me.lstWholesale.Enabled = False
        Me.lstWholesale.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWholesale.FormattingEnabled = True
        Me.lstWholesale.ItemHeight = 16
        Me.lstWholesale.Location = New System.Drawing.Point(12, 60)
        Me.lstWholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.lstWholesale.Name = "lstWholesale"
        Me.lstWholesale.Size = New System.Drawing.Size(68, 228)
        Me.lstWholesale.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Wholesale:"
        '
        'lstRetail
        '
        Me.lstRetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRetail.Enabled = False
        Me.lstRetail.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRetail.FormattingEnabled = True
        Me.lstRetail.ItemHeight = 16
        Me.lstRetail.Location = New System.Drawing.Point(96, 60)
        Me.lstRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRetail.Name = "lstRetail"
        Me.lstRetail.Size = New System.Drawing.Size(68, 228)
        Me.lstRetail.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Retail:"
        '
        'btnRetail
        '
        Me.btnRetail.Location = New System.Drawing.Point(184, 60)
        Me.btnRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetail.Name = "btnRetail"
        Me.btnRetail.Size = New System.Drawing.Size(137, 76)
        Me.btnRetail.TabIndex = 7
        Me.btnRetail.Text = "&Update Array to Retail Prices"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblLessThanAvg)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnDoLoop)
        Me.GroupBox2.Controls.Add(Me.btnForEachNext)
        Me.GroupBox2.Controls.Add(Me.btnForNext)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(226, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(341, 183)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p522 #9 Avg, min sold"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Values: 250, 225, 193, 260"
        '
        'lblLessThanAvg
        '
        Me.lblLessThanAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLessThanAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLessThanAvg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLessThanAvg.Location = New System.Drawing.Point(72, 100)
        Me.lblLessThanAvg.Name = "lblLessThanAvg"
        Me.lblLessThanAvg.Size = New System.Drawing.Size(112, 36)
        Me.lblLessThanAvg.TabIndex = 14
        Me.lblLessThanAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "< avg:"
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(191, 136)
        Me.btnDoLoop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(129, 36)
        Me.btnDoLoop.TabIndex = 8
        Me.btnDoLoop.Text = "&Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'btnForEachNext
        '
        Me.btnForEachNext.Location = New System.Drawing.Point(191, 97)
        Me.btnForEachNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnForEachNext.Name = "btnForEachNext"
        Me.btnForEachNext.Size = New System.Drawing.Size(129, 36)
        Me.btnForEachNext.TabIndex = 7
        Me.btnForEachNext.Text = "For &Each...Next"
        Me.btnForEachNext.UseVisualStyleBackColor = True
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(191, 57)
        Me.btnForNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(129, 36)
        Me.btnForNext.TabIndex = 6
        Me.btnForNext.Text = "&For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'lblAvg
        '
        Me.lblAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(72, 57)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(112, 36)
        Me.lblAvg.TabIndex = 10
        Me.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Avg sold:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDays)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnDisplayDays)
        Me.GroupBox1.Controls.Add(Me.txtMonth)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(205, 183)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Days in Month"
        '
        'lblDays
        '
        Me.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDays.Location = New System.Drawing.Point(137, 70)
        Me.lblDays.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(41, 30)
        Me.lblDays.TabIndex = 11
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Number of days:"
        '
        'btnDisplayDays
        '
        Me.btnDisplayDays.Location = New System.Drawing.Point(40, 119)
        Me.btnDisplayDays.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplayDays.Name = "btnDisplayDays"
        Me.btnDisplayDays.Size = New System.Drawing.Size(137, 36)
        Me.btnDisplayDays.TabIndex = 8
        Me.btnDisplayDays.Text = "&Display Days"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(137, 30)
        Me.txtMonth.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(48, 25)
        Me.txtMonth.TabIndex = 7
        Me.txtMonth.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Month number:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(441, 444)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 519)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "esurprenant3d1 Arrays, Subscripts, Loops"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnWholesale As Button
    Friend WithEvents lstWholesale As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstRetail As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRetail As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLessThanAvg As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDoLoop As Button
    Friend WithEvents btnForEachNext As Button
    Friend WithEvents btnForNext As Button
    Friend WithEvents lblAvg As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDays As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDisplayDays As Button
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class

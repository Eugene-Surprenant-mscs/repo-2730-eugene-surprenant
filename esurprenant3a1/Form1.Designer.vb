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
        Me.lblEven = New System.Windows.Forms.Label()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.btnDoUntil = New System.Windows.Forms.Button()
        Me.btnLoopWhile = New System.Windows.Forms.Button()
        Me.btnLoopUntil = New System.Windows.Forms.Button()
        Me.btnFor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.TextBox()
        Me.lblCnt = New System.Windows.Forms.Label()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(6, 37)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(155, 279)
        Me.lblEven.TabIndex = 0
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Location = New System.Drawing.Point(183, 37)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(155, 31)
        Me.btnDoWhile.TabIndex = 2
        Me.btnDoWhile.Text = "Pretest: Do While"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'btnDoUntil
        '
        Me.btnDoUntil.Location = New System.Drawing.Point(183, 84)
        Me.btnDoUntil.Name = "btnDoUntil"
        Me.btnDoUntil.Size = New System.Drawing.Size(155, 31)
        Me.btnDoUntil.TabIndex = 3
        Me.btnDoUntil.Text = "Pretest: Do Until"
        Me.btnDoUntil.UseVisualStyleBackColor = True
        '
        'btnLoopWhile
        '
        Me.btnLoopWhile.Location = New System.Drawing.Point(183, 133)
        Me.btnLoopWhile.Name = "btnLoopWhile"
        Me.btnLoopWhile.Size = New System.Drawing.Size(155, 31)
        Me.btnLoopWhile.TabIndex = 4
        Me.btnLoopWhile.Text = "Pretest: Loop While"
        Me.btnLoopWhile.UseVisualStyleBackColor = True
        '
        'btnLoopUntil
        '
        Me.btnLoopUntil.Location = New System.Drawing.Point(183, 182)
        Me.btnLoopUntil.Name = "btnLoopUntil"
        Me.btnLoopUntil.Size = New System.Drawing.Size(155, 31)
        Me.btnLoopUntil.TabIndex = 5
        Me.btnLoopUntil.Text = "Pretest: Loop Until"
        Me.btnLoopUntil.UseVisualStyleBackColor = True
        '
        'btnFor
        '
        Me.btnFor.Location = New System.Drawing.Point(183, 232)
        Me.btnFor.Name = "btnFor"
        Me.btnFor.Size = New System.Drawing.Size(155, 31)
        Me.btnFor.TabIndex = 6
        Me.btnFor.Text = "Pretest: For"
        Me.btnFor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.btnDoWhile)
        Me.GroupBox1.Controls.Add(Me.btnFor)
        Me.GroupBox1.Controls.Add(Me.btnDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnLoopUntil)
        Me.GroupBox1.Controls.Add(Me.btnLoopWhile)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 336)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347#13 Loop 2-20"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.lblCnt)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Controls.Add(Me.lblAverage)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 240)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332_348#22 Addition"
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(6, 28)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ReadOnly = True
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtList.Size = New System.Drawing.Size(114, 190)
        Me.txtList.TabIndex = 9
        Me.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(147, 43)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(70, 21)
        Me.lblAverage.TabIndex = 10
        Me.lblAverage.Text = "Average:"
        '
        'lblAvg
        '
        Me.lblAvg.Location = New System.Drawing.Point(151, 68)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(79, 29)
        Me.lblAvg.TabIndex = 11
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(245, 68)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(79, 29)
        Me.lblCount.TabIndex = 12
        '
        'lblCnt
        '
        Me.lblCnt.AutoSize = True
        Me.lblCnt.Location = New System.Drawing.Point(241, 44)
        Me.lblCnt.Name = "lblCnt"
        Me.lblCnt.Size = New System.Drawing.Size(55, 21)
        Me.lblCnt.TabIndex = 13
        Me.lblCnt.Text = "Count:"
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(151, 112)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(173, 31)
        Me.btnSumDoWhile.TabIndex = 14
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(151, 149)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(173, 31)
        Me.btnSumLoopUntil.TabIndex = 15
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(151, 186)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(173, 31)
        Me.btnSumForNext.TabIndex = 16
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 411)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "esurprenant3a1 Loops, Sum, Count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblEven As Label
    Friend WithEvents btnDoWhile As Button
    Friend WithEvents btnDoUntil As Button
    Friend WithEvents btnLoopWhile As Button
    Friend WithEvents btnLoopUntil As Button
    Friend WithEvents btnFor As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtList As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblCount As TextBox
    Friend WithEvents lblAvg As TextBox
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents lblCnt As Label
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumForNext As Button
End Class

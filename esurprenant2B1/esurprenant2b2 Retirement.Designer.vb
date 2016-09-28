<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmesurprenant2b2_Retirement
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
        Me.lblgross = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.lblemployer = New System.Windows.Forms.Label()
        Me.lblemployeeannual = New System.Windows.Forms.Label()
        Me.lblemployerannual = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txtgross = New System.Windows.Forms.TextBox()
        Me.txtemployee = New System.Windows.Forms.TextBox()
        Me.txtemployer = New System.Windows.Forms.TextBox()
        Me.txtemployeeannual = New System.Windows.Forms.TextBox()
        Me.txtemployerannual = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblgross
        '
        Me.lblgross.AutoSize = True
        Me.lblgross.Location = New System.Drawing.Point(13, 30)
        Me.lblgross.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgross.Name = "lblgross"
        Me.lblgross.Size = New System.Drawing.Size(134, 21)
        Me.lblgross.TabIndex = 0
        Me.lblgross.Text = "&Gross weekly pay:"
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(13, 70)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(307, 21)
        Me.lblemployee.TabIndex = 7
        Me.lblemployee.Text = "&Employee contribution rate (decimal form):"
        '
        'lblemployer
        '
        Me.lblemployer.AutoSize = True
        Me.lblemployer.Location = New System.Drawing.Point(13, 110)
        Me.lblemployer.Name = "lblemployer"
        Me.lblemployer.Size = New System.Drawing.Size(305, 21)
        Me.lblemployer.TabIndex = 8
        Me.lblemployer.Text = "E&mployer contribution rate (decimal form):"
        '
        'lblemployeeannual
        '
        Me.lblemployeeannual.AutoSize = True
        Me.lblemployeeannual.Location = New System.Drawing.Point(13, 150)
        Me.lblemployeeannual.Name = "lblemployeeannual"
        Me.lblemployeeannual.Size = New System.Drawing.Size(228, 21)
        Me.lblemployeeannual.TabIndex = 9
        Me.lblemployeeannual.Text = "Employee annual contributions:"
        '
        'lblemployerannual
        '
        Me.lblemployerannual.AutoSize = True
        Me.lblemployerannual.Location = New System.Drawing.Point(13, 190)
        Me.lblemployerannual.Name = "lblemployerannual"
        Me.lblemployerannual.Size = New System.Drawing.Size(226, 21)
        Me.lblemployerannual.TabIndex = 10
        Me.lblemployerannual.Text = "Employer annual contributions:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(13, 230)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(194, 21)
        Me.lbltotal.TabIndex = 11
        Me.lbltotal.Text = "Total annual contributions:"
        '
        'txtgross
        '
        Me.txtgross.Location = New System.Drawing.Point(418, 22)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(112, 29)
        Me.txtgross.TabIndex = 1
        '
        'txtemployee
        '
        Me.txtemployee.Location = New System.Drawing.Point(418, 67)
        Me.txtemployee.Name = "txtemployee"
        Me.txtemployee.Size = New System.Drawing.Size(112, 29)
        Me.txtemployee.TabIndex = 2
        Me.txtemployee.Text = "0.05"
        '
        'txtemployer
        '
        Me.txtemployer.Location = New System.Drawing.Point(418, 107)
        Me.txtemployer.Name = "txtemployer"
        Me.txtemployer.Size = New System.Drawing.Size(112, 29)
        Me.txtemployer.TabIndex = 3
        Me.txtemployer.Text = "0.07"
        '
        'txtemployeeannual
        '
        Me.txtemployeeannual.Location = New System.Drawing.Point(418, 147)
        Me.txtemployeeannual.Name = "txtemployeeannual"
        Me.txtemployeeannual.Size = New System.Drawing.Size(112, 29)
        Me.txtemployeeannual.TabIndex = 12
        '
        'txtemployerannual
        '
        Me.txtemployerannual.Location = New System.Drawing.Point(418, 187)
        Me.txtemployerannual.Name = "txtemployerannual"
        Me.txtemployerannual.Size = New System.Drawing.Size(112, 29)
        Me.txtemployerannual.TabIndex = 13
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(418, 227)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(112, 29)
        Me.txttotal.TabIndex = 14
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(104, 284)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 33)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(336, 284)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 33)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(224, 284)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 33)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmesurprenant2b2_Retirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(542, 329)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtemployerannual)
        Me.Controls.Add(Me.txtemployeeannual)
        Me.Controls.Add(Me.txtemployer)
        Me.Controls.Add(Me.txtemployee)
        Me.Controls.Add(Me.txtgross)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblemployerannual)
        Me.Controls.Add(Me.lblemployeeannual)
        Me.Controls.Add(Me.lblemployer)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblgross)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmesurprenant2b2_Retirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "esurprenant2b2_Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblgross As Label
    Friend WithEvents lblemployee As Label
    Friend WithEvents lblemployer As Label
    Friend WithEvents lblemployeeannual As Label
    Friend WithEvents lblemployerannual As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents txtgross As TextBox
    Friend WithEvents txtemployee As TextBox
    Friend WithEvents txtemployer As TextBox
    Friend WithEvents txtemployeeannual As TextBox
    Friend WithEvents txtemployerannual As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
End Class

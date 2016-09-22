<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblComm = New System.Windows.Forms.Label()
        Me.btnRate8 = New System.Windows.Forms.Button()
        Me.btnRate10 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Sales:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(17, 36)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 27)
        Me.txtSales.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(144, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Commission:"
        '
        'lblComm
        '
        Me.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComm.Location = New System.Drawing.Point(148, 36)
        Me.lblComm.Name = "lblComm"
        Me.lblComm.Size = New System.Drawing.Size(100, 27)
        Me.lblComm.TabIndex = 6
        Me.lblComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRate8
        '
        Me.btnRate8.Location = New System.Drawing.Point(275, 13)
        Me.btnRate8.Name = "btnRate8"
        Me.btnRate8.Size = New System.Drawing.Size(94, 36)
        Me.btnRate8.TabIndex = 2
        Me.btnRate8.Text = "&8% Rate"
        Me.btnRate8.UseVisualStyleBackColor = true
        '
        'btnRate10
        '
        Me.btnRate10.Location = New System.Drawing.Point(275, 55)
        Me.btnRate10.Name = "btnRate10"
        Me.btnRate10.Size = New System.Drawing.Size(94, 36)
        Me.btnRate10.TabIndex = 3
        Me.btnRate10.Text = "&10% Rate"
        Me.btnRate10.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(275, 97)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 36)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 151)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRate10)
        Me.Controls.Add(Me.btnRate8)
        Me.Controls.Add(Me.lblComm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commission Calculator"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblComm As Label
    Friend WithEvents btnRate8 As Button
    Friend WithEvents btnRate10 As Button
    Friend WithEvents btnExit As Button
End Class

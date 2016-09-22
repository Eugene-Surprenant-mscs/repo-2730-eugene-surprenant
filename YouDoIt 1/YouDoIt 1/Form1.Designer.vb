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
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.lblcost = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(314, 19)
        Me.txtcost.Margin = New System.Windows.Forms.Padding(6)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(180, 33)
        Me.txtcost.TabIndex = 0
        Me.txtcost.Tag = "45"
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcost.Location = New System.Drawing.Point(191, 97)
        Me.lblcost.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(2, 27)
        Me.lblcost.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 200)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Double"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(253, 22)
        Me.label.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(53, 25)
        Me.label.TabIndex = 3
        Me.label.Text = "Cost:"
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(347, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 44)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Variable's Content:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 291)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblcost)
        Me.Controls.Add(Me.txtcost)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcost As TextBox
    Friend WithEvents lblcost As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents label As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class

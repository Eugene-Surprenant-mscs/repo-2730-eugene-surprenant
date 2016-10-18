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
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResortFee = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblRoomChg = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtChildren = New System.Windows.Forms.TextBox()
        Me.txtAdults = New System.Windows.Forms.TextBox()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.txtRooms = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radQueen = New System.Windows.Forms.RadioButton()
        Me.radKing = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.radAtrium = New System.Windows.Forms.RadioButton()
        Me.chkParkingFee = New System.Windows.Forms.CheckBox()
        Me.lblParkingFee = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(96, 160)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(93, 26)
        Me.lblTotalDue.TabIndex = 9
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(276, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 31)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResortFee
        '
        Me.lblResortFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResortFee.Location = New System.Drawing.Point(96, 97)
        Me.lblResortFee.Name = "lblResortFee"
        Me.lblResortFee.Size = New System.Drawing.Size(93, 26)
        Me.lblResortFee.TabIndex = 7
        Me.lblResortFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(134, 356)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(97, 31)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Ca&lculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(96, 65)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(93, 26)
        Me.lblTax.TabIndex = 6
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRoomChg
        '
        Me.lblRoomChg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRoomChg.Location = New System.Drawing.Point(96, 33)
        Me.lblRoomChg.Name = "lblRoomChg"
        Me.lblRoomChg.Size = New System.Drawing.Size(93, 26)
        Me.lblRoomChg.TabIndex = 5
        Me.lblRoomChg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtChildren)
        Me.GroupBox1.Controls.Add(Me.txtAdults)
        Me.GroupBox1.Controls.Add(Me.txtNights)
        Me.GroupBox1.Controls.Add(Me.txtRooms)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Number of"
        '
        'txtChildren
        '
        Me.txtChildren.Location = New System.Drawing.Point(135, 129)
        Me.txtChildren.Name = "txtChildren"
        Me.txtChildren.Size = New System.Drawing.Size(40, 27)
        Me.txtChildren.TabIndex = 7
        '
        'txtAdults
        '
        Me.txtAdults.Location = New System.Drawing.Point(21, 129)
        Me.txtAdults.Name = "txtAdults"
        Me.txtAdults.Size = New System.Drawing.Size(40, 27)
        Me.txtAdults.TabIndex = 5
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(135, 61)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(40, 27)
        Me.txtNights.TabIndex = 3
        '
        'txtRooms
        '
        Me.txtRooms.Location = New System.Drawing.Point(21, 61)
        Me.txtRooms.Name = "txtRooms"
        Me.txtRooms.Size = New System.Drawing.Size(40, 27)
        Me.txtRooms.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "&Nights:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Children:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Adults (18+):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Rooms:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total due:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Resort fee:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Room:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tax:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.esurprenant2f1.My.Resources.Resources.Tree
        Me.PictureBox1.Location = New System.Drawing.Point(21, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblParkingFee)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblResortFee)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblRoomChg)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 189)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radKing)
        Me.GroupBox3.Controls.Add(Me.radQueen)
        Me.GroupBox3.Location = New System.Drawing.Point(134, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 100)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Type"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radAtrium)
        Me.GroupBox4.Controls.Add(Me.radStandard)
        Me.GroupBox4.Location = New System.Drawing.Point(305, 23)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(110, 100)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "View"
        '
        'radQueen
        '
        Me.radQueen.AutoSize = True
        Me.radQueen.Checked = True
        Me.radQueen.Location = New System.Drawing.Point(7, 27)
        Me.radQueen.Name = "radQueen"
        Me.radQueen.Size = New System.Drawing.Size(102, 24)
        Me.radQueen.TabIndex = 0
        Me.radQueen.TabStop = True
        Me.radQueen.Text = "Two &Queen"
        Me.radQueen.UseVisualStyleBackColor = True
        '
        'radKing
        '
        Me.radKing.AutoSize = True
        Me.radKing.Location = New System.Drawing.Point(7, 58)
        Me.radKing.Name = "radKing"
        Me.radKing.Size = New System.Drawing.Size(88, 24)
        Me.radKing.TabIndex = 1
        Me.radKing.Text = "One &King"
        Me.radKing.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(9, 26)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(87, 24)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'radAtrium
        '
        Me.radAtrium.AutoSize = True
        Me.radAtrium.Location = New System.Drawing.Point(9, 56)
        Me.radAtrium.Name = "radAtrium"
        Me.radAtrium.Size = New System.Drawing.Size(72, 24)
        Me.radAtrium.TabIndex = 1
        Me.radAtrium.Text = "A&trium"
        Me.radAtrium.UseVisualStyleBackColor = True
        '
        'chkParkingFee
        '
        Me.chkParkingFee.AutoSize = True
        Me.chkParkingFee.Location = New System.Drawing.Point(427, 51)
        Me.chkParkingFee.Name = "chkParkingFee"
        Me.chkParkingFee.Size = New System.Drawing.Size(155, 24)
        Me.chkParkingFee.TabIndex = 5
        Me.chkParkingFee.Text = "&Vehicle parking fee"
        Me.chkParkingFee.UseVisualStyleBackColor = True
        '
        'lblParkingFee
        '
        Me.lblParkingFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblParkingFee.Location = New System.Drawing.Point(96, 130)
        Me.lblParkingFee.Name = "lblParkingFee"
        Me.lblParkingFee.Size = New System.Drawing.Size(93, 26)
        Me.lblParkingFee.TabIndex = 8
        Me.lblParkingFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Parking:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 414)
        Me.Controls.Add(Me.chkParkingFee)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Treeline Resort"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalDue As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResortFee As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTax As Label
    Friend WithEvents lblRoomChg As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtChildren As TextBox
    Friend WithEvents txtAdults As TextBox
    Friend WithEvents txtNights As TextBox
    Friend WithEvents txtRooms As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radKing As RadioButton
    Friend WithEvents radQueen As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents radAtrium As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents chkParkingFee As CheckBox
    Friend WithEvents lblParkingFee As Label
    Friend WithEvents Label10 As Label
End Class

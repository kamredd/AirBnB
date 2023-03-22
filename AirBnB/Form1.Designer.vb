<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmairbnb
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
        Me.lblAirbnb = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblStayCost = New System.Windows.Forms.Label()
        Me.lblActualCost = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAirbnb
        '
        Me.lblAirbnb.AutoSize = True
        Me.lblAirbnb.Font = New System.Drawing.Font("Berlin Sans FB Demi", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirbnb.Location = New System.Drawing.Point(408, 34)
        Me.lblAirbnb.Name = "lblAirbnb"
        Me.lblAirbnb.Size = New System.Drawing.Size(365, 55)
        Me.lblAirbnb.TabIndex = 1
        Me.lblAirbnb.Text = "Orlando AirBnB"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(476, 89)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(217, 24)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "Only $79.00 per night"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.Location = New System.Drawing.Point(415, 139)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(145, 18)
        Me.lblNights.TabIndex = 3
        Me.lblNights.Text = "Number of Nights:"
        '
        'lblStayCost
        '
        Me.lblStayCost.AutoSize = True
        Me.lblStayCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStayCost.Location = New System.Drawing.Point(415, 208)
        Me.lblStayCost.Name = "lblStayCost"
        Me.lblStayCost.Size = New System.Drawing.Size(107, 18)
        Me.lblStayCost.TabIndex = 4
        Me.lblStayCost.Text = "Cost of Stay:"
        '
        'lblActualCost
        '
        Me.lblActualCost.AutoSize = True
        Me.lblActualCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualCost.Location = New System.Drawing.Point(590, 208)
        Me.lblActualCost.Name = "lblActualCost"
        Me.lblActualCost.Size = New System.Drawing.Size(0, 18)
        Me.lblActualCost.TabIndex = 6
        Me.lblActualCost.Visible = False
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(593, 136)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(34, 24)
        Me.txtNumber.TabIndex = 7
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(385, 290)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(120, 48)
        Me.btnCost.TabIndex = 8
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(532, 290)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(122, 48)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.AirBnB.My.Resources.Resources.airbnb
        Me.pictureBox1.Location = New System.Drawing.Point(-9, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(372, 447)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 10
        Me.pictureBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gainsboro
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(672, 291)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 47)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmairbnb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblActualCost)
        Me.Controls.Add(Me.lblStayCost)
        Me.Controls.Add(Me.lblNights)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblAirbnb)
        Me.Name = "frmairbnb"
        Me.Text = "Air BnB Reservations"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblAirbnb As Label
    Private WithEvents lblCost As Label
    Private WithEvents lblNights As Label
    Private WithEvents lblStayCost As Label
    Private WithEvents lblActualCost As Label
    Private WithEvents txtNumber As TextBox
    Private WithEvents btnCost As Button
    Private WithEvents btnClear As Button
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnExit As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckout))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnSearchGuest = New System.Windows.Forms.Button()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiscountType = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bttnCheckout = New System.Windows.Forms.Button()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.lblTransID = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtIn = New System.Windows.Forms.DateTimePicker()
        Me.dtOut = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox_Grand_Total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Payment "
        '
        'bttnSearchGuest
        '
        Me.bttnSearchGuest.Location = New System.Drawing.Point(377, 93)
        Me.bttnSearchGuest.Name = "bttnSearchGuest"
        Me.bttnSearchGuest.Size = New System.Drawing.Size(30, 26)
        Me.bttnSearchGuest.TabIndex = 71
        Me.bttnSearchGuest.Text = "..."
        Me.bttnSearchGuest.UseVisualStyleBackColor = True
        '
        'txtGuestName
        '
        Me.txtGuestName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtGuestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.Location = New System.Drawing.Point(161, 94)
        Me.txtGuestName.Multiline = True
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.ReadOnly = True
        Me.txtGuestName.Size = New System.Drawing.Size(210, 25)
        Me.txtGuestName.TabIndex = 67
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Table Number"
        '
        'txtTransID
        '
        Me.txtTransID.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTransID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransID.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTransID.Location = New System.Drawing.Point(161, 63)
        Me.txtTransID.Multiline = True
        Me.txtTransID.Name = "txtTransID"
        Me.txtTransID.ReadOnly = True
        Me.txtTransID.Size = New System.Drawing.Size(115, 25)
        Me.txtTransID.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Order ID"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(161, 125)
        Me.txtRoomNumber.Multiline = True
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.ReadOnly = True
        Me.txtRoomNumber.Size = New System.Drawing.Size(85, 25)
        Me.txtRoomNumber.TabIndex = 72
        Me.txtRoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Member ID"
        '
        'txtDiscountType
        '
        Me.txtDiscountType.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDiscountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountType.Location = New System.Drawing.Point(161, 156)
        Me.txtDiscountType.Multiline = True
        Me.txtDiscountType.Name = "txtDiscountType"
        Me.txtDiscountType.ReadOnly = True
        Me.txtDiscountType.Size = New System.Drawing.Size(85, 25)
        Me.txtDiscountType.TabIndex = 91
        Me.txtDiscountType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 16)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Member Discount"
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.ForeColor = System.Drawing.Color.Black
        Me.txtCash.Location = New System.Drawing.Point(61, 314)
        Me.txtCash.Multiline = True
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(143, 38)
        Me.txtCash.TabIndex = 97
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(48, 282)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(167, 29)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "CASH GIVEN"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.Location = New System.Drawing.Point(358, 314)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(143, 38)
        Me.txtChange.TabIndex = 99
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(308, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(230, 29)
        Me.Label16.TabIndex = 100
        Me.Label16.Text = "CHANGE TO GIVE"
        '
        'bttnCheckout
        '
        Me.bttnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCheckout.Location = New System.Drawing.Point(216, 369)
        Me.bttnCheckout.Name = "bttnCheckout"
        Me.bttnCheckout.Size = New System.Drawing.Size(128, 50)
        Me.bttnCheckout.TabIndex = 101
        Me.bttnCheckout.Text = "&CHECKOUT"
        Me.bttnCheckout.UseVisualStyleBackColor = True
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(14, 497)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(46, 13)
        Me.lblGuestID.TabIndex = 102
        Me.lblGuestID.Text = "GuestID"
        '
        'lblTransID
        '
        Me.lblTransID.AutoSize = True
        Me.lblTransID.Location = New System.Drawing.Point(15, 517)
        Me.lblTransID.Name = "lblTransID"
        Me.lblTransID.Size = New System.Drawing.Size(41, 13)
        Me.lblTransID.TabIndex = 103
        Me.lblTransID.Text = "transID"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(161, 187)
        Me.txtSubTotal.Multiline = True
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(85, 25)
        Me.txtSubTotal.TabIndex = 104
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(70, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 16)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Sub Total"
        '
        'dtIn
        '
        Me.dtIn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIn.Location = New System.Drawing.Point(101, 497)
        Me.dtIn.Name = "dtIn"
        Me.dtIn.Size = New System.Drawing.Size(93, 20)
        Me.dtIn.TabIndex = 106
        '
        'dtOut
        '
        Me.dtOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOut.Location = New System.Drawing.Point(200, 497)
        Me.dtOut.Name = "dtOut"
        Me.dtOut.Size = New System.Drawing.Size(102, 20)
        Me.dtOut.TabIndex = 107
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 26)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox_Grand_Total
        '
        Me.TextBox_Grand_Total.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox_Grand_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Grand_Total.Location = New System.Drawing.Point(161, 222)
        Me.TextBox_Grand_Total.Multiline = True
        Me.TextBox_Grand_Total.Name = "TextBox_Grand_Total"
        Me.TextBox_Grand_Total.ReadOnly = True
        Me.TextBox_Grand_Total.Size = New System.Drawing.Size(85, 25)
        Me.TextBox_Grand_Total.TabIndex = 109
        Me.TextBox_Grand_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Grand Total"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(252, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 25)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Calculate Discount"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmCheckout
        '
        Me.AcceptButton = Me.bttnCheckout
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 444)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_Grand_Total)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.dtOut)
        Me.Controls.Add(Me.dtIn)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblTransID)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.bttnCheckout)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDiscountType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bttnSearchGuest)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTransID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout Guest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bttnSearchGuest As System.Windows.Forms.Button
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTransID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountType As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bttnCheckout As System.Windows.Forms.Button
    Friend WithEvents lblGuestID As System.Windows.Forms.Label
    Friend WithEvents lblTransID As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox_Grand_Total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class

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
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkclearning = New System.Windows.Forms.CheckBox()
        Me.chkxray = New System.Windows.Forms.CheckBox()
        Me.chkcavityfilling = New System.Windows.Forms.CheckBox()
        Me.lblxray = New System.Windows.Forms.Label()
        Me.lblcavityfilling = New System.Windows.Forms.Label()
        Me.lblclearning = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(196, 306)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(100, 27)
        Me.txttotal.TabIndex = 0
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btncalculate
        '
        Me.btncalculate.Location = New System.Drawing.Point(196, 359)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(100, 34)
        Me.btncalculate.TabIndex = 1
        Me.btncalculate.Text = "calculate"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "patient name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(180, 66)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 27)
        Me.txtname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "clearning"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "cavity filling"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "X-ray"
        '
        'chkclearning
        '
        Me.chkclearning.AutoSize = True
        Me.chkclearning.Location = New System.Drawing.Point(29, 116)
        Me.chkclearning.Name = "chkclearning"
        Me.chkclearning.Size = New System.Drawing.Size(15, 14)
        Me.chkclearning.TabIndex = 7
        Me.chkclearning.UseVisualStyleBackColor = True
        '
        'chkxray
        '
        Me.chkxray.AutoSize = True
        Me.chkxray.Location = New System.Drawing.Point(29, 238)
        Me.chkxray.Name = "chkxray"
        Me.chkxray.Size = New System.Drawing.Size(15, 14)
        Me.chkxray.TabIndex = 8
        Me.chkxray.UseVisualStyleBackColor = True
        '
        'chkcavityfilling
        '
        Me.chkcavityfilling.AutoSize = True
        Me.chkcavityfilling.Location = New System.Drawing.Point(29, 174)
        Me.chkcavityfilling.Name = "chkcavityfilling"
        Me.chkcavityfilling.Size = New System.Drawing.Size(15, 14)
        Me.chkcavityfilling.TabIndex = 9
        Me.chkcavityfilling.UseVisualStyleBackColor = True
        '
        'lblxray
        '
        Me.lblxray.Location = New System.Drawing.Point(243, 238)
        Me.lblxray.Name = "lblxray"
        Me.lblxray.Size = New System.Drawing.Size(53, 20)
        Me.lblxray.TabIndex = 12
        '
        'lblcavityfilling
        '
        Me.lblcavityfilling.Location = New System.Drawing.Point(243, 168)
        Me.lblcavityfilling.Name = "lblcavityfilling"
        Me.lblcavityfilling.Size = New System.Drawing.Size(53, 20)
        Me.lblcavityfilling.TabIndex = 11
        '
        'lblclearning
        '
        Me.lblclearning.Location = New System.Drawing.Point(243, 116)
        Me.lblclearning.Name = "lblclearning"
        Me.lblclearning.Size = New System.Drawing.Size(53, 20)
        Me.lblclearning.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(122, 309)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 427)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblxray)
        Me.Controls.Add(Me.lblcavityfilling)
        Me.Controls.Add(Me.lblclearning)
        Me.Controls.Add(Me.chkcavityfilling)
        Me.Controls.Add(Me.chkxray)
        Me.Controls.Add(Me.chkclearning)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txttotal)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkclearning As System.Windows.Forms.CheckBox
    Friend WithEvents chkxray As System.Windows.Forms.CheckBox
    Friend WithEvents chkcavityfilling As System.Windows.Forms.CheckBox
    Friend WithEvents lblxray As System.Windows.Forms.Label
    Friend WithEvents lblcavityfilling As System.Windows.Forms.Label
    Friend WithEvents lblclearning As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class

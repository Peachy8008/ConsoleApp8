<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logusernametxt = New System.Windows.Forms.TextBox()
        Me.logpasswordtxt = New System.Windows.Forms.TextBox()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rgherebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'logusernametxt
        '
        Me.logusernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logusernametxt.Location = New System.Drawing.Point(43, 103)
        Me.logusernametxt.Name = "logusernametxt"
        Me.logusernametxt.Size = New System.Drawing.Size(181, 31)
        Me.logusernametxt.TabIndex = 3
        '
        'logpasswordtxt
        '
        Me.logpasswordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logpasswordtxt.Location = New System.Drawing.Point(43, 170)
        Me.logpasswordtxt.Name = "logpasswordtxt"
        Me.logpasswordtxt.Size = New System.Drawing.Size(181, 31)
        Me.logpasswordtxt.TabIndex = 4
        '
        'loginbtn
        '
        Me.loginbtn.Location = New System.Drawing.Point(94, 222)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(75, 23)
        Me.loginbtn.TabIndex = 5
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Don't have an Account"
        '
        'rgherebtn
        '
        Me.rgherebtn.Location = New System.Drawing.Point(81, 282)
        Me.rgherebtn.Name = "rgherebtn"
        Me.rgherebtn.Size = New System.Drawing.Size(98, 23)
        Me.rgherebtn.TabIndex = 7
        Me.rgherebtn.Text = "Register here"
        Me.rgherebtn.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 343)
        Me.Controls.Add(Me.rgherebtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.logpasswordtxt)
        Me.Controls.Add(Me.logusernametxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents logusernametxt As TextBox
    Friend WithEvents logpasswordtxt As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents rgherebtn As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.regpasswordtxt = New System.Windows.Forms.TextBox()
        Me.regusernametxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logherebtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'registerbtn
        '
        Me.registerbtn.Location = New System.Drawing.Point(100, 225)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(75, 23)
        Me.registerbtn.TabIndex = 11
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = True
        '
        'regpasswordtxt
        '
        Me.regpasswordtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regpasswordtxt.Location = New System.Drawing.Point(51, 188)
        Me.regpasswordtxt.Name = "regpasswordtxt"
        Me.regpasswordtxt.Size = New System.Drawing.Size(181, 31)
        Me.regpasswordtxt.TabIndex = 10
        '
        'regusernametxt
        '
        Me.regusernametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regusernametxt.Location = New System.Drawing.Point(51, 121)
        Me.regusernametxt.Name = "regusernametxt"
        Me.regusernametxt.Size = New System.Drawing.Size(181, 31)
        Me.regusernametxt.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Register"
        '
        'logherebtn
        '
        Me.logherebtn.Location = New System.Drawing.Point(86, 281)
        Me.logherebtn.Name = "logherebtn"
        Me.logherebtn.Size = New System.Drawing.Size(98, 23)
        Me.logherebtn.TabIndex = 13
        Me.logherebtn.Text = "Login here"
        Me.logherebtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Already have an Account"
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 336)
        Me.Controls.Add(Me.logherebtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.registerbtn)
        Me.Controls.Add(Me.regpasswordtxt)
        Me.Controls.Add(Me.regusernametxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "register"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents registerbtn As Button
    Friend WithEvents regpasswordtxt As TextBox
    Friend WithEvents regusernametxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logherebtn As Button
    Friend WithEvents Label4 As Label
End Class

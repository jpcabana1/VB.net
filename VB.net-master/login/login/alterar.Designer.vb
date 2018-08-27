<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class alterar
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Csenha2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cemail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Csenha1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cuser = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Csenha2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Cemail)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Csenha1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Cuser)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(69, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 489)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alterar Dados"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 46)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Alterar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Confirmar senha:"
        '
        'Csenha2
        '
        Me.Csenha2.Location = New System.Drawing.Point(203, 211)
        Me.Csenha2.Name = "Csenha2"
        Me.Csenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Csenha2.Size = New System.Drawing.Size(164, 29)
        Me.Csenha2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "E-mail:"
        '
        'Cemail
        '
        Me.Cemail.Location = New System.Drawing.Point(203, 275)
        Me.Cemail.Name = "Cemail"
        Me.Cemail.Size = New System.Drawing.Size(164, 29)
        Me.Cemail.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nova senha:"
        '
        'Csenha1
        '
        Me.Csenha1.Location = New System.Drawing.Point(203, 139)
        Me.Csenha1.Name = "Csenha1"
        Me.Csenha1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Csenha1.Size = New System.Drawing.Size(164, 29)
        Me.Csenha1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Novo usuário:"
        '
        'Cuser
        '
        Me.Cuser.Location = New System.Drawing.Point(203, 71)
        Me.Cuser.Name = "Cuser"
        Me.Cuser.Size = New System.Drawing.Size(164, 29)
        Me.Cuser.TabIndex = 2
        '
        'alterar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 513)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "alterar"
        Me.Text = "alterar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Csenha2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Cemail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Csenha1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Cuser As TextBox
End Class

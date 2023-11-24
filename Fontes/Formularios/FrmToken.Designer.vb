<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmToken
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmToken))
        Me.ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Refresh_Token = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Acess_Token = New System.Windows.Forms.Label()
        Me.LbAcess = New System.Windows.Forms.Label()
        Me.Expiracao = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Plataforma = New System.Windows.Forms.ComboBox()
        Me.CmdGerarToken = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(12, 30)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(99, 22)
        Me.ID.TabIndex = 4
        Me.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Refresh_Token
        '
        Me.Refresh_Token.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Refresh_Token.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_Token.Location = New System.Drawing.Point(12, 87)
        Me.Refresh_Token.Name = "Refresh_Token"
        Me.Refresh_Token.Size = New System.Drawing.Size(447, 22)
        Me.Refresh_Token.TabIndex = 6
        Me.Refresh_Token.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Refresh Token"
        '
        'Acess_Token
        '
        Me.Acess_Token.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Acess_Token.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Acess_Token.Location = New System.Drawing.Point(12, 138)
        Me.Acess_Token.Name = "Acess_Token"
        Me.Acess_Token.Size = New System.Drawing.Size(447, 22)
        Me.Acess_Token.TabIndex = 8
        Me.Acess_Token.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbAcess
        '
        Me.LbAcess.AutoSize = True
        Me.LbAcess.Location = New System.Drawing.Point(12, 122)
        Me.LbAcess.Name = "LbAcess"
        Me.LbAcess.Size = New System.Drawing.Size(89, 16)
        Me.LbAcess.TabIndex = 7
        Me.LbAcess.Text = "ACess Token"
        '
        'Expiracao
        '
        Me.Expiracao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Expiracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expiracao.Location = New System.Drawing.Point(465, 87)
        Me.Expiracao.Name = "Expiracao"
        Me.Expiracao.Size = New System.Drawing.Size(138, 22)
        Me.Expiracao.TabIndex = 10
        Me.Expiracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(462, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Expiração"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Plataforna"
        '
        'Plataforma
        '
        Me.Plataforma.FormattingEnabled = True
        Me.Plataforma.Items.AddRange(New Object() {"Shopee"})
        Me.Plataforma.Location = New System.Drawing.Point(117, 28)
        Me.Plataforma.Name = "Plataforma"
        Me.Plataforma.Size = New System.Drawing.Size(241, 24)
        Me.Plataforma.TabIndex = 11
        '
        'CmdGerarToken
        '
        Me.CmdGerarToken.BackColor = System.Drawing.Color.Green
        Me.CmdGerarToken.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGerarToken.ForeColor = System.Drawing.Color.White
        Me.CmdGerarToken.Location = New System.Drawing.Point(466, 112)
        Me.CmdGerarToken.Name = "CmdGerarToken"
        Me.CmdGerarToken.Size = New System.Drawing.Size(137, 49)
        Me.CmdGerarToken.TabIndex = 13
        Me.CmdGerarToken.Text = "Gerar Token"
        Me.CmdGerarToken.UseVisualStyleBackColor = False
        Me.CmdGerarToken.Visible = False
        '
        'FrmToken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(636, 187)
        Me.Controls.Add(Me.CmdGerarToken)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Plataforma)
        Me.Controls.Add(Me.Expiracao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Acess_Token)
        Me.Controls.Add(Me.LbAcess)
        Me.Controls.Add(Me.Refresh_Token)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmToken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Token"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Refresh_Token As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Acess_Token As Label
    Friend WithEvents LbAcess As Label
    Friend WithEvents Expiracao As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Plataforma As ComboBox
    Friend WithEvents CmdGerarToken As Button
End Class

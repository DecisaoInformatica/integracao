<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguração
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguração))
        Me.Endereço_Redirecionamento_Página = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.Label()
        Me.Plataforma = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ID_Aplicação = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Senha_Aplicação = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Endereço_Host = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Loja_ID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdSalvar = New System.Windows.Forms.Button()
        Me.Codigo_Gerado = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Endereço_Redirecionamento_Página
        '
        Me.Endereço_Redirecionamento_Página.Location = New System.Drawing.Point(28, 149)
        Me.Endereço_Redirecionamento_Página.Name = "Endereço_Redirecionamento_Página"
        Me.Endereço_Redirecionamento_Página.Size = New System.Drawing.Size(646, 22)
        Me.Endereço_Redirecionamento_Página.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'ID
        '
        Me.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(26, 29)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(99, 22)
        Me.ID.TabIndex = 2
        Me.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Plataforma
        '
        Me.Plataforma.FormattingEnabled = True
        Me.Plataforma.Items.AddRange(New Object() {"Shopee"})
        Me.Plataforma.Location = New System.Drawing.Point(131, 27)
        Me.Plataforma.Name = "Plataforma"
        Me.Plataforma.Size = New System.Drawing.Size(185, 24)
        Me.Plataforma.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Plataforna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Redirecionar respostas para:"
        '
        'ID_Aplicação
        '
        Me.ID_Aplicação.Location = New System.Drawing.Point(28, 207)
        Me.ID_Aplicação.Name = "ID_Aplicação"
        Me.ID_Aplicação.Size = New System.Drawing.Size(97, 22)
        Me.ID_Aplicação.TabIndex = 6
        Me.ID_Aplicação.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ID Aplicação"
        '
        'Senha_Aplicação
        '
        Me.Senha_Aplicação.Location = New System.Drawing.Point(131, 207)
        Me.Senha_Aplicação.Name = "Senha_Aplicação"
        Me.Senha_Aplicação.Size = New System.Drawing.Size(543, 22)
        Me.Senha_Aplicação.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Senha da Aplicação"
        '
        'Endereço_Host
        '
        Me.Endereço_Host.Location = New System.Drawing.Point(31, 91)
        Me.Endereço_Host.Name = "Endereço_Host"
        Me.Endereço_Host.Size = New System.Drawing.Size(643, 22)
        Me.Endereço_Host.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Endereço Host da API"
        '
        'Loja_ID
        '
        Me.Loja_ID.Location = New System.Drawing.Point(28, 265)
        Me.Loja_ID.Name = "Loja_ID"
        Me.Loja_ID.Size = New System.Drawing.Size(97, 22)
        Me.Loja_ID.TabIndex = 12
        Me.Loja_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ID da Loja"
        '
        'CmdSalvar
        '
        Me.CmdSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.CmdSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalvar.ForeColor = System.Drawing.Color.White
        Me.CmdSalvar.Location = New System.Drawing.Point(425, 238)
        Me.CmdSalvar.Name = "CmdSalvar"
        Me.CmdSalvar.Size = New System.Drawing.Size(241, 49)
        Me.CmdSalvar.TabIndex = 14
        Me.CmdSalvar.Text = "Salvar"
        Me.CmdSalvar.UseVisualStyleBackColor = False
        '
        'Codigo_Gerado
        '
        Me.Codigo_Gerado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Codigo_Gerado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo_Gerado.Location = New System.Drawing.Point(322, 29)
        Me.Codigo_Gerado.Name = "Codigo_Gerado"
        Me.Codigo_Gerado.Size = New System.Drawing.Size(352, 22)
        Me.Codigo_Gerado.TabIndex = 16
        Me.Codigo_Gerado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(319, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Código Aceso Gerado"
        '
        'FrmConfiguração
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(692, 312)
        Me.Controls.Add(Me.Codigo_Gerado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CmdSalvar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Loja_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Endereço_Host)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Senha_Aplicação)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ID_Aplicação)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Plataforma)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Endereço_Redirecionamento_Página)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmConfiguração"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuração da Integração"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Endereço_Redirecionamento_Página As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As Label
    Friend WithEvents Plataforma As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ID_Aplicação As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Senha_Aplicação As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Endereço_Host As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Loja_ID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CmdSalvar As Button
    Friend WithEvents Codigo_Gerado As Label
    Friend WithEvents Label9 As Label
End Class

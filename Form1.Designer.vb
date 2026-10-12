<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblTitulo = New Label()
        lblBus1 = New Label()
        lblBus2 = New Label()
        lblBus3 = New Label()
        pbBus1 = New ProgressBar()
        pbBus2 = New ProgressBar()
        pbBus3 = New ProgressBar()
        lblEstado1 = New Label()
        lblEstado2 = New Label()
        lblEstado3 = New Label()
        lblGanador = New Label()
        btnIniciar = New Button()
        btnSalir = New Button()
        tmrEstados = New Timer(components)
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold)
        lblTitulo.ForeColor = Color.DarkBlue
        lblTitulo.Location = New Point(18, 16)
        lblTitulo.Margin = New Padding(2, 0, 2, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(257, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Managua → Estelí · 150 km"
        ' 
        ' lblBus1
        ' 
        lblBus1.AutoSize = True
        lblBus1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBus1.ForeColor = Color.MidnightBlue
        lblBus1.Location = New Point(18, 75)
        lblBus1.Margin = New Padding(2, 0, 2, 0)
        lblBus1.Name = "lblBus1"
        lblBus1.Size = New Size(48, 20)
        lblBus1.TabIndex = 1
        lblBus1.Text = "Bus 1"
        ' 
        ' lblBus2
        ' 
        lblBus2.AutoSize = True
        lblBus2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBus2.ForeColor = Color.MidnightBlue
        lblBus2.Location = New Point(18, 150)
        lblBus2.Margin = New Padding(2, 0, 2, 0)
        lblBus2.Name = "lblBus2"
        lblBus2.Size = New Size(48, 20)
        lblBus2.TabIndex = 2
        lblBus2.Text = "Bus 2"
        ' 
        ' lblBus3
        ' 
        lblBus3.AutoSize = True
        lblBus3.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBus3.ForeColor = Color.MidnightBlue
        lblBus3.Location = New Point(18, 223)
        lblBus3.Margin = New Padding(2, 0, 2, 0)
        lblBus3.Name = "lblBus3"
        lblBus3.Size = New Size(48, 20)
        lblBus3.TabIndex = 3
        lblBus3.Text = "Bus 3"
        ' 
        ' pbBus1
        ' 
        pbBus1.ForeColor = Color.RoyalBlue
        pbBus1.Location = New Point(18, 109)
        pbBus1.Margin = New Padding(2)
        pbBus1.Maximum = 150
        pbBus1.Name = "pbBus1"
        pbBus1.Size = New Size(312, 23)
        pbBus1.TabIndex = 4
        ' 
        ' pbBus2
        ' 
        pbBus2.ForeColor = Color.RoyalBlue
        pbBus2.Location = New Point(18, 181)
        pbBus2.Margin = New Padding(2)
        pbBus2.Maximum = 150
        pbBus2.Name = "pbBus2"
        pbBus2.Size = New Size(312, 23)
        pbBus2.TabIndex = 4
        ' 
        ' pbBus3
        ' 
        pbBus3.ForeColor = Color.RoyalBlue
        pbBus3.Location = New Point(18, 258)
        pbBus3.Margin = New Padding(2)
        pbBus3.Maximum = 150
        pbBus3.Name = "pbBus3"
        pbBus3.Size = New Size(312, 23)
        pbBus3.TabIndex = 6
        ' 
        ' lblEstado1
        ' 
        lblEstado1.AutoSize = True
        lblEstado1.Enabled = False
        lblEstado1.Location = New Point(362, 109)
        lblEstado1.Margin = New Padding(2, 0, 2, 0)
        lblEstado1.Name = "lblEstado1"
        lblEstado1.Size = New Size(172, 19)
        lblEstado1.TabIndex = 7
        lblEstado1.Text = "Background, WaitSleepJoin"
        ' 
        ' lblEstado2
        ' 
        lblEstado2.AutoSize = True
        lblEstado2.Enabled = False
        lblEstado2.Location = New Point(362, 181)
        lblEstado2.Margin = New Padding(2, 0, 2, 0)
        lblEstado2.Name = "lblEstado2"
        lblEstado2.Size = New Size(172, 19)
        lblEstado2.TabIndex = 8
        lblEstado2.Text = "Background, WaitSleepJoin"
        ' 
        ' lblEstado3
        ' 
        lblEstado3.AutoSize = True
        lblEstado3.Enabled = False
        lblEstado3.Location = New Point(362, 262)
        lblEstado3.Margin = New Padding(2, 0, 2, 0)
        lblEstado3.Name = "lblEstado3"
        lblEstado3.Size = New Size(82, 19)
        lblEstado3.TabIndex = 9
        lblEstado3.Text = "Background"
        ' 
        ' lblGanador
        ' 
        lblGanador.AutoSize = True
        lblGanador.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGanador.ForeColor = SystemColors.HotTrack
        lblGanador.Location = New Point(51, 302)
        lblGanador.Margin = New Padding(2, 0, 2, 0)
        lblGanador.Name = "lblGanador"
        lblGanador.Size = New Size(86, 21)
        lblGanador.TabIndex = 10
        lblGanador.Text = "Ganador: "
        lblGanador.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackColor = Color.MediumBlue
        btnIniciar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIniciar.ForeColor = SystemColors.ButtonHighlight
        btnIniciar.Location = New Point(361, 341)
        btnIniciar.Margin = New Padding(2)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(90, 35)
        btnIniciar.TabIndex = 11
        btnIniciar.Text = "Iniciar carrera"
        btnIniciar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.LightCoral
        btnSalir.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = SystemColors.ButtonHighlight
        btnSalir.Location = New Point(456, 341)
        btnSalir.Margin = New Padding(2)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(78, 35)
        btnSalir.TabIndex = 12
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' tmrEstados
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(564, 389)
        Controls.Add(btnSalir)
        Controls.Add(btnIniciar)
        Controls.Add(lblGanador)
        Controls.Add(lblEstado3)
        Controls.Add(lblEstado2)
        Controls.Add(lblEstado1)
        Controls.Add(pbBus3)
        Controls.Add(pbBus2)
        Controls.Add(pbBus1)
        Controls.Add(lblBus3)
        Controls.Add(lblBus2)
        Controls.Add(lblBus1)
        Controls.Add(lblTitulo)
        Font = New Font("Segoe UI", 10F)
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Carrera de Buses Managua - Estelí"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblBus1 As Label
    Friend WithEvents lblBus2 As Label
    Friend WithEvents lblBus3 As Label
    Friend WithEvents pbBus1 As ProgressBar
    Friend WithEvents pbBus2 As ProgressBar
    Friend WithEvents pbBus3 As ProgressBar
    Friend WithEvents lblEstado1 As Label
    Friend WithEvents lblEstado2 As Label
    Friend WithEvents lblEstado3 As Label
    Friend WithEvents lblGanador As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents tmrEstados As Timer

    Private Sub lblGanador_Click(sender As Object, e As EventArgs) Handles lblGanador.Click

    End Sub
End Class

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
        lblTitulo.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.DarkBlue
        lblTitulo.Location = New Point(18, 14)
        lblTitulo.Margin = New Padding(2, 0, 2, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(164, 15)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Managua → Estelí · 150 km"
        ' 
        ' lblBus1
        ' 
        lblBus1.AutoSize = True
        lblBus1.Location = New Point(41, 44)
        lblBus1.Margin = New Padding(2, 0, 2, 0)
        lblBus1.Name = "lblBus1"
        lblBus1.Size = New Size(35, 15)
        lblBus1.TabIndex = 1
        lblBus1.Text = "Bus 1"
        ' 
        ' lblBus2
        ' 
        lblBus2.AutoSize = True
        lblBus2.Location = New Point(41, 101)
        lblBus2.Margin = New Padding(2, 0, 2, 0)
        lblBus2.Name = "lblBus2"
        lblBus2.Size = New Size(35, 15)
        lblBus2.TabIndex = 2
        lblBus2.Text = "Bus 2"
        ' 
        ' lblBus3
        ' 
        lblBus3.AutoSize = True
        lblBus3.Location = New Point(41, 160)
        lblBus3.Margin = New Padding(2, 0, 2, 0)
        lblBus3.Name = "lblBus3"
        lblBus3.Size = New Size(35, 15)
        lblBus3.TabIndex = 3
        lblBus3.Text = "Bus 3"
        ' 
        ' pbBus1
        ' 
        pbBus1.Location = New Point(41, 61)
        pbBus1.Margin = New Padding(2, 2, 2, 2)
        pbBus1.Maximum = 150
        pbBus1.Name = "pbBus1"
        pbBus1.Size = New Size(312, 20)
        pbBus1.TabIndex = 4
        ' 
        ' pbBus2
        ' 
        pbBus2.Location = New Point(41, 118)
        pbBus2.Margin = New Padding(2, 2, 2, 2)
        pbBus2.Maximum = 150
        pbBus2.Name = "pbBus2"
        pbBus2.Size = New Size(312, 20)
        pbBus2.TabIndex = 4
        ' 
        ' pbBus3
        ' 
        pbBus3.Location = New Point(41, 177)
        pbBus3.Margin = New Padding(2, 2, 2, 2)
        pbBus3.Maximum = 150
        pbBus3.Name = "pbBus3"
        pbBus3.Size = New Size(312, 20)
        pbBus3.TabIndex = 6
        ' 
        ' lblEstado1
        ' 
        lblEstado1.AutoSize = True
        lblEstado1.Enabled = False
        lblEstado1.Location = New Point(377, 66)
        lblEstado1.Margin = New Padding(2, 0, 2, 0)
        lblEstado1.Name = "lblEstado1"
        lblEstado1.Size = New Size(150, 15)
        lblEstado1.TabIndex = 7
        lblEstado1.Text = "Background, WaitSleepJoin"
        ' 
        ' lblEstado2
        ' 
        lblEstado2.AutoSize = True
        lblEstado2.Enabled = False
        lblEstado2.Location = New Point(377, 123)
        lblEstado2.Margin = New Padding(2, 0, 2, 0)
        lblEstado2.Name = "lblEstado2"
        lblEstado2.Size = New Size(150, 15)
        lblEstado2.TabIndex = 8
        lblEstado2.Text = "Background, WaitSleepJoin"
        ' 
        ' lblEstado3
        ' 
        lblEstado3.AutoSize = True
        lblEstado3.Enabled = False
        lblEstado3.Location = New Point(377, 182)
        lblEstado3.Margin = New Padding(2, 0, 2, 0)
        lblEstado3.Name = "lblEstado3"
        lblEstado3.Size = New Size(71, 15)
        lblEstado3.TabIndex = 9
        lblEstado3.Text = "Background"
        ' 
        ' lblGanador
        ' 
        lblGanador.AutoSize = True
        lblGanador.Location = New Point(232, 252)
        lblGanador.Margin = New Padding(2, 0, 2, 0)
        lblGanador.Name = "lblGanador"
        lblGanador.Size = New Size(70, 15)
        lblGanador.TabIndex = 10
        lblGanador.Text = "Ganador: —"
        lblGanador.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackColor = SystemColors.GradientActiveCaption
        btnIniciar.Location = New Point(361, 301)
        btnIniciar.Margin = New Padding(2, 2, 2, 2)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(90, 31)
        btnIniciar.TabIndex = 11
        btnIniciar.Text = "Iniciar carrera"
        btnIniciar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.LightCoral
        btnSalir.Location = New Point(456, 301)
        btnSalir.Margin = New Padding(2, 2, 2, 2)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(78, 31)
        btnSalir.TabIndex = 12
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' FrmBuses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 343)
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
        Margin = New Padding(2, 2, 2, 2)
        Name = "FrmBuses"
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

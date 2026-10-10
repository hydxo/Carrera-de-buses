<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuses
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
        ProgressBar2 = New ProgressBar()
        ProgressBar3 = New ProgressBar()
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
        lblTitulo.Location = New Point(26, 23)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(249, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Managua → Estelí · 150 km"
        ' 
        ' lblBus1
        ' 
        lblBus1.AutoSize = True
        lblBus1.Location = New Point(58, 73)
        lblBus1.Name = "lblBus1"
        lblBus1.Size = New Size(55, 25)
        lblBus1.TabIndex = 1
        lblBus1.Text = "Bus 1"
        ' 
        ' lblBus2
        ' 
        lblBus2.AutoSize = True
        lblBus2.Location = New Point(58, 168)
        lblBus2.Name = "lblBus2"
        lblBus2.Size = New Size(55, 25)
        lblBus2.TabIndex = 2
        lblBus2.Text = "Bus 2"
        ' 
        ' lblBus3
        ' 
        lblBus3.AutoSize = True
        lblBus3.Location = New Point(58, 267)
        lblBus3.Name = "lblBus3"
        lblBus3.Size = New Size(55, 25)
        lblBus3.TabIndex = 3
        lblBus3.Text = "Bus 3"
        ' 
        ' pbBus1
        ' 
        pbBus1.Location = New Point(58, 101)
        pbBus1.Maximum = 150
        pbBus1.Name = "pbBus1"
        pbBus1.Size = New Size(445, 34)
        pbBus1.TabIndex = 4
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(58, 196)
        ProgressBar2.Maximum = 150
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(445, 34)
        ProgressBar2.TabIndex = 4
        ' 
        ' ProgressBar3
        ' 
        ProgressBar3.Location = New Point(58, 295)
        ProgressBar3.Maximum = 150
        ProgressBar3.Name = "ProgressBar3"
        ProgressBar3.Size = New Size(445, 34)
        ProgressBar3.TabIndex = 6
        ' 
        ' lblEstado1
        ' 
        lblEstado1.AutoSize = True
        lblEstado1.Enabled = False
        lblEstado1.Location = New Point(538, 110)
        lblEstado1.Name = "lblEstado1"
        lblEstado1.Size = New Size(225, 25)
        lblEstado1.TabIndex = 7
        lblEstado1.Text = "Background, WaitSleepJoin"
        ' 
        ' lblEstado2
        ' 
        lblEstado2.AutoSize = True
        lblEstado2.Enabled = False
        lblEstado2.Location = New Point(538, 205)
        lblEstado2.Name = "lblEstado2"
        lblEstado2.Size = New Size(225, 25)
        lblEstado2.TabIndex = 8
        lblEstado2.Text = "Background, WaitSleepJoin"
        ' 
        ' lblEstado3
        ' 
        lblEstado3.AutoSize = True
        lblEstado3.Enabled = False
        lblEstado3.Location = New Point(538, 304)
        lblEstado3.Name = "lblEstado3"
        lblEstado3.Size = New Size(107, 25)
        lblEstado3.TabIndex = 9
        lblEstado3.Text = "Background"
        ' 
        ' lblGanador
        ' 
        lblGanador.AutoSize = True
        lblGanador.Location = New Point(332, 420)
        lblGanador.Name = "lblGanador"
        lblGanador.Size = New Size(107, 25)
        lblGanador.TabIndex = 10
        lblGanador.Text = "Ganador: —"
        lblGanador.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackColor = SystemColors.GradientActiveCaption
        btnIniciar.Location = New Point(516, 501)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(129, 34)
        btnIniciar.TabIndex = 11
        btnIniciar.Text = "Iniciar carrera"
        btnIniciar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.LightCoral
        btnSalir.Location = New Point(651, 501)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(112, 34)
        btnSalir.TabIndex = 12
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' FrmBuses
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 560)
        Controls.Add(btnSalir)
        Controls.Add(btnIniciar)
        Controls.Add(lblGanador)
        Controls.Add(lblEstado3)
        Controls.Add(lblEstado2)
        Controls.Add(lblEstado1)
        Controls.Add(ProgressBar3)
        Controls.Add(ProgressBar2)
        Controls.Add(pbBus1)
        Controls.Add(lblBus3)
        Controls.Add(lblBus2)
        Controls.Add(lblBus1)
        Controls.Add(lblTitulo)
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
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
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

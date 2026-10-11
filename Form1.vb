Imports System.Threading

Public Class Form1

    ' Variables para controlar los hilos
    Private hilos(2) As Thread
    Private ganador As String = ""
    Private candado As New Object()
    Private cerrando As Boolean = False

    ' ==========================================
    ' BOTON INICIAR CARRERA
    ' ==========================================
    Private Sub btnIniciar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnIniciar.Click

        ' Reiniciar las barras de progreso
        pbBus1.Value = 0
        pbBus2.Value = 0
        pbBus3.Value = 0

        ' Reiniciar los estados
        lblEstado1.Text = "Unstarted"
        lblEstado2.Text = "Unstarted"
        lblEstado3.Text = "Unstarted"

        ' Reiniciar ganador
        SyncLock candado
            ganador = ""
        End SyncLock

        lblGanador.Text = "Ganador: —"

        cerrando = False
        btnIniciar.Enabled = False

        ' Crear los tres hilos
        hilos(0) = New Thread(AddressOf Viajar)
        hilos(0).Name = "Bus 1"
        hilos(0).IsBackground = True

        hilos(1) = New Thread(AddressOf Viajar)
        hilos(1).Name = "Bus 2"
        hilos(1).IsBackground = True

        hilos(2) = New Thread(AddressOf Viajar)
        hilos(2).Name = "Bus 3"
        hilos(2).IsBackground = True

        ' Iniciar el monitor de estados
        tmrEstados.Interval = 100
        tmrEstados.Start()

        ' Iniciar los tres buses
        For Each hilo As Thread In hilos
            hilo.Start()
        Next

    End Sub

    ' ==========================================
    ' METODO QUE EJECUTA CADA BUS
    ' ==========================================
    Private Sub Viajar()

        Dim nombreBus As String =
            Thread.CurrentThread.Name

        Dim aleatorio As New Random(
            Guid.NewGuid().GetHashCode()
        )

        ' Recorrer los 150 kilometros
        For km As Integer = 5 To 150 Step 5

            If cerrando Then Return

            Dim distancia As Integer = km

            Try
                Me.Invoke(
                    New MethodInvoker(
                        Sub()

                            If cerrando Then Return

                            Select Case nombreBus

                                Case "Bus 1"
                                    pbBus1.Value = distancia

                                Case "Bus 2"
                                    pbBus2.Value = distancia

                                Case "Bus 3"
                                    pbBus3.Value = distancia

                            End Select

                        End Sub
                    )
                )

            Catch ex As ObjectDisposedException
                Return

            Catch ex As InvalidOperationException
                Return

            End Try

            ' Simular velocidad diferente para cada bus
            Thread.Sleep(aleatorio.Next(50, 201))

        Next

        ' Registrar el primer bus que termine
        Dim esGanador As Boolean = False

        SyncLock candado

            If ganador = "" Then
                ganador = nombreBus
                esGanador = True
            End If

        End SyncLock

        If esGanador AndAlso Not cerrando Then

            Try
                Me.Invoke(
                    New MethodInvoker(
                        Sub()
                            If Not cerrando Then
                                lblGanador.Text =
                                    "Ganador: " & nombreBus
                            End If
                        End Sub
                    )
                )

            Catch ex As ObjectDisposedException
                Return

            Catch ex As InvalidOperationException
                Return

            End Try

        End If

    End Sub

    ' ==========================================
    ' MONITOREAR LOS ESTADOS DE LOS HILOS
    ' ==========================================
    Private Sub tmrEstados_Tick(
        sender As Object,
        e As EventArgs
    ) Handles tmrEstados.Tick

        Dim etiquetas() As Label = {
            lblEstado1,
            lblEstado2,
            lblEstado3
        }

        Dim todosTerminados As Boolean = True

        For i As Integer = 0 To hilos.Length - 1

            If hilos(i) Is Nothing Then
                todosTerminados = False
                Continue For
            End If

            ' Mostrar el estado actual del hilo
            etiquetas(i).Text =
                hilos(i).ThreadState.ToString()

            If hilos(i).IsAlive Then
                todosTerminados = False
            End If

        Next

        ' Cuando todos terminan, habilitar otra carrera
        If todosTerminados Then

            tmrEstados.Stop()
            btnIniciar.Enabled = True

        End If

    End Sub

    ' ==========================================
    ' BOTON SALIR
    ' ==========================================
    Private Sub btnSalir_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSalir.Click

        Me.Close()

    End Sub

    ' ==========================================
    ' CIERRE DEL FORMULARIO
    ' ==========================================
    Private Sub Form1_FormClosing(
        sender As Object,
        e As FormClosingEventArgs
    ) Handles MyBase.FormClosing

        cerrando = True
        tmrEstados.Stop()

    End Sub

End Class
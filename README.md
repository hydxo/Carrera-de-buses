# Carrera de Buses Managua–Estelí

## Descripción del proyecto

Aplicación desarrollada en Visual Basic .NET que simula una carrera entre tres buses mediante el uso de hilos (threads). El programa permite observar el avance de cada bus mediante barras de progreso y determinar cuál termina primero el recorrido.

## Objetivos

- Comprender el funcionamiento de los hilos.
- Observar los estados de los hilos durante la ejecución.
- Actualizar las barras de progreso de forma segura.
- Mantener la interfaz gráfica receptiva durante la carrera.
- Identificar un único ganador mediante la coordinación de los hilos.

## Tecnologías utilizadas

- Visual Basic .NET
- Windows Forms
- Visual Studio
- Git y GitHub

## Estructura de la documentación

- `docs/bitacora.md`: registro de los experimentos realizados.
- `docs/estados-observados.md`: descripción de los estados de los hilos.

## Ejecución del proyecto

1. Clonar o descargar el repositorio.
2. Abrir la solución del proyecto en Visual Studio.
3. Restaurar las dependencias necesarias.
4. Compilar la solución.
5. Ejecutar la aplicación.
6. Presionar el botón de inicio para observar la carrera de los tres buses.

## Funcionamiento

Cada bus realiza su recorrido mediante un hilo de trabajo independiente. Las barras de progreso muestran el avance de los buses y las actualizaciones de la interfaz se realizan de forma segura desde el hilo de la ventana.

La aplicación coordina la finalización de la carrera para registrar un único ganador.

## Documentación adicional

- [Bitácora de experimentos](docs/bitacora.md)
- [Estados observados](docs/estados-observados.md)

## Integrantes del equipo
Heydi Francellys Centeno Pineda-Hydxo (creadora de hilos)
Bryan Ariel Cardenas Calderon-Ariel.Cardenas reflexo cósmico295 (creacion repositorio)
Marianyeli Rafaela Huete Lira-marianyelihuete (formulario y codigo)
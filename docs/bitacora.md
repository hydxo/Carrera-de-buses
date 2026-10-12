# Bitácora de experimentos
## Proyecto: Carrera de buses Managua–Estelí

### Introducción

Durante el desarrollo del proyecto Carrera de Buses Managua–Estelí se trabajó con hilos en Visual Basic .NET para simular el recorrido de tres buses de manera concurrente. El propósito fue comprender el funcionamiento de los hilos, observar sus estados durante la ejecución y comprobar cómo se puede mantener la interfaz gráfica disponible mientras se realizan operaciones en segundo plano.

### Experimento 1. Ejecución de los tres buses

Se ejecutó la aplicación para observar el comportamiento de los tres buses durante la carrera. Cada bus realiza su recorrido de manera independiente mediante un hilo de trabajo. Esto permite que los buses avancen sin necesidad de ejecutar todo el recorrido de forma secuencial.

### Experimento 2. Comportamiento de la interfaz gráfica

Durante la ejecución se observó la respuesta de la ventana mientras los buses avanzaban. El uso de hilos permite separar el trabajo de la carrera del hilo encargado de la interfaz gráfica. De esta manera, la ventana puede continuar respondiendo a las acciones del usuario mientras se desarrolla el recorrido, siempre que las operaciones se gestionen correctamente.

### Experimento 3. Actualización de las barras de progreso

Se utilizaron barras de progreso para representar visualmente el avance de cada bus. Debido a que los controles de Windows Forms deben actualizarse desde el hilo de la interfaz gráfica, es necesario realizar las actualizaciones de manera segura mediante mecanismos como `Me.Invoke(New MethodInvoker(...))`. Esto permite mostrar el avance sin acceder directamente a los controles desde los hilos de trabajo.

### Experimento 4. Observación de los estados de los hilos

Durante la ejecución se consideró el uso de la propiedad `ThreadState` para observar los estados de los hilos. Estos estados permiten conocer si un hilo está ejecutándose, esperando, suspendido temporalmente por una operación de espera o si ya terminó su trabajo. La observación de los estados ayuda a comprender el comportamiento de los hilos durante las diferentes etapas de la carrera.

### Experimento 5. Pausas y finalización del recorrido

Se consideró el efecto de las pausas durante el recorrido de los buses. Una operación como `Thread.Sleep` permite que un hilo espere durante un tiempo determinado antes de continuar su ejecución. Durante determinadas esperas, el hilo puede presentar el estado `WaitSleepJoin`. Cuando termina el trabajo asignado, el hilo deja de ejecutarse y alcanza el estado `Stopped`.

### Experimento 6. Determinación del ganador

La carrera debe finalizar identificando un único bus ganador. Para conseguirlo, es necesario coordinar los hilos y proteger la operación que registra al primer bus que termina. El uso de un mecanismo de sincronización, como `SyncLock`, permite evitar que varios hilos registren simultáneamente resultados contradictorios. Así, el resultado final puede mostrar un solo ganador.

### Conclusión

El desarrollo de la carrera permitió estudiar la ejecución concurrente mediante hilos en Visual Basic .NET y comprender la importancia de la sincronización al trabajar con varios procesos al mismo tiempo. También permitió reconocer la necesidad de actualizar los controles gráficos de manera segura y observar los estados de los hilos durante su ejecución. Estos conocimientos contribuyen a desarrollar aplicaciones que mantienen una interfaz gráfica receptiva y gestionan correctamente las tareas concurrentes.
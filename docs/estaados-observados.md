# Estados observados de los hilos

## Proyecto: Carrera de buses Managua–Estelí

### Introducción

Durante la ejecución del proyecto se utiliza la propiedad `ThreadState` de Visual Basic .NET para identificar los estados en los que pueden encontrarse los hilos encargados del recorrido de los buses.

### 1. Unstarted

Indica que el hilo ha sido creado, pero todavía no ha comenzado su ejecución mediante el método `Start()`.

### 2. Running

Indica que el hilo está listo para ejecutarse o se encuentra ejecutando instrucciones. Este estado permite identificar que el hilo participa activamente en el trabajo de la carrera.

### 3. WaitSleepJoin

Indica que el hilo está esperando debido a una operación como `Sleep()`, `Join()` o una espera de sincronización. Durante este estado, el hilo no continúa con su trabajo habitual hasta que termina la espera correspondiente.

### 4. Stopped

Indica que el hilo ha finalizado su ejecución. En el proyecto, este estado puede observarse cuando un bus termina el recorrido y su hilo deja de ejecutar instrucciones.

### 5. AbortRequested

Indica que se ha solicitado la finalización de un hilo mediante mecanismos de interrupción antiguos. Este estado está obsoleto en las versiones modernas de .NET y no debe utilizarse como mecanismo habitual para detener hilos.

### 6. Background

Indica que el hilo está configurado como hilo en segundo plano mediante la propiedad `IsBackground`. Los hilos de segundo plano no impiden que finalice el proceso cuando ya no quedan hilos principales activos.

### Conclusión

La propiedad `ThreadState` permite observar diferentes situaciones durante la ejecución de los hilos. Comprender estos estados facilita el análisis de la concurrencia y ayuda a interpretar el comportamiento de los buses durante la carrera.
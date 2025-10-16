# Notas del parche versión 3.0.0

Esta actualización presenta cambios importantes en el funcionamiento de la aplicación así como cambios importantes en el manejo de las cuentas pro cobrar así como el arreglo de errores varios en el sistema para mejorar su estabilidad de gran forma. Además en esta versión se hizo un amigración extremadamente importante en relación con el proceso de actualización de la aplicación pasando del uso de Squirrel el cual es bastante antiguo a Velopack que es un paquete similar pero mucho más modernos y versatil para este propósito, siendo este el principal cambio realizado y el porque de esta versión

## Nuevo

### General
- Mejora en la documentación del reporistorio de git #34: Se mejoró de gran forma el README.md del proyecto con información mucho más precisa de las capacidades del proyecto así como se añadieron distintos badges para mostrar el estado y requierimientos del proyecto
- Se añadió el archivo de licencia del proyecto para especificar de mejor forma las formas de utilizar el proyecto, cualquier consulta comunicarse conmigo al correo específicado en este.
- Se añadió un archivo donde se verá de mejor forma las notas del parche más reciente dentro del proyecto
- Implementación de CI/CD por medio de github actions para facilitar el proceso de lanzamiento de actualizaciones

### Migraciones
- Se agregaron nuevas tablas en la base de datos para el manejo de las cuentas por cobrar

### Inicialización
- Se agregó una pestaña de inicialización mientras se ejecutan las acciones de preparaciónde al aplicación, esto con el fin de que se sepa siempre que tareas está ejecutando la aplicación al iniciarse
- Ahora en la pestaña de inicialización también se mostrará el nombre de la versión en la que se está actualmente

### Actualizaciones
- Ahora en caso de que se tengan activadas las actualizaciones automáticas al inciar la aplicación o si se buscan nuevas versiones desde la aplicación, si se detecta una nueva versión aparecerá un dialogo que mostrará las notas de los cambios realizados seguido de 2 botones uno para actualizar y reiniciar la aplicación y otro para cancelar la actualización
- Ahora al detectar una nueva versión el sistema además de mostrar la pestaña con las notas del parche mostará también el progreso de la actualización

### Cuentas por cobrar
- Se realizó un cambio completo del funcionamiento de las cuentas por cobrar para poder hacer mucho más robustas y útiles sus funciones
- Se modificó visualmente la pestaña de visualización de las cuentas por cobrar haciendo que esta ahora esté maximizada y que sus componentes se adapten al tamaño de una mejor manera
- Ahora los recueadros con las cuentas por cobrar mostrarán el saldo pendiente por pagar en la cuenta
- Al presionar el botón de "Detalles" en los recuadros de las cuentas por cobrar hará que se muestre una nueva pestaña con la información compelta de esta cuenta, mostrando los abonos realizados, los productos que esta tiene, el saldo pendiente, el cliente, el total de la venta y más.
- Se agregó la funcionalidad de un sistema de caja único para las cuentas por cobrar, en este se puede actualizar los datos de la cuenta (Como el comentario o el cliente que la identifican y productos y sus cantidades), abonar un monto al saldo restante de la cuenta para poder pagarla por tractos, o, en todo caso, para poder terminar de pagar la cuenta en su totalidad
- Se agregó un mensaje de confirmación al momento de terminar exitosamente de guardar la cuenta por cobrar
- Las cuentas por cobrar pueden ser filtradas dependiendo de su estado: Inactivo, activo, cobrada o mostrar todas, en este caso los estados de activo e inactivo se puede modificar simplemente presionando el botón de "Activar/Desactivar", mientras que el estado de cobrada solo sucede cuando el valor de los abonos hechos a la cuenta supero al total de esta
- Se agregó en la parte inferior de la pestaña de vista de la cuentas por cobrar indicadores con los colores de encabezado que tienen cada uno de los estados de las cuentas por cobrar siendo, verde= activas, rojas= inactivas, y naranja= cobrada
- Al abonar a una cuenta ahora se puede imprimir la factura de este abono mostrando principalmente en este el saldo restante para pagar la cuenta

### Logging
- Se implementó un robusto sistema de logging dentro de la aplicación, este crea un archivo de logs el cual se puede acceder revisando la carpeta de appData/Roaming de la aplicación.
- Estos archivos de log son importantes principalmente la el debuggin, la busqueda de errores y análisis de patrones de uso de los usuario para mejorar el desarrollo de la aplicación.

### Cierres de caja
- Ahora a la hora de hacer los cierres también se tomarán en cuenta las entradas de efectivo que suceden por medio de abonos a cuentas por cobrar, a excepción de las cuentas que ya están como cobradas las cuales se toman directamente como una venta normal en el sistema

### Configuraciones
- Se agregó código para agregar a futuro la función de ver la lista de cambios y para ver el c´dogio fuente dentro de la aplicación.

## BugFix

### Generales
- Se modificó el momento en el que se cargan los productos en la pestaña de consulta de productos para tratar de hacer que se la apertura de la pestaña no sea tan lenta
- Se agregaron nuevos mensajes de errores es más sitios de la aplicación donde eran necesarios
- Se agregron mejores formatos en algunas de las tablas del sistema para mejorar su legibilidad y compresión

### Caja
- Mejoras varias en el manejo de los procesos en la caja
- Se arregló un error en el que al presionar modificar en un producto de la lista de productos de la caja, los datos de este no se cargaban de forma correcta en el dialogo de busqueda
- Se arregló un error en el dialogo de busuqueda de productos en el que si se cambiaba el producto que se estaba editando este dada un error fatal
- Ahora los campos donde se ingresan el dinero que entrega el cliente en la pestaña de terminar venta son numericos, por lo que nos evitamos errores de formatos incorrectos, estos tiene un monto máximo de 1.000.000.000 por lo que hay campo de trabajo suficiente para cualquier tipo de venta común
- Se arregló un error en la caja en el que al momento de que solo hubiera un producto en la tabla este no permitía terminar la venta o guardar la cuenta
- Se arregló un error en el que aunque cancelaras la venta en la caja esta se registraba igualmente
- Se arregló un error en el que al buscar un cliente se cargaba la información incirrecta en vez del nombre

### Impresiónes
- Se modificó el formato de creación de la factura para eliminar un guión extra que hacía un salto de linea que no debía de haber en la factura
- Se arregló un error en el que no se borraban de forma correcta los valores de los habladores impresos anteriormente y se reflejaban en la proxima vez que se imprimieran los habladores
- Se arregló un error al imprimir un abono en el que se mostraba una linea de Total de cuenta la cual no debería de estarse imprimiendo
- Se arregló un error de formato en las facturas de ventas en el que el pago en tarjeta tenía su valor desalineado

### Reportes
- Se arregló un error en donde la listade los movimientos realizados en la vista de detalles de arqueos de caja pasados no cargaba correctamente por errores en la consulta de la base de datos

### Cierre de caja
- Se mejoró el manejo y la eficiencia de los calculos del saldo tanto en los formularios de apertura como de cierre de caja
- A la hora de hacer el cierre y que se abra de forma directa la apertura de caja el saldo con el que se cerró se carga de forma automática en la pestaña de apertura para facilitar este proceso

### Actualizaciones / Desisntalación
- Se arregló un error en el que no se revisaba de forma correcta el valor de la configuración de las actualizaciones automáticas
- Ahora al desisntalar la aplicación se eliminara el archivo de configuración y la base de datos, pero los archivos generados por el usuario como los Logs, reportes y respaldos de la base de datos se mantendran en esa carpeta para evitar la eliminación de los datos

### Cuentas por cobrar
- Se arregló un error en el que al ver los detalles de cualquier factura no se veía el nombre del cajero que realizó la venta
- Se arregló un error que sucedía cuando no se podía cargar correctamente los detalles de la cuenta por cobrar debido a que alguno de los datos numéricos es nulo
- Se arregló un error en el que al momento de terminar de hacer un pago completo de una cuenta por cobrar con un monto mayor al restante, al ver la cuenta nuevamente desde la lista de cuentas ya cobradas el valor restante aparecía en negativo, ahora ya se muestra en 0 de forma correcta
- Se arregló un error en el que al terminar una cuenta por cobrar abonando más de lo que quedaba de saldo el valor del saldo restante se quedaba en negativo en la base de datos, ya se guarda en estos casos el valor en 0 correctamente
- Se arregló un error en el que se podía volver a entrar a la caja de las cuentas por cobrar que ya estaban como cobradas en el sistema, ahora estas facturas ya cobradas no pueden ser modificadas de ninguna forma
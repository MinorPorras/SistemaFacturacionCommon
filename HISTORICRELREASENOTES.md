# Notas del parche versión 3.0.4 (28 de oct de 2025)

Esta actualización busca resolver algunos problemas identificados anteriormente en varias partes de la aplicación, presentando mejoras de vida en la finalización de la venta, en la consulta de productos y más.

# BugFix
## Abonar o terminar venta
Closes #78 
- Se homogenizaron los procesos de las pestañs de terminar venta para que funcionen de la misma forma  los calculos y las acciones
- Ahora al cambiar de tipo de venta en las pestañas de abonar o terminar venta el texto se selecciona automáticamente para poder cambiarlo sin tener que selecionar el texto completamente de forma manual
- Ahora al entrar a las pestañas de abonar o terminar venta se coloca automáticamente el monto total de la venta para simplemente presionar el botón de terminar venta o f7 en ese caso

## Movimientos en cierres de caja
Closes #79
- Se arregló un error en el que si se agregaba un solo un cierre o una sola salida el sistema se caía al no detectar información del otro movimiento, ahora ya se maneja corretcamente

## Cierre de sesión
Closes #75
- Se arregló un error en el que al presionar el botón de cerrar sesión en el menú principal la aplicación se cerraba y no cerraba sesión correctamente

## Mantenimiento de productos
- Closes #77: Se arregló un error en el que al terminar de guardar un producto nuevo la pestaña no se cerraba correctamente y se mantenía abierta sin la posibilidad de cerrarla de formas normales
- Closes #76: Ahora al regresar de las pestañas de agregar o modificar los productos se seleccionará de forma automática todo el texto de la caja de texto de busqueda de productos para poder agregar directamente el siguiente
     
# Notas del parche versión 3.0.3 (20 de oct de 2025)

Esta actualización busca resolver algunos problemas identificados anteriormente en varias partes de la aplicación

## Nuevo
Closes #70
- Se agregó un nuevo filtro en la pestaña de consulta de productos, esta ahora ter permite limitar la cantidad de productos que se cargan buscando hacer que estos se carguen de forma más rápido resolviendo el problema de la duración inicial de carga al ingresar a la pestaña de consulta (Este cambio tambipen aplica para la pestaña de busqueda de productos de la caja)

## BugFix

### 1. Terminar venta
Closes #69
- Se revirtió el cambio del la caja de texto numericas a como estaba antes, ahora estas muestran en tiempo real el valor del vuelto sin necesitar de presionar nada y además ya evitan totalmente el ingreso de cualquier tipo de caracter que no sea numérico
- Se mejoró la eficiencia y robustes de los procesos de calculo de vueltos y restantes en la pestaña de terminar venta

### 2. Reimpresión de facturas
Closes #68
- Se arregló un error en el que al presionar el botón de "Reimprimir más reciente" en la pestaña de reimpresiones se mostraba un error y no se podía imprimir
- Se arregló un error relacionado a la selección de la fila con la factura a imprimir en el que a veces al selecionar la primer fila esta no se imprimía correctamente
- Se eliminó el preview que se generaba al terminar la factura ya que en producción no se consideró necesario ya que este se imprimiría en todo caso

### 3. Actualizaciones de la aplicación
Closes #73
- Se arregló un error en el que no se señalizaba de forma correcta que ya se estaba comenzando con el proceso de actualizaicón de la aplicación al buscar versiones nuevas desde la pestaña de configuración
- Se arregló un error que impedía el funcionamiento correcto de las actualizaciones automáticas

# Notas del parche versión 3.0.2 (19 de oct de 2025)

Esta actualización busca resolver 2 erorres bastante molestos y problemáticos con la aplicación despues de las versiones anteriores

## BugFix
- Se arregló un error en la caja en el que al buscar un producto se colocaba por defecto el valor de 0, lo cual era incorrecto, ahora ya muestra el número 1 correctamente
- Se arregló un error en el que en el momento en el que se preionaba el botón de regresar en la pestaña de ver datos de las factura se cerraba la aplicación por error

# Notas del parche versión 3.0.1 (16 de oct de 2025)

Esta actualización presenta mejorar y bugfix importantes en el funcionamiento de la aplicación, principalmente en el manejo de la instancia única de la aplicación, su cierre ya la conexión con el servidor de git

## Nuevo

### Configuraciones
- Se agregaron 2 botones en la pestaña de información de las configuraciones, uno te permite ver la lista de cambios de las actualizaciones, principalmente de la más reciente, desde el directorio de git del proyecto, mientras que el botón que dice "Código fuente" te redirige al repositorio de github en el navegador
## BugFix

### Generales
- Se arregló un error en ran parte de las pestañas que provocaba que la aplicación no se cerrara de forma correcta y quedara trabajando en segundo plano, ahora al presionar cualquier botón que cierre la aplicación por completo esta ya se cerrará de forma correcta, impidiendo así que en condiciones normales haya problemas con la instancia única de la aplicación.
- Se arregló el título en la pestaña de cierre de caja

# Notas del parche versión 3.0.0 (16 de oct de 2025)

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


# **Versión 2.2.1.0 (18 de marzo de 2025)**
- Se agregó la función de la generación de reportes. Para acceder a ellos solo se presiona el botón "Reportes" en el menu principal y, de momento la función está implementada de forma rápida y solo permite calcular las ventas totales en un intervalo de 2 fechas, en el futuro se planean mostrar gráficos, promedios y incluso generar exportaciones a pdf de lo generado.

# **Versión 2.2.0.1 (28 de enero 2025)**
- Se modificó el código para la creación de los habladores con el fin de tratar de evitar que al imprimir 8 o más habladores la impresora no se detenía e imprimía infinitamente los habladores, además ahora la línea divisora se ajusto para evitar el desperdicio innecesario del papel, por lo que ahora tanto al inicio como al final de la impresión no se agrega una línea divisora extra innecesaria
- Al regresar de cualquier manera a la caja, la caja de texto de buscar producto se selecciona por defecto
- Se corrigieron errores ortográficos en el sistema y en este archivo

# **Versión 2.2 (3 de enero de 2025)**
- Ahora al cancelar la impresión de los habladores se mantienen los productos de los que se quería imprimir el hablador en la tabla, anteriormente estos eran eliminados
- Anteriormente luego de agregar un producto con precio variable en la caja utilizando la búsqueda de productos en este no se mostraba correctamente la pestaña donde se ingresa el precio bajo el que se venderá el producto
- Ahor al terminar la venta o al regresar de esta pestaña a la caja se mantendrá correctamente seleccionado la caja de texto de productos
- Se cambió el texto del botón con el cual se entra en la pestaña para reimprimir facturas pasadas y ahora además de reimprimirlas se puede ver la información de la factura sin tener que reimprimirlas
- Se modificó toda la interfaz, principalmente los botones y la distribución de ciertas pestañas, implementando con esto en la caja una forma de que se adapte al tamaño de la pantalla en la que se está mostrando
- Se arregló un error que se producía al modificar productos ya agregados en la caja, en el que al presionar el botón de modificar los datos de este no eran correctamente enviados a la pestaña donde se modificaba

# **Versión 2.1 (2 de enero de 2025)**
Feliz año esto es lo que trae la nueva actualización
- Ahora en las configuraciones se puede personalizar el tamaño de la fuente de los precios y productos de los habladores
- Se agregó el botón de configuraciones desde más pestañas, principalmente las de mantenimiento para poder modificar los códigos automáticos y en la pestaña de los habladores para entrar específicamente a sus configuraciones
- Se cambió el texto en el botón con el que se cambia la carpeta en el que se guardan los respaldos desde las configuraciones
- Se agregaron los atajos del teclado de la pestaña de habladores
- Las tablas de los pedidos de los proveedores de la pestaña de inicio ahora se ven de la misma forma
- Ahora al buscar productos se puede activar un filtro que te permite ver los productos que más recientemente se ha agregado, por lo que en la base de datos igualmente se ha agregado una fila nueva en la base de datos para almacenar este espacio

# **Versión 2.0.0.3 (28 de diciembre de 2024)**
- Se cambió el motor de base de datos de Microsoft Access a SQLite y se hicieron los cambios pertinentes en el código para que funcione correctamente la migración
- Se simplificó el proceso de muestra de cajas de texto con mensaje e información
- Se aceleró el proceso de guardado de las ventas al presionar el botón de terminar haciendo que todos los datos se guarden junto al mismo tiempo
- Se agregó un botón de terminar e imprimir aparte del de terminar venta, ahora si se desea imprimir la factura se presiona este botón, el que se utilizaba antes ya no pregunta si se desea imprimir, solo termina automáticamente y muestra una caja de texto con el vuelto a entregar
- Se quitaron mensajes innecesarios dentro del código
- Se eliminó la barra de progreso del botón de agregar producto ya que no funcionaba como se quería, ahora al comenzar el proceso de guardado apara un símbolo de carga hasta que se muestra el mensaje de que se guardó todo
- Ahora al buscar productos se puede hacer un doble click sobre las cajas de texto de búsqueda de categorías, proveedores y marcas para entrar en las pestañas de búsqueda específicas de estas para encontrar más fácilmente lo que se necesite
- Ahora al regresar o moverte entre pestañas, el programa se asegura de que se muestre al frente la pestaña a la que se está entrando, esto para evitar que si hay más aplicaciones abiertas alguna pestaña quede detrás de otras
- Se modifico el como se ve la pestaña de configuración general, ahora está dividida en pestañas entre las que de momento está la de gestión de base de datos que el la que ya estaba ingresada y la de códigos automáticos, en esta se coloca el número de dígitos que quieres que tengan los código creados automáticamente
- Se modificaron los colores de los botones por los cuales te mueves entre pestañas de terminar venta y de la configuraciones
- En conjunto con al pestaña de configuraciones se agregó la función para crear código automáticamente, para hacerlo primero se debe de configurar el número de dígitos del código, luego al crear o modificar cualquier cosa en la pestaña de mantenimiento se tiene un botón verde con un "+" junto a la caja de texto del código, con solo presionarlo este debe de buscar el próximo código en la base de datos que no esté utilizado creándolo con el número de dígitos ingresado
- Se corrigió un error que hacia que al no colocar ningún comentario en una factura que se quería imprimir, al hacerlo esta se imprimía con el comentario de la última factura de la cual se hubiera registrado un comentario

# **Versión 1.2.0.1 27 de noviembre de 2024**
- Ahora se puede filtrar las facturas a reimprimir para que muestre solo, la últimas 50 (por defecto activado para que cargue más rápido), las ultimas 100 o 200 o que las muestre todas
- Se arregló un error que sucedía cuando después de seleccionar un producto con precio variable no se cargaba correctamente la pestaña para agregar su precio
- Se agregó el nuevo estilo de los menús contextuales ala pestaña de agregar o modificar pedidos en el apartado de mantenimiento de proveedores cuando se agrega o se modifica un proveedor
- Se arregló un error en la pestaña de productos en la cual al escribir en los filtro se seleccionaba automáticamente la caja de texto de buscar principal cada vez que se escribía una letra
- Se arregló un error a la hora de almacenar los comentarios de la factura en la base de datos ya que este se guardaba solo si estaba vacía la caja de texto en vez de lo contrario
- Mejoras en la calidad de vida de la app

# **Version 1.2.0.0 26 de noviembre de 2024**
- Ya se puede agregar existencias de cada producto en la pestaña de mantenimiento, al terminar una venta se resta a estas existencias la cantidad que se vendió, las existencias pueden ser negativas en caso de que se venda más de lo que se tiene registrado y va desde un rango de -1000 hasta 1000000 unidades
- Se pueden crear habladores en la pestaña de mantenimiento de productos, únicamente se debe de seleccionar los productos que se quieran imprimir, la cantidad de habladores por producto y presionar el botón de imprimir}
- Se añadieron iconos y se cambio el formato levemente de los menus contextuales de las pestañas de mantenimiento para que sean más visibles
- La caja de texto que muestra el total de la venta en la caja ahora es mas grande y está en negrita para que sea más visible en pantallas pequeñas  

# **Versión 1.1.0.6 (25 de noviembre de 2024)**
- Al entrar en la caja se mantiene seleccionado la caja de texto de buscar producto
- Al fallar la contraseña ahora se mantiene la selección de la caja de texto para escribir la contraseña
- Las facturas ya deberían de mostrar correctamente toda la dirección de la sucursal
- Se arregló un error que hacia que al cancelar los cambios al modificar cualquier cosa en la app mostraba el error como si el producto fuera nuevo
- Ya funciona la tecla de esc en la pestaña de nuevo producto
- En todas las pestañas de agregar, modificar y de buscar ahora si se equivocan escribiendo un código que ya existe, lo selecciona todo para escribirlo de nuevo
- Se arregló un error con los hilos de la app que hacía que a la hora de hacer ciertas acciones en específicas no cargaba correctamente el menu contextual con los botones de eliminar y modificar en las pestañas de mantenimiento
- Se aseguró que todas las listas se cargaran ordenadas por código
- Mejoras de la calidad de vida general de la app
- Ahora al terminar cualquier proceso se mantiene el objeto seleccionado anteriormente en la tabla, funciona en todos menos en las pestañas de búsqueda


# **Versión 1.1.0.5 (23 de noviembre de 2024)**
- La caja de advertencia a la hora de confirmar que se quiere cerrar la app en la pestaña de selección de usuario al iniciar la app ahora da la opción de cancelarlo y que no se cierre la app
- Se mejoró el proceso de búsqueda de todas las pestañas que lo ocupaban y de el de las tablas de los pedidos de los proveedores
- Ahora al buscar marcas y luego de fallar una vez la contraseña en el login se va a mantener seleccionado la caja de texto en la que se estaba escribiendo
- Se arregló un error con el query para cargar las categorías que impedía entrar a esta pestaña del mantenimiento luego de actualizar la app a la BETA
- Se añadieron los atajos del teclado que faltaban, entre ellos los de la pestaña de terminar venta de f7 y f3
- Se añadieron indices en la base de datos y un espacio para agregar el inventario disponible en la tabla en la que se guardan los productos mas aun no se va a implementar este sistema

# **Versión 1.1.0.5 BETA (22 de noviembre de 2024)**
- Se mejoró el proceso de carga de la tabla de productos para que sea mucho más rápida, por medio del uso de hilos y de un termporiador para que se actualize la tabla cuando termines de escribir
- Existen varios errores aún por arreglar y esta versión no es estable en lo más mínimo, tan solo es una prueba

# **Versión 1.1.0.4 (20 de noviembre de 2024)**
- Se arregló un error que se generaba al entrar a la pestaña de buscar productos en la caja si le dabas doble click a la caja de texto de buscar producto
- Se Eliminó el filtro de búsqueda por nombre y por código de todas las pestañas de búsqueda y mantenimiento, ahora la misma caja de texto hace ambos funciones, lo que aceleró un poco el proceso de búsqueda de la app

# **Versión 1.1.0.3 (18 de noviembre de 2024)**
- Se arregló un error que sucedía al acceder a la caja y regresar a la pestaña de inicio causando que se perdiera el usuario en el camino
- Se agregó un espacio que faltaba en la factura de pago mixto entre el pago en efectivo y el pago en tarjeta
- Se disminuyó el tamaño del texto en el data grid view de fechas de pedidos de los proveedores en la pestaña principal
- Se corrigió un error de guardado que impedía la modificación de los datos de los cajeros luego de crearlos
- Se corrigió un error en el que no se almacenaba correctamente el precio de un producto al crearse por primera vez
- Se corrigió un error donde al modificar un producto y quitar la marca  la que pertenecía antes esta no se eliminaba al guardar los cambios
- Ya se puede modificar correctamente los datos de los productos con precios variables, mas a estos no se les puede cambiar el precio al agregarlos, al menos no de momento
- Se arregló un error que se producía al modificar productos en la versión anterior en el cual luego de entrar no se podía actualizar la tabla de búsqueda
- Se arregló un error donde al imprimir una factura que incluyera un producto variable el precio que se colocó de este no se reflejaba correctamente en esta factura
- El botón del menu contextual en la pestaña de reimprimir factura que permite reimprimir la factura que se desee antes imprimía de vez en cuando los valores incorrectos, ya se corrigió el código para que siempre imprima correctamente
- Se arregló un error que sucedía al eliminar una fila a la hora de agregar o modificar los días de pedidos de los proveedores, si eliminaban una fila esta no se eliminaba correctamente y producía que uno de los 2 datos permaneciera haciendo que no se pudiera volver a entrar a modificar el proveedor y que se rompiera las tablas de pedidos del menu de inicio


# **Versión 1.1.0.2 (17 de noviembre de 2024)**
- Se revisó el funcionamiento de las configuraciones, ahora se necesita reiniciar la app para que los valores nuevos se carguen
- Se quitó el botón de regresar en la pestaña de selección de usuarios ya que no debía de estar ahí y se agregó el de cerrar la app
- Se modifico la ruta a la que iba el botón de regresar de la caja para que ahora vuelva correctamente al menu de inicio

# **Versión 1.1.0.1 (16 de noviembre de 2024)**
- Ahora al crear cajeros se puede definir su rol, ya sea Administrador o cajero, el cajero tiene restringido el acceso a los reportes, al mantenimiento y a las configuraciones, mientras que el administrador puede acceder a todo el sistema, luego se añadirán más tipos de perfiles
- Con el cambio anterior ahora al entrar a la aplicación se te pedirá iniciar sesión con una cuenta y se te habilitarán las opciones dependiendo del rol que tenga asignado tu cuenta
- Se cambió el nombre del botón de exportar base de datos por el de respaldar base de datos para que se entienda mejor su función
- Se arregló un error donde en la caja de texto de teléfono a la hora de guardar los cambios hechos a un proveedor este no se eliminaba y los datos se quedaban ahí
- Se arregló un error donde al seguir una serie de pasos las listas se cargaban con un orden incorrecto en las pestañas de mantenimiento y de búsqueda
- Se corrigió un error que provocaba que no se pudiera eliminar un producto en la pestaña de mantenimiento
- Se arreglaron errores a la hora de modificar productos, ya que antes en caso de querer quitar la descripción, marca, categoría o proveedor, estos no se quitaban correctamente en la base de datos
- Se arreglaron ciertos errores que produjo el cambio de las listas a la hora de modificar los productos en la caja
- Ahora al imprimir una factura si se pagó con el método de pago mixto en la factura se verá reflejado lo que pagó en efectivo y en tarjeta por aparte
- Se volvieron a corregir errores en el botón de imprimir más reciente, ahora si de verdad debería de funcionar bien

# **Versión 1.1.0.0 (16 de noviembre de 2024)**
- Se modifico el formato de todas las listas para que sean más agradables a la vista y además ahora son mucho más eficientes y ya se pueden acomodar de menor a mayor y viceversa por cada una de las columnas (Se pasaron todas y sus procesos relacionados de un List view a Data grid view)
- Se removió el botón de cerrar la aplicación en la pestaña de mantenimiento de productos por problemas con los atajos del teclado
- Se corrigieron varios errores relacionados con la búsqueda de productos donde dependiendo de los filtros que se usaban no se mostraba la información
- Se corrigió un error en las eliminaciones de proveedores donde estos no se podían eliminar correctamente si estaban relacionados con algún producto, ahora tiene el mismo proceso que con las marcas y las categorías, donde estas se, eliminan de los productos también

# **Version 1.0.0.12 (14 de noviembre de 2024)**
- Se modificó el color de la pestaña para agregar a la caja los producto variables para que sea más visible y se arreglaron problemas donde esta no se cerraba al terminar el proceso
- Creo que ahora si resolví el problema con el botón de imprimir más reciente y ya funciona correctamente, además en la lista de facturas ahora la más reciente también es la que aparece en la parte de más arriba


# **Versión 1.0.0.11 (14 de noviembre de 2024)**
- Ahora se pueden crear productos con precios variables, este tipo de productos al pasarlo por la caja muestran un pestaña en la cual además de mostrar la info del producto, te permite colocar el precio que desees para ese tipo de productos que se vende por kilo y demás. En este caso no se almacena ningún impuesto, ganancia o precio de venta, únicamente el precio base
- Había un error en la pestaña de agregar productos en el que a la hora de buscar un impuesto el resultado que te daba luego de escoger uno era incorrecto y estaba relacionado con la categoría en vez de con el impuesto correcto
- Ahora la crear o modificar un proveedor en el sistema el teclado para escribir se fija en la caja de texto del código en vez de la del nombre como estaba antes

# **Versión 1.0.0.10 (12 de noviembre de 2024)**
- Se cambio el formato de la lista de los productos en caja, ahora tiene un formato un poco más trabajado (se pasó de un list view a un datagrid), este cambio se hará en un futuro a todas las demás listas del sistema
- Junto con el cambio anterior ahora en la tabla de los productos en caja se puede  modificar el valor de la cantidad y se actualizan los valores correctamente
- Ahora al darle click a los filtros de buscar por nombre o código estos te colocan de una vez en la caja de texto para que escribas tu búsqueda, al igual que con los otros filtros del productos
- Se ajustaron los textos de los placeholders de algunas cajas de texto puesto que habían varias con leyendas incorrectas
- El botón de imprimir mas reciente debería de funcionar correctamente ahora
- Se corrigieron errores en donde al presionar enter en las pestañas de modificar y agregar en el mantenimiento se guardaban los datos como estuvieran en el momento sin importar que le faltara información necesaria, ahora el mismo botón también hace una última verificación antes de guardar la información
- Todas las listas del mantenimiento se acomodan por defecto por código de menor a mayor, en un futuro se podrá acomodar de muchas otras formas con los demás atributos de cada parte del mantenimiento.

# **Versión 1.0.0.9 (11 de noviembre de 2024)**
- Ahora el botón de inicio de sesión siempre está habilitado para las cuentas de cajero sin contraseña
- Los diálogos para abrir los archivos para modificar el directorio y modificar la conexión con la base de datos muestran lo que está seleccionado actualmente
- Se corrigió un error en el que no se podía guardar correctamente los colores de los cajeros al modificarlos
- Se corrigió un error a la hora de modificar los proveedores ya que al eliminar los datos del correo o el teléfono estos no eran correctamente eliminados de la base de datos
- Se agregaron dos botones a la pestaña de pago mixto en la pestaña de terminar venta, estos colocan en la caja de texto junto a la que están el monto restante para realizar la compra
- Ahora la pestaña de pedidos de los proveedores ya se puede usar la tecla esc para regresar
- Se corrigió el error que sucedía cuando se escaneaba un código de barras, ya que este presionaba la tecla enter y hacía un acción en el programa, como enviar un archivo vacío a la caja o entrar a la pestaña de agregar producto cuando no debía de hacerlo
- Se corrigió un error donde no se eliminaban correctamente de la base de datos los valores de la marca, categoría, proveedor y descripción de los productos por problemas con los atributos de entre estos
- Ahora cuando se cancela la modificación o agregación de un producto se reinicia la barra de progreso, anteriormente no lo hacía y se seguía incrementando hasta fallar
- En la caja ya funcionan los atajos del teclado desde el f1-f8, a excepción del f2 que por alguna razón no lo hace

# **Versión 1.0.0.7**
- Se modificó de nuevo el proceso de creación de respaldos y los procesos de la pestaña de configuración general

# **Versión 1.0.0.6**

- Arreglos al apartado de la creación de respaldos
- Se agregaron botones para modificar el directorio donde se guardan los respaldos
- Se agregó un botón para modificar la conexión con la base de datos a otra distinta(Importante que tenga la misma estructura o sino dará errores)
- Se eliminaron procesos de Md_inicialización que no se utilizaron
- Se agregó un par de líneas en el Md_Backup para obtener la conection string que está almacenado en el app config

# **Versión 1.0.0.5**

- Se modifican los iconos de varios de los botones para que esten mejor alineados
- Corrección de errores en la impresión de las facturas
- Bugfix general

# **Versión 1.0.0.4**

- Se añadió la función para poder modificar el directorio en el que se exportan los respaldos de la base de datos
- Se arreglaron problemas en los que los productos no se podían buscar y filtrar por marca, proveedor y categoria a futuro se convertirán en drop downs
- Se arreglaron temas de diseño de la app para dejar todo un poco más uniforme, en la siguiente versión se modificarán lo iconos a unos más estandarizados


- Se modificó el ícono de todas las pestañas al actual y nuevo de la aplicación
- Se colocó un identificador de la versión de la aplicación en el menu de inicio
- Se modificaron los nombres de algunos controles que anteriormente aparecían con nombres incorrectos
- Se agregaron los nombre y títulos de cada una de las pestañas
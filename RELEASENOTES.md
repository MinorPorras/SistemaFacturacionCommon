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
     
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
     
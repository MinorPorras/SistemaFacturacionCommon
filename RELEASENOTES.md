# Notas del parche versión 3.0.10 (29 de ene de 2026)

Esta actualización busca resolver algunos problemas identificados en la sección de reportes y algunas mejoras en la calidad de vida

## Nuevo
- Se agregó un botón en las secciones de reportes que permite colocar de forma automátca los datos del día actual en los campos del rango de fechas.
- Ahora, por defecto, en los reportes de productos el valor por defecto del campo "Cantidad" pasó de 1 a 10, esto para mostrar por defecto los 10 productos más vendidos ya que el valor anterior no tenía sentido práctico

## Bugfix
- Se arregló un error en el que al intentar descargar el pdf de un reporte que tuviera cualquier fecha que no fuera la del día actual provocaba que este se creara en blanco
- Se arregló un error en el que el límite superior del rango de las fechas en los reportes no estaban funcionan correctamente en algunos casos
- Se mejoró el estilado de la tabla donde se muestran los reportes de ventas, la cual ahora se adapta de mejor manera dependiendo del tamaño de la pantalla

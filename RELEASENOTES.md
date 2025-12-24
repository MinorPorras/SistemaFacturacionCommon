# Notas del parche versión 3.0.6 (23 de dic de 2025)

Esta actualización busca resolver algunos problemas identificados en el flujo de trabajao de los arqueos de caja. EN este caso se presentan mejorar sustanciales en el flujo de trabajo de los turnos y una mayor claridad de sus procesos. Además de esto se mejoró la precisión con la que se puede específicar los rangos de tiempo en los reportes

## Nuevo

### Inicio de sesión

- Se modifico la forma de inicio de sesión eliminando la pestaña de selección de usuarios para ahora seleccionarlo directamente en la misma pestaña de login donde se coloca la contraseña agilizando este proceso

### Caja

- Añadido botón de cierre de sesión en caja e indicador de si el turno está o no iniciado.
- Se agregó un indicador debajo del usuario en la caja para saber si el turno se ha iniciado o no correctamente
- Se modificaron los nombres de los botones de la caja para abrir y cerrar la caja a ser llamados inciar y terminar turno para mayor claridad

### Arqueos de caja

- Se mejoró la seguridad de los arqueos de caja haciendo que solo se tomen en cuenta los ventas realizadas pro el usuario durante el tiempo en el que esté vigente su turno, permitiendo que varios usuarios trabajen al mismo tiempo

### Reportes

- Los reportes ahora permiten una mejor filtración, pudiendo ahora además del día colocar una hora de inicio y de fin del día específicado
- Los reportes de productos más vendidos ahora muestran su lugar en el ranking dentro de la lista

## BugFix

- Se arregló un error en el que se podía iniciar los turnos multiples veces
- Se modificó el flujo de procesos del cierre de caja, ahora al finalizar el turno cierra sesión y pide que se vuelva a realizar el login, luego muestra directamente la pestaña de caja y de inicio del turno como ya lo hacía antes

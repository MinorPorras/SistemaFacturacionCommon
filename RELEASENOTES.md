# Notas del parche versión 3.0.8 (5}8 de ene de 2026)

Esta actualización busca resolver algunos problemas identificados en el flujo de trabajo de los arqueos de caja y problemas entre las sesiones y algunas otras cosas.

## BugFix

- Se arregló un error por el que al terminar turno en una cuenta, el turno aparecía como terminado en las demás cuentas.
- Se arregló un error en el que al hacer el cierre no aparecía la información correspondiente a las ventas de esa fecha.
- Ahora se detecta correctamente de forma individual por cada usuario si ya ha iniciado o no su turno
- Se arregló un erro en el que al interar en una cuenta de cajero su id de sesión no era correctamente enviado y utilizado alrededor de la aplicación haciendo que algunas ventas se guardaran con valores en 0
- Mejoras de estabilidad y disminución del tamaño de la aplicación eliminando archivos innecesarios
- Se arregló un error en ciertos tipos de reportes y obtenciones de listas de ventas en el que por problemas en el formato de la fecha esta no mostraba la información correcta

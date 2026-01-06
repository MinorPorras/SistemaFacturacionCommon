# Notas del parche versión 3.0.7 (5 de ene de 2026)

Esta actualización busca resolver algunos problemas identificados en el flujo de trabajo de los arqueos de caja y problemas entre las sesiones y algunas otras cosas.

## BugFix

- Se arregló un eror en el que al inciar un turno en una cuenta, si se salía de esta antes de terminarlo el turno aparecía como iniciado aunque no lo estuviera en todas las demás cuentas del sistema. Ahora este ya se maneja correctamente de forma individual por cada uno de los usuarios
- Ahora al agregar productos con precio variable con precios distintos estos se agregaran por separado aunque sean el mismo código, pero si tienen el mismo precio si se agregarán juntos como se hace normalmente. Antes estos simplemente sumaban la cantidad, pero se mantenía el precio del rpimero que e haya inmgresado
- Los reportes de arqueos de caja ahora se despliegan de forma de que se muestran los más recientes primero.
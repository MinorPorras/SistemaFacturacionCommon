# Notas del parche versión 3.0.1 (16 de oct de 2025)

Esta actualización presenta mejorar y bugfix importantes en el funcionamiento de la aplicación, principalmente en el manejo de la instancia única de la aplicación, su cierre ya la conexión con el servidor de git

## Nuevo

### Configuraciones
- Se agregaron 2 botones en la pestaña de información de las configuraciones, uno te permite ver la lista de cambios de las actualizaciones, principalmente de la más reciente, desde el directorio de git del proyecto, mientras que el botón que dice "Código fuente" te redirige al repositorio de github en el navegador

## BugFix

### Generales
- Se arregló un error en ran parte de las pestañas que provocaba que la aplicación no se cerrara de forma correcta y quedara trabajando en segundo plano, ahora al presionar cualquier botón que cierre la aplicación por completo esta ya se cerrará de forma correcta, impidiendo así que en condiciones normales haya problemas con la instancia única de la aplicación.
- Se arregló el título en la pestaña de cierre de caja
- Se mejoró el manejo de los dialogos de busqueda en el sistema para que funcionen en código como dialogos facilitando futuras implementaciones que se hagan
- Se corrigió un error en el cálculo del cierre de caja donde se consideraba incorrectamente el monto total de las facturas generadas al liquidar cuentas por cobrar. Ahora, el sistema solo toma en cuenta los abonos realizados durante el turno, ignorando el saldo total de la cuenta, lo que garantiza un cálculo preciso del efectivo manejado.
         

     
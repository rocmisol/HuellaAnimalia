# Sistema de Gestión de Compras y Clientes

Este proyecto es una aplicación de escritorio desarrollada en **C#** con **Windows Forms** que permite la gestión de clientes, empleados, proveedores, categorías de productos, productos, compras  y ventas (con líneas de detalle), e informes.

## Características principales

- Control de roles.
- Alta, baja y modificación de registros.
- Navegación entre registros: primero, anterior, siguiente, último.
- Validación de campos: DNI, correo electrónico, teléfono, etc.
- Carga de imagen.
- Validación de formularios con `ErrorProvider`.
- Teclas de acceso rápido (Alt + Tecla) para cada acción.
- Funcionalidad de búsqueda por diferentes criterios.
- Exportación/visualización de informes.
- Maestro-Detalle: encabezado de compra/venta y líneas de productos comprados/vendidos.


## Requisitos

- Visual Studio 2022 o superior.
- .NET Framework 4.7.2 o superior.
- Base de datos local (DataSet tipado) configurado en el archivo `.xsd`.
- Librerías de imágenes en `Properties.Resources`.


## Instalación

1. Abre el archivo `.sln` en Visual Studio.
2. Ejecuta el proyecto (`F5`).

## Notas

- La aplicación usa un `DataSet` local. Asegúrate de tener configurada la conexión de base de datos correctamente en el archivo `.xsd` y `.config`.
- Para informes, puedes usar `ReportViewer` de Microsoft.

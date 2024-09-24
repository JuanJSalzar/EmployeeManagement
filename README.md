# Employee Management Application

## Descripción del Proyecto

Esta aplicación fue desarrollada con .NET Framework 4.8 como parte de una prueba técnica. Su propósito es permitir la gestión completa de empleados, incluyendo las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) y la validación de campos.

## Requisitos Previos

Para ejecutar este proyecto, necesitas tener instalados los siguientes componentes:

- **.NET Framework 4.8**
- **Visual Studio 2022**
- **SQL Server 2019**
- **Entity Framework 6.5.1**

## Configuración del Entorno

### Clonación del Repositorio

Primero, clona el repositorio desde GitHub:

```bash
git clone https://github.com/JuanJSalzar/EmployeeManagement.git
```

### Configuración de la Base de Datos

1. Abre la solución en Visual Studio 2022.
2. Configura la cadena de conexión en el archivo `web.config` para apuntar a tu instancia de SQL Server.
3. Abre la Consola del Administrador de Paquetes en Visual Studio y ejecuta el siguiente comando para crear la base de datos:

```bash
Update-Database
```

4. Realiza un **build** de la solución.
5. Ejecuta la aplicación.

## Estructura del Proyecto

- **Models:** Contiene el modelo de datos `Employee`.
- **Context:** Incluye `EmployeeDbContext`, responsable de la configuración de la base de datos.
- **Controllers:** `EmployeeController` gestiona todas las llamadas a la base de datos usando `async/await`.
- **Views:** `index.cshtml` contiene el front-end de la aplicación y consume los métodos para mostrar datos.

## Instrucciones de Uso

1. Clona el repositorio y abre la solución en Visual Studio 2022.
2. Configura la base de datos y ejecuta el comando `Update-Database`.
3. Compila y ejecuta la aplicación.
4. Interactúa con la aplicación para gestionar empleados: crear, leer, actualizar y eliminar registros.

## Endpoints del API

- **`GET /Employee/GetEmployees`**: Devuelve una lista de todos los empleados.
- **`GET /Employee/GetEmployeeById/{id}`**: Devuelve los detalles de un empleado específico por su ID.
- **`POST /Employee/AddEmployee`**: Agrega un nuevo empleado.
- **`POST /Employee/UpdateEmployee`**: Actualiza los detalles de un empleado existente.
- **`POST /Employee/DeleteEmployee`**: Elimina un empleado por su ID.

## Captura de Pantalla

A continuación se presenta una captura de pantalla de la interfaz de la aplicación, mostrando la lista de empleados con opciones para editar y eliminar:

![imagen](https://github.com/user-attachments/assets/73e78e3d-ee18-4c50-8792-e7f02e8f85e0)

## Licencia

Este proyecto es de código abierto y no tiene una licencia específica asociada.

## Autor

Desarrollado por **Juan José Salazar**.

## Tecnologías Utilizadas

- AJAX
- jQuery
- Bootstrap 4
- SQL Server 2019
- .NET Framework 4.8
- Visual Studio 2022
- HTML (.NET integrado)
- Entity Framework 6.5.1
- 

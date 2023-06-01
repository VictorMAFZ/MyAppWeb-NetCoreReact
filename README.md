# MyAppWeb-NetCoreReact

Este es un proyecto de una aplicación web desarrollada con .NET Core y React.js. La aplicación consta de un backend basado en una API RESTful desarrollada en .NET Core y un frontend en React.js que interactúa con el backend para mostrar y gestionar usuarios y perfiles.

## Requisitos previos

- [.NET Core SDK](https://dotnet.microsoft.com/download) (versión 7.0.302)
- [Node.js](https://nodejs.org/) (versión 18.15.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (instalado localmente)

## Configuración

1. **Clonar el repositorio**
git clone https://github.com/VictorMAFZ/MyAppWeb-NetCoreReact.git


2. **Configurar la base de datos**

- Crea una base de datos en SQL Server llamada `MiAppWeb`.
- Ejecuta los scripts de creación de tablas que se encuentran en la carpeta `database` del proyecto.

3. **Configurar el backend**

- Abre el proyecto `backend` en tu IDE (por ejemplo, Visual Studio Code).
- Modifica el archivo `appsettings.json` en la carpeta `backend` para establecer la cadena de conexión a tu base de datos SQL Server.

4. **Configurar el frontend**

- Abre el proyecto `frontend` en tu IDE.
- Ejecuta el siguiente comando en la terminal para instalar las dependencias del proyecto:

  ```
  npm install
  ```

- Modifica el archivo `.env` en la carpeta `frontend` para establecer la URL del backend.

## Ejecución

1. **Ejecutar el backend**

- Abre una terminal en la carpeta `backend` del proyecto.
- Ejecuta el siguiente comando:

  ```
  dotnet run
  ```

2. **Ejecutar el frontend**

- Abre otra terminal en la carpeta `frontend` del proyecto.
- Ejecuta el siguiente comando:

  ```
  npm start
  ```

3. **Acceder a la aplicación**

- Abre tu navegador web y visita la URL `http://localhost:3000` para acceder a la aplicación.

## Contribución

Si deseas contribuir a este proyecto, siéntete libre de abrir un problema o enviar una solicitud de extracción.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para obtener más información.


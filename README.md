# proyecto-c-sharp-asp-mvc

#SCRIPT DE BASE DE DATOS UTILIZADA
----------------------------------------
CREATE DATABASE Comercial;

CREATE TABLE Marca(
	idMarca INT IDENTITY PRIMARY KEY,
	descripcionMarca VARCHAR(15) NOT NULL
);

CREATE TABLE Categoria(
	idCategoria INT IDENTITY PRIMARY KEY,
	descripcionCategoria VARCHAR(15) NOT NULL
);

CREATE TABLE Proveedor(
	idProveedor INT PRIMARY KEY IDENTITY,
	razonSocial VARCHAR(50) NOT NULL,
	telefono VARCHAR(20) NOT NULL,
	direccion VARCHAR(20),
	ruc VARCHAR(50)
);

CREATE TABLE Producto(
	idProducto INT IDENTITY PRIMARY KEY,
	descripcion VARCHAR(30) NOT NULL,
	marca INT REFERENCES Marca,
	categoria INT REFERENCES Categoria,
	cantidadStock INT NOT NULL DEFAULT(0),
	precio INT NOT NULL,
	proveedor INT REFERENCES Proveedor
);

CREATE TABLE Cliente(
	idCliente INT PRIMARY KEY IDENTITY,
	documento VARCHAR(50) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	telefono VARCHAR(20),
	direccion VARCHAR(20)
);

CREATE TABLE Venta(
	idVenta INT IDENTITY PRIMARY KEY,
	fecha DATETIME NOT NULL DEFAULT(GETDATE()),
	cliente INT REFERENCES Cliente
);

CREATE TABLE DetalleVenta(
	idVenta INT REFERENCES Venta,
	idProducto INT REFERENCES Producto,
	cantidad INT NOT NULL DEFAULT(1),
	PRIMARY KEY(idVenta, idProducto)
);


----------------------------------------

#CONFIGURACIÓN
1.Descargar o clonar el proyecto
2.Añadir el archivo Web.config, Web.Debug.config y Web.Release.config al proyecto
3.Compilar
4.Restaurar la instalación de paquetes NuGet
5.En caso de tener problemas con la carpeta Roslyn
  5.1. Reinstalar el paquete Microsoft.CodeDom.Providers.DotNetCompilerPlatform
6.En caso de que el problema siga, googlear!

#Desplegado en: https://proyectofinalasp-mvc2020.azurewebsites.net/


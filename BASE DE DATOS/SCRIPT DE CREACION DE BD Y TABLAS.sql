CREATE DATABASE SYSVENTAS --CREAMOS LA BASE DE DATOS SYSVENTAS
GO --EL GO ES PARA EJECUTAR UNA INSTRUCCION DE ARRIBA
USE SYSVENTAS --LA PONEMOS EN USO
GO
CREATE TABLE --CREAMOS LAS TABLAS
	tbl_asociado (id_asociado INT IDENTITY (1,1) PRIMARY KEY, --TABLA ASOCIADO
				asociado VARCHAR (20) NOT NULL)
GO
select * from tbl_articulo
ADD precio_docena FLOAT
GO
ALTER TABLE tbl_articulo
ADD id_sucursal INT FOREIGN KEY REFERENCES tbl_sucursal(id_sucursal)
CREATE TABLE 
	tbl_articulo (id_articulo INT IDENTITY (1,1) PRIMARY KEY,
				articulo VARCHAR(50) NOT NULL,
				precio_compra FLOAT NOT NULL,
				precio_venta FLOAT NOT NULL,
				existencia INT,
				id_asociado INT FOREIGN KEY REFERENCES tbl_asociado(id_asociado)) --CLAVE FORANEA QUE HACE REFERENCIA A LA TABLA ASOCIADO
				--CADA ARTICULO ESTA VINCULADO A UN ASOCIADO PARA LUEGO PODER MOSTRAR INVENTARIO DE CADA QUIEN
GO
CREATE TABLE
	tbl_gastos (id_gastos INT IDENTITY (1,1) PRIMARY KEY,
			gasto VARCHAR (50) NOT NULL,
			id_asociado INT FOREIGN KEY REFERENCES tbl_asociado(id_asociado))
GO
CREATE TABLE
	tbl_capital (id_capital INT IDENTITY (1,1) PRIMARY KEY,
			capital FLOAT,
			id_asociado INT FOREIGN KEY REFERENCES tbl_asociado(id_asociado))
GO
CREATE TABLE
	tbl_cartera (id_cartera INT IDENTITY (1,1) PRIMARY KEY,
			cartera FLOAT,
			id_asociado INT FOREIGN KEY REFERENCES tbl_asociado(id_asociado))
GO

CREATE TABLE
	tbl_venta (id_venta INT IDENTITY (1,1) PRIMARY KEY,
			fecha_venta DATETIME,
			id_asociado INT FOREIGN KEY REFERENCES tbl_asociado(id_asociado))
GO
DROP TABLE tbl_detalleVenta
CREATE TABLE
	tbl_detalleVenta (id_venta INT FOREIGN KEY REFERENCES tbl_venta(id_venta) NOT NULL,
				id_articulo INT FOREIGN KEY REFERENCES tbl_articulo(id_articulo) NOT NULL,
				cantidad INT NOT NULL,
				precio_venta FLOAT NOT NULL,
				subtotal FLOAT NOT NULL,
				total FLOAT NOT NULL,
				utilidad FLOAT NOT NULL)
				--PRIMARY KEY (id_venta,id_articulo)
GO
CREATE TABLE
	tbl_salida (id_salida INT IDENTITY (1,1) PRIMARY KEY,
			fecha_salida DATETIME,
			id_asociado INT FOREIGN KEY REFERENCES tbl_asociado(id_asociado))
GO
CREATE TABLE
	tbl_detalleSalida (id_salida INT NOT NULL,
				id_articulo INT NOT NULL,
				cantidad INT NOT NULL,
				motivo VARCHAR(50))
GO
CREATE TABLE
	tbl_entrada (id_entrada INT IDENTITY (1,1) PRIMARY KEY,
			fecha_entrada DATETIME,
			id_asociado INT FOREIGN KEY REFERENCES tbl_asociado(id_asociado))
GO
CREATE TABLE
	tbl_detalleEntrada (id_entrada INT NOT NULL,
				id_articulo INT NOT NULL,
				cantidad INT NOT NULL)
GO

create TABLE 
ALTER TABLE tbl_sucursal
ALTER COLUMN sucursal VARCHAR(50)
tbl_sucursal (id_sucursal INT IDENTITY (1,1) PRIMARY KEY,
				sucursal INT NOT NULL,
				id_articulo INT FOREIGN KEY REFERENCES tbl_articulo(id_articulo))
GO


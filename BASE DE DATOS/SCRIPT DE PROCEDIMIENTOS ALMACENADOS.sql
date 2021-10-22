--PROCEDIMIENTOS ALMACENADOS DE INSERTAR
SELECT * FROM tbl_asociado
GO

ALTER PROCEDURE SP_asociado(
	@id_asociado INT, 
	--ESTO SIGNIFICA QUE SI NO SE ENVIA EL ID SE LE ASIGNARA EL VALOR -1 PARA VALIDAR SI ES -1 ES UNA INSERCION SI CONTIENE UN ID ES ACTULIZACION
	@asociado VARCHAR(50)
) AS
BEGIN
	IF @id_asociado = -1
		BEGIN TRY
			INSERT INTO tbl_asociado(asociado) --SOLO INSERTAMOS LOS CAMPOS QUE NO SON CLAVE PRINCIPAL PORQUE ES AUTOINCREMENTO
			VALUES (@asociado)
			--SELECT @@IDENTITY --ESTO ES PARA QUE DEVUELVA EL ULTIMO ID INGRESADO
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
	ELSE
		BEGIN TRY
			UPDATE tbl_asociado SET asociado = @asociado 
			WHERE id_asociado = @id_asociado
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
END
GO

EXEC SP_asociado -1,'DAVID'
EXEC SP_asociado -1,'LIZET'
EXEC SP_asociado -1,'FEDERMAN'
EXEC SP_asociado -1,'FEDERICO'

DELETE FROM tbl_asociado

DBCC CHECKIDENT([tbl_asociado], RESEED,0) --ESTE CODIGO ES PARA RESETEAR EL ID DE LA TABLA, PARA COMENZAR EN CERO

--PROCEDIMIENTO INSERTAR ARTICULOS
select * from tbl_articulo
GO
ALTER PROCEDURE SP_articulo(
	@id_articulo INT, 
	@articulo VARCHAR(50),
	@precio_compra FLOAT,
	@precio_venta FLOAT,
	@precio_docena FLOAT,
	@existencia INT,
	@id_asociado INT
) AS
BEGIN
	IF @id_articulo = -1
		BEGIN TRY
			INSERT INTO tbl_articulo(articulo,precio_compra,precio_venta,precio_docena,existencia,id_asociado) --SOLO INSERTAMOS LOS CAMPOS QUE NO SON CLAVE PRINCIPAL PORQUE ES AUTOINCREMENTO
			VALUES (@articulo,@precio_compra,@precio_venta,@precio_docena,@existencia,@id_asociado)
			--SELECT @@IDENTITY --ESTO ES PARA QUE DEVUELVA EL ULTIMO ID INGRESADO
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
	ELSE
		BEGIN TRY
			UPDATE tbl_articulo 
			SET articulo = @articulo, precio_compra = @precio_compra, precio_venta = @precio_venta, precio_docena = @precio_docena,existencia = @existencia, id_asociado = @id_asociado 
			WHERE id_articulo = @id_articulo
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
END

EXEC SP_articulo -1,'CAMISETA BLANCA TALLA M',100,200,50,1
EXEC SP_articulo -1,'CAMISETA BLANCA TALLA S',100,200,50,1
EXEC SP_articulo -1,'CAMISETA BLANCA TALLA L',100,200,50,1
EXEC SP_articulo -1,'IMAGEN VIRGEN GUADALUPE',50,200,30,2
EXEC SP_articulo -1,'ROSARIOS AROMATICOS',10,50,200,2
EXEC SP_articulo 6,'BIBLIA LATINOAMERICANA',500,700,10,4

SELECT * FROM tbl_articulo INNER JOIN tbl_asociado ON tbl_articulo.id_asociado = tbl_asociado.id_asociado

--PROCEDIMIENTO INSERTAR VENTA
select * from tbl_venta
select * from tbl_detalleVenta
GO
ALTER PROCEDURE SP_venta(
	@id_venta INT, 
	@id_asociado INT,
	@parametro1 INT OUT
) AS
BEGIN
	DECLARE @id_ventaTemp INT
	IF @id_venta = -1
		BEGIN TRY
			
			INSERT INTO tbl_venta(fecha_venta,id_asociado) --SOLO INSERTAMOS LOS CAMPOS QUE NO SON CLAVE PRINCIPAL PORQUE ES AUTOINCREMENTO
			VALUES (GETDATE(),@id_asociado)
			SET @id_ventaTemp = @@IDENTITY --ESTO ES PARA QUE DEVUELVA EL ULTIMO ID INGRESADO
			SET @parametro1 = SCOPE_IDENTITY()

		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
	ELSE
		BEGIN TRY
			UPDATE tbl_venta 
			SET id_asociado = @id_asociado
			WHERE id_venta = @id_venta
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
	SELECT @parametro1
END
GO
exec SP_venta -1,1
select * from tbl_venta

ALTER PROCEDURE SP_detalleventa(
	@id_venta INT, 
	@id_articulo INT,
	@cantidad INT,
	@precio_venta FLOAT,
	@subtotal FLOAT
) AS
BEGIN
		BEGIN TRY		
			INSERT INTO tbl_detalleVenta(id_venta,id_articulo,cantidad,precio_venta,subtotal) --SOLO INSERTAMOS LOS CAMPOS QUE NO SON CLAVE PRINCIPAL PORQUE ES AUTOINCREMENTO
			VALUES (@id_venta,@id_articulo,@cantidad,@precio_venta,@subtotal)
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
END
DBCC FREEPROCCACHE
select * from tbl_detalleVenta
select * from tbl_venta
delete from tbl_venta where id_venta=5
delete from tbl_venta
delete from tbl_detalleVenta
EXEC SP_detalleventa 1,2,10,200,2000
--EXEC SP_venta -1,'18-08-2021',1,2,10,100,0,1000,1000 --FECHA MANUAL
EXEC SP_venta -1,2,4,20,100,0,2000,2000 --INSERTA SI PONEMOS EL ID -1
EXEC SP_venta 1,1,5,10,200,0,2000,2000 --MODIFICA SI PONEMOS EL ID DE LA VENTA AL INICIO

SELECT * FROM tbl_detalleVenta INNER JOIN tbl_articulo ON tbl_detalleVenta.id_articulo = tbl_articulo.id_articulo 
INNER JOIN tbl_asociado ON tbl_articulo. id_asociado = tbl_asociado.id_asociado

--PROCEDIMIENTO INSERTAR ENTRADA DE ARTICULOS
select * from tbl_entrada
select * from tbl_detalleEntrada
GO
CREATE PROCEDURE SP_Entrada(
	@id_entrada INT, 
	@id_asociado INT,
	@id_articulo INT,
	@cantidad INT
) AS
BEGIN
	DECLARE @id_entradaTemp INT
	IF @id_entrada = -1
		BEGIN TRY
			INSERT INTO tbl_entrada(fecha_entrada,id_asociado) --SOLO INSERTAMOS LOS CAMPOS QUE NO SON CLAVE PRINCIPAL PORQUE ES AUTOINCREMENTO
			VALUES (GETDATE(),@id_asociado)
			SET @id_entradaTemp = @@IDENTITY --ESTO ES PARA QUE DEVUELVA EL ULTIMO ID INGRESADO			
			
			INSERT INTO tbl_detalleEntrada(id_entrada,id_articulo,cantidad) --SOLO INSERTAMOS LOS CAMPOS QUE NO SON CLAVE PRINCIPAL PORQUE ES AUTOINCREMENTO
			VALUES (@id_entradaTemp,@id_articulo,@cantidad)
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
	ELSE
		BEGIN TRY
			UPDATE tbl_detalleEntrada 
			SET id_articulo = @id_articulo, cantidad = @cantidad
			WHERE id_entrada = @id_entrada
		END TRY
		BEGIN CATCH
			SELECT
			ERROR_MESSAGE() AS ERROR
		END CATCH
END

exec SP_Entrada -1,1,2,10 


select top 1 id_venta 
FROM tbl_venta
ORDER BY id_venta DESC
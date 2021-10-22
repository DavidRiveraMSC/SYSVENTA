--VISTAS
ALTER VIEW TOPARTICULOS
AS
SELECT TOP 5 id_articulo,articulo,precio_compra,precio_venta,precio_docena,existencia,asociado 
FROM tbl_articulo INNER JOIN tbl_asociado ON tbl_articulo.id_asociado = tbl_asociado.id_asociado
ORDER BY id_articulo DESC
GO

SELECT * FROM TOPARTICULOS

ALTER PROCEDURE SP_BUSCARARTICULOS
@param VARCHAR(20)
AS
BEGIN
	SELECT TOP 10 id_articulo,articulo,precio_compra,precio_venta,precio_docena,existencia,asociado
	FROM tbl_articulo INNER JOIN tbl_asociado ON tbl_articulo.id_asociado = tbl_asociado.id_asociado
	WHERE articulo LIKE + @param + '%'
END

EXEC SP_BUSCARARTICULOS C

SELECT * FROM tbl_articulo

CREATE PROCEDURE SP_BUSCARARTICULOS2
@param VARCHAR(20)
AS
BEGIN
	SELECT TOP 10 id_articulo,articulo,precio_venta,precio_docena,existencia,asociado
	FROM tbl_articulo INNER JOIN tbl_asociado ON tbl_articulo.id_asociado = tbl_asociado.id_asociado
	WHERE articulo LIKE + @param + '%'
END


EXEC SP_BUSCARARTICULOS2 c



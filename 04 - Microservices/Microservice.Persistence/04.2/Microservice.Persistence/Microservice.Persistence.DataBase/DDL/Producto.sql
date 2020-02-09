CREATE TABLE [dbo].[Producto]
(
	ProductoId INT NOT NULL IDENTITY PRIMARY KEY,
	Descripcion VARCHAR(250),
	Precio DECIMAL(30,6),
	Unidad VARCHAR(3)
)

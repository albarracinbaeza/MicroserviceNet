CREATE TABLE [dbo].[OrdenItem]
(
	OrdenItemId INT NOT NULL IDENTITY PRIMARY KEY,
	OrdenId INT NOT NULL,
	ProductoId INT NOT NULL,

	CONSTRAINT FK_OrdernItemOrden FOREIGN KEY (OrdenId) REFERENCES Orden(OrdenId),
	CONSTRAINT FK_OrdernItemProducto FOREIGN KEY (ProductoId) REFERENCES Producto(ProductoId),
)

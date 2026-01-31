use ordenrecibo
go

alter proc ConsultaProductosRevisados
as
begin
	
	/*otras operaciones*/


	/**salida de datos*/
	select
	
	b.IdOrdenReciboProductoRevisado as Secuencial,
	a.IdOrdenRecibo as IdOR,
	a.NumOrdenRecibo,
	a.CodigoCedis,
	a.Cedis,
	a.RucProveedor,
	a.Proveedor,
	b.SkuProducto,
	b.DescripcionProducto,
	b.Ubicacion,
	b.UxC,
	b.PalletsPeq,
	b.PalletsGran,
	b.CantidadRevisada,
	b.CantidadCompra,
	b.FechaFabricacion,
	b.FechaVencimiento

	from ordenrecibo..OrdenReciboRevisadas a
	inner join ordenrecibo..OrdenReciboProductosRevisados b
	on b.IdOrdenRecibo = a.IdOrdenRecibo


end
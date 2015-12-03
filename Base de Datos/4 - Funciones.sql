Create Function buscarUsuarios()
Returns Table
Return
(
	Select ROW_NUMBER() OVER (ORDER BY Nombres) As Numero,  Id,
	(Nombres + ' ' + Apellido_Paterno + ' ' + ISNULL(Apellido_Materno, '')) As Usuario
	From Usuario 
	Where Estado = 1 And Id > 1
)
Go

Create Function buscarProveedores()
Returns Table
Return
(
	Select ROW_NUMBER() OVER (ORDER BY Nombre) As Numero, Id, Nit, Nombre, Telefono
	From Proveedor
	Where Estado = 1
)
Go

Create Function buscarGrupos()
Returns Table
Return
(
	Select ROW_NUMBER() OVER (ORDER BY Nombre) As Numero, Id, Nombre
	From Grupo
	Where Estado = 1
)
Go

Create Function buscarProductos()
Returns Table
Return
(
	Select Pr.Id, P.Nombre As Proveedor, G.Nombre As Grupo, Pr.Tipo_De_Codigo_De_Barras, Pr.Codigo_De_Barras, Pr.Nombre_Generico, Pr.Marca,
	Pr.Presentacion, ISNULL(Pr.Sabor_U_Olor, '') As Sabor_U_Olor, Pr.Tipo, Pr.Cantidad_Minima, Pr.Precio_De_Compra, Pr.Precio_De_Venta, Pr.Alias
	From Proveedor P, Grupo G, Producto Pr
	Where P.Id = Pr.Id_Proveedor And G.Id = Pr.Id_Grupo And Pr.Estado = 1
	Union
	Select Pr.Id, P.Nombre As Proveedor, '' As Grupo, Pr.Tipo_De_Codigo_De_Barras, Pr.Codigo_De_Barras, Pr.Nombre_Generico, Pr.Marca,
	Pr.Presentacion, ISNULL(Pr.Sabor_U_Olor, '') As Sabor_U_Olor, Pr.Tipo, Pr.Cantidad_Minima, Pr.Precio_De_Compra, Pr.Precio_De_Venta, Pr.Alias
	From Proveedor P, Producto Pr
	Where P.Id = Pr.Id_Proveedor And Pr.Id_Grupo = 0 And Pr.Estado = 1
	Union
	Select Id, '', '' As Grupo, Tipo_De_Codigo_De_Barras, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion,
	ISNULL(Sabor_U_Olor, '') As Sabor_U_Olor, Tipo, Cantidad_Minima, Precio_De_Compra, Precio_De_Venta, Alias
	From Producto
	Where Id_Proveedor = 0 And Id_Grupo = 0 And Estado = 1
)
Go

Create Function Stock()
Returns Table
Return
(
	Select Bp.Id, Bp.Proveedor, Bp.Grupo, Bp.Tipo_De_Codigo_De_Barras, Bp.Codigo_De_Barras, Bp.Nombre_Generico, Bp.Marca,
	Bp.Presentacion, Bp.Sabor_U_Olor, Bp.Tipo, Bp.Cantidad_Minima, Bp.Precio_De_Compra, Bp.Precio_De_Venta, Bp.Alias,
	(ISNULL((Select SUM(DdI.Cantidad) From Detalle_De_Ingreso DdI Where bP.Id = DdI.Id_Producto And DdI.Estado = 'VIGENTE'), 0)
	- ISNULL((Select SUM(DdE.Cantidad) From Detalle_De_Egreso DdE Where bP.Id = DdE.Id_Producto And DdE.Estado = 'VIGENTE'), 0)) As Stock
	From buscarProductos() bP
)
Go
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
	Select Pr.Id, P.Nombre As Proveedor, G.Nombre As Grupo, Pr.Codigo_De_Barras, Pr.Nombre_Generico, Pr.Marca, Pr.Presentacion,
	ISNULL(Pr.Sabor_U_Olor, '') As Sabor_U_Olor, Pr.Cantidad_Minima, Pr.Precio_De_Compra, Pr.Precio_De_Venta
	From Proveedor P, Grupo G, Producto Pr
	Where P.Id = Pr.Id_Proveedor And G.Id = Pr.Id_Grupo And Pr.Estado = 1
	Union
	Select Pr.Id, P.Nombre As Proveedor, '' As Grupo, Pr.Codigo_De_Barras, Pr.Nombre_Generico, Pr.Marca, Pr.Presentacion,
	ISNULL(Pr.Sabor_U_Olor, '') As Sabor_U_Olor, Pr.Cantidad_Minima, Pr.Precio_De_Compra, Pr.Precio_De_Venta
	From Proveedor P, Producto Pr
	Where P.Id = Pr.Id_Proveedor And Pr.Id_Grupo = 0 And Pr.Estado = 1
	Union
	Select Id, '', '' As Grupo, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, ISNULL(Sabor_U_Olor, '') As Sabor_U_Olor,
	Cantidad_Minima, Precio_De_Compra, Precio_De_Venta
	From Producto
	Where Id_Proveedor = 0 And Id_Grupo = 0 And Estado = 1
)
Go
Create Procedure insertarUsuario
@Ci Varchar(8),
@Nombres Varchar(100),
@Apellido_Paterno Varchar(100),
@Apellido_Materno Varchar (100),
@Telefono Varchar(8),
@Nombre_De_Usuario Varchar(50),
@Clave Varchar(Max)
As
Begin
	Insert Into Usuario(Ci, Nombres, Apellido_Paterno, Apellido_Materno, Telefono, Nombre_De_Usuario, Clave, Estado)
	Values(@Ci, @Nombres, @Apellido_Paterno, @Apellido_Materno, @Telefono, @Nombre_De_Usuario, @Clave, 1)
	Select SCOPE_IDENTITY()
End

Go
Create Procedure insertarPrivilegio
@Id_Usuario Int,
@Id_Opcion Int
As
Begin
	Insert Into Privilegio (Id_Usuario, Id_Opcion, Estado)
	Values (@Id_Usuario, @Id_Opcion, 1)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarDosificacion
@Id_Sucursal Int,
@Numero_De_Autorizacion Varchar(15),
@Llave Varchar(256),
@Fecha_Limite_De_Emision Date,
@Leyenda Varchar(MAX),
@Estado Varchar(9)
As
Begin
	Insert Into Dosificacion(Id_Sucursal, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado)
	Values(@Id_Sucursal, @Numero_De_Autorizacion, @Llave, @Fecha_Limite_De_Emision, @Leyenda, @Estado)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarCaja
@Nombre_De_Equipo Varchar(MAX),
@Numero Varchar(20)
As
Begin
	Insert Into Caja(Nombre_De_Equipo, Numero, Estado)
	Values (@Nombre_De_Equipo, @Numero, 'ACTIVA')
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarAperturaDeCaja
@Id_Usuario Int,
@Id_Caja Int,
@Hora Varchar(50),
@Monto Decimal(18,2)
As
Begin
	Insert Into Apertura_De_Caja(Id_Usuario, Id_Caja, Fecha, Hora, Monto, Cerrado)
	Values(@Id_Usuario, @Id_Caja, GETDATE(), @Hora, @Monto, 0)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarCierreDeCaja
@Id_Usuario Int,
@Id_Caja Int,
@Id_Apertura_De_Caja Int,
@Hora Varchar(50),
@Monto_De_Apertura_De_Caja Decimal(18,2),
@Monto_De_Ventas Decimal(18,2),
@Monto_De_Cupones Decimal(18,2),
@Monto_De_Devoluciones Decimal(18,2),
@Monto_De_Venta_De_Tarjetas Decimal(18,2),
@Monto_De_Pagos Decimal(18,2),
@Monto_Total Decimal(18,2)
As
Begin
	Insert Into Cierre_De_Caja(Id_Usuario, Id_Caja, Id_Apertura_De_Caja, Fecha, Hora, Monto_De_Apertura_De_Caja, Monto_De_Ventas,
	Monto_De_Cupones, Monto_De_Devoluciones, Monto_De_Venta_De_Tarjetas, Monto_De_Pagos, Monto_Total)
	Values(@Id_Usuario, @Id_Caja, @Id_Apertura_De_Caja, GETDATE(), @Hora, @Monto_De_Apertura_De_Caja, @Monto_De_Ventas,
	@Monto_De_Cupones, @Monto_De_Devoluciones, @Monto_De_Venta_De_Tarjetas, @Monto_De_Pagos, @Monto_Total)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarProveedor
@Nit Varchar(12),
@Nombre Varchar(300),
@Persona_De_Contacto Varchar(300),
@Direccion Varchar(500),
@Telefono Varchar(8),
@Celular Varchar(8),
@Numero_De_Cuenta Varchar(100)
As
Begin
	Insert Into Proveedor(Nit, Nombre, Persona_De_Contacto, Direccion, Telefono, Celular, Numero_De_Cuenta, Estado)
	Values(@Nit, @Nombre, @Persona_De_Contacto, @Direccion, @Telefono, @Celular, @Numero_De_Cuenta, 1)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarCliente
@Ci_O_Nit Varchar(12),
@Nombre Varchar(500)
As
Begin
	Insert Into Cliente(Ci_O_Nit, Nombre, Estado)
	Values(@Ci_O_Nit, @Nombre, 1)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarGrupo
@Nombre Varchar(100)
As
Begin
	Insert Into Grupo(Nombre, Estado)
	Values(@Nombre, 1)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarProducto
@Id_Proveedor Int,
@Id_Grupo Int,
@Tipo_De_Codigo_De_Barras Varchar(7),
@Codigo_De_Barras Varchar(100),
@Nombre_Generico Varchar(100),
@Marca Varchar(100),
@Presentacion Varchar(100),
@Sabor_U_Olor Varchar(100),
@Tipo Varchar(10),
@Cantidad_Minima Decimal(18,3),
@Precio_De_Compra Decimal(18,2),
@Precio_De_Venta Decimal(18,2),
@Alias Varchar(24)
As
Begin
	Insert Into Producto(Id_Proveedor, Id_Grupo, Tipo_De_Codigo_De_Barras, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, 
	Sabor_U_Olor, Tipo, Cantidad_Minima, Precio_De_Compra, Precio_De_Venta, Alias, Estado)
	Values(@Id_Proveedor, @Id_Grupo, @Tipo_De_Codigo_De_Barras, @Codigo_De_Barras, @Nombre_Generico, @Marca, @Presentacion, @Sabor_U_Olor,
	@Tipo, @Cantidad_Minima, @Precio_De_Compra, @Precio_De_Venta, @Alias, 1)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarIngreso
@Id_Proveedor Int,
@Numero_De_Registro Int,
@Numero_De_Nota_De_Entrega Varchar(50),
@Monto Decimal(18,2),
@Observaciones Varchar(500)
As
Begin
	Insert Into Ingreso(Id_Proveedor, Fecha, Numero_De_Registro, Numero_De_Nota_De_Entrega, Monto, Observaciones, Estado)
	Values(@Id_Proveedor, GETDATE(), @Numero_De_Registro, @Numero_De_Nota_De_Entrega, @Monto, @Observaciones, 'VIGENTE')
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarDetalleDeIngreso
@Id_Ingreso Int,
@Id_Producto Int,
@Cantidad Decimal(18,3),
@Precio_De_Compra Decimal(18,2),
@Monto_Total Decimal(18,2),
@Porcentaje_De_Utilidad Decimal(18,2),
@Precio_De_Venta Decimal(18,2)
As
Begin
	Insert Into Detalle_De_Ingreso(Id_Ingreso, Id_Producto, Cantidad, Precio_De_Compra, Monto_Total, Porcentaje_De_Utilidad, Precio_De_Venta,
	Estado)
	Values(@Id_Ingreso, @Id_Producto, @Cantidad, @Precio_De_Compra, @Monto_Total, @Porcentaje_De_Utilidad, @Precio_De_Venta, 'VIGENTE')
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarEgreso
@Id_Usuario Int,
@Id_Caja Int,
@Id_Apertura_De_Caja Int,
@Id_Cliente Int,
@Hora Varchar(50),
@Tipo Varchar(15),
@Metodo_De_Pago Varchar(15),
@Monto Decimal(18,2),
@Monto_De_Cupon Decimal(18,2) Not Null,
@Monto_Extra Decimal(18,2) Not Null,
@Monto_Pagado Decimal(18,2),
@Cambio Decimal(18,2),
@Observaciones Varchar(500),
@Facturado Bit,
@Cerrado Bit,
@Estado Varchar(7)
As
Begin
	Insert Into Egreso (Id_Usuario, Id_Caja, Id_Apertura_De_Caja, Id_Cliente, Fecha, Hora, Tipo, Metodo_De_Pago, Monto, Monto_De_Cupon,
	Monto_Extra, Monto_Pagado, Cambio, Observaciones, Facturado, Cerrado, Estado)
	Values (@Id_Usuario, @Id_Caja, @Id_Apertura_De_Caja, @Id_Cliente, GETDATE(), @Hora, @Tipo, @Metodo_De_Pago, @Monto, @Monto_De_Cupon,
	@Monto_Extra, @Monto_Pagado, @Cambio, @Observaciones, @Facturado, @Cerrado, @Estado)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarDetalleDeEgreso
@Id_Egreso Int,
@Id_Producto Int,
@Cantidad Decimal(18,3),
@Precio_Unitario Decimal(18,2),
@Monto_Total Decimal(18,2),
@Estado Varchar(7)
As
Begin
	Insert Into Detalle_De_Egreso(Id_Egreso, Id_Producto, Cantidad, Precio_Unitario, Monto_Total, Estado)
	Values(@Id_Egreso, @Id_Producto, @Cantidad, @Precio_Unitario, @Monto_Total, @Estado)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarFactura
@Id_Usuario As Int,
@Id_Caja As Int,
@Id_Apertura_De_Caja As Int,
@Id_Egreso As Int,
@Id_Cliente As Int,
@Id_Dosificacion As Int,
@Numero_De_Autorizacion As Varchar(15),
@Ci_O_Nit As Varchar(12),
@Cliente As Varchar(500),
@Fecha As Date,
@Hora As Varchar(50),
@Monto As Money,
@Monto_Pagado As Money,
@Cambio As Money
As
Begin
	Declare @Numero As Int
	Set @Numero = (Select (ISNULL(MAX(Numero), 0) + 1) From Factura Where Id_Dosificacion = @Id_Dosificacion)
	Insert Into Factura(Id_Usuario, Id_Caja, Id_Apertura_De_Caja, Id_Egreso, Id_Cliente, Id_Dosificacion, Numero_De_Autorizacion, Numero,
	Codigo_De_Control, Ci_O_Nit, Cliente, Fecha, Hora, Monto, Monto_Pagado, Cambio, Estado)
	Values(@Id_Usuario, @Id_Caja, @Id_Apertura_De_Caja, @Id_Egreso, @Id_Cliente, @Id_Dosificacion, @Numero_De_Autorizacion, @Numero, '',
	@Ci_O_Nit, @Cliente, @Fecha, @Hora, @Monto, @Monto_Pagado, @Cambio, 'VIGENTE')
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarDetalleDeFactura
@Id_Factura Int,
@Id_Producto Int,
@Detalle Varchar(24),
@Cantidad Decimal(18,3),
@Importe Decimal(18,2)
As
Begin
	Insert Into Detalle_De_Factura(Id_Factura, Id_Producto, Detalle, Cantidad, Importe, Estado)
	Values(@Id_Factura, @Id_Producto, @Detalle, @Cantidad, @Importe, 1)
	Select SCOPE_IDENTITY()
End
Go
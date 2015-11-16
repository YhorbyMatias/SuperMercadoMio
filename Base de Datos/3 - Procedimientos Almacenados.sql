Create Procedure insertarRegistro
@Usuario Varchar(300),
@Equipo Varchar(100),
@Hora Varchar(30),
@Tabla Varchar(100),
@Id_Tabla Int,
@Tipo Varchar(45)
As
Begin
	Insert Into Registro(Usuario, Equipo, Fecha, Hora, Tabla, Id_Tabla, Tipo)
	Values(@Usuario, @Equipo, GETDATE(), @Hora, @Tabla, @Id_Tabla, @Tipo)
End
Go

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


Create Procedure insertarEmpresa
@Propietario Varchar(300),
@Razon_Social Varchar(200),
@Nit Varchar(20),
@Actividad_Economica Varchar(MAX)
As
Begin
	Insert Into Empresa(Propietario, Razon_Social, Nit, Actividad_Economica, Estado)
	Values(@Propietario, @Razon_Social, @Nit, @Actividad_Economica, 1)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarSucursal
@Id_Empresa Int,
@Numero Varchar(3),
@Direccion Varchar(MAX),
@Telefono Varchar(8),
@Municipio Varchar(100)
As
Begin
	Insert Into Sucursal(Id_Empresa, Numero, Direccion, Telefono, Municipio, Estado)
	Values(@Id_Empresa, @Numero, @Direccion, @Telefono, @Municipio, 1)
	Select SCOPE_IDENTITY()
End
Go

Create Procedure insertarDosificacion
@Id_Sucursal Int,
@Numero_De_Autorizacion Varchar(15),
@Llave Varchar(256),
@Fecha_Limite_De_Emision Date,
@Leyenda Varchar(MAX)
As
Begin
	Insert Into Dosificacion(Id_Sucursal, Numero_De_Autorizacion, Llave, Fecha_Limite_De_Emision, Leyenda, Estado)
	Values(@Id_Sucursal, @Numero_De_Autorizacion, @Llave, @Fecha_Limite_De_Emision, @Leyenda, 1)
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
@Alias Varchar(24),
@Sabor_U_Olor Varchar(100),
@Tipo Varchar(10),
@Cantidad_Minima Decimal(18,3),
@Precio_De_Compra Decimal(18,2),
@Precio_De_Venta Decimal(18,2)
As
Begin
	Insert Into Producto(Id_Proveedor, Id_Grupo, Tipo_De_Codigo_De_Barras, Codigo_De_Barras, Nombre_Generico, Marca, Presentacion, Alias,
	Sabor_U_Olor, Tipo, Cantidad_Minima, Precio_De_Compra, Precio_De_Venta, Estado)
	Values(@Id_Proveedor, @Id_Grupo, @Tipo_De_Codigo_De_Barras, @Codigo_De_Barras, @Nombre_Generico, @Marca, @Presentacion, @Alias,
	@Sabor_U_Olor, @Tipo, @Cantidad_Minima, @Precio_De_Compra, @Precio_De_Venta, 1)
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
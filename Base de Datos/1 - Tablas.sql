Create Table Usuario
(
	Id Int Not Null Identity(1,1),
	Ci Varchar(8) Not Null,
	Nombres Varchar(100) Not Null,
	Apellido_Paterno Varchar(100) Not Null,
	Apellido_Materno Varchar(100) Null,
	Telefono Varchar(8) Null,
	Nombre_De_Usuario Varchar(50) Collate Latin1_General_CS_AS Not Null,
	Clave Varchar(Max) Not Null,
	Estado Bit Not Null,
	Primary Key(Id)
)
Go

Create Table Opcion
(
	Id Int Not Null Identity(1,1),
	Nombre Varchar(100) Not Null,
	Estado Bit Not Null,
	Primary Key(Id)
)
Go

Create Table Privilegio
(
	Id Int Not Null Identity(1,1),
	Id_Usuario Int Not Null,
	Id_Opcion Int Not Null,
	Estado Bit Not Null,
	Primary Key(Id),
	Foreign Key(Id_Usuario) References Usuario(Id),
	Foreign Key(Id_Opcion) References Opcion(Id)
)
Go

Create Table Registro
(
	Id Int Not Null Identity(1,1),
	Usuario Varchar(300) Not Null,
	Equipo Varchar(100) Not Null,
	Fecha Date Not Null,
	Hora Varchar(30) Not Null,
	Tabla Varchar(100) Not Null,
	Id_Tabla Int Not Null,
	Tipo Varchar(45) Not Null,
	Primary Key(Id)
)
Go

Create Table Empresa
(
	Id Int Identity(1,1) Not Null,
	Propietario Varchar(300) Not Null,
	Razon_Social Varchar(200) Not Null,
	Nit Varchar(12) Not Null,
	Actividad_Economica Varchar(MAX) Not Null,
	Estado Bit Not Null,
	Primary Key(Id)
)
Go

Create Table Sucursal
(
	Id Int Not Null Identity(1,1),
	Id_Empresa Int Not Null,
	Numero Varchar(3) Not Null,
	Direccion Varchar(MAX) Not Null,
	Telefono Varchar(8) Not Null,
	Municipio Varchar(100) Not Null,
	Estado Bit Not Null,
	Primary Key(Id),
	Foreign Key(Id_Empresa) References Empresa(Id)
)
Go

Create Table Dosificacion
(
	Id Int Not Null Identity(1,1),
	Id_Sucursal Int Not Null,
	Numero_De_Autorizacion Varchar(15) Not Null,
	Llave Varchar(256) Not Null,
	Fecha_Limite_De_Emision Date Not Null,
	Leyenda Varchar(MAX) Not Null,
	Estado Varchar(9) Not Null,
	Primary Key(Id),
	Foreign Key(Id_Sucursal) References Sucursal(Id)
)
Go

Create Table Caja
(
	Id Int Not Null Identity(1,1),
	Nombre_De_Equipo Varchar(MAX) Not Null,
	Numero Varchar(100) Not Null,
	Estado Varchar(20) Not Null,
	Primary Key(Id)
)
Go

Create Table Apertura_De_Caja
(
	Id Int Not Null Identity(1,1),
	Id_Usuario Int Not Null,
	Id_Caja Int Not Null,
	Fecha Date Not Null,
	Hora Varchar(50) Not Null,
	Monto Decimal(18,2) Not Null,
	Cerrado Bit Not Null,
	Primary Key(Id),
	Foreign Key(Id_Usuario) References Usuario(Id),
	Foreign Key(Id_Caja) References Caja(Id)
)

Create Table Cierre_De_Caja
(
	Id Int Not Null Identity(1,1),
	Id_Usuario Int Not Null,
	Id_Caja Int Not Null,
	Id_Apertura_De_Caja Int Not Null,
	Fecha Date Not Null,
	Hora Varchar(50) Not Null,
	Monto_De_Apertura_De_Caja Decimal(18,2) Not Null,
	Monto_De_Ventas Decimal(18,2) Not Null,
	Monto_De_Devoluciones Decimal(18,2) Not Null,
	Monto_De_Venta_De_Tarjetas Decimal(18,2) Not Null,
	Monto_De_Pagos Decimal(18,2) Not Null,
	Monto_Total Decimal(18,2) Not Null,
	Primary Key(Id),
	Foreign Key(Id_Usuario) References Usuario(Id),
	Foreign Key(Id_Caja) References Caja(Id),
	Foreign Key(Id_Apertura_De_Caja) References Apertura_De_Caja(Id)
)

Create Table Proveedor
(
	Id Int Not Null Identity(1,1),
	Nit Varchar(12) Not Null,
	Nombre Varchar(300) Not Null,
	Persona_De_Contacto Varchar(300) Null,
	Direccion Varchar(500) Null,
	Telefono Varchar(8) Null,
	Celular Varchar(8) Null,
	Numero_De_Cuenta Varchar(100) Null,
	Estado Bit Not Null,
	Primary Key(Id)
)
Go

Create Table Cliente
(
	Id Int Not Null Identity(1,1),
	Ci_O_Nit Varchar(12) Not Null,
	Nombre Varchar(500) Not Null,
	Estado Bit Not Null,
	Primary Key(Id)
)
Go

Create Table Grupo
(
	Id Int Not Null Identity(1,1),
	Nombre Varchar(100) Not Null,
	Estado Bit Not Null,
	Primary Key(Id)
)
Go

Create Table Producto
(
	Id Int Not Null Identity(1,1),
	Id_Proveedor Int Not Null,
	Id_Grupo Int Not Null,
	Tipo_De_Codigo_De_Barras Varchar(7) Not Null,
	Codigo_De_Barras Varchar(100) Not Null,
	Nombre_Generico Varchar(100) Not Null,
	Marca Varchar(100) Not Null,
	Presentacion Varchar(100) Not Null,
	Sabor_U_Olor Varchar(100) Null,
	Tipo Varchar(10) Not Null,
	Cantidad_Minima Decimal(18,3) Not Null,
	Precio_De_Compra Decimal(18,2) Not Null,
	Precio_De_Venta Decimal(18,2) Not Null,
	Alias Varchar(24) Not Null,
	Estado Bit Not Null,
	Primary Key (Id)
)

Create Table Ingreso
(
Id Int Not Null Identity(1,1),
Id_Proveedor Int Not Null,
Fecha Date Not Null,
Numero_De_Registro Int Not Null,
Numero_De_Nota_De_Entrega Varchar(50) Null,
Monto Decimal(18,2) Not Null,
Observaciones Varchar(500) Null,
Estado Varchar(20) Not Null,
Primary Key(Id),
Foreign Key(Id_Proveedor) References Proveedor(Id),
)

Create Table Detalle_De_Ingreso
(
Id Int Not Null Identity(1,1),
Id_Ingreso Int Not Null,
Id_Producto Int Not Null,
Cantidad Decimal(18,3) Not Null,
Precio_De_Compra Decimal(18,2) Not Null,
Monto_Total Decimal(18,2) Not Null,
Porcentaje_De_Utilidad Decimal(18,2) Not Null,
Precio_De_Venta Decimal(18,2) Not Null,
Estado Varchar(9) Not Null,
Primary Key(Id),
Foreign Key(Id_Ingreso) References Ingreso(Id),
Foreign Key(Id_Producto) References Producto(Id)
)

Create Table Egreso
(
	Id Int Not Null Identity(1,1),
	Id_Usuario Int Not Null,
	Id_Caja Int Not Null,
	Id_Apertura_De_Caja Int Not Null,
	Id_Cliente Int Not Null,
	Fecha Date Not Null,
	Hora Varchar(50) Not Null,
	Tipo Varchar(15) Not Null,
	Metodo_De_Pago Varchar(15) Null,
	Monto Decimal(18,2) Not Null,
	Monto_Pagado Decimal(18,2) Not Null,
	Cambio Decimal(18,2) Not Null,
	Observaciones Varchar(500) Null,
	Facturado Bit Not Null,
	Cerrado Bit Not Null,
	Estado Varchar(7) Not Null,
	Primary Key(Id),
	Foreign Key(Id_Usuario) References Usuario(Id)
)

Create Table Detalle_De_Egreso
(
	Id Int Not Null Identity(1,1),
	Id_Egreso Int Not Null,
	Id_Producto Int Not Null,
	Cantidad Decimal(18,3) Not Null,
	Precio_Unitario Decimal(18,2) Not Null,
	Monto_Total Decimal(18,2) Not Null,
	Estado Varchar(7) Not Null,
	Primary Key(Id),
	Foreign Key(Id_Egreso) References Egreso(Id),
	Foreign Key(Id_Producto) References Producto(Id)
)
Go

Create Table Factura
(
	Id Int Not Null Identity(1,1),
	Id_Usuario Int Not Null,
	Id_Caja Int Not Null,
	Id_Apertura_De_Caja Int Not Null,
	Id_Egreso Int Not Null,
	Id_Cliente Int Not Null,
	Id_Dosificacion Int Not Null,
	Numero_De_Autorizacion Varchar(15) Not Null,
	Numero Int Not Null,
	Codigo_De_Control Varchar(14) Not Null,
	Ci_O_Nit Varchar(12) Not Null,
	Cliente Varchar(500) Not Null,
	Fecha Date Not Null,
	Hora Varchar(50) Not Null,
	Monto Decimal(18,2) Not Null,
	Monto_Pagado Decimal(18,2) Not Null,
	Cambio Decimal(18,2) Not Null,
	Estado Varchar(7) Not Null,
	Primary Key(Id),
	Foreign Key(Id_Usuario) References Usuario(Id),
	Foreign Key(Id_Caja) References Caja(Id),
	Foreign Key(Id_Apertura_De_Caja) References Apertura_De_Caja(Id),
	Foreign Key(Id_Cliente) References Cliente(Id),
	Foreign Key(Id_Dosificacion) References Dosificacion(Id)
)
Go

Create Table Detalle_De_Factura
(
	Id Int Not Null Identity(1,1),
	Id_Factura Int Not Null,
	Id_Producto Int Not Null,
	Detalle Varchar(24) Not Null,
	Cantidad Decimal(18,3) Not Null,
	Importe Decimal(18,2) Not Null,
	Estado Bit Not Null,
	Primary Key(Id),
	Foreign Key(Id_Factura) References Factura(Id),
	Foreign Key(Id_Producto) References Producto(Id)
)
Go

Create Table Devolucion
(
	Id Int Not Null Identity(1,1),
	Id_Usuario Int Not Null,
	Id_Caja Int Not Null,
	Id_Apertura_De_Caja Int Not Null,
	Id_Egreso Int Not Null,
	Fecha Date Not Null,
	Hora Varchar(50) Not Null,
	Monto Decimal(18,2) Not Null,
	Cerrado Bit Not Null,
	Estado Bit Not Null,
	Primary Key(Id),
	Foreign Key(Id_Usuario) References Usuario(Id),
	Foreign Key(Id_Caja) References Caja(Id),
	Foreign Key(Id_Apertura_De_Caja) References Apertura_De_Caja(Id)
)
Go
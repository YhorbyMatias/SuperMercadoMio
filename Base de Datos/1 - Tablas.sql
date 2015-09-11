Create Table Usuario
(
Id_Usuario Int Not Null Identity(1,1),
Ci Varchar(8) Not Null,
Nombres Varchar(100) Not Null,
Apellido_Paterno Varchar(100) Not Null,
Apellido_Materno Varchar(100) Null,
Telefono Varchar(8) Null,
Nombre_De_Usuario Varchar(50) Collate Latin1_General_CS_AS Not Null,
Clave Varchar(Max) Not Null,
Estado Bit Not Null,
Primary Key(Id_Usuario)
)
Go

Create Table Opcion
(
Id_Opcion Int Not Null Identity(1,1),
Nombre Varchar(100) Not Null,
Estado Bit Not Null,
Primary Key(Id_Opcion)
)
Go

Create Table Privilegio
(
Id_Privilegio Int Not Null Identity(1,1),
Id_Usuario Int Not Null,
Id_Opcion Int Not Null,
Estado Bit Not Null,
Primary Key(Id_Privilegio),
Foreign Key(Id_Usuario) References Usuario(Id_Usuario),
Foreign Key(Id_Opcion) References Opcion(Id_Opcion)
)
Go

Create Table Registro
(
Id_Registro Int Not Null Identity(1,1),
Usuario Varchar(300) Not Null,
Equipo Varchar(100) Not Null,
Fecha Date Not Null,
Hora Varchar(30) Not Null,
Tabla Varchar(100) Not Null,
Id_Tabla Int Not Null,
Tipo Varchar(45) Not Null,
Primary Key(Id_Registro)
)
Go

Create Table Empresa
(
Id_Empresa Int Identity(1,1) Not Null,
Propietario Varchar(300) Not Null,
Razon_Social Varchar(200) Not Null,
Nit Varchar(12) Not Null,
Actividad_Economica Varchar(MAX) Not Null,
Estado Bit Not Null,
Primary Key(Id_Empresa)
)
Go

Create Table Sucursal
(
Id_Sucursal Int Not Null Identity(1,1),
Id_Empresa Int Not Null,
Numero Varchar(3) Not Null,
Direccion Varchar(MAX) Not Null,
Telefono Varchar(8) Not Null,
Municipio Varchar(100) Not Null,
Estado Bit Not Null,
Primary Key(Id_Sucursal),
Foreign Key(Id_Empresa) References Empresa(Id_Empresa)
)
Go

Create Table Dosificacion
(
Id_Dosificacion Int Not Null Identity(1,1),
Id_Sucursal Int Not Null,
Numero_De_Autorizacion Varchar(15) Not Null,
Llave Varchar(256) Not Null,
Fecha_Limite_De_Emision Date Not Null,
Leyenda Varchar(MAX) Not Null,
Estado Varchar(9) Not Null,
Primary Key(Id_Dosificacion),
Foreign Key(Id_Sucursal) References Sucursal(Id_Sucursal)
)
Go

Create Table Caja
(
Id_Caja Int Not Null Identity(1,1),
Nombre_De_Equipo Varchar(MAX) Not Null,
Numero Varchar(100) Not Null,
Estado Varchar(20) Not Null,
Primary Key(Id_Caja)
)
Go

Create Table Apertura_De_Caja
(
Id_Apertura_De_Caja Int Not Null Identity(1,1),
Id_Usuario Int Not Null,
Id_Caja Int Not Null,
Fecha Date Not Null,
Hora Varchar(50) Not Null,
Monto Decimal(18,2) Not Null,
Cerrado Bit Not Null,
Primary Key(Id_Apertura_De_Caja),
Foreign Key(Id_Usuario) References Usuario(Id_Usuario),
Foreign Key(Id_Caja) References Caja(Id_Caja)
)

Create Table Cierre_De_Caja
(
Id_Cierre_De_Caja Int Not Null Identity(1,1),
Id_Usuario Int Not Null,
Id_Caja Int Not Null,
Id_Apertura_De_Caja Int Not Null,
Fecha Date Not Null,
Hora Varchar(50) Not Null,
Monto_De_Apertura_De_Caja Decimal(18,2) Not Null,
Monto_Total_De_Ventas Decimal(18,2) Not Null,
Monto_De_Devoluciones Decimal(18,2) Not Null,
Monto_De_Ventas_De_Tarjetas Decimal(18,2) Not Null,
Pagos Decimal(18,2) Not Null,
Monto_Total Decimal(18,2) Not Null,
Primary Key(Id_Cierre_De_Caja),
Foreign Key(Id_Usuario) References Usuario(Id_Usuario),
Foreign Key(Id_Caja) References Caja(Id_Caja),
Foreign Key(Id_Apertura_De_Caja) References Apertura_De_Caja(Id_Apertura_De_Caja)
)

Create Table Proveedor
(
Id_Proveedor Int Not Null Identity(1,1),
Nit Varchar(12) Not Null,
Nombre Varchar(300) Not Null,
Persona_De_Contacto Varchar(300) Null,
Direccion Varchar(500) Null,
Telefono Varchar(8) Null,
Celular Varchar(8) Null,
Numero_De_Cuenta Varchar(100) Null,
Estado Bit Not Null,
Primary Key(Id_Proveedor)
)
Go

Create Table Cliente
(
Id_Cliente Int Not Null Identity(1,1),
Ci_O_Nit Varchar(12) Not Null,
Nombre_Completo Varchar(500) Not Null,
Estado Bit Not Null,
Primary Key(Id_Cliente)
)
Go

Create Table Grupo
(
Id_Grupo Int Not Null Identity(1,1),
Nombre Varchar(100) Not Null,
Estado Bit Not Null,
Primary Key(Id_Grupo)
)
Go

Create Table Producto
(
Id_Producto Int Not Null Identity(1,1),
Id_Proveedor Int Not Null,
Id_Grupo Int Not Null,
Tipo_De_Codigo_De_Barras Varchar(7) Not Null,
Codigo_De_Barras Varchar(100) Not Null,
Nombre_Generico Varchar(100) Not Null,
Marca Varchar(100) Not Null,
Presentacion Varchar(100) Not Null,
Alias Varchar(24) Not Null,
Sabor_U_Olor Varchar(100) Null,
Tipo Varchar(10) Not Null,
Cantidad_Minima Decimal(18,3) Not Null,
Precio Decimal(18,2) Not Null,
Estado Bit Not Null,
Primary Key (Id_Producto)
)

Create Table Ingreso
(
Id_Ingreso Int Not Null Identity(1,1),
Id_Proveedor Int Not Null,
Fecha Date Not Null,
Numero_De_Registro Int Not Null,
Numero_Nota_De_Entrega Varchar(50) Null,
Monto_Total Decimal(18,2) Not Null,
Observaciones Varchar(500) Null,
Tipo Varchar(15) Not Null,
Estado Varchar(20) Not Null,
Primary Key(Id_Ingreso),
Foreign Key(Id_Proveedor) References Proveedor(Id_Proveedor),
)

Create Table Detalle_De_Ingreso
(
Id_Detalle_De_Ingreso Int Not Null Identity(1,1),
Id_Ingreso Int Not Null,
Id_Producto Int Not Null,
Cantidad Decimal(18,3) Not Null,
Precio_De_Compra Decimal(18,2) Not Null,
Monto_Total Decimal(18,2) Not Null,
Porcentaje_De_Utilidad Decimal(18,2) Not Null,
Precio_De_Venta Decimal(18,2) Not Null,
Estado Bit Not Null,
Primary Key(Id_Detalle_De_Ingreso),
Foreign Key(Id_Ingreso) References Ingreso(Id_Ingreso),
Foreign Key(Id_Producto) References Producto(Id_Producto)
)

Create Table Egreso
(
Id_Egreso Int Not Null Identity(1,1),
Id_Usuario Int Not Null,
Id_Caja Int Not Null,
Id_Apertura_De_Caja Int Not Null,
Id_Cliente Int Not Null,
Fecha Date Not Null,
Hora Varchar(50) Not Null,
Tipo Varchar(15) Not Null,
Metodo_De_Pago Varchar(15) Not Null,
Monto Decimal(18,2) Not Null,
Monto_Pagado Decimal(18,2) Not Null,
Cambio Decimal(18,2) Not Null,
Observaciones Varchar(500) Null,
Cerrado Bit Not Null,
Estado Varchar(7) Not Null,
Primary Key(Id_Egreso),
Foreign Key(Id_Usuario) References Usuario(Id_Usuario),
Foreign Key(Id_Caja) References Caja(Id_Caja),
Foreign Key(Id_Apertura_De_Caja) References Apertura_De_Caja(Id_Apertura_De_Caja),
Foreign Key(Id_Cliente) References Cliente(Id_Cliente)
)

Create Table Detalle_De_Egreso
(
Id_Detalle_De_Egreso Int Not Null Identity(1,1),
Id_Egreso Int Not Null,
Id_Producto Int Not Null,
Cantidad Decimal(18,3) Not Null,
Precio_Unitario Decimal(18,2) Not Null,
Monto_Total Money Not Null,
Estado Varchar(7) Not Null,
Primary Key(Id_Detalle_De_Egreso),
Foreign Key(Id_Egreso) References Egreso(Id_Egreso),
Foreign Key(Id_Producto) References Producto(Id_Producto),
)
Go

Create Table Factura
(
Id_Factura Int Not Null Identity(1,1),
Id_Usuario Int Not Null,
Id_Caja Int Not Null,
Id_Apertura_De_Caja Int Not Null,
Id_Egreso Int Not Null,
Id_Cliente Int Not Null,
Id_Dosificacion Int Not Null,
Numero_De_Autorizacion Varchar(15) Not Null,
Numero_De_Factura Int Not Null,
Codigo_De_Control Varchar(14) Not Null,
Nit_O_Ci_Cliente Varchar(12) Not Null,
Cliente Varchar(500) Not Null,
Fecha Date Not Null,
Hora Varchar(50) Not Null,
Monto Money Not Null,
Monto_Pagado Money Not Null,
Cambio Money Not Null,
Estado Varchar(20) Not Null,
Primary Key(Id_Factura),
Foreign Key(Id_Usuario) References Usuario(Id_Usuario),
Foreign Key(Id_Caja) References Caja(Id_Caja),
Foreign Key(Id_Apertura_De_Caja) References Apertura_De_Caja(Id_Apertura_De_Caja),
Foreign Key(Id_Cliente) References Cliente(Id_Cliente),
Foreign Key(Id_Dosificacion) References Dosificacion(Id_Dosificacion)
)
Go

Create Table Detalle_De_Factura
(
Id_Detalle_De_Factura Int Not Null Identity(1,1),
Id_Factura Int Not Null,
Id_Producto Int Not Null,
Detalle Varchar(24) Not Null,
Cantidad Decimal(18,3) Not Null,
Precio_Total Decimal(18,2) Not Null,
Estado Bit Not Null,
Primary Key(Id_Detalle_De_Factura),
Foreign Key(Id_Factura) References Factura(Id_Factura),
Foreign Key(Id_Producto) References Producto(Id_Producto),
)
Go

Create Table Monto_De_Devolucion
(
Id_Monto_De_Devolucion Int Not Null Identity(1,1),
Id_Usuario Int Not Null,
Id_Caja Int Not Null,
Id_Apertura_De_Caja Int Not Null,
Id_Egreso Int Not Null,
Fecha Date Not Null,
Hora Varchar(50) Not Null,
Monto Decimal(18,2) Not Null,
Cerrado Bit Not Null,
Estado Bit Not Null,
Primary Key(Id_Monto_De_Devolucion),
Foreign Key(Id_Usuario) References Usuario(Id_Usuario),
Foreign Key(Id_Caja) References Caja(Id_Caja),
Foreign Key(Id_Apertura_De_Caja) References Apertura_De_Caja(Id_Apertura_De_Caja)
)
Go
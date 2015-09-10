Use SuperMio
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
Estado Varchar(20) Not Null,
Primary Key(Id_Dosificacion),
Foreign Key(Id_Sucursal) References Sucursal(Id_Sucursal)
)
Go

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
Codigo_De_Barras Varchar(100) Not Null,
Nombre_Generico Varchar(100) Not Null,
Marca Varchar(100) Not Null,
Sabor_U_Olor Varchar(100) Not Null,
Cantidad_Minima Decimal(18,2) Not Null,
Precio Decimal(18,2) Not Null,
Estado Bit Not Null,
Primary Key (Id_Producto),
Foreign Key(Id_Grupo) References Grupo(Id_Grupo)
)

Create Table Caja
(
Id_Equipo Int Not Null Identity(1,1),
Nombre_De_Equipo Varchar(MAX) Not Null,
Numero Varchar(100) Not Null,
Estado Varchar(20) Not Null,
Primary Key(Id_Equipo)
)
Go

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
	Insert Into Usuario(Nombres, Apellido_Paterno, Apellido_Materno, Telefono, Nombre_De_Usuario, Clave, Estado)
	Values(@Nombres, @Apellido_Paterno, @Apellido_Materno, @Telefono, @Nombre_De_Usuario, @Clave, 1)
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
End
Go

Create Procedure insertarGrupo
@Nombre Varchar(100)
As
Begin
	Insert Into Grupo(Nombre, Estado)
	Values(@Nombre, 1)
End
Go

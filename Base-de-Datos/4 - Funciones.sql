Create Function buscarUsuarios()
Returns Table
Return
(
	Select ROW_NUMBER() OVER (ORDER BY Nombres) As Numero,  Id_Usuario,
	(Nombres + ' ' + Apellido_Paterno + ' ' + ISNULL(Apellido_Materno, '')) As Usuario
	From Usuario 
	Where Estado = 1
)
Go

Create Function buscarProveedores()
Returns Table
Return
(
	Select ROW_NUMBER() OVER (ORDER BY Nombre) As Numero, Id_Proveedor, Nombre, Persona_De_Contacto, Direccion, Telefono, Celular, Numero_De_Cuenta
	From Proveedor
	Where Estado = 1
)
Go

Create Function buscarGrupos()
Returns Table
Return
(
	Select ROW_NUMBER() OVER (ORDER BY Nombre) As Numero, Id_Grupo, Nombre
	From Grupo
	Where Estado = 1
)
Go

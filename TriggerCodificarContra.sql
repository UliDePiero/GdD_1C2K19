USE [GD1C2019];
GO
create trigger CodificarContrasenia
on PENSAMIENTO_LINEAL.Usuario
instead of insert
as
begin
	insert into PENSAMIENTO_LINEAL.Usuario ()
	select usua_nombre, usua_apellido,usua_direccion,usua_mail, HASHBYTES('SHA2_256',usua_password), usua_telefono, usua_documento, usua_fechanac
	from inserted
end
USE [GD1C2019];
GO
create function dbo.CodificarSha256(@contra varchar)
returns binary(32)
as
begin
return (HASHBYTES('SHA2_256',@contra))
end
GO
create trigger CodificarContrasenia
on PENSAMIENTO_LINEAL.Usuario
instead of insert
as
begin
insert into PENSAMIENTO_LINEAL.Usuario /*(usua_nombre,usua_apellido,usua_direccion,usua_mail,usua_password,usua_telefono,usua_documento,usua_fechanac)*/
select usua_nombre,usua_apellido,usua_direccion,usua_mail,usua_username,dbo.CodificarSha256(usua_password),usua_telefono,usua_documento,usua_fechanac
from inserted
where usua_username IS NOT NULL
end
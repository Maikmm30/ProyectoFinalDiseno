USE [D:\DISCO DURO 1 TB\DESCARGAS\TERCER CUATRIMESTRE\PROYECTOFINALDISENO\PROYECTOFINAL\INVENTARIO\INVENTARIO\DATABASE1.MDF]

SELECT * FROM log

INSERT INTO log VALUES ('admin', 'admin', 'admin'),
					   ('user','123', 'user');


DROP TABLE log;

CREATE TABLE [dbo].[USUARIOS]
(

[Nombre] VARCHAR(50) NULL,
[Usuario] VARCHAR(50) NULL,
[Password] VARCHAR(50) NULL,
[Tipo_usuario] VARCHAR(50) NULL

)

select * from USUARIOS

insert into USUARIOS values ('Alex Galicia', 'Alex03', '123', 'Admin'),
						   ('Carlos Pérez', 'Carlos', '321', 'Usuario');

insert into USUARIOS values ('William Courrau', 'Wcm500', '123', 'Admin');

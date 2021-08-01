-- Hemos decido crear una base de datos donde los usuarios solo pueden ser empleados, por lo tanto no hemos utilizado su dise�o.
-- Para esta primera fase de prueba no hemos creado la tabla completa.

use master;
go

drop database testJC;
go

create database testJC;
go

use testJC;
go

create table levels(
	id_level int identity(1,1) primary key,
	level_name varchar(6),
);
go

insert into levels (level_name) values ('admin'), ('normal');
go

CREATE TABLE [employees](
	[cedula] [varchar](11) primary key NOT NULL,
	[first_name] [varchar](25) NOT NULL,
	[last_name] [varchar](25) NOT NULL
	)
	go

	insert into employees values ( '00000000000', 'Admin first', 'Admin last')
	go

create table Tuser(
username varchar(20),
email varchar(max),
upassword varchar(max),
id_level int, 
cedula  varchar(11),
FOREIGN KEY (id_level) REFERENCES levels(id_level),
FOREIGN KEY (cedula) REFERENCES employees(cedula)
);
go

insert into Tuser values ('Administrador', 'admin@sys.com', '4f6af08f0ab26f8e1cf06b930c38ff186d76dbc1d6cf673578e11985a0c44d4b', 1, '00000000000');
go


create procedure  sp_signin
@email varchar(max),
@password varchar(max)
as
begin
select username, email, L.level_name as leveln, E.last_name as user_last_name
from Tuser as U 
inner join levels as L on U.id_level = L.id_level 
inner join employees as E on  U.cedula = E.cedula
where (email = @email or username = @email) and upassword= @password;
end
go

create procedure sp_signup
@username varchar(25),
@email varchar(max),
@password varchar(max),
@cedula varchar(max)
as
begin
insert into Tuser values (@username, @email, @password, 2, @cedula);
end
go

select *, 'Admin1234#' as 'Password Text' from Tuser;


-- exec sp_signin 'Administrador', '4f6af08f0ab26f8e1cf06b930c38ff186d76dbc1d6cf673578e11985a0c44d4b';

CREATE TABLE Client(
	ID INT IDENTITY(1,1),
	NAME NVARCHAR(30),
	LAST_NAME NVARCHAR(30),
	GENDER NVARCHAR(9),
	AGE INT,
	PHONE NVARCHAR(10),
	ADDRESS NVARCHAR(45),
	CREATION_DATE DATETIME
	CONSTRAINT PK_ID_CLIENT PRIMARY KEY
)
GO

CREATE PROC SP_INSERT_CLIENT (
	@NAME NVARCHAR(30),
	@LAST_NAME  NVARCHAR(30),
	@GENDER NVARCHAR(9),
	@AGE INT,
	@PHONE NVARCHAR(10),
	@ADDRESS NVARCHAR(45),
	@CREATION_DATE DATETIME
)
AS

INSERT INTO Client(NAME, LAST_NAME, GENDER, AGE, PHONE, ADDRESS, CREATION_DATE) 
VALUES (@NAME, @LAST_NAME,@GENDER, @AGE, @PHONE, @ADDRESS, GETDATE())
GO

CREATE PROC SHOW_CLIENTS
AS
SELECT ID,NAME, LAST_NAME, GENDER, AGE, PHONE, ADDRESS FROM Client
GO

CREATE PROC SP_UPDATE_CLIENT(
	@ID_CLIENT INT,
	@NAME NVARCHAR(30),
	@LAST_NAME  NVARCHAR(30),
	@GENDER NVARCHAR(9),
	@AGE INT,
	@PHONE NVARCHAR(10),
	@ADDRESS NVARCHAR(45)
)
AS
UPDATE Client SET NAME = @NAME, LAST_NAME = @LAST_NAME, GENDER = @GENDER, AGE = @AGE, PHONE = @PHONE, ADDRESS = @ADDRESS
			  WHERE ID = @ID_CLIENT
GO

CREATE PROC SP_DELETE_CLIENT @ID_CLIENT INT
AS
DELETE FROM Client WHERE ID = @ID_CLIENT
GO

EXEC SP_INSERT_CLIENT 'ISABEL', 'PEREZ', 'FEMENINA', 52, '8494324626', 'ENSANCHE NACO', ''
EXEC SHOW_CLIENTS
EXEC SP_UPDATE_CLIENT 1, 'ISABEL', 'PEREZ ', 'FEMENINA', 53, '8092345678', 'ENSANCHE NACO'
EXEC SP_DELETE_CLIENT 1


SELECT * FROM Client


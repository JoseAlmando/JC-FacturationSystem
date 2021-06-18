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

create table Tuser(
username varchar(20),
email varchar(max),
upassword varchar(max),
id_level int, 
FOREIGN KEY (id_level) REFERENCES levels(id_level)
);
go

insert into Tuser values ('Administrador', 'admin@sys.com', '4f6af08f0ab26f8e1cf06b930c38ff186d76dbc1d6cf673578e11985a0c44d4b', 1);
go


create procedure  sp_signin
@email varchar(max),
@password varchar(max)
as
begin
select username, email, L.level_name as leveln from Tuser as U inner join levels as L on U.id_level = L.id_level where (email = @email or username = @email) and upassword= @password;
end
go

create procedure sp_signup
@username varchar(25),
@email varchar(max),
@password varchar(max)
as
begin
insert into Tuser values (@username, @email, @password, 2);
end
go

select * from Tuser;


-- exec sp_signin 'Administrador', '4f6af08f0ab26f8e1cf06b930c38ff186d76dbc1d6cf673578e11985a0c44d4b';

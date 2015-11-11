--Cree una Base de Datos que se llame Arduino 

--Cree esta tabla, note que el codigo es de 26 Digitos , es lo que leemos de la tarjeta :D
Create table usuarios(
  
   code  varchar (50) primary key ,
   id    varchar (12), 
   propietario varchar (15),
   automovil varchar(30) ,
   vencido varchar (15),
   multas int

);
--Inserte estos datos de prueba
insert into usuarios values ('25351484850546652535357523', '1234', 'Jhonny Rojas', 'BMW 502',   'false' , 0);
insert into usuarios values ('25351484850546657684849673', '4321', 'Pablo Zamora', 'Ford ',  'true'  , 0);
insert into usuarios values ('25351484850546967657051543', '1324', 'Josue Pereira', 'Citroen', 'true',  0);


delete DELETE FROM usuarios
WHERE id=´1234´;--drop table usuarios;
--select * from usuarios;
--Update la columna vencido de una fila con el mismo codigo
update  usuarios 
  set vencido = 'false' where code = '25351484850546652535357523';

  update  usuarios 
  set multas = 0;

  update usuarios
  set vencido = 'false'
  where id='1234';




--drop table pasos;
--select * from pasos;
--truncate table pasos;

Create table pasos(
  
   code  varchar (50) foreign key references Usuarios(code), 
   datex  date    ,
   vencido varchar (15),

);	

insert into pasos values ('25351484850546652535357523',GETDATE(),'true');


go 



select 'Terrenos' as Tipo, count(*) as Cantidad from terrenos 
union select 'Locales' as Tipo, count(*) from locales
union select 'Casas' as Tipo, count(*)  from casas
union select 'Apartamentos' as tipo, count(*) from apartamentos;

select * from consumidores inner join clientes on consumidores.ci = clientes.ciconsumidor order by apellido;

select * from edificados where patios = 1 and cantidadambientes = 8;
select * from lugares where superficietotal > 350; 

select * from consumidores where ci = (select ciconsumidor from propietarios where ciconsumidor = (select cipropietario from lugares where codigopostal = 14000 and direccion = "Positos"));

select * from ofertas where id = (select max(id) from ofertas); 

select * from consumidores where ci = (select cipropietario from lugares, (select codigopostallugar, direccionlugar from ventas where idnegocio = (select id from negocios where id = (select max(id) from ofertas))) as tablita where codigoPostal = tablita.codigopostallugar and direccion = tablita.direccionLugar);

select count(*) from ofertas where year(fecha) = 2010;

select precio from (select precio,tabla.id from ofertas inner join (select * from negocios inner join ventas on negocios.id = ventas.idNegocio) as tabla on ofertas.idnegocio = tabla.id) as tablita where id = (select max(id) from ofertas) ;
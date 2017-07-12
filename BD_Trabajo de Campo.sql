use SistemaCampo

insert into MEDICOS
values 
('Ricardo Bendatti', 'Paraguay 3422', 1533421,'ricardo.bendatti@gmail.com', 54321, 19876678, 'Cardiologo', 1, 45),
('Raul Esperanza', 'Cordoba 3422', 15112233, 'raul.esperanza@gmail.com', 54654, 14654732, 'Pediatra', 1, 120),
('Federico Ruiz', 'Caferata 8766', 15656543, 'federico.ruiz@gmail.com', 54987, 12765876, 'Oculista', 1, 30),
('Mario Beltran', 'San Luis 3442', 15877798, 'mario.beltran@gmail.com', 548765, 110098678, 'Traumatologo', 1, 50),
('Monica Di Pietro', 'San Juan 2831', 15545463, 'monica.dipietro@gmail.com', 54099, 17656443, 'Psiquiatra', 1, 45),
('Luciana Gomez', 'Rioja 3213', 15345678, 'luciana.gomez@gmail.com', 53123, 19987987, 'Endocrinologo', 1, 60)

insert into HORARIOS_MEDICOS
values 
('09:00', '17:00', 'Lunes', 1),
('09:00', '18:00', 'Lunes', 2),
('10:00', '17:00', 'Lunes', 3),
('10:00', '19:00', 'Lunes', 4),
('09:00', '13:00', 'Lunes', 5),
('11:00', '19:00', 'Lunes', 6),
('12:00', '20:00', 'Martes', 1),
('09:00', '17:00', 'Martes', 2),
('10:00', '15:00', 'Martes', 3),
('09:00', '17:00', 'Miercoles', 2),
('10:00', '19:00', 'Miercoles', 3),
('12:00', '20:00', 'Miercoles', 4),
('11:00', '18:00', 'Miercoles', 5),
('09:00', '18:00', 'Jueves', 1),
('10:00', '19:00', 'Jueves', 2),
('11:00', '20:00', 'Jueves', 3),
('12:00', '18:00', 'Jueves', 4),
('09:00', '17:00', 'Jueves', 5),
('09:00', '18:00', 'Jueves', 6),
('09:00', '18:00', 'Viernes', 1),
('09:00', '15:00', 'Viernes', 2),
('10:00', '17:00', 'Viernes', 3),
('09:00', '18:00', 'Viernes', 4),
('11:00', '20:00', 'Viernes', 5),
('09:00', '19:00', 'Viernes', 6)

insert into PLANES
values 
('FULL 10', 'BUENO', 500, 1),
('FULL 11', 'MUY BUENO', 575, 1),
('FULL 12', 'MUY BUENO', 650, 1),
('FULL 13', 'EXCELENTE', 700, 1),
('FULL 14', 'EXCELENTE', 750, 1)

insert into DATOS_EMPRESAS
values 
('Hydra', 'Enrique Peña', 'Rosario')

insert into DIAS_EMPRESAS
values 
('Lunes', '09:00', '20:00', 1),
('Martes', '09:00', '20:00', 1),
('Miercoles', '09:00', '20:00', 1),
('Jueves', '09:00', '20:00', 1),
('Viernes', '09:00', '20:00', 1)

insert into DIAS_NO_LABORABLESS
values 
('2016-15-08 00:00:00.000', 'Feriado nacional', 1),
('2016-10-10 00:00:00.000', 'Feriado nacional', 1),
('2016-04-10 00:00:00.000', 'Feriado nacional', 1),
('2016-12-10 00:00:00.000', 'Feriado nacional', 1),
('2016-28-11 00:00:00.000', 'Feriado nacional', 1),
('2016-08-12 00:00:00.000', 'Feriado nacional', 1),
('2016-09-12 00:00:00.000', 'Feriado nacional', 1)

insert into AFILIADOS
values 
/*   nombre      |   Direccion   |        Mail             |   num    |  DNI    |     nacimieno           |    sexo     |nc|froma pago |es |P|  */
('Esteban Frare', 'Laprida 1440', 'frare.esteban@gmail.com', 15683663, 38140925, '1994-09-07 00:00:00.000', 'Masculino', 1, 'Debito Automático', 1, 1),
('Julian Cedaro', 'Cordoba 2431', 'julian.cedaro@gmail.com', 15876576, 38009376, '1994-02-09 00:00:00.000', 'Masculino', 2, 'Efectivo', 1, 1),
('Manuel Bogino', 'Maipu 1232', ' manuel.bogino@gmail.com', 15129842, 31654372, '1993-06-12 00:00:00.000', 'Masculino', 3, 'Efectivo', 1, 1),
('Alejandro Lupo ', 'Sarmiento 2354', 'ale.lupo@gmail.com', 15090932, 38987554, '1993-12-07 00:00:00.000', 'Masculino', 4, 'Efectivo', 1, 1),
('Carlos Kehoe', 'Montevideo 1223', 'carlos.kehoe@gmail.com', 15165321, 28765443, '1985-09-07 00:00:00.000', 'Masculino', 5, 'Efectivo', 1, 1),
('Cristian Balcarse', 'Rioja 2133', 'cristian.b@gmail.com', 15231231, 13231123, '1990-09-09 00:00:00.000', 'Masculino', 6, 'Efectivo', 1, 1),
('Raul Rios', 'Montevideo 4532', 'raul.rios@gmail.com', 15887643, 25631323, '1987-08-08 00:00:00.000', 'Masculino', 7, 'Efectivo', 1, 1),
('Luciano Castro', 'Santa Fe', 'castro.luciano@gmail.com', 159898776, 25654456, '1987-01-01 00:00:00.000', 'Masculino', 8, 'Efectivo', 1, 1),
('Carlos Paz', 'Bv Segui 2312', 'carlos.paz@gmail.com', 151233212, 20987009, '1978-03-10 00:00:00.000', 'Masculino', 9, 'Efectivo', 1, 1),
('Mariano Lazaro', 'Bv Oroño 1232', 'mariano.lazaro@gmail.com', 15766687, 16765887, '1965-09-01 00:00:00.000', 'Masculino', 10, 'Efectivo', 1, 1),
('Simon Nuñez', 'Larpida 1440', 'simon.nuñez@gmail.com', 159877635, 38240924, '1994-30-10 00:00:00.000', 'Masculino', 11, 'Efectivo', 1, 1),
('Tomas Semorile', '25 de mayo 546', 'semorile.tomas@gmail.com', 15113219, 36765009, '1995-09-03 00:00:00.000', 'Masculino', 12, 'Efectivo', 1, 1)

insert into TARJETAS
values 
('Esteban Frare', 1231312312332, '12/2019', 1)

insert into SERVICIOS
values 
('UNO', 'Cardiologia', '2015-09-07 00:00:00.000', 1),
('DOS', 'Pediatria', '2015-09-07 00:00:00.000', 1),
('TRES', 'Ocular', '2015-09-07 00:00:00.000', 1),
('CUATRO', 'traumatologia', '2015-09-07 00:00:00.000', 1),
('CINCO', 'Psiquiatria', '2015-09-07 00:00:00.000', 1),
('SEIS', 'Endocrinologia', '2015-09-07 00:00:00.000', 1)

insert into PLANSERVICIO 
values 
(5, 1),
(5, 2),
(5, 3),
(5, 4),
(5, 5),
(5, 6),
(4, 1),
(4, 2),
(4, 3),
(4, 4),
(4, 5),
(3, 1),
(3, 2),
(3, 3),
(3, 4),
(2, 1),
(2, 2),
(2, 3),
(1, 1),
(1, 2)

insert into TURNOS
values                                            /* C| M | A  */
/* Doctor Bendatti */
/* 01/08/2016      LUNES*/
('Registrado', '2016-01-08 09:00:00.000', 'Control', 1, 1, 1),
('Registrado', '2016-01-08 09:45:00.000', 'Control', 1, 1, 2),
('Registrado', '2016-01-08 10:30:00.000', 'Control', 1, 1, 3),
('Registrado', '2016-01-08 11:15:00.000', 'Control', 1, 1, 4),
('Registrado', '2016-01-08 12:00:00.000', 'Control', 1, 1, 5),
('Registrado', '2016-01-08 12:45:00.000', 'Control', 1, 1, 6),
('Registrado', '2016-01-08 13:30:00.000', 'Control', 1, 1, 7),
('Registrado', '2016-01-08 14:15:00.000', 'Control', 1, 1, 8),
('Registrado', '2016-01-08 15:00:00.000', 'Control', 1, 1, 9),
('Registrado', '2016-01-08 15:45:00.000', 'Control', 1, 1, 10),
('Registrado', '2016-01-08 16:15:00.000', 'Control', 1, 1, 11),
/* 02/08/2016      MARTES*/
('Registrado', '2016-02-08 12:00:00.000', 'Control', 1, 1, 5),
('Registrado', '2016-02-08 12:45:00.000', 'Control', 1, 1, 6),
('Registrado', '2016-02-08 13:30:00.000', 'Control', 1, 1, 7),
('Registrado', '2016-02-08 14:15:00.000', 'Control', 1, 1, 8),
('Registrado', '2016-02-08 15:00:00.000', 'Control', 1, 1, 9),
('Registrado', '2016-02-08 15:45:00.000', 'Control', 1, 1, 10),
('Registrado', '2016-02-08 16:15:00.000', 'Control', 1, 1, 11),
('Registrado', '2016-02-08 17:00:00.000', 'Control', 1, 1, 12),
('Registrado', '2016-02-08 17:45:00.000', 'Control', 1, 1, 1),
('Registrado', '2016-02-08 19:15:00.000', 'Control', 1, 1, 2),
/* 08/08/2016      LUNES*/
('Registrado', '2016-08-08 09:00:00.000', 'Control', 1, 1, 1),
('Registrado', '2016-08-08 09:45:00.000', 'Control', 1, 1, 2),
('Registrado', '2016-08-08 10:30:00.000', 'Control', 0, 1, 3),
('Registrado', '2016-08-08 11:15:00.000', 'Control', 1, 1, 4),
('Registrado', '2016-08-08 12:00:00.000', 'Control', 1, 1, 5),
('Registrado', '2016-08-08 12:45:00.000', 'Control', 0, 1, 6),
('Registrado', '2016-08-08 13:30:00.000', 'Control', 1, 1, 7),
('Registrado', '2016-08-08 14:15:00.000', 'Control', 1, 1, 8),
('Registrado', '2016-08-08 15:00:00.000', 'Control', 0, 1, 9),
('Registrado', '2016-08-08 15:45:00.000', 'Control', 1, 1, 10),
('Registrado', '2016-08-08 16:15:00.000', 'Control', 1, 1, 11),
/* 09/08/2016      MARTES*/
('Registrado', '2016-09-08 12:00:00.000', 'Control', 1, 1, 5),
('Anulado', '2016-09-08 12:45:00.000', 'Control', 0, 1, 6),
('Registrado', '2016-09-08 13:30:00.000', 'Control', 1, 1, 7),
('Registrado', '2016-09-08 14:15:00.000', 'Control', 1, 1, 8),
('Registrado', '2016-09-08 15:00:00.000', 'Control', 1, 1, 9),
('Registrado', '2016-09-08 15:45:00.000', 'Control', 1, 1, 10),
('Registrado', '2016-09-08 16:15:00.000', 'Control', 1, 1, 11),
('Anulado', '2016-09-08 17:00:00.000', 'Control', 0, 1, 12),
('Registrado', '2016-09-08 17:45:00.000', 'Control', 1, 1, 1),
('Registrado', '2016-09-08 19:15:00.000', 'Control', 0, 1, 2),
/* 22/08/2016      LUNES*/
('Registrado', '2016-22-08 09:00:00.000', 'Control', 0, 1, 1),
('Registrado', '2016-22-08 09:45:00.000', 'Control', 0, 1, 2),
('Anulado', '2016-22-08 10:30:00.000', 'Control', 0, 1, 3),
('Registrado', '2016-22-08 11:15:00.000', 'Control', 0, 1, 4),
('Registrado', '2016-22-08 12:00:00.000', 'Control', 0, 1, 5),
('Registrado', '2016-22-08 12:45:00.000', 'Control', 0, 1, 6),
('Registrado', '2016-22-08 13:30:00.000', 'Control', 0, 1, 7),
('Anulado', '2016-22-08 14:15:00.000', 'Control', 0, 1, 8),
('Registrado', '2016-22-08 15:00:00.000', 'Control', 0, 1, 9),
('Registrado', '2016-22-08 15:45:00.000', 'Control', 0, 1, 10),
('Registrado', '2016-22-08 16:15:00.000', 'Control', 0, 1, 11),
/* 29/08/2016      LUNES*/
('Registrado', '2016-29-08 09:00:00.000', 'Control', 0, 1, 1),
('Registrado', '2016-29-08 09:45:00.000', 'Control', 0, 1, 2),
('Registrado', '2016-29-08 10:30:00.000', 'Control', 0, 1, 3),
('Registrado', '2016-29-08 11:15:00.000', 'Control', 0, 1, 4),
('Registrado', '2016-29-08 12:00:00.000', 'Control', 0, 1, 5),
('Registrado', '2016-29-08 12:45:00.000', 'Control', 0, 1, 6),
('Registrado', '2016-29-08 13:30:00.000', 'Control', 0, 1, 7),
('Registrado', '2016-29-08 14:15:00.000', 'Control', 0, 1, 8),
('Registrado', '2016-29-08 15:00:00.000', 'Control', 0, 1, 9),
('Registrado', '2016-29-08 15:45:00.000', 'Control', 0, 1, 12),
('Anulado', '2016-29-08 15:45:00.000', 'Control', 0, 1, 10),
('Registrado', '2016-29-08 16:15:00.000', 'Control', 0, 1, 11)

/*
select * from DATOS_EMPRESAS
select * from AFILIADOS
select * from PLANES
select * from SERVICIOS
select * from MEDICOS
select * from HORARIOS_MEDICOS
select * from DIAS_EMPRESAS
select * from DIAS_NO_LABORABLESS
select * from TURNOS
select * from PLANSERVICIO
select * from TARJETAS
select * from PRODUCTOS
select * from AUDITORIA_TURNOS
select * from AUDITORIAS
*/


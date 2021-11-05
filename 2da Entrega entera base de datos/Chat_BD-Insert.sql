/*Alumnos*/
insert into Usuario(Ci, nombre, apellido, Username, contraseña,estado) value(51996594, 'Pablo', 'Sosa', 'Paso', 'P894526873',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña,estado) value(54357935, 'joaquin', 'ferreira', 'Joacote', 'J4965487354',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña,estado) value(53489753, 'Alejandro', 'Rodriguez', 'Aleord55', 'Alejandro12',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña,estado) value(53106408, 'Mario', 'Santos', 'Santos12', 'MS8768752',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña,estado) value(52987456, 'Agustin', 'Rodales', 'Agusrodales', 'Ap46586546',1);

insert into Alumno value (51996594,1);
insert into Alumno value (54357935,1);
insert into Alumno value (53489753,1);
insert into Alumno value (53106408,1);
insert into Alumno value (52987456,1);

/*Docentes*/
insert into Usuario(Ci, nombre, apellido, Username, contraseña) value(36843456, 'Martin', 'Viar', 'Viar', 'MV8796574',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña) value(37954689, 'Marcos', 'Palermo', 'Palermo12', 'IgSalvia987657',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña) value(16584358, 'Cristian', 'Gonzalez', 'Cristiano', 'CrGz9866864',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña) value(13548965, 'Enrique', 'Rosales', 'Enrique23', 'EnrEs9887354',1);
insert into Usuario(Ci, nombre, apellido, Username, contraseña) value(23549689, 'Pablo', 'Perrone', 'Perrone21', 'PPP1084654',1);

insert into Docente value (36843456,1);
insert into Docente value (37954689,1);
insert into Docente value (16584358,1);
insert into Docente value (13548965,1);
insert into Docente value (23549689,1);

/*Administrador*/
insert into Usuario(Ci, nombre, apellido, Username, contraseña) value(53584031, 'Alejo', 'Nievas', 'AleNievas18', 'AlNs986654');
insert into Administrador value (53584031, 'Modificar datos');


Insert into Grupo value('3ºBA',68968968);
Insert into Grupo value('3ºBA1',12312312);
Insert into Grupo value('3ºBB',99999998);

insert into Tiene value(51996594,68968968);
insert into Tiene value(54357935,12312312);
insert into Tiene value(53489753,99999998);
insert into Tiene value(53106408,68968968);
insert into Tiene value(52987456,12312312);

Insert into Asignatura value(12121212,'Proyecto');
Insert into Asignatura value(34343434,'Programacion');
Insert into Asignatura value(12128128,'Matematicas');
Insert into Asignatura value(22129999,'Geometria');

insert into Trabaja value(36843456, 12121212);
insert into Trabaja value(37954689, 34343434);
insert into Trabaja value(16584358, 12128128);
insert into Trabaja value(13548965, 22129999);
insert into Trabaja value(23549689, 34343434);

insert into Consulta value(11112222,'Profesor, tengo dudas sobre los temas de escrito', 'Realizada', 'Lunes', 36843456, 51996594);
insert into Consulta value(22221111,'Tuvistes un error ocacionado por falto de ; y gramatical', 'Contestada', 'Martes', 37954689, 54357935);
insert into Consulta value(11221122,'Los practicos de derivadas te ayudaran a practicar para el escrito', 'Respondida', 'Lunes', 16584358, 51996594);
insert into Consulta value(99911299,'Profe, como se calcula la pendiente en el caso 5 del practico?', 'Realizada', 'Viernes', 13548965, 53489753);
insert into Consulta value(15687965,'Con que programa usaremos para programar este año?', 'Realizada', 'Jueves', 23549689, 53106408);

insert into Supervisa Value(55966549,11112222);
insert into Supervisa Value(51996596,22221111);
insert into Supervisa Value(55966549,11221122);
insert into Supervisa Value(59876546,99911299);
insert into Supervisa Value(59876546,15687965);

insert into realiza value(68968968, 12121212);
insert into realiza value(12312312, 34343434);
insert into realiza value(99999998, 12128128);
insert into realiza value(12312312, 22129999);
insert into realiza value(12312312, 34343434);

insert into Chat value(99999999, 'Alumnos totales presentes, se dio tema nuevo', 0, 34, 'Oyente', 36843456, 51996594);
insert into Chat value(99988877, 'Consultas sobre codigo y compresion de programa', 1, 0, 'Anfitrion', 37954689, 54357935);
insert into Chat value(99876123, 'Se resolvieron 3 ejercicios y se dio tema nuevo', 1, 0, 'Anfitrion', 16584358, 54357935);

insert into Mensaje value('2021-04-05', 99999999, 'Alumnos totales presentes, se dio tema nuevo', 0, 34);
insert into Mensaje value('2021-06-05', 99988877, 'Consultas sobre codigo y compresion de programa', 0, 32);
insert into Mensaje value('2021-06-06', 99988877, 'Se resolvieron 3 ejercicios y se dio tema nuevo', 1, 0);





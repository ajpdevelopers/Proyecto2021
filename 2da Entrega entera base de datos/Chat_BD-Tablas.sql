create database Chat_BD;
use Chat_BD;

create table Usuario(Ci int(8) primary key not null, nombre varchar(45) not null, apellido varchar (45) not null, 
Username varchar(45) not null, contraseña varchar(45) not null, ImagenDePerfil longblob);


create table Alumno(Ci int primary key not null, foreign key (Ci) references Usuario(Ci));
create table Grupo(Nomgrupo Varchar(10) not null, IDGrupo int primary key not null);
create table tiene(CiAlumno int not null, IDGrupo int not null, foreign key (IDGrupo) references Grupo(IDGrupo), 
foreign key (CiAlumno) references Alumno(Ci));

create table Docente(Ci int primary key not null, foreign key (Ci) references Usuario(Ci));
create table Asignatura(IdMateria int primary key not null, Materia Varchar(20) not null);
create table trabaja(CiDocente int not null, IDMateria int not null, foreign key (CiDocente) references Docente(Ci),
foreign key (IDMateria) references Asignatura(IdMateria));

create table Administrador(Ci int primary key not null, permisos enum('Modificar datos','Registros') not null, foreign key (Ci) references Usuario(Ci));
create table Consulta(IdConsulta int(8) primary key not null, Contenido varchar(500),Estado enum('Realizada','Respondida','Contestada') not null, 
Agenda enum('Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado','Domingo') not null, CiDocente int not null, CiAlumno int not null, 
foreign key (CiAlumno) references Alumno(Ci), foreign key (CiDocente) references Docente(Ci)); 
create table Supervisa(CiAdm int not null, IdCons int not null, foreign key (CiAdm) references Administrador(Ci));

create table realiza(IDGrupo int not null, IdMateria int not null, foreign key (IDGrupo) references Grupo(IDGrupo),
foreign key (IdMateria) references Asignatura(IdMateria));


create table Chat(IDChat int(8) primary key not null, Registro Varchar(800) not null, Individual int(16) not null, Grupal int(248) not null, 
Calidad enum('Anfitrion','Oyente') not null, CiDocente int not null, CiAlumno int not null,
foreign key (CiDocente) references Docente(Ci), foreign key (CiAlumno) references Alumno(Ci));

create table Mensaje(Fecha date primary key not null, IDChat int not null, Registro Varchar(800) not null,
 Individual int(16) not null, Grupal int(248) not null, foreign key (IDChat) references Chat(IDChat) );
 
create role 'administracion';
Grant all on Chat_BD.* to administracion;

create role 'Profesor';
grant update (nombre), update (apellido), update (contraseña), update (Username), update (ImagenDePerfil) on Chat_BD.Usuario to Profesor;
grant select (nombre), select (apellido), select (Username), select (ImagenDePerfil) on Chat_BD.Usuario to Profesor;
grant select (estado), select (agenda), select (idconsulta) on Chat_BD.consulta to Profesor;
grant select (IDChat), select (Registro), select (CiAlumno) on Chat_BD.chat to Profesor;
grant select (IDMateria), select (Materia) on Chat_BD.Asignatura to Profesor;

create role 'Estudiante';
grant update (nombre), update (apellido), update (contraseña), update (Username), update (ImagenDePerfil) on Chat_BD.Usuario to Estudiante;
grant select (nombre), select (apellido), select (Username), select (ImagenDePerfil) on Chat_BD.Usuario to Estudiante;
grant select (estado), select (agenda), select (idconsulta) on Chat_BD.consulta to Estudiante;
grant select (IDChat), select (Registro) on Chat_BD.chat to Estudiante;
grant select (nomgrupo), select (IdGrupo) on Chat_BD.Grupo to Estudiante;

Show grants for administracion;
show grants for Profesor;
show grants for Estudiante;
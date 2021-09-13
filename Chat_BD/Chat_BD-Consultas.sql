/*1*/
select nombre, count(CiAlumno)
from alumno, consulta, Usuario
where alumno.Ci = Usuario.Ci and alumno.Ci = CiAlumno
group by CiAlumno;

/*2*/
select Nomgrupo, count(g.IDGrupo)
from grupo g, chat c, alumno, tiene t
where c.CiAlumno = Ci and t.CiAlumno = Ci and t.IDGrupo = g.IDGrupo
group by Nomgrupo;

/*3*/
select Materia
from asignatura A, chat C, docente D, trabaja T
where D.Ci = C.CiDocente and D.Ci = T.CiDocente and T.IDMateria = A.IdMateria
group by Materia
having count(a.IdMateria)>3;

/*4*/
select nombre, apellido, estado, agenda Consulto, fecha ChatDia, c.Registro
from usuario u, alumno a, chat c, consulta co, mensaje m
where a.Ci = c.CiAlumno and c.IDChat = m.IDChat and co.CiAlumno = a.Ci and a.Ci = u.ci;


/*5*/
select nombre, count(c.CiDocente)
from docente d, chat c, mensaje m, usuario u
where d.Ci=c.CiDocente and c.IDChat = m.IDChat and u.Ci=d.Ci and fecha>=(curdate()-interval 1500 day)
group by D.Ci;

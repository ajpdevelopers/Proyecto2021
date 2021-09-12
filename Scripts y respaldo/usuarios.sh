#!/bin/bash
echo  "ADMINISTRACION DE USUARIOS" 
echo  "--------------------------"
echo  "1- Agregar usuario con su directorio"
echo  "2- Eliminar usuario"
echo  "3- Gestionar contraseña"
echo  "4- Crear grupo"
echo  "5- Eliminar grupo"
echo  "6- Agregar Usuario a un grupo"
echo  "7- Eliminar usuario de un grupo" 
echo  "8- salir"
echo  "Seleccione una opcion: "
read opcion
case $opcion in
1)echo  "introduzca nombre del nuevo usuario: "
    	read nombre 
    	useradd  $nombre
      	echo  "el usuario creado es " $nombre
	echo "crear contraseña del usuario"
        read passwd 
	passwd $nombre
        echo "creacion exitosa"  
         
    ;;
2)echo -n "Introduzca nombre del usuario que desea eliminar: "
  read nombreeli
  userdel $nombreeli
  ;;
3)---------------------------
  ;;
4)echo -n "Introduzca nombre para nuevo grupo: "
  read grup
  groupadd $grup
  ;;
5)echo -n  "Introduzca nombre del grupo que desea eliminar: "
  read $grupo
  groupdel $grupo
  ;; 
6)echo -n "Introduzca nombre del usuario que quiere agregar al grupo: "
  read agrega
  echo -n "Introduzca nombre del grupo:"
  read group
  Usermod -g $group $agrega
  ;;
7)echo -n "Introduzca nombre del usuario que desea eliminar del grupo: "
  read elimgru
  echo -n "Introduzca nombre del grupo: "
  read gr
  gpasswd -a  $elimgru $gr
  ;; 
8)echo "esta saliendo del administrador"
  ;;
esac
 

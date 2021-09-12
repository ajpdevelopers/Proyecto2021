#!/bin/bash
echo  "Centro de computos"
echo  " -----------------------"
echo  "1- ABM-Usuarios"
echo  "2- Respaldo"
echo  "3- logs"
echo  "4- salir"
echo  "seleccione una opcion: "
read opcion
case $opcion in
1) source usuarios.sh  ;;
2) source respaldo.sh ;;
3) source logs.sh ;;	
4) echo "esta saliendo del centro de computos" ;;
esac


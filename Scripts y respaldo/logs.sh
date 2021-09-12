#!/bin/bash
echo "Bienvenido a la visualizacion de logs del sistema"
echo "-------------------------------------------------"
echo "1-Logins exitosos"
echo "2-Logins fallidos"
echo "3-Reporte de los ultimos 30 dias"
echo "4-Actividad general del usuario"
echo "5-Informacion sobre los usuarios conectados"
echo "6-salir" 
echo "Seleccione una opcion: "
read opcion
case $opcion in
1) last  /var/log/wtmp ;; 
2) lastb /var/log/btmp ;;	
3) lastlog -t 30 ;;
4) w -  ;;
5) who -H -u -q ;;
6)esac


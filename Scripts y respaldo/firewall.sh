#!/bin/bash
echo "Bienvenido a la configuracion del firewall"
echo "--------------------------------------------"
echo "1-Iniciar firewall"
echo "2-Habilitar firewall"
echo "3-Deshabilitar firewall"
echo "4-Detener firewall"
echo "5-Status firewall cmd"
echo "6-Status firewalld"
echo "Seleccione una opcion: "
read opcion
case $opcion in
1) echo "Ha iniciado el firewall"
   sudo systemctl start firewalld;;
2) echo "Ha habilitado el firewall" 
   systemctl enable firewalld;;
3) echo "Ha desactivado el firewall"  
sudo systemctl disable firewalld;;
4) echo "Ha detenido el firewall" 
sudo systemctl stop firewalld;;
5) sudo firewall-cmd --state;;
6) sudo systemctl status firewalld;;
esac

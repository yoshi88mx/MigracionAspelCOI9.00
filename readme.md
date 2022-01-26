## Migrador de Aspel COI 8.0 a Aspel COI 9.0

Este programa acelera la migracion de la version 8 a 9, lo que debe hacerse es instalar la version 9 de COI, ingresar 
al Dacaspel de la version 8 de COI y copiar el contenido de la carpeta "Datos" y pegarlo dentro de la carepta de version 9.
Despues copiamos el archivo Conexiones.ini y empresas.xml de la carpeta de la version 8 y lo pegamos dentro del la carpeta
de la version 9, respaldando prevaimente dichos archivos en el destino.

Despues mediante linea de comandos ejecutamos el .exe compilado de este proyecto agregando como argumento la ruta de la carpeta
de la version 9 de COI dentro de Dacaspel.

Quedando el comando de la siguiente manera: 

.\MIGCOI.exe "C:\Program Files (x86)\Common Files\Aspel\Sistemas Aspel\COI9.00\"

Por ultimo renombramos el archvio resultante Conexiones9.ini a Conexiones.ini, respaldando el archivo previamente.

Las carpetas que contienen los reportes se generan automaticamente al ingresar a cada empresa Datos1, Datos2, Datos3, etc.
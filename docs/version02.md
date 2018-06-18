# QEdit

## Version 01: Moving through the text

This second version should allow the user to move through the text:

- If the left cursor key is pressed, the cursor will go back one position (the 
program will work in "insert mode": if new letters are pressed, the existing 
ones will move to the right to "leave room fot the new letters"); if the new 
letters are written at the end of a line, the program will behave as before, 
adding text to the end of the line. Obviously, the cursor should not go back 
any further if it is already in the first column.

- If the right cursor key is pressed, the cursor will advance one position, 
unless it is already in the last character of the current line. In this 
version, lines of more than 80 characters will be allowed, so, for example, if 
the current line has 90 characters and the user moves to the last of those 90 
characters, columns 11 to 90 will be displayed (instead of 1 to 80) for ALL the 
lines.

- If the Home key is pressed, the cursor will move to the beginning of the 
current line.

- If the End key is pressed, the cursor will move to the beginning of the 
current line.

- If the up cursor key is pressed, the cursor will move to the same position of 
the previous line, unless it is shorter (for example, if it was in column 40, 
it will continue in 40 of the previous line; if the previous line contained 30 
letters, will stay in column 30).

- If you press the cursor arrow up, the cursor will move to the same position 
of the previous line, unless it is shorter (for example, if it was in column 
40, it will continue in 40 of the previous line; if the previous line contained 
30 letters, it will stay in column 30).

- If the cursor arrow is pressed down, the cursor will move to the same position of the following line, in the same conditions as the previous case.

In addition, if the file name indicated when loading the program is that of an 
existing file, the text it contains will be shown on the screen and the cursor 
will remain in the first row and column.


---

## Entrega 02: Moverse por el texto

Esta segunda versión debe permitir al usuario moverse por el texto:

- Si se pulsa la flecha de cursor izquierda, el cursor retrocederá una posición 
(el programa trabajará en modo de "inserción": si se pulsan nuevas letras, las 
existentes se desplazarán hacia la derecha para "dejarles sitio"); si se 
escribe al final de una línea, se comportará como antes, añadiendo texto al 
final de la línea. Obviamente, el cursor no debe retroceder más si ya está en 
la primera columna.

- Si se pulsa la flecha de cursor derecha, el cursor avanzará una posición, a 
no ser que ya se encuentre en el último carácter de la línea actual. En esta 
versión, sí se permitirá líneas de más de 80 caracteres, de modo que, por 
ejemplo, si la línea actual tiene 90 caracteres y el usuario se desplaza hasta 
el último de esos 90 caracteres, se mostrará las columnas 11 a 90 (en vez de 1 
a 80) de TODAS las líneas.

- Si se pulsa la tecla Inicio, el cursor se moverá al principio de la línea 
actual.

- Si se pulsa la tecla Fin, el cursor se moverá al principio de la línea 
actual.

- Si se pulsa la flecha de cursor arriba, el cursor se moverá a la misma 
posición de la línea anterior, salvo que sea más corta (por ejemplo, si estaba 
en la columna 40, seguirá en la 40 de la línea anterior; si la línea anterior 
contenía 30 letras, se quedará en la columna 30).

- Si se pulsa la flecha de cursor abajo, el cursor se moverá a la misma 
posición de la línea posterior, en las mismas condiciones que el caso anterior.

Además, si el nombre de fichero que se indique al cargar el programa 
corresponde al de un fichero ya existente, se mostrará en pantalla el texto que 
contiene y el cursor se quedará en la primera fila y columna.



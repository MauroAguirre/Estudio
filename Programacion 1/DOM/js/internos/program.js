window.onload = Load;

function Load()
{
	var btns = document.getElementsByClassName("btnBorrar");
	for(var i = 0; i < btns.length; i++)
	{
		btns[i].onclick = borrar;		
	}	
}

function borrar()
{
	var pepe = this; //Botón
	var columna = pepe.parentNode;  // Columna
	var fila = columna.parentNode; // Fila
	
	
	var tabla = fila.parentNode; //Tabla	
	var filas = tabla.childNodes;
	var fila1;
	
	for(var i = 0; i<filas.length; i++)
	{
		var atrFila = filas[i].getAttribute("filaId");
		if(atrFila == "f1");
		{
			fila1 = filas[i]; 
		}
	}
	
// ******* JQuery *******

//children(): devuelve los elementos hijo que contiene el especificado.
//get(): usado para acceder directamente a los elementos del DOM.
//prev() / next(): devuelven los elementos anterior y siguiente respectivamente.
//parent(): devuelve el elemento padre del especificado.
//parents(): devuelve los padres de un elemento en los distintos niveles dentro del árbol DOM.
//siblings(): devuelve los elementos 'hermanos' que están al mismo nivel del especificado.


// ******* JS *******

//parentNode devuelve el nodo padre
//childNodes devuelve un objeto nodeList(hijos)
//firstChild devuelve el primer nodo hijo
//lastChild devuelve el último nodo hijo
//previousSibling devuelve el hermano menor
//nextSibling devuelve el hermano mayor
	
	
	
	
	
	
	
	
	//fila.remove();
	
	
	
	
}





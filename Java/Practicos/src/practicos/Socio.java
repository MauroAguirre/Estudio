/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package practicos;

/**
 *
 * @author Mauro
 */
public class Socio {
    private String nombre;
    private int numero;
    private static int proximoNumero = 0;
    public Socio(String nombre)
    {
        this.nombre = nombre;
        numero = ++proximoNumero;
    }
    public int Numero()
    {
        return numero;
    }
    public String Nombre()
    {
        return nombre;
    }
    public void Modificar_nombre(String nombre)
    {
        this.nombre = nombre;
    }
    public String Mostrar()
    {
        return numero+" - "+nombre;
    }
}

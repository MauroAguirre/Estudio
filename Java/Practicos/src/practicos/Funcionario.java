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
public class Funcionario {
    private String nombre;
    private int sueldo;
    public Funcionario(String nombre, int sueldo)
    {
        this.nombre = nombre;
        this.sueldo = sueldo;
    }
    public int Sueldo()
    {
        return sueldo;
    }
    public void Modificar(String nombre, int sueldo)
    {
        this.nombre = nombre;
        this.sueldo = sueldo;
    }
    public String Mostrar()
    {
        return nombre+" - "+sueldo;
    }
}

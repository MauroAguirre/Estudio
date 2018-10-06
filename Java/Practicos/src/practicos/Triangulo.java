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
public class Triangulo {
    private int a;
    private int b;
    private int c;
    public Triangulo(int a,int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public boolean EsEscaleno()
    {
        if(a!=b && a!=c && b!=c)
        {
             return true;
        }
        else
        {
            return false;
        }  
    }
    public boolean EsIsosceles()
    {
        if((a == b && b!= c)|| (b==c && c!=a) || (c==a && c!= b))
        {
            return true;
        }
        else
        {
            return false;
        }  
    }
    public boolean EsEquilatero()
    {
        if(a==b && b==c)
        {
            return true;
        }
        else
        {
            return false;
        }  
    }
    public boolean TieneAnguloRecto()
    {
        if(a*a +b*b == c*c || a*a +c*c == b*b || b*b + c*c == a*a)
        {
            return true;
        }
        return false;
    }
}

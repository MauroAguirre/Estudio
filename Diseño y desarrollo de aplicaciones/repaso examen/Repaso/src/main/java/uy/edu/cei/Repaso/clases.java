package uy.edu.cei.Repaso;



public class clases {
	public static abstract class A
    {
    	private int valor;
    	public A(int i) {
    		valor = 1;
    		System.out.println(getValor());
    	}
    	public String getValor() 
    	{
    		return String.valueOf(valor);
    	}
    	public String m() 
    	{	
    		return ma() + " - "+mb()*2;
    	}
    	public abstract String ma();
    	public abstract int mb();
    }
    public static class A1 extends A
    {
    	private String valor = "Sin especificar";
    	public A1(int i,String s) 
    	{
    		super(i);
    		valor = s;
    	}
    	public String getValor() 
    	{
    		return valor;
    	}
    	public String ma() 
    	{
    		return "A1";
    	}
    	public int mb() 
    	{
    		return 1;
    	}
    }
    public static class A2 extends A
    {
    	public A2() 
    	{
    		this(2);
    	}
    	public A2(int i)
    	{
    		super(i);
    	}
    	public String ma()
    	{
    		return "A2" + ""+mb();
    	}
    	public int mb() 
    	{
    		return 2;
    	}
    }
}

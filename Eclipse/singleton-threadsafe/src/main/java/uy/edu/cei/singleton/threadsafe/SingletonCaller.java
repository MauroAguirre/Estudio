package uy.edu.cei.singleton.threadsafe;

public class SingletonCaller extends Thread{
	/*
	@Override
	public void run() {
		int counter = 0;
		while(counter <10) {
			System.out.println(counter);
			try {
				sleep(100);
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			counter++;
		}
	}
	*/
	private Singleton singleton;
	private long sleep;
	private String nombre;
	
	public SingletonCaller(long sleep,String nombre) {
		this.sleep = sleep;
		this.nombre = nombre;
	}
	
	public void run() {
		try {
			this.singleton = Singleton.GetInstancia();
			Thread.sleep(sleep);
			this.singleton.Dame3(this.nombre);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		System.out.println(singleton);
		
	}
	public Singleton getS() {
		return singleton;
	}
	public void setS(Singleton s) {
		this.singleton = s;
	}
}

package uy.edu.cei.singleton.threadsafe;

public class Singleton {
	private static Singleton instance = null;
	//private static Singleton instance == new Singleton();
	private Singleton() {
		
	}
	//el problema del synchronized es que bloquea todo el objeto, por ejemplo no se pueden llamar metodos del objeto mientras esta bloqueado
	public synchronized static Singleton GetInstancia() throws InterruptedException {
		if(instance == null) {
			System.out.println("wopa");
			Thread.sleep(1000);
			instance = new Singleton();
		}	
		return instance;
	}
	public void Dame3(String nombre) {
		System.out.println(String.format("%s - %s",":)",nombre));
	}
	/*
	public static Singleton GetInstance(){
		return instance;
	}
	 */
}

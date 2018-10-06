package uy.edu.cei.singleton.threadsafe;

public class CreaLineas extends Thread {
	private long tiempo;
	
	public CreaLineas(long tiempo) {
		this.tiempo = tiempo;
	}
	
	public void run() {
		int num = 10;
		while(num>0) {
			System.out.println("---");
			try {
				Thread.sleep(tiempo);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
			num--;
		}
		
	}
}

package uy.edu.cei.observer;

import java.awt.EventQueue;

public class App {

	public static void main(String[] args) {
		Observable server = new Server();
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Cliente c1 = new Cliente(server);
					Cliente c2 = new Cliente(server);
					server.addObservable(c1);
					server.addObservable(c2);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
}

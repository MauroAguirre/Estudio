package uy.edu.cei.observerrmi.client;

import java.awt.EventQueue;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

import uy.edu.cei.observerrmi.common.Observable;
import uy.edu.cei.observerrmi.common.ServerApp;

public class ClientMain {

	public static void main(String[] args) throws RemoteException, NotBoundException {
		Registry registry = LocateRegistry.getRegistry(1099);
		ServerApp serverApp = (ServerApp) registry.lookup("server");
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ChatWindow window = new ChatWindow(serverApp);
					System.out.println("Ventana");
					((Observable) serverApp).subscribe(window);
					System.out.println("suscribir");
					serverApp.sayHello("me quiero matar");
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

}

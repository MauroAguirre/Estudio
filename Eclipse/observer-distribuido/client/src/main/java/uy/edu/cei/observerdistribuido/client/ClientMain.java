package uy.edu.cei.observerdistribuido.client;

import java.awt.EventQueue;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

import uy.edu.cei.observerdistribuido.common.ServerApp;

public class ClientMain {

	public static void main(String[] args) throws RemoteException, NotBoundException {
		// TODO Auto-generated method stub
		Registry registry = LocateRegistry.getRegistry(1099);
		ServerApp serverApp = (ServerApp) registry.lookup("server");
		serverApp.SayHello("Mauro");
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Game juego = new Game();
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

}

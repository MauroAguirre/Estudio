package uy.edu.cei.generala.client;

import java.awt.EventQueue;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

import uy.edu.cei.generala.client.ui.MainWindow;
import uy.edu.cei.generala.client.ui.panel.LoginPanel;
import uy.edu.cei.generala.domain.UserModel;

public class App {
	
	// Esto esta mal!!!
	public static UserModel user;
	
	public static void main(String[] args) throws RemoteException, NotBoundException {
		
		EventQueueClient generalaClient = EventQueueClient.getInstance();
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainWindow window = new MainWindow();
					window.changePanel(new LoginPanel());
					generalaClient.registrar(window);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}
}

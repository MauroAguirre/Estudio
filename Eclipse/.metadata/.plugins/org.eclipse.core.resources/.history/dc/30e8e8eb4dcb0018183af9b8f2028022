package uy.edu.cei.Obligatorio.Client;

import java.awt.EventQueue;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

import uy.edu.cei.Obligatorio.Client.ui.MainWindow;
import uy.edu.cei.Obligatorio.Client.ui.Panel.LoginPanel;
import uy.edu.cei.Obligatorio.Client.ui.Panel.MainPanel;
import uy.edu.cei.Obligatorio.Common.Observable;
import uy.edu.cei.Obligatorio.Common.Server.Server;

public class ClientMain {

	public static void main(String[] args) throws RemoteException, NotBoundException {

		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					//profe tirando fruta
					
					CommClientServer css = CommClientServer.Instancia();
					MainWindow main = new MainWindow();
					main.GetFrame().add(new LoginPanel());
					main.GetFrame().setVisible(true);		
					
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
		
	}

}
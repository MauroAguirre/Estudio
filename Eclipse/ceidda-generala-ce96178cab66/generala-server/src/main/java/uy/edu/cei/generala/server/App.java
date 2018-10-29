package uy.edu.cei.generala.server;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;

import uy.edu.cei.generala.common.server.Server;

/**
 * Servidor generala
 *
 */
public class App {
	public static void main(String[] args) throws RemoteException {
		System.out.println("Iniciando Servidor");
		Server server = new ServerImpl();
		LocateRegistry.createRegistry(1099);
		Registry locateRegistry = LocateRegistry.getRegistry();
		Server stub = (Server) UnicastRemoteObject.exportObject(server, 0 ); 
		locateRegistry.rebind("server", stub);
		System.out.println("Servidor Iniciado");
	}
}

package uy.edu.cei.Obligatorio.Client;

import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

import uy.edu.cei.Obligatorio.Common.Server.Server;
import uy.edu.cei.Obligatorio.Domain.UsuarioModel;

public class CommClientServer {
	private static CommClientServer instancia = null;
	private Server server;
	
	public static CommClientServer Instancia() {
		if(instancia == null)
			instancia = new CommClientServer();
		return instancia;
	}
	public CommClientServer() {
		try {
			Registry registry = LocateRegistry.getRegistry(1099);
			server= (Server) registry.lookup("server");
			server.TestConnection();
			
		} catch (RemoteException | NotBoundException e) {
			// tirar alguna excepcion para arriba
			e.printStackTrace();
		}
	}
	public Server GetServer() {
		return server;
	}
}

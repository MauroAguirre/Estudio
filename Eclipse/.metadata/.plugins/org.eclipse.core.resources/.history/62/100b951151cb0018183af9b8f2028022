package uy.edu.cei.Obligatorio.Server.Impl;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import uy.edu.cei.Obligatorio.Domain.UsuarioModel;
import uy.edu.cei.Obligatorio.Common.Observable;
import uy.edu.cei.Obligatorio.Common.Observer;
import uy.edu.cei.Obligatorio.Common.Server.Server;

public class ServerImpl implements Server, Observable {
	
	private UsuarioControllerImpl usuarioControllerImpl;
	private List<Observer> observers;
	private List<UsuarioModel> usuarios;
	
	public ServerImpl() throws RemoteException {
		usuarioControllerImpl = UsuarioControllerImpl.Instancia();
	}
	
	public UsuarioControllerImpl getUsuarioControllerImpl() throws RemoteException {
		return usuarioControllerImpl;
	}
	
	@Override
	public void subscribe(Observer observer) throws RemoteException {
		System.out.println("Observer agregado");
		this.observers.add(observer);
	}
	
	@Override
	public void sayHello(String name) throws RemoteException {
		System.out.println(String.format("Hola %s", name));
		// this.observers.forEach((o) -> o.update(String.format("Hola %s", name)));
		for(Observer o : this.observers) {
			o.update(String.format("Hola %s", name));
		}
	}

	@Override
	public void IrMenuRegistrar() throws RemoteException {
		for(Observer o : this.observers) {
			o.CambiarMenuRegistro();
		}
	}


	@Override
	public void TestConnection() throws RemoteException {
		System.out.println("Hemos conectado con el server yeahh boooyyyyy");
		
	}

}

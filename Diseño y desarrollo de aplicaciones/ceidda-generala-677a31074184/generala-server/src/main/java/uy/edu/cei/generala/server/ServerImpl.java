package uy.edu.cei.generala.server;

import java.rmi.RemoteException;
import java.util.LinkedList;
import java.util.List;

import uy.edu.cei.generala.common.client.Observer;
import uy.edu.cei.generala.common.server.Server;
import uy.edu.cei.generala.common.server.controllers.UserController;
import uy.edu.cei.generala.server.controllers.UserControllerImpl;

public class ServerImpl implements Server {

	private UserController userController;
	private List<Observer> observers;

	public ServerImpl() throws RemoteException {
		this.observers = new LinkedList<>();
		this.userController = new UserControllerImpl(observers);
	}

	@Override
	public void testConnection() throws RemoteException {
		System.out.println("Connection OK! :)");
	}

	@Override
	public UserController getUserController() throws RemoteException {
		return this.userController;
	}
	
	@Override
	public void register(Observer observer) throws RemoteException {
		this.observers.add(observer);
	}

}

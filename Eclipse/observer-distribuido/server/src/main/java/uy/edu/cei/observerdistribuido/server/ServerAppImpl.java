package uy.edu.cei.observerdistribuido.server;

import java.rmi.RemoteException;
import java.util.LinkedList;
import java.util.List;

import uy.edu.cei.observerdistribuido.common.Observable;
import uy.edu.cei.observerdistribuido.common.Observer;
import uy.edu.cei.observerdistribuido.common.ServerApp;

public class ServerAppImpl implements ServerApp,Observable {
	
	private List<Observer> observers;
	
	public ServerAppImpl() {
		this.observers = new LinkedList<Observer>();
	}
	@Override
	public void Subscribe(Observer o) throws RemoteException {
		this.observers.add(o);
	}
	
	@Override
	public void SayHello(String name) throws RemoteException {
		System.out.println(String.format("Hola %s", name));
	}
	
}
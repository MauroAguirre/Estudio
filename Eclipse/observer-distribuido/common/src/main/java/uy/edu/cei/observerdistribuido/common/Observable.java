package uy.edu.cei.observerdistribuido.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface Observable extends Remote {
	public void Subscribe(Observer o) throws RemoteException;
		
}

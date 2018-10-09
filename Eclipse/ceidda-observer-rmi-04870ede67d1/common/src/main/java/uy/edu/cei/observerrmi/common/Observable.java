package uy.edu.cei.observerrmi.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface Observable extends Remote {

	public void subscribe(Observer observer) throws RemoteException;

}

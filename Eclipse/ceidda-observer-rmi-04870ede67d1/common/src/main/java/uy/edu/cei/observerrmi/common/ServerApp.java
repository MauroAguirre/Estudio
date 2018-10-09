package uy.edu.cei.observerrmi.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface ServerApp extends Remote {
	public void sayHello(String name) throws RemoteException;
}

package uy.edu.cei.observerdistribuido.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface ServerApp extends Remote{
	public void SayHello(String name) throws RemoteException;
}

package uy.edu.cei.observerdistribuido.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface Observer extends Remote{
	public void Update(String name) throws RemoteException;
}

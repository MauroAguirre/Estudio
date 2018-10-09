package uy.edu.cei.observerrmi.common;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface Observer extends Remote {

	public void update(String message) throws RemoteException;

}

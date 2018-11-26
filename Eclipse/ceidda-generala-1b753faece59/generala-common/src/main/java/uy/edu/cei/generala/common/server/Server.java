package uy.edu.cei.generala.common.server;

import java.rmi.Remote;
import java.rmi.RemoteException;

import uy.edu.cei.generala.common.client.Observer;
import uy.edu.cei.generala.common.server.controllers.UserController;

public interface Server extends Remote {

	public void testConnection() throws RemoteException;

	public UserController getUserController() throws RemoteException;

	public void register(Observer observer) throws RemoteException;
}

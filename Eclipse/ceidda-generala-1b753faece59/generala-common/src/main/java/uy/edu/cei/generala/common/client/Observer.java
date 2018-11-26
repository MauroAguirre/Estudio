package uy.edu.cei.generala.common.client;

import java.rmi.Remote;
import java.rmi.RemoteException;

import uy.edu.cei.generala.common.notifications.GameNotification;

public interface Observer extends Remote {

	public void update(GameNotification login) throws RemoteException;

}

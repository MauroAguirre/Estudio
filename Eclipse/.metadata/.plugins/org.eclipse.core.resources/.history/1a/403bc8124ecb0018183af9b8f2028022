package uy.edu.cei.Obligatorio.Common.Server;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.List;

import uy.edu.cei.Obligatorio.Domain.UsuarioModel;
import uy.edu.cei.Obligatorio.Common.Controller.UsuarioController;

public interface Server extends Remote {
	public void sayHello(String name) throws RemoteException;
	public void IrMenuRegistrar() throws RemoteException;
	public void TestConnection() throws RemoteException;
	public UsuarioController getUsuarioControllerImpl() throws RemoteException;
}
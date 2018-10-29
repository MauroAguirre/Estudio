package uy.edu.cei.generala.common.server.controllers;

import java.rmi.Remote;
import java.rmi.RemoteException;

import uy.edu.cei.generala.domain.UserModel;

public interface UserController extends Remote {

	public UserModel login(String username, String password) throws RemoteException;
}

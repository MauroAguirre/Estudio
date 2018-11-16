package uy.edu.cei.generala.server.controllers;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.List;

import uy.edu.cei.generala.common.client.Observer;
import uy.edu.cei.generala.common.notifications.GameNotification;
import uy.edu.cei.generala.common.notifications.GameNotificationType;
import uy.edu.cei.generala.common.server.controllers.UserController;
import uy.edu.cei.generala.domain.UserModel;
import uy.edu.cei.generala.server.services.UserService;

public class UserControllerImpl extends UnicastRemoteObject implements UserController {

	/**
	 * Default UID
	 */
	private static final long serialVersionUID = 1L;
	private List<Observer> observers;

	public UserControllerImpl(List<Observer> observers) throws RemoteException {
		this.observers = observers;
	}

	@Override
	public UserModel login(String username, String password) throws RemoteException {
		System.out.println(String.format("username: %s, password: %s", username, password));
		
		UserService us = UserService.userServiceFactory();
		UserModel userModel = us.findUserByUsername(username);
		if(userModel != null && 
				userModel.getPassword().equals(password)) {
			this.observers.forEach(o -> {
				try {
					
					GameNotification gameNotification = 
							new GameNotification();
					
					gameNotification.setTargetUser(userModel);
					gameNotification.setType(
							GameNotificationType.LOGIN);
					
					o.update(gameNotification);
					
				} catch (RemoteException e) {
					e.printStackTrace();
				}
			});
			return userModel;
		}
		
		return null;
	}
}

package uy.edu.cei.generala.server.services;

import uy.edu.cei.generala.domain.UserModel;
import uy.edu.cei.generala.server.services.impl.UserServiceInMemoryImpl;

public interface UserService {

	public static final String TYPE = "memory";

	public static UserService userServiceFactory() {
		UserService userService = null;
		if ("memory".equals(TYPE)) {
			userService = UserServiceInMemoryImpl.getInstance();
		} else if("database".equals(TYPE)) {
			// retorno implementacion en base de datos
		} else {
			// no lo voy a hacer, pero que bien estaria tirar una EX aca! :)
		}
		return userService;
	}

	/**
	 * Una descripcion muy linda de lo que hace el metodo
	 * 
	 * @param username
	 * @return Un usuario si hay uno con ese username, si no, retorna null
	 */
	public UserModel findUserByUsername(String username);

}

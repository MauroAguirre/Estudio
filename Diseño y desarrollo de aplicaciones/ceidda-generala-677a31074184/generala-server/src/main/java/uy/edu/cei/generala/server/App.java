package uy.edu.cei.generala.server;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.TypedQuery;

import uy.edu.cei.generala.common.server.Server;
import uy.edu.cei.generala.domain.Address;
import uy.edu.cei.generala.domain.UserModel;

/**
 * Servidor generala
 *
 */
public class App {
	public static void main(String[] args) throws RemoteException {

		EntityManagerFactory emf;
		emf = Persistence.createEntityManagerFactory("jpaDS");
		EntityManager em = emf.createEntityManager();

		UserModel userModel = new UserModel();

		em.getTransaction().begin();
		userModel.setUsername("pepe");
		userModel.setPassword("password");
		Address address = new Address();
		address.setAddressLine1("line 1");
		userModel.setMainAddress(address);
		em.persist(address);
		em.persist(userModel);
		em.getTransaction().commit();

		userModel.setUsername("juan");
		
		
		em.getTransaction().begin();
		
		userModel.setUsername("jose2");
		
		UserModel reattached = em.merge(userModel);
		//em.persist(reattached);
		em.getTransaction().commit();

		
		//UserModel fromDatabase = em.find(UserModel.class, 1L);
		
		//System.out.println(fromDatabase.getUsername());
		
		TypedQuery<UserModel> query = em.createNamedQuery("UserModel.findByUsername", UserModel.class);
		query.setParameter("username", "juan");
		UserModel fromNamedQuery = query.getSingleResult();
		
		System.out.println(fromNamedQuery.getUsername());
		
		TypedQuery<UserModel> allQuery = em.createQuery("SELECT u FROM UserModel u", UserModel.class);
		List<UserModel> users = allQuery.getResultList();
		
		users.forEach((u) -> System.out.println(u.getUsername()));
		
		System.exit(0);
		
		System.out.println("Iniciando Servidor");
		Server server = new ServerImpl();
		LocateRegistry.createRegistry(1099);
		Registry locateRegistry = LocateRegistry.getRegistry();
		Server stub = (Server) UnicastRemoteObject.exportObject(server, 0);
		locateRegistry.rebind("server", stub);
		System.out.println("Servidor Iniciado");
	}
}

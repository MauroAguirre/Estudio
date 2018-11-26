package uy.edu.cei.generala.server;

import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;
import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.TypedQuery;

import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;

import uy.edu.cei.generala.common.server.Server;
import uy.edu.cei.generala.domain.Address;
import uy.edu.cei.generala.domain.UserModel;

/**
 * Servidor generala
 *
 */
public class App {
	protected static final Logger LOGGER = LogManager.getLogger();

	public static void main(String[] args) {

		LOGGER.info("Iniciando Generala {}", () -> System.currentTimeMillis());

		EntityManagerFactory emf;
		emf = Persistence.createEntityManagerFactory("jpaDS");
		EntityManager em = emf.createEntityManager();

		em.getTransaction().begin();

		UserModel userModel = new UserModel();
		userModel.setUsername("pepe");
		userModel.setPassword("password");

		Address address = new Address();
		address.setAddressLine1("line 1");

		List<Address> addresses = new ArrayList<>();
		addresses.add(address);
		userModel.setAddresses(addresses);

		em.persist(userModel);
		em.getTransaction().commit();

		em.getTransaction().begin();

		UserModel reattached = em.merge(userModel);
		em.persist(reattached);
		em.getTransaction().commit();

		UserModel fromDatabase = em.find(UserModel.class, 1L);

		System.out.println(fromDatabase.getUsername());

		TypedQuery<UserModel> query = em.createNamedQuery("UserModel.findByUsername", UserModel.class);
		query.setParameter("username", "pepe");
		UserModel fromNamedQuery = query.getSingleResult();

		LOGGER.info("From named query: {}", () -> fromNamedQuery.getUsername());

		TypedQuery<UserModel> allQuery = em.createQuery("SELECT u FROM UserModel u",
				UserModel.class);
		List<UserModel> users = allQuery.getResultList();

		users.forEach((u) -> LOGGER.info("Result List {}", () -> u.getUsername()));

		System.exit(0);

		System.out.println("Iniciando Servidor");
		Server server;
		try {
			server = new ServerImpl();
			LocateRegistry.createRegistry(1099);
			Registry locateRegistry = LocateRegistry.getRegistry();
			Server stub = (Server) UnicastRemoteObject.exportObject(server, 0);
			locateRegistry.rebind("server", stub);
			System.out.println("Servidor Iniciado");
		} catch (RemoteException e) {
			LOGGER.error(e);
		}
	}
}

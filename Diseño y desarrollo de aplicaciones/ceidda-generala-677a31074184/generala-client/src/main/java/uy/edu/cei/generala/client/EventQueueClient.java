package uy.edu.cei.generala.client;

import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.rmi.server.UnicastRemoteObject;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.ListIterator;
import java.util.Queue;

import com.sun.javafx.binding.StringFormatter;

import uy.edu.cei.generala.client.ui.panel.TablePanel;
import uy.edu.cei.generala.common.client.Observer;
import uy.edu.cei.generala.common.notifications.GameNotification;
import uy.edu.cei.generala.common.server.Server;

public class EventQueueClient
		extends UnicastRemoteObject
		implements Observer {

	private static EventQueueClient instance = null;

	private Server server;
	private List<Observer> observers;
	private Queue<GameNotification> queue;

	static {
		try {
			instance = new EventQueueClient();
		} catch (RemoteException e) {
			e.printStackTrace();
		}
	}

	public static EventQueueClient getInstance() {
		return EventQueueClient.instance;
	}

	private EventQueueClient() throws RemoteException {
		Registry registry;
		try {
			this.observers = new LinkedList<>();
			this.queue = new LinkedList<>();
			registry = LocateRegistry.getRegistry(1099);
			server = (Server) registry.lookup("server");
			server.testConnection();
			server.register(this);
			this.initializeThread();
		} catch (RemoteException | NotBoundException e) {
			// TODO tirar alguna exception para arriba, muchacho
			e.printStackTrace();
		}
	}

	@Override
	public void update(GameNotification gameNotification) throws RemoteException {
		System.out.println(
				StringFormatter.format("Nuevo mensaje es del tipo %s",
						gameNotification.getType()));
		this.queue.add(gameNotification);
	}

	public void registrar(Observer observer) {
		this.observers.add(observer);
	}

	public Server getServer() {
		return server;
	}

	private void initializeThread() {
		EventQueueClient that = this;
		new Thread(new Runnable() {
			@Override
			public void run() {
				while (true) {
					try {
						do {
							GameNotification gn = queue.poll();
							if (gn != null) {
								
								Iterator<Observer> it = observers.iterator();
								while(it.hasNext()) {
									Observer o = it.next();
									o.update(gn);
								}
							}
						} while (queue.peek() != null);
						Thread.sleep(1000);
					} catch (InterruptedException e) {
						e.printStackTrace();
					} catch (RemoteException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
			}
		}).start();
	}

	public void remove(Observer observer) {
		this.observers.remove(observer);
	}

}

package uy.edu.cei.generala.client.ui.panel;

import java.rmi.RemoteException;

import javax.swing.JPanel;

import uy.edu.cei.generala.client.EventQueueClient;
import uy.edu.cei.generala.common.client.Observer;
import uy.edu.cei.generala.common.notifications.GameNotification;
import uy.edu.cei.generala.common.notifications.GameNotificationType;
import java.awt.Color;

public class TablePanel extends JPanel implements Observer {
	public TablePanel() {
		setBackground(Color.RED);
		EventQueueClient.getInstance()
			.registrar(this);
	}

	@Override
	public void update(GameNotification notification) throws RemoteException {
		if (notification.getType() == GameNotificationType.USER_IN) {
			System.out.println(notification.getTargetUser());
		}
	}
	
	@Override
	public void removeAll() {
		EventQueueClient.getInstance()
			.remove(this);
		super.removeAll();
	}
}

package uy.edu.cei.generala.common.notifications;

import java.io.Serializable;

public class GameNotification implements Serializable {

	/**
	 * Default UID
	 */
	private static final long serialVersionUID = 1L;

	private String currentUser;
	private GameNotificationType type;

	public String getCurrentUser() {
		return currentUser;
	}

	public void setCurrentUser(String currentUser) {
		this.currentUser = currentUser;
	}

	public GameNotificationType getType() {
		return type;
	}

	public void setType(GameNotificationType type) {
		this.type = type;
	}

}

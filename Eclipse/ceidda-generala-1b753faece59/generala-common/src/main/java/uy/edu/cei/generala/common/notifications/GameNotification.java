package uy.edu.cei.generala.common.notifications;

import java.io.Serializable;

import uy.edu.cei.generala.domain.UserModel;

public class GameNotification implements Serializable {

	/**
	 * Default UID
	 */
	private static final long serialVersionUID = 1L;

	private UserModel targetUser;
	private GameNotificationType type;

	public UserModel getTargetUser() {
		return targetUser;
	}

	public void setTargetUser(UserModel targetUser) {
		this.targetUser = targetUser;
	}

	public GameNotificationType getType() {
		return type;
	}

	public void setType(GameNotificationType type) {
		this.type = type;
	}

}

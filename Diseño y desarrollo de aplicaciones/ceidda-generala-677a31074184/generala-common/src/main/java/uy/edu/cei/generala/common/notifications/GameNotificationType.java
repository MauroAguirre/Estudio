package uy.edu.cei.generala.common.notifications;

public enum GameNotificationType {

	LOGIN("login"),
	LOGOUT("logout"), 
	THROW_DICE("throw_dice"), 
	USER_IN("user_in");

	private String value;

	GameNotificationType(String value) {
		this.value = value;
	}

	public String getValue() {
		return value;
	}

	public void setValue(String value) {
		this.value = value;
	}

}

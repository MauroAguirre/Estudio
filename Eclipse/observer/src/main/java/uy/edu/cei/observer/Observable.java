package uy.edu.cei.observer;

public abstract interface Observable {

	void sendMessage(String message);

	void addObservable(Observer observer);
	
	
}

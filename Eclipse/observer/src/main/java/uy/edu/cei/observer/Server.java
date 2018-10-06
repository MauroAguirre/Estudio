package uy.edu.cei.observer;
import java.util.LinkedList;
import java.util.List;

public class Server implements Observable {

	private List<Observer> observers;
	
	public Server() {
		this.observers = new LinkedList<>();
	}
	
	@Override
	public void addObservable(Observer observer) {
		this.observers.add(observer);
	}
	
	@Override
	public void sendMessage(String message) {
		
		this.observers.forEach(observer -> observer.notify(message));
		/*
		foreach(Observer o in this.observers){
			
		}*/
	}
}

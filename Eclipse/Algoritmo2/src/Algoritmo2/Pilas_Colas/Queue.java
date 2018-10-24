package Algoritmo2.Pilas_Colas;

public class Queue {
	private String[] queue;
	
	public String[] getQueue() {
		return this.queue;
	}
	
	public Queue() {
		queue = new String[10];
	}
	
	public void Mostrar() {
		int i=0;
		while(i!=10) {
			if(queue[i]!=null) {
				System.out.println(queue[i]);
				i++;
			}			
			else 
				break;
		}
		System.out.println();
	}
	
	public boolean enQueue(String s) {
		int i=0;
		while(i!=10) {
			if(queue[i]!=null)
				i++;
			else 
				break;
		}
		if(i!=10) {
			queue[i]=s;
			return true;
		}
		else {
			return false;
		}
	}
	public boolean isEmpty() {
		if(queue[0]==null)
			return true;
		return false;
	}
	public String front() {
		return queue[0];
	}
	public String back() {
		int i=0;
		if(queue[0]==null)
			return null;
		while(i!=9) {
			if(queue[i+1]!=null)
				i++;
			else
				break;
		}
		if(i!=10)
			return queue[i];
		else
			return null;
	}
	public void deQueue() {
		for(int i=0;i<queue.length-1;i++) {
			queue[i]=queue[i+1];
		}
		queue[9]=null;
	}
}

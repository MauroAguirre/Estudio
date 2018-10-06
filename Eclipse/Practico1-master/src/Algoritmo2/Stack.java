package Algoritmo2;

public class Stack {
	private String[] stack;
	
	public String[] getStack() {
		return stack;
	}
	public void setStack(String[] stack) {
		this.stack = stack;
	}
	
	public Stack() {
		stack = new String[10];
	}
	public void mostrar() {
		for(int i=0;i<10;i++) {
			if(stack[i]==null) {
				System.out.println();
				break;
			}	
			System.out.println(stack[i]);
		}
	}
	public void push(String s) {
		for(int i=stack.length-1;i>0;i--) {
			stack[i]=stack[i-1];
		}
		stack[0]=s;
	}
	public boolean isEmpty() {
		return stack[0]==null;
	}
	public String top() {
		return stack[0];
	}
	public void pop() {
		for(int i=0;i<stack.length-1;i++) {
			stack[i]=stack[i+1];
		}
		stack[9]=null;
	}
	public void clean() {
		for(int i=0;i<stack.length;i++) {
			stack[i]=null;
		}
	}
	public Stack borrarUno(String e,Stack s) {
		Stack nuevo = new Stack();
		String[] col = s.getStack();
		int i=0;
		while(i<col.length&&col[i]!=null) {
			if(col[i].equals(e)) {
				for(int l=i;l<col.length-1;l++) {
					col[l]=col[l+1];
				}
				col[9]=null;
				break;
			}
			i++;
		}
		nuevo.setStack(col);
		return nuevo;
	}
	public Stack borrar(String e,Stack s) {
		Stack nuevo = new Stack();
		String[] col = s.getStack();
		int i=0;
		while(i<col.length&&col[i]!=null) {
			if(col[i].equals(e)) {
				for(int l=i;l<col.length-1;l++) {
					col[l]=col[l+1];
				}
				col[9]=null;
			}
			else {
				i++;
			}
		}
		nuevo.setStack(col);
		return nuevo;
	}
	public static Stack Reemplazar(String viejo,String nuevo,Stack s) {
		Stack nuevoStack = new Stack();
		String[] col = s.getStack();
		int i=0;
		while(i<col.length&&col[i]!=null) {
			if(col[i].equals(viejo))
				col[i]=nuevo;
			i++;
		}
		nuevoStack.setStack(col);
		return nuevoStack;
	}
	public static Stack mezclados(Stack s1,Stack s2) {
		Stack stackNuevo = new Stack();
		String[] col1 = s1.getStack();
		String[] col2 = s2.getStack();
		String[] nuevo = new String[10];
		int l=0;
		int i=0;
		while(l!=10 && col1[i]!=null) {
			nuevo[l] = col1[i];
			l++;
			i++;
		}
		i=0;
		while(l!=10 && col2[i]!=null) {
			nuevo[l] = col2[i];
			l++;
			i++;
		}
		stackNuevo.setStack(nuevo);
		return stackNuevo;
	}
}

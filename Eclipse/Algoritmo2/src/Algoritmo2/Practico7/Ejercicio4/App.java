package Algoritmo2.Practico7.Ejercicio4;

public class App {

	public static void main(String[] args) {
		if(verificarParentesis("asdasd"))
			System.out.println("Bien");
		else
			System.out.println("mal");
		if(verificarParentesis("as(da)sd"))
			System.out.println("Bien");
		else
			System.out.println("mal");
		if(verificarParentesis("as((d}asd"))
			System.out.println("Bien");
		else
			System.out.println("mal");

	}
	public static boolean verificarParentesis(String s) {
		int curbo = 0;
		int recto = 0;
		int corchete = 0;
		for(int i=0;i<s.length();i++) {
			switch(s.charAt(i)) {
				case ')':
					curbo++;
					break;
				case ']':
					recto++;
					break;
				case '}':
					corchete++;
					break;
				case '(':
					curbo--;
					break;
				case '[':
					recto--;
					break;
				case '{':
					corchete--;
					break;
			}
		}
		if(curbo==0&&recto==0&&corchete==0)
			return true;
		return false;
	}
}

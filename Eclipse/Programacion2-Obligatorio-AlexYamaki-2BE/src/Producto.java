
public class Producto {
	
	private int id;
	private String descripcion;
	private String marca;
	private int cantidad;
	
	
	
	public Producto( String des, String mar, int can) {
		
		this.descripcion=des;
		this.marca=mar;
		this.cantidad=can;
		
		
	}
	
	
	
	
	
	public Producto() {
		
	}
	
	
	
	public int getId() {
		return this.id;
		
	}
	
	public String getDescripcion() {
		return this.descripcion;
		
	}
	
	public String getMarca() {
		return this.marca;
		
	}
	
	public int getCantidad() {
		return this.cantidad;
		
	}
	
	
	
	
	public void setId(int id) {
		this.id=id;
	}
	
	public void setDescripcion(String des) {
		this.descripcion=des;
	}
	
	public void setMarca(String mar) {
		this.marca=mar;
	}
	
	public void setCantidad(int can) {
		this.cantidad=can;
	}

	
	public String toString() {
		
		return "ID: "+this.id+"\nDescripcion: "+this.descripcion+"\nMarca: "+this.marca+"\nCantidad: "+this.cantidad;
	}
	
	public void Modificar(String des, String mar, int can) {
		
		this.descripcion=des;
		this.marca=mar;
		this.cantidad=can;
		
		
	}
	
}
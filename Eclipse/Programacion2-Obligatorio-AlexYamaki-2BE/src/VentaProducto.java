
public class VentaProducto {
	private int idProducto;
	private int cantidad;
	
	public int getIdProducto() {
		return this.idProducto;
	}
	
	public int getCantidad() {
		return this.cantidad;
	}
	
	public VentaProducto(int idProducto, int cantidad) {
		this.idProducto = idProducto;
		this.cantidad = cantidad;
	}
}

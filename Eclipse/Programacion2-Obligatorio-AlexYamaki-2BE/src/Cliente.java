
public class Cliente {

	private int cedula;
	private String nombre;
	private String apellido;
	private String calle;
	private int nroPuerta;
	private String localidad;
	private int telefonos;
	
	
	public Cliente(int ced, String nom, String ape, String calle, int nro, String local, int tel) {
		
		this.cedula=ced;
		this.nombre=nom;
		this.apellido=ape;
		this.calle=calle;
		this.nroPuerta=nro;
		this.localidad=local;
		this.telefonos=tel;
		
	}
	
	
	
	
	
	public Cliente() {
		
	}
	
	public int getCedula() {
		return this.cedula;
		
	}
	
	public String getNombre() {
		return this.nombre;
		
	}
	
	public String getApellido() {
		return this.apellido;
		
	}
	
	public String getCalle() {
		return this.calle;
		
	}
	
	public int getNroPuerta() {
		return this.nroPuerta;
		
	}
	
	public String getLocalidad() {
		return this.localidad;
		
	}
	
	public int getTelefonos() {
		return this.telefonos;
	}
	
	
	
	
	public void setCedula(int ced) {
		this.cedula=ced;
	}
	
	public void setNombre(String nom) {
		this.nombre=nom;
	}
	
	public void setApellido(String ape) {
		this.apellido=ape;
	}
	
	public void setCalle(String calle) {
		this.calle=calle;
	}
	
	public void setNroPuerta(int nro) {
		this.nroPuerta=nro;
	}
	
	public void setLocalidad(String local) {
		this.localidad=local;
	}
	
	public void setTelefonos(int tel) {
		this.telefonos=tel;
	}
	
	public String toString() {

		return "Nombre: "+this.nombre+"\nApellido: "+this.cedula+"\nCedula: "+this.cedula+"\nLocalidad: "+this.localidad+"\nCalle: "+this.calle+"\nNumero de puerta: "+this.nroPuerta+"\nTelefono: "+this.telefonos;
	}


	
	
}
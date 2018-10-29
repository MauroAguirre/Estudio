
public class Proveedor {
	
	private int razonSocial;
	private int Rut;
	private String calle;
	private int nroPuerta;
	private String localidad;
	private int telefonos;
	private String correo;
	private String nomContacto;
	
	
	public Proveedor(String raz, int rut, String calle, int nro, String local, int tel, String correo, String nomC) {
		this.razonSocial=razonSocial;
		this.Rut=rut;
		this.calle=calle;
		this.nroPuerta=nro;
		this.localidad=local;
		this.telefonos=tel;
		this.correo=correo;
		this.nomContacto=nomC;
	}
	
	public Proveedor() {
		
	}
	
	
	public int getRazonSocial() {
		return this.razonSocial;
	}
	
	public int getRut() {
		return this.Rut;
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
	
	public String getCorreo() {
		return this.correo;
	}
	
	public String getNombreContacto() {
		return this.nomContacto;
	}
	
	
	
	public void setRazonSocial(int raz) {
		this.razonSocial=raz;
	}
	
	public void setRut(int rut) {
		this.Rut=rut;
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
	
	public void setCorreo(String correo) {
		this.correo=correo;
	}
	
	public void setNombreContacto(String nomC) {
		this.nomContacto=nomC;
	}
	
	public String toString() {
		return "Razon social: "+this.razonSocial+" - Rut: +"+this.Rut+ " - Calle: "+this.calle+ " - numPuerta: +"+this.nroPuerta+
				" - Localidad: "+this.localidad+" - Mail: "+this.correo+
				" - Telefono: "+this.telefonos+" - NomContacto:"+this.nomContacto;
	}
	
}

import java.sql.*;
import java.util.ArrayList;
import java.util.Scanner;
public class Menu {
	static Scanner entrada=new Scanner(System.in);
	public static void main(String[] args) {
		
		String op = "0";
		boolean chau=false;
			
		//creamos el menu
		do {
			
			System.out.println("Ingrese la opcion deseada: \n 1- Cargar elementos de la Base de Datos \n 2- Menu Cliente \n 3- Menu Producto \n 4- Menu Proveedor \n 5- Realizar Venta \n 6- Listados \n 0-Salir");
			op=entrada.next();
			switch (op) {
				case "0":
					chau=true;
					break;
					
				case "1":
					System.out.println("proximamente");
					break;
				
				case "2":
					System.out.println("Ha seleccionado  Menu Cliente \n 1- Alta de Cliente \n 2- Modificar Cliente");
					op=entrada.next();
					switch (op) {
						case "1":
							AltaCliente();
							break;
						
						case "2":
							ModificarClientes();
							break;
					}
					break;
					
				
				case "3":
					System.out.println("Ha seleccionado  Menu Producto \n 1- Alta de Producto \n 2- Modificar Producto");
					op=entrada.next();
					switch (op) {
						case "1":
							AltaProducto();
							break;
						
						case "2":
							//ModificarProducto();
							break;
					}
					break;
					
				
				case "4":
					System.out.println("Ha seleccionado  Menu Proveedor \n 1- Alta de Proveedor \n 2- Modificar Proveedor");
					op=entrada.next();
					switch (op) {
						case "1":
							AltaProveedor();
							break;
						case "2":
							//ModificarProveedor();
							break;
					}
					break;
				case "5":
					System.out.println("Ha seleccionado Realizar venta");
					break;
				
				case "6":
					System.out.println("Ha seleccionado los listados \n 1-Listado de Clientes \n 2-Listado de Productos \n 3-Listado de Proveedores \n 4-Volver al menu");
					op=entrada.next();
					switch (op) {
						case "1":
							ListadoCliente();
							break;
						case "2":	
							ListadoProducto();
							break;
						case "3":	
							ListadoProveedor();
							break;
						case "4":	
							System.out.println("Volviendo al menu");
							break;
						}
					break;
				default: 
					System.out.println("Error");
			}
			
			System.out.println("\nIngrese algo para continuar");
			entrada.next();
		}while( !chau);
			System.out.println("saliendo...");

			
	}
	
	
	//creamos el alta de cliente por base de datos
	public static void AltaCliente() {
		Cliente nc =new Cliente();
		String respuesta;
		boolean ok=false;
		do {	
			System.out.println("Ingrese la Cedula");
			respuesta=entrada.next();
			if(EsEntero(respuesta)) {
				if(respuesta.length()==8) {
					ok=true;
					nc.setCedula(Integer.parseInt(respuesta));
				}
			}
		}while(!ok);
		
		System.out.println("Ingrese un nombre");
		nc.setNombre(entrada.next());
		
		System.out.println("Ingrese un apellido");
		nc.setApellido(entrada.next());
		
		System.out.println("Ingrese la calle");
		nc.setCalle(entrada.next());
		ok=false;
		do {
			
			System.out.println("Ingrese numero de puerta");
			respuesta=entrada.next();
			if(EsEntero(respuesta)) {
				ok=true;
				nc.setNroPuerta(Integer.parseInt(respuesta));
			}
			
			
		}while(!ok);
		
		System.out.println("Ingrese su localidad");
		nc.setLocalidad(entrada.next());
		
		ok=false;
		do {
			
			System.out.println("Ingrese un telefono");
			respuesta=entrada.next();
			if(EsEntero(respuesta)) {
				ok=true;
				nc.setTelefonos(Integer.parseInt(respuesta));
			}
			
			
		}while(!ok);
		
		try{
			
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			Statement comando = conn.createStatement();
	           comando.executeUpdate("insert into clientes(ci, nombre, apellido, calle, numPuerta, localidad) values "
	           		+ "(" + nc.getCedula() + ",'" + nc.getNombre() + "','" + nc.getApellido() + "','" + nc.getCalle() + "'," + nc.getNroPuerta() + ",'" + nc.getLocalidad() + "')");
			
	           System.out.println("Se ingresaron los datos a la base de datos");
			
			
			conn.close();
			
		}catch (Exception e) {
			System.out.println("Error");
		}
	}
	
	//pasamos de string a integer
	public static boolean EsEntero(String numero){
	    try{
	        Integer.parseInt(numero);
	        return true;
	    }catch(NumberFormatException e){
	        return false;
	    }
	}
	
	//creamos el listado de clientes
	public static void ListadoCliente() {
		try{
			
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			Statement comando = conn.createStatement();
            ResultSet lista = comando.executeQuery("select * from clientes");
			
            while (lista.next()) 
    		{
    		    System.out.println("CI: "+lista.getString("ci")+" - Nombre: "+lista.getString("nombre")+" - Apellido: "+lista.getString("apellido")+
    		    		" - calle: "+lista.getString("calle")+ " - Numero de Puerta: "+lista.getString("numPuerta")+" - localidad: "+lista.getString("localidad")); 
    		}
            
			conn.close();
			
		}catch (Exception e) {
			System.out.println("Error");
		}

	}
	
	//cantidad clientes
	public static int CantidadClientes() {
		int cantidad = 0;;
		try{
			
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			Statement comando = conn.createStatement();
			ResultSet lista = comando.executeQuery("select * from clientes");
			if (lista.last())
				cantidad = lista.getRow();
            
			conn.close();
			
		}catch (Exception e) {
			System.out.println("Error");
		}
		return cantidad;
	}
	
	//creamos la opcion de modificar clientes
	public static void ModificarClientes() {
		
		
		if(CantidadClientes()==0)
			System.out.println("No hay clientes");
		else 
		{
			ListadoCliente();
			String res;
			boolean ok=false;
			do {
				System.out.println("Elige al cliente que quieras modificar");
				res=entrada.next();
				if(EsEntero(res)) {
					if(Integer.parseInt(res)>0){
						ok=true;
						
						//
						
						Cliente nc = new Cliente();
						nc.setCedula(Integer.parseInt(res));
						String respuesta;
						ok=false;
						
						System.out.println("Ingrese un nombre");
						nc.setNombre(entrada.next());
						
						System.out.println("Ingrese un apellido");
						nc.setApellido(entrada.next());
						
						System.out.println("Ingrese la calle");
						nc.setCalle(entrada.next());
						ok=false;
						do {
							
							System.out.println("Ingrese numero de puerta");
							respuesta=entrada.next();
							if(EsEntero(respuesta)) {
								ok=true;
								nc.setNroPuerta(Integer.parseInt(respuesta));
							}
							
							
						}while(!ok);
						
						System.out.println("Ingrese su localidad");
						nc.setLocalidad(entrada.next());
						
						ok=false;
						do {
							
							System.out.println("Ingrese un telefono");
							respuesta=entrada.next();
							if(EsEntero(respuesta)) {
								ok=true;
								nc.setTelefonos(Integer.parseInt(respuesta));
							}
							
							
						}while(!ok);
						
						try{
							
							System.out.println("Estoy intentando conectar a la base de datos");
							Class.forName("com.mysql.jdbc.Driver");
							
							Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
							System.out.println("Conexion exitosa");
							
							//creamos la consulta
							Statement comando = conn.createStatement();
					           comando.executeUpdate("update clientes set nombre = "+"'"+nc.getNombre() +"'"+", apellido = "+"'"+nc.getApellido()+"'"+
					        		   ", calle = "+"'"+nc.getCalle()+ "'"+", numPuerta = "+nc.getNroPuerta()+ ", localidad = "+"'"+nc.getLocalidad()+"'"+" where ci = "+nc.getCedula()+";");
							
					           System.out.println("Se ingresaron los datos a la base de datos");
							
							
							conn.close();
							
						}catch (Exception e) {
							System.out.println("Error");
						}
						
						//
						
					}
				}
			}while(!ok);
		}
		
	}

	//creamos el alta producto
	public static void AltaProducto() {
		Producto np =new Producto();
		String respuesta;
		boolean ok=false;
		
		do {
			
			System.out.println("Ingrese el id");
			respuesta=entrada.next();
			if(EsEntero(respuesta)) {
				if(Integer.parseInt(respuesta)>0) {
					ok=true;
					np.setId(Integer.parseInt(respuesta));
				}
				
			}
			
			
		}while(!ok);
		ok=!true;
		
		System.out.println("Ingrese una descripcion");
		np.setDescripcion(entrada.next());
		
		System.out.println("Ingrese una marca");
		np.setMarca(entrada.next());
		
		do {
			
			System.out.println("Ingrese cantidad del stock");
			respuesta=entrada.next();
			if(EsEntero(respuesta)) {
				if(Integer.parseInt(respuesta)>0) {
					ok=true;
					np.setCantidad(Integer.parseInt(respuesta));
				}
				
			}
			
			
		}while(!ok);
		
		
		try{
			
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			Statement comando = conn.createStatement();
	        comando.executeUpdate("insert into productos(id, descripcion, marca, cantidad) values "
	           		+ "(" + np.getId() + ",'" + np.getDescripcion() + "','" + np.getMarca() + "','" + np.getCantidad() + "')");
			
	        System.out.println("Se ingresaron los datos a la base de datos");
			
			
			conn.close();
			
		}catch (Exception e) {
			System.out.println("Error");
		}
		
		
	}
	
	
	//creamos el listado de producto
	public static void ListadoProducto() {
		try{
			
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			Statement comando = conn.createStatement();
            ResultSet lista = comando.executeQuery("select * from productos");
			
            while (lista.next()) 
    		{ 
    		    System.out.println("ID: "+lista.getString("id")+" - Descripcion: "+lista.getString("descripcion")+" - Marca: "+lista.getString("marca")+
    		    		" - Cantidad: "+lista.getString("cantidad")); 
    		}
            
			conn.close();
			
		}catch (Exception e) {
			System.out.println("Error");
		}
	}
	
	/*
	//creamos la opcion de modificar productos
	public static void ModificarProducto() {
		
		ListadoProducto(ListaProductos);
		String res;
		boolean ok=false;
		do {
			System.out.println("Elige al cliente que quieras modificar");
			res=entrada.next();
			if(EsEntero(res)) {
				if(Integer.parseInt(res)>0 && Integer.parseInt(res) < ListaProductos.size()+1){
					ok=true;
					ListaProductos.set(Integer.parseInt(res)-1, AltaProducto());
				}
			}
		}while(!ok);
		
	}
	*/
	//creamos el Alta Proveedor
	public static void AltaProveedor() {
		Proveedor np = new Proveedor();
		
		System.out.println("Ingrese una razon social");
		np.setRazonSocial(entrada.next());
		
		System.out.println("Ingrese un rut");
		np.setRut(entrada.nextInt());
		
		System.out.println("Ingrese una calle");
		np.setCalle(entrada.next());
		
		System.out.println("Ingrese un numero de puerta");
		np.setNroPuerta(entrada.nextInt());
		
		System.out.println("Ingrese una localidad");
		np.setLocalidad(entrada.next());
		
		System.out.println("Ingrese un telefono");
		np.setTelefonos(entrada.nextInt());
		
		System.out.println("Ingrese un correo");
		np.setCorreo(entrada.next());
		
		System.out.println("Ingrese un nombre de contacto");
		np.setNombreContacto(entrada.next());
		
		try{
			
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			Statement comando = conn.createStatement();
	           comando.executeUpdate("insert into proveedores(razonSocial, rut, calle, numPuerta,localidad,mail,nomContacto) values "
	           		+ "(" + np.getRazonSocial() + ",'" + np.getRut() + "','" + np.getCalle() + "','" + np.getNroPuerta() + 
	           		"','" + np.getLocalidad() +"','" + np.getCorreo() +"','" + np.getNombreContacto() +"')");
			
	           System.out.println("Se ingresaron los datos a la base de datos");
			
			
			conn.close();
			
		}catch (Exception e) {
			System.out.println("Error");
		}
		
	}
	
	
	//creamos el listado del proveedor
	public static void ListadoProveedor() {
		try{
			
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			Statement comando = conn.createStatement();
            ResultSet lista = comando.executeQuery("select * from proveedores");
			
            while (lista.next()) 
    		{ 
    		    System.out.println("Razon Social: "+lista.getString("razonSocial")+" - RUT: "+lista.getString("rut")+" - Calle: "+lista.getString("calle")+
    		    		" - Numero de puerta: "+lista.getString("numPuerta")+" - Localidad: "+lista.getString("localidad")+" - mail: "+lista.getString("Mail")
    		    		+" - nombre de contacto: "+lista.getString("nomContacto")); 
    		}
            
			conn.close();
			
		}catch (Exception e) {
			System.out.println("Error");
		}
	}
	
	/*
	//creamos la opcion de modificar el proveedor
	public static void ModificarProveedor() {
		
		ListadoProveedor(ListaProveedor);
		String res;
		boolean ok=false;
		do {
			System.out.println("Elige al proveedor que quieras modificar");
			res=entrada.next();
			if(EsEntero(res)) {
				if(Integer.parseInt(res)>0 && Integer.parseInt(res) < ListaProveedor.size()+1){
					ok=true;
					ListaProveedor.set(Integer.parseInt(res)-1, AltaProveedor());
				}
			}
		}while(!ok);
		
	}

*/

}	


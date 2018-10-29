import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.awt.Window;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JTextPane;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.JFormattedTextField;
import javax.swing.JSeparator;
import javax.swing.JList;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class AltaCliente extends JFrame {

	private JPanel AltaClientePane;
	private JTextField txtCed;
	private JTextField txtNombre;
	private JTextField txtApellido;
	private JTextField txtTelefono;
	private JTextField txtLocalidad;
	private JTextField txtCalle;
	private JTextField txtNroPuerta;
	private JTextField txtCed2;
	private JTextField txtNombre2;
	private JTextField txtApellido2;
	private JTextField txtTel2;
	private JTextField txtLocalidad2;
	private JTextField txtCalle2;
	private JTextField txtNroPuerta2;
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AltaCliente frame = new AltaCliente();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public AltaCliente() {
		setTitle("AltaCliente");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 804, 341);
		AltaClientePane = new JPanel();
		AltaClientePane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(AltaClientePane);
		AltaClientePane.setLayout(null);
		
		JLabel lblCdula = new JLabel("C\u00E9dula:");
		lblCdula.setBounds(25, 64, 46, 14);
		AltaClientePane.add(lblCdula);
		
		JLabel lblNombre = new JLabel("Nombre:");
		lblNombre.setBounds(25, 101, 46, 14);
		AltaClientePane.add(lblNombre);
		
		JLabel lblApellido = new JLabel("Apellido:");
		lblApellido.setBounds(25, 135, 46, 14);
		AltaClientePane.add(lblApellido);
		
		JLabel lblTelefono = new JLabel("Telefono:");
		lblTelefono.setBounds(25, 173, 46, 14);
		AltaClientePane.add(lblTelefono);
		
		JLabel lblDireccion = new JLabel("Direccion:");
		lblDireccion.setBounds(203, 64, 54, 14);
		AltaClientePane.add(lblDireccion);
		
		JLabel lblLocalidad = new JLabel("Localidad:");
		lblLocalidad.setBounds(203, 101, 54, 14);
		AltaClientePane.add(lblLocalidad);
		
		JLabel lblCalle = new JLabel("Calle:");
		lblCalle.setBounds(203, 135, 46, 14);
		AltaClientePane.add(lblCalle);
		
		JLabel lblNroPuerta = new JLabel("Nro Puerta:");
		lblNroPuerta.setBounds(203, 173, 63, 14);
		AltaClientePane.add(lblNroPuerta);
		
		txtCed = new JTextField();
		txtCed.setBounds(81, 61, 86, 20);
		AltaClientePane.add(txtCed);
		txtCed.setColumns(10);
		
		txtNombre = new JTextField();
		txtNombre.setBounds(81, 98, 86, 20);
		AltaClientePane.add(txtNombre);
		txtNombre.setColumns(10);
		
		txtApellido = new JTextField();
		txtApellido.setBounds(81, 132, 86, 20);
		AltaClientePane.add(txtApellido);
		txtApellido.setColumns(10);
		
		txtTelefono = new JTextField();
		txtTelefono.setBounds(81, 170, 86, 20);
		AltaClientePane.add(txtTelefono);
		txtTelefono.setColumns(10);
		
		txtLocalidad = new JTextField();
		txtLocalidad.setBounds(287, 98, 119, 20);
		AltaClientePane.add(txtLocalidad);
		txtLocalidad.setColumns(10);
		
		txtCalle = new JTextField();
		txtCalle.setBounds(287, 132, 119, 20);
		AltaClientePane.add(txtCalle);
		txtCalle.setColumns(10);
		
		txtNroPuerta = new JTextField();
		txtNroPuerta.setBounds(287, 170, 119, 20);
		AltaClientePane.add(txtNroPuerta);
		txtNroPuerta.setColumns(10);
		
		JButton btnIngresar = new JButton("Ingresar");
		btnIngresar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try{
					
					System.out.println("Estoy intentando conectar a la base de datos");
					Class.forName("com.mysql.jdbc.Driver");
					
					Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
					System.out.println("Conexion exitosa");
					
					//creamos la consulta
					Statement comando = conn.createStatement();
			           comando.executeUpdate("insert into clientes(ci, nombre, apellido, calle, numPuerta, localidad) values "
			           		+ "(" + txtCed.getText() + ",'" + txtNombre.getText() + "','" + txtApellido.getText() + "','" + txtCalle.getText() + "'," + txtNroPuerta.getText() + ",'" + txtLocalidad.getText() + "')");
			           System.out.println("Se ingresaron los datos a la base de datos");
					
					
					conn.close();
					
				}catch (Exception c) {
					System.out.println("Error");
				}
			
			}
		});
		btnIngresar.setBounds(284, 233, 89, 23);
		AltaClientePane.add(btnIngresar);
		
		JLabel lblAltaCliente = new JLabel("Ingresar Clientes:");
		lblAltaCliente.setBounds(25, 11, 141, 14);
		AltaClientePane.add(lblAltaCliente);
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
			
		}catch (Exception c) {
			System.out.println("Error");
		}
		
		JList list = new JList();
		list.setBounds(449, 0, 6, 292);
		AltaClientePane.add(list);
		
		JLabel lblModificarClientes = new JLabel("Modificar Clientes:");
		lblModificarClientes.setBounds(476, 11, 119, 14);
		AltaClientePane.add(lblModificarClientes);
		
		JLabel label = new JLabel("C\u00E9dula:");
		label.setBounds(465, 64, 46, 14);
		AltaClientePane.add(label);
		
		JLabel label_1 = new JLabel("Nombre:");
		label_1.setBounds(465, 101, 46, 14);
		AltaClientePane.add(label_1);
		
		JLabel label_2 = new JLabel("Apellido:");
		label_2.setBounds(465, 135, 46, 14);
		AltaClientePane.add(label_2);
		
		JLabel label_3 = new JLabel("Telefono:");
		label_3.setBounds(465, 173, 46, 14);
		AltaClientePane.add(label_3);
		
		JLabel label_4 = new JLabel("Direccion:");
		label_4.setBounds(618, 64, 54, 14);
		AltaClientePane.add(label_4);
		
		JLabel label_5 = new JLabel("Localidad:");
		label_5.setBounds(618, 98, 54, 14);
		AltaClientePane.add(label_5);
		
		JLabel label_6 = new JLabel("Calle:");
		label_6.setBounds(618, 135, 46, 14);
		AltaClientePane.add(label_6);
		
		JLabel label_7 = new JLabel("Nro Puerta:");
		label_7.setBounds(618, 173, 63, 14);
		AltaClientePane.add(label_7);
		
		txtCed2 = new JTextField();
		txtCed2.setBounds(522, 61, 86, 20);
		AltaClientePane.add(txtCed2);
		txtCed2.setColumns(10);
		
		txtNombre2 = new JTextField();
		txtNombre2.setBounds(522, 98, 86, 20);
		AltaClientePane.add(txtNombre2);
		txtNombre2.setColumns(10);
		
		txtApellido2 = new JTextField();
		txtApellido2.setBounds(521, 132, 86, 20);
		AltaClientePane.add(txtApellido2);
		txtApellido2.setColumns(10);
		
		txtTel2 = new JTextField();
		txtTel2.setBounds(521, 170, 86, 20);
		AltaClientePane.add(txtTel2);
		txtTel2.setColumns(10);
		
		txtLocalidad2 = new JTextField();
		txtLocalidad2.setBounds(674, 98, 86, 20);
		AltaClientePane.add(txtLocalidad2);
		txtLocalidad2.setColumns(10);
		
		txtCalle2 = new JTextField();
		txtCalle2.setBounds(674, 132, 86, 20);
		AltaClientePane.add(txtCalle2);
		txtCalle2.setColumns(10);
		
		txtNroPuerta2 = new JTextField();
		txtNroPuerta2.setBounds(674, 170, 86, 20);
		AltaClientePane.add(txtNroPuerta2);
		txtNroPuerta2.setColumns(10);
		
		JButton btnIngresar_1 = new JButton("Ingresar");
		btnIngresar_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try{
					
					System.out.println("Estoy intentando conectar a la base de datos");
					Class.forName("com.mysql.jdbc.Driver");
					
					Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
					System.out.println("Conexion exitosa");
					
					//creamos la consulta
					Statement comando = conn.createStatement();
			           comando.executeUpdate("update clientes set nombre = "+"'"+ txtNombre2.getText() +"'"+", apellido = "+"'"+txtApellido2.getText()+"'"+
			        		   ", calle = "+"'"+txtCalle2.getText()+ "'"+", numPuerta = "+txtNroPuerta2.getText()+ ", localidad = "+"'"+txtLocalidad2.getText()+"'"+" where ci = "+txtCed2.getText()+";");
					
			           System.out.println("Se ingresaron los datos a la base de datos");
					
					
					conn.close();
					
				}catch (Exception c) {
					System.out.println("Error");
				}
			}
		});
		btnIngresar_1.setBounds(580, 233, 89, 23);
		AltaClientePane.add(btnIngresar_1);
		
		JButton btnVolverAlMenu = new JButton("Volver al menu");
		btnVolverAlMenu.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				MenuVentas menu=new MenuVentas();
				menu.setVisible(true);
				AltaCliente.this.setVisible(false);
			}
		});
		btnVolverAlMenu.setBounds(65, 233, 119, 23);
		AltaClientePane.add(btnVolverAlMenu);
	}
}

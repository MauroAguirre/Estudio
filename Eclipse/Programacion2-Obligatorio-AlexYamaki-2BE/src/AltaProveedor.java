import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.awt.event.ActionEvent;
import javax.swing.JList;
import javax.swing.JSeparator;

public class AltaProveedor extends JFrame {

	private JPanel contentPane;
	private JTextField txtRazonSocial;
	private JTextField txtRut;
	private JTextField txtCorreo;
	private JTextField txtTelefono;
	private JTextField txtNomContacto;
	private JTextField txtLocalidad;
	private JTextField txtCalle;
	private JTextField txtNroPuerta;
	private JTextField txtRazonSocial2;
	private JTextField txtRut2;
	private JTextField txtCalle2;
	private JTextField txtNroPuerta2;
	private JTextField txtLocalidad2;
	private JTextField txtCorreo2;
	private JTextField txtNomContacto2;
	private JTextField txtTelefono2;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AltaProveedor frame = new AltaProveedor();
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
	public AltaProveedor() {
		setTitle("AltaProveedor");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 1060, 368);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblRazonSocial = new JLabel("Razon Social:");
		lblRazonSocial.setBounds(30, 74, 71, 14);
		contentPane.add(lblRazonSocial);
		
		JLabel lblRut = new JLabel("RUT:");
		lblRut.setBounds(30, 116, 46, 14);
		contentPane.add(lblRut);
		
		JLabel lblLocalidad = new JLabel("Localidad:");
		lblLocalidad.setBounds(283, 74, 62, 14);
		contentPane.add(lblLocalidad);
		
		JLabel lblCalle = new JLabel("Calle:");
		lblCalle.setBounds(30, 159, 46, 14);
		contentPane.add(lblCalle);
		
		JLabel lblNroPuerta = new JLabel("Nro Puerta:");
		lblNroPuerta.setBounds(30, 205, 71, 14);
		contentPane.add(lblNroPuerta);
		
		JLabel lblTelefono = new JLabel("Telefono:");
		lblTelefono.setBounds(283, 216, 46, 14);
		contentPane.add(lblTelefono);
		
		JLabel lblEmail = new JLabel("E-mail:");
		lblEmail.setBounds(283, 116, 46, 14);
		contentPane.add(lblEmail);
		
		JLabel lblNombreContacto = new JLabel("Nombre Contacto:");
		lblNombreContacto.setBounds(283, 159, 94, 14);
		contentPane.add(lblNombreContacto);
		
		txtRazonSocial = new JTextField();
		txtRazonSocial.setBounds(100, 71, 86, 20);
		contentPane.add(txtRazonSocial);
		txtRazonSocial.setColumns(10);
		
		txtRut = new JTextField();
		txtRut.setBounds(100, 113, 86, 20);
		contentPane.add(txtRut);
		txtRut.setColumns(10);
		
		txtCorreo = new JTextField();
		txtCorreo.setBounds(387, 113, 86, 20);
		contentPane.add(txtCorreo);
		txtCorreo.setColumns(10);
		
		txtTelefono = new JTextField();
		txtTelefono.setBounds(387, 213, 86, 20);
		contentPane.add(txtTelefono);
		txtTelefono.setColumns(10);
		
		txtNomContacto = new JTextField();
		txtNomContacto.setBounds(387, 156, 86, 20);
		contentPane.add(txtNomContacto);
		txtNomContacto.setColumns(10);
		
		txtLocalidad = new JTextField();
		txtLocalidad.setBounds(387, 71, 86, 20);
		contentPane.add(txtLocalidad);
		txtLocalidad.setColumns(10);
		
		txtCalle = new JTextField();
		txtCalle.setBounds(100, 156, 86, 20);
		contentPane.add(txtCalle);
		txtCalle.setColumns(10);
		
		txtNroPuerta = new JTextField();
		txtNroPuerta.setBounds(100, 202, 86, 20);
		contentPane.add(txtNroPuerta);
		txtNroPuerta.setColumns(10);
		
		JLabel lblAltaProveedor = new JLabel("Alta Proveedor");
		lblAltaProveedor.setBounds(166, 11, 93, 14);
		contentPane.add(lblAltaProveedor);
		
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
			           comando.executeUpdate("insert into proveedores(razonSocial, rut, calle, numPuerta,localidad,mail,nomContacto) values "
			           		+ "(" + txtRazonSocial.getText() + ",'" + txtRut.getText() + "','" + txtCalle.getText() + "','" + txtNroPuerta.getText() + 
			           		"','" + txtLocalidad.getText() +"','" + txtCorreo.getText() +"','" + txtNomContacto.getText() +"')");
					
			           System.out.println("Se ingresaron los datos a la base de datos");
					
					
					conn.close();
					
				}catch (Exception b) {
					System.out.println("Error");
				}
			}
		});
		btnIngresar.setBounds(358, 278, 89, 23);
		contentPane.add(btnIngresar);
		
		JButton btnVolverAlMenu = new JButton("Volver al menu");
		btnVolverAlMenu.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				MenuVentas menu=new MenuVentas();
				menu.setVisible(true);
				AltaProveedor.this.dispose();
			}
		});
		btnVolverAlMenu.setBounds(88, 278, 124, 23);
		contentPane.add(btnVolverAlMenu);
		
		JSeparator separator = new JSeparator();
		separator.setBounds(562, 11, 10, 308);
		contentPane.add(separator);
		
		JLabel lblModificarProveedor = new JLabel("Modificar Proveedor");
		lblModificarProveedor.setBounds(686, 11, 166, 14);
		contentPane.add(lblModificarProveedor);
		
		JLabel label = new JLabel("Razon Social:");
		label.setBounds(597, 74, 71, 14);
		contentPane.add(label);
		
		txtRazonSocial2 = new JTextField();
		txtRazonSocial2.setBounds(692, 71, 86, 20);
		contentPane.add(txtRazonSocial2);
		txtRazonSocial2.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("RUT:");
		lblNewLabel.setBounds(597, 116, 46, 14);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Calle:");
		lblNewLabel_1.setBounds(597, 159, 46, 14);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Nro Puerta:");
		lblNewLabel_2.setBounds(597, 205, 100, 14);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Localidad:");
		lblNewLabel_3.setBounds(824, 74, 71, 14);
		contentPane.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("E-Mail:");
		lblNewLabel_4.setBounds(824, 116, 46, 14);
		contentPane.add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Nombre Contacto:");
		lblNewLabel_5.setBounds(824, 159, 105, 14);
		contentPane.add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("Telefono:");
		lblNewLabel_6.setBounds(824, 205, 46, 14);
		contentPane.add(lblNewLabel_6);
		
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
			           comando.executeUpdate("update proveedores set Rut = "+"'"+txtRut2.getText() +"'"+", razonSocial = "+"'"+txtRazonSocial2.getText()+"'"+
			        		   ", calle = "+"'"+txtCalle2.getText()+ "'"+", numPuerta = "+txtNroPuerta2.getText()+ ", localidad = "+"'"+txtLocalidad2.getText()+"'"+","
			        		    + "mail = "+"'"+txtCorreo2.getText()+"'"+", nomContacto = "+"'"+txtNomContacto.getText()+"'"+ "where Rut = "+txtRut.getText()+";");
			           System.out.println("Se ingresaron los datos a la base de datos");
					
					
					conn.close();
					
				}catch (Exception c) {
					System.out.println("Error");
				}
				
			}
		});
		btnIngresar_1.setBounds(749, 278, 89, 23);
		contentPane.add(btnIngresar_1);
		
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
    		    
    		    System.out.println("Razon Social: "+lista.getString("razonSocial")+" - Rut: "+lista.getString("rut")+" - Calle: "+lista.getString("calle")+
    		    		" - Numero de puerta: "+lista.getString("numPuerta")+ " - Localidad: "+lista.getString("localidad")+" - E-mail: "+lista.getString("mail")+" - Nombre Contacto: "+lista.getString("nomContacto")); 
    		}
            
			conn.close();
			
		}catch (Exception c) {
			System.out.println("Error");
		}
		
		txtRut2 = new JTextField();
		txtRut2.setBounds(692, 113, 86, 20);
		contentPane.add(txtRut2);
		txtRut2.setColumns(10);
		
		txtCalle2 = new JTextField();
		txtCalle2.setBounds(692, 156, 86, 20);
		contentPane.add(txtCalle2);
		txtCalle2.setColumns(10);
		
		txtNroPuerta2 = new JTextField();
		txtNroPuerta2.setBounds(692, 202, 86, 20);
		contentPane.add(txtNroPuerta2);
		txtNroPuerta2.setColumns(10);
		
		txtLocalidad2 = new JTextField();
		txtLocalidad2.setBounds(932, 71, 86, 20);
		contentPane.add(txtLocalidad2);
		txtLocalidad2.setColumns(10);
		
		txtCorreo2 = new JTextField();
		txtCorreo2.setBounds(932, 113, 86, 20);
		contentPane.add(txtCorreo2);
		txtCorreo2.setColumns(10);
		
		txtNomContacto2 = new JTextField();
		txtNomContacto2.setBounds(932, 156, 86, 20);
		contentPane.add(txtNomContacto2);
		txtNomContacto2.setColumns(10);
		
		txtTelefono2 = new JTextField();
		txtTelefono2.setBounds(932, 202, 86, 20);
		contentPane.add(txtTelefono2);
		txtTelefono2.setColumns(10);
	}

}

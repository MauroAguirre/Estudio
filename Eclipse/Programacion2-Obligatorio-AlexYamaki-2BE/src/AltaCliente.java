import java.awt.BorderLayout;
import java.awt.EventQueue;

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

public class AltaCliente extends JFrame {

	private JPanel contentPane;
	private JTextField txtCed;
	private JTextField txtNombre;
	private JTextField txtApellido;
	private JTextField txtTelefono;
	private JTextField txtLocalidad;
	private JTextField txtCalle;
	private JTextField txtNroPuerta;

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
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblCdula = new JLabel("C\u00E9dula:");
		lblCdula.setBounds(25, 64, 46, 14);
		contentPane.add(lblCdula);
		
		JLabel lblNombre = new JLabel("Nombre:");
		lblNombre.setBounds(25, 101, 46, 14);
		contentPane.add(lblNombre);
		
		JLabel lblApellido = new JLabel("Apellido:");
		lblApellido.setBounds(25, 135, 46, 14);
		contentPane.add(lblApellido);
		
		JLabel lblTelefono = new JLabel("Telefono:");
		lblTelefono.setBounds(25, 173, 46, 14);
		contentPane.add(lblTelefono);
		
		JLabel lblDireccion = new JLabel("Direccion:");
		lblDireccion.setBounds(203, 50, 54, 14);
		contentPane.add(lblDireccion);
		
		JLabel lblLocalidad = new JLabel("Localidad:");
		lblLocalidad.setBounds(214, 79, 54, 14);
		contentPane.add(lblLocalidad);
		
		JLabel lblCalle = new JLabel("Calle:");
		lblCalle.setBounds(214, 114, 46, 14);
		contentPane.add(lblCalle);
		
		JLabel lblNroPuerta = new JLabel("Nro Puerta:");
		lblNroPuerta.setBounds(214, 153, 63, 14);
		contentPane.add(lblNroPuerta);
		
		txtCed = new JTextField();
		txtCed.setBounds(81, 61, 86, 20);
		contentPane.add(txtCed);
		txtCed.setColumns(10);
		
		txtNombre = new JTextField();
		txtNombre.setBounds(81, 98, 86, 20);
		contentPane.add(txtNombre);
		txtNombre.setColumns(10);
		
		txtApellido = new JTextField();
		txtApellido.setBounds(81, 132, 86, 20);
		contentPane.add(txtApellido);
		txtApellido.setColumns(10);
		
		txtTelefono = new JTextField();
		txtTelefono.setBounds(81, 170, 86, 20);
		contentPane.add(txtTelefono);
		txtTelefono.setColumns(10);
		
		txtLocalidad = new JTextField();
		txtLocalidad.setBounds(287, 76, 86, 20);
		contentPane.add(txtLocalidad);
		txtLocalidad.setColumns(10);
		
		txtCalle = new JTextField();
		txtCalle.setBounds(287, 111, 86, 20);
		contentPane.add(txtCalle);
		txtCalle.setColumns(10);
		
		txtNroPuerta = new JTextField();
		txtNroPuerta.setBounds(287, 150, 86, 20);
		contentPane.add(txtNroPuerta);
		txtNroPuerta.setColumns(10);
		
		JButton btnIngresar = new JButton("Ingresar");
		btnIngresar.setBounds(274, 215, 89, 23);
		contentPane.add(btnIngresar);
		
		JLabel lblAltaCliente = new JLabel("Alta Cliente");
		lblAltaCliente.setBounds(90, 11, 77, 14);
		contentPane.add(lblAltaCliente);
		
		JTextPane textPane = new JTextPane();
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
    		    textPane.setText(textPane.getText()+"CI: "+lista.getString("ci")+" - Nombre: "+lista.getString("nombre")+" - Apellido: "+lista.getString("apellido")+
    		    		" - calle: "+lista.getString("calle")+ " - Numero de Puerta: "+lista.getString("numPuerta")+" - localidad: "+lista.getString("localidad")); 
    		    
    		    System.out.println("CI: "+lista.getString("ci")+" - Nombre: "+lista.getString("nombre")+" - Apellido: "+lista.getString("apellido")+
    		    		" - calle: "+lista.getString("calle")+ " - Numero de Puerta: "+lista.getString("numPuerta")+" - localidad: "+lista.getString("localidad")); 
    		}
            
			conn.close();
			
		}catch (Exception c) {
			System.out.println("Error");
		}
		
		textPane.setBounds(25, 198, 232, 52);
		contentPane.add(textPane);
	}
}

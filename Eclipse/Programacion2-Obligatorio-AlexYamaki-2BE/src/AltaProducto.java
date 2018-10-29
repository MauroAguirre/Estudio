import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class AltaProducto extends JFrame {

	private JPanel contentPane;
	private JTextField txtId;
	private JTextField txtDescripcion;
	private JTextField txtMarca;
	private JTextField txtCantidad;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					AltaProducto frame = new AltaProducto();
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
	public AltaProducto() {
		setTitle("AltaProducto");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblId = new JLabel("ID:");
		lblId.setBounds(23, 100, 46, 14);
		contentPane.add(lblId);
		
		JLabel lblDescripcion = new JLabel("Descripcion:");
		lblDescripcion.setBounds(23, 150, 64, 14);
		contentPane.add(lblDescripcion);
		
		JLabel lblMarca = new JLabel("Marca:");
		lblMarca.setBounds(237, 100, 46, 14);
		contentPane.add(lblMarca);
		
		JLabel lblCantidad = new JLabel("Cantidad:");
		lblCantidad.setBounds(235, 150, 64, 14);
		contentPane.add(lblCantidad);
		
		txtId = new JTextField();
		txtId.setBounds(97, 97, 86, 20);
		contentPane.add(txtId);
		txtId.setColumns(10);
		
		txtDescripcion = new JTextField();
		txtDescripcion.setBounds(97, 147, 86, 20);
		contentPane.add(txtDescripcion);
		txtDescripcion.setColumns(10);
		
		txtMarca = new JTextField();
		txtMarca.setBounds(293, 97, 86, 20);
		contentPane.add(txtMarca);
		txtMarca.setColumns(10);
		
		txtCantidad = new JTextField();
		txtCantidad.setBounds(293, 147, 86, 20);
		contentPane.add(txtCantidad);
		txtCantidad.setColumns(10);
		
		JLabel lblAltaProducto = new JLabel("Alta Producto");
		lblAltaProducto.setBounds(171, 35, 72, 14);
		contentPane.add(lblAltaProducto);
		
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
			        comando.executeUpdate("insert into productos(id, descripcion, marca, cantidad) values "
			           		+ "(" + txtId.getText() + ",'" + txtDescripcion.getText() + "','" + txtMarca.getText() + "','" + txtCantidad.getText() + "')");
					
			        System.out.println("Se ingresaron los datos a la base de datos");
					
					
					conn.close();
					
				}catch (Exception c) {
					System.out.println("Error");
				}
			}
		});
		btnIngresar.setBounds(89, 208, 89, 23);
		contentPane.add(btnIngresar);
		
		JButton btnSalir = new JButton("Salir");
		btnSalir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				System.exit(0);
			}
		});
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
			}
		});
		btnSalir.setBounds(222, 208, 89, 23);
		contentPane.add(btnSalir);
	}
}

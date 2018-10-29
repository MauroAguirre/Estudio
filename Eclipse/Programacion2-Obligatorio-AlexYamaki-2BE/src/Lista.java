import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JButton;
import javax.swing.JLabel;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.awt.event.ActionEvent;

public class Lista extends JFrame {

	private JPanel contentPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Lista frame = new Lista();
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
	public Lista() {
		setTitle("Listas");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JButton btnNewButton = new JButton("Lista de Clientes");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
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
				System.out.println("-------------------------------------------------------------------------------------------------------------------"+"\n");
			}
		});
		btnNewButton.setBounds(27, 55, 193, 23);
		contentPane.add(btnNewButton);
		
		JButton btnNewButton_1 = new JButton("Lista de Productos");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
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
					
				}catch (Exception c) {
					System.out.println("Error");
				}
				System.out.println("-------------------------------------------------------------------------------------------------------------------"+"\n");
			}
		});
		btnNewButton_1.setBounds(27, 108, 193, 23);
		contentPane.add(btnNewButton_1);
		
		JButton btnNewButton_2 = new JButton("Lista de Proveedores");
		btnNewButton_2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
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
		    		    		" - Numero de Puerta: "+lista.getString("numPuerta")+ " - Localidad: "+lista.getString("localidad")+" - Mail: "+lista.getString("mail")+" - Nombre de Contacto: "+lista.getString("nomContacto")); 
		    		}
		            
					conn.close();
					
				}catch (Exception c) {
					System.out.println("Error");
				}
				System.out.println("-------------------------------------------------------------------------------------------------------------------"+"\n");
			}
		});
		btnNewButton_2.setBounds(27, 164, 193, 23);
		contentPane.add(btnNewButton_2);
		
		JButton btnNewButton_4 = new JButton("Salir");
		btnNewButton_4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});
		btnNewButton_4.setBounds(267, 228, 89, 23);
		contentPane.add(btnNewButton_4);
		
		JLabel lblElijaLaLista = new JLabel("Elija la lista que desee:");
		lblElijaLaLista.setBounds(27, 11, 131, 14);
		contentPane.add(lblElijaLaLista);
		
		JButton btnVolverAlMenu = new JButton("Volver al menu");
		btnVolverAlMenu.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				MenuVentas menu=new MenuVentas();
				menu.setVisible(true);
				Lista.this.setVisible(false);
			}
		});
		btnVolverAlMenu.setBounds(69, 228, 118, 23);
		contentPane.add(btnVolverAlMenu);
	}

}

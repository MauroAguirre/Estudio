import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;

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
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblRazonSocial = new JLabel("Razon Social:");
		lblRazonSocial.setBounds(30, 53, 71, 14);
		contentPane.add(lblRazonSocial);
		
		JLabel lblRut = new JLabel("RUT:");
		lblRut.setBounds(30, 94, 46, 14);
		contentPane.add(lblRut);
		
		JLabel lblDireccion = new JLabel("Direccion:");
		lblDireccion.setBounds(214, 53, 62, 14);
		contentPane.add(lblDireccion);
		
		JLabel lblLocalidad = new JLabel("Localidad:");
		lblLocalidad.setBounds(247, 78, 62, 14);
		contentPane.add(lblLocalidad);
		
		JLabel lblCalle = new JLabel("Calle:");
		lblCalle.setBounds(247, 126, 46, 14);
		contentPane.add(lblCalle);
		
		JLabel lblNroPuerta = new JLabel("Nro Puerta:");
		lblNroPuerta.setBounds(247, 174, 71, 14);
		contentPane.add(lblNroPuerta);
		
		JLabel lblTelefono = new JLabel("Telefono:");
		lblTelefono.setBounds(30, 174, 46, 14);
		contentPane.add(lblTelefono);
		
		JLabel lblEmail = new JLabel("E-mail:");
		lblEmail.setBounds(30, 138, 46, 14);
		contentPane.add(lblEmail);
		
		JLabel lblNombreContacto = new JLabel("Nombre Contacto:");
		lblNombreContacto.setBounds(30, 216, 94, 14);
		contentPane.add(lblNombreContacto);
		
		txtRazonSocial = new JTextField();
		txtRazonSocial.setBounds(100, 50, 86, 20);
		contentPane.add(txtRazonSocial);
		txtRazonSocial.setColumns(10);
		
		txtRut = new JTextField();
		txtRut.setBounds(100, 91, 86, 20);
		contentPane.add(txtRut);
		txtRut.setColumns(10);
		
		txtCorreo = new JTextField();
		txtCorreo.setBounds(100, 135, 86, 20);
		contentPane.add(txtCorreo);
		txtCorreo.setColumns(10);
		
		txtTelefono = new JTextField();
		txtTelefono.setBounds(100, 171, 86, 20);
		contentPane.add(txtTelefono);
		txtTelefono.setColumns(10);
		
		txtNomContacto = new JTextField();
		txtNomContacto.setBounds(120, 213, 86, 20);
		contentPane.add(txtNomContacto);
		txtNomContacto.setColumns(10);
		
		txtLocalidad = new JTextField();
		txtLocalidad.setBounds(305, 75, 86, 20);
		contentPane.add(txtLocalidad);
		txtLocalidad.setColumns(10);
		
		txtCalle = new JTextField();
		txtCalle.setBounds(305, 123, 86, 20);
		contentPane.add(txtCalle);
		txtCalle.setColumns(10);
		
		txtNroPuerta = new JTextField();
		txtNroPuerta.setBounds(305, 171, 86, 20);
		contentPane.add(txtNroPuerta);
		txtNroPuerta.setColumns(10);
		
		JLabel lblAltaProveedor = new JLabel("Alta Proveedor");
		lblAltaProveedor.setBounds(166, 11, 93, 14);
		contentPane.add(lblAltaProveedor);
		
		JButton btnIngresar = new JButton("Ingresar");
		btnIngresar.setBounds(287, 228, 89, 23);
		contentPane.add(btnIngresar);
	}

}

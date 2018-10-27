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
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 450, 300);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblId = new JLabel("ID:");
		lblId.setBounds(47, 100, 46, 14);
		contentPane.add(lblId);
		
		JLabel lblDescripcion = new JLabel("Descripcion:");
		lblDescripcion.setBounds(47, 150, 64, 14);
		contentPane.add(lblDescripcion);
		
		JLabel lblMarca = new JLabel("Marca:");
		lblMarca.setBounds(237, 100, 46, 14);
		contentPane.add(lblMarca);
		
		JLabel lblCantidad = new JLabel("Cantidad:");
		lblCantidad.setBounds(235, 150, 64, 14);
		contentPane.add(lblCantidad);
		
		txtId = new JTextField();
		txtId.setBounds(89, 97, 86, 20);
		contentPane.add(txtId);
		txtId.setColumns(10);
		
		txtDescripcion = new JTextField();
		txtDescripcion.setBounds(115, 147, 86, 20);
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
		
		JButton btnIngresar = new JButton("Ingresar");
		btnIngresar.setBounds(89, 208, 89, 23);
		contentPane.add(btnIngresar);
		
		JButton btnSalir = new JButton("Salir");
		btnSalir.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				
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

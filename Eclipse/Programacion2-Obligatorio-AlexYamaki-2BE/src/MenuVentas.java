import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class MenuVentas extends JFrame {

	private JPanel MenuVentasPane;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MenuVentas frame = new MenuVentas();
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
	public MenuVentas() {
		setTitle("Menu de Ventas");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 452, 335);
		MenuVentasPane = new JPanel();
		MenuVentasPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(MenuVentasPane);
		MenuVentasPane.setLayout(null);
		
		JLabel lblElijaUnaOpcion = new JLabel("Elija una opcion:");
		lblElijaUnaOpcion.setBounds(25, 30, 102, 14);
		MenuVentasPane.add(lblElijaUnaOpcion);
		
		
		JButton btnNewButton = new JButton("AltaCliente");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				AltaCliente ventanaAltaCliente= new AltaCliente();
				ventanaAltaCliente.setVisible(true);
				MenuVentas.this.dispose();
			}
		});
		btnNewButton.setBounds(25, 114, 102, 23);
		MenuVentasPane.add(btnNewButton);
		
		
		JButton btnAltaproducto = new JButton("AltaProducto");
		btnAltaproducto.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				AltaProducto ventanaAltaProducto= new AltaProducto();
				ventanaAltaProducto.setVisible(true);
				MenuVentas.this.dispose();
			}
		});
		btnAltaproducto.setBounds(25, 159, 102, 23);
		MenuVentasPane.add(btnAltaproducto);
		
		
		JButton btnNewButton_1 = new JButton("AltaProveedor");
		btnNewButton_1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				AltaProveedor ventanaAltaProveedor= new AltaProveedor();
				ventanaAltaProveedor.setVisible(true);
				MenuVentas.this.dispose();
			}
		});
		btnNewButton_1.setBounds(25, 206, 102, 23);
		MenuVentasPane.add(btnNewButton_1);
		
		JButton btnSalir = new JButton("Salir");
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				System.exit(0);
			}
		});
		
		btnSalir.setBounds(260, 240, 102, 23);
		MenuVentasPane.add(btnSalir);
		
		
		JButton btnListaDeProductos = new JButton("Listas");
		btnListaDeProductos.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Lista allList= new Lista();
				allList.setVisible(true);
				MenuVentas.this.dispose();
			}
		});
		btnListaDeProductos.setBounds(217, 142, 135, 23);
		MenuVentasPane.add(btnListaDeProductos);
		
		JButton btnRealizarVenta = new JButton("Realizar Venta");
		btnRealizarVenta.setBounds(217, 72, 135, 23);
		MenuVentasPane.add(btnRealizarVenta);
		
		
		JButton btnCargarElementosDb = new JButton("Cargar elementos DB");
		btnCargarElementosDb.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
			}
		});
		btnCargarElementosDb.setBounds(23, 72, 135, 23);
		MenuVentasPane.add(btnCargarElementosDb);
	}
}

import java.awt.BorderLayout;
import java.awt.EventQueue;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JLabel;
import javax.swing.JComboBox;
import javax.swing.JTextField;
import javax.swing.DefaultComboBoxModel;
import javax.swing.DefaultListModel;
import javax.swing.JButton;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JList;
import javax.swing.border.BevelBorder;

public class VentanaVentaProducto extends JFrame {
	Calendar fecha = Calendar.getInstance();
	SimpleDateFormat formatoFecha = new SimpleDateFormat("yyyy-MM-dd");
	
	
	String[] cedClientes;
	String[] idProducto;
	List<VentaProducto> ventaProductos;
	
	ResultSet resultado;
	Statement estado;
	Connection conn;	
	private JPanel contentPane;
	private JTextField txtTotal;
	private JTextField textCantidad;
	private JTextField textId;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		
		
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					VentanaVentaProducto frame = new VentanaVentaProducto();
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
	public VentanaVentaProducto() {
		//creo la lista de producto comprados
		ventaProductos = new ArrayList<VentaProducto>();
		
		setTitle("Venta");
		
		//System.out.println(fecha);
		String fechaActual = formatoFecha.format(fecha.getTime());
		System.out.println(fechaActual);		
		
//////// para la cedula..		
		try{	
			System.out.println("Estoy intentando conectar a la base de datos");
			Class.forName("com.mysql.jdbc.Driver");
			
			conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
			System.out.println("Conexion exitosa");
			
			//creamos la consulta
			estado = conn.createStatement();
			resultado = estado.executeQuery ("select ci from clientes");
			
			//leer resultados
			int contador = 0;
			while (resultado.next()) {
			    contador++;
			}
			
			resultado.beforeFirst();	
			
			cedClientes = new String[ contador ];
			
			System.out.println("en total hay " + contador + " Clientes");
			
			int i= 0;
			while (resultado.next()) 
			{ 
			    cedClientes[i] = resultado.getString("ci"); 
			    i++;
			}
		}
		catch (Exception e) {
			// TODO: handle exception
			System.out.println("error del tipo " + e.getMessage());
		}		
		
		
////////para el producto..		
		try{	
			resultado = estado.executeQuery ("select id from productos");
			
			//leer resultados
			int contador = 0;
			while (resultado.next()) {
			    contador++;
			}
			
			resultado.beforeFirst();	
			
			idProducto = new String[ contador ];
			
			System.out.println("en total hay " + contador +" Productos");
			
			int i= 0;
			while (resultado.next()) 
			{ 
				idProducto[i] = resultado.getString("id"); 
			    i++;
			}
		}
		catch (Exception e) {
			// TODO: handle exception
			System.out.println("error del tipo " + e.getMessage());
		}		
		
				
		
		
		
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 688, 373);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JLabel lblCedula = new JLabel("Cedula");
		lblCedula.setBounds(28, 24, 56, 16);
		contentPane.add(lblCedula);
		
		JLabel lblNom = new JLabel("Nombre:");
		lblNom.setBounds(234, 27, 56, 16);
		contentPane.add(lblNom);
		
		JLabel lblNombre = new JLabel("-");
		lblNombre.setBounds(302, 27, 95, 16);
		contentPane.add(lblNombre);
		
		JLabel lblApell = new JLabel("Apellido:");
		lblApell.setBounds(409, 27, 56, 16);
		contentPane.add(lblApell);
		
		JLabel lblApellido = new JLabel("-");
		lblApellido.setBounds(486, 30, 111, 16);
		contentPane.add(lblApellido);
		
		JComboBox comboCliente = new JComboBox();
		comboCliente.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				
				try {
			
					String sql =  "SELECT * FROM clientes WHERE ci = "+comboCliente.getSelectedItem().toString() ;
					
					resultado = estado.executeQuery ( sql );
					while (resultado.next()) 
					{ 
						lblNombre.setText( resultado.getString("nombre") );
						lblApellido.setText( resultado.getString("apellido") );
					}
					
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
			}
		});
		comboCliente.setBounds(107, 24, 104, 22);
		comboCliente.setModel(new DefaultComboBoxModel(cedClientes));
		contentPane.add(comboCliente);
		
		JLabel lblIdProd = new JLabel("Id Prod");
		lblIdProd.setBounds(28, 70, 56, 16);
		contentPane.add(lblIdProd);
		
		JLabel lblDesc = new JLabel("Desc.:");
		lblDesc.setBounds(234, 73, 56, 16);
		contentPane.add(lblDesc);
		
		JLabel lblDescripcion = new JLabel("-");
		lblDescripcion.setBounds(302, 73, 95, 16);
		contentPane.add(lblDescripcion);
		
		JLabel lblCantDisp = new JLabel("Cant. Disp.");
		lblCantDisp.setBounds(409, 73, 76, 16);
		contentPane.add(lblCantDisp);
		
		JLabel lblCantidad = new JLabel("-");
		lblCantidad.setBounds(486, 73, 111, 16);
		contentPane.add(lblCantidad);
		
		JComboBox comboProducto = new JComboBox();
		comboProducto.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				
				try {
			
					String sql =  "SELECT * FROM productos WHERE id = "+comboProducto.getSelectedItem().toString() ;
					
					resultado = estado.executeQuery ( sql );
					while (resultado.next()) 
					{ 
						lblDescripcion.setText( resultado.getString("descripcion") );
						lblCantidad.setText( resultado.getString("cantidad") );
					}
					
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				
			}
		});
		comboProducto.setBounds(107, 70, 104, 22);
		comboProducto.setModel(new DefaultComboBoxModel(idProducto));
		contentPane.add(comboProducto);
		
		txtTotal = new JTextField();
		txtTotal.setBounds(107, 192, 104, 22);
		contentPane.add(txtTotal);
		txtTotal.setColumns(10);
		
		JLabel lblPrecioTotal = new JLabel("Precio total");
		lblPrecioTotal.setBounds(28, 195, 67, 16);
		contentPane.add(lblPrecioTotal);
		
		JLabel lblResultado = new JLabel(".");
		lblResultado.setBounds(28, 239, 186, 16);
		contentPane.add(lblResultado);
		
		JButton btnVender = new JButton("Vender");
		btnVender.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseReleased(MouseEvent arg0) {				
				boolean bien = true;
				try{
					
					System.out.println("Estoy intentando conectar a la base de datos");
					Class.forName("com.mysql.jdbc.Driver");
					
					Connection conn = DriverManager.getConnection("jdbc:mysql://localhost/obligatorio_db","root", "");
					System.out.println("Conexion exitosa");
					
					Statement comando = conn.createStatement();
					//verificar si nos pasamos del stock
					for(int i=0;i<ventaProductos.size();i++) {
						ResultSet cantidad = comando.executeQuery("select * from productos where id = '"+ventaProductos.get(i).getIdProducto()+"'");
						int numerin = -888;
						while (cantidad.next()) 
			    		{
			    		    numerin =Integer.parseInt(cantidad.getString("cantidad"));
			    		}
						if(ventaProductos.get(i).getCantidad() > numerin)
						{
							bien = false;
							break;
						}	
			        }
					if(bien) {
					
						//creamos la tabla venta
				           comando.executeUpdate("insert into ventas(id, ciCliente, total) values "
				           		+ "(" + textId.getText() + ",'" + comboCliente.getSelectedItem().toString() + "','" + txtTotal.getText()+ "')");
				        System.out.println("Se creo la tabla venta");
						
				        
				        
				        //creamos la tablas ventaProducto
				        for(int i=0;i<ventaProductos.size();i++) {
					        comando.executeUpdate("insert into ventaproductos(idVenta, idProducto, cantidad) values "
					        + "(" + textId.getText() + ",'" + ventaProductos.get(i).getIdProducto() + "','" + ventaProductos.get(i).getCantidad()+ "')");
					        System.out.println("Se creo la tabla VentaProducto del producto "+ventaProductos.get(i).getIdProducto());
					        comando.executeUpdate("update productos set cantidad = cantidad -'"+ ventaProductos.get(i).getCantidad()+"' where id = '"+ventaProductos.get(i).getIdProducto()+"'");
				        }
				        lblResultado.setText("venta ingresada");
					}
					else
						lblResultado.setText("nos pasamos del stock");
					
				}catch (Exception c) {
					System.out.println("Error");
				}
				
			}
		});
		btnVender.setBounds(28, 278, 76, 25);
		contentPane.add(btnVender);
		
		
		JList list = new JList();
		list.setBounds(324, 183, 281, 115);
		this.getContentPane().add(list);
		
		DefaultListModel dlm = new DefaultListModel();
		list.setModel(dlm);
		
		JButton btnAgregarProducto = new JButton("Agregar producto");
		btnAgregarProducto.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseReleased(MouseEvent e) {
				boolean esta = false;
				VentaProducto vp = new VentaProducto(Integer.parseInt(comboProducto.getSelectedItem().toString()),Integer.parseInt(textCantidad.getText()));
				for(int i=0;i<ventaProductos.size();i++) {
					if(ventaProductos.get(i).getIdProducto()==Integer.parseInt(comboProducto.getSelectedItem().toString())) {
						esta = true;
						break;
					}
				}
				if(!esta) {
					ventaProductos.add(vp);
					dlm.addElement("Producto: "+vp.getIdProducto() +" - Cantidad: "+vp.getCantidad());
				}
				else
					lblResultado.setText("El producto ya esta ingresado");
			}
		});
		btnAgregarProducto.setBounds(25, 147, 186, 23);
		contentPane.add(btnAgregarProducto);
		
		JLabel lblCantidad_1 = new JLabel("Cantidad");
		lblCantidad_1.setBounds(28, 112, 46, 14);
		contentPane.add(lblCantidad_1);
		
		textCantidad = new JTextField();
		textCantidad.setBounds(107, 109, 104, 20);
		contentPane.add(textCantidad);
		textCantidad.setColumns(10);
		
		JLabel lblProductosSeleccionados = new JLabel("Productos seleccionados");
		lblProductosSeleccionados.setBounds(409, 151, 146, 14);
		contentPane.add(lblProductosSeleccionados);
		
		textId = new JTextField();
		textId.setBounds(399, 109, 86, 20);
		contentPane.add(textId);
		textId.setColumns(10);
		
		JLabel lblId = new JLabel("Id");
		lblId.setBounds(234, 112, 46, 14);
		contentPane.add(lblId);
	}
}

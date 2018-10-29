
import java.awt.EventQueue;

import javax.swing.DefaultListModel;
import javax.swing.JFrame;
import java.awt.GridLayout;
import javax.swing.SpringLayout;
import javax.swing.JList;
import java.awt.GridBagLayout;
import javax.swing.JComboBox;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JTextField;
import javax.swing.JLabel;

public class Probando {

	private JFrame frame;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Probando window = new Probando();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Probando() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JList list = new JList();
		list.setBounds(292, 102, 132, 149);
		frame.getContentPane().add(list);
		
		DefaultListModel dlm = new DefaultListModel();
		dlm.addElement("mauro");
		dlm.addElement("pepe");
		dlm.addElement("lautaro");
		list.setModel(dlm);
		
		JComboBox comboBox = new JComboBox();
		comboBox.setBounds(32, 52, 28, 25);
		frame.getContentPane().add(comboBox);
		
		comboBox.addItem("dasdas");
		comboBox.addItem("loco");
		
		JButton btnAgregar = new JButton("agregar");
		btnAgregar.setBounds(28, 157, 71, 23);
		btnAgregar.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				textField.setText((String) comboBox.getSelectedItem());
				textField_1.setText((String) list.getSelectedValue());
			}
		});
		frame.getContentPane().add(btnAgregar);
		
		textField = new JTextField();
		textField.setBounds(99, 29, 86, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.setBounds(248, 29, 86, 20);
		frame.getContentPane().add(textField_1);
		textField_1.setColumns(10);
		
		JLabel lblGente = new JLabel("gente");
		lblGente.setBounds(350, 82, 28, 14);
		frame.getContentPane().add(lblGente);
		
		textField_2 = new JTextField();
		textField_2.setBounds(141, 157, 86, 20);
		frame.getContentPane().add(textField_2);
		textField_2.setColumns(10);
		
		JList list_1 = new JList();
		list_1.setBounds(141, 243, 44, -35);
		frame.getContentPane().add(list_1);
	}
}

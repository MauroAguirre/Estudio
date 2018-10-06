package uy.edu.cei.observer;

//import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.SpringLayout;
import javax.swing.JTextPane;
import javax.swing.JTextField;
import java.awt.Color;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Cliente implements Observer{

	private JFrame frmVentana;
	private JTextField textField;
	private Observable observable;
	private JTextPane textPane;
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		
	}

	/**
	 * Create the application.
	 * @wbp.parser.entryPoint
	 */
	public Cliente() {
		initialize();
	}
	public Cliente(Observable observable) {
		this();//llama al constructor Cliente();
		this.observable = observable;
	}
	@Override
	public void notify(String message) {
		this.textPane.setText(this.textPane.getText()+message+"\n");
	}
	
	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmVentana = new JFrame();
		frmVentana.getContentPane().setBackground(Color.DARK_GRAY);
		frmVentana.setTitle("La vida de macdalena es una condena");
		frmVentana.setBounds(100, 100, 450, 300);
		frmVentana.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		SpringLayout springLayout = new SpringLayout();
		frmVentana.getContentPane().setLayout(springLayout);
		
		textPane = new JTextPane();
		springLayout.putConstraint(SpringLayout.NORTH, textPane, 22, SpringLayout.NORTH, frmVentana.getContentPane());
		springLayout.putConstraint(SpringLayout.WEST, textPane, 10, SpringLayout.WEST, frmVentana.getContentPane());
		springLayout.putConstraint(SpringLayout.EAST, textPane, -10, SpringLayout.EAST, frmVentana.getContentPane());
		textPane.setBackground(Color.WHITE);
		frmVentana.getContentPane().add(textPane);
		
		textField = new JTextField();
		springLayout.putConstraint(SpringLayout.WEST, textField, 9, SpringLayout.WEST, frmVentana.getContentPane());
		springLayout.putConstraint(SpringLayout.SOUTH, textField, -10, SpringLayout.SOUTH, frmVentana.getContentPane());
		textField.setBackground(Color.WHITE);
		frmVentana.getContentPane().add(textField);
		textField.setColumns(10);
		
		JButton btnNewButton = new JButton("Tocame");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				observable.sendMessage(textField.getText());
			}
		});
		springLayout.putConstraint(SpringLayout.SOUTH, btnNewButton, -8, SpringLayout.SOUTH, frmVentana.getContentPane());
		springLayout.putConstraint(SpringLayout.EAST, textField, -6, SpringLayout.WEST, btnNewButton);
		springLayout.putConstraint(SpringLayout.SOUTH, textPane, -17, SpringLayout.NORTH, btnNewButton);
		springLayout.putConstraint(SpringLayout.EAST, btnNewButton, 0, SpringLayout.EAST, textPane);
		frmVentana.getContentPane().add(btnNewButton);
		
		frmVentana.setVisible(true);
	}
}

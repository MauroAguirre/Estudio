package uy.edu.cei.observerdistribuido.client;

import java.awt.Color;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import java.awt.BorderLayout;
import javax.swing.JSplitPane;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import java.awt.GridLayout;
import javax.swing.SpringLayout;
import javax.swing.JTextField;
import javax.swing.JTextPane;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Game {

	private JFrame frame;
	private JTextField textField;
	private JTextPane textPane;
	/**
	 * Launch the application.
	 */
	/**
	 * Create the application.
	 */
	public Game() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {		
		frame = new JFrame();
		frame.getContentPane().setBackground(Color.DARK_GRAY);
		frame.setBounds(500,100, 500, 500);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		SpringLayout springLayout = new SpringLayout();
		frame.getContentPane().setLayout(springLayout);
		
		JButton btnTocadme = new JButton("Tocadme");
		btnTocadme.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				textPane.setText(textField.getText());
			}
		});
		springLayout.putConstraint(SpringLayout.SOUTH, btnTocadme, -10, SpringLayout.SOUTH, frame.getContentPane());
		springLayout.putConstraint(SpringLayout.EAST, btnTocadme, -10, SpringLayout.EAST, frame.getContentPane());
		frame.getContentPane().add(btnTocadme);
		
		textField = new JTextField();
		springLayout.putConstraint(SpringLayout.EAST, textField, -6, SpringLayout.WEST, btnTocadme);
		frame.getContentPane().add(textField);
		textField.setColumns(10);
		
		textPane = new JTextPane();
		springLayout.putConstraint(SpringLayout.NORTH, textField, 7, SpringLayout.SOUTH, textPane);
		springLayout.putConstraint(SpringLayout.WEST, textField, 0, SpringLayout.WEST, textPane);
		springLayout.putConstraint(SpringLayout.NORTH, textPane, 10, SpringLayout.NORTH, frame.getContentPane());
		springLayout.putConstraint(SpringLayout.WEST, textPane, 10, SpringLayout.WEST, frame.getContentPane());
		springLayout.putConstraint(SpringLayout.SOUTH, textPane, -6, SpringLayout.NORTH, btnTocadme);
		springLayout.putConstraint(SpringLayout.EAST, textPane, 0, SpringLayout.EAST, btnTocadme);
		frame.getContentPane().add(textPane);
		frame.setVisible(true);
		
		ImageIcon image = new ImageIcon("C:\\Users\\Mauro\\Pictures\\dedos.jpg");
        JLabel imageLabel = new JLabel(image); 
        frame.getContentPane().add(imageLabel);
        
        springLayout.putConstraint(SpringLayout.SOUTH, textPane, -6, SpringLayout.NORTH, imageLabel);
		springLayout.putConstraint(SpringLayout.EAST, textPane, 0, SpringLayout.EAST, imageLabel);
	}
}

package uy.edu.cei.generala.client.ui;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.SpringLayout;

import uy.edu.cei.generala.client.ui.panel.DicePanel;

import javax.swing.JPanel;
import java.awt.Color;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class TestDicePanel {

	private JFrame frame;
	private DicePanel dicePanel;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					TestDicePanel window = new TestDicePanel();
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
	public TestDicePanel() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		SpringLayout springLayout = new SpringLayout();
		frame.getContentPane().setLayout(springLayout);
		
		JPanel panel = new JPanel();
		springLayout.putConstraint(SpringLayout.NORTH, panel, 10, SpringLayout.NORTH, frame.getContentPane());
		springLayout.putConstraint(SpringLayout.WEST, panel, 10, SpringLayout.WEST, frame.getContentPane());
		springLayout.putConstraint(SpringLayout.SOUTH, panel, 268, SpringLayout.NORTH, frame.getContentPane());
		springLayout.putConstraint(SpringLayout.EAST, panel, 440, SpringLayout.WEST, frame.getContentPane());
		panel.setBackground(Color.ORANGE);
		frame.getContentPane().add(panel);
		SpringLayout sl_panel = new SpringLayout();
		panel.setLayout(sl_panel);
		
		dicePanel = new DicePanel();
		sl_panel.putConstraint(SpringLayout.NORTH, dicePanel, 121, SpringLayout.NORTH, panel);
		sl_panel.putConstraint(SpringLayout.WEST, dicePanel, 10, SpringLayout.WEST, panel);
		sl_panel.putConstraint(SpringLayout.SOUTH, dicePanel, -55, SpringLayout.SOUTH, panel);
		sl_panel.putConstraint(SpringLayout.EAST, dicePanel, 420, SpringLayout.WEST, panel);
		panel.add(dicePanel);
		
		JButton btnWiiiiii = new JButton("Wiiiiii!!!!!");
		btnWiiiiii.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				dicePanel.refreshDice();
			}
		});
		sl_panel.putConstraint(SpringLayout.NORTH, btnWiiiiii, 37, SpringLayout.NORTH, panel);
		sl_panel.putConstraint(SpringLayout.WEST, btnWiiiiii, 62, SpringLayout.WEST, panel);
		panel.add(btnWiiiiii);
	}
}

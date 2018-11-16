package uy.edu.cei.generala.client.ui.panel;

import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;

import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JPasswordField;
import javax.swing.JTextField;
import javax.swing.SpringLayout;

import uy.edu.cei.generala.client.App;
import uy.edu.cei.generala.client.EventQueueClient;
import uy.edu.cei.generala.common.client.Observer;
import uy.edu.cei.generala.common.notifications.GameNotification;
import uy.edu.cei.generala.common.notifications.GameNotificationType;
import uy.edu.cei.generala.common.server.controllers.UserController;
import uy.edu.cei.generala.domain.UserModel;

public class LoginPanel extends JPanel implements Observer {
	/**
	 * Default UID
	 */
	private static final long serialVersionUID = 1L;
	private JTextField userTextField;
	private JPasswordField passwordField;

	/**
	 * Create the panel.
	 */
	public LoginPanel() {
		setBackground(Color.ORANGE);
		SpringLayout springLayout = new SpringLayout();
		setLayout(springLayout);

		JLabel lblLogin = new JLabel("Login");
		lblLogin.setFont(new Font("Lucida Grande", Font.PLAIN, 24));
		springLayout.putConstraint(SpringLayout.NORTH, lblLogin, 10, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.WEST, lblLogin, 10, SpringLayout.WEST, this);
		add(lblLogin);

		JLabel lblNewLabel = new JLabel("Usuario");
		add(lblNewLabel);

		JLabel lblNewLabel_1 = new JLabel("Contraseña");
		springLayout.putConstraint(SpringLayout.NORTH, lblNewLabel_1, 33, SpringLayout.SOUTH, lblNewLabel);
		springLayout.putConstraint(SpringLayout.EAST, lblNewLabel_1, 0, SpringLayout.EAST, lblNewLabel);
		add(lblNewLabel_1);

		userTextField = new JTextField();
		springLayout.putConstraint(SpringLayout.WEST, userTextField, 107, SpringLayout.WEST, this);
		springLayout.putConstraint(SpringLayout.EAST, userTextField, -10, SpringLayout.EAST, this);
		springLayout.putConstraint(SpringLayout.NORTH, lblNewLabel, 5, SpringLayout.NORTH, userTextField);
		springLayout.putConstraint(SpringLayout.EAST, lblNewLabel, -9, SpringLayout.WEST, userTextField);
		springLayout.putConstraint(SpringLayout.NORTH, userTextField, 62, SpringLayout.NORTH, this);
		add(userTextField);
		userTextField.setColumns(10);

		JButton btnIngresar = new JButton("Ingresar");
		LoginPanel that = this;
		btnIngresar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String username = userTextField.getText();
					String password = new String(passwordField.getPassword());
					UserController uc = EventQueueClient.getInstance()
							.getServer()
							.getUserController();
					UserModel userModel = uc.login(username, password);
					if(userModel == null) {
						//JOptionPane.showMessageDialog(that, "Wiiii :), No Wiiii :(", "!Wiiiii", JOptionPane.INFORMATION_MESSAGE);
					} else {
						App.user = userModel;
						//JOptionPane.showMessageDialog(that, "Wiiii :)", "Wiiiii", JOptionPane.INFORMATION_MESSAGE);
					}
				} catch (RemoteException e1) {
					e1.printStackTrace();
				}
			}
		});
		springLayout.putConstraint(SpringLayout.SOUTH, btnIngresar, -10, SpringLayout.SOUTH, this);
		springLayout.putConstraint(SpringLayout.EAST, btnIngresar, -10, SpringLayout.EAST, this);
		add(btnIngresar);

		passwordField = new JPasswordField();
		springLayout.putConstraint(SpringLayout.NORTH, passwordField, -5, SpringLayout.NORTH, lblNewLabel_1);
		springLayout.putConstraint(SpringLayout.WEST, passwordField, 0, SpringLayout.WEST, userTextField);
		springLayout.putConstraint(SpringLayout.EAST, passwordField, 0, SpringLayout.EAST, userTextField);
		add(passwordField);
	}
	
	@Override
	public void update(GameNotification gameNotification) throws RemoteException {
		
	}
}

package uy.edu.cei.Obligatorio.Client.ui.Panel;

import javax.swing.JPanel;
import javax.swing.SpringLayout;

import uy.edu.cei.Obligatorio.Client.CommClientServer;
import uy.edu.cei.Obligatorio.Client.ui.MainWindow;
import uy.edu.cei.Obligatorio.Common.Controller.UsuarioController;
import uy.edu.cei.Obligatorio.Domain.UsuarioModel;

import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.rmi.RemoteException;
import javax.swing.JPasswordField;
import java.awt.Font;

public class LoginPanel extends JPanel {
	private JTextField txtUsuario;
	private JPasswordField pwdContra;
	private JTextField txtRespuesta;
	/**
	 * Create the panel.
	 */
	public LoginPanel() {
		setBackground(Color.GRAY);
		SpringLayout springLayout = new SpringLayout();
		setLayout(springLayout);
		
		JLabel lblLogin = new JLabel("Login");
		springLayout.putConstraint(SpringLayout.NORTH, lblLogin, 10, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.SOUTH, lblLogin, 41, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.EAST, lblLogin, 88, SpringLayout.WEST, this);
		lblLogin.setFont(new Font("Tahoma", Font.PLAIN, 14));
		springLayout.putConstraint(SpringLayout.WEST, lblLogin, 10, SpringLayout.WEST, this);
		add(lblLogin);
		
		JLabel lblUsuario = new JLabel("Usuario");
		springLayout.putConstraint(SpringLayout.SOUTH, lblUsuario, 82, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.NORTH, lblUsuario, 51, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.WEST, lblUsuario, 10, SpringLayout.WEST, this);
		springLayout.putConstraint(SpringLayout.EAST, lblUsuario, 88, SpringLayout.WEST, this);
		lblUsuario.setFont(new Font("Tahoma", Font.PLAIN, 14));
		add(lblUsuario);
		
		JLabel lblContrasea = new JLabel("Contraseña");
		springLayout.putConstraint(SpringLayout.NORTH, lblContrasea, 14, SpringLayout.SOUTH, lblUsuario);
		springLayout.putConstraint(SpringLayout.WEST, lblContrasea, 10, SpringLayout.WEST, this);
		springLayout.putConstraint(SpringLayout.SOUTH, lblContrasea, 43, SpringLayout.SOUTH, lblUsuario);
		springLayout.putConstraint(SpringLayout.EAST, lblContrasea, 88, SpringLayout.WEST, this);
		lblContrasea.setFont(new Font("Tahoma", Font.PLAIN, 14));
		add(lblContrasea);
		
		txtUsuario = new JTextField();
		springLayout.putConstraint(SpringLayout.NORTH, txtUsuario, 51, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.WEST, txtUsuario, 152, SpringLayout.WEST, this);
		springLayout.putConstraint(SpringLayout.SOUTH, txtUsuario, 82, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.EAST, txtUsuario, 440, SpringLayout.WEST, this);
		add(txtUsuario);
		txtUsuario.setColumns(10);
		
		pwdContra = new JPasswordField();
		springLayout.putConstraint(SpringLayout.EAST, pwdContra, 440, SpringLayout.WEST, this);
		springLayout.putConstraint(SpringLayout.SOUTH, pwdContra, 125, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.NORTH, pwdContra, 94, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.WEST, pwdContra, 152, SpringLayout.WEST, this);
		add(pwdContra);
		
		LoginPanel p = this;
		
		
		JButton btnLogear = new JButton("Logear");
		springLayout.putConstraint(SpringLayout.NORTH, btnLogear, 249, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.WEST, btnLogear, 10, SpringLayout.WEST, this);
		springLayout.putConstraint(SpringLayout.SOUTH, btnLogear, 290, SpringLayout.NORTH, this);
		springLayout.putConstraint(SpringLayout.EAST, btnLogear, 101, SpringLayout.WEST, this);
		btnLogear.setFont(new Font("Tahoma", Font.PLAIN, 14));
		add(btnLogear);
		btnLogear.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					String nombre = txtUsuario.getText();
					String contra= new String(pwdContra.getPassword());
					CommClientServer css = CommClientServer.Instancia();
					UsuarioController uci = css.GetServer().getUsuarioControllerImpl();
					UsuarioModel usuario = uci.VerificarUsuario(nombre,contra);
					if(usuario==null) {
						txtRespuesta.setText("Error en los datos del usuario");
						JOptionPane.showMessageDialog(p, "Error en los datos del usuario", "Error", 1);
					}
					else {
						txtRespuesta.setText("Encontrado");
						JOptionPane.showMessageDialog(p, "Encontrado", "Bien", 1);
					}
						
				} catch (Throwable e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}			
			}
		});
		
		JButton btnSalir = new JButton("Salir");
		springLayout.putConstraint(SpringLayout.WEST, btnSalir, -101, SpringLayout.EAST, this);
		springLayout.putConstraint(SpringLayout.EAST, btnSalir, -10, SpringLayout.EAST, this);
		btnSalir.setFont(new Font("Tahoma", Font.PLAIN, 14));
		add(btnSalir);
		
		JButton btnRegistrar = new JButton("Registrar");
		springLayout.putConstraint(SpringLayout.WEST, btnRegistrar, 173, SpringLayout.WEST, this);
		springLayout.putConstraint(SpringLayout.EAST, btnRegistrar, 264, SpringLayout.WEST, this);
		btnRegistrar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
			}
		});
		btnRegistrar.setFont(new Font("Tahoma", Font.PLAIN, 14));
		add(btnRegistrar);
		
		txtRespuesta = new JTextField();
		springLayout.putConstraint(SpringLayout.SOUTH, btnRegistrar, 128, SpringLayout.SOUTH, txtRespuesta);
		springLayout.putConstraint(SpringLayout.SOUTH, btnSalir, 128, SpringLayout.SOUTH, txtRespuesta);
		springLayout.putConstraint(SpringLayout.NORTH, btnRegistrar, 87, SpringLayout.SOUTH, txtRespuesta);
		springLayout.putConstraint(SpringLayout.NORTH, btnSalir, 87, SpringLayout.SOUTH, txtRespuesta);
		txtRespuesta.setEditable(false);
		springLayout.putConstraint(SpringLayout.NORTH, txtRespuesta, 6, SpringLayout.SOUTH, pwdContra);
		springLayout.putConstraint(SpringLayout.WEST, txtRespuesta, 0, SpringLayout.WEST, txtUsuario);
		springLayout.putConstraint(SpringLayout.SOUTH, txtRespuesta, 37, SpringLayout.SOUTH, pwdContra);
		springLayout.putConstraint(SpringLayout.EAST, txtRespuesta, 0, SpringLayout.EAST, txtUsuario);
		txtRespuesta.setColumns(10);
		add(txtRespuesta);
		btnSalir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					
				} catch (Throwable e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}	
			}
		});
	}
}

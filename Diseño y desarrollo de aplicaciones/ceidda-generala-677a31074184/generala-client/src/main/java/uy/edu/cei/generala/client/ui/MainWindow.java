package uy.edu.cei.generala.client.ui;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.JPanel;

import uy.edu.cei.generala.client.App;
import uy.edu.cei.generala.client.ui.panel.LoginPanel;
import uy.edu.cei.generala.client.ui.panel.TablePanel;
import uy.edu.cei.generala.common.client.Observer;
import uy.edu.cei.generala.common.notifications.GameNotification;
import uy.edu.cei.generala.common.notifications.GameNotificationType;

public class MainWindow implements Observer {

	private JFrame frame;
	private JPanel currentPanel;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainWindow window = new MainWindow();
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
	public MainWindow() {
		initialize();
	}
	
	public void changePanel(JPanel panel) {
		if(this.currentPanel != null) {
			 this.frame.remove(this.currentPanel);
		}
		this.currentPanel = panel;
		this.frame.add(panel);
		this.frame.setVisible(true);
	}

	@Override
	public void update(GameNotification notification) {
		if(notification.getType() == GameNotificationType.LOGIN &&
				notification.getTargetUser().equals(App.user)) {
			new Thread(new Runnable() {
				
				@Override
				public void run() {
					try {
						Thread.sleep(100);
					} catch (InterruptedException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
					JPanel tablePanel = new TablePanel();
					changePanel(tablePanel);
				}
			}).start();
			
		}
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

	public JFrame getFrame() {
		return frame;
	}

}

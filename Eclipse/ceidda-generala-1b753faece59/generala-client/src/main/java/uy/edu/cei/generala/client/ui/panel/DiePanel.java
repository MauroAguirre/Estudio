package uy.edu.cei.generala.client.ui.panel;

import java.awt.Color;
import java.awt.Graphics;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.net.URL;

import javax.imageio.ImageIO;
import javax.swing.JPanel;

public class DiePanel extends JPanel {

	private BufferedImage image;
	private int value = 1;

	/**
	 * Create the panel.
	 */
	public DiePanel() {
		setBackground(Color.RED);
		setLayout(null);
		try {
			URL url = DiePanel.class.getResource("/assets/dice-sprite.jpg");
			image = ImageIO.read(url);
		} catch (IOException ex) {
			ex.printStackTrace();
		}
	}

	public void setValue(int value) {
		this.value = value - 1;
		this.repaint();
	}

	@Override
	protected void paintComponent(Graphics g) {
		super.paintComponent(g);
		Integer value = -63 * this.value;
		g.drawImage(image, value, 0, this);
	}

}

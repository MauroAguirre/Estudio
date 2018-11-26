package uy.edu.cei.generala.client.ui.panel;

import java.awt.Color;
import java.util.Random;

import javax.swing.JPanel;

public class DicePanel extends JPanel {
	private DiePanel diePanel_5;
	private DiePanel diePanel_4;
	private DiePanel diePanel_3;
	private DiePanel diePanel_2;
	private DiePanel diePanel_1;

	/**
	 * Create the panel.
	 */
	public DicePanel() {
		setBackground(Color.CYAN);
		setLayout(null);
		
		diePanel_1 = new DiePanel();
		diePanel_1.setBounds(6, 6, 63, 63);
		add(diePanel_1);
		
		diePanel_2 = new DiePanel();
		diePanel_2.setBounds(81, 6, 63, 63);
		add(diePanel_2);
		
		diePanel_3 = new DiePanel();
		diePanel_3.setBounds(156, 6, 63, 63);
		add(diePanel_3);
		
		diePanel_4 = new DiePanel();
		diePanel_4.setBounds(231, 6, 63, 63);
		add(diePanel_4);
		
		diePanel_5 = new DiePanel();
		diePanel_5.setBounds(306, 6, 63, 63);
		add(diePanel_5);
		
	}
	
	public void refreshDice() {
		diePanel_1.setValue(generateRandom());
		diePanel_2.setValue(generateRandom());
		diePanel_3.setValue(generateRandom());
		diePanel_4.setValue(generateRandom());
		diePanel_5.setValue(generateRandom());
	}
	
	private Integer generateRandom() {
		Random r = new Random();
		return r.nextInt((6 - 1) + 1) + 1;
	}
}

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JButton;
import javax.swing.JTextField;
import javax.swing.JLabel;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class PersonalCont extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField tbFname;
	private JTextField tbLname;
	private JTextField tbTel;
	private JTextField tbEmail;
	private JTextField tbAddr;
	private JTextField tbCity;
	private JTextField tbPostcode;
	private JButton btnDeleteSelected;
	private JButton btnSaveSelected;
	private JButton btnSaveNew;
	private JButton btnAddNew;
	private JButton btnUpdateSelected;
	private JTextField tbDepart;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PersonalCont frame = new PersonalCont();
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
	public PersonalCont() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 852, 528);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(50, 144, 746, 323);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {
				tbFname.setText(table.getValueAt(table.getSelectedRow(), 1).toString());
				tbLname.setText(table.getValueAt(table.getSelectedRow(), 2).toString());
				tbDepart.setText(table.getValueAt(table.getSelectedRow(), 3).toString());
				tbTel.setText(table.getValueAt(table.getSelectedRow(), 4).toString());
				tbEmail.setText(table.getValueAt(table.getSelectedRow(), 5).toString());
				tbAddr.setText(table.getValueAt(table.getSelectedRow(), 6).toString());
				tbCity.setText(table.getValueAt(table.getSelectedRow(), 7).toString());
				tbPostcode.setText(table.getValueAt(table.getSelectedRow(), 8).toString());
			}
		});
		scrollPane.setViewportView(table);
		dbConn d = new dbConn();
		JButton btnRefresh = new JButton("Refresh");
		btnRefresh.setBounds(719, 103, 97, 19);
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
			}
		});
		
		tbFname = new JTextField();
		tbFname.setBounds(105, 26, 66, 17);
		tbFname.setColumns(10);
		
		tbLname = new JTextField();
		tbLname.setBounds(105, 66, 66, 17);
		tbLname.setColumns(10);
		
		tbDepart = new JTextField();
		tbDepart.setBounds(105, 104, 66, 17);
		tbDepart.setColumns(10);
		
		tbTel = new JTextField();
		tbTel.setBounds(275, 26, 66, 17);
		tbTel.setColumns(10);
		
		tbEmail = new JTextField();
		tbEmail.setBounds(275, 66, 66, 17);
		tbEmail.setColumns(10);
		
		tbAddr = new JTextField();
		tbAddr.setBounds(275, 104, 66, 17);
		tbAddr.setColumns(10);
		
		tbCity = new JTextField();
		tbCity.setBounds(426, 26, 66, 17);
		tbCity.setColumns(10);
		
		tbPostcode = new JTextField();
		tbPostcode.setBounds(426, 66, 66, 17);
		tbPostcode.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("First Name");
		lblNewLabel.setBounds(25, 29, 72, 11);
		
		JLabel lblNewLabel_1 = new JLabel("Last Name");
		lblNewLabel_1.setBounds(25, 69, 72, 11);
		
		JLabel lblNewLabel_2 = new JLabel("Department");
		lblNewLabel_2.setBounds(25, 107, 72, 15);
		
		JLabel lblNewLabel_3 = new JLabel("Telephone No.");
		lblNewLabel_3.setBounds(179, 29, 88, 14);
		
		JLabel lblNewLabel_4 = new JLabel("Email");
		lblNewLabel_4.setBounds(179, 69, 63, 11);
		
		JLabel lblNewLabel_5 = new JLabel("Address");
		lblNewLabel_5.setBounds(179, 107, 63, 11);
		
		JLabel lblNewLabel_6 = new JLabel("City");
		lblNewLabel_6.setBounds(364, 29, 37, 11);
		
		JLabel lblNewLabel_7 = new JLabel("Post Code");
		lblNewLabel_7.setBounds(350, 69, 68, 11);
		
		btnDeleteSelected = new JButton("Delete Selected");
		btnDeleteSelected.setBounds(551, 103, 135, 19);
		
		btnSaveSelected = new JButton("Save Selected");
		
		btnSaveSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				String f = tbFname.getText();
				String l = tbLname.getText();
				String dp = tbDepart.getText();
				String t = tbTel.getText();
				String em = tbEmail.getText();
				String a = tbAddr.getText();
				String c = tbCity.getText();
				String p = tbPostcode.getText();
				String id = table.getValueAt(table.getSelectedRow(), 0).toString();
				d.UpdatePersonal(f, l, dp, t, em, a, c, p, id);
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
			}
		});
		btnSaveSelected.setEnabled(false);
		btnSaveSelected.setBounds(551, 65, 135, 19);
		
		btnSaveNew = new JButton("Save New");
		btnSaveNew.setEnabled(false);
		btnSaveNew.setBounds(719, 65, 97, 19);
		
		btnAddNew = new JButton("Add New");
		btnAddNew.setBounds(719, 25, 97, 19);
		
		btnUpdateSelected = new JButton("Update Selected");
		btnUpdateSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				btnUpdateSelected.setEnabled(false);
				btnAddNew.setEnabled(false);
				btnSaveNew.setEnabled(false);
				btnDeleteSelected.setEnabled(false);
				btnSaveSelected.setEnabled(true);
			}
		});
		btnUpdateSelected.setBounds(551, 25, 135, 19);
		contentPane.setLayout(null);
		contentPane.add(scrollPane);
		contentPane.add(btnRefresh);
		contentPane.add(tbFname);
		contentPane.add(tbLname);
		contentPane.add(tbDepart);
		contentPane.add(tbTel);
		contentPane.add(tbEmail);
		contentPane.add(tbAddr);
		contentPane.add(tbCity);
		contentPane.add(tbPostcode);
		contentPane.add(lblNewLabel);
		contentPane.add(lblNewLabel_1);
		contentPane.add(lblNewLabel_2);
		contentPane.add(lblNewLabel_3);
		contentPane.add(lblNewLabel_4);
		contentPane.add(lblNewLabel_5);
		contentPane.add(lblNewLabel_6);
		contentPane.add(lblNewLabel_7);
		contentPane.add(btnDeleteSelected);
		contentPane.add(btnSaveSelected);
		contentPane.add(btnSaveNew);
		contentPane.add(btnAddNew);
		contentPane.add(btnUpdateSelected);
	}
}

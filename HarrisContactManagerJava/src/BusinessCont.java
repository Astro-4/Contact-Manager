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

public class BusinessCont extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField tbFname;
	private JTextField tbLname;
	private JTextField tbComp;
	private JTextField tbPosition;
	private JTextField tbTel;
	private JTextField tbEmail;
	private JTextField tbAddr;
	private JTextField tbCity;
	private JTextField tbPostcode;
	private JButton btnDeleteSelected;
	private JButton btnSaveSelected;
	private JButton btnUpdateSelected;
	private JButton btnAddNew;
	private JButton btnSaveNew;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BusinessCont frame = new BusinessCont();
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
	public BusinessCont() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 856, 527);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(36, 154, 770, 296);
		contentPane.add(scrollPane);
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {
				tbFname.setText(table.getValueAt(table.getSelectedRow(), 1).toString());
				tbLname.setText(table.getValueAt(table.getSelectedRow(), 2).toString());
				tbComp.setText(table.getValueAt(table.getSelectedRow(), 3).toString());
				tbPosition.setText(table.getValueAt(table.getSelectedRow(), 4).toString());
				tbTel.setText(table.getValueAt(table.getSelectedRow(), 5).toString());
				tbEmail.setText(table.getValueAt(table.getSelectedRow(), 6).toString());
				tbAddr.setText(table.getValueAt(table.getSelectedRow(), 7).toString());
				tbCity.setText(table.getValueAt(table.getSelectedRow(), 8).toString());
				tbPostcode.setText(table.getValueAt(table.getSelectedRow(), 9).toString());
			}
			
		});
		scrollPane.setViewportView(table);
		
		JButton btnRefresh = new JButton("Refresh");
		dbConn d = new dbConn();
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
			}
		});
		btnRefresh.setBounds(727, 120, 107, 19);
		contentPane.add(btnRefresh);
		
		tbFname = new JTextField();
		tbFname.setBounds(103, 33, 66, 17);
		contentPane.add(tbFname);
		tbFname.setColumns(10);
		
		tbLname = new JTextField();
		tbLname.setBounds(103, 69, 66, 17);
		contentPane.add(tbLname);
		tbLname.setColumns(10);
		
		tbComp = new JTextField();
		tbComp.setBounds(103, 107, 66, 17);
		contentPane.add(tbComp);
		tbComp.setColumns(10);
		
		tbPosition = new JTextField();
		tbPosition.setBounds(281, 33, 66, 17);
		contentPane.add(tbPosition);
		tbPosition.setColumns(10);
		
		tbTel = new JTextField();
		tbTel.setBounds(281, 69, 66, 17);
		contentPane.add(tbTel);
		tbTel.setColumns(10);
		
		tbEmail = new JTextField();
		tbEmail.setBounds(281, 107, 66, 17);
		contentPane.add(tbEmail);
		tbEmail.setColumns(10);
		
		tbAddr = new JTextField();
		tbAddr.setBounds(486, 33, 66, 17);
		contentPane.add(tbAddr);
		tbAddr.setColumns(10);
		
		tbCity = new JTextField();
		tbCity.setBounds(486, 69, 66, 17);
		contentPane.add(tbCity);
		tbCity.setColumns(10);
		
		tbPostcode = new JTextField();
		tbPostcode.setBounds(486, 107, 66, 17);
		contentPane.add(tbPostcode);
		tbPostcode.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("First Name");
		lblNewLabel.setBounds(20, 36, 66, 17);
		contentPane.add(lblNewLabel);
		
		JLabel lblNewLabel_1 = new JLabel("Last Name");
		lblNewLabel_1.setBounds(20, 72, 66, 14);
		contentPane.add(lblNewLabel_1);
		
		JLabel lblNewLabel_2 = new JLabel("Company");
		lblNewLabel_2.setBounds(20, 110, 66, 14);
		contentPane.add(lblNewLabel_2);
		
		JLabel lblNewLabel_3 = new JLabel("Position");
		lblNewLabel_3.setBounds(188, 36, 62, 11);
		contentPane.add(lblNewLabel_3);
		
		JLabel lblNewLabel_4 = new JLabel("Telephone No.");
		lblNewLabel_4.setBounds(188, 72, 85, 11);
		contentPane.add(lblNewLabel_4);
		
		JLabel lblNewLabel_5 = new JLabel("Email");
		lblNewLabel_5.setBounds(188, 110, 62, 11);
		contentPane.add(lblNewLabel_5);
		
		JLabel lblNewLabel_6 = new JLabel("Address");
		lblNewLabel_6.setBounds(387, 36, 62, 11);
		contentPane.add(lblNewLabel_6);
		
		JLabel lblNewLabel_7 = new JLabel("City");
		lblNewLabel_7.setBounds(387, 72, 62, 11);
		contentPane.add(lblNewLabel_7);
		
		JLabel lblNewLabel_8 = new JLabel("Post Code");
		lblNewLabel_8.setBounds(387, 110, 77, 11);
		contentPane.add(lblNewLabel_8);
		
		btnDeleteSelected = new JButton("Delete Selected");
		btnDeleteSelected.setBounds(571, 120, 131, 19);
		contentPane.add(btnDeleteSelected);
		
		btnSaveSelected = new JButton("Save Selected");
		btnSaveSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				String f = tbFname.getText();
				String l = tbLname.getText();
				String cn = tbComp.getText();
				String pos = tbPosition.getText();
				String t = tbTel.getText();
				String em = tbEmail.getText();
				String a = tbAddr.getText();
				String c = tbCity.getText();
				String p = tbPostcode.getText();
				String id = table.getValueAt(table.getSelectedRow(), 0).toString();
				d.UpdateBusiness(f, l, cn, pos, t, em, a, c, p, id);
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
			}
		});
		btnSaveSelected.setEnabled(false);
		btnSaveSelected.setBounds(571, 79, 131, 19);
		contentPane.add(btnSaveSelected);
		
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
		btnUpdateSelected.setBounds(571, 33, 131, 19);
		contentPane.add(btnUpdateSelected);
		
		btnAddNew = new JButton("Add New");
		btnAddNew.setBounds(727, 32, 107, 19);
		contentPane.add(btnAddNew);
		
		btnSaveNew = new JButton("Save New");
		btnSaveNew.setEnabled(false);
		btnSaveNew.setBounds(729, 79, 105, 19);
		contentPane.add(btnSaveNew);
	}

}

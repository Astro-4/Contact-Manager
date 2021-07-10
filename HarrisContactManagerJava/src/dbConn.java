import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.*;

public class dbConn {
	
	String connString = "jdbc:mysql://harrisdb.ceadcjzmmv4p.us-east-1.rds.amazonaws.com/HarrisContactDB";
	String username = "admin";
	String password = "509password";
	Connection con = null;
	
	public dbConn() {
		try {
			con = DriverManager.getConnection(connString,username,password);
			System.out.println("Connected");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Connection Failed");
		}
	}
	
	public ResultSet GetAllPersonal() {
		
		ResultSet rs = null;
		String sql = "{call selectAllPersonal()}";
		try {
			CallableStatement cst = con.prepareCall(sql);
			rs = cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return rs;
		
	}
	
	public ResultSet GetAllBusiness() {
			
			ResultSet rs = null;
			String sql = "{call selectAllBusiness()}";
			try {
				CallableStatement cst = con.prepareCall(sql);
				rs = cst.executeQuery();
			} catch (SQLException e) {
				e.printStackTrace();
			}
			return rs;
		
	}
	
	public void UpdatePersonal(String f,String l,String dp,String t,String em,String a,String c,String p, String id) {
		
		ResultSet rs = null;
		String sql = "{call updatePersonal(?,?,?,?,?,?,?,?,?)}";
		try {
			CallableStatement cst = con.prepareCall(sql);
			cst.setString(1,id);
			cst.setString(2,f);
			cst.setString(3,l);
			cst.setString(4,dp);
			cst.setString(5,t);
			cst.setString(6,em);
			cst.setString(7,a);
			cst.setString(8,c);
			cst.setString(9,p);
			rs = cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	
	}
	
	public void UpdateBusiness(String f,String l,String cn,String pos,String t,String em,String a,String c,String p, String id) {
		
		ResultSet rs = null;
		String sql = "{call updateBusiness()}";
		try {
			CallableStatement cst = con.prepareCall(sql);
			cst.setString(1,id);
			cst.setString(2,f);
			cst.setString(3,l);
			cst.setString(4,cn);
			cst.setString(5,pos);
			cst.setString(6,t);
			cst.setString(7,em);
			cst.setString(8,a);
			cst.setString(9,c);
			cst.setString(10,p);
			rs = cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
}

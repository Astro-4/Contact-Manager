using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    public class DbConn
    {
        private string connString = "Server=harrisdb.ceadcjzmmv4p.us-east-1.rds.amazonaws.com;User ID=admin;Password=509password;Database=HarrisContactDB";

        public DataTable GetAllPersonal() {
            using (var conn = new SqlConnection(connString)) {
                conn.Open();
                DataTable personalContactDt = new DataTable();
                List<PersonalContact> personalContacts = new List<PersonalContact>();
                using (var cmd = new SqlCommand("Call selectAllPersonal();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read()) {
                        personalContacts.Add(new PersonalContact { 
                            ContactID = reader.GetInt32(0),
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            PersonalTel = reader.GetString(4)
                        });
                    }
                personalContactDt.Columns.Add("ContactID");
                personalContactDt.Columns.Add("ContactFname");
                personalContactDt.Columns.Add("ContactLname");
                personalContactDt.Columns.Add("ContactEmail");
                personalContactDt.Columns.Add("PersonalTel");

                foreach (var item in personalContacts) {
                    var row = personalContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFname"] = item.ContactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["ContactEmail"] = item.ContactEmail;
                    row["PersonalTel"] = item.PersonalTel;

                    personalContactDt.Rows.Add(row);
                }
                return personalContactDt;
            }
        }
        public void InsertPersonal(PersonalContact personalContact)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new SqlCommand()) {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4);";
                    cmd.Parameters.AddWithValue("p1",personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p4", personalContact.PersonalTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdatePersonal(PersonalContact personalContact)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1,@p2,@p3,@p4,@p5);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.PersonalTel);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeletePersonal(int id)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    public class DbConn
    {
        private string connString = "Server=harrisdb.ceadcjzmmv4p.us-east-1.rds.amazonaws.com;User ID=admin;Password=509password;Database=HarrisContactDB";

        public DataTable GetAllPersonal() {
            using (var conn = new MySqlConnection(connString)) {
                conn.Open();
                DataTable personalContactDt = new DataTable();
                List<PersonalContact> personalContacts = new List<PersonalContact>();
                using (var cmd = new MySqlCommand("Call selectAllPersonal();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read()) {
                        personalContacts.Add(new PersonalContact { 
                            ContactID = reader.GetInt32(0),
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactDepartment = reader.GetString(3),
                            PersonalTel = reader.GetString(4),
                            ContactEmail = reader.GetString(5),                      
                            ContactAddr = reader.GetString(6),
                            ContactCity = reader.GetString(7),
                            ContactPostcode = reader.GetString(8)
                        });
                    }
                personalContactDt.Columns.Add("ContactID");
                personalContactDt.Columns.Add("ContactFname");
                personalContactDt.Columns.Add("ContactLname");
                personalContactDt.Columns.Add("ContactDepartment"); 
                personalContactDt.Columns.Add("PersonalTel");
                personalContactDt.Columns.Add("ContactEmail");
                personalContactDt.Columns.Add("ContactAddr");
                personalContactDt.Columns.Add("ContactCity");
                personalContactDt.Columns.Add("ContactPostcode");

                foreach (var item in personalContacts) {
                    var row = personalContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFname"] = item.ContactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["ContactDepartment"] = item.ContactDepartment;
                    row["PersonalTel"] = item.PersonalTel;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddr"] = item.ContactAddr;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostCode"] = item.ContactPostcode;

                    personalContactDt.Rows.Add(row);
                }
                return personalContactDt;
            }
        }
        
        public DataTable GetAllBusiness() {
            using (var conn = new MySqlConnection(connString)) {
                conn.Open();
                DataTable businessContactDt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var cmd = new MySqlCommand("Call selectAllBusiness();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read()) {
                        businessContacts.Add(new BusinessContact {
                            ContactID = reader.GetInt32(0),
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactCompany = reader.GetString(3),
                            ContactPosition = reader.GetString(4),
                            BusinessTel = reader.GetString(5),
                            ContactEmail = reader.GetString(6),
                            ContactAddr = reader.GetString(7),
                            ContactCity = reader.GetString(8),
                            ContactPostcode = reader.GetString(9)
                        });
                    }
                businessContactDt.Columns.Add("ContactID");
                businessContactDt.Columns.Add("ContactFname");
                businessContactDt.Columns.Add("ContactLname");
                businessContactDt.Columns.Add("ContactCompany");
                businessContactDt.Columns.Add("ContactPosition");
                businessContactDt.Columns.Add("BusinessTel");
                businessContactDt.Columns.Add("ContactEmail");
                businessContactDt.Columns.Add("ContactAddr");
                businessContactDt.Columns.Add("ContactCity");
                businessContactDt.Columns.Add("ContactPostcode");

                foreach (var item in businessContacts) {
                    var row = businessContactDt.NewRow();

                    row["ContactID"] = item.ContactID;
                    row["ContactFname"] = item.ContactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["ContactCompany"] = item.ContactCompany;
                    row["ContactPosition"] = item.ContactPosition;
                    row["BusinessTel"] = item.BusinessTel;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddr"] = item.ContactAddr;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;

                    businessContactDt.Rows.Add(row);
                }
                return businessContactDt;
            }
        }
        
        public async void InsertPersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand()) {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactDepartment);
                    cmd.Parameters.AddWithValue("p4", personalContact.PersonalTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        public async void InsertBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand()) {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactFname);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactCompany);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactPosition);
                    cmd.Parameters.AddWithValue("p5", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactAddr);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactPostcode);

                     await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        public async void UpdatePersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactDepartment);
                    cmd.Parameters.AddWithValue("p5", personalContact.PersonalTel);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactAddr);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        public async void UpdateBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updateBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactCompany);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactPosition);
                    cmd.Parameters.AddWithValue("p6", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactAddr);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p10", businessContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        public async void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
        public async void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deleteBusiness(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
    }
}

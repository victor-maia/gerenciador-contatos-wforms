using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Econtact.ContactModel;
using Econtact.DataBaseContext;

namespace Econtact
{
    public class DALContacts
    {


        public static void CreateSqliteDB()
        {
            try
            {
                if (!File.Exists(dbContext.path))
                {
                    SQLiteConnection.CreateFile(dbContext.path);
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro");
            }
        }

        public static void CreateSqliteTable()
        {
            try
            {
                using (var cmd = dbContext.DbConnection().CreateCommand())
                {
                    cmd.CommandText =
                       "CREATE TABLE IF NOT EXISTS \"tbl_contacts\" (" +
                       "\"Contact_ID\" INTEGER PRIMARY KEY AUTOINCREMENT, " +
                       "\"First_Name\" TEXT, " +
                       "\"Last_Name\" TEXT, " +
                       "\"ContactNo\" TEXT, " +
                       "\"Address\" TEXT, " +
                       "\"Gender\" TEXT)";

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                {
                    throw new Exception("Erro");
                }
            }
        }

        public static DataTable GetAllContacts()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = dbContext.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tbl_contacts";
                    da = new SQLiteDataAdapter(cmd.CommandText, dbContext.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                throw new Exception("Erro");
            }
        }

        public static void Add(Contact contact)
        {
            try
            {
                using (var cmd = dbContext.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO tbl_contacts (First_Name, Last_Name, ContactNo, Address, Gender) " +
                        "VALUES (@firstname, @lastname, @contactno, @address, @gender);";
                    cmd.Parameters.AddWithValue("@firstname", contact.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", contact.LastName);
                    cmd.Parameters.AddWithValue("@contactno", contact.ContactNo);
                    cmd.Parameters.AddWithValue("@address", contact.Address);
                    cmd.Parameters.AddWithValue("@gender", contact.Gender);
                    cmd.ExecuteNonQuery();
                }
            }

            catch
            {
                throw new Exception("Error");
            }
        }

        public static void Update(Contact contact)
        {
            using (var cmd = dbContext.DbConnection().CreateCommand())
            {
                try
                {

                    cmd.CommandText = "UPDATE tbl_contacts SET First_Name=@firstname,Last_Name=@lastname, ContactNo=@contactno, Address=@address, Gender=@gender WHERE Contact_Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", contact.ContactID);
                    cmd.Parameters.AddWithValue("@firstname", contact.FirstName);
                    cmd.Parameters.AddWithValue("@lastname", contact.LastName);
                    cmd.Parameters.AddWithValue("@contactno", contact.ContactNo);
                    cmd.Parameters.AddWithValue("@address", contact.Address);
                    cmd.Parameters.AddWithValue("@gender", contact.Gender);
                    cmd.ExecuteNonQuery();

                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var cmd = dbContext.DbConnection().CreateCommand())
            {
                try
                {
                    cmd.CommandText = "DELETE from tbl_contacts where Contact_ID=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

      


        public static DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            using (var connection = dbContext.DbConnection())
            {
                using (var cmd = connection.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = @"SELECT * FROM tbl_contacts 
                                    WHERE First_Name LIKE @keyword 
                                    OR Last_Name LIKE @keyword 
                                    OR Address LIKE @keyword 
                                    OR ContactNo LIKE @keyword";

                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erro ao realizar a pesquisa: " + ex.Message);
                    }
                }
            }

            return dt;
        }
    }
}
using System.Data.SQLite;

namespace Econtact.DataBaseContext
{
    public static class dbContext
    {
        public static string path = Directory.GetCurrentDirectory() + "\\contact.db";

        public static SQLiteConnection sqliteConnection;

        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + path);
            sqliteConnection.Open();
            return sqliteConnection;
        }
    }
}

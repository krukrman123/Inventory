using System.Data.SQLite;

namespace Inventory.Class
{
    public static class DatabaseInitializer
    {
        private static string connectionString = $@"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.db")};Version=3;";

        public static void Initialize()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS UserTbl (
                    Uname TEXT NOT NULL,
                    Ufullname TEXT NOT NULL,
                    Upassword TEXT,
                    Uphone TEXT NOT NULL PRIMARY KEY,
                    UserRole TEXT NOT NULL DEFAULT 'User' -- Adding UserRole column with default value 'User'
                );
                
                CREATE TABLE IF NOT EXISTS ""Table"" (
                    Id INTEGER NOT NULL PRIMARY KEY
                );

                CREATE TABLE IF NOT EXISTS ProductTbl (
                    ProdId INTEGER NOT NULL PRIMARY KEY,
                    ProdName TEXT NOT NULL,
                    ProdQty INTEGER NOT NULL,
                    ProdPrice INTEGER NOT NULL,
                    ProdDesc TEXT NOT NULL,
                    ProdCat TEXT NOT NULL,
                    ProdFile TEXT NOT NULL,
                    ProdText TEXT NOT NULL,
                    ProdImage BLOB
                );

                CREATE TABLE IF NOT EXISTS OrderTbl (
                    OrderId INTEGER NOT NULL PRIMARY KEY,
                    CustId INTEGER NOT NULL,
                    CustName TEXT NOT NULL,
                    OrderDate TEXT NOT NULL,
                    TotalAmt INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS CustomerTbl (
                    CustId INTEGER NOT NULL PRIMARY KEY,
                    CustName TEXT NOT NULL,
                    CustPhone TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS CategoryTbl (
                    CatId INTEGER NOT NULL PRIMARY KEY,
                    CatName TEXT NOT NULL
                );";

                using (SQLiteCommand command = new SQLiteCommand(createTablesQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

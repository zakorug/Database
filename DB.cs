using System;
using System.Data;
using System.Data.SQLite;

namespace Database
{
    class DB
    {
        SQLiteConnection Db = new SQLiteConnection();

        public static ConnectionState State { get; private set; }

        public void openConnection()
        {
            if (Db.State == System.Data.ConnectionState.Closed)
                Db.Open();
        }

       

        public void closeConnection()
        {
            if (Db.State == System.Data.ConnectionState.Open)
                Db.Close();
        }

        public SQLiteConnection getConnection()
        {
            return Db;
        }
    }
}

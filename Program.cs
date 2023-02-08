//if you getting this error --> 'You need to call SQLitePCL.raw.SetProvider().  If you are using a bundle package, this is done by calling SQLitePCL.Batteries.Init().'
//so just download EntityFrameworkCore.Sqlite
using Microsoft.Data.Sqlite;
using System.Data;

namespace demo
{
    class Demo1
    {
        public static void Main(String[] args)
        {
            method1();
        }

        static void method1()
        {
            SqliteConnection conn = new SqliteConnection("Data Source=test.db");
            try
            {
                conn.Open();
                if(conn.State==ConnectionState.Open)
                {
                    Console.WriteLine("Connected !");
                    conn.Close();
                }
            }
            catch(SqliteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
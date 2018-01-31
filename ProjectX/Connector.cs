using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX
{
    public class Connector
    {
       
       
        SQLiteConnection sQLiteConnection = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "DB.db")));
           
        public  bool OpenConnection()
        {
            try
            {
                sQLiteConnection.Open();
                Console.WriteLine("Połączono !!!!!");
                return true;
            }
            catch
            {
                MessageBox.Show("Problem z połaczeniem");
                sQLiteConnection.Close();
                Console.WriteLine("Wtopa !!!!");
                return false;

   
            }
            
        }
        public bool CloseConnection()
        {
            try
            {
                sQLiteConnection.Close();
                Console.WriteLine("Zamkniete polaczenie");
                return true;

            }
            catch
            {
                MessageBox.Show("Problem z zamknieciem polaczenia");
                return false;
            }
            
        }

    }
    
}

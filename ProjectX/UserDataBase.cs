using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ProjectX
{
    public partial class UserDataBase : UserControl  
    {

        SQLiteCommand command = new SQLiteCommand();
        string SqlQuery = "";
        public UserDataBase()
        {
            InitializeComponent();

        }

        Connector connector = new Connector();
        SQLiteConnection sQLiteConnection = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "DB.db")));


        private void UserDataBase_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            sQLiteConnection.Open();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',symbol as 'Symbol',dlugosc as'Dł(cm)',wysokosc as'Wys.(cm)',wagaA as 'Waga(Kg/1 szt.)',wagaB as'Waga(Kg/m²)',powierzchnia as'Powierzchnia Płt (m²)',cenazam as'Cena za m²(PLN)' FROM tabelaA", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.RowTemplate.Height = 20;








        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

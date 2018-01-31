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
    public partial class UserControl1 : UserControl
    {
        int operation = 0;
        Connector connector = new Connector();
        SQLiteConnection sQLiteConnection = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "DB.db")));




        public UserControl1()
        {
            InitializeComponent();
            comboBunifuData.AddItem("Ruszta betonowe dla trzody (Szer. 45,4cm Szcz. 17mm Pow. Stąpania 80mm");
            comboBunifuData.AddItem("Ruszta betonowe dla trzody (Szer. 44cm Szcz. 18mm Pow. Stąpania 92mm");
            comboBunifuData.AddItem("Ruszta betonowe dla loszek,loch i knurów (Szer. 52cm Szcz. 20mm Pow. Stąpania 84mm");
            comboBunifuData.AddItem("Belki żelbetonowe - Podciągi dla betonowych podłóg rusztowych dla trzody");


            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 60, 218);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.FromArgb(37, 46, 59);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            zlSztTx.Enabled = false;
            zlMbTx.Enabled = false;
            wagaCTx.Enabled = false;
            szerokoscTx.Enabled = false;




        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        public void ShowDataA()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',symbol as 'Symbol                    ',dlugosc as'Długość         (cm)',wysokosc as'Wysokość     (cm)',wagaA as 'Waga        (Kg/1 szt.)',wagaB as'Waga         (Kg/m²)',powierzchnia as'Powierzchnia Płt (m²)',cenazam as'Cena za m²(PLN)' FROM tabelaA", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connector.CloseConnection();

        }
        public void ShowDataB()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',symbol as 'Symbol                    ',dlugosc as'Długość         (cm)',wysokosc as'Wysokość     (cm)',wagaA as 'Waga        (Kg/1 szt.)',wagaB as'Waga         (Kg/m²)',powierzchnia as'Powierzchnia Płt (m²)',cenazam as'Cena za m²(PLN)' FROM tabelaB", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connector.CloseConnection();

        }
        public void ShowDataC()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',symbol as 'Symbol                    ',dlugosc as'Długość         (cm)',wysokosc as'Wysokość     (cm)',wagaA as 'Waga        (Kg/1 szt.)',wagaB as'Waga         (Kg/m²)',powierzchnia as'Powierzchnia Płt (m²)',cenazam as'Cena za m²(PLN)' FROM tabelaC", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connector.CloseConnection();
        }
        public void ShowDataD()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',dlugosc as'Długość         (cm)',szerokosc as'Szerokość     (cm)',wysokosc as'Wysokość     (cm)',waga as 'Waga        (Kg/1 szt.)',cenaa as'Cena         (zł/1szt.)',cenab as'Cena     (zł/mb)' FROM tabelaD", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            connector.CloseConnection();

        }
        public  void Insterta()
        {
            connector.OpenConnection();

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("INSERT INTO tabelaA VALUES (null,'"+symbolTx.Text+ "','" + dlugoscTx.Text + "','" + wysokoscTx.Text + "','" + wagaTx.Text + "','" + wagaBTx.Text + "','" + powTx.Text + "','" + cenaTx.Text + "')", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            connector.CloseConnection();
            
        }

    


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBunifu_onItemSelected(object sender, EventArgs e)
        {

            if (comboBunifuData.selectedIndex == 0)
            {
                operation = 1;
                ShowDataA();
                Console.WriteLine("element " + operation);


            }
            if (comboBunifuData.selectedIndex == 1)
            {
                operation = 2;
                ShowDataB();
                Console.WriteLine("element " + operation);


            }
            if (comboBunifuData.selectedIndex == 2)
            {
                operation = 3;
                ShowDataC();
                Console.WriteLine("element " + operation);

            }
            if (comboBunifuData.selectedIndex == 3)
            {
                operation = 4;
                ShowDataD();
                Console.WriteLine("element " + operation);

                  labelZlSzt.Visible = true;
                  zlSztTx.Visible = true;
                  zlSztTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                  zlSztTx.Enabled = true;

                  labelZlMb.Visible = true;
                  zlMbTx.Visible = true;
                  zlMbTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                  zlMbTx.Enabled = true;

                  labelWagaC.Visible = true;
                  wagaCTx.Visible = true;
                  wagaCTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                  wagaCTx.Enabled = true;

                  labelSzerokosc.Visible = true;
                  szerokoscTx.Visible = true;
                  szerokoscTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                  szerokoscTx.Enabled = true;  


            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if( operation == 1)
            {
                Insterta();
                ShowDataA();
                
            }
            Console.WriteLine("guzik"+operation);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}


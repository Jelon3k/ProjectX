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
    public partial class UserSettings : UserControl
    {
        public UserSettings()
        {
            InitializeComponent();
        }

        private double rabat = 0;

        private double waga = 0;

        SQLiteConnection sQLiteConnection = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "DB.db")));
        Connector connector = new Connector();

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
        public void UpdateSettings()
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();

                    cmd.CommandText = String.Format("UPDATE tabelaE SET waga ='" + waga + "',rabat ='" + rabat + "' WHERE id = 1");

                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();

                    MessageBox.Show("Dokonano aktualizacji parametrów:\nWaga: " + waga + " kg \nRabat: " + rabat + " %","Sukces",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bląd !!!" + ex,"Uwaga",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (ladownoscTx.Text == "" || ladownoscTx.Text == "")
                {
                    MessageBox.Show("Wypełnij dane " , "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    rabat = Convert.ToDouble(rabatTx.Text);
                    waga = Convert.ToDouble(ladownoscTx.Text);
                    UpdateSettings();
                }
            }
            catch
            {


            }
        }

        private void rabatTx_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void UserSettings_Load(object sender, EventArgs e)
        {

        }
    }
}

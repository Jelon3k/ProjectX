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
    public partial class UserControl2 : UserControl
    {
        int operation = 0;
        string symbol;
        int dlugosc;
        int wysokosc;
        int wagaKgSzt;
        int wagaKgM;
        double powierzchnia;
        int cenaZaM;
        int cenaSzt;
        int cenaMb;
        int szerokosc;
        int ID;



        Connector connector = new Connector();
        SQLiteConnection sQLiteConnection = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "DB.db")));
        public UserControl2()
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




        }

        private void UserControl2_Load(object sender, EventArgs e)
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
        public void Insterta()
        {
            try
            {
                    connector.OpenConnection();
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("INSERT INTO tabelaA VALUES (null,'" + symbolTx.Text + "','" + dlugoscTx.Text + "','" + wysokoscTx.Text + "','" + wagaTx.Text + "','" + wagaBTx.Text + "','" + powTx.Text + "','" + cenaTx.Text + "')", sQLiteConnection);
                    DataSet dataSet = new System.Data.DataSet();
                    dataAdapter.Fill(dataSet);
                    connector.CloseConnection();
                    MessageBox.Show("Dodano wiersz do bazy danych", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        public void InstertB()
        {
            try
            {
                connector.OpenConnection();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("INSERT INTO tabelaB VALUES (null,'" + symbolTx.Text + "','" + dlugoscTx.Text + "','" + wysokoscTx.Text + "','" + wagaTx.Text + "','" + wagaBTx.Text + "','" + powTx.Text + "','" + cenaTx.Text + "')", sQLiteConnection);
                DataSet dataSet = new System.Data.DataSet();
                dataAdapter.Fill(dataSet);
                connector.CloseConnection();
                MessageBox.Show("Dodano wiersz do bazy danych", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void InstertC()
        {
            try
            {
                connector.OpenConnection();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("INSERT INTO tabelaC VALUES (null,'" + symbolTx.Text + "','" + dlugoscTx.Text + "','" + wysokoscTx.Text + "','" + wagaTx.Text + "','" + wagaBTx.Text + "','" + powTx.Text + "','" + cenaTx.Text + "')", sQLiteConnection);
                DataSet dataSet = new System.Data.DataSet();
                dataAdapter.Fill(dataSet);
                connector.CloseConnection();
                MessageBox.Show("Dodano wiersz do bazy danych", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void InstertD()
        {
            try
            {
                connector.OpenConnection();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("INSERT INTO tabelaD VALUES (null,'" + dlugoscTx.Text + "','" + szerokoscTx.Text + "','" + wysokoscTx.Text + "','" + wagaTx.Text + "','" + zlSztTx.Text + "','" + zlMbTx.Text + "')", sQLiteConnection);
                DataSet dataSet = new System.Data.DataSet();
                dataAdapter.Fill(dataSet);
                connector.CloseConnection();
                MessageBox.Show("Dodano wiersz do bazy danych", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeleteA(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();
                    cmd.CommandText = String.Format("DELETE FROM tabelaA WHERE id={0}", ID);
                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataA();
                    MessageBox.Show("Usunięt wiersz z bazy danych. Id: "+ ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeleteB(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();

                    cmd.CommandText = String.Format("DELETE FROM tabelaB WHERE id={0}", ID);
                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataB();
                    MessageBox.Show("Usunięt wiersz z bazy danych. Id: " + ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeleteC(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();

                    cmd.CommandText = String.Format("DELETE FROM tabelaC WHERE id={0}", ID);
                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataC();
                    MessageBox.Show("Usunięt wiersz z bazy danych. Id: " + ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeleteD(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();

                    cmd.CommandText = String.Format("DELETE FROM tabelaD WHERE id={0}", ID);

                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataD();
                    MessageBox.Show("Usunięt wiersz z bazy danych. Id: " + ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void UpdateA(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();

                    cmd.CommandText = String.Format("UPDATE tabelaA SET symbol ='" + symbolTx.Text + "',dlugosc ='" + dlugoscTx.Text + "',wysokosc ='" + wysokoscTx.Text + "',wagaA='" + wagaTx.Text + "',wagaB='" + wagaBTx.Text + "',powierzchnia='" + powTx.Text + "',cenazam='" + cenaTx.Text + "'  WHERE id={0}", ID);

                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataA();
                    MessageBox.Show("Dokonano aktualizacji bazy danych. Id: " + ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void UpdateB(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();

                    cmd.CommandText = String.Format("UPDATE tabelaB SET symbol ='" + symbolTx.Text + "',dlugosc ='" + dlugoscTx.Text + "',wysokosc ='" + wysokoscTx.Text + "',wagaA='" + wagaTx.Text + "',wagaB='" + wagaBTx.Text + "',powierzchnia='" + powTx.Text + "',cenazam='" + cenaTx.Text + "'  WHERE id={0}", ID);

                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataB();
                    MessageBox.Show("Dokonano aktualizacji bazy danych. Id: " + ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void UpdateC(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();
                    cmd.CommandText = String.Format("UPDATE tabelaC SET symbol ='" + symbolTx.Text + "',dlugosc ='" + dlugoscTx.Text + "',wysokosc ='" + wysokoscTx.Text + "',wagaA='" + wagaTx.Text + "',wagaB='" + wagaBTx.Text + "',powierzchnia='" + powTx.Text + "',cenazam='" + cenaTx.Text + "'  WHERE id={0}", ID);
                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataC();
                    MessageBox.Show("Dokonano aktualizacji bazy danych. Id: " + ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateD(int ID)
        {
            try
            {
                using (SQLiteCommand cmd = sQLiteConnection.CreateCommand())
                {
                    sQLiteConnection.Open();
                    cmd.CommandText = String.Format("UPDATE tabelaD SET  dlugosc ='" + dlugoscTx.Text + "',szerokosc ='" + szerokoscTx.Text + "', wysokosc='" + wysokoscTx.Text + "',waga='" + wagaTx.Text + "',cenaa='" + zlSztTx.Text + "',cenab='" + zlMbTx.Text + "'  WHERE id={0}", ID);
                    cmd.ExecuteNonQuery();
                    sQLiteConnection.Close();
                    ShowDataD();
                    MessageBox.Show("Dokonano aktualizacji bazy danych. Id: " + ID, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Treść błedu  " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBunifuData_onItemSelected(object sender, EventArgs e)
        {
            if (comboBunifuData.selectedIndex == 0)
            {
                ClearText();
                ModTx();
                operation = 1;
                ShowDataA();
            }
            if (comboBunifuData.selectedIndex == 1)
            {
                ClearText();
                ModTx();
                operation = 2;
                ShowDataB();
            }
            if (comboBunifuData.selectedIndex == 2)
            {
                ClearText();
                ModTx();
                operation = 3;
                ShowDataC();
            }
            if (comboBunifuData.selectedIndex == 3)
            {
                ClearText();
                operation = 4;
                ShowDataD();

                labelZlSzt.Visible = true;
                zlSztTx.Visible = true;
                zlSztTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                zlSztTx.Enabled = true;

                labelZlMb.Visible = true;
                zlMbTx.Visible = true;
                zlMbTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                zlMbTx.Enabled = true;


                wagaTx.Visible = true;
                wagaTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                wagaTx.Enabled = true;

                labelSzerokosc.Visible = true;

                szerokoscTx.Visible = true;
                szerokoscTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                szerokoscTx.Enabled = true;

                dlugoscTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                wysokoscTx.LineIdleColor = Color.FromArgb(0, 176, 80);

                symbolTx.Enabled = false;
                wagaTx.Enabled = true;
                wagaBTx.Enabled = false;
                powTx.Enabled = false;
                cenaTx.Enabled = false;

                symbolTx.LineIdleColor = Color.Gray;
                wagaTx.LineIdleColor = Color.FromArgb(0, 176, 80);
                wagaBTx.LineIdleColor = Color.Gray;
                powTx.LineIdleColor = Color.Gray;
                cenaTx.LineIdleColor = Color.Gray;
            }
        }

        public void ClearText()
        {
            zlSztTx.Text = "";
            zlMbTx.Text = "";
            szerokoscTx.Text = "";
            symbolTx.Text = "";
            wagaTx.Text = "";
            wagaBTx.Text = "";
            powTx.Text = "";
            cenaTx.Text = "";
            zlMbTx.Text = "";
            zlSztTx.Text = "";
            dlugoscTx.Text = "";
            wysokoscTx.Text = "";
        }
        public void ModTx()
        {
            zlSztTx.LineIdleColor = Color.Gray;
            zlMbTx.LineIdleColor = Color.Gray;
            szerokoscTx.LineIdleColor = Color.Gray;
            zlSztTx.Enabled = false;
            zlMbTx.Enabled = false;
            szerokoscTx.Enabled = false;

            symbolTx.Enabled = true;
            wagaTx.Enabled = true;
            wagaBTx.Enabled = true;
            powTx.Enabled = true;
            cenaTx.Enabled = true;
            symbolTx.LineIdleColor = Color.FromArgb(0, 176, 80);
            dlugoscTx.LineIdleColor = Color.FromArgb(0, 176, 80);
            wysokoscTx.LineIdleColor = Color.FromArgb(0, 176, 80);
            wagaTx.LineIdleColor = Color.FromArgb(0, 176, 80);
            wagaBTx.LineIdleColor = Color.FromArgb(0, 176, 80);
            powTx.LineIdleColor = Color.FromArgb(0, 176, 80);
            cenaTx.LineIdleColor = Color.FromArgb(0, 176, 80);

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                try
                {
                    if (symbolTx.Text == "" || dlugoscTx.Text == "" || wysokoscTx.Text == "" || wagaTx.Text == "" || wagaBTx.Text == "" || powTx.Text == "" || cenaTx.Text  == "")
                    {
                        MessageBox.Show("Wypełnij wszystkie pola poprawnie pamiętając, że tylko w kolumnie symbol możesz używać różnych znaków.W pozostałych kolumnach używaj cyfr.", "Uwaga", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else {
                        Insterta();
                        ShowDataA();
                        MessageBox.Show("Dodano wiesz do tablicy", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch
                {

                }

            }
            if (operation == 2)
            {
                try
                {
                    if (symbolTx.Text == "" || dlugoscTx.Text == "" || wysokoscTx.Text == "" || wagaTx.Text == "" || wagaBTx.Text == "" || powTx.Text == "" || cenaTx.Text == "")
                    {
                        MessageBox.Show("Wypełnij wszystkie pola poprawnie pamiętając, że tylko w kolumnie symbol możesz używać różnych znaków.W pozostałych kolumnach używaj cyfr.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        InstertB();
                        ShowDataB();
                        MessageBox.Show("Dodano wiesz do tablicy", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch
                {

                }
            }
            if (operation == 3)
            {
                try
                {
                    if (symbolTx.Text == "" || dlugoscTx.Text == "" || wysokoscTx.Text == "" || wagaTx.Text == "" || wagaBTx.Text == "" || powTx.Text == "" || cenaTx.Text == "")
                    {
                        MessageBox.Show("Wypełnij wszystkie pola poprawnie pamiętając, że tylko w kolumnie symbol możesz używać różnych znaków.W pozostałych kolumnach używaj cyfr.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        InstertC();
                        ShowDataC();
                        MessageBox.Show("Dodano wiesz do tablicy", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch
                {

                }
            }
            if (operation == 4)
            {
                try
                {
                    if (dlugoscTx.Text == "" || szerokoscTx.Text == "" || wysokoscTx.Text == "" || wagaTx.Text == "" || zlSztTx.Text == "" || zlMbTx.Text == "")
                    {
                        MessageBox.Show("Wypełnij wszystkie pola poprawnie pamiętając, że w kolumnach używaj cyfr.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        InstertD();
                        ShowDataD();
                        MessageBox.Show("Dodano wiesz do tablicy", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {

                }
            }
        }




        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (operation == 1 || operation == 2 || operation == 3)
            {

                try
                {
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    Console.WriteLine(ID);


                    symbol = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    symbolTx.Text = symbol;

                    dlugosc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    dlugoscTx.Text = dlugosc.ToString();

                    wysokosc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    wysokoscTx.Text = wysokosc.ToString();

                    wagaKgSzt = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    wagaTx.Text = wagaKgSzt.ToString();

                    wagaKgM = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    wagaBTx.Text = wagaKgM.ToString();

                    powierzchnia = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                    powTx.Text = powierzchnia.ToString();

                    cenaZaM = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                    cenaTx.Text = cenaZaM.ToString();
                }
                catch

                {
                    MessageBox.Show("Coś poszło nie tak ;-(");
                }
            }
            else
            {
                try
                {
                    ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    Console.WriteLine(ID);


                    dlugosc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                    dlugoscTx.Text = dlugosc.ToString();

                    szerokosc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                    szerokoscTx.Text = szerokosc.ToString();

                    wysokosc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    wysokoscTx.Text = wysokosc.ToString();

                    wagaKgSzt = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    wagaTx.Text = wagaKgSzt.ToString();

                    cenaSzt = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                    zlSztTx.Text = cenaSzt.ToString();

                    cenaMb = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                    zlMbTx.Text = cenaMb.ToString();
                }
                catch
                {
                    MessageBox.Show("Coś poszło nie tak ;-(");
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                if (MessageBox.Show("Czy chcesz usunąć wybrany element", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteA(ID);
                }
            }
            if (operation == 2)
            {
                if (MessageBox.Show("Czy chcesz usunąć wybrany element", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteB(ID);
                }
            }
            if (operation == 3)
            {
                if (MessageBox.Show("Czy chcesz usunąć wybrany element", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteC(ID);
                }
            }
            if (operation == 4)
            {
                if (MessageBox.Show("Czy chcesz usunąć wybrany element", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteD(ID);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                if (MessageBox.Show("Czy chcesz z aktualizować wybrany element", "Aktualizacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateA(ID);
                }
            }
            if (operation == 2)
            {
                if (MessageBox.Show("Czy chcesz z aktualizować wybrany element", "Aktualizacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateB(ID);
                }
            }
            if (operation == 3)
            {
                if (MessageBox.Show("Czy chcesz z aktualizować wybrany element", "Aktualizacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateC(ID);
                }
            }
            if (operation == 4)
            {
                if (MessageBox.Show("Czy chcesz z aktualizować wybrany element", "Aktualizacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateD(ID);
                }
            }
        }
    }
}

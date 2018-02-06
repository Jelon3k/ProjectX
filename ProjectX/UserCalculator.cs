using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace ProjectX
{
    public partial class UserCalculator : UserControl
    {
        int operation = 0;
        int ID;
        int cenaZaM;
        int wagaKgSzt;
        string symbol;
        double cenaWynik;
        double wynik;
        double powierzchnia;
        double powCalkowita;
        double transportWaga;
        double sklepRabat;
        double wynikCenaNetto;
        double sklepMarza;
        double wynikSumaCenyNetto;

        double sumaMkwadratowe = 0;
        double sumaKg = 0;
        double sumaNetto = 0;
        double wynikTransport;

        int wagaKgM;
        int sztuk;
        Connector connector = new Connector();
        SQLiteConnection sQLiteConnection = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "DB.db")));

        public UserCalculator()
        {
            InitializeComponent();

            comboBunifuData.AddItem("Ruszta betonowe dla trzody (Szer. 45,4cm Szcz. 17mm Pow. Stąpania 80mm");
            comboBunifuData.AddItem("Ruszta betonowe dla trzody (Szer. 44cm Szcz. 18mm Pow. Stąpania 92mm");
            comboBunifuData.AddItem("Ruszta betonowe dla loszek,loch i knurów (Szer. 52cm Szcz. 20mm Pow. Stąpania 84mm");
            comboBunifuData.AddItem("Belki żelbetonowe - Podciągi dla betonowych podłóg rusztowych dla trzody");


            dataGridView2.RowTemplate.Height = 20;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 60, 218);
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.FromArgb(37, 46, 59);

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        public double Oblicz(int sztuk, double powierzchnia)
        {
            powCalkowita = sztuk * powierzchnia;
            wynik = powCalkowita * wagaKgM;
            return wynik;
        }
        public double ObliczCena(int sztuk, int cena, double powierzchnia)
        {
            cenaWynik = powCalkowita * cena;
            return cenaWynik;
        }
        public double GetWaga()
        {
            {
                sQLiteConnection.Open();
                SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                cmd.CommandText = "SELECT waga FROM tabelaE where id=1";
                object waga = cmd.ExecuteScalar();
                transportWaga = (double)waga;
                sQLiteConnection.Close();
                return transportWaga;
            }
        }
        public double GetRabat()
        {
            {
                sQLiteConnection.Open();
                SQLiteCommand cmd = sQLiteConnection.CreateCommand();
                cmd.CommandText = "SELECT rabat FROM tabelaE where id=1";
                object rabat = cmd.ExecuteScalar();
                sklepRabat = (double)rabat;
                sQLiteConnection.Close();
                return sklepRabat;
            }
        }
        public double CenaNetto(double sklepRabat, double cenaZaM, double sklepMarza)
        {
            double procent;
            double etapPierwszy;
            procent = sklepRabat * 0.01;
            etapPierwszy = cenaZaM * procent;
            wynikCenaNetto = cenaZaM - etapPierwszy + sklepMarza;
            return wynikCenaNetto;
        }
        public double SumaCenyNetto(double sztuk, double cenaNetto)
        {
            wynikSumaCenyNetto = sztuk * cenaNetto;
            return wynikSumaCenyNetto;
        }
        public double ObliczTransport(double sumaWagi,double ladowoscCiezarowki)
        {
            wynikTransport = sumaWagi / ladowoscCiezarowki;
            return wynikTransport;
        }
        public void ShowDataA()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',symbol as 'Symbol                    ',dlugosc as'Długość         (cm)',wysokosc as'Wysokość     (cm)',wagaA as 'Waga        (Kg/1 szt.)',wagaB as'Waga         (Kg/m²)',powierzchnia as'Powierzchnia Płt (m²)',cenazam as'Cena za m²(PLN)' FROM tabelaA", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connector.CloseConnection();

        }
        public void ShowDataB()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',symbol as 'Symbol                    ',dlugosc as'Długość         (cm)',wysokosc as'Wysokość     (cm)',wagaA as 'Waga        (Kg/1 szt.)',wagaB as'Waga         (Kg/m²)',powierzchnia as'Powierzchnia Płt (m²)',cenazam as'Cena za m²(PLN)' FROM tabelaB", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connector.CloseConnection();

        }
        public void ShowDataC()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',symbol as 'Symbol                    ',dlugosc as'Długość         (cm)',wysokosc as'Wysokość     (cm)',wagaA as 'Waga        (Kg/1 szt.)',wagaB as'Waga         (Kg/m²)',powierzchnia as'Powierzchnia Płt (m²)',cenazam as'Cena za m²(PLN)' FROM tabelaC", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connector.CloseConnection();
        }
        public void ShowDataD()
        {
            connector.OpenConnection();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT id as'ID',dlugosc as'Długość         (cm)',szerokosc as'Szerokość     (cm)',wysokosc as'Wysokość     (cm)',waga as 'Waga        (Kg/1 szt.)',cenaa as'Cena         (zł/1szt.)',cenab as'Cena     (zł/mb)' FROM tabelaD", sQLiteConnection);
            DataSet dataSet = new System.Data.DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
            connector.CloseConnection();

        }
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (operation == 1 || operation == 2 || operation == 3)
            {
                try
                {
                    ID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                    Console.WriteLine(ID);

               
                    symbol = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                    
                    powierzchnia = Convert.ToDouble(dataGridView2.SelectedRows[0].Cells[6].Value.ToString());
                  
                    wagaKgSzt = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[4].Value.ToString());
                   
                    wagaKgM = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[5].Value.ToString());

                    cenaZaM = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[7].Value.ToString());
                
                }
                catch

                {
                    MessageBox.Show("Coś poszło nie tak");
                }
            }
            else
            {
                try
                {
                    /*
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
                    zlMbTx.Text = cenaMb.ToString();*/
                }
                catch
                {
                    MessageBox.Show("Zazacz wiersz, który chcesz usunąć");
                }
            }
            }
        private void comboBunifuData_onItemSelected_1(object sender, EventArgs e)
        {

            if (comboBunifuData.selectedIndex == 0)
            {
                operation = 1;
                ShowDataA();
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
            }

        }

        private void btnOblicz_Click_1(object sender, EventArgs e)
        {
          

            GetRabat();
                GetWaga();
                if (sztukTX.Text == "" || marzaTx.Text == "")
                {
                    MessageBox.Show("Wypełnij pola: sztuk, marza");
                }
                else
                {
                    sztuk = Convert.ToInt32(sztukTX.Text);
                    sklepMarza = Convert.ToDouble(marzaTx.Text);
                    CenaNetto(sklepRabat, cenaZaM, sklepMarza);
                    SumaCenyNetto(sztuk, wynikCenaNetto);

                    Oblicz(sztuk, powierzchnia);
                    ObliczCena(sztuk, cenaZaM, powierzchnia);
                    ListViewItem item = new ListViewItem(symbol);
                    item.SubItems.Add(sztuk.ToString());
                    item.SubItems.Add(powierzchnia.ToString());
                    item.SubItems.Add(powCalkowita.ToString());
                    item.SubItems.Add(wagaKgSzt.ToString());
                    item.SubItems.Add(wynik.ToString());
                    item.SubItems.Add(wynikCenaNetto.ToString());
                    item.SubItems.Add(wynikSumaCenyNetto.ToString());
                    listView1.Items.Add(item);

                    double hSumaMkwadratowe = 0;
                    double hSumaKg = 0;
                    double hSumaNetto = 0;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                    hSumaMkwadratowe += double.Parse(listView1.Items[i].SubItems[3].Text);
                    hSumaKg += double.Parse(listView1.Items[i].SubItems[5].Text);
                    hSumaNetto += double.Parse(listView1.Items[i].SubItems[7].Text);
                

                }
                    
                sumaMkwadratowe = hSumaMkwadratowe;
                    sumaKg = hSumaKg;
                    sumaNetto = hSumaNetto;
                    ObliczTransport(sumaKg, transportWaga);
                    label5.Text = sumaMkwadratowe.ToString();
                    label6.Text = sumaKg.ToString();
                    label8.Text = sumaNetto.ToString();
                    label1.Text = Math.Round(wynikTransport,1).ToString();
                }
            
        }
        private void UserCalculator_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);

                    double hSumaMkwadratowe = 0;
                    double hSumaKg = 0;
                    double hSumaNetto = 0;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        hSumaMkwadratowe += double.Parse(listView1.Items[i].SubItems[3].Text);
                        hSumaKg += double.Parse(listView1.Items[i].SubItems[5].Text);
                        hSumaNetto += double.Parse(listView1.Items[i].SubItems[7].Text);
                    }
                    sumaMkwadratowe = hSumaMkwadratowe;
                    sumaKg = hSumaKg;
                    sumaNetto = hSumaNetto;
                    ObliczTransport(sumaKg, transportWaga);
                    label5.Text = sumaMkwadratowe.ToString();
                    label6.Text = sumaKg.ToString();
                    label8.Text = sumaNetto.ToString();
                    label1.Text = Math.Round(wynikTransport, 1).ToString();
                
                MessageBox.Show("usunięto element");
                }
            }catch
            {
                MessageBox.Show("Wybierz element do usunięcia");
            }
        }
    }
}

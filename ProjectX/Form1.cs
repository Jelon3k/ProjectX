using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class Form1 : Form
    {
      
    
        public Form1()
        {
            InitializeComponent();
            Connector connector = new Connector();
            connector.OpenConnection();

        }




        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
         
  

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {

                panel1.Visible = false;
                panel1.Width = 200;
                panelAnimator.ShowSync(panel1);
            }else
            {
                panel1.Visible = true;
                panel1.Width = 50;
                panelAnimator.ShowSync(panel1);

            }
            }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            userCalculator1.BringToFront();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            userContact1.BringToFront();

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userCalculator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            userSettings1.BringToFront();
        }

        private void userCalculator3_Load(object sender, EventArgs e)
        {

        }
    }
    }


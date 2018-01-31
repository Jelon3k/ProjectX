using System;

using System.Windows.Forms;
using System.Net.Mail;

namespace ProjectX
{
    public partial class UserContact : UserControl
    {
        private int port;
        private string nickSmtp;
        private string myemail = "przem.jaworski@gmail.com";

        public UserContact()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {try
            {
                SmtpClient client = new SmtpClient(nickSmtp, port); 
                MailMessage message = new MailMessage(); 
                message.From = new MailAddress(myemail); 
                message.To.Add(myemail); 
                message.Body = txtbody.Text; 
                message.Subject = txtsubject.Text; 
                client.UseDefaultCredentials = false;

                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new System.Net.NetworkCredential(txtsender.Text, bunifuMaterialTextbox1.Text);
                Cursor.Current = Cursors.WaitCursor;
                client.Send(message); 
                MessageBox.Show("Wiadomość Wysłana");
                Cursor.Current = Cursors.Default;
                message = null; 
           
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserContact_Load(object sender, EventArgs e)
        {
            comboBunifu.AddItem("@gmail.com");
            comboBunifu.AddItem("@wp.pl");
            comboBunifu.AddItem("@interia.pl");
            comboBunifu.AddItem("@o2.pl");
            comboBunifu.AddItem("@outlock.pl");
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuDropdown1_onItemSelected_1(object sender, EventArgs e)
        {
            
            if (comboBunifu.selectedIndex == 0)
            {

                nickSmtp = "smtp.gmail.com";
                port = 587;
                

            }
            if (comboBunifu.selectedIndex == 1)
            {
                nickSmtp = "smtp.wp.pl";
                port = 465;
                Console.WriteLine("wp.pl");

            }
            if (comboBunifu.selectedIndex == 2)
            {
                Console.WriteLine("wybrales indeks 3");
            }
            if (comboBunifu.selectedIndex == 3)
            {
                nickSmtp = "poczta.o2.pl";
                port = 465;
                Console.WriteLine("o2.pl");
            }
            if (comboBunifu.selectedIndex == 4)
            {
                Console.WriteLine("wybrales indeks 5");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

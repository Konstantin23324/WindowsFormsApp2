using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.UsersClasses;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBoxEmail.Text = "task_code_development@list.ru";
            textBoxName.Text = "Антон Игоревич";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxName.Text) || 
                string.IsNullOrWhiteSpace(textBoxSubject.Text) || 
                string.IsNullOrWhiteSpace(textBoxBody.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            string smtp = "smtp.mail.ru";
            StringPair fromInfo = new StringPair("konstantinguzik@mail.ru", "Гузик Константин Александрович");
            string password = "LQxnP40Zxe4aQrwGJDme";
            StringPair toInfo = new StringPair(textBoxEmail.Text, textBoxName.Text);
            string subject = textBoxSubject.Text;
            string body = $"{DateTime.Now} \n" +
            $"{Dns.GetHostName()} \n" +
            $"{Dns.GetHostAddresses(Dns.GetHostName()).First()} \n" +
            $"{textBoxBody.Text}";

            InfoEmailSending info =
            new InfoEmailSending(smtp, fromInfo, password, toInfo, subject, body);
            SendingEmail sendingEmail = new SendingEmail(info);
            sendingEmail.Send();

            MessageBox.Show("Письмо отправлено!");
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }
    }
}

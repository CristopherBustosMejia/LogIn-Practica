using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HTTPupt;
using Newtonsoft;

namespace LogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static User user;
        Form2 form2 = new Form2();
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LogIn(TxtBoxNumCard.Text, TxtBoxPssword.Text, user);
            TxtBoxNumCard.Text = "";
            TxtBoxPssword.Text = "";
        }
        private void LogIn(string NumAccount,string Password, User user)
        {
            try
            {
                FileStream File = new FileStream(@".\Account" + NumAccount + ".txt", FileMode.Open, FileAccess.ReadWrite);
                StreamReader Reader = new StreamReader(File);
                String Text;
                while((Text = Reader.ReadLine()) != null)
                {
                    user = JsonConvertidor.Json_Objeto<User>(Text);
                }
                File.Close();
                Reader.Close();
                if(user.Password == Password)
                {
                    form2.user = user;
                    form2.form1 = this;
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La contraseña que ingreso no coincide con el numero de cuenta");
                }
            }
            catch
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }

        private void KeyPressNumV(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            
        }
    }
}

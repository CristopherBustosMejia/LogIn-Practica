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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public User user;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre del titular: " + user.UserName + "\nNumero de Cuenta: " + user.creditCard.Account + "\nCredito Total: " + user.creditCard.Credit + "\nCredito Disponible: " + user.creditCard.RemainigCred);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if(double.Parse(TxtBoxCash.Text) <= user.creditCard.RemainigCred)
            {
                user.creditCard.RemainigCred = user.creditCard.RemainigCred - double.Parse(TxtBoxCash.Text);
                SaveChanges(user);
                MessageBox.Show("Tarea Exitosa");
            }
            else
            {
                MessageBox.Show("Credito Insuficiente");            
            }
        }
        private void SaveChanges(User user)
        {
            FileStream File = new FileStream(@"Account" + user.creditCard.Account + ".txt", FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(File);
            String json = JsonConvertidor.Objeto_Json(user);
            writer.WriteLine(json);
            writer.Close();
            File.Close();
        }
    }
}

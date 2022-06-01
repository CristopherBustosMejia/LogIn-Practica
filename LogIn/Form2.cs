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
        public User usertwo;
        public Form1 form1;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre del titular: " + user.UserName + "\nNumero de Cuenta: " + user.creditCard.Account + "\nCredito Original: " + user.creditCard.Credit + "\nCredito Disponible: " + user.creditCard.RemainigCred);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(TxtBoxCash.Text) <= user.creditCard.RemainigCred && double.Parse(TxtBoxCash.Text) >= 0)
                {
                    user.creditCard.RemainigCred = user.creditCard.RemainigCred - double.Parse(TxtBoxCash.Text);
                    SaveChanges(user);
                    MessageBox.Show("Tarea Exitosa");
                }
                else
                {
                    MessageBox.Show("Valor ingresado no valido \n-Por favor ingrese un valor dentro del limite de su credito \n-Ingrese un valor positivo");
                }
            }
            catch
            {
                MessageBox.Show("Valor ingresado no valido");
            }
            TxtBoxCash.Text = "";
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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Hide();
        }

        private void KeyValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if(TxtBoxOldPsswrd.Text == user.Password)
            {
                if(TxtBoxNewPsswrd.Text == TxtBoxConfirm.Text)
                {
                    user.Password = TxtBoxNewPsswrd.Text;
                    FileStream File = new FileStream(@"Account" + user.creditCard.Account + ".txt", FileMode.Open, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(File);
                    String json = JsonConvertidor.Objeto_Json(user);
                    writer.WriteLine(json);
                    writer.Close();
                    File.Close();
                    TxtBoxConfirm.Text = "";
                    TxtBoxOldPsswrd.Text = "";
                    TxtBoxNewPsswrd.Text = "";
                    panel1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual ingresada es incorrecta");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtBoxConfirm.Text = "";
            TxtBoxOldPsswrd.Text = "";
            TxtBoxNewPsswrd.Text = "";
            panel1.Visible = false;
        }

        private void BtnDoTranasfer_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream File = new FileStream(@"Account" + TxtBoxAccountTwo.Text + ".txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(File);
                String Text;
                while((Text = reader.ReadLine()) != null)
                {
                    usertwo = JsonConvertidor.Json_Objeto<User>(Text);
                }
                File.Close();
                reader.Close();
                if(double.Parse(TxtBoxQuantity.Text) <= user.creditCard.RemainigCred)
                {
                    usertwo.creditCard.RemainigCred = usertwo.creditCard.RemainigCred + double.Parse(TxtBoxQuantity.Text);
                    user.creditCard.RemainigCred = user.creditCard.RemainigCred - double.Parse(TxtBoxQuantity.Text);
                    FileStream WriteFile2 = new FileStream(@"Account" + usertwo.creditCard.Account + ".txt", FileMode.Open, FileAccess.Write);
                    StreamWriter Writer2 = new StreamWriter(WriteFile2);
                    String json2 = JsonConvertidor.Objeto_Json(usertwo);
                    Writer2.WriteLine(json2);
                    Writer2.Close();
                    WriteFile2.Close();
                    FileStream WriteFile1 = new FileStream(@"Account" + user.creditCard.Account + ".txt", FileMode.Open, FileAccess.Write);
                    StreamWriter Writer1 = new StreamWriter(WriteFile1);
                    String json1 = JsonConvertidor.Objeto_Json(user);
                    Writer1.WriteLine(json1);
                    Writer1.Close();
                    WriteFile1.Close();
                    TxtBoxAccountTwo.Text = "";
                    TxtBoxQuantity.Text = "";
                    panel2.Visible = false;
                }
                else
                {
                    MessageBox.Show("Dinero insuficiente para la transaccion");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error durante la transaccion");
            }
        }

        private void BtnCancelTransfer_Click(object sender, EventArgs e)
        {
            TxtBoxAccountTwo.Text = "";
            TxtBoxQuantity.Text = "";
            panel2.Visible = false;
        }

        private void BtnTranfer_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void VaildateAccountKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void ValidateQuantityKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
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

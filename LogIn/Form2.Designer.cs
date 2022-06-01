namespace LogIn
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.TxtBoxCash = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.BtnPassword = new System.Windows.Forms.Button();
            this.BtnTransfer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.TxtBoxConfirm = new System.Windows.Forms.TextBox();
            this.TxtBoxNewPsswrd = new System.Windows.Forms.TextBox();
            this.TxtBoxOldPsswrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelTransfer = new System.Windows.Forms.Button();
            this.BtnDoTranasfer = new System.Windows.Forms.Button();
            this.TxtBoxQuantity = new System.Windows.Forms.TextBox();
            this.TxtBoxAccountTwo = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowAccount.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAccount.Location = new System.Drawing.Point(12, 111);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(196, 46);
            this.btnShowAccount.TabIndex = 1;
            this.btnShowAccount.Text = "Revisar Cuenta";
            this.btnShowAccount.UseVisualStyleBackColor = false;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(253, 99);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(187, 29);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Solicitar Efectivo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::LogIn.Properties.Resources.AG00163_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(118, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bank of America";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl2.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(255, 140);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(119, 17);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Monto Solicitado:";
            // 
            // TxtBoxCash
            // 
            this.TxtBoxCash.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxCash.Location = new System.Drawing.Point(258, 175);
            this.TxtBoxCash.Name = "TxtBoxCash";
            this.TxtBoxCash.Size = new System.Drawing.Size(170, 30);
            this.TxtBoxCash.TabIndex = 6;
            this.TxtBoxCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBoxCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyValidation);
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequest.Location = new System.Drawing.Point(314, 231);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 7;
            this.btnRequest.Text = "Solicitar";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnExit.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(12, 218);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(195, 45);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBack.Location = new System.Drawing.Point(243, 84);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(209, 195);
            this.lblBack.TabIndex = 9;
            // 
            // BtnPassword
            // 
            this.BtnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnPassword.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPassword.Location = new System.Drawing.Point(12, 168);
            this.BtnPassword.Name = "BtnPassword";
            this.BtnPassword.Size = new System.Drawing.Size(88, 37);
            this.BtnPassword.TabIndex = 10;
            this.BtnPassword.Text = "Cambiar Contraseña";
            this.BtnPassword.UseVisualStyleBackColor = false;
            this.BtnPassword.Click += new System.EventHandler(this.BtnPassword_Click);
            // 
            // BtnTransfer
            // 
            this.BtnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnTransfer.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransfer.Location = new System.Drawing.Point(119, 168);
            this.BtnTransfer.Name = "BtnTransfer";
            this.BtnTransfer.Size = new System.Drawing.Size(88, 37);
            this.BtnTransfer.TabIndex = 11;
            this.BtnTransfer.Text = "Transferencia";
            this.BtnTransfer.UseVisualStyleBackColor = false;
            this.BtnTransfer.Click += new System.EventHandler(this.BtnTranfer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnAccept);
            this.panel1.Controls.Add(this.TxtBoxConfirm);
            this.panel1.Controls.Add(this.TxtBoxNewPsswrd);
            this.panel1.Controls.Add(this.TxtBoxOldPsswrd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 291);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCancel.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(338, 241);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 26);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.Green;
            this.BtnAccept.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.Location = new System.Drawing.Point(338, 201);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 26);
            this.BtnAccept.TabIndex = 6;
            this.BtnAccept.Text = "Aceptar";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // TxtBoxConfirm
            // 
            this.TxtBoxConfirm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxConfirm.Location = new System.Drawing.Point(28, 235);
            this.TxtBoxConfirm.Name = "TxtBoxConfirm";
            this.TxtBoxConfirm.PasswordChar = '*';
            this.TxtBoxConfirm.Size = new System.Drawing.Size(218, 26);
            this.TxtBoxConfirm.TabIndex = 5;
            this.TxtBoxConfirm.UseSystemPasswordChar = true;
            // 
            // TxtBoxNewPsswrd
            // 
            this.TxtBoxNewPsswrd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxNewPsswrd.Location = new System.Drawing.Point(28, 138);
            this.TxtBoxNewPsswrd.Name = "TxtBoxNewPsswrd";
            this.TxtBoxNewPsswrd.PasswordChar = '*';
            this.TxtBoxNewPsswrd.Size = new System.Drawing.Size(218, 26);
            this.TxtBoxNewPsswrd.TabIndex = 4;
            this.TxtBoxNewPsswrd.UseSystemPasswordChar = true;
            // 
            // TxtBoxOldPsswrd
            // 
            this.TxtBoxOldPsswrd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxOldPsswrd.Location = new System.Drawing.Point(28, 51);
            this.TxtBoxOldPsswrd.Name = "TxtBoxOldPsswrd";
            this.TxtBoxOldPsswrd.PasswordChar = '*';
            this.TxtBoxOldPsswrd.Size = new System.Drawing.Size(218, 26);
            this.TxtBoxOldPsswrd.TabIndex = 3;
            this.TxtBoxOldPsswrd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirmar Contraseña:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(20, 107);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(141, 19);
            this.lbl4.TabIndex = 1;
            this.lbl4.Text = "Nueva Contraseña:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(16, 15);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(142, 19);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Contraseña Actual:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancelTransfer);
            this.panel2.Controls.Add(this.BtnDoTranasfer);
            this.panel2.Controls.Add(this.TxtBoxQuantity);
            this.panel2.Controls.Add(this.TxtBoxAccountTwo);
            this.panel2.Controls.Add(this.lbl6);
            this.panel2.Controls.Add(this.lbl5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 291);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // BtnCancelTransfer
            // 
            this.BtnCancelTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancelTransfer.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelTransfer.Location = new System.Drawing.Point(314, 201);
            this.BtnCancelTransfer.Name = "BtnCancelTransfer";
            this.BtnCancelTransfer.Size = new System.Drawing.Size(126, 45);
            this.BtnCancelTransfer.TabIndex = 5;
            this.BtnCancelTransfer.Text = "Cancelar";
            this.BtnCancelTransfer.UseVisualStyleBackColor = false;
            this.BtnCancelTransfer.Click += new System.EventHandler(this.BtnCancelTransfer_Click);
            // 
            // BtnDoTranasfer
            // 
            this.BtnDoTranasfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnDoTranasfer.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoTranasfer.Location = new System.Drawing.Point(314, 90);
            this.BtnDoTranasfer.Name = "BtnDoTranasfer";
            this.BtnDoTranasfer.Size = new System.Drawing.Size(126, 45);
            this.BtnDoTranasfer.TabIndex = 4;
            this.BtnDoTranasfer.Text = "Transferir";
            this.BtnDoTranasfer.UseVisualStyleBackColor = false;
            this.BtnDoTranasfer.Click += new System.EventHandler(this.BtnDoTranasfer_Click);
            // 
            // TxtBoxQuantity
            // 
            this.TxtBoxQuantity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxQuantity.Location = new System.Drawing.Point(16, 142);
            this.TxtBoxQuantity.Name = "TxtBoxQuantity";
            this.TxtBoxQuantity.Size = new System.Drawing.Size(255, 26);
            this.TxtBoxQuantity.TabIndex = 3;
            this.TxtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateQuantityKey);
            // 
            // TxtBoxAccountTwo
            // 
            this.TxtBoxAccountTwo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxAccountTwo.Location = new System.Drawing.Point(16, 51);
            this.TxtBoxAccountTwo.Name = "TxtBoxAccountTwo";
            this.TxtBoxAccountTwo.Size = new System.Drawing.Size(255, 26);
            this.TxtBoxAccountTwo.TabIndex = 2;
            this.TxtBoxAccountTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VaildateAccountKey);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(12, 99);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(90, 23);
            this.lbl6.TabIndex = 1;
            this.lbl6.Text = "Cantidad:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(12, 15);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(171, 23);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Numero de Cuenta:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 288);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnTransfer);
            this.Controls.Add(this.BtnPassword);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.TxtBoxCash);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnShowAccount);
            this.Controls.Add(this.lblBack);
            this.Name = "Form2";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox TxtBoxCash;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button BtnPassword;
        private System.Windows.Forms.Button BtnTransfer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox TxtBoxOldPsswrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxConfirm;
        private System.Windows.Forms.TextBox TxtBoxNewPsswrd;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDoTranasfer;
        private System.Windows.Forms.TextBox TxtBoxQuantity;
        private System.Windows.Forms.TextBox TxtBoxAccountTwo;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Button BtnCancelTransfer;
    }
}
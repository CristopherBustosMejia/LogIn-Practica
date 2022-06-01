namespace LogIn
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMain = new System.Windows.Forms.Label();
            this.PicBoxIso = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.TxtBoxNumCard = new System.Windows.Forms.TextBox();
            this.lblPsswrd = new System.Windows.Forms.Label();
            this.TxtBoxPssword = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.Font = new System.Drawing.Font("Constantia", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Navy;
            this.lblMain.Location = new System.Drawing.Point(113, 33);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(309, 61);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Bank of America";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PicBoxIso
            // 
            this.PicBoxIso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBoxIso.Image = global::LogIn.Properties.Resources.AG00163_;
            this.PicBoxIso.Location = new System.Drawing.Point(12, 12);
            this.PicBoxIso.Name = "PicBoxIso";
            this.PicBoxIso.Size = new System.Drawing.Size(95, 82);
            this.PicBoxIso.TabIndex = 1;
            this.PicBoxIso.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 138);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(177, 23);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Numero de Tajerta:";
            // 
            // TxtBoxNumCard
            // 
            this.TxtBoxNumCard.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxNumCard.Location = new System.Drawing.Point(16, 178);
            this.TxtBoxNumCard.Name = "TxtBoxNumCard";
            this.TxtBoxNumCard.Size = new System.Drawing.Size(397, 30);
            this.TxtBoxNumCard.TabIndex = 3;
            this.TxtBoxNumCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumV);
            // 
            // lblPsswrd
            // 
            this.lblPsswrd.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsswrd.Location = new System.Drawing.Point(12, 221);
            this.lblPsswrd.Name = "lblPsswrd";
            this.lblPsswrd.Size = new System.Drawing.Size(116, 23);
            this.lblPsswrd.TabIndex = 4;
            this.lblPsswrd.Text = "Contraseña:";
            // 
            // TxtBoxPssword
            // 
            this.TxtBoxPssword.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxPssword.Location = new System.Drawing.Point(16, 265);
            this.TxtBoxPssword.Name = "TxtBoxPssword";
            this.TxtBoxPssword.PasswordChar = '*';
            this.TxtBoxPssword.Size = new System.Drawing.Size(393, 30);
            this.TxtBoxPssword.TabIndex = 5;
            this.TxtBoxPssword.UseSystemPasswordChar = true;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.Green;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogIn.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.ForeColor = System.Drawing.Color.White;
            this.BtnLogIn.Location = new System.Drawing.Point(141, 344);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(142, 51);
            this.BtnLogIn.TabIndex = 6;
            this.BtnLogIn.Text = "Iniciar Sesion";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.TxtBoxPssword);
            this.Controls.Add(this.lblPsswrd);
            this.Controls.Add(this.TxtBoxNumCard);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.PicBoxIso);
            this.Controls.Add(this.lblMain);
            this.Name = "Form1";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxIso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.PictureBox PicBoxIso;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox TxtBoxNumCard;
        private System.Windows.Forms.Label lblPsswrd;
        private System.Windows.Forms.TextBox TxtBoxPssword;
        private System.Windows.Forms.Button BtnLogIn;
    }
}


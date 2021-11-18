
namespace Projeto3Camadas.Ui
{
    partial class Frm_Login
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.picEntrar = new System.Windows.Forms.PictureBox();
            this.lnkLabEsqueceu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(496, 300);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(309, 67);
            this.btnEntrar.TabIndex = 18;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(496, 247);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(309, 35);
            this.txtSenha.TabIndex = 17;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(491, 215);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(95, 29);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "SENHA";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(496, 154);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 35);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(491, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 29);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "E-MAIL";
            // 
            // picEntrar
            // 
            this.picEntrar.Image = global::Projeto3Camadas.Properties.Resources._891372;
            this.picEntrar.Location = new System.Drawing.Point(43, 66);
            this.picEntrar.Name = "picEntrar";
            this.picEntrar.Size = new System.Drawing.Size(404, 384);
            this.picEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEntrar.TabIndex = 19;
            this.picEntrar.TabStop = false;
            // 
            // lnkLabEsqueceu
            // 
            this.lnkLabEsqueceu.AutoSize = true;
            this.lnkLabEsqueceu.Location = new System.Drawing.Point(558, 410);
            this.lnkLabEsqueceu.Name = "lnkLabEsqueceu";
            this.lnkLabEsqueceu.Size = new System.Drawing.Size(172, 20);
            this.lnkLabEsqueceu.TabIndex = 20;
            this.lnkLabEsqueceu.TabStop = true;
            this.lnkLabEsqueceu.Text = "Esqueceu sua senha? ";
            this.lnkLabEsqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabEsqueceu_LinkClicked);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 508);
            this.Controls.Add(this.lnkLabEsqueceu);
            this.Controls.Add(this.picEntrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "Frm_Login";
            this.Text = "Realizar Login";
            ((System.ComponentModel.ISupportInitialize)(this.picEntrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picEntrar;
        private System.Windows.Forms.LinkLabel lnkLabEsqueceu;
    }
}
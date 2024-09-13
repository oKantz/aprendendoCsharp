using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aprendendoWindowForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMensagem = new System.Windows.Forms.Button();
            this.chkGostou = new System.Windows.Forms.CheckBox();
            this.datData = new System.Windows.Forms.DateTimePicker();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMensagem
            // 
            this.btnMensagem.BackColor = System.Drawing.Color.DarkGray;
            this.btnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensagem.Location = new System.Drawing.Point(294, 237);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(266, 130);
            this.btnMensagem.TabIndex = 0;
            this.btnMensagem.Text = "Clique aqui";
            this.btnMensagem.UseVisualStyleBackColor = false;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // chkGostou
            // 
            this.chkGostou.AutoSize = true;
            this.chkGostou.Location = new System.Drawing.Point(294, 373);
            this.chkGostou.Name = "chkGostou";
            this.chkGostou.Size = new System.Drawing.Size(224, 17);
            this.chkGostou.TabIndex = 1;
            this.chkGostou.Text = "Você gostou do nosso aplicativo incrível?";
            this.chkGostou.UseVisualStyleBackColor = true;
            // 
            // datData
            // 
            this.datData.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.datData.Location = new System.Drawing.Point(297, 211);
            this.datData.Name = "datData";
            this.datData.Size = new System.Drawing.Size(263, 20);
            this.datData.TabIndex = 4;
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.BackColor = System.Drawing.Color.DarkGray;
            this.btnProsseguir.Location = new System.Drawing.Point(297, 502);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(263, 39);
            this.btnProsseguir.TabIndex = 5;
            this.btnProsseguir.Text = "Prossiga";
            this.btnProsseguir.UseVisualStyleBackColor = false;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(213, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 168);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(894, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.datData);
            this.Controls.Add(this.chkGostou);
            this.Controls.Add(this.btnMensagem);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou o botão, parabéns amigo!!", "Programa Incrível");
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Olá Mundo");

            frmUsuario frmUsuario = new frmUsuario();
          
            frmUsuario.Show();
        }
    }
}

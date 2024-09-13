namespace aprendendoWindowForms
{
    partial class frmUsuario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobreNome = new System.Windows.Forms.TextBox();
            this.lblSobreNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(218, 135);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(221, 202);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(243, 79);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(288, 132);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Location = new System.Drawing.Point(288, 162);
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.Size = new System.Drawing.Size(176, 20);
            this.txtSobreNome.TabIndex = 3;
            this.txtSobreNome.TextChanged += new System.EventHandler(this.txtSobreNome_TextChanged);
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Location = new System.Drawing.Point(218, 165);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(64, 13);
            this.lblSobreNome.TabIndex = 4;
            this.lblSobreNome.Text = "Sobrenome:";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSobreNome);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblNome);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobreNome;
        private System.Windows.Forms.Label lblSobreNome;
    }
}
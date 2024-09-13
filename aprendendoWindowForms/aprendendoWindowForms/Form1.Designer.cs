namespace aprendendoWindowForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.CheckBox chkGostou;
        private System.Windows.Forms.DateTimePicker datData;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


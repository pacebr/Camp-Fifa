namespace CampFifaTeste1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cb_nj = new System.Windows.Forms.ComboBox();
            this.cb_nj2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(522, 210);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Enter += new System.EventHandler(this.comboBox2_Enter);
            // 
            // cb_nj
            // 
            this.cb_nj.FormattingEnabled = true;
            this.cb_nj.Location = new System.Drawing.Point(263, 82);
            this.cb_nj.Name = "cb_nj";
            this.cb_nj.Size = new System.Drawing.Size(121, 21);
            this.cb_nj.TabIndex = 0;
            this.cb_nj.Enter += new System.EventHandler(this.cb_nj_Enter);
            // 
            // cb_nj2
            // 
            this.cb_nj2.FormattingEnabled = true;
            this.cb_nj2.Location = new System.Drawing.Point(395, 82);
            this.cb_nj2.Name = "cb_nj2";
            this.cb_nj2.Size = new System.Drawing.Size(121, 21);
            this.cb_nj2.TabIndex = 2;
            this.cb_nj2.Enter += new System.EventHandler(this.cb_nj2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_nj2);
            this.Controls.Add(this.cb_nj);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cb_nj;
        private System.Windows.Forms.ComboBox cb_nj2;
    }
}


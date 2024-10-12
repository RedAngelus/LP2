namespace WindowsFormsApp1
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
            this.lraio = new System.Windows.Forms.Label();
            this.laltura = new System.Windows.Forms.Label();
            this.lVOLUME = new System.Windows.Forms.Label();
            this.traio = new System.Windows.Forms.TextBox();
            this.tvolume = new System.Windows.Forms.TextBox();
            this.taltura = new System.Windows.Forms.TextBox();
            this.bsair = new System.Windows.Forms.Button();
            this.bcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lraio
            // 
            this.lraio.AutoSize = true;
            this.lraio.Location = new System.Drawing.Point(113, 81);
            this.lraio.Name = "lraio";
            this.lraio.Size = new System.Drawing.Size(39, 16);
            this.lraio.TabIndex = 0;
            this.lraio.Text = "RAIO";
            // 
            // laltura
            // 
            this.laltura.AutoSize = true;
            this.laltura.Location = new System.Drawing.Point(113, 115);
            this.laltura.Name = "laltura";
            this.laltura.Size = new System.Drawing.Size(61, 16);
            this.laltura.TabIndex = 2;
            this.laltura.Text = "ALTURA";
            // 
            // lVOLUME
            // 
            this.lVOLUME.AutoSize = true;
            this.lVOLUME.Location = new System.Drawing.Point(113, 202);
            this.lVOLUME.Name = "lVOLUME";
            this.lVOLUME.Size = new System.Drawing.Size(63, 16);
            this.lVOLUME.TabIndex = 4;
            this.lVOLUME.Text = "VOLUME";
            // 
            // traio
            // 
            this.traio.Location = new System.Drawing.Point(245, 75);
            this.traio.Name = "traio";
            this.traio.Size = new System.Drawing.Size(100, 22);
            this.traio.TabIndex = 5;
            // 
            // tvolume
            // 
            this.tvolume.Location = new System.Drawing.Point(245, 196);
            this.tvolume.Name = "tvolume";
            this.tvolume.Size = new System.Drawing.Size(100, 22);
            this.tvolume.TabIndex = 7;
            // 
            // taltura
            // 
            this.taltura.Location = new System.Drawing.Point(245, 109);
            this.taltura.Name = "taltura";
            this.taltura.Size = new System.Drawing.Size(100, 22);
            this.taltura.TabIndex = 9;
            // 
            // bsair
            // 
            this.bsair.Location = new System.Drawing.Point(300, 285);
            this.bsair.Name = "bsair";
            this.bsair.Size = new System.Drawing.Size(107, 62);
            this.bsair.TabIndex = 10;
            this.bsair.Text = "SAIR";
            this.bsair.UseVisualStyleBackColor = true;
            this.bsair.Click += new System.EventHandler(this.bsair_Click);
            // 
            // bcalcular
            // 
            this.bcalcular.Location = new System.Drawing.Point(73, 276);
            this.bcalcular.Name = "bcalcular";
            this.bcalcular.Size = new System.Drawing.Size(101, 62);
            this.bcalcular.TabIndex = 12;
            this.bcalcular.Text = "CALCULAR";
            this.bcalcular.UseVisualStyleBackColor = true;
            this.bcalcular.Click += new System.EventHandler(this.bcalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 439);
            this.Controls.Add(this.bcalcular);
            this.Controls.Add(this.bsair);
            this.Controls.Add(this.taltura);
            this.Controls.Add(this.tvolume);
            this.Controls.Add(this.traio);
            this.Controls.Add(this.lVOLUME);
            this.Controls.Add(this.laltura);
            this.Controls.Add(this.lraio);
            this.Name = "Form1";
            this.Text = "Calculo do Volume do Cilidro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lraio;
        private System.Windows.Forms.Label laltura;
        private System.Windows.Forms.Label lVOLUME;
        private System.Windows.Forms.TextBox traio;
        private System.Windows.Forms.TextBox tvolume;
        private System.Windows.Forms.TextBox taltura;
        private System.Windows.Forms.Button bsair;
        private System.Windows.Forms.Button bcalcular;
    }
}


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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blimpar = new System.Windows.Forms.Button();
            this.bcalculo = new System.Windows.Forms.Button();
            this.bsair = new System.Windows.Forms.Button();
            this.mTbpeso = new System.Windows.Forms.MaskedTextBox();
            this.mTbaltura = new System.Windows.Forms.MaskedTextBox();
            this.timc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESO ATUAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IMC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ALTURA";
            // 
            // blimpar
            // 
            this.blimpar.Location = new System.Drawing.Point(165, 156);
            this.blimpar.Name = "blimpar";
            this.blimpar.Size = new System.Drawing.Size(108, 43);
            this.blimpar.TabIndex = 9;
            this.blimpar.Text = "LIMPAR";
            this.blimpar.UseVisualStyleBackColor = true;
            this.blimpar.Click += new System.EventHandler(this.blimpar_Click);
            // 
            // bcalculo
            // 
            this.bcalculo.Location = new System.Drawing.Point(49, 156);
            this.bcalculo.Name = "bcalculo";
            this.bcalculo.Size = new System.Drawing.Size(95, 43);
            this.bcalculo.TabIndex = 11;
            this.bcalculo.Text = "CALCULO";
            this.bcalculo.UseVisualStyleBackColor = true;
            this.bcalculo.Click += new System.EventHandler(this.bcalculo_Click);
            // 
            // bsair
            // 
            this.bsair.Location = new System.Drawing.Point(297, 156);
            this.bsair.Name = "bsair";
            this.bsair.Size = new System.Drawing.Size(107, 43);
            this.bsair.TabIndex = 13;
            this.bsair.Text = "SAIR";
            this.bsair.UseVisualStyleBackColor = true;
            this.bsair.Click += new System.EventHandler(this.bsair_Click);
            // 
            // mTbpeso
            // 
            this.mTbpeso.Location = new System.Drawing.Point(211, 33);
            this.mTbpeso.Mask = "&&&.&&";
            this.mTbpeso.Name = "mTbpeso";
            this.mTbpeso.Size = new System.Drawing.Size(100, 22);
            this.mTbpeso.TabIndex = 15;
            // 
            // mTbaltura
            // 
            this.mTbaltura.Location = new System.Drawing.Point(211, 69);
            this.mTbaltura.Mask = "0.000";
            this.mTbaltura.Name = "mTbaltura";
            this.mTbaltura.Size = new System.Drawing.Size(100, 22);
            this.mTbaltura.TabIndex = 19;
            // 
            // timc
            // 
            this.timc.Location = new System.Drawing.Point(211, 110);
            this.timc.Name = "timc";
            this.timc.Size = new System.Drawing.Size(100, 22);
            this.timc.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 230);
            this.Controls.Add(this.timc);
            this.Controls.Add(this.mTbaltura);
            this.Controls.Add(this.mTbpeso);
            this.Controls.Add(this.bsair);
            this.Controls.Add(this.bcalculo);
            this.Controls.Add(this.blimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button blimpar;
        private System.Windows.Forms.Button bcalculo;
        private System.Windows.Forms.Button bsair;
        private System.Windows.Forms.MaskedTextBox mTbpeso;
        private System.Windows.Forms.MaskedTextBox mTbaltura;
        private System.Windows.Forms.TextBox timc;
    }
}


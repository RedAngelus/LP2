namespace atividade7
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
            this.bexercicio1 = new System.Windows.Forms.Button();
            this.bexercicio2 = new System.Windows.Forms.Button();
            this.bexercicio3 = new System.Windows.Forms.Button();
            this.bexercicio4 = new System.Windows.Forms.Button();
            this.bexercicio5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bexercicio1
            // 
            this.bexercicio1.Location = new System.Drawing.Point(166, 44);
            this.bexercicio1.Name = "bexercicio1";
            this.bexercicio1.Size = new System.Drawing.Size(163, 119);
            this.bexercicio1.TabIndex = 0;
            this.bexercicio1.Text = "Exercicio 1";
            this.bexercicio1.UseVisualStyleBackColor = true;
            this.bexercicio1.Click += new System.EventHandler(this.bexercicio1_Click);
            // 
            // bexercicio2
            // 
            this.bexercicio2.Location = new System.Drawing.Point(401, 44);
            this.bexercicio2.Name = "bexercicio2";
            this.bexercicio2.Size = new System.Drawing.Size(163, 119);
            this.bexercicio2.TabIndex = 1;
            this.bexercicio2.Text = "Exercicio 2";
            this.bexercicio2.UseVisualStyleBackColor = true;
            this.bexercicio2.Click += new System.EventHandler(this.bexercicio2_Click);
            // 
            // bexercicio3
            // 
            this.bexercicio3.Location = new System.Drawing.Point(166, 174);
            this.bexercicio3.Name = "bexercicio3";
            this.bexercicio3.Size = new System.Drawing.Size(163, 119);
            this.bexercicio3.TabIndex = 2;
            this.bexercicio3.Text = "Exercicio 3";
            this.bexercicio3.UseVisualStyleBackColor = true;
            this.bexercicio3.Click += new System.EventHandler(this.bexercicio3_Click);
            // 
            // bexercicio4
            // 
            this.bexercicio4.Location = new System.Drawing.Point(401, 174);
            this.bexercicio4.Name = "bexercicio4";
            this.bexercicio4.Size = new System.Drawing.Size(163, 119);
            this.bexercicio4.TabIndex = 3;
            this.bexercicio4.Text = "Exercicio 4";
            this.bexercicio4.UseVisualStyleBackColor = true;
            // 
            // bexercicio5
            // 
            this.bexercicio5.Location = new System.Drawing.Point(277, 299);
            this.bexercicio5.Name = "bexercicio5";
            this.bexercicio5.Size = new System.Drawing.Size(163, 119);
            this.bexercicio5.TabIndex = 4;
            this.bexercicio5.Text = "Exercicio 5";
            this.bexercicio5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bexercicio5);
            this.Controls.Add(this.bexercicio4);
            this.Controls.Add(this.bexercicio3);
            this.Controls.Add(this.bexercicio2);
            this.Controls.Add(this.bexercicio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bexercicio1;
        private System.Windows.Forms.Button bexercicio2;
        private System.Windows.Forms.Button bexercicio3;
        private System.Windows.Forms.Button bexercicio4;
        private System.Windows.Forms.Button bexercicio5;
    }
}


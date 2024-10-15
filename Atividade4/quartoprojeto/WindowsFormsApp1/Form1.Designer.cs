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
            this.tLadoA = new System.Windows.Forms.TextBox();
            this.tLadoB = new System.Windows.Forms.TextBox();
            this.tLadoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bexecutar = new System.Windows.Forms.Button();
            this.bsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tLadoA
            // 
            this.tLadoA.Location = new System.Drawing.Point(207, 24);
            this.tLadoA.Name = "tLadoA";
            this.tLadoA.Size = new System.Drawing.Size(100, 22);
            this.tLadoA.TabIndex = 0;
            // 
            // tLadoB
            // 
            this.tLadoB.Location = new System.Drawing.Point(207, 94);
            this.tLadoB.Name = "tLadoB";
            this.tLadoB.Size = new System.Drawing.Size(100, 22);
            this.tLadoB.TabIndex = 4;
            // 
            // tLadoC
            // 
            this.tLadoC.Location = new System.Drawing.Point(207, 166);
            this.tLadoC.Name = "tLadoC";
            this.tLadoC.Size = new System.Drawing.Size(100, 22);
            this.tLadoC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "LADO A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "LADO B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "LADO C";
            // 
            // bexecutar
            // 
            this.bexecutar.Location = new System.Drawing.Point(71, 247);
            this.bexecutar.Name = "bexecutar";
            this.bexecutar.Size = new System.Drawing.Size(104, 42);
            this.bexecutar.TabIndex = 12;
            this.bexecutar.Text = "EXECUTAR";
            this.bexecutar.UseVisualStyleBackColor = true;
            this.bexecutar.Click += new System.EventHandler(this.bexecutar_Click);
            // 
            // bsair
            // 
            this.bsair.Location = new System.Drawing.Point(207, 247);
            this.bsair.Name = "bsair";
            this.bsair.Size = new System.Drawing.Size(75, 42);
            this.bsair.TabIndex = 14;
            this.bsair.Text = "SAIR";
            this.bsair.UseVisualStyleBackColor = true;
            this.bsair.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 353);
            this.Controls.Add(this.bsair);
            this.Controls.Add(this.bexecutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tLadoC);
            this.Controls.Add(this.tLadoB);
            this.Controls.Add(this.tLadoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tLadoA;
        private System.Windows.Forms.TextBox tLadoB;
        private System.Windows.Forms.TextBox tLadoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bexecutar;
        private System.Windows.Forms.Button bsair;
    }
}


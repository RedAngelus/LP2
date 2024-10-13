using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bcalculo_Click(object sender, EventArgs e)
        {
            double PAtual, Altu, Imc;

            PAtual = Convert.ToDouble(mTbpeso.Text);
            Altu = Convert.ToDouble(mTbaltura.Text);

            Imc = PAtual / (Altu * Altu);

            if (Imc <  18.5)
            {
                timc.Text = Convert.ToString(Imc);
                MessageBox.Show("Magreza \n obesidade grau 0");

            }
            else
            {
                if (Imc < 25)
                {
                    timc.Text = Convert.ToString(Imc);
                    MessageBox.Show("Normal \n obesidade gra 0");
                }
                else 
                {
                    if (Imc < 30)
                    {
                        timc.Text = Convert.ToString(Imc);
                        MessageBox.Show("Sobrepeso \n obesidade gra 1");
                    }
                    else if (Imc < 40)
                    {
                        timc.Text = Convert.ToString(Imc);
                        MessageBox.Show("Obesidade \n obesidade gra 2");
                    }
                    else
                    {
                        timc.Text = Convert.ToString(Imc);
                        MessageBox.Show("Obesidade grave \n obesidade gra 3");
                    }
                }
            }
        }

        private void blimpar_Click(object sender, EventArgs e)
        {
            mTbaltura.Text = string.Empty;
            mTbpeso.Text = string.Empty;
            timc.Text = string.Empty;

        }

        private void bsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

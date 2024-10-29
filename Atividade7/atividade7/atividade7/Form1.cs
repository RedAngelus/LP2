using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections;

namespace atividade7
{
    public partial class Form1 : Form
    {
        string auxiliar = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void bexercicio1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];

            auxiliar = "";

            for (int i = 0; i < 20;  i++)
            {
                auxiliar = Interaction.InputBox("Digite o numero.", "Entrada de Dados.");

                if (!int.TryParse(auxiliar, out Vetor[i]))
                {
                    MessageBox.Show("numero invalido!");
                    i--;
                }
            }

            Array.Reverse(Vetor);
            auxiliar = " ";
            foreach (int x in Vetor)
            {
                auxiliar += x + "\n";
            }

            MessageBox.Show(auxiliar);
        }

        private void bexercicio2_Click(object sender, EventArgs e)
        {
            ArrayList Lista = new ArrayList()
            {
                "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"
            };
            Lista.Remove("Otávio");
            foreach (string x in Lista)
            {
                auxiliar += x + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void bexercicio3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] media = new double[20];
            auxiliar = "";

            for ( int i = 0; i < 20; i++)
            {
                for ( int j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota " + (j+1), "Nota do aluno " + (i+1));

                    if (!double.TryParse(auxiliar, out notas[i, j] ))
                    {
                        MessageBox.Show("Valor invalido");
                        j--;
                    }
                    else if (notas[i, j] < 0 || notas[i, j] > 10)
                    {
                        MessageBox.Show("Inserir um valor entre 0 a 10");
                        j--;
                    }
                    else
                    media[i] = notas[i, j] + notas[i, j] + notas[i, j];
                }
                media[i] = media[i] / 3;

                foreach ( double y in media ) 

                auxiliar = auxiliar + "nota do aluno " + (i + 1) + ": " + media[] + "\n";
            }
            MessageBox.Show(auxiliar);
        }
    }
}

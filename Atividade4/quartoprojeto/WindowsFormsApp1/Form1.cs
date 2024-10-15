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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bexecutar_Click(object sender, EventArgs e)
        {
            float A, B, C;

            A = Convert.ToSingle(tLadoA.Text);
            B = Convert.ToSingle(tLadoB.Text);
            C = Convert.ToSingle(tLadoC.Text);

            if (A + B >= C &&  B + C >= A && C + A >= B)
            {
                if (A == B && B == C && A == C)
                {
                    MessageBox.Show("triangulo equilatero");
                }
                else if (A != B && B != C && A != C)
                {
                    MessageBox.Show("triangulo escaleno");
                }
                else
                {
                    MessageBox.Show("triangulo isósceles");
                }
            }
            else
            {
                MessageBox.Show("não é triangulo ");
            }
        }
    }
}

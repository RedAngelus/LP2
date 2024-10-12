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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bcalcular_Click(object sender, EventArgs e)
        {
            double Alt, Raio, Vol;
            Alt = Convert.ToDouble (taltura.Text);
            Raio = Convert.ToDouble (traio.Text);

            Vol = 3.14 * (Raio * Raio) * Alt;

            tvolume.Text = Convert.ToString (Vol);
            
        }
    }
}

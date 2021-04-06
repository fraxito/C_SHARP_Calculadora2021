using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void botonPulsado(object sender, EventArgs e)
        {
            Button boton = (Button) sender;
            if (label1.Text == "0")
            {
                label1.Text = boton.Text;
            }
            else 
            {
                label1.Text = label1.Text + boton.Text;
            }
        }
    }
}

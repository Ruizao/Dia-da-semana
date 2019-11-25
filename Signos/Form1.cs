using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signos
{
    public partial class Form1 : Form
    {


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public Form1()
        {
            InitializeComponent();
        }


        diadasemana dia = new diadasemana();

        private void Button1_Click_1(object sender, EventArgs e)
        {
            dia.recebe = textBox1.Text;
            label3.Text = dia.envia;
        }
    }
}
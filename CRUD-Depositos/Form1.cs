using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Depositos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshPantalla();
        }
        public void refreshPantalla() {
            DGResultado.DataSource = VDatos.presetarLista();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombreFiltro.Text = comboBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

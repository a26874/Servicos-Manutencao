using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAAD
{
    public partial class Interface : Form
    {
        private SQL baseDados;
        public Interface()
        {
            InitializeComponent();

            baseDados = new SQL("MARCO\\MARCO","MARCO\\marco","ProjetoAAD");
            if (baseDados.Conectar())
                MessageBox.Show("Conectado");
            else
                MessageBox.Show("Falha na conexão");
        }

        private void InserirDadosButton_Click(object sender, EventArgs e)
        {
            baseDados.InsereDados("asdsda");
        }

        private void MostrarDadosButton_Click(object sender, EventArgs e)
        {
            dataGridDados.DataSource = null;
            dataGridDados = baseDados.MostrarDados("CodigoPostal");
            this.Refresh();
        }

    }
}

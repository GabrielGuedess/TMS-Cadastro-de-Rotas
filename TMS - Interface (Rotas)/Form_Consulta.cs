using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace TMS___Interface__Rotas_
{
    public partial class Form_Consulta : Form
    {
        public Form_Consulta()
        {
            InitializeComponent();
        }
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (txtBox_IDRota.Text != "")
            {
                dataGridView1.Visible = true;

                string SQL = $"SELECT * FROM [Rotas] WHERE ID_Rota = '{txtBox_IDRota.Text}'";

                DataTable dados = Metodos.ConnectionDBAndSQLData(@"DB\Banco_de_dados.mdb", groupBox1, SQL);

                dataGridView1.DataSource = dados;
            }
            else
            {
                MessageBox.Show("Insira um valor no campo.");
            }
        }
        private void btn_Todos_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            string SQL = $"SELECT * FROM [Rotas]";

            DataTable dados = Metodos.ConnectionDBAndSQLData(@"DB\Banco_de_dados.mdb", groupBox1, SQL);

            dataGridView1.DataSource = dados;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Form_Consulta formulario_Consulta = new Form_Consulta();

            this.Close();
            formulario_Consulta.Close();
        }
    }
}

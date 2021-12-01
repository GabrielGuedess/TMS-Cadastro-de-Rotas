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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();

            if (MessageBox.Show("Deseja sair da aplicação?", "Saída", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                formulario.Close();
            }
        }

        public void FillComboBox(string pathDB, ComboBox comboBox, string SQL, string category)
        {
            try
            {
                OleDbConnection connec = new OleDbConnection($@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {Application.StartupPath}\{pathDB}");

                OleDbCommand cmd = new OleDbCommand();

                connec.Open();

                cmd.Connection = connec;

                cmd.CommandText = SQL;

                OleDbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox.Items.Add(dr[category]);
                }

                dr.Close();

                connec.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro: {err.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string SQLMotoristas = "SELECT * FROM [Motoristas]";

            string SQLVeiculos = "SELECT * FROM [(D)tbVeículos]";

            FillComboBox(@"DB\Banco_de_dados.mdb", cmbBox_Moto, SQLMotoristas, "Nome");
            FillComboBox(@"DB\Banco_de_dados.mdb", cmbBox_Veiculo, SQLVeiculos, "Modelo");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar os dados informados?", "Salvar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idRota, statusVi, progresso, proxEnt, conhecimento, entrega, motorista, veiculo;

                idRota = txtBox_IDRota.Text;
                statusVi = txtBox_StatusVi.Text;
                progresso = txtBox_Progresso.Text;
                int distTotal = int.Parse(txtBox_DistTotal.Text);
                proxEnt = txtBox_ProxEnt.Text;
                int custo = int.Parse(txtBox_Custo.Text);
                conhecimento = txtBox_Conhecimento.Text;
                entrega = txtBox_Entrega.Text;
                motorista = cmbBox_Moto.SelectedItem.ToString();
                veiculo = cmbBox_Veiculo.SelectedItem.ToString();

                if (Metodos.ValidateDB("ID_Rota", "Rotas", idRota))
                {
                    string SQL = $"Insert Into [Rotas](ID_Rota, Entrega, Motorista, Veiculos, S_Viagem, Progresso, D_Total, P_Destino, C_Estimado, C_Trasp) Values ('{idRota}', '{entrega}', '{motorista}', '{veiculo}', '{statusVi}', '{progresso}', '{distTotal}', '{proxEnt}', '{custo}', '{conhecimento}')";

                    Metodos.ConnectionDBAndSQL(@"DB\Banco_de_dados.mdb", groupBox1, SQL);
                }
                else
                {
                    MessageBox.Show("Erro: Essa Rota já existe");
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar os dados informados?", "Atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idRota, statusVi, progresso, proxEnt, conhecimento, entrega, motorista, veiculo;

                idRota = txtBox_IDRota.Text;
                statusVi = txtBox_StatusVi.Text;
                progresso = txtBox_Progresso.Text;
                int distTotal = int.Parse(txtBox_DistTotal.Text);
                proxEnt = txtBox_ProxEnt.Text;
                int custo = int.Parse(txtBox_Custo.Text);
                conhecimento = txtBox_Conhecimento.Text;
                entrega = txtBox_Entrega.Text;
                motorista = cmbBox_Moto.SelectedItem.ToString();
                veiculo = cmbBox_Veiculo.SelectedItem.ToString();

                if (Metodos.ValidateDB("ID_Rota", "Rotas", idRota))
                {
                    MessageBox.Show("Erro: Esse ID não existe");
                }
                else
                {
                    string SQL = $"UPDATE [Rotas] SET Entrega = '{entrega}', Motorista = '{motorista}', Veiculos = '{veiculo}', S_Viagem = '{statusVi}', Progresso = '{progresso}', D_Total = '{distTotal}', P_Destino = '{proxEnt}', C_Estimado = '{custo}', C_Trasp = '{conhecimento}' WHERE ID_Rota = '{idRota}'";

                    Metodos.ConnectionDBAndSQL(@"DB\Banco_de_dados.mdb", groupBox1, SQL, true, "Dados atualizados com sucesso.");
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir os dados informados?", "Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string idRota = txtBox_IDRota.Text;

                if (idRota != "")
                {
                    if (Metodos.ValidateDB("ID_Rota", "Rotas", idRota))
                    {
                        MessageBox.Show("Erro: Esse ID não existe");
                    }
                    else
                    {
                        string SQL = $"DELETE from [Rotas] where ID_Rota = '{idRota}'";

                        Metodos.ConnectionDBAndSQL(@"DB\Banco_de_dados.mdb", groupBox1, SQL, true, "Dados Excluídos com sucesso.");
                    }
                }
                else
                {
                    MessageBox.Show("Erro: Informe um ID para excluir");
                }
            }
        }

        private void btn_Consult_Click(object sender, EventArgs e)
        {
            Form_Consulta formulario_Consulta = new Form_Consulta();

            this.Show();
            formulario_Consulta.Show();
        }
    }
}

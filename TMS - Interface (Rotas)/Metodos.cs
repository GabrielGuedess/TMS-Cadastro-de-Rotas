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
    public class Metodos
    {
        public static void ClearAll(GroupBox control)
        {
            foreach (TextBox textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }
            foreach (ComboBox comboBox in control.Controls.OfType<ComboBox>())
            {
                comboBox.SelectedIndex = -1;
            }
        }

        public static bool ValidateDB(string name, string tabela, string value)
        {
            try
            {
                OleDbConnection connec = new OleDbConnection($@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {Application.StartupPath}\DB\Banco_de_dados.mdb");

                OleDbCommand cmd = new OleDbCommand();

                connec.Open();

                cmd.Connection = connec;

                cmd.CommandText = $"SELECT {name} FROM [{tabela}] WHERE {name} = '{value}'";

                OleDbDataReader dr = cmd.ExecuteReader();

                List<string> list = new List<string>();

                while (dr.Read())
                {
                    list.Add(dr[name].ToString());
                }

                connec.Dispose();

                dr.Close();

                string[] listArray = list.ToArray();

                if (listArray.Length > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro: {err.Message}");
                return true;
            }
        }


        public static void ConnectionDBAndSQL(string pathDB, GroupBox groupBoxCleaned, string SQL, bool hasMessage = true, string messageSuccess = "Dados gravados com sucesso.")
        {
            try
            {
                OleDbConnection connec = new OleDbConnection($@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {Application.StartupPath}\{pathDB}");

                connec.Open();

                OleDbCommand comando = new OleDbCommand(SQL, connec);

                comando.ExecuteNonQuery();

                ClearAll(groupBoxCleaned);

                if (hasMessage)
                {
                    MessageBox.Show(messageSuccess);
                }

                connec.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro: {err.Message}");
            }
        }

        public static DataTable ConnectionDBAndSQLData(string pathDB, GroupBox groupBoxCleaned, string SQL)
        {
            try
            {
                OleDbConnection connec = new OleDbConnection($@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {Application.StartupPath}\{pathDB}");

                connec.Open();

                OleDbCommand comando = new OleDbCommand(SQL, connec);

                comando.ExecuteNonQuery();

                DataTable dados = new DataTable();

                OleDbDataAdapter adapt = new OleDbDataAdapter(SQL, $@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {Application.StartupPath}\{pathDB}");

                adapt.Fill(dados);

                Metodos.ClearAll(groupBoxCleaned);

                connec.Dispose();

                return dados;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro: {err.Message}");
                return null;
            }
        }
    }
}

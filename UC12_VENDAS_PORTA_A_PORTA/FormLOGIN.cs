using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_VENDAS_PORTA_A_PORTA
{
    public partial class FormLOGIN : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormLOGIN()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=porta_a_porta;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM login WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    Form TELAESCOLHA = new FormTELAESCOLHA();
                    TELAESCOLHA.Show();
                }
                else
                {
                    MessageBox.Show("Usuario e/ou senha incorretos");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

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
    public partial class FormCADASTROPRODUTOS : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormCADASTROPRODUTOS()
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
                comando.CommandText = "INSERT INTO cadastro_produtos(produto, marca, tipo, quantidade) VALUES ('" + textBoxPRODUTO.Text + "', '" + textBoxMARCA.Text + "', '" + textBoxTIPO.Text + "', '" + textBoxQUANTIDADE.Text + "'); ";
                comando.ExecuteNonQuery();
                MessageBox.Show("cadastrado");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao cadastrar, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

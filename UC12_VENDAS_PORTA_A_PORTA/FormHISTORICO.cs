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
    public partial class FormHISTORICO : Form
    {

        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormHISTORICO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=porta_a_porta;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            atualizar_dataGRID();
        }

        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, produto, hora FROM vendas inner join vendas_realizadas on (vendas_realizadas.fk_vendas = vendas.id) INNER JOIN cadastro_produtos on (vendas.fk_produto = cadastro_produtos.id) INNER JOIN cadastro_clientes on (vendas.fk_cliente = cadastro_clientes.id) ORDER BY hora DESC;";

                MySqlDataAdapter adaptadorPESQUISA = new MySqlDataAdapter(comando);

                DataTable tabelaAGENDA = new DataTable();
                adaptadorPESQUISA.Fill(tabelaAGENDA);

                dataGridViewPESQUISA.DataSource = tabelaAGENDA;
                dataGridViewPESQUISA.Columns["usuario"].HeaderText = "Nome";
                dataGridViewPESQUISA.Columns["produto"].HeaderText = "Produto";
                dataGridViewPESQUISA.Columns["hora"].HeaderText = "Hora";
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonPESQUISAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, produto, hora FROM tbl_agenda WHERE nome LIKE '" + textBoxPESQUISA.Text + "'% OR produto LIKE '" + textBoxPESQUISA.Text + "'% OR hora LIKE '" + textBoxPESQUISA.Text + "'%;";

                MySqlDataAdapter adaptadorPESQUISA = new MySqlDataAdapter(comando);

                DataTable tabelaAGENDA = new DataTable();
                adaptadorPESQUISA.Fill(tabelaAGENDA);

                dataGridViewPESQUISA.DataSource = tabelaAGENDA;
                dataGridViewPESQUISA.Columns["usuario"].HeaderText = "Nome";
                dataGridViewPESQUISA.Columns["produto"].HeaderText = "Produto";
                dataGridViewPESQUISA.Columns["hora"].HeaderText = "Data";
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

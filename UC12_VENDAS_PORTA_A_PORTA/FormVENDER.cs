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
    public partial class FormVENDER : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        int numero = 0;
        private DataSet tabelaUSUARIOS;

        public FormVENDER()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=porta_a_porta;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            labelNUMERO.Enabled = false;
            textBoxUSUARIO.Enabled = false;

            atualizar_dataLABELNUMEROS();
            atualizar_dataGRIDUSUARIOS();
            atualizar_dataGRIDPRODUTOS();
        }

        private void atualizar_dataLABELNUMEROS()
        {
            try
            {
                conexao.Open();
                labelNUMERO.Text = numero.ToString();

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

        private void atualizar_dataGRIDUSUARIOS()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario FROM cadastro_clientes;";

                MySqlDataAdapter adaptadorUSUARIOS = new MySqlDataAdapter(comando);

                DataTable tabelaUSUARIOS = new DataTable();
                adaptadorUSUARIOS.Fill(tabelaUSUARIOS);

                dataGridViewUSUARIOS.DataSource = tabelaUSUARIOS;
                dataGridViewUSUARIOS.Columns["usuario"].HeaderText = "Usuários";
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

        private void atualizar_dataGRIDPRODUTOS()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT produto, quantidade FROM cadastro_produtos;";

                MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

                DataTable tabelaPRODUTOS = new DataTable();
                adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

                dataGridViewPRODUTOS.DataSource = tabelaPRODUTOS;
                dataGridViewPRODUTOS.Columns["produto"].HeaderText = "Produtos";
                dataGridViewPRODUTOS.Columns["quantidade"].HeaderText = "Quantia";

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

        private void buttonCOMPRAR_Click(object sender, EventArgs e)
        {
            try
            {

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

        private void label2_Click(object sender, EventArgs e)
        {
            numero = numero + 1;
            atualizar_dataLABELNUMEROS();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            numero = numero - 1;
            atualizar_dataLABELNUMEROS();
        }

        private void dataGridViewUSUARIOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conexao.Open();
            comando.CommandText = "SELECT * FROM tbl_agenda ORDER BY nome ASC;";

            MySqlDataAdapter adaptadorUSUARIOS = new MySqlDataAdapter(comando);

            DataTable tabelaUSSARIOS = new DataTable();
            adaptadorUSUARIOS.Fill(tabelaUSUARIOS);

            dataGridViewUSUARIOS.DataSource = tabelaUSUARIOS;
            dataGridViewUSUARIOS.Columns["id"].HeaderText = "ID";
        }

        private void dataGridViewPRODUTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conexao.Open();
            comando.CommandText = "SELECT * FROM tbl_agenda ORDER BY nome ASC;";

            MySqlDataAdapter adaptadorPRODUTOS = new MySqlDataAdapter(comando);

            DataTable tabelaPRODUTOS = new DataTable();
            adaptadorPRODUTOS.Fill(tabelaPRODUTOS);

            dataGridViewPRODUTOS.DataSource = tabelaPRODUTOS;
            dataGridViewPRODUTOS.Columns["id"].HeaderText = "ID";
            dataGridViewPRODUTOS.Columns["nome"].HeaderText = "NOME";
        }
    }
}

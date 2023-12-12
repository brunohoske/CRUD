using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace CRUD___Lógica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConexaoCliente conexao = new ConexaoCliente();
        string tabela = "cliente";
        private void Form1_Load(object sender, EventArgs e)
        {
            ExibirClientes();
        }

        public void ExibirClientes()
        {
            string sql = $"SELECT * FROM {tabela}";
            DataTable dt = conexao.ExecutarConsulta(sql);
            dtCliente.DataSource = dt.AsDataView();
        }

        public void LimpaCampos()
        {
            lblId.Text = "";
            txtNome.Clear();
            txtNumero.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();

        }

        private void txtSalvar_Click(object sender, EventArgs e)
        {
            int numero;
            string sql = $"INSERT INTO {tabela} VALUES(Default,'{txtNome.Text}','{txtLogradouro.Text}',{txtNumero.Text},'{txtBairro.Text}','{txtCidade.Text}','{txtEstado.Text}')";
            if (txtNome.Text != "" && int.TryParse(txtNumero.Text, out numero))
            {
                int resultado = conexao.ExcutarComando(sql);
                if (resultado == 1)
                {
                    MessageBox.Show("Dados salvos com sucesso");
                    LimpaCampos();
                    ExibirClientes();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar os dados. Confira os valores");
                }
            }
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            ExibirClientes();
        }



        private void dtCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dtCliente.Rows[e.RowIndex].Cells[0].Value.ToString(); //Pega a linha clicada, depois o valor da coluna 0 da linha clicada
            txtNome.Text = dtCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLogradouro.Text = dtCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNumero.Text = dtCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBairro.Text = dtCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCidade.Text = dtCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEstado.Text = dtCliente.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void txtApagar_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "")
            {
                string deletar = $"DELETE FROM {tabela} WHERE id = {lblId.Text}";
                int resultado = conexao.ExcutarComando(deletar);

                if (resultado == 1)
                {
                    MessageBox.Show("Dado deletado com sucesso");
                    LimpaCampos();
                    ExibirClientes();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar os dados");
                }
            }
        }

        private void txtAtualizar_Click(object sender, EventArgs e)
        {
            int numero;
           string sql =  $"UPDATE {tabela} SET NOME = '{txtNome.Text}',logradouro = '{txtLogradouro.Text}', numero = {txtNumero.Text}, bairro = '{txtBairro.Text}', Cidade = '{txtCidade.Text}', ESTADO = '{txtEstado.Text}' where id = {lblId.Text}";
            if (txtNome.Text != "" && int.TryParse(txtNumero.Text, out numero))
            {
                int resultado = conexao.ExcutarComando(sql);
                if (resultado == 1)
                {
                    MessageBox.Show("Dados salvos com sucesso");
                    LimpaCampos();
                    ExibirClientes();
                }
                else
                {
                    MessageBox.Show("Erro ao salvar os dados. Confira os valores");
                }
            }
        }
    }
}

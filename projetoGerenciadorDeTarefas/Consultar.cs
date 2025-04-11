using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoGerenciadorDeTarefas
{
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();//configuro a estrutura da coluna e linha
            NomeColunas();//nomeando colunas
            AdicionarDados();//adicionar os dados para visualizar
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim botão voltar

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.Show();
            atu.BringToFront();
            atu.Focus();
            atu.Activate(); // Isso garante que ela venha pra frente

            this.Close();
        }//fim do botão editar

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do data grid view

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Titulo tarefa";
            dataGridView1.Columns[3].Name = "Descrição tarefa";
            dataGridView1.Columns[4].Name = "Prioridade tarefa";
            dataGridView1.Columns[5].Name = "Vencimento tarefa";
            dataGridView1.Columns[6].Name = "Andamento tarefa";
        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//não pode adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//não pode apagar linhas
            dataGridView1.AllowUserToResizeColumns = false;//não pode redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//não pode redimensionar as linhas

            dataGridView1.ColumnCount = 7;
        }//Fim do método de configuração

        public void AdicionarDados()
        {
            consul.PreencherVetor();//preencher os vetores com dados do banco de dados
            for (int i = 0; i < consul.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.nome[i], consul.tituloTarefa[i], consul.descTarefa[i] , consul.prioridade[i], consul.vencimento[i], consul.andamentoTarefa[i]);
            }//fim do for

        }//fim do método adicionar dados


    }
}

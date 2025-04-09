using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetoGerenciadorDeTarefas
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim titulo cadastrar

        private void label2_Click(object sender, EventArgs e)
        {

        }//fim label

        private void label3_Click(object sender, EventArgs e)
        {

        }//fim label

        private void label5_Click(object sender, EventArgs e)
        {

        }//fim label

        private void label4_Click(object sender, EventArgs e)
        {

        }//fim label

        private void label8_Click(object sender, EventArgs e)
        {

        }//fim da label

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Fim botão voltar

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificando se algum campo está em branco
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Impede o cadastro
            }

            // Instanciando a classe
            DAO inserir = new DAO();

            // Coletando os dados dos campos
            int codigo = Convert.ToInt32(maskedTextBox1.Text);
            string nome = textBox2.Text;
            string tituloTarefa = textBox3.Text;
            string descTarefa = textBox4.Text;
            string prioridade = comboBox1.Text;
            string vencimento = dateTimePicker1.Text;
            string andamentoTarefa = comboBox2.Text;

            // Chamando o método inserir
            MessageBox.Show(inserir.Inserir(codigo, nome, tituloTarefa, descTarefa, prioridade, vencimento, andamentoTarefa));
            this.Close(); // Fechar janela cadastrar
        }//Fim botão cadastrar

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da caixa código

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa titulo da tarefa

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa descrição da tarefa

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }//fim da caixa prioridade

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }//fim da caixa data de vencimento

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//fim da caixa status tarefa
    }
}

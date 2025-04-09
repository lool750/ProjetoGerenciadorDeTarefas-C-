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
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            atu = new DAO();
            InitializeComponent();
            maskedTextBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            this.Close();
        }//fim do botão voltar

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                textBox2.Text = "Informe o código";
                textBox3.Text = "Informe o código";
                textBox4.Text = "Informe o código";
                comboBox1.Text = "Informe o código";
                //dateTimePicker1.Text = "Informe o código";
                comboBox2.Text = "Informe o código";
            }
            else
            {
                int codigo = Convert.ToInt32(maskedTextBox1.Text);//coletando o código

                textBox2.Text = atu.RetornarNome(codigo);//Preenchendo o campo nome
                textBox3.Text = atu.RetornarTituloTarefa(codigo);//Preenchendo o campo telefone
                textBox4.Text = atu.RetornarDescTarefa(codigo);//Preenchendo o campo endereço
                comboBox1.Text = atu.RetornarPrioridadeTarefa(codigo);//preenchendo o campo de prioridade                                              //
                dateTimePicker1.Text = atu.RetornarDataVencimento(codigo);//preenchendo o campo de vencimento 
                comboBox2.Text = atu.RetornarAndamentoTarefa(codigo);//preenchendo o campo de vencimento

                maskedTextBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                comboBox1.Enabled = true;
                //dateTimePicker1.ReadOnly = false;
                comboBox2.Enabled = true;
            }
        }//fim do botão buscar

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se algum campo está vazio
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de atualizar.",
                                "Campos obrigatórios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Sai do método sem atualizar
            }

            // Se todos os campos estiverem preenchidos, segue com a atualização
            int codigo = Convert.ToInt32(maskedTextBox1.Text);
            string nome = textBox2.Text;
            string tituloTarefa = textBox3.Text;
            string descTarefa = textBox4.Text;
            string prioridade = comboBox1.Text;
            string vencimento = dateTimePicker1.Text;
            string andamentoTarefa = comboBox2.Text;

            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "tituloTarefa", tituloTarefa);
            atu.Atualizar(codigo, "descTarefa", descTarefa);
            atu.Atualizar(codigo, "prioridade", prioridade);
            atu.Atualizar(codigo, "vencimento", vencimento);
            atu.Atualizar(codigo, "andamentoTarefa", andamentoTarefa);

            // Modal de sucesso mais bonito
            MessageBox.Show(" Os dados foram atualizados com sucesso!",
                            "Atualização Concluída",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.Close();
        }//fim do botão Atualizar

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//caixa prioridade

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//caixa status da tarefa

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }//caixa vencimento
    }
}

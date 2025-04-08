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
                dateTimePicker1.Text = "Informe o código";
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
               /*omboBox1.ReadOnly = false;
                dateTimePicker1.ReadOnly = false;
                comboBox2.ReadOnly = false;*/
            }
        }//fim do botão buscar

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(maskedTextBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "tituloTarefa", telefone);
            atu.Atualizar(codigo, "descTarefa", endereco);
            MessageBox.Show("Dados Atualizados com Sucesso");
            this.Close();
        }//fim do botão Atualizar

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

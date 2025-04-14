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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a tela atual
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog(); // Espera até a tela de cadastro ser fechada
            this.Show(); // Volta a mostrar a tela anterior (Menu)

        }//fim do botão cadastrar tarefas

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a tela atual
            Consultar con = new Consultar();
            con.ShowDialog(); // Espera até a tela de cadastro ser fechada
            this.Show(); // Volta a mostrar a tela anterior (Menu)

        }//fim do botão consultar tarefas

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim titulo menu

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a tela atual
            Atualizar atu = new Atualizar();
            atu.ShowDialog(); // Espera até a tela de cadastro ser fechada
            this.Show(); // Volta a mostrar a tela anterior (Menu)
        }//fim botão Atualizar tarefas

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // Esconde a tela atual
            Excluir exc = new Excluir();
            exc.ShowDialog(); // Espera até a tela de cadastro ser fechada
            this.Show(); // Volta a mostrar a tela anterior (Menu)
        }//Fim botão excluir tarefas

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

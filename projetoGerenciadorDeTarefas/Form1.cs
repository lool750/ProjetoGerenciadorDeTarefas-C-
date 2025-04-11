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
            Cadastrar cad = new Cadastrar();
            this.Visible = false;
            cad.ShowDialog();
            
        }//fim do botão cadastrar tarefas

        

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();
            con.Show();

        }//fim do botão consultar tarefas

        private void label1_Click(object sender, EventArgs e)
        {

        }//fim titulo menu

        private void button3_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();
        }//fim botão Atualizar tarefas

        private void button4_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
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
    }
}

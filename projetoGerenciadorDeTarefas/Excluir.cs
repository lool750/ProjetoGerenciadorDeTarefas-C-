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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int codigo = Convert.ToInt32(maskedTextBox1.Text);
                MessageBox.Show(exc.Excluir(codigo));
                this.Close();
            }
            else
            {
                MessageBox.Show("Exclusão cancelada.");
            }
        }//fim do botão excluir

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }
    }
}

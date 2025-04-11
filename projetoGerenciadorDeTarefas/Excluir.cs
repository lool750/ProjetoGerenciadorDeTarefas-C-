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
            // Verifica se o campo está vazio ou só tem espaços
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Por favor, informe um código para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tenta converter para int com segurança
            if (!int.TryParse(maskedTextBox1.Text, out int codigo))
            {
                MessageBox.Show("Código inválido. Digite apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmação da exclusão
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                string retorno = exc.Excluir(codigo);

                if (retorno.StartsWith("1")) // Se uma linha foi afetada
                {
                    MessageBox.Show("Excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir. Verifique o código.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

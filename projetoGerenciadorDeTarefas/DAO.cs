using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace projetoGerenciadorDeTarefas
{
    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] nome;
        public string[] tituloTarefa;
        public string[] descTarefa;
        public string[] prioridade;
        public string[] vencimento;
        public string[] andamentoTarefa;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=gerenciador_tint;Uid=root;password=");
            try
            {
                conexao.Open();//tentando conectar com o banco
                MessageBox.Show("Conectado!!!"); //serve para teste
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado \n\n\n" + erro);
            }
        }//FIM DO CONSTRUTOR

        public string Inserir(int codigo, string nome, string tituloTarefa, string descTarefa, string prioridade, string vencimento, string andamentoTarefa)
        {
            string inserir = $"Insert into cadastro(codigo, nome, tituloTarefa, descTarefa, prioridade, vencimento, andamentoTarefa) values('{codigo}','{nome}','{tituloTarefa}','{descTarefa}','{prioridade}','{vencimento}','{andamentoTarefa}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }// fim do método inserir

        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update cadastro set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
        }//fim do método Atualizar

        public void PreencherVetor()
        {
            string query = "select * from cadastro";

            //instanciar vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.tituloTarefa = new string[100];
            this.descTarefa = new string[100];
            this.prioridade = new string[100];
            this.vencimento = new string[100];
            this.andamentoTarefa = new string[100];

            //preparar comando para o banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //chamar o leitor do banco de dados
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;//instanciando contador
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                tituloTarefa[i] = leitura["tituloTarefa"] + "";
                descTarefa[i] = leitura["descTarefa"] + "";
                prioridade[i] = leitura["prioridade"] + "";
                vencimento[i] = leitura["vencimento"] + "";
                andamentoTarefa[i] = leitura["andamentoTarefa"] + "";
                i++;//contador gire
                contador++;//qtda de dados que preenche o vetor
            }//fim do while

            //Encerrar processo de leitura
            leitura.Close();

        }//fim do método

        public int ConsultarPorCodigo(int cod)
        {
            PreencherVetor();//Preenchendoi o vetor

            i = 0;//instanciando contador
            while (i < QuantidadeDeDados())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++;//contador gire

            }//fim do while

            //Encerrar processo de leitura
            return -1;

        }//fim do método

        public string RetornarNome(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return nome[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do método retornar nome

        public string RetornarTituloTarefa(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return tituloTarefa[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do método retornar titulo da tarefa

        public string RetornarDescTarefa(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return descTarefa[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do método retornar descrição da tarefa

        public string RetornarDataVencimento(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return vencimento[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do método retornar data de vencimento

        public string RetornarAndamentoTarefa(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return andamentoTarefa[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do método retornar andamento da tarefa

        public string RetornarPrioridadeTarefa(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return prioridade[posicao];
            }
            return "Código digitado não é válido!";
        }//fim do método retornar prioridade da tarefa

        public int QuantidadeDeDados()
        {
            return contador;
        }//fim do método

        public string Excluir(int codigo)
        {
            string query = $"delete from cadastro where codigo ='{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Deletado !";
            return resultado;
        }//fim do método excluir
    }
}

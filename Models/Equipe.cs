using EJOGOSS.Interface;
using System.Collections.Generic;
using System.IO;

namespace EJOGOSS.Models
{
    //Herança:


    public class Equipe : Equipebase, IEquipe
    {
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //variavel de dados

        private const string caminhobd = "Database/equipe.csv";
       
        //criando construtor  para verificar se o diretório existe
        public Equipe()
        {
  

            //metodo da classe de herança "IEquipe"
            CriarPastaOuArquivo(caminhobd);
        }

        //Criar uma funcao que vai receber o objeto EQUIPE
        // E vai retornar no formato de csv (string)

       private string Preparar(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";

        }


        public void Criar(Equipe novaequipe)
        {
            string valor = Preparar(novaequipe);
            //array de strings = na posição 0 temos o retorno do "Preparar"
            string[] equipe_texto = { valor };

            //No arquivo vamos adicionar uma nova linha
            // recebe caminho do arquivo, string em formato de array

            File.AppendAllLines(caminhobd, equipe_texto);

        }

        public List<Equipe> LerEquipes()
        {
            List<Equipe> listaEquipes = new List<Equipe>();

            //ler todas as linhas do arquivo csv e armazenar em array
            string[] linhas = File.ReadAllLines(caminhobd);
            foreach (string item in linhas)
            {
                //1. ID | 2.Nome da Equipe | 3.Caminho da imagem
                string[] linhaEquipe = item.Split(';');
                Equipe equipeAtual = new Equipe();
                equipeAtual.IdEquipe =  int.Parse(linhaEquipe[0]);
                equipeAtual.Nome = linhaEquipe[1];
                equipeAtual.Imagem = linhaEquipe[2];

                listaEquipes.Add(equipeAtual);

            }

            return listaEquipes;

        }
    }
}

using System.IO;

namespace EJOGOSS.Models
{
    public class Equipebase
    {
        public void CriarPastaOuArquivo (string caminho)
        {
            // nome da pasta / nome do arquivo.csv
            string pasta = caminho.Split('/')[0];
            Directory.CreateDirectory(caminho);

            if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }

            if(!File.Exists(caminho))
            {
                File.Create(caminho);
            }
                

        }
    }
}

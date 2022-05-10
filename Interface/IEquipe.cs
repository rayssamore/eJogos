using EJOGOSS.Models;
using System.Collections.Generic;

namespace EJOGOSS.Interface
{
    public interface IEquipe
    {
        //Representa um contrato 
        //Representar os métodos que são obrigatórios
        //em uma classe

        void Criar(Equipe novaequipe);
        List <Equipe>LerEquipes();



    }
}

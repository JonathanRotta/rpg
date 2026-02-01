using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Models
{
    public class Guerreiro : Personagem
    {
       
        public Guerreiro(string nome) : base(nome, 1, 120)
        {
           
        }

        public override void Atacar(Personagem alvo)
        {
            throw new NotImplementedException();
        }
    }
}

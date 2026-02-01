using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Models
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }

        public Personagem(string nome, int nivel, int vida)
        {
            Nome = nome;
            Nivel = nivel;
            Vida = vida;
        }

        public abstract void Atacar(Personagem alvo);

        public void ReceberDano(int dano)
        {
            Vida = Vida - dano;
            if (Vida < 0)
            {
                Vida = 0;
            }
        }
    }
}

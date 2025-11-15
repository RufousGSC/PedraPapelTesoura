using Computador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Jogador : IA
    {
        string Escolha = "";              

        public void setEscolha(string nome)
        {
            this.Escolha = nome;
            Console.WriteLine(Escolha);
        }





    }
}

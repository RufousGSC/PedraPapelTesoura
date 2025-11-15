using Computador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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
        }
        public string getEscolha()
        {
            return this.Escolha;
        }
    }
}

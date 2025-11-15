using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computador
{ 

    public class IA
    {
      
        Random random = new Random();

        public string[] escolhaIA = new string[] { "Pedra", "Papel", "Tesoura" };
        public string sorteio = "";


        public string Receber()
        {
           this.sorteio = escolhaIA[random.Next(escolhaIA.Length)];

            return sorteio;
        }




        


    }
}

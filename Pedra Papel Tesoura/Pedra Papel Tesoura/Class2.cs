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
        string[] escolhaIA = new string[] { "Pedra", "Papel", "Tesoura" };
        string sorteio = "";
        int ganhar = 0;
        int perder = 0;       

        public void Receber()
        {
           this.sorteio = escolhaIA[random.Next(escolhaIA.Length)];           
        }

        public string getSorteio()
        {
            return this.sorteio;
        }

        public void vitoria()
        {
            this.ganhar++;
            Console.WriteLine("Vitoria\n");         
        }     
        
        public string getGanhou()
        {
            if(ganhar >= 3)
            {
                return "ganhou";
            }
            return "";
        }
           

        public void derrota()
        {
            this.perder++;
            Console.WriteLine("Perdeu\n");
        }

        public string getPerdeu()
        {
            if (perder >= 3)
            {
                return "Perdeu";
            }
            return "";
        }






    }
}

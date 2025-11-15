using Computador;
using Player;

Jogador jogador = new Jogador();
IA ia = new IA();
bool ativo = true;
string pedra = "Pedra";
string papel = "Papel";
string tesoura = "Tesoura";
string escolhajogador = "";
string escolhaIA = "";
string ganhou = "Ganhou";
string perdeu = "Perdeu";
string ganhouia = "";
string perdeuia = "";
bool verificar = false;
bool verificarjogadorPedra = false;
bool verificarjogadorPapel = false;
bool verificarjogadorTesoura = false;
bool verificarIAPedra = false;
bool verificarIAPapel = false;
bool verificarIATesoura = false;
bool verificarganhou = false;
bool verificarperdeu = false;





while (ativo == true)
{
    Console.WriteLine("Digite Uma Opção entre Pedra Papel e Tesoura: ");
    jogador.setEscolha(Console.ReadLine());
    ia.Receber();
    Console.WriteLine("resultado: \n");
    escolhajogador = jogador.getEscolha(); // string - 
    escolhaIA = ia.getSorteio(); // string - 
    verificar = escolhajogador.Equals(escolhaIA, StringComparison.OrdinalIgnoreCase); //bool - pesquisei na internet para saber como comparava strings
    verificarjogadorPedra = escolhajogador.Equals(pedra, StringComparison.OrdinalIgnoreCase); // bool - 
    verificarjogadorPapel = escolhajogador.Equals(papel, StringComparison.OrdinalIgnoreCase);
    verificarjogadorTesoura = escolhajogador.Equals(tesoura, StringComparison.OrdinalIgnoreCase);
    verificarIAPedra = escolhaIA.Equals(pedra, StringComparison.OrdinalIgnoreCase);
    verificarIAPapel = escolhaIA.Equals(papel, StringComparison.OrdinalIgnoreCase);
    verificarIATesoura = escolhaIA.Equals(tesoura, StringComparison.OrdinalIgnoreCase);    
    Console.WriteLine(escolhajogador + "\n" + escolhaIA);


    if (verificar == true)
    {
        Console.WriteLine("Empate");
    }
    else
    {
        if(verificarjogadorPedra == true && verificarIAPapel == false && verificarIATesoura == true)
        {
            ia.vitoria();
            Console.WriteLine("Ganhou\n");
        }

        if(verificarjogadorPedra == true && verificarIAPapel == true && verificarIATesoura == false)
        {
            ia.derrota();
            Console.WriteLine("Perdeu\n");
        }
        


    }
    ganhouia = ia.getGanhou();
    perdeuia = ia.getPerdeu();
    verificarperdeu = perdeu.Equals(perdeuia, StringComparison.OrdinalIgnoreCase);
    verificarganhou = ganhou.Equals(ganhouia, StringComparison.OrdinalIgnoreCase);
    if(verificarganhou == true)
    {
        ativo = false;
    }
    if (verificarperdeu == true)
    {
        ativo = false; 
    }




   
    
}








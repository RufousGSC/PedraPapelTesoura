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
string ganhoupersonagem = "";
string perdeupersonagem = "";
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
    verificarjogadorPedra = escolhajogador.Equals(pedra, StringComparison.OrdinalIgnoreCase); //bool - Acho que daria pra tentar fazer usando um vetor
    verificarjogadorPapel = escolhajogador.Equals(papel, StringComparison.OrdinalIgnoreCase); //bool -
    verificarjogadorTesoura = escolhajogador.Equals(tesoura, StringComparison.OrdinalIgnoreCase); //bool -
    verificarIAPedra = escolhaIA.Equals(pedra, StringComparison.OrdinalIgnoreCase); //bool -
    verificarIAPapel = escolhaIA.Equals(papel, StringComparison.OrdinalIgnoreCase); //bool -
    verificarIATesoura = escolhaIA.Equals(tesoura, StringComparison.OrdinalIgnoreCase); //bool -    
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

        if (verificarjogadorPapel == true && verificarIATesoura == false && verificarIAPedra == true)
        {
            ia.vitoria();
            Console.WriteLine("Ganhou\n");
        }

        if (verificarjogadorPapel == true && verificarIATesoura == true && verificarIAPedra == false)
        {
            ia.derrota();
            Console.WriteLine("Perdeu\n");
        }

        if (verificarjogadorTesoura == true && verificarIAPedra == false && verificarIAPapel == true)
        {
            ia.vitoria();
            Console.WriteLine("Ganhou\n");
        }

        if (verificarjogadorTesoura == true && verificarIAPedra == true && verificarIAPapel == false)
        {
            ia.derrota();
            Console.WriteLine("Perdeu\n");
        }
    }

    ganhoupersonagem = ia.getGanhou();
    perdeupersonagem = ia.getPerdeu();
    verificarperdeu = perdeu.Equals(perdeupersonagem, StringComparison.OrdinalIgnoreCase);
    verificarganhou = ganhou.Equals(ganhoupersonagem, StringComparison.OrdinalIgnoreCase);

    if(verificarganhou == true)
    {
        ativo = false;
        Console.WriteLine("PARABENS VOCÊ GANHOU");
    }
    if (verificarperdeu == true)
    {
        ativo = false;
        Console.WriteLine("É UMA PENA VOCE PERDEU");
    }     
}








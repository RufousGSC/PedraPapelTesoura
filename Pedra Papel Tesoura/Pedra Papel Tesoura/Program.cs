using Computador;
using Player;

Jogador jogador = new Jogador();
IA ia = new IA();
bool ativo = true;




while (ativo == true)
{
    Console.WriteLine("Digite Uma Opção entre Pedra Papel e Tesoura: ");
    jogador.setEscolha(Console.ReadLine());
    ia.Receber();
    Console.WriteLine(ia.sorteio);



   
    
}








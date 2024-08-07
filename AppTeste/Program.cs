using AppTeste.Entities;


var jogador = new Jogador("João");
var jogador2 = new Jogador ("Maria");

jogador.Jogar(EAcao.Papel);
jogador2.Jogar(EAcao.Tesoura);


var jogadaPedra = new Pedra();
var jogadaPapel = new Papel();
var jogadaTesoura = new Tesoura();

var result = "";

switch (jogador.Acao)
{
    case EAcao.Pedra:
        result = jogadaPedra.Resultado(jogador2.Acao, jogador.Name, jogador2.Name);
        break;
    case EAcao.Papel:
        result = jogadaPapel.Resultado(jogador2.Acao, jogador.Name, jogador2.Name);
        break;
    case EAcao.Tesoura:
        result = jogadaTesoura.Resultado(jogador2.Acao, jogador.Name, jogador2.Name);
        break;
}



Console.WriteLine(result);
Console.ReadKey();

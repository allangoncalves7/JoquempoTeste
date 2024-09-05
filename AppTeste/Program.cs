using AppTeste.Entities;
using AppTeste.Enums;


var jogador1 = new Jogador("João");
var jogador2 = new Jogador("Maria");

jogador1.EscolherAcao(EAcao.Pedra);
jogador2.EscolherAcao(EAcao.Tesoura);

var jogo = new Jogo();
var resultado = jogo.Jogar(jogador1, jogador2);

Console.WriteLine(resultado);
Console.ReadKey();

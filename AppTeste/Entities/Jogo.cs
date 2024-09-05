using AppTeste.Enums;

namespace AppTeste.Entities
{
    public class Jogo
    {
        private static readonly Dictionary<EAcao, List<EAcao>> _regras = new Dictionary<EAcao, List<EAcao>>
    {
        { EAcao.Pedra, new List<EAcao> { EAcao.Tesoura, EAcao.Lagarto } },
        { EAcao.Papel, new List<EAcao> { EAcao.Pedra, EAcao.Spock } },
        { EAcao.Tesoura, new List<EAcao> { EAcao.Papel, EAcao.Lagarto } },
        { EAcao.Lagarto, new List<EAcao> { EAcao.Papel, EAcao.Spock } },
        { EAcao.Spock, new List<EAcao> { EAcao.Pedra, EAcao.Tesoura } }
    };

        public string Jogar(Jogador jogador1, Jogador jogador2)
        {
            if (jogador1.Acao == jogador2.Acao)
                return "Empate!";

            if (_regras[jogador1.Acao].Contains(jogador2.Acao))
                return $"{jogador1.Nome} ganhou com {jogador1.Acao}!";

            return $"{jogador2.Nome} ganhou com {jogador2.Acao}!";
        }
    }
}

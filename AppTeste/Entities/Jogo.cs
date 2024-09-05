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

        public string Jogar(EAcao acaoJogador1, EAcao acaoJogador2, string jogador1, string jogador2)
        {
            if (acaoJogador1 == acaoJogador2)
                return "Empate!";

            if (_regras[acaoJogador1].Contains(acaoJogador2))
                return $"{jogador1} ganhou com {acaoJogador1}!";

            return $"{jogador2} ganhou com {acaoJogador2}!";
        }
    }
}

using AppTeste.Interfaces;

namespace AppTeste.Entities
{
    public class Tesoura : IJoquemPo
    {
        public string Resultado(EAcao acao, string jogador1, string jogador2)
        {
            switch (acao)
            {
                case EAcao.Pedra:
                    return $"{jogador2} ganhou";
                case EAcao.Papel:
                    return $"{jogador1} ganhou";
                default:
                    return "Empate";
            }
        }
    }
}

using AppTeste.Interfaces;

namespace AppTeste.Entities
{
    public class Papel : IJoquemPo
    {
        public string Resultado(EAcao acao, string jogador1, string jogador2)
        {
            switch (acao)
            {
                case EAcao.Tesoura:
                    return $"{jogador2} ganhou";
                case EAcao.Pedra:
                    return $"{jogador1} ganhou";
                default:
                    return "Empate";
            }
        }
    }
}

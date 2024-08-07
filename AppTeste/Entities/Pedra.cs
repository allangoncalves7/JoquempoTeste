using AppTeste.Interfaces;

namespace AppTeste.Entities
{
    public class Pedra : IJoquemPo
    {
        public string Resultado(EAcao acao, string jogador1, string jogador2)
        {
            switch (acao)
            {
                case EAcao.Papel:
                    return $"{jogador2} ganhou";
                case EAcao.Tesoura:
                    return $"{jogador1} ganhou";
                default:
                    return "Empate";
            }
        }
    }
}

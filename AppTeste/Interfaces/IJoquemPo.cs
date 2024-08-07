using AppTeste.Entities;

namespace AppTeste.Interfaces
{
    public interface IJoquemPo
    {
        string Resultado(EAcao acao, string jogador1, string jogador2);
    }
}

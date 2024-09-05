using AppTeste.Enums;

namespace AppTeste.Entities
{
    public class Jogador
    {
        public string Nome { get; }
        public EAcao Acao { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public void EscolherAcao(EAcao acao)
        {
            Acao = acao;
        }
    }  

}

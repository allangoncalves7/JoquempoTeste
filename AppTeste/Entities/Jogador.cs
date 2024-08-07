namespace AppTeste.Entities
{
    public class Jogador
    {
        public Jogador(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public EAcao Acao { get; private set; }

        public void Jogar(EAcao acao)
        {
            Acao = acao;
        }

    }
    public enum EAcao
    {
        Pedra,
        Papel,
        Tesoura,

    }

}

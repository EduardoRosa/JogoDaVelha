namespace JogoDaVelha
{
    public interface IResultado
    {
        public IResultado ProximoPossivelResultado { get; set; }

        public string VerificaResultado(char[] posicoes, char simboloJogador);
    }
}
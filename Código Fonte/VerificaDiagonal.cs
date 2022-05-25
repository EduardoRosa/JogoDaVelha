namespace JogoDaVelha
{
    public class VerificaDiagonal : IResultado
    {
        public IResultado ProximoPossivelResultado { get; set; }

        public string VerificaResultado(char[] posicoes, char simboloJogador)
        {
            if ((
                posicoes[0].Equals(simboloJogador)
                && posicoes[4].Equals(simboloJogador)
                && posicoes[8].Equals(simboloJogador)
             ) ||
            (
             posicoes[2].Equals(simboloJogador)
             && posicoes[4].Equals(simboloJogador)
             && posicoes[6].Equals(simboloJogador)
            ))
            {
                return $"Jogador {(simboloJogador.Equals('X') ? "1" : "2")} ganhou.";
            }

            return ProximoPossivelResultado.VerificaResultado(posicoes, simboloJogador);
        }
    }
}
namespace JogoDaVelha
{

    public class VerificaVertical : IResultado
    {
        public IResultado ProximoPossivelResultado { get; set; }

        public string VerificaResultado(char[] posicoes, char simboloJogador)
        {
            if (
                (
                    posicoes[0].Equals(simboloJogador)
                    && posicoes[3].Equals(simboloJogador)
                    && posicoes[6].Equals(simboloJogador)
                ) ||
                (
                    posicoes[1].Equals(simboloJogador)
                    && posicoes[4].Equals(simboloJogador)
                    && posicoes[7].Equals(simboloJogador)
                ) ||
                (
                    posicoes[2].Equals(simboloJogador)
                    && posicoes[5].Equals(simboloJogador)
                    && posicoes[8].Equals(simboloJogador)
                )
            )
            {
                return $"Jogador {(simboloJogador.Equals('X') ? "1" : "2")} ganhou.";
            }

            return ProximoPossivelResultado.VerificaResultado(posicoes, simboloJogador);
        }
    }
}
namespace JogoDaVelha
{
    public static class VerificaResultado
    {
        static IResultado diagonal = new VerificaDiagonal();
        static IResultado horizontal = new VerificaVertical();
        static IResultado vertical = new VerificaHorizontal();
        static IResultado empate = new VerificaEmpate();

        public static string Verifica(char[] posicoes, char simboloJogador)
        {
            diagonal.ProximoPossivelResultado = horizontal;
            horizontal.ProximoPossivelResultado = vertical;
            vertical.ProximoPossivelResultado = empate;

            return diagonal.VerificaResultado(posicoes, simboloJogador);
        }
    }
}
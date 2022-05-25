using System.Linq;

namespace JogoDaVelha
{
    public class VerificaEmpate : IResultado
    {
        public IResultado ProximoPossivelResultado { get; set; }

        public string VerificaResultado(char[] posicoes, char simboloJogador)
        {
            if (posicoes.Count(x => x.Equals('X') || x.Equals('O')) == 9)
                return "Empate";

            return default;
        }
    }
}

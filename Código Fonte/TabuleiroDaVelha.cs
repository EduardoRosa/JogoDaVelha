using System;

namespace JogoDaVelha
{

    public static class TabuleiroDaVelha
    {
        public static void Jogar()
        {
            Posicoes = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            while (!FimDoJogo)
            {
                RenderizaTabuleiro();
                EscolhePosicaoJogada();
                TrocaJogador();
            }
        }
        private static void TrocaJogador()
        {
            SimboloJogador = SimboloJogador.Equals('X') ? 'O' : 'X';
        }

        private static void EscolhePosicaoJogada()
        {
            Console.Write($"[{SimboloJogador}] Escolha a posição de sua jogada: ");
            bool jogadaValida = (int.TryParse(Console.ReadLine(), out int posicaoEscolhida) && (posicaoEscolhida > 0 && posicaoEscolhida <= 9));

            if (!jogadaValida)
            {
                Console.WriteLine("Jogada inválida. Escolha uma posição e tente novamente.");
                EscolhePosicaoJogada();
            }
            else
            {
                if (Posicoes[posicaoEscolhida - 1].Equals('X') || Posicoes[posicaoEscolhida - 1].Equals('O'))
                {
                    Console.WriteLine("Jogada inválida. Escolha uma posição vazia para efetuar a jogada.");
                    EscolhePosicaoJogada();
                }
                else
                {
                    Posicoes[posicaoEscolhida - 1] = SimboloJogador;

                    if (SimboloJogador.Equals('X'))
                        JogadasJogador1 += 1;
                    else
                        JogadasJogador2 += 1;

                    if (JogadasJogador1 >= 3 || JogadasJogador2 >= 3)
                    {
                        string resultado = VerificaResultado.Verifica(Posicoes, SimboloJogador);

                        if (!string.IsNullOrWhiteSpace(resultado))
                        {
                            RenderizaTabuleiro();
                            Console.WriteLine($"{Environment.NewLine} {resultado}");
                            FimDoJogo = true;
                            Console.ReadKey();
                        }
                    }

                }

            }

        }

        private static void RenderizaTabuleiro()
        {
            Console.WriteLine(GeraTabuleiro());
        }

        private static string GeraTabuleiro()
        {
            return $"{Environment.NewLine}"+
                   $"\t\t__{Posicoes[0]}__|__{Posicoes[1]}__|__{Posicoes[2]}__{Environment.NewLine}" +
                   $"\t\t__{Posicoes[3]}__|__{Posicoes[4]}__|__{Posicoes[5]}__{Environment.NewLine}" +
                   $"\t\t__{Posicoes[6]}__|__{Posicoes[7]}__|__{Posicoes[8]}__{Environment.NewLine}";

        }

        private static char[] Posicoes { get; set; }
        private static char SimboloJogador = 'X';
        private static bool FimDoJogo = false;
        private static int JogadasJogador1 { get; set; }
        private static int JogadasJogador2 { get; set; }

    }
}
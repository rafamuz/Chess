using System;
using tabuleiro;

namespace Chess
{
    internal class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.linhas; l++)
            {
                for (int c = 0; c < tab.colunas; c++)
                {
                    if (tab.peca(c, l) == null)
                        Console.Write("- ");
                    else
                        Console.Write(tab.peca(l, c) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

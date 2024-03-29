﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];

        PreencheMatriz(mat, 5, 5);
        ImprimeMatriz(mat, 5, 5);
        SomaValoresColuna(mat, 5, 5);
        SomaValoresLInha(mat, 5, 5);
        SomaValoresDiagonais(mat, 5, 5);


        void PreencheMatriz(int[,] aux, int lin, int col)
        {

            for (int linha = 0; linha < lin; linha++)
            {
                for (int coluna = 0; coluna < col; coluna++)
                {
                    Console.WriteLine(" \nDigite o valor da posicao [{0},{1}]", linha, coluna);
                    aux[linha, coluna] = int.Parse(Console.ReadLine());

                }
            }
        }

        void ImprimeMatriz(int[,] aux, int lin, int col)
        {
            Console.Clear();

            for (int linha = 0; linha < lin; linha++)
            {
                for (int coluna = 0; coluna < col; coluna++)
                {

                    Console.Write(aux[linha, coluna] + " |");

                    if (coluna == (col - 1))
                    {
                        Console.WriteLine("\n");
                    }

                }
            }

        }




        void SomaValoresColuna(int[,] aux, int lin, int col)
        {

            int contador = 0;
            for (int coluna = 0; coluna < col; coluna++)
            {
                int vertical = 0;

                Console.Write("A soma do caminho da coluna {0} é: ", coluna);

                for (int linha = 0; linha < lin; linha++)
                {

                    vertical += aux[linha, contador];


                }
                Console.Write(vertical + "\n");
                if (contador < lin)
                {
                    contador++;
                }

            }

        }

        void SomaValoresLInha(int[,] aux, int lin, int col)
        {

            int contador = 0;
            for (int linha = 0; linha < lin; linha++)
            {
                int vertical = 0;

                Console.Write("A soma do caminho da linha {0} é: ", linha);

                for (int coluna = 0; coluna < col; coluna++)
                {

                    vertical += aux[contador, coluna];


                }
                Console.Write(vertical + "\n");
                if (contador < lin)
                {
                    contador++;
                }
            }

        }

        void SomaValoresDiagonais(int[,] aux, int lin, int col)
        {

            int somaDiagonal1 = 0;
            int somaDiagonal2 = 0;
            int contadorLinha = 0;
            int contadorColuna = col - 1;

            for (int linha = 0; linha < lin; linha++)
            {

                for (int coluna = 0; coluna < col; coluna++)
                {
                    if (linha == coluna)
                    {
                        somaDiagonal1 += aux[linha, coluna];
                    }

                    if ((coluna == contadorColuna) && (linha == contadorLinha))
                    {
                        somaDiagonal2 += aux[contadorLinha, contadorColuna];
                        contadorLinha++;
                        contadorColuna--;
                    }

                }

            }
            Console.Write(" A soma da diagonal 1 é: " + somaDiagonal1 + "\n");
            Console.Write(" \nA soma da diagonal 2 é: " + somaDiagonal2 + "\n");

        }


    }
}

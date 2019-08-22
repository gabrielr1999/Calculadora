using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz1
{
    class Program
    {
        static int opcao;
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA MATRIZ DE ORDEM 3");
            Console.WriteLine();
            Console.WriteLine("1- TRANSPOSTA");
            Console.WriteLine("2- OPOSTA");
            Console.WriteLine("3- DETERMINANTE E INVERSA");
            Console.WriteLine("4- ADIÇÃO");
            Console.WriteLine("5- SUBTRAÇÃO");
            Console.WriteLine("6- MULTIPLICAÇÃO");

            Console.WriteLine();
            Console.WriteLine("Digite o Número correspondente a opção:");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    TRANSPOSTA(); // Chama a função inserir
                    break;
                case 2:
                    OPOSTA(); // Chama a função listar
                    break;
                case 3:
                    INVERSA();
                    break;
                case 4:
                    ADIÇÃO();
                    break;
                case 5:
                    SUBTRAÇÃO();
                    break;
                case 6:
                    MULTIPLICAÇÃO();
                    break;


                default: // caso o número digitado não exista no switch ele aciona o defalt
                    Console.WriteLine("----Opção inválida----");
                    Console.WriteLine("Precione uma telca para voltar ao menu");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }
        static void TRANSPOSTA()
        {
            Console.Clear();
            // declaração das matrizes 
            int[,] mAi = new int[3, 3];   //CALCULO DA MATRIZ INVERSA
            int[,] mA = new int[3, 3];  //MATRIZ A
            int[,] mB = new int[3, 3]; // MATRIZ B
            string[,] inversaA = new string[3, 3]; // MATRIZ INVESA COMPLETA

            Console.WriteLine("Digite uma matriz: \n");

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    mA[i, j] = 0;
                }
            }

            /////////////////////////////////////////CRIAR MATRIZ 1/////////////////////////////////////////////

            int m = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'a{0}{1}': ", m, n);
                    mA[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                m++;
            }

            /////////////////////////////////////////MOSTRA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("\n|{0}  {1}  {2}|", mA[0, 0], mA[0, 1], mA[0, 2]);
            Console.WriteLine("|{0}  {1}  {2}|", mA[1, 0], mA[1, 1], mA[1, 2]);
            Console.WriteLine("|{0}  {1}  {2}|\n", mA[2, 0], mA[2, 1], mA[2, 2]);

            /////////////////////////////////////////TRANSPOSTA DA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("TRANSPOSTA");
            Console.WriteLine("\n|{0}  {1}  {2}|\n|{3}  {4}  {5}|\n|{6}  {7}  {8}|\n", mA[0, 0], mA[1, 0], mA[2, 0], mA[0, 1], mA[1, 1], mA[2, 1], mA[0, 2], mA[1, 2], mA[2, 2]);



            Console.ReadKey();
            Menu(); //Chama o método menu de opções.
        }
        static void OPOSTA()
        {
            Console.Clear();
            // declaração das matrizes 
            int[,] mAi = new int[3, 3];    //CALCULO DA MATRIZ INVERSA
            int[,] mA = new int[3, 3];  //MATRIZ A
            int[,] mB = new int[3, 3]; // MATRIZ B
            string[,] inversaA = new string[3, 3]; // MATRIZ INVESA COMPLETA

            Console.WriteLine("Digite uma matriz: \n");

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    mA[i, j] = 0;
                }
            }

            /////////////////////////////////////////CRIAR MATRIZ 1/////////////////////////////////////////////

            int m = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'a{0}{1}': ", m, n);
                    mA[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                m++;
            }

            /////////////////////////////////////////MOSTRA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("\n|{0}  {1}  {2}|", mA[0, 0], mA[0, 1], mA[0, 2]);
            Console.WriteLine("|{0}  {1}  {2}|", mA[1, 0], mA[1, 1], mA[1, 2]);
            Console.WriteLine("|{0}  {1}  {2}|\n", mA[2, 0], mA[2, 1], mA[2, 2]);
            /////////////////////////////////////////OPOSTA DA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("OPOSTA");
            Console.WriteLine("\n|{0}  {1}  {2}|\n|{3}  {4}  {5}|\n|{6}  {7}  {8}|\n", -(mA[0, 0]), -(mA[0, 1]), -(mA[0, 2]), -(mA[1, 0]), -(mA[1, 1]), -(mA[1, 2]), -(mA[2, 0]), -(mA[2, 1]), -(mA[2, 2]));


            Console.ReadKey();
            Menu();
        }
        static void INVERSA()
        {
            Console.Clear();
            // declaração das matrizes 
            int[,] mAi = new int[3, 3];    //CALCULO DA MATRIZ INVERSA
            int[,] mA = new int[3, 3];  //MATRIZ A
            int[,] mB = new int[3, 3]; // MATRIZ B
            string[,] inversaA = new string[3, 3]; // MATRIZ INVESA COMPLETA

            Console.WriteLine("Digite uma matriz: \n");

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    mA[i, j] = 0;
                }
            }

            /////////////////////////////////////////CRIAR MATRIZ 1/////////////////////////////////////////////

            int m = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'a{0}{1}': ", m, n);
                    mA[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                m++;
            }

            /////////////////////////////////////////MOSTRA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("\n|{0}  {1}  {2}|", mA[0, 0], mA[0, 1], mA[0, 2]);
            Console.WriteLine("|{0}  {1}  {2}|", mA[1, 0], mA[1, 1], mA[1, 2]);
            Console.WriteLine("|{0}  {1}  {2}|\n", mA[2, 0], mA[2, 1], mA[2, 2]);
            /////////////////////////////////////////DETERMINANTE DA MATRIZ 1/////////////////////////////////////////////
            int det;
            det = ((mA[0, 0] * mA[1, 1] * mA[2, 2]) + (mA[0, 1] * mA[1, 2] * mA[2, 0]) + (mA[0, 2] * mA[1, 0] * mA[2, 1]))
                                                                -
                  ((mA[0, 2] * mA[1, 1] * mA[2, 0]) + (mA[0, 0] * mA[1, 2] * mA[2, 1]) + (mA[0, 1] * mA[1, 0] * mA[2, 2]));

            Console.WriteLine("\nDETERMINANTE DA MATRIZ: {0}\n", det);

            /////////////////////////////////////////INVERSA DA MATRIZ 1//////////////////////////////////////////////
            if (det != 0)
            {

                mAi[0, 0] = (mA[1, 1] * mA[2, 2] - mA[1, 2] * mA[2, 1]);
                mAi[0, 1] = (mA[2, 1] * mA[0, 2] - mA[0, 1] * mA[2, 2]);
                mAi[0, 2] = (mA[0, 1] * mA[1, 2] - mA[0, 2] * mA[1, 1]);
                mAi[1, 0] = (mA[1, 2] * mA[2, 0] - mA[2, 2] * mA[1, 0]);
                mAi[1, 1] = (mA[2, 2] * mA[0, 0] - mA[0, 2] * mA[2, 0]);
                mAi[1, 2] = (mA[0, 2] * mA[1, 0] - mA[0, 0] * mA[1, 2]);
                mAi[2, 0] = (mA[1, 0] * mA[2, 1] - mA[1, 1] * mA[2, 0]);
                mAi[2, 1] = (mA[2, 0] * mA[0, 1] - mA[2, 1] * mA[0, 0]);
                mAi[2, 2] = (mA[0, 0] * mA[1, 1] - mA[0, 1] * mA[1, 0]);

                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (mAi[i, j] % det == 0)
                        {
                            inversaA[i, j] = (mAi[i, j] / det).ToString();

                        }
                        else if (mAi[i, j] % det != 0)
                        {
                            inversaA[i, j] = (mAi[i, j].ToString() + "/" + det.ToString());
                        }
                    }

                }


                Console.WriteLine("INVERSA\n");

                Console.WriteLine("|{0}  {1}  {2}|", inversaA[0, 0], inversaA[0, 1], inversaA[0, 2]);
                Console.WriteLine("|{0}  {1}  {2}|", inversaA[1, 0], inversaA[1, 1], inversaA[1, 2]);
                Console.WriteLine("|{0}  {1}  {2}|", inversaA[2, 0], inversaA[2, 1], inversaA[2, 2]);
            }
            else
            {
                Console.WriteLine("\nSE O DETERMINANTE FOR 0 A MATRIZ INVERSA DESSA MATRIZ NÃO EXISTE\n");
            }
            Console.ReadKey();
            Menu();
        }
        static void ADIÇÃO()
        {
            Console.Clear();
            // declaração das matrizes 
            int[,] mAi = new int[3, 3];    //CALCULO DA MATRIZ INVERSA
            int[,] mA = new int[3, 3];  //MATRIZ A
            int[,] mB = new int[3, 3]; // MATRIZ B
            string[,] inversaA = new string[3, 3]; // MATRIZ INVESA COMPLETA

            Console.WriteLine("Digite uma matriz: \n");

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    mA[i, j] = 0;
                }
            }

            /////////////////////////////////////////CRIAR MATRIZ 1/////////////////////////////////////////////

            int m = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'a{0}{1}': ", m, n);
                    mA[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                m++;
            }

            /////////////////////////////////////////MOSTRA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("\n|{0}  {1}  {2}|", mA[0, 0], mA[0, 1], mA[0, 2]);
            Console.WriteLine("|{0}  {1}  {2}|", mA[1, 0], mA[1, 1], mA[1, 2]);
            Console.WriteLine("|{0}  {1}  {2}|\n", mA[2, 0], mA[2, 1], mA[2, 2]);
            int M = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'b{0}{1}': ", M, n);
                    mB[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                M++;
            }
            /////////////////////////////////////////MATRIZ 1+2//////////////////////////////////////////////
            Console.WriteLine("\nADIÇÃO");
            Console.WriteLine("\n|{0}  {1}  {2}|\n|{3}  {4}  {5}|\n|{6}  {7}  {8}|\n", (mA[0, 0] + mB[0, 0]), (mA[0, 1] + mB[0, 1]), (mA[0, 2] + mB[0, 2]), (mA[1, 0] + mB[1, 0]), (mA[1, 1] + mB[1, 1]), (mA[1, 2] + mB[1, 2]), (mA[2, 0] + mB[2, 0]), (mA[2, 1] + mB[2, 1]), (mA[2, 2] + mB[2, 2]));

            Console.ReadKey();
            Menu();
        }
        static void SUBTRAÇÃO()
        {
            Console.Clear();
            // declaração das matrizes 
            int[,] mAi = new int[3, 3];    //CALCULO DA MATRIZ INVERSA
            int[,] mA = new int[3, 3];  //MATRIZ A
            int[,] mB = new int[3, 3]; // MATRIZ B
            string[,] inversaA = new string[3, 3]; // MATRIZ INVESA COMPLETA

            Console.WriteLine("Digite uma matriz: \n");

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    mA[i, j] = 0;
                }
            }

            /////////////////////////////////////////CRIAR MATRIZ 1/////////////////////////////////////////////

            int m = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'a{0}{1}': ", m, n);
                    mA[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                m++;
            }

            /////////////////////////////////////////MOSTRA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("\n|{0}  {1}  {2}|", mA[0, 0], mA[0, 1], mA[0, 2]);
            Console.WriteLine("|{0}  {1}  {2}|", mA[1, 0], mA[1, 1], mA[1, 2]);
            Console.WriteLine("|{0}  {1}  {2}|\n", mA[2, 0], mA[2, 1], mA[2, 2]);
            int M = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'b{0}{1}': ", M, n);
                    mB[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                M++;
            }
            /////////////////////////////////////////MATRIZ 1-2//////////////////////////////////////////////
            Console.WriteLine("\nSUBTRAÇÃO");
            Console.WriteLine("\n|{0}  {1}  {2}|\n|{3}  {4}  {5}|\n|{6}  {7}  {8}|\n", (mA[0, 0] - mB[0, 0]), (mA[0, 1] - mB[0, 1]), (mA[0, 2] - mB[0, 2]), (mA[1, 0] - mB[1, 0]), (mA[1, 1] - mB[1, 1]), (mA[1, 2] - mB[1, 2]), (mA[2, 0] - mB[2, 0]), (mA[2, 1] - mB[2, 1]), (mA[2, 2] - mB[2, 2]));

            Console.ReadKey();
            Menu();
        }
        static void MULTIPLICAÇÃO()
        {
            Console.Clear();
            // declaração das matrizes 
            int[,] mAi = new int[3, 3];    //CALCULO DA MATRIZ INVERSA
            int[,] mA = new int[3, 3];  //MATRIZ A
            int[,] mB = new int[3, 3]; // MATRIZ B
            string[,] inversaA = new string[3, 3]; // MATRIZ INVESA COMPLETA

            Console.WriteLine("Digite uma matriz: \n");

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    mA[i, j] = 0;
                }
            }

            /////////////////////////////////////////CRIAR MATRIZ 1/////////////////////////////////////////////

            int m = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'a{0}{1}': ", m, n);
                    mA[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                m++;
            }

            /////////////////////////////////////////MOSTRA MATRIZ 1/////////////////////////////////////////////
            Console.WriteLine("\n|{0}  {1}  {2}|", mA[0, 0], mA[0, 1], mA[0, 2]);
            Console.WriteLine("|{0}  {1}  {2}|", mA[1, 0], mA[1, 1], mA[1, 2]);
            Console.WriteLine("|{0}  {1}  {2}|\n", mA[2, 0], mA[2, 1], mA[2, 2]);
            int M = 1;
            for (int i = 0; i <= 2; i++)
            {

                int n = 1;
                for (int j = 0; j <= 2; j++)
                {

                    Console.Write("Digite um número para a matriz 'b{0}{1}': ", M, n);
                    mB[i, j] = int.Parse(Console.ReadLine());

                    n++;
                }
                M++;
            }
            Console.WriteLine("MULTIPLICAÇÃO DAS MATRIZES");
            Console.WriteLine("\n|{0}  {1}  {2}|\n|{3}  {4}  {5}|\n|{6}  {7}  {8}|\n", (mA[0, 0] * mB[0, 0] + mA[0, 1] * mB[1, 0] + mA[0, 2] * mB[2, 0]), (mA[0, 0] * mB[0, 1] + mA[0, 2] * mB[1, 1] + mA[0, 2] * mB[2, 1]), (mA[0, 0] * mB[0, 2] + mA[0, 1] * mB[0, 2] + mA[0, 2] * mB[2, 2]), (mA[1, 0] * mB[0, 0] + mA[1, 1] * mB[1, 0] + mA[1, 2] * mB[2, 0]), (mA[2, 1] * mB[0, 1] + mA[1, 1] * mB[1, 1] + mA[1, 2] * mB[2, 1]), (mA[1, 0] * mB[0, 2] + mA[1, 1] * mB[1, 2] + mA[1, 2] * mB[2, 2]), (mA[2, 0] * mB[0, 0] + mA[2, 1] * mB[1, 0] + mA[2, 2] * mB[2, 0]), (mA[2, 0] * mB[0, 1] + mA[2, 1] * mB[1, 1] + mA[2, 2] * mB[2, 1]), (mA[2, 0] * mB[0, 2] + mA[2, 1] * mB[1, 2] + mA[2, 2] * mB[2, 2]));
            //     Console.WriteLine("\n|{0}  {1}  {2}|\n|{3}  {4}  {5}|\n|{6}  {7}  {8}|\n", (a11     * b11 +     a12 *   b21 +           a13 *   b31), (a11 *         b12 +      a12 *       b22 +    a13 * b32), (a11 * b13 + a12 * b23 + a13 * b33), (a21 * b11 + a22 * b21 + a23 * b31), (a21 * b12 + a22 * b22 + a23 * b32), (a21 * b13 + a22 * b23 + a23 * b33), (a31 * b11 + a32 * b21 + a33 * b31), (a31 * b12 + a32 * b22 + a33 * b32), (a31 * b13 + a32 * b23 + a33 * b33));

            Console.ReadKey();
            Menu();
        }
        static void Main(string[] args)
        {
            Menu(); // chama a função Menu

        }

    }
}
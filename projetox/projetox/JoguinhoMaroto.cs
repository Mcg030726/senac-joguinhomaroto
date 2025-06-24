using System;


namespace projetox
{
    class JoguinhoMaroto
    {
        static char[,] mapa;
        static int largura = 100;
        static int altura = 50;
        static int playerX = 1;
        static int playerY = 1;
        static bool jogando = true;


        public static void Main()
        {
            Console.Clear();
            // aqui entrar o menu de vcs 
            jogar();
        }



        public static void jogar()
        {
            iniciarMapa();
            while (jogando)
            {
                Console.Clear();
                DesenharMapa();



                var tecla = Console.ReadKey(true).Key;

                AtualizarPosicao(tecla);

            }
        }

        static void iniciarMapa()
        {
            mapa = new char[largura, altura];

            for (int x = 0; x < largura; x++)
            {
                for (int y = 0; y < altura; y++)
                {
                    if (x == 0 || y == 0 || x == largura - 1 || y == altura - 1)
                    {
                        mapa[x, y] = '@';
                    }
                    else
                    {
                        mapa[x, y] = ' ';
                    }
                }
            }

            mapa[playerX, playerY] = '@';

        }

        static void DesenharMapa()

        {
            
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Console.Write(mapa[x, y]);
                }

                Console.WriteLine();
            }            

        }

        static void AtualizarPosicao(ConsoleKey tecla)
        {

            int tempX = playerX;
            int tempY = playerY;

            switch (tecla)
            {
                case ConsoleKey.A:
                    tempX--;
                    break;
                case ConsoleKey.S:
                    tempY++;
                    break;
                case ConsoleKey.D:
                    tempX++;
                    break;
                case ConsoleKey.W:
                    tempY--;
                    break;

            }

            if (mapa[tempX, tempY] != '#')
            {
                mapa[playerX, playerY] = ' ';
                mapa[tempX, tempY] = '@';
                playerX = tempX;
                playerY = tempY;
            }
        }
    }

    }







        
   
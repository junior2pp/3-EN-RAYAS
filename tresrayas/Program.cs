using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace tresrayas
{
    class Program
    {
        static string juga1="";
        static string juga2="";
        static string ganador = "EMPATE";
        static int diagonalx = 0 ,diagoanly = 0;
        static int diagonalinversax = 0, diagonaliversay = 0;
        static int filax1 = 0,filay1 = 0;
        static int filax2 = 0,filay2 = 0;
        static int filax3 = 0,filay3 = 0;
        static int columx1 = 0 ,colimy1 = 0;
        static int columx2 = 0, columy2 = 0;
        static int columx3 = 0, columy3 = 0;

        static void comprobar( string[,] mat)
        {
            int j = 2;
            for (int i = 0; i < 3; i++)
            {
                if (mat[i,i] == "X"){diagonalx++;}else{diagonalx = 0;}
                if (mat[j,j] == "X") { diagonalx++; } else { diagonalx = 0;}

                if (mat[i,i] == "O"){diagoanly++;}else{diagoanly = 0;}
                if (mat[j,j] == "O") { diagoanly++; } else { diagoanly = 0; }

                if (mat[j,i] == "X"){diagonalinversax++;}else{diagonalinversax = 0;}
                if (mat[i,j] == "X") { diagonalinversax++; } else { diagonalinversax = 0;}

                if (mat[j,i] == "O"){diagonaliversay++;}else{diagonaliversay = 0;}
                if (mat[i,j] == "O") { diagonaliversay++; } else { diagonaliversay = 0; }

                if (mat[i,0] == "X"){filax1++; }else{filax1 = 0;}
                if (mat[j,0] == "X") { filax1++; } else { filax1 = 0; }

                if (mat[i,0] == "O") { filay1++; } else { filay1 = 0; }
                if (mat[j,0] == "O") { filay1++; } else { filay1 = 0; }

                if (mat[i,1] == "X"){filax2++;}else{filax2 = 0;}
                if (mat[j,1] == "X") { filax2++; } else { filax2 = 0; }

                if (mat[i,1] == "O"){filay2++;}else{filay2 = 0;}
                if (mat[j,1] == "O"){ filay2++; }else{ filay2 = 0;}

                if (mat[i,2] == "X"){filax3++;}else{filax3 = 0;}
                if (mat[j,2] == "X") { filax3++; } else { filax3 = 0;}

                if (mat[i,2] == "O"){filay3++;}else{filay3 = 0;}
                if (mat[j,2] == "O") { filay3++; } else { filay3 = 0; }

                if (mat[0,i] == "X"){columx1++;}else{columx1 = 0;}
                if (mat[0,j] == "X") { columx1++; } else { columx1 = 0; }

                if (mat[0,i] == "O"){colimy1++;}else{colimy1 = 0;}
                if (mat[0,j] == "O") { colimy1++; } else { colimy1 = 0; }

                if (mat[1,i] == "X"){columx2++;}else{columx2 = 0;}
                if (mat[1,j] == "X") { columx2++; } else { columx2 = 0; }

                if (mat[1,i] == "O"){columy2++;}else{columy2 = 0;}
                if (mat[1,j] == "O") { columy2++; } else { columy2 = 0; }

                if (mat[2,i] == "X"){columx3++;}else{columx3 = 0;}
                if (mat[2,j] == "X") { columx3++; } else { columx3 = 0; }

                if (mat[2,i] == "O"){columy3++;}else{columy3 = 0;}
                if (mat[2,j] == "O") { columy3++; } else { columy3 = 0; }
                j--;
            }
        }
        static void mostrar( string[,] mat,string valor,string signo)
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition((5*i)+50,(2*j)+10);
                    Console.Write(mat[i,j]);
                    if (mat[i,j] == valor)
                    {
                        
                        mat[i, j] = signo;
                    }
                }
            }
        }

        static void conjugadores()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(5, 10);
            Console.Write("Ingrese Nombre del Jugador 1: ");
            juga1 = Console.ReadLine();
            Console.SetCursorPosition(5, 11);
            Console.Write("Ingrese Nombre del Jugador 2: ");
            juga2 = Console.ReadLine();
            Console.Clear();
        }
        static void jugar()
        {
            string[,] matriz;

            matriz = new string[3, 3];
            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = num.ToString();
                    num++;
                }
            }

            bool estado = true;
            mostrar(matriz, "", "");
            int conta = 0;
            while (estado)
            {
                mostrar(matriz, "", "");
                Console.SetCursorPosition(2, 15);
                string sig = "X";
                Console.Write(" {0} NÚMERO DEL 1 AL 9 JUEGAS CON {1}:  ", juga1.ToUpper(), sig);
                string respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();
                mostrar(matriz, respuesta, sig);
                comprobar(matriz);
                if (diagonalx >= 3 || filax1 >= 3 || diagonalinversax >= 3 || filax2 >= 3 || filax1 >= 3 || filax3 >= 3 || columx1 >= 3 || columx2 >= 3 || columx3 >= 3)
                {
                    mostrar(matriz, "", "");
                    ganador = juga1;
                    break;
                }
                Console.Clear();
                mostrar(matriz, "", "");
                if (conta >= 4)
                {

                    estado = false;
                    break;
                }
                Console.SetCursorPosition(2, 15);
                sig = "O";
                Console.Write(" {0} NÚMERO DEL 1 AL 9 JUEGAS CON {1}:  ", juga2.ToUpper(), sig);
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();

                mostrar(matriz, respuesta, sig);
                comprobar(matriz);
                if (diagoanly >= 3 || filay1 >= 3 || diagonaliversay >= 3 || filay2 >= 3 || filay1 >= 3 || filay3 >= 3 || colimy1 >= 3 || columy2 >= 3 || columy3 >= 3)
                {
                    mostrar(matriz, "", "");
                    ganador = juga2;
                    break;
                }
                Console.Clear();
                conta++;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(35, 17);
            Console.Write("JUEGO TERMINADO EL GANADOR ES: " + ganador);
        }
        static void Main(string[] args)
        {
            //SoundPlayer usar = new SoundPlayer();
            //usar.SoundLocation = "oliver.wav";
            //usar.Play();
            Console.SetCursorPosition(7,40);
            Console.Write("Desarrollado por by Luis Suárez");
            conjugadores();
            Console.SetCursorPosition(2,7);
            jugar();
            bool estado = true;

            while (estado)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.SetCursorPosition(35, 19);
                Console.Write("Desea Volver a Jugar SI/NO: ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "SI")
                {
                    Console.Clear();
                    jugar();
                }
                if (respuesta.ToUpper() == "NO")
                {
                    Environment.Exit(0);
                }
            }
            
        }
    }
}

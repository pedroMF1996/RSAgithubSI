using System;
using System.Globalization;

namespace RSAgithubSI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * RSA

            P  = 11

            Q = 17

            N = P*Q = 187

            Z = (P-1)*(Q-1) = 160

            MDC
            160     D	| 1
	                    |
	                    |
    	                |

            D será a chave privada
            D = 7

            for>(E * D) mod Z = 1

            > E tem que ser não multiplo de Z * D

            E é a chave publica
            E = 23


            Chave publica: (E,N) 23, 187
            
            Chave privada: (D,N) 


            K = (Nº da letra ^ E) mod N
            
            Nº da letra = ( Log E na base K ) * K

             */
            
            double P = 0.0, Q = 0.0;
            double N = P * Q;
            double Z = P-1 * Q-1;
            double D = 0;
            double E = 0.0;
//            Console.Write("Entre com a Quantidade desejada de teste: ");
//            int qteDesejada = Int32.Parse(Console.ReadLine());

            while ((D % Z == 1) && D!=1 && D != 0 && D < Z)
            {
                D++;
            }

            Console.WriteLine($"O {D.ToString("f2",CultureInfo.InvariantCulture)}");

            while ((E * D)%Z != 1)
            {
                Console.WriteLine($"Teste {E.ToString("f2",CultureInfo.InvariantCulture)}");
                E++;
            }
        }
    }
}
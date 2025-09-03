using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();


            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);

                Console.WriteLine("Operação atual: {0} {1} {2} = {3}",
                    operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // Imprime a fila de operações restantes
                if (filaOperacoes.Count > 0)
                {
                    Console.WriteLine("Próximas operações:");
                    foreach (var op in filaOperacoes)
                    {
                        Console.WriteLine("  {0} {1} {2}", op.valorA, op.operador, op.valorB);
                    }
                }
                else
                {
                    Console.WriteLine("Sem operações restantes na fila.");
                }

                Console.WriteLine(new string('═', 40));
            }



        }
    }
}

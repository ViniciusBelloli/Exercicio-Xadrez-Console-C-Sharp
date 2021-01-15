﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
   class Program
   {
      static void Main(string[] args)
      {
         try
         {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
               Console.Clear();
               Tela.ImprimirTabuleiro(partida.Tab);

               Console.Write("\nOrigem: ");
               Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
               Console.Write("Destino: ");
               Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

               partida.ExecutaMovimento(origem, destino);
            }
         }
         catch(TabuleiroException e)
         {
            Console.WriteLine(e.Message);
         }
      }
   }
}
/*  
*   Algoritmo de ordenação rápida em C#
*/  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortQuick
{
  class quickSort
  {
  
  private int[] indice = new int[20];
  private int tam;
  
  public void QuickSort()
  {
      ordena(0, tam - 1);
   }

  public void ordena(int esquerda, int direita)
  {
      int pivo, esquerdaFimse, direitaFimse;
      esquerdaFimse = esquerda;
      direitaFimse = direita;
      pivo = indice[esquerda];
    while(esquerda<direita)
    {
      while((indice[direita] >= pivo) && (esquerda < direita))
      {
        direita--;
      }
      if(esquerda != direita)
        {
            indice[esquerda] = indice[direita];
            esquerda++;
        }
      while((indice[esquerda] <= pivo) && (esquerda < direita))
        {
          esquerda++;
        }
      if(esquerda != direita)
        {
          indice[direita] = indice[esquerda];
          direita--;
        }
    }
    indice[esquerda] = pivo;
    pivo = esquerda;
    esquerda = esquerdaFimse;
    direita = direitaFimse;
    if(esquerda < pivo)
      {
        ordena(esquerda, pivo - 1);
      }
      if(direita > pivo)
        {
          ordena(pivo + 1, direita);
        }
  }

  public static void Main()
  {
      quickSort qSort = new quickSort();
      int[] indice = {4,3,1,49,6,7,5,41,32,2,26,187,8};
      qSort.indice = indice;
      qSort.tam = qSort.indice.Length;
      qSort.QuickSort();
      for(int j = 0; j < qSort.tam; j++)
        {
          Console.WriteLine(qSort.indice[j]);
        }
      Console.ReadKey();
  }
  }
}
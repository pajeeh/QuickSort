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
      direitaFimse = direita
      pivo = array[esquerda];
    while(esquerda<direita)
    {
      while((indice[direita] >= pivo) && (esquerda < direita))
      {
        direita--;
      }

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

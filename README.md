# QuickSort
Algoritmo do **[Quicksort](https://pt.wikipedia.org/wiki/Quicksort)** implementado em Python. 

Assim como o **[Merge Sort](https://pt.wikipedia.org/wiki/Merge_sort)**, o QuickSort é um algoritmo de divisão e conquista. Ele escolhe um elemento como pivô e particiona o array fornecido ao redor do pivô escolhido. Existem muitas versões diferentes do QuickSort que selecionam o pivô de maneiras diferentes.  

##

#### Exemplos:
  - Primeiro elemento como pivô.
  - Último elemento como pivô.
  - Elemento aleatório como pivô.
  - Mediana como pivô. 

##

O principal processo no **QuickSort** é a partição (). O destino das partições é, dado uma matriz e um elemento ***x*** da matriz como pivô, 
colocar ***x*** em sua posição correta na matriz classificada e colocar todos os elementos menores (menores que x) antes de ***x***, 
e colocar todos os elementos maiores (maiores que x) depois ***x***. Tudo isso deve ser feito em tempo linear.

##

### Pseudo-Código para uma função recursiva do QuickSort:

```
quickSort(indice[], primeiro, ultimo) 
// Inicializando o índice com o primeiro elemento e finalizando com o último elemento.
{
    if (primeiro < ultimo){
        
        // O pivô começa a particionar o índice a partir daqui, indice[pivo] agora está à direita.
           
        pivo = particionando(indice, primeiro, ultimo);

        quickSort(indice, primeiro, pivo - 1);  // Antes
        quickSort(indice, pivo + 1, ultimo); // Depois
    }
}
```

##

<p align="center">
  <img src="https://user-images.githubusercontent.com/48485199/129904463-bddfb862-5c35-4785-8de1-0e7402a2bf94.png?raw=true" alt="QuickSort algorithm"/>
</p>

[Referências]: <> (https://www.geeksforgeeks.org/quick-sort/)
[Referências]: <> (https://pt.wikipedia.org/wiki/Quicksort)
[Referências]: <> (https://pt.wikipedia.org/wiki/Merge_sort)

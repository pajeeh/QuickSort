# Ruby é uma linguagem de tipagem forte





def quick(indice, primeiro, ultimo)
    if primeiro < ultimo
        swap = particao(indice, primeiro, ultimo)
        desce = swap[0]
        sobe = swap[1]
        quick(indice, primeiro, desce - 1)
        quick(indice, sobe + 1, ultimo)
    end
end

def particao(indice, primeiro, ultimo)
    pivo = indice[primeiro]
    i = primeiro + 1
    menorQ += primeiro
    maiorQ = ultimo
    
    while(i <= maiorQ)
        if indice[i] < pivo
            swap = indice[menorQ]
            indice


elsif indice[i] > pivo
    swap = a[i]
    a[i] = a[maiorQ]
    a[maiorQ] = swap
    maiorQ -= 1
else
    
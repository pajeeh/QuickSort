def quick(vetor, inicio, fim)
  if inicio < fim
    pivo = particao(vetor, inicio, fim)
    quick(vetor, inicio, pivo -1)
    quick(vetor, pivo + 1, fim)
  end
  vetor
end

def particao(vetor, inicio, fim)
  vetorAtual = inicio
  i = inicio
  while i < fim do
    if vetor[i] <= vetor[fim]
      swap(vetor, i, vetorAtual)
      vetorAtual += 1
    end
    i += 1
  end
  swap(vetor, fim, vetorAtual)
  vetorAtual
end

def swap(vetor, primeiro, ultimo)
  temp = vetor[primeiro]
  vetor[primeiro] = vetor[ultimo]
  vetor[ultimo] = temp
end

puts quick([54, 26, 93, 17, 77, 31, 44, 55, 20, 23],0,9).inspect 

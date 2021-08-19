def quickSort(indice):
    quickSortTam(indice, len(indice)-1)
  
def quickSortTam(indice, primeiro, ultimo):
	if primeiro < ultimo:
		
		pivo = particao(indice, primeiro, ultimo)
     
		quickSortTam(indice, primeiro, pivo - 1)
    	quickSortTam(indice, pivo+1, ultimo)
		
def particao(indice, primeiro, ultimo):
	pivoNum = indice[primeiro]
  
	esquerda = primeiro + 1
	direita = ultimo
  
  	flag = False
 	while not flag:
    
    	while esquerda <= direita and indice[esquerda] <= pivoNum:
			esquerda = esquerda + 1
		
		while indice[direita] >=pivoNum and direita >= esquerda:
			direita = direita - 1
	
		if direita < esquerda:
			flag = True
		else:
			swap = indice[esquerda]
			indice[esquerda] = indice[direita]
			indice[direita] = swap
			
	swap = indice[primeiro]
	indice[primeiro] = indice[direita]
	indice[direita] = swap

	return direita

indice = [54, 26, 93, 17, 77, 31, 44, 55, 20, 23]

# implementar tempo de execução para teste de eficiência

quickSort(indice)
print(indice)

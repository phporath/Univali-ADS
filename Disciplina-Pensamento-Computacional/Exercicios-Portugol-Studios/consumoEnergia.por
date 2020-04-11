programa
{
	
	funcao inicio()
	{
		caracter nome[4]
		inteiro potencia[4], potenciaKw[4], hora[4], i
		real kwh, consAparelho, consDia, conta

		kwh = 0.3
		consDia= 0.000
		consAparelho = 0.000
		conta= 0.000
		i = 0
		
		enquanto(i<=3)
		{
			escreva("Insira o nome do aparelho: ")
			leia(nome[i])
			escreva("Insira potência em watts: ")
			leia(potencia[i])
			escreva("Insira quantidade de horas utilizada no dia: ")
			leia(hora[i])
			potenciaKw[i] = potencia[i]*0.001
			consAparelho = potenciaKw[i]*hora[i]
			escreva("Por dia o aparelho ",nome[i],"consome ",consAparelho," kwh")
			consDia = consDia + consAparelho
			conta = consDia * 30 * kwh
			i=i+1				
		}		
				
		escreva("Conta de energia elétrica ao final do mês: R$",conta)
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 0; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = {nome, 6, 11, 4}-{potencia, 7, 10, 8}-{potenciaKw, 7, 23, 10}-{hora, 7, 38, 4}-{i, 7, 47, 1}-{kwh, 8, 7, 3}-{consAparelho, 8, 12, 12}-{consDia, 8, 26, 7}-{conta, 8, 35, 5};
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
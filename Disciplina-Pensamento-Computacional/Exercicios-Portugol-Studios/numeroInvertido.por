programa
{
	
	funcao inicio()
	{
		inteiro nu, aux, nuinv
		
		escreva("Insira o número a ser invertido: ")
		leia(nu)
		aux = nu
		nuinv = 0
		enquanto (aux > 0)
		{
			nuinv = nuinv*10+(aux%10)
			aux = aux/10
		}
		escreva("O número ",nu, "invertido é ",nuinv)	
		
	}
}






/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 211; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
programa
{
	
	funcao inicio()
	{
		real mDolar, mReal, cotacao
		inteiro opcao
		
		escreva("Bem vindo ao conversor de moeda\n")
		escreva("Escolha uma das opções abaixo: \n")
		escreva("1 - Dolar para real\n")
		escreva("2 - Real para dolar\n")
		escreva("3 - Sair\n")
		leia(opcao)
		
		escolha (opcao)
		{
			caso 1:
				escreva("Qual a cotação do dolar em relação ao real?\n")
				leia(cotacao)
				
				escreva("Quantos reais serão convertidos?\n")
				leia(mReal)
				
				mDolar = mReal / cotacao
		
				escreva("R$",mReal," no câmbio de hoje equivale a U$",mDolar)
			pare

			caso 2:
				escreva("Qual a cotação do real em relação ao dolar?\n")
				leia(cotacao)
				
				escreva("Quantos dólares serão convertidos?\n")
				leia(mDolar)
				
				mReal = mDolar / cotacao
		
				escreva("U$",mDolar," no câmbio de hoje equivale a R$",mReal)
			pare

			caso 3:
				//fim do processo
			pare

			caso contrario:
				escreva("Entrada inválida, insira um número de 1 a 3\n")
			
		}
		
	}
}


/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 979; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
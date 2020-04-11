programa
{
	
	funcao inicio()
	{
		real salBruto, vendaMes, comissao, salComissao 

		escreva("Digite o valor do salário do funcionário: \n")
		leia(salBruto)

		escreva("Digite o valor de vendas do funcionário no mês: \n")
		leia(vendaMes)

		se (vendaMes < 55000)
		{
			comissao = 100
		}
		senao se (vendaMes >= 55000 e vendaMes <= 100000)
		{
			comissao = vendaMes * 0.02
		}
		senao
		{
			comissao = 5000
		}

		salComissao = salBruto + comissao
		
		escreva("Para esse mês, o funcionário teve comissão de R$",comissao, ". Dessa forma, sendo R$", salComissao, " o valor de salário e comissão")

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 601; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
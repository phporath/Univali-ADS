programa
{

	funcao inicio()
	{
		inteiro qtdeMasc, qtdeFem, qtdeNaoDecl, qtdeHora = 0
		real salBruto, salLiquido, descSal, valHora, folha, porcDes = 0.00

		escreva("Digite a quantidade de funcionários do sexo masculino: \n")
		leia(qtdeMasc)

		escreva("Digite a quantidade de funcionários do sexo feminino: \n")
		leia(qtdeFem)

		escreva("Digite a quantidade de funcionários que não declararam o sexo: \n")
		leia(qtdeNaoDecl)
				
		escreva("Digite a quantidade de horas trabalhadas no mês: \n")
		leia(qtdeHora)
		
		escreva("Digite o valor da hora trabalhada: \n")
		leia(valHora)
		
		escreva("Digite o  valor da porcentagem de desconto *Obs: em decimal: \n")
		leia(porcDes)
		
		salBruto = qtdeHora*valHora
		escreva("Valor do salário bruto: R$",salBruto,"\n")
		
		salLiquido = salBruto-(salBruto*porcDes)
		escreva("Valor do salário líquido: R$",salLiquido,"\n")

		descSal = salBruto*porcDes
		escreva("Valor do desconto do salário: R$",descSal,"\n")

		folha = (qtdeMasc + qtdeFem + qtdeNaoDecl)*salBruto
		escreva("Valor da folha de salário da empresa é de R$",folha)

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1083; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
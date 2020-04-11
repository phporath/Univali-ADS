programa
{
	
	funcao inicio()
	{

		real valFrete, valRastreamento = 0, distKm, valFretePecas, valLitro, valFreteKm
		inteiro regiao, qtdePecas
		caracter rastreamento

		escreva("Qual a distância em km percorrida?\n")
		leia(distKm)

		escreva("Quantas peças serão transportadas?\n")
		leia(qtdePecas)
		
		escreva("Deseja fazer a entrega com rastreamento? (S/N)\n")
		leia(rastreamento)

		se (rastreamento == 'S')
		{
			valRastreamento = 200	
		}
		senao
		{
			valRastreamento = 0
		}
		
		escreva("Regiões para frete \n")
		escreva("1 - Sul\n")
		escreva("2 - Sudeste\n")
		escreva("3 - Centro-oeste\n")
		leia(regiao)

		se (regiao == 1)
		{
			se (qtdePecas <= 1000)
			{
				valFretePecas = qtdePecas * 1
			}
			senao
			{
				valFretePecas = 1000*1 + (qtdePecas-1000) * 0.9
			}
		}
		senao se (regiao == 2)
		{
			se (qtdePecas <= 1000)
			{
				valFretePecas = qtdePecas * 1.2
			}
			senao
			{
				valFretePecas = 1000*1.2 + (qtdePecas-1000) * 1.056
			}
		}
		senao
		{
			se (qtdePecas <= 1000)
			{
				valFretePecas = qtdePecas * 1.3
			}
			senao
			{
				valFretePecas = 1000*1.3 + (qtdePecas-1000) * 1.131
			}
		}
		
		valLitro = 3.57
		valFreteKm = valLitro*distKm
		valFrete = valRastreamento + valFretePecas + valFreteKm

		escreva("Taxa de rastreamento R$",valRastreamento,"\n")
		escreva("Valor de frete pelas peças R$",valFretePecas,"\n")
		escreva("Valor de frete por km R$",valFreteKm,"\n")
		escreva("Total do frete R$",valFrete,"\n")

	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1467; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
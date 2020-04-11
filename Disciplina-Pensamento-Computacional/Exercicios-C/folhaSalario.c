#include<stdio.h>

int main()
{

    int qtdeMasc=0;
    printf("Digite a quantidade de funcionários do sexo masculino: \n");
    scanf("%d", &qtdeMasc);
   
    int qtdeFem=0;
    printf("Digite a quantidade de funcionários do sexo feminino: \n");
	scanf("%d", &qtdeFem);

    int qtdeNaoDecl=0;
    printf("Digite a quantidade de funcionários que não declararam o sexo: \n");
	scanf("%d", &qtdeNaoDecl);

    int qtdeHora=0;
    printf("Digite a quantidade de horas trabalhadas no mês: \n");
	scanf("%d", &qtdeHora);

    float porcDes=0.00;
    printf("Digite o  valor da porcentagem de desconto *Obs: em decimal: \n");
	scanf("%f",&porcDes);
    
    float valHora=0.00;
    printf("Digite o  valor da hora trabalhada: \n");
	scanf("%f",&valHora);    

    float salBruto=0.00;
    salBruto=qtdeHora*valHora;
	printf("Valor do salário bruto: R$%f\n",salBruto);

	float salLiquido=0.00;
    salLiquido=salBruto-(salBruto*porcDes);
	printf("Valor do salário líquido: R$%f\n",salLiquido);

	float descSal = 0.00;
    descSal = salBruto*porcDes;
	printf("Valor do desconto do salário: R$%f\n",descSal);

    float folha = 0.00;
    folha = (qtdeMasc+qtdeFem+qtdeNaoDecl)*salBruto;
    printf("Valor da folha salarial da empresa: R$%f\n",folha);

    return 0;
}
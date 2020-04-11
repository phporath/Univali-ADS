#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <conio.h>

int main()
{
    char valor[50], temp;
    int cont, valorInicial, valorCalculado=0, menu, resultadoDiv, i, cont2, aux=0, nuInv=0;

    do // comando faça enquanto
    { 
        system("cls");  //função para limpar a tela
        printf("1 - Decimal para Binário\n");
        printf("2 - Binário para Decimal\n");
        printf("3 - Sair\n");
        
        do
        {
            scanf("%d", &menu); //recebe o valor da opção do menu
        }
        while (menu<1||menu>3); // faça enquanto menu for maior que 1 OU "||" menor que 3
        switch(menu) // switch = escolha
        {
            case 1:

                // Decimal para Binario

                printf("\nInsira o número a ser convertido: ");
                scanf("%d", &valorInicial);
                cont=0; // inicializa a variável em 0
                i=0; 
                while (i!=1) // != diferente de...
                {
                    resultadoDiv=valorInicial/2;
                    if (resultadoDiv<2)
                    {
                        i=1;
                        if (valorInicial%2==0)
                        {
                            valor[cont]='0';
                        }
                        else
                        {
                            valor[cont]='1';
                        }
                        if (resultadoDiv==0)
                        {
                            valor[cont+1]='0';
                        }
                        else
                        {
                            valor[cont+1]='1';
                        }
                            valor[cont+2]='\0';
                    }
                    else
                    {
                        if (valorInicial%2==0)
                        {
                            valor[cont]= '0';
                        }
                        else
                        {
                            valor[cont]= '1';
                        }
                    }
                    cont++; //incremento na variável cont
                    valorInicial=resultadoDiv; //valor inicial é atualizado com o resultado da divisão
                }              
                
                cont2=strlen(valor)-1; // strlen calcula o comprimento de uma string. Despois ela é subtraída por 1 
                for (cont=0; cont<=cont2; cont++) //esse bloco inverte a string com valores binários gravados
                {
                    temp=valor[cont];
                    valor[cont]=valor[cont2];
                    valor[cont2]=temp;
                    cont2--; //decremento
                }                           
                printf("\n%s", valor);
                fflush(stdin); //função limpa o buffer de entrada "stdin"
                getch();

            break;

            case 2:

                //Binário para Decimal
                
                printf("\nInsira o número a ser convertido: ");
                scanf("%s", &valor);
                
               /* while (cont<strlen(valor))
                {
                    if (valor[cont]=='1')
                    {
                        valorCalculado=valorCalculado+pow(2, strlen(valor)-(cont+1));
                    }
                    if (valor[cont]!='1'&&valor[cont]!='0')
                    {
                        printf("\nInvalid Values!");
                        cont=strlen(valor); //Ending the loop...
                    }
                    cont++;
                }*/
                
                
                
                for (cont=0; cont<strlen(valor); cont++)
                {
                    if (valor[cont]=='1')
                    {
                        valorCalculado=valorCalculado+pow(2, strlen(valor)-(cont+1));
                    }
                    if (valor[cont]!='1'&&valor[cont]!='0')
                    {
                        printf("\nInvalid Values!");
                        cont=strlen(valor); //Ending the loop...
                    }
                }
                printf("%d", valorCalculado);
                fflush(stdin);
                getch();
            break;
                                             
            default:
            printf("Número inválido, escolha outro número de 1 à 3");
            break;
            
            }

     }while (menu!=3); // fecha a função de Menu.
}
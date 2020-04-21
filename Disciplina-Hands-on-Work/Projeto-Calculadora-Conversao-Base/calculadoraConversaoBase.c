#include <stdio.h> // biblioteca padrão do C (comandos como printf scanf, etc...)
#include <string.h> // manipulação de cadeias de caracteres
#include <stdlib.h> // alocação de memória 
#include <conio.h> // manipular caracteres na tela
#include <windows.h> // para adicionar caracteres especiais (UTF-8)
#include <math.h> // instruções matemáticas

int main()
{
    // os comandos abaixos servem para configuração de caracteres especiais
    UINT CPAGE_UTF8 = 65001;
    UINT CPAGE_DEFAULT = GetConsoleOutputCP();
    SetConsoleOutputCP(CPAGE_UTF8);

    //variáveis globais
    char valor[50], temp=0;
    int cont, valorInicial, valorCalculado=0, menu, resultadoDiv=0, i, cont2=0, aux=0, nuInv=0;

    do // enquanto o número 3 não for digitado, a operação continua
    { 
        system("cls");  //função para limpar a tela
        printf("Digite uma das opções abaixo:\n\n");
        printf("1 - Decimal para Binário\n");
        printf("2 - Binário para Decimal\n");
        printf("3 - Sair\n");
        
        do
        {
            scanf("%d", &menu); //recebe o valor da opção do menu apenas se "menu<1||menu>3"
        }
        while (menu<1||menu>3);

        switch(menu) // responsável pelas intruções das opções 1 e 2
        {
            case 1:

                // Conversão de Decimal para Binário
                printf("\nInsira um número decimal: ");
                scanf("%d", &valorInicial);
                cont=0;
                i=0; 
                while (i!=1)
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
                printf("\nNúmero binário correspondente: %s\n\n", valor);
                printf("Pressione ENTER para voltar ao menu");
                fflush(stdin); //função limpa o buffer de entrada "stdin"
                getch(); // retorna a tecla digitada
                break;

            case 2:

                //Binário para Decimal
                printf("\nInsira um número binário: ");
                scanf("%s", &valor);             
                
                for (cont=0; cont<strlen(valor); cont++)
                {
                    if (valor[cont]=='1')
                    {
                        valorCalculado=valorCalculado+pow(2, strlen(valor)-(cont+1));
                    }
                    if (valor[cont]!='1'&&valor[cont]!='0')
                    {
                        printf("\nInvalid Values!");
                        cont=strlen(valor); //Termina o loop...
                    }
                }
                printf("Número decimal correspondente: %d\n\n", valorCalculado);
                printf("Pressione ENTER para voltar ao menu");
                fflush(stdin);
                getch(); // retorna a tecla digitada
                break;

            case 3:
                printf("Obrigado por usar a calculadora, até a próxima.\n");
                break; 
            }
    }while (menu!=3); // Finaliza a função de Menu.
}
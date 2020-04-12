#include <stdio.h>
int main()
{
    int opcao=-1, ws=0, unix=0, linux=0, netware=0, macOS=0, outro=0, totalVotos=0;
    float percWs=0.00, percUnix=0.00, percLinux=0.00, percNetware=0.00, percMacOS=0.00, percOutro=0.00;

    while (opcao!=0)
    {
        printf("Qual o melhor sistema operacional para uso em servidores:\n");
        printf("1 - Windows Server\n");
        printf("2 - Unix\n");
        printf("3 - Linux\n");
        printf("4 - Netware\n");
        printf("5 - Mac OS\n");
        printf("6 - Outro\n");
        printf("0 - Sair\n");
        scanf("%d", &opcao);
        
        if (opcao==1)
        {
            ws=ws+1; 
        }
        else if (opcao==2)
        {
            unix=unix+1;
        }
        else if (opcao==3)
        {
            linux=linux+1;
        }
        else if (opcao==4)
        {
            netware=netware+1; 
        }
        else if (opcao==5)
        {
            macOS=macOS+1;  
        }
        else if (opcao==6)
        {
            outro=outro+1; 
        }
        else if (opcao==0)
        {
            printf("Obrigado por participar dessa enquete!\n"); 
        }
        else
        {
            printf("Insira um valor válido (0 à 6)\n");
            opcao=-1;
        }
    }

    totalVotos = ws+unix+linux+netware+macOS+outro;
    percWs = ((float)ws/totalVotos)*100;
    percUnix = ((float)unix/totalVotos)*100;
    percLinux = ((float)linux/totalVotos)*100;
    percNetware = ((float)netware/totalVotos)*100;
    percMacOS = ((float)macOS/totalVotos)*100;
    percOutro = ((float)outro/totalVotos)*100;

    printf("\n");

    printf("********************************************************\n");
    printf("Resultado da pesquisa:\n");
    printf("\n");
    printf("Sistema Operacional | Quantidade de votos | Porcentagem \n");
    printf("--------------------|---------------------|-------------\n");
    printf("Windows Server..... |         %d           |     %.2f \n",ws,percWs);
    printf("Unix............... |         %d           |     %.2f \n",unix,percUnix);
    printf("Linux...............|         %d           |     %.2f \n",linux,percLinux);
    printf("Netware Server......|         %d           |     %.2f \n",netware,percNetware);
    printf("MacOS...............|         %d           |     %.2f \n",macOS,percMacOS);
    printf("Outros..............|         %d           |     %.2f \n",outro,percOutro);
    printf("--------------------|---------------------|-------------\n");
    printf("Total de votos......|         %d          |     100.00\n",totalVotos);
}

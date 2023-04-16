#include<stdio.h>
#include<stdlib.h>
int main()
{
int idade,dif;
printf("digite a idade\n");
scanf("%i",&idade);
if(idade>=18)
printf("pode tirar cnh\n");
else
{
    printf("não pode tirar cnh\n");
    dif=18-idade;
    printf("faltam %i anos para completar 18\n",dif);
}
system("pause");
}

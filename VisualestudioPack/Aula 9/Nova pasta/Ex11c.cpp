#include<stdio.h>
#include<stdlib.h>
int main()
{
int id,d;
printf(" Digite a idade\n");
scanf("%i",&id);
if(id>=18)
printf("Voce pode tirar a CNH\n");
else
{
d=18-id;
printf("Faltam %i anos \n",d);
}
system ("pause");
}



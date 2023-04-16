#include<stdio.h>
#include<stdlib.h>
#include<math.h>
int main()
{
float a,b,c,d;
printf ("Digite os coeficientes a,b,c\n");
scanf("%f%f%f",&a,&b,&c);
if(a==0)
printf("Nao e equaçao do segundo grau\n");
else
{
d=pow(b,2)-4*a*c;
if(d>0)
printf("Ha duas raizes reais");
else
if(d==0)
printf("Ha uma raiz real");
else
printf("Nao ha raizes reais");
}
system("pause");
}




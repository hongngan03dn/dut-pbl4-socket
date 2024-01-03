#include <stdio.h> 
#include <math.h> 
const float eps=0.00001;
float saisotuyetdoi(float m, float n)
{ 	float f;
 	f=eps*m+eps*n;
 	return f;
}
int main()
{	float f1;
	float x=2.55925,y=2.58198;
	float m=3*x*x+4*y;
	float n=4*x+3*y*y;
	f1=x*x*x+4*x*y+y*y*y; 
	float saisotuongdoi=saisotuyetdoi(m,n)/fabs(f1);
	printf("BAI 1\n");
	printf("Sai so tuyet doi f(x,y)=%.6f\n",saisotuyetdoi(m,n));
	printf("Sai so tuong doi f(x.y)=%.6f",saisotuongdoi);
	
}

#include<stdio.h>
#include<math.h>

const float eps = pow(10,-6);

void nhap(float a[][100], int n)
{
	for(int i = 0; i <n ; i++)
	{
		for(int j = 0; j <= n; j++)
		{
			printf("\na[%d][%d] = ",i,j);
			scanf("%f", &a[i][j]);
		}
	}
}
void xuat(float a[][100], int n)
{
	for(int i = 0; i <n ; i++)
	{
		for(int j = 0; j <= n; j++)
		{
			printf("a[%d][%d] = %f\t",i,j, a[i][j]);
		}
		printf("\n");
	}
}

main()
{
	int n, t;
	float a[100][100], x[100],s, y[100];
	
	printf("n = "); scanf("%d", &n);
	nhap(a,n);
	xuat(a,n);
	
	for(int i = 0; i < n ; i++)
	{
		printf("\nNhap nghiem xap xi x[%d] : ",i);
		scanf("%f", &x[i]);
	}
	printf("\n");
	
	do
	{
		t=0;
		for(int i = 0; i < n ; i++)
		{
			s = 0;
			for(int j = 0; j < n ; j++)
			{
				if(j != i) s = s + a[i][j]*x[j];
			}
			y[i] = (a[i][n] - s)/a[i][i];
			if(fabs(y[i] - x[i]) >= eps) t = 1;
		}
		for(int i = 0; i<n; i++)
		{
			x[i] = y[i];
		}
	} while(t);
	
	for(int i = 0; i<n; i++)
	{
		printf("\nx[%d] = %f",i,x[i]);
	}
}

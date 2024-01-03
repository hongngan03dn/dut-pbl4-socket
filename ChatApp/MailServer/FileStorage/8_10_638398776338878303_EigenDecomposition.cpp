#include<stdio.h>
#include<math.h>
#include<conio.h>
#include<iostream>
#include<iomanip>

using namespace std;
const float max=100;
int n;
float a[100][100],b[100][100],c[100][100],m[100][100],m1[100][100],M[100][100],P[100][100],y[100][100],P1[100][100],ad[100][100],D[100][100],q[100][100];
float heso[100],lamda[100];

void nhapmtr(float a[][100], int n)
{	for (int i=1; i<=n; i++)
    {
        for (int j=1; j<=n; j++)
		{
            cout << "x[" << i << "]["<< j << "]= ";
            cin >> a[i][j];
        }
    }
}

void xuatmtr(float a[][100], int n)
{	int i,j;
	cout << endl;
	for(i=1;i<=n;i++)
	{
        for (j=1;j<=n;j++)
		{
            cout << setw(8) << setprecision(2) << fixed << a[i][j];
        }
        cout << endl;
	}
}

void nhan2mtr(float a[][100], float b[][100], float c[][100], int n)
{	int i,j,k;
	for(i=1; i<=n; i++)
		for(j=1; j<=n; j++)
		{ c[i][j]=0;
		  for(k=1; k<=n; k++) c[i][j]+=a[i][k]*b[k][j];
		}
}

void saochep (float a[][100], float b[][100], int n){
    for (int i=1;i<=n; i++){
        for (int j=1; j<=n; j++){
            b[i][j]=a[i][j];
        }
    }
}

void swap(int &xp, int &yp)
{
    int temp = xp;
    xp = yp;
    yp = temp;
}

void selectionSort(float arr[], int n)
{
    int i, j, k;
    for (i = 0; i < n-1; i++)
    {
	k = i;
	for (j = i+1; j < n; j++)
	    if (arr[j] > arr[k])
		k = j;

        swap(arr[k], arr[i]);
    }
}

void getCofactor(float A[][100], float temp[][100], int p, int q, int n)
{
    int i = 1, j = 1;
 
    for (int row = 1; row <= n; row++) {
        for (int col = 1; col <= n; col++) {
            if (row != p && col != q) {
                temp[i][j++] = A[row][col];
 
                if (j == n) 
				{
                    j = 1;
                    i++;
                }
            }
        }
    }
}
 
float determinant(float A[][100], int n)
{
    float D = 0; 
    
    if (n == 1)
        return A[1][1];
 
    float temp[100][100]; 
 
    float sign = 1; 

    for (int f = 1; f <= n; f++) {
        
        getCofactor(A, temp, 1, f, n);
        D += sign * A[1][f] * determinant(temp, n - 1);
 
        
        sign = -sign;
    }
 
    return D;
}

void adjoint(float A[][100], float adj[][100], int n)
{
    if (n == 1) {
        adj[1][1] = 1;
        return;
    }
 
    float sign = 1; 
	float temp[100][100];
 
    for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= n; j++) {
            
            getCofactor(A, temp, i, j, n);
 
            sign = ((i + j) % 2 == 0) ? 1 : -1;
 
            adj[j][i] = (sign) * (determinant(temp, n-1));
        }
    }
}
 
bool inverse(float A[][100], float inverse[][100], int n)
{
    // Find determinant of A[][]
    float det = determinant(A, n);
    if (det == 0) {
        cout << "Singular matrix, can't find its inverse";
        return false;
    }
 
    // Find adjoint
    float adj[100][100];
    adjoint(A,adj,n);
 
    // Find Inverse using formula "inverse(A) = adj(A)/det(A)"
    for (int i = 1; i <= n; i++)
        for (int j = 1; j <= n; j++)
            inverse[i][j] = adj[i][j] / det;
 
    return true;
}

float bac3(float a, float b, float c, float d){
    const float PI = 4.0 * atan( 1.0 );

    cout << endl << "Tri rieng la nghiem cua phuong trinh: " 
				 << a << "x^3 + " << b << "x^2 + " << c << "x + " << d << " = 0" << endl;

    float p = ( b * b - 3.0 * a * c ) / ( 9.0 * a * a );
    float q = ( 9.0 * a * b * c - 27.0 * a * a * d - 2.0 * b * b * b ) / ( 54.0 * a * a * a );
    float offset = b / ( 3.0 * a );

    // Discriminant
    float discriminant = p * p * p - q * q;
    
    cout  << "Cac tri rieng la: ";
    if ( discriminant > 0 )          
    {
        float theta = acos( q / ( p * sqrt( p ) ) );
        float r = 2.0 * sqrt( p );
        for ( int i = 0; i < 3; i++ ) 
		{
            lamda[i] = r * cos( ( theta + 2.0 * i * PI ) / 3.0 ) - offset;
        }
        selectionSort(lamda,n);
        for (int i = 0; i < 3; i++)
    		cout << lamda[i] << " ";
		cout << endl;
    }
    else 
    {
        float gamma1 = cbrt( q + sqrt( -discriminant ) );
        float gamma2 = cbrt( q - sqrt( -discriminant ) );

        cout << gamma1 + gamma2 - offset << '\n';

        float re = -0.5 * ( gamma1 + gamma2 ) - offset;
        float im = ( gamma1 - gamma2 ) * sqrt( 3.0 ) / 2.0;
        if ( discriminant == 0.0 )                
        {
            cout << re << '\n';
            cout << re << '\n';
        }
        else
        {
            cout << re << " + " << im << " i\n";
            cout << re << " - " << im << " i\n";
        }
    }
}

void tririeng(float a[][100], int n)
{	int i,j,k;
	for(k=n-1; k>=1; k--)
	{ 
		for(i=1; i<=n; i++)
		{
			for(j=1; j<=n; j++)
			{
				if(i!=k)
				{
				  if(i==j) { m[i][j]=1; m1[i][j]=1; }
				  else { m[i][j]=0; m1[i][j]=0; }
				}
				else
				{ m1[i][j]=a[k+1][j];
				  if(j==k) m[i][j]=1/a[k+1][k];
				  else m[i][j]=-a[k+1][j]/a[k+1][k];	
				}
			}	
		}
		//*goi ham nhan 3 lan*//
		nhan2mtr(a,m,b,n);
		nhan2mtr(m1,b,a,n);
		nhan2mtr(M,m,b,n);
		// gan lai M = b
		saochep(b,M,n);
	}
	for(int i=0; i <=n ; i++){
        if (i==0) heso[i] = 1;
        else heso[i] = -a[1][i];
    }	
}

void vectorrieng(float M[][100], float lamda[100], int n)
{
	for(int i=1; i<=n; i++){
        y[i][1] = pow(lamda[0],n-i);
        y[i][2] = pow(lamda[1],n-i); 
        y[i][3] = pow(lamda[2],n-i);
    }
    nhan2mtr(M,y,P,n); // vector rieng la gia tri theo tung cot cua ma tran P
    
	for (int i = 1;i <=n ;i++ ){
        D[i][i] = lamda [i-1];
    }
}

void matrandonvi(float e[][100], int n)
{	int i,j;
	for(i=1; i<=n; i++)
		for(j=1; j<=n; j++) 
		{
			if (i==j) 
				e[i][j]=1;
			else  e[i][j]=0;
		}
}


int main()
{
	cout << "Nhap n: "; cin >> n;
	cout << "Nhap he so ma tran: " << endl;	
	nhapmtr(a,n);;
	cout << endl << "Xuat ma tran: ";
	xuatmtr(a,n);
	matrandonvi(M,n);
	tririeng(a,n);
	bac3(heso[0],heso[1],heso[2],heso[3]);
	vectorrieng(M,lamda,n);
	cout << endl << "Xuat ma tran P: ";
	xuatmtr(P,n);
	cout << endl << "Xuat ma tran duong cheo chinh D:  ";
    xuatmtr(D,n);
	if(inverse(P,P1,n))
	{
		cout << endl << "Xuat ma tran nghich dao P1: ";
		xuatmtr(P1,n);	
	}
	
	
	return 0;
}

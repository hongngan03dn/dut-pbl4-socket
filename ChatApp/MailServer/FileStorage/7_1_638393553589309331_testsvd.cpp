#include "bits/stdc++.h"
#include "Eigen"

using namespace Eigen;
using namespace std;
const double max=100;


void input(double a[][100], int row, int col)
{	for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
		{
            cout << "a[" << i << "]["<< j << "]= ";
            cin >> a[i][j];
        }
    }
}

void output(double a[][100], int row, int col)
{	 
	cout << endl;
	for(int i = 0; i < row; i++)
	{
        for(int j = 0; j < col; j++)
		{
        	cout << setw(10) << setprecision(5) << fixed << a[i][j] << "    ";
        }
        cout << endl;
	}
}

void transposeMatrix( double a[][100], int row, int col, double at[][100])
{
  	for(int i = 0; i < row; i++)
  	{
	    for(int j = 0; j < col ;j++){
	      at[j][i] = a[i][j];
	    }
  	}
}

void mulMatrix(double at[][100], int row1, int col1, double a[][100], int row2, int col2, double c[][100]){
	if (col1 != row2)
	{
		cout << "Cannot multiple 2 matrix!" << endl;
	}
	else
	{
		for(int i = 0; i < row1; i++){
			for (int j = 0; j < col2; j++){
				c[i][j] = 0;
				for(int k = 0; k < col1; k++){
			    	c[i][j] += at[i][k] * a[k][j];
				}
			}
		}
	}	
}

void find(double s[][100], int row, int col, double lamda[100], double v[][100])
{
    MatrixXf Ae;
    Ae.resize(row, col);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Ae(i, j) = s[i][j];
        }
    }
    EigenSolver<MatrixXf> k(Ae);
    VectorXcf kEigenvalue = k.eigenvalues();
    for (int i = 0; i < col; i++)
    {
        lamda[i] = real(k.eigenvalues()(i));
        if(fabs(lamda[i]) < 1e-10) lamda[i] = 0;
    }
    MatrixXcf kEigenvector = k.eigenvectors();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
        	if (j%2==0)
        	{
            	v[i][j] = - kEigenvector(i, j).real();
			}
			else 
            	v[i][j] = kEigenvector(i, j).real();
        }
    }
    for (int i = 0; i < col - 1; i++)
    {
        for (int j = i + 1; j < col; j++)
        {
            if (lamda[i] < lamda[j])
            {
                double temp = lamda[i];
                lamda[i] = lamda[j];
                lamda[j] = temp;
                for (int k = 0; k < col; k++)
                {
                    double temp2 = v[k][i];
                    v[k][i] = v[k][j];
                    v[k][j] = temp2;
                }
            }
        }
    }
    cout << endl << "Eigen values of S: ";
    for (int i = 0 ; i < col; i++)
    {
    	cout << lamda[i] << "  ";
	}
	cout << endl;
}


void findSigmaMatrix(double lamda[100], double sigma[][100], int h, int n)
{
	for (int i = 0; i < h; i++)
    {
        sigma[i][i] = sqrt(lamda[i]);
    }
    cout << endl << "Matrix Sigma: ";
	output(sigma, h, n);
}

void findUMatrix(double sigma[][100], double a[][100], double v[][100], double u[][100], int h, int n){
	for(int i = 0; i < h; i++)
	{
		double ui[100][100];
		double sigma1 = sigma[i][i];
		double vi[100][100];
		for(int j = 0; j < n; j++)
		{
			vi[j][0] = v[j][i]; 
		}
		mulMatrix(a, h, n, vi, n, 1, ui);
		for(int j = 0; j < h; j++)
		{
			ui[j][0] /= sigma1;
			u[j][i] = ui[j][0];
		}
	}
	cout << endl << "Matrix U: ";
	output(u, h, h);
}

int main()
{
	int row, col;
	double sigma[100][100]={0};
	double a[100][100],s[100][100],y[100][100],at[100][100],u[100][100],v[100][100],vt[100][100];
	double heso[100],lamda[100];
	cout << "Enter row: "; cin >> row;
	cout << "Enter col: "; cin >> col;
	cout << "Enter matrix: " << endl;
	input(a, row, col);
	cout << endl << "Matrix A: ";
	output(a, row, col);
	transposeMatrix(a, row, col,at);
	mulMatrix(at, col, row, a, row, col, s);
	cout << endl << "Matrix S: ";
	output(s, col, col);
	find(s, col, col, lamda, v);
	findSigmaMatrix(lamda, sigma, row, col);
	findUMatrix(sigma, a, v, u, row, col);
	transposeMatrix(v, col, col, vt);
	cout << endl << "Matrix V^T: ";
	output(vt, col, col);
	
	return 0;
}


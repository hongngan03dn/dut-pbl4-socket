#include "bits/stdc++.h"
using namespace std;

double h(double x1, double x2)
{
	return x1 + x2 - 5;
}
double x1_new(double lamda, double rk)
{
	return (-90 * pow(rk, 2) + 9 * rk * lamda - 6 * lamda + 60 * rk) / ((14 - 5 * rk) * (12 + 2 * rk));
}
double x2_new(double lamda, double rk)
{
	return (20 * rk - 2 * lamda) / (14 - 5 * rk);
}
void augmentedLarange(double x1, double x2, double lamda, double rk)
{
	double valueOf_h;
	for(int i = 1; i <= 10; i++)
	{
		x1 = x1_new(lamda, rk);
		x2 = x2_new(lamda, rk);
		valueOf_h = h(x1, x2);
		cout << setprecision(5) << fixed << setw(10) << lamda << "\t" 
										 << setw(10) << rk << "\t" 
										 << setw(10) << x1 << "\t" 
										 << setw(10) << x2 << "\t" 
										 << setw(10) << valueOf_h << endl;
		lamda += 2 * rk * valueOf_h;
	}
}
int main()
{
	double rk = 1;
	double lamda = 0;
	double x1, x2;

	cout << setw(8) << "lamda" << "\t" 
		 << setw(8) << "rk" << "\t" 
		 << setw(8) << "x1" << "\t" 
		 << setw(8) << "x2" << "\t" 
		 << setw(8) << "Value of h" << endl;
	cout << "---------------------------------------------------------------------------" << endl;
	augmentedLarange(x1, x2, lamda, rk);
	cout << "---------------------------------------------------------------------------" << endl;
	
}

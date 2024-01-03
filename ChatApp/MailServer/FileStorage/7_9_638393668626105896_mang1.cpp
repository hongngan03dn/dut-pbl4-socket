#include <iostream>
using namespace std;
int n;

int SoPhanTu(float *a);
void NhapMang(float *a);
void XuatMang(float *a);
void PhanTuTai(float *a);

bool ascending(float left, float right);
bool descending(float left, float right);
void Selection_Sort(float a[], int n, bool CompFunc(float,float));

int main()
{
	do
	{
		cout<<"So Phan Tu Mang : ";
		cin >> n;
	} while(n<=0);
	
	float a[n];
	cout<<"Kich thuoc mang : "<<(sizeof(a)/sizeof(float))<<endl;
	NhapMang(a);
	XuatMang(a);
	PhanTuTai(a);
	
	Selection_Sort(a,n, ascending);
	Selection_Sort(a,n, descending);
	
}

void NhapMang(float *a)
{
	for(int i = 0; i<n; i++)
	{
		cout<<"a["<<i<<"] = ";
		cin>>a[i];
	}
}
void XuatMang(float *a)
{
	cout<<endl<<"Mang da nhap : "<<endl;
	for(int i = 0; i<n; i++)
	{
		cout<<"a["<<i<<"] = "<<a[i]<<endl;
	}
}
void PhanTuTai(float *a)
{
	int i;
	
	do{
		cout<<"Nhap vi tri : i = "; cin>>i;
	} while(i<0 || i>=n);
	
	cout<<"a["<<i<<"] = "<<a[i];
}

bool ascending(float left, float right)
{
	return left<right;
}
bool descending(float left, float right)
{
	return left>right;
}


void Selection_Sort(float a[], int n, bool CompFunc(float,float)){
	cout<<endl<<"Selection Sort : "<<endl;
	int min;
	for(int i=0; i<n-1; i++){
		min = i;
		for(int j=i+1; j<n; j++){
			if(CompFunc(a[j], a[min])){
				min = j;
			}
		}
		swap(a[min], a[i]);
	}
	XuatMang(a);
}


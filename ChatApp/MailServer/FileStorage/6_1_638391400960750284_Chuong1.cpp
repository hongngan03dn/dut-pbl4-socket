#include <stdio.h>
#include <math.h>

const int max = 10000;

// kiem tra so nguyen to
int isPrime(int n) {
	int i;
	for(i = 2; i * i <= n; i++) {
		if(n % i == 0) return 0;
	}
	return 1;
}

// phan tich thua so nguyen to
void factoringNumber(int n, int *p, int *x, int *s) {
	int j = 0, k;
	int i;
	for(i = 2; i <= sqrt(n); i++) {
		if(isPrime(i)) {
			k = 0;
			while(n % i == 0) {
				k++;
				n /= i;
			}
			p[j] = i;
			x[j] = k;
			if(k != 0) printf("%d^%d ", i, k);
			j++;
		}
	}
	if(n != 1) {
		p[j] = n;
		x[j] = 1;
		printf("%d^%d", n, 1);
		*s = j + 1;
	} else *s = j;
}

// so luong uoc so
int numberOfFactors(int *x, int *s) {
	int sum = 1;
	int i;
	for(i = 0; i < *s; i++) {
		sum *= (x[i] + 1);
	}
	return sum;
}

// liet ke uoc so
void listOfFactors(int n) {
	int i;
	for(i = 1; i * i < n; i++) {
		if(n % i == 0) {
			printf("%d ", i);
		}
	}
	
	for(i = sqrt(n); i >= 1; i--) {
		if(n % i == 0) {
			printf("%d ", n / i);
		}
	}
}

// tong cac uoc so
long long sumOfFactors(int *p, int *x, int *s) {
	long long sum = 1;
	int i;
	for(i = 0; i < *s; i++) {
		sum *= (long long) (pow(p[i], x[i] + 1) - 1) / (p[i] - 1);
	}
	return sum;
}

// tich cac uoc so
long long productOfFactors(int n, int *p, int *x, int *s) {
	int number = numberOfFactors(x, s);
	return (long long) pow(n, number / 2);
}

// kiem tra so hoan hao (cach 1)
int isPerfectNumber(int n) {
	int sum = 1, i;
	for(i = 2; i * i < n; i++) {
		if(n % i == 0) {
			sum += i + n / i;
		}
	}
	if(i * i == n) sum += i;
	if(sum == n && n != 1) return 1;
	else return 0;
}

// kiem tra so hoan hao (cach 2)
int isPerfectNumber2(int n, int *p, int *x, int *s) {
	if(sumOfFactors(p, x, s) == 2 * n) return 1;
	else return 0;
}

// liet ke cac so hoan hao tu 1 den n
void listOfPerfectNumber(int n) {
	int check = 0;
	int i;
	for(i = 1; i <= n; i++) {
		if(isPerfectNumber(i)) {
			printf("%d ", i);
			check = 1;
		}
	}
	if(!check) printf("Khong ton tai");
}

// liet ke cac so hoan hao tu a den b
void listOfPerfectNumber2(int a, int b) {
	int check = 0;
	int i;
	for(i = a; i <= b; i++) {
		if(isPerfectNumber(i)) {
			printf("%d ", i);
			check = 1;
		}
	}
	if(!check) printf("Khong ton tai");
}

// tim so nguyen to gan nhat
int closestPrime(int n) {
	if(isPrime(n)) return n;
	int i = n - 1, j = n + 1;
	while(i >= 2) {
		if(!isPrime(i)) i--;
		else break;
	}
	while(1) {
		if(!isPrime(j)) j++;
		else break;
	}
	if(n - i <= j - n) return i;
	else return j;
}

// mat do so nguyen to
int densityOfPrime(int n) {
	return (int) n / log(n);
}

// thuat toan sang so nguyen to
void sieveOfEratosthenes(int *prime) {
	int i, j;
	for(i = 0; i < max; i++) {
		prime[i] = 0;
	}
	prime[0] = prime[1] = 1;
	for(i = 2; i <= max; i++) {
		if(prime[i]) continue;
		for(j = 2 * i; j <= max; j += i) {
			prime[j] = i;
		}
	}
}

// liet ke cac so nguyen to tu 1 den n
void listOfPrime(int n, int *prime) {
	int check = 0;
	int i;
	for(i = 2; i <= n; i++) {
		if(!prime[i]) {
			printf("%d ", i);
			check = 1;
		}
	}
	if(!check) printf("Khong ton tai");
}

// liet ke cac so nguyen to tu a den b
void listOfPrime2(int a, int b, int *prime) {
	int check = 0;
	int i;
	for(i = a; i <= b; i++) {
		if(!prime[i]) {
			printf("%d ", i);
			check = 1;
		}
	}
	if(!check) printf("Khong ton tai");
}

int main() {
	int p[100], x[100], prime[100];
	int a, b, n;
	int s = 0;
	printf("\nNhap n: ");
	scanf("%d", &n);
	printf("\nNhap khoang a, b cho truoc\n");
	printf("\nNhap a: ");
	scanf("%d", &a);
	printf("\nNhap b: ");
	scanf("%d", &b);
	printf("\n1. Phan tich n = %d thanh cac thua so nguyen to: ", n); factoringNumber(n, p, x, &s);
	printf("\n\n2. So luong uoc so cua n = %d: %d", n, numberOfFactors(x, &s));
	printf("\n\n3. Liet ke cac uoc so cua n = %d: ", n); listOfFactors(n);
	printf("\n\n4. Tong cac uoc so cua n = %d: %lld", n, sumOfFactors(p, x, &s));
	printf("\n\n5. Tich cac uoc so cua n = %d: %lld", n, productOfFactors(n, p, x, &s));
	if(isPerfectNumber(n)) printf("\n\n6.1. n = %d la so hoan hao (cach 1)", n);
	else printf("\n\n6.1. n = %d khong la so hoan hao (cach 1)", n);
	if(isPerfectNumber2(n, p, x, &s)) printf("\n\n6.1. n = %d la so hoan hao (cach 2)", n);
	else printf("\n\n6.2. n = %d khong la so hoan hao (cach 2)", n);
	printf("\n\n7.1. Liet ke so hoan hao tu 1 den n = %d: ", n); listOfPerfectNumber(n);
	printf("\n\n7.2. Liet ke so hoan hao tu a den b (%d den %d): ", a, b); listOfPerfectNumber2(a, b);
	printf("\n\n8. So nguyen to gan nhat voi n/2 = %d la %d", (n / 2), closestPrime(n / 2));
	printf("\n\n9. Mat do so nguyen to la %d", densityOfPrime(n));
	sieveOfEratosthenes(prime);
	printf("\n\n10.1. Liet ke cac so nguyen to nho hon n = %d: ", n); listOfPrime(n, prime);
	printf("\n\n10.2. Liet ke cac so nguyen to tu a den b (%d den %d): ", a, b); listOfPrime2(a, b, prime);
	return 0;
}

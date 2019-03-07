//Problema 3
#include<iostream>
#include<math.h>

using namespace std;

bool isPrime(long long int);

int main() {
	long long int n = 600851475143;
	bool found = false;
	int i = sqrt(n);
	while (!found && i >= 3) {
		if (i % 2 != 0 && i % 5 != 0 && n % i == 0) {
			if (isPrime(i)) {
				cout << "The largest prime factor is " << i << endl;
				found = true;
			}
		}
		i--;
	}
	return 0;
}

bool isPrime(long long int n) {
	int i = 1;
	int count = 0;
	bool prime = true;
	while (prime && i <= n) {
		if (n % i == 0) {
			count++;
		}
		if (count > 2) {
			prime = false;
		}
		i++;
	}
	return prime;
}

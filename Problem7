//Problema 7
#include<iostream>

using namespace std;

bool isPrime(int);

int main() {
	int count = 0;
	int numbers = 2;
	int prime;
	while (count < 10001) {
		if (isPrime(numbers)) {
			count++;
			prime = numbers;
		}
		numbers++;
	}
	cout << "The " << count << " th prime is " << prime << endl;
	return 0;
}

//Esta forma de encontrar primos es mas eficiente. En vez de contar divisores, se exluyen el dividirse entre 1 y el mismo numero. Si hay algun divisor aparte de esos, no
//es primo
bool isPrime(int n) {
	bool prime = true;
	for (int i = 2; i < n - 1; i++) {
		if (n % i == 0) {
			prime = false;
		}
	}
	return prime;
}

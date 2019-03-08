//Problema 2
#include<iostream>

using namespace std;
int main() {
	int n1 = 1;
	int n2 = 2;
	int fib = 0;
	int sum = 0;
	while(n1 < 4000000 && n2 < 4000000){ //No es necesario verificar ambos numeros. Basta con verificar n1 nada más
		if (n2 % 2 == 0) { //Usar n2 para comprobar no n1. En caso de que el ultimo numero sea par
			sum += n2;
		}
		fib = n1 + n2;
		n1 = n2;
		n2 = fib;	
	}
	cout << "The sum of even Fibonacci numbers up until 4 million is " << sum << endl;
	return 0;
}

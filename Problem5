//Problema 5
#include<iostream>

using namespace std;

int main() {
	int n = 20;
	int count;
	bool multiple = false;
	while (!multiple) {
		count = 0;
		for (int i = 1; i <= 20; i++) {
			if (n % i == 0) {
				count++;
			}
		}
		if (count == 20) {
			multiple = true;
		}
		else {
			n++;
		}
	}
	cout << "The smallest number divisible by numbers from 1 through 20 is " << n << endl;
	return 0;
}

//Problema 9
#include<iostream>
#include<math.h>

using namespace std;

int main() {
	bool done = false;
	int r1, r2, r3, sum;
	int a = 1;
	int b = 0;
	while (!done) {
		r1 = sqrt(a);
		if (r1 * r1 == a) {
			b = 0;
			while (!done && b < a) {
				r2 = sqrt(b);
				if (r2 * r2 == b) {
					sum = a + b;
					r3 = sqrt(sum);
					if (r3 * r3 == sum) {
						if ((r1 + r2 + r3) == 1000) {
							cout << "The product of the pythagorean numbers that add up to 1000 is " << r1 * r2 * r3 << endl;
							done = true;
						}
					}
				}
				b++;
			}
		}
		a++;
	}
	return 0;
}

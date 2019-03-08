//Problema 4
#include<iostream>
#include<string>

using namespace std;

bool palindrome(string);

int main() {
	int n;
	int max = 0;
	string s;
	bool palin;
	for (int i = 999; i >= 100; i--) {
		for (int j = 999; j >= 100; j--) {
			n = i * j;
			s = to_string(n);
			if (palindrome(s)) {
				if (n > max) {
					max = n;
				}
			}
		}
	}
	cout << "The largest palindrome product is " << max << endl;
	return 0;
}

bool palindrome(string s) {
	int size = s.length();
	int half = size / 2;
	int i = 0;
	int j = size-1;
	bool equal = true;
	while (equal && i >= 0 && i < half && j < size && j > half-1) {
		if (s.at(i) == s.at(j)) {
			i++;
			j--;
		}
		else {
			equal = false;
		}
	}
	return equal;
}

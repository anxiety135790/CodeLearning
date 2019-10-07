#include<iostream>
#include <math.h>
using namespace std;

int main(){
	int r,h;
	cin >> h >> r;
	double req = 20,pi = 3.14159,n;
	n = req/(pi*r*r*h*0.001);
	cout << ceil(n) << endl;
	return 0;
}
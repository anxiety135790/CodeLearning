#include<iostream>
#include <iterator>
using namespace std;

int main(){
	int n,x,y;
	cin >> n >> x >> y; // input  parameter
	int residual;
	residual = n - (y/x);
	if (residual > 0 ){
		if (residual % 2 ==1){ // judge tempalte is odd
			cout << residual << endl;  //output value   
		}
		else{
			cout << residual-1 << endl; //output value - 1 
		}
	}
	else{
		cout << 0 <<endl;
	}
	return 0;
}
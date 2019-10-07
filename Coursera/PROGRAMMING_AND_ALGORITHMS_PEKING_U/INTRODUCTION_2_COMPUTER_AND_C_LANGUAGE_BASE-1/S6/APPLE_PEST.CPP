#include<iostream>
using namespace std;

int main(){
	int n,x,y;
	cin >> n >> x >> y;
	int residual;
	residual = n - (y/x);
	if (residual > 0 ){
		if (residual % 2 ==1){
			cout << residual << endl;
		}
		else{
			cout << residual-1 << endl;
		}
	}
	else{
		cout << 0 <<endl;
	}
	return 0;
}
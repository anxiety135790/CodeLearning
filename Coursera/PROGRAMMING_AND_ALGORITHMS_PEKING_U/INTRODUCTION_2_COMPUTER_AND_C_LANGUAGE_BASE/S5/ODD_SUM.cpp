#include <iostream>
using namespace std;
int main(){
	int m,n,temp = 0;
	cin >> m >> n;
	while (m<=n){
		if (m%2 ==1){
			temp += m;
		}
		m++;
	}
	cout << temp << endl;
	return 0;
}
#include <iostream>
using namespace std;

int main(){
	
    int n, index=0;//ÊäÈë
    cin >> n;
    
    while (n > 0){//int2str×ª»»
        if (index == 0) cout << n%10;
        else cout << " " << n%10;
        index++;
        n /= 10;
    }
    
    cout << endl;//Êä³ö
    return 0;
}

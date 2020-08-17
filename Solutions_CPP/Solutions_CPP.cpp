#include <iostream>
#include <vector> 
using namespace std;
int main()
{
	Solution s;
	string a = s.toLowerCase("HELLO");
}
class Solution {
public:
	int bitwiseComplement(int N) {
		
    }
	string toLowerCase(string str) {
		for (size_t i = 0; i < str.length; i++)
		{
			if (str[i] >= 'A' && str[i] <= 'Z')
			{
				str[i] = str[i]-'A'+'a';
			}
			
		}
		return str;
	}
};

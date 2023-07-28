#include<string>
#include <iostream>

using namespace std;

void replace(char* s, char c1, char c2)
{
    char specialsymbol = '!';

    while (*s != '\0')
    {
        if (*(s - 1) == specialsymbol && *s == c1)
        {
            *s = c2;
        }
        s++;
    }
}

int main()
{
    string n;
    char x;
    char y;
    char* N = &n[0];
    cout << "Enter the phrase you wish to edit: \n";

    cin >> n;

    cout << "Enter the character you want to replace: \n";

    cin >> x;

    cout << "Enter the character you want to replace it with: \n";

    cin >> y;

    replace(N, x, y);

    cout << n;

}

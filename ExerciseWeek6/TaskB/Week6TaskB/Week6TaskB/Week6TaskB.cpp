#include <iostream>
using namespace std;

void dnaReplace(string s, string y, string l, string r, string x)
{
    int iS = s.length();
    int iY = y.length();
    int iL = l.length();
    int iR = r.length();
    int iX = x.length();

    for (int i = 0; i <= (iS - iY); i++)
    {
        int a = 0;
        int b = 0;
        int c = 0;
        while (a < iY && s[i + a] == y[a])
        {
            a++;
        }
        if (a == iY && (i - iL) >= 0)
        {
            while (b < iR && s[i + b + a] == r[b])
            {
                b++;
            }
            while (c < iL && s[i - iL + c] == l[c])
            {
                c++;
            }
            if (b != iR && c == iL)
            {
                string replace = s.replace(i, iY, x);
                cout << replace << " \n";
                s.replace(i, iX, y);
            }
        }
    }
}
int main()
{
    string s = "atatatatgtatatatgta";
    string y = "tat";
    string l = "a";
    string r = "gt";
    string x = "gg";
    cout << "Original String: " << s << " \n";
    dnaReplace(s, y, l, r, x);
}
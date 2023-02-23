/**/

Console.Write("write a number");
string input = Console.ReadLine();
int N = int.Parse(input);

if (N != 0) {
    Console.Write(1);
}

int n = 2;
while (n <= N) {
    string result = Convert.ToString(n * n * n);
    Console.Write(", " + result);
    n = n + 1;
}

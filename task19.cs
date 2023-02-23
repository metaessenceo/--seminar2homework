/**/

string input = Console.ReadLine("Write a 5-digit number");

number = int.Parse(input);
if ((10000 <= number) && (number <= 99999)) {
    int n1 = int.Parse(input[0]);
    int n2 = int.Parse(input[1]);
    int n4 = int.Parse(input[3]);
    int n5 = int.Parse(input[4]);

    if ((n1 == n5) && (n2 == n4)) {
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }
}
else {
    Console.WriteLine("Isn't 5-digit number :(");
}

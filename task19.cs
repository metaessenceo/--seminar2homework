/**/

Console.WriteLine("write a 5-digit number:");
string input = Console.ReadLine();

int number = int.Parse(input);
if ((10000 <= number) && (number <= 99999)) {
    var n1 = input[0];
    var n2 = input[1];
    var n4 = input[3];
    var n5 = input[4];

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

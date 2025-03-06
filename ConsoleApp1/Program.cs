// switch (DayOfWeek.Monday)
// {
//     case DayOfWeek.Monday:
//         break;
//     case DayOfWeek.Tuesday:
//         break;
//     default:
//         break;
// }
// enum WeekDay
// {
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Saturday,
//     Sunday,
// };

// var numbers = new int[]{1,2,3};
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

using System.Text.RegularExpressions;

while (true)
{
    try
    {
        // Console.Write("Enter number a: ");
        // double a = double.Parse(Console.ReadLine());
        // Console.Write("Enter operation: ");
        // string oper = Convert.ToString(Console.ReadLine());
        // Console.Write("Enter number c: ");
        // double c = double.Parse(Console.ReadLine());
        Console.Write("Simple Calc\n\nEnter for calculation:");
        string input = Console.ReadLine();
        Regex regex = new Regex(@"(\d+)([+\-*/])(\d+)");
        Match match = regex.Match(input);
        double a=0, c=0;
        string oper = string.Empty;
        if (match.Success)
        {
            a = double.Parse(match.Groups[1].Value);
            oper = match.Groups[2].Value;
            c = double.Parse(match.Groups[3].Value);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
        if (oper == "+")
        {
            var res = DoOperation(a, c, Operation.Add);
            Console.Clear();
            Console.WriteLine($"{a}+{c}={res}");
        }
        else if (oper == "-")
        {
            var res =DoOperation(a, c, Operation.Subtract);
            Console.Clear();
            Console.WriteLine($"Result: {a}-{c}={res}");
        }
        else if (oper == "*"){
            var res =DoOperation(a, c, Operation.Multiply);
            Console.Clear();
            Console.WriteLine($"Result: {a}*{c}={res}");
        }
        else if (oper == "/"){
            var res =DoOperation(a, c, Operation.Divide);
            Console.Clear();
            Console.WriteLine($"Ответ: {a}/{c}={res}");
        }
        else
            Console.WriteLine("Invalid operation1!");
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }

}

double DoOperation(double x, double y, Operation op)
{
    switch (op)
    {
        case Operation.Add:
            return x + y;
        case Operation.Subtract:
            return x - y;
        case Operation.Multiply:
            return x * y;
        case Operation.Divide:
            return x / y;
        default:
            Console.WriteLine("Invalid operation2!");
            break;
    }
    return 0;
}
enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}




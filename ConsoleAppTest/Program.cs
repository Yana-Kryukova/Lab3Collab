int A = 0, B = 0;
double res = 0;
string s = "";
Console.WriteLine("Enter A, B, +, -, *, or /");
s = Console.ReadLine();
switch (s)
{
    case "A":Input(ref A); break;
    case "B": Input(ref B); break;
    case "+": res = Plus(A, B); break;
    case "-": res = Minus(A, B); break;
    case "*": res = Multy(A, B); break;
    case "/": res = Dev(A, B); break;
}
Console.WriteLine($"{A} {s} {B} = {res}");

int Multy(int x,int y)
{
    return x * y;
}


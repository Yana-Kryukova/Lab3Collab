int A = 0, B = 0;
double res = 0;
string s = "";
for (; ; )
{
    Console.WriteLine("Enter A, B, +, -, *, or /");
    s = Console.ReadLine();
    switch (s)
    {
        case "A": Input(ref A); break;
        case "B": Input(ref B); break;
        case "+": res = Plus(A, B); Console.WriteLine($"{A} {s} {B} = {res}"); break;
        case "-": res = Minus(A, B); Console.WriteLine($"{A} {s} {B} = {res}"); break;
        case "*": res = Multy(A, B); Console.WriteLine($"{A} {s} {B} = {res}"); break;
        case "/": res = Dev(A, B); Console.WriteLine($"{A} {s} {B} = {res}"); break;
        default: return;
    }
    
}
int Plus(int x,int y)
{
    return x + y;
}


int Minus(int x,int y)
{
    return x - y;
}


int Multy(int x,int y)
{
    return x * y;
}


double Dev(int x,int y)
{
    return (x * 1.0) / (y * 1.0);
}
void Input(ref int x)
{
    x = 0;
    int.TryParse(Console.ReadLine(), out x);
}


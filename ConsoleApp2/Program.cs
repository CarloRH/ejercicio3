int n1=0, n2=0, menu=0;
void saludo()
{
    Console.WriteLine("Que onda bro---\nEsta es una calculadora");
}
int mul(int n1, int n2)
{
    int r1 = 0; r1 = n1 * n2; return r1;
}
int suma(int n1, int n2)
{
    int r1 = 0; r1 = n1 + n2; return r1;
}
int res(int n1, int n2)
{
    int r1 = 0; r1 = n1 - n2; return r1;
}
int div(int n1, int n2)
{
    int r1 = 0; r1 = n1 / n2; return r1;
}
saludo();
Console.WriteLine("Ingrese el primer numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
n2= int.Parse(Console.ReadLine()); 
Console.WriteLine("Elije la operacion a realizar\n#1 Suma\n#2 Resta\n#3 Multiplicacion\n#4 Division");
menu=int.Parse(Console.ReadLine());
switch (menu) {
    case 1:
        Console.WriteLine($"La suma es: {suma(n1, n2)}");
        break;
    case 2:
        Console.WriteLine($"La resta es: {res(n1, n2)}");
        break;
    case 3:
        Console.WriteLine($"La multiplicacion es: {mul(n1, n2)}");
        break;
    case 4:
        Console.WriteLine($"La division es: {div(n1, n2)}");
        break;
}
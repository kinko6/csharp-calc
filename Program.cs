Console.Write("digite o numero: ");
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = 0;

Console.WriteLine("digite a operacao (+, -, *, /, =):");
string operacao = Console.ReadLine();

if (operacao != "=") { 
Console.Write("digite o segundo numero: ");
num2 = Convert.ToInt16(Console.ReadLine());
}

switch (operacao)
{
    case "+":
        return num1 + num2;
    case "-":
        return num1 - num2;
    case "*":
        return num1 * num2;
    case "/":
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            throw new DivideByZeroException("impossivel dividir por 0");
        }
    case "=":
        return num1;
    default:
        throw new ArgumentException("operacao invalidada");
}

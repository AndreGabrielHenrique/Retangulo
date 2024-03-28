Console.WriteLine("Informe o valor da largura de um retângulo");
double largura=double.Parse(Console.ReadLine());
Console.WriteLine("Agora a altura");
double altura=double.Parse(Console.ReadLine());
double area=CalcularArea();
double perimetro=CalcularPerimetro();
double diagonal=CalcularDiagonal();
System.Console.WriteLine($"Sua área: {area.ToString("F4")}");
System.Console.WriteLine($"Seu perímetro: {perimetro.ToString("F4")}");
System.Console.WriteLine($"Sua diagonal: {diagonal.ToString("F4")}");
double CalcularArea()=>largura*altura;
double CalcularPerimetro()=>largura+altura*2;
double CalcularDiagonal()
{
    double d=Math.Sqrt(largura+altura*2);
    return d;
}
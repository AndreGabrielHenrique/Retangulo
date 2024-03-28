class VetorRetangulo
{
    public double largura;
    public double altura;

    public double CalcularArea()=>largura*altura;
    public double CalcularPerimetro()=>largura+altura*2;
    public double CalcularDiagonal()
    {
        double d=Math.Sqrt(largura+altura*2);
        return d;
    }
    public override string ToString()
    {
        double area=CalcularArea();
        double perimetro=CalcularPerimetro();
        double diagonal=CalcularDiagonal();
        string mensagem=$"Sua área: {area.ToString("F4")}\nSeu perímetro: {perimetro.ToString("F4")}\nSua diagonal: {diagonal.ToString("F4")}";
        return mensagem;
    }
}
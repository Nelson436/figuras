using System;

// Clase abstracta base
internal abstract class Figuras
{
    protected double Area { get; set; }
    protected double Perimetro { get; set; }
    public string UnidadMedida { get; set; }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public void MuestraArea()
    {
        Console.WriteLine($"El área es: {Area:F2} {UnidadMedida}^2");
    }

    public void MuestraPerimetro()
    {
        Console.WriteLine($"El perímetro es: {Perimetro:F2} {UnidadMedida}");
    }
}

// Clase Cuadrado
internal class Cuadrado : Figuras
{
    public int MedidaLado { get; set; }

    public override void CalcularArea()
    {
        Area = MedidaLado * MedidaLado;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = MedidaLado * 4;
    }
}

// Clase Rectángulo
internal class Rectangulo : Figuras
{
    public int Largo { get; set; }
    public int Ancho { get; set; }

    public override void CalcularArea()
    {
        Area = Largo * Ancho;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 2 * (Largo + Ancho);
    }
}

// Clase Triángulo
internal class Triangulo : Figuras
{
    public int Base { get; set; }
    public int Altura { get; set; }
    public int Lado1 { get; set; }
    public int Lado2 { get; set; }
    public int Lado3 { get; set; }

    public override void CalcularArea()
    {
        Area = (Base * Altura) / 2.0;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = Lado1 + Lado2 + Lado3;
    }
}

// Clase Círculo
internal class Circulo : Figuras
{
    public double Radio { get; set; }

    public override void CalcularArea()
    {
        Area = Math.PI * Math.Pow(Radio, 2);
    }

    public override void CalcularPerimetro()
    {
        Perimetro = 2 * Math.PI * Radio;
    }
}

// Clase Polígono (Regular)
internal class Poligono : Figuras
{
    public int NumeroLados { get; set; }
    public double LongitudLado { get; set; }
    public double Apotema { get; set; }

    public override void CalcularArea()
    {
        Area = (Perimetro * Apotema) / 2;
    }

    public override void CalcularPerimetro()
    {
        Perimetro = NumeroLados * LongitudLado;
    }
}

// Programa Principal
class Program
{
    static void Main(string[] args)
    {
        // Creación de un Cuadrado
        Cuadrado cuadrado = new Cuadrado
        {
            MedidaLado = 5,
            UnidadMedida = "metros"
        };
        cuadrado.CalcularArea();
        cuadrado.MuestraArea();
        cuadrado.CalcularPerimetro();
        cuadrado.MuestraPerimetro();

        Console.WriteLine();

        // Creación de un Rectángulo
        Rectangulo rectangulo = new Rectangulo
        {
            Largo = 4,
            Ancho = 2,
            UnidadMedida = "metros"
        };
        rectangulo.CalcularArea();
        rectangulo.MuestraArea();
        rectangulo.CalcularPerimetro();
        rectangulo.MuestraPerimetro();

        Console.WriteLine();

        // Creación de un Triángulo
        Triangulo triangulo = new Triangulo
        {
            Base = 5,
            Altura = 3,
            Lado1 = 5,
            Lado2 = 4,
            Lado3 = 6,
            UnidadMedida = "metros"
        };
        triangulo.CalcularArea();
        triangulo.MuestraArea();
        triangulo.CalcularPerimetro();
        triangulo.MuestraPerimetro();

        Console.WriteLine();

        // Creación de un Círculo
        Circulo circulo = new Circulo
        {
            Radio = 3.5,
            UnidadMedida = "metros"
        };
        circulo.CalcularArea();
        circulo.MuestraArea();
        circulo.CalcularPerimetro();
        circulo.MuestraPerimetro();

        Console.WriteLine();

        // Creación de un Polígono Regular
        Poligono poligono = new Poligono
        {
            NumeroLados = 6,
            LongitudLado = 4,
            Apotema = 3.5,
            UnidadMedida = "metros"
        };
        poligono.CalcularPerimetro();
        poligono.CalcularArea();
        poligono.MuestraArea();
        poligono.MuestraPerimetro();

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

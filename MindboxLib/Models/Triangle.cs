using MindboxLib.Models.Interfaces;

namespace MindboxLib.Models;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : IFigure
{
    /// <summary>
    /// Погрешность
    /// </summary>
    private const double Epsilon = 0.00001;
    /// <summary>
    /// Первая сторона
    /// </summary>
    public double FirstSide { get; init; }
    /// <summary>
    /// Вторая сторона
    /// </summary>
    public double SecondSide { get; init; }
    /// <summary>
    /// Третья сторона
    /// </summary>
    public double ThirdSide { get; init; }

    public double Area()
    {
        var p = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
    }
    
    /// <summary>
    /// Проверка: Прямоугольный треугольник
    /// </summary>
    /// <returns>true/false</returns>
    public bool IsRightTriangle()
    {
        var firstSquare = FirstSide * FirstSide;
        var secondSquare = SecondSide * SecondSide;
        var thirdSquare = ThirdSide * ThirdSide;

        return Math.Abs(firstSquare + secondSquare - thirdSquare) < Epsilon || 
               Math.Abs(firstSquare + thirdSquare - secondSquare) < Epsilon || 
               Math.Abs(secondSquare + thirdSquare - firstSquare) < Epsilon;
    }
}
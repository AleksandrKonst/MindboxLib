using MindboxLib.Models.Interfaces;

namespace MindboxLib.Models;

/// <summary>
/// Круг
/// </summary>
public class Сircle : IFigure
{
    /// <summary>
    /// Радиус
    /// </summary>
    public double Radius { get; init; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
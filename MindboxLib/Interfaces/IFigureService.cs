using MindboxLib.Models.Interfaces;

namespace MindboxLib.Interfaces;

/// <summary>
/// Интерфейс сервиса фигур.
/// </summary>
public interface IFigureService
{
    /// <summary>
    /// Получение площади фигуры.
    /// </summary>
    /// <param name="figure">Фигура.</param>
    /// <returns>Площадь фигуры.</returns>
    static abstract double GetArea (IFigure figure);
}
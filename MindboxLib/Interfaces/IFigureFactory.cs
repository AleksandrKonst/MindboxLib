using MindboxLib.Models.Interfaces;

namespace MindboxLib.Interfaces;

/// <summary>
/// Интерфейс фабрики.
/// </summary>
public interface IFigureFactory
{
    /// <summary>
    /// Свойство содержащие колличество фигур.
    /// </summary>
    /// <value>Колличество фигур.</value>
    /// <remarks>Колличество фигур реализующих интерфес IFigure полученно с помощью рефлексии.</remarks>
    static int FiguresCount { get; } 
    
    /// <summary>
    /// Свойство содержащие названия фигур.
    /// </summary>
    /// <value>Названия фигур.</value>
    /// <remarks>Названия классов реализующих интерфес IFigure полученно с помощью рефлексии.</remarks>
    static string[] GetFigureNames { get; }
    
    /// <summary>
    /// Получение нового экземпляра фигуры по названию.
    /// </summary>
    /// <param name="figureName">Название фигуры.</param>
    /// <returns>Фигуру семейства IFigure.</returns>
    static abstract IFigure GetFigure (string figureName);
}
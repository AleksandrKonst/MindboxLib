using MindboxLib.Interfaces;
using MindboxLib.Models.Interfaces;

namespace MindboxLib;

/// <summary>
/// Сервис фигур.
/// </summary>
public abstract class FigureService : IFigureService
{
    public static double GetArea(IFigure figure)
    {
        return figure.Area();
    }
}
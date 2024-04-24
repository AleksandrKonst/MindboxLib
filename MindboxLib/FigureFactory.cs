using MindboxLib.Interfaces;
using MindboxLib.Models.Interfaces;

namespace MindboxLib;

/// <summary>
/// Фабрика фигур.
/// </summary>
public abstract class FigureFactory : IFigureFactory
{
    public static int FiguresCount
    {
        get { return typeof(FigureFactory).Assembly
            .GetTypes()
            .Count(t => t.GetInterfaces().Contains(typeof(IFigure))); }
    }
    
    public static string[] GetFigureNames
    {
        get { return typeof(FigureFactory).Assembly
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(IFigure)))
            .Select(c => c.Name).ToArray(); } 
    }
    
    public static IFigure GetFigure(string figureName)
    {
        var figure = typeof(FigureFactory).Assembly
            .GetTypes()
            .FirstOrDefault(t => t.GetInterfaces().Contains(typeof(IFigure)) && t.Name == figureName);

        if (figure == null) throw new Exception("Figure not found");
        
        var instance = (IFigure)Activator.CreateInstance(figure)!;
        
        if (instance == null) throw new Exception("Internal Error");
        
        return instance;
    }
}
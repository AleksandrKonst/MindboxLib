using MindboxLib;
using MindboxLib.Models;
using Newtonsoft.Json;
using Xunit;

namespace LibTests;

/// <summary>
/// Тесты MindboxLib.dll
/// </summary>
public class FigureTests
{
    /// <summary>
    /// Проверка расчета площади
    /// </summary>
    [Fact]
    public void AreaTest()
    {
        var triangle = new Triangle()
        {
            FirstSide = 3,
            SecondSide = 4,
            ThirdSide = 5
        };
        
        Assert.Equal(6, FigureService.GetArea(triangle));
    }
    
    /// <summary>
    /// Проверка подсчета колличеств фигур в сборке
    /// </summary>
    [Fact]
    public void FiguresCountTest()
    {
        Assert.Equal(2, FigureFactory.FiguresCount);
    }
    
    /// <summary>
    /// Проверка вывода списока всех фигур сборки
    /// </summary>
    [Fact]
    public void GetFigureNamesTest()
    {
        var trueResult = new List<string>()
        {
            "Triangle","Сircle"
        };
        
        Assert.Equal(JsonConvert.SerializeObject(trueResult), 
            JsonConvert.SerializeObject(FigureFactory.GetFigureNames.OrderByDescending(x => x)));
    }
    
    /// <summary>
    /// Проверка утверждения о прямоугольном треугольнике
    /// </summary>
    [Fact]
    public void IsRightTriangleTest()
    {
        var triangle = new Triangle()
        {
            FirstSide = 3,
            SecondSide = 4,
            ThirdSide = 5
        };
        
        Assert.True(triangle.IsRightTriangle());
    }
}
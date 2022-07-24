using GeometryCalculator.Shapes;

namespace GeometryCalculatorTests;

public class CircleTests
{
    private readonly Circle[] _circles;
    private readonly double _precision = 0.001;

    public CircleTests()
    {
        _circles = new[]
        {
            new Circle(0.2),
            new Circle(10),
            new Circle(999)
        };
    }

    [Test]
    public void CalculateArea()
    {
        var circleAreasResult = new[]
        {
            0.126,
            314.159,
            3135312.61
        };
        
        for (int i = 0; i < _circles.Length; i++)
        {
            var circle = _circles[i];
            var expectedArea = circleAreasResult[i];
            
            var area = circle.CalculateArea();
            Assert.That(Math.Abs(expectedArea - area) < _precision);
        }
    }
}
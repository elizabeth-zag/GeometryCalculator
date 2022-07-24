using GeometryCalculator.Shapes;

namespace GeometryCalculatorTests;

public class TriangleTests
{
    private readonly Triangle[] _triangles;
    private readonly double _precision = 0.001;

    public TriangleTests()
    {
        _triangles = new[]
        {
            new Triangle(3, 4, 5),
            new Triangle(10, 7, 12),
            new Triangle(50, 70, 100)
        };
    }

    [Test]
    public void CalculateArea()
    {
        var triangleAreasResult = new[]
        {
            6.0,
            34.978,
            1624.808
        };
        
        for (int i = 0; i < _triangles.Length; i++)
        {
            var triangle = _triangles[i];
            var expectedArea = triangleAreasResult[i];
            
            var area = triangle.CalculateArea();
            Assert.That(Math.Abs(expectedArea - area) < _precision);
        }
    }
    
    [Test]
    public void CheckOrthogonal()
    {
        var isOrthogonalResult = new[] {true, false, false };
        for (int i = 0; i < _triangles.Length; i++)
        {
            var triangle = _triangles[i];
            var expectedResult = isOrthogonalResult[i];
            
            var result = triangle.IsOrthogonal();
            Assert.AreEqual(expectedResult, result);
        }
    }
}
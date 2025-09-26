using System.Reflection;

public class LessonTests
{
    private static string lesson48FilePath = @"../../../Lesson48Tests/Math.Tests.cs";
    private string lesson48Content = File.ReadAllText(lesson48FilePath);
    private readonly string[] _requiredTestMethods =
    {
        "ShouldReturnCorrectRomanNumeralFor1",
        "ShouldReturnCorrectRomanNumeralFor483",
        "ShouldReturnEmptyStringWhenIntegerIsOutOfRange"
    };

    [Fact]
    public void Lesson48MathTestsShouldPass()
    {
        var testAssembly = Assembly.GetExecutingAssembly();
        var mathTestsClass = testAssembly.GetTypes()
            .FirstOrDefault(t => t.Name == "MathTests");

        Assert.NotNull(mathTestsClass);

        var instance = Activator.CreateInstance(mathTestsClass);

        foreach (var requiredMethodName in _requiredTestMethods)
        {
            var testMethod = mathTestsClass.GetMethod(requiredMethodName);
            Assert.True(testMethod != null, $"Method {requiredMethodName} not found in MathTests class");

            try
            {
                testMethod.Invoke(instance, null);
            }
            catch (TargetInvocationException ex)
            {
                Assert.Fail($"Test {requiredMethodName} failed: {ex.InnerException?.Message ?? ex.Message}");
            }
        }
    }

    [Fact]
    public void Lesson48MathTestsShouldContainExpectedAssertions()
    {
        Assert.True(lesson48Content.Contains("Assert.Equal(\"I\", result);"),
            $"The file {lesson48FilePath} does not contain \"Assert.Equal(\"I\", result);\".");
        Assert.True(lesson48Content.Contains("Assert.Equal(\"CDLXXXIII\", result);"),
            $"The file {lesson48FilePath} does not contain \"Assert.Equal(\"CDLXXXIII\", result);\".");
        Assert.True(lesson48Content.Contains("Assert.Equal(\"\", result);"),
            $"The file {lesson48FilePath} does not contain \"Assert.Equal(\"\", result);\".");
    }
}
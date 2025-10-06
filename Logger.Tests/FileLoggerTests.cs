using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void Log_WithMessage_WritesToFile()
    {
        // Arrange
        string filePath = Path.GetTempFileName();
        var logger = new FileLogger(filePath);

        // Act
        logger.Log(LogLevel.Warning, "Warning message");

        // Assert
        string fileInfo = File.ReadAllText(filePath);
        Assert.IsTrue(fileInfo.Contains("Warning message"));

        // Cleanup
        File.Delete(filePath);
    }

    [TestMethod]

    public void Log_AppendsMessage_ToNewLine()
    {
        // Arrange
        string filePath = Path.GetTempFileName();
        var logger = new FileLogger(filePath);

        // Act
        logger.Log(LogLevel.Error, "First Line Message");
        logger.Log(LogLevel.Error, "Second Line Message");

        // Assert
        string[] lines = File.ReadAllLines(filePath);
        Assert.AreEqual(lines.Length, 2);
        Assert.IsTrue(lines[0].Contains("First Line Message"));
        Assert.IsTrue(lines[1].Contains("Second Line Message"));

        // Cleanup
        File.Delete(filePath);



    }

}




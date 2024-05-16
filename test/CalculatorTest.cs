using Xunit;

public class CalculatorTest
{
    [Fact]
    public void Op()
    {
      //Arrange
      var calculator = new Calculator();
      //Act  
      var result = calculator.Op(2,3);
      //Assert
      Assert.Equal(5,result);
    }


}
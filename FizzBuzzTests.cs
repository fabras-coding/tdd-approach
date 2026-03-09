namespace tdd_approach;

public class FizzBuzzTests
{
    [Fact]
    public void ShouldReturnTheNumber_When_Not_A_MultipleOf_5_Or_3()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.Generate(1);
        Assert.Equal("1", result);
    }

    [Fact]
    public void ShouldReturn_TheNumber_When_Not_A_MultipleOf_5_Or_3_OtherNumber()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.Generate(2);
        Assert.Equal("2", result);

    }

    [Fact]
    public void ShouldReturnFizz_When_It_Is_A_MultipleOf_3()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.Generate(3);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void ShouldReturnBuzz_When_It_Is_A_MultilpeOf_5()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.Generate(5);
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void ShouldReturnFizzBuzz_Whent_It_Is_A_MultipleOf_3_and_5()
    {
        var fizzBuzz = new FizzBuzz();
        var result = fizzBuzz.Generate(15);
        Assert.Equal("FizzBuzz", result);
    }





}

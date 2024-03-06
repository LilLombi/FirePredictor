namespace FirePredictorTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double a = FirePredictor.MathOperations.chandlerBI(25.0, 50.0);
            Assert.Equal(20, a);
        }

        [Fact]
        public void Test2()
        {
            double b = FirePredictor.MathOperations.chandlerBI(14.5, 66.0);
            Assert.Equal(5, b);
        }

        [Fact]
        public void Test3()
        {
            double b = FirePredictor.MathOperations.chandlerBI(-3, 80);
            Assert.Equal(0, b);
        }

        [Fact]
        public void Test4()
        {
            double b = FirePredictor.MathOperations.chandlerBI(25.0, -50.0);
            Assert.Equal(20, b);
        }
    }
}
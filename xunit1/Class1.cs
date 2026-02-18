using Xunit;

namespace xunit1
{
    
    public class Class1
    {

        public int add(int x, int y)
        { 
            return x + y; 
        }
        
        public bool MayorA5(int valor)
        {
            if (valor > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [Fact]
        public void TestCorrecto1()
        {
            Assert.Equal(4, add(2, 2));
        }

        [Fact]
        public void TestCorrecto2()
        {
            Assert.NotEqual(5, add(2, 2));
        }

        [Fact]
        public void test1()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData("a", "b", 1)]
        public void test2(string a, string b, int c)
        {
            Assert.True(true);
        }

        [Fact]
        public void TestCorrecto()
        {
            Assert.Equal(4, add(2,2));
        }

        

        [Theory]
        [InlineData(3)]
        [InlineData(100)]
        [InlineData(6)]
        public void TestCorrectoTheory(int value)
        {
            Assert.True(MayorA5(value));
        }



    }
}

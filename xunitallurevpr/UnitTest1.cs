using Xunit;
using Allure.Xunit.Attributes;

namespace xunitallurevpr
{
    public class UnitTest1
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

        [Fact(DisplayName = "Test exitoso de suma")]
        [AllureTag("SmokeTest", "Regression")]
        [AllureOwner("QA_Team")]
       public void SuccessfulSumTest()
        {
            Assert.Equal(4, add(2, 2));
        }

        [Fact(DisplayName = "Test fallido de resta")]
        [AllureOwner("Developer")]
        public void FailedSubtractionTest()
        {
            Assert.Equal(4, add(3, 2));

        }

        [Fact(DisplayName = "Test exitoso de suma 2")]
        [AllureTag("SmokeTest vpr", "Regression")]
        [AllureOwner("QA_Team 2")]
        public void SuccessfulSumTest2()
        {
            Assert.Equal(5, add(3, 2));
        }
    }
}
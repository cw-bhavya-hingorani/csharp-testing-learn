using MVCTesting.Controllers;
using Xunit;

namespace MVCTesting.test{

    public class HomeTest{

        HomeController hc;

        public HomeTest(){
            hc = new();
        }

        [Fact]
        public void add_zero_addingTwoNums()
        {
            int a=5, b=-5;

            var result = hc.add(a, b);

            Assert.Equal(0, result);
        }
    }
}
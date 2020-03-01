using SharpieSet;
using Xunit;

namespace SharpieTest
{
    public class SharpieTest
    {
        [Fact]
        public void UseSharpie()
        {
            var sharpie = new Sharpie("green", 0.3f);
            sharpie.Use();
            var result = sharpie.InkAmount;
            Assert.Equal(99, result);

        }
    }
}

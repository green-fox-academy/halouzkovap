using Xunit;

namespace Sharpies
{
    public class SharpieTest
    {
        [Fact]
        public void Use()
        {
            Sharpies sharpie = new Sharpies("yellow", 5.0f);
            sharpie.Use();
            float result = sharpie.InkAmount;
            Assert.Equal(99, result);

        }
    }
}

using CAB;
using System.Linq;
using Xunit;

namespace CABTests
{
    public class CABNumberTest
    {
        [Fact]
        public void CreateArrayNumber()
        {
            var cabNumber = new CABNumber();
            var result = cabNumber.GetCABNumber();
            Assert.Equal(4, result.Count);
        }

        [Fact]
        public void CreateArrayNumberCheckUnique()
        {
            var cabNumber = new CABNumber();
            var result = cabNumber.GetCABNumber();
            var resl = result.Distinct();
            Assert.Equal(4, resl.Count());
        }
    }
}

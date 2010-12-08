using Umar;
using Xunit;
using Tests.Mocks;

namespace Tests {
    public class CanTests {
        [Fact]
        public void ShouldBeAbleToCheckIfAUserHasAnAbility() {
            var resource = new MockResource();
            var result = Can.Read( resource );
            Assert.False( result );
        }

        [Fact]
        public void CanReadShouldBeFalseIfAbilityIsNotDefined() {
            new MockAbility().Initialize( new MockUser() );
            var resource = new MockResource();
            var result = Can.Read( resource );
            Assert.True( result );
        }
    }
}
using Tests.Mocks;
using Xunit;

namespace Tests {
    public class AbilityBaseTests {

        [Fact]
        public void ShouldBeAbleToInitializeAbility() {
            var mockUser = new MockUser();
            var ability = new MockAbility();
            ability.Initialize( mockUser );
        }
    }
}
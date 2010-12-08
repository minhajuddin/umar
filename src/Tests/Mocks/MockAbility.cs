using Umar;

namespace Tests.Mocks {
    class MockAbility : AbilityBase<MockUser> {
        public override void Initialize( MockUser user ) {
            if ( user.IsAdmin() ) {
                Can( Privilege.Read );
            }
        }

        protected void Can( Privilege privilege ) {
        }
    }
}
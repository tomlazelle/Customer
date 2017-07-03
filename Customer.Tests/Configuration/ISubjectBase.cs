using Ploeh.AutoFixture;

namespace Customer.Tests.Configuration
{
    public interface ISubjectBase
    {
        void FixtureSetup(IFixture fixture);
        void FixtureTearDown();
    }
}
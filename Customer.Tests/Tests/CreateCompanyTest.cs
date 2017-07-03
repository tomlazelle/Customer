using Customer.Domain.Handlers;
using Customer.Domain.Messages;
using Customer.Tests.Configuration;
using Ploeh.AutoFixture;
using Should;

namespace Customer.Tests.Tests
{
    public class CreateCompanyTest:Subject<CompanyHandler>
    {
        public override void FixtureSetup(IFixture fixture)
        {
            base.FixtureSetup(fixture);
            RegisterDatabase();
        }
        public void can_create_a_company()
        {
            var createCompany = _fixture.Create<CreateCompanyMessage>();
            
            var company = Sut.Handle(createCompany);

            company.ShouldNotBeNull();
            company.Name.ShouldNotBeNull();
            company.Name.ShouldEqual(createCompany.Name);
        }
    }
}
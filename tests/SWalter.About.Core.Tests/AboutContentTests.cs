namespace SWalter.About.Core.Tests;

public class AboutContentTests
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(AboutContent).GetConstructors());
    }
}
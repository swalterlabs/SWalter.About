using SWalter.About.Avalonia.Models;

namespace SWalter.About.Avalonia.Tests.Models;

public class AboutViewModelExtendedTests
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(AboutViewModelExtended).GetConstructors());
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_ReturnsInterfaceName(AboutViewModelExtended sut)
    {
        sut.Should().BeAssignableTo<IAboutViewModelExtended>();
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(AboutViewModelExtended).GetMethods().Where(method => !method.IsAbstract));
    }
}
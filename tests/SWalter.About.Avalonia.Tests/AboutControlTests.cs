using Avalonia.Controls;

namespace SWalter.About.Avalonia.Tests;

public class AboutControlTests
{
    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_HasNullGuards(GuardClauseAssertion assertion)
    {
        assertion.Verify(typeof(AboutControl).GetConstructors());
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Constructor_ReturnsInterfaceName(AboutControl sut)
    {
        sut.Should().BeAssignableTo<UserControl>();
    }

    [Theory, NSubstituteOmitAutoPropertiesTrueAutoData]
    public void Methods_HaveNullGuards(GuardClauseAssertion assertion)
    {
        var baseMethods = typeof(AboutControl).BaseType?.GetMethods().Select(method => method.Name) ?? [];

        assertion.Verify(typeof(AboutControl).GetMethods().Where(method => !method.IsAbstract &
                                                                           !baseMethods.Contains(method.Name)
        ));
    }
}
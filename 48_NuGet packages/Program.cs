using Moq;
using NUnit.Framework;


[TestFixture]
public class SomeTests
{
    private Mock<IFlyable> _flyableMock;
}

public interface IFlyable
{
    void Fly();
}


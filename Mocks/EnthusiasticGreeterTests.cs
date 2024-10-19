[TestFixture]
public class EnthusiasticGreeterTests
{
    private Mock<Action<string>> _printToConsoleMock;
    private EnthusiasticGreeter _cut;

    [SetUp]
    public void SetUp()
    {
        _printToConsoleMock = new Mock<Action<string>>();
        _cut = new EnthusiasticGreeter(
            _printToConsoleMock.Object);
    }

    [Test]
    public void ShallPrintHello5Times_WhenCalledPrintHello5Times()
    {
        _cut.PrintHelloNTimes(5);
        _printToConsoleMock.Verify(
            mock => mock("Hello!"), Times.Exactly(5));
    }
}

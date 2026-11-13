namespace UnitTests;

public class Tests
{
    Pin pin = new Pin();

    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void AmountIsWithinRange()
    {
        Assert.That(pin.Expend(100), Is.EqualTo(false));
    }
    [Test]
    public void AmountOverCriticalAmount()
    {
        Assert.That(pin.Expend(351), Is.EqualTo(true));
    }
    [Test]
    public void AmountIsNegative()
    {
        Assert.That(pin.Expend(-10), Is.EqualTo(false));
    }
}

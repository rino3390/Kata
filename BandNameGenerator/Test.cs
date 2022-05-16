namespace Kata.BandNameGenerator;

[TestFixture]
public class Test
{
	[SetUp]
	public void SetUp() {
	}

	[Test]
	[TestCase("knife","The Knife")]
	[TestCase("tart","Tartart")]
	[TestCase("sandles","Sandlesandles")]
	[TestCase("bed","The Bed")]
	public void TestMethod(string noun,string expect) {
		Assert.That(Kata.BandNameGenerator(noun),Is.EqualTo(expect));
	}
}
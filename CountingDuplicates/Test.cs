namespace Kata.CountingDuplicates;

[TestFixture]
public class Test
{
	[SetUp]
	public void SetUp() {
	}

	[Test]
	[TestCase("",0)]
	[TestCase("abcde",0)]
	[TestCase("aabbcde",2)]
	[TestCase("aabBcde",2)]
	[TestCase("Indivisibility",1)]
	[TestCase("Indivisibilities",2)]
	public void TestMethod(string str, int expected) {
		Assert.That(Kata.DuplicateCount(str), Is.EqualTo(expected));
	}

	[Test]
	[TestCase("",0)]
	[TestCase("abcde",0)]
	[TestCase("aabbcde",2)]
	[TestCase("aabBcde",2)]
	[TestCase("Indivisibility",1)]
	[TestCase("Indivisibilities",2)]
	public void OneLaneTestMethod(string str, int expected) {
		Assert.That(Kata.DuplicateCountOneLane(str), Is.EqualTo(expected));
	}
}
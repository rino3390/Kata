namespace Kata.StringAverage;

public class Tests
{
	[SetUp]
	public void Setup() {
	}

	[Test]
	[TestCase("zero nine five two","four")]
	[TestCase("four six two three","three")]
	[TestCase("one two three four five","three")]
	[TestCase("five four","four")]
	[TestCase("zero zero zero zero zero","zero")]
	[TestCase("one one eight one","two")]
	[TestCase("","n/a")]
	public void TestEnum(string input,string expect) {
		Assert.That(new Kata().StringAverageWithEnum(input), Is.EqualTo(expect));
	}
	[Test]
	[TestCase("zero nine five two","four")]
	[TestCase("four six two three","three")]
	[TestCase("one two three four five","three")]
	[TestCase("five four","four")]
	[TestCase("zero zero zero zero zero","zero")]
	[TestCase("one one eight one","two")]
	[TestCase("","n/a")]
	public void TestArray(string input,string expect) {
		Assert.That(new Kata().StringAverageWithArray(input), Is.EqualTo(expect));
	}
}
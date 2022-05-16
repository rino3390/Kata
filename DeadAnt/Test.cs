namespace Kata.DeadAnt;

[TestFixture]
public class Test
{
	[SetUp]
	public void SetUp() {
	}

	[Test]
	[TestCase("ant ant ant ant",0)]
	[TestCase(null,0)]
	[TestCase("ant anantt aantnt",2)]
	[TestCase("ant ant .... a nt",1)]
	[TestCase("atta..aanat.at.nnt.antnt.tn.a.aan..a..n....t.n.nt.n.t",10)]
	public void TestMethod(string ants,int expect) {
		Assert.That(Kata.DeadAntCount(ants),Is.EqualTo(expect));
	}
}
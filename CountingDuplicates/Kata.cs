namespace Kata.CountingDuplicates;

public class Kata
{
	public static int DuplicateCount(string str) {
		str = str.ToLower();
		var store = new List<char>();
		foreach (var t in str.Where(t => !store.Contains(t) && str.Count(c=> c==t)>1)) {
			store.Add(t);
		}
		return store.Count;
	}

	public static int DuplicateCountOneLane(string str) {
		return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
	}
}
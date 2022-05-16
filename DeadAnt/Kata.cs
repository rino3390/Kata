namespace Kata.DeadAnt;

public class Kata
{
	public static int DeadAntCount(string ants) {
		if (string.IsNullOrEmpty(ants)) {
			return 0;
		}
		ants = ants.Replace("ant", "");
		return Math.Max(ants.Count(x=> x=='a'), Math.Max(ants.Count(x=> x=='n'),ants.Count(x=> x=='t')));
	}
}
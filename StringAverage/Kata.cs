namespace Kata.StringAverage;

public class Kata
{
	public static string StringAverageWithEnum(string str) {
		var nums = str.Split();
		if (nums.Length==0 || nums.Any(num => !Enum.IsDefined(typeof(NumStringEnum),num))) {
			return "n/a";
		}
		var sum = nums.Average(num => (int) Enum.Parse<NumStringEnum>(num));
		return ((NumStringEnum) sum).ToString();
	}
	public static string StringAverageWithArray(string str) {
		var numString = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
		var nums = str.Split();
		if (nums.Length==0 || !nums.All(numString.Contains)) {
			return "n/a";
		}
		var sum = nums.Average(num => Array.IndexOf(numString,num));
		return numString[(int)sum];
	}
}
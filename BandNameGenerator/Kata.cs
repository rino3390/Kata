namespace Kata.BandNameGenerator;

public class Kata
{
	public static string BandNameGenerator(string str) {
		if (str[0] == str[^1]) return str[0].ToString().ToUpper() + str[1..] + str[1..];
		return "The " + str[0].ToString().ToUpper() + str[1..];
	}
}
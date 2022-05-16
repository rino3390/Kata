namespace Kata.BandNameGenerator;

public class Kata
{
	public static string BandNameGenerator(string str) {
		return (str[0] != str[^1] ? "The " + char.ToUpper(str[0]) : char.ToUpper(str[0]) + str[1..]) + str[1..];
	}
}
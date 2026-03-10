namespace Tutorial2;

public class StatisticsHelper
{
	public static int Main(string[] args)
	{
		string? line;
		int[]? numbers;
		while (true) {
			Console.WriteLine("Enter numbers separated by space: ");
			line = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(line)) {
				Console.WriteLine("Invalid input detected");
				continue;
			}
			numbers = line.Trim().Split(' ').Select(int.Parse).ToArray();
			Console.WriteLine(string.Join(", ", numbers));
		}
	}
}

using System;
using System.Linq;

public class Program
{
	public static void Main(string[] args)
	{
		args = new string[1] { "265149" };

		Console.WriteLine(Steps(int.Parse(args[0])));
	}

	/// <summary>
	/// Calculate the max possible length for the solutions layer
	/// </summary>
	/// <param name="solution">Solution</param>
	/// <returns>Length</returns>
	public static int SideLength(int solution)
	{
		// We get the amount of steps to the bottom right corner of solution
		var floor = (int)Math.Floor(Math.Sqrt(solution) + 1);
		return floor + 1 - floor % 2; // Add 1 if number is even
	}

	/// <summary>
	/// Get the total amount of steps for the solution to go to 1
	/// </summary>
	/// <param name="solution">Solution</param>
	/// <returns>Steps</returns>
	public static int Steps(int solution)
	{
		// Total length this line has
		var len = SideLength(solution);

		// Total length divided by two and rounded down
		var offset = (int)(len - 1) / 2;

		// Loop over the 4 sides, there's probably a way to skip this but my brain isn't working tonight... 
		var sides = new int[4];
		for (var i = 0; i < 4; i++)
		{
			sides[i] = (int)(Math.Pow(len, 2) - (len - 1) * i - (len / 2));
		}

		return sides.Min(s => Math.Abs(solution - s)) + offset;
	}
}

// of extended Euclidean Algorithm
using System;

class GFG
{
	
	// extended Euclidean Algorithm
	public static int gcdExtended(int a, int b,
								int x, int y)
	{
		// Base Case
		if (a == 0)
		{
			x = 0;
			y = 1;
			return b;
		}

		// To store results of
		// recursive call
		int x1 = 1, y1 = 1;
		int gcd = gcdExtended(b % a, a, x1, y1);

		// Update x and y using
		// results of recursive call
		x = y1 - (b / a) * x1;
		y = x1;

		return gcd;
	}
	
	// Driver Code
	static public void Main ()
	{
		int x = 1, y = 1;
		int a = 35, b = 15;
		int g = gcdExtended(a, b, x, y);
		Console.WriteLine("gcd(" + a + " , " +
							b + ") = " + g);
	}
}
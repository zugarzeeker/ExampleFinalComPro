using System;
class test {
	static void Main() {
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		Console.WriteLine("_________________");
		int min = findMin(n1, n2);
	}

	static int findMin(int a, int b) {
		Console.WriteLine("Find Min Int");
		if (a > b)
			return b;
		return a;
	}

	static double findMin(double a, double b) {
		Console.WriteLine("Find Min Double");
		if (a > b)
			return b;
		return a;
	}
}

using System;
class test {
	static void Main() {
		int [,] a = {{1,2,3},{4,5,6}};
		int [,] b = {{0,1,2},{6,8,9}};
		Console.WriteLine("A");
		printMatrix(a);
		Console.WriteLine("B");
		printMatrix(b);
		Console.WriteLine("Sum");
		printMatrix(sumArray(a, b));
	}

	static void printMatrix(int [,] a) {
		for (int row = 0; row < a.GetLength(0); row++) {
			for (int col = 0; col < a.GetLength(1); col++) {
				Console.Write(a[row, col] + " ");
			}
			Console.WriteLine();
		}
	}

	static int [,] sumArray(int [,] a, int [,] b) {
		int [,] sum = new int [a.GetLength(0), b.GetLength(1)];
		for (int row = 0; row < sum.GetLength(0); row++) {
			for (int col = 0; col < sum.GetLength(1); col++) {
				sum[row, col] = a[row, col] + b[row, col];
			}
		}
		return sum;
	}
}

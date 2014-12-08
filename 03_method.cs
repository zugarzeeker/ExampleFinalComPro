using System;
class test {
	static int sum = 1; // global

	static void Main() {
		int sum = 5; // local
		sum++;
		Console.WriteLine(sum);
		addSum();
		Console.WriteLine(sum);
	}

	static void addSum() {
		Console.WriteLine(sum++);
	}

	static void addSum(sum) {
		Console.WriteLine(sum++);
	}
}

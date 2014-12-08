using System;
class test {
	static void Main() {
		int a=2,b=3;
		Console.WriteLine("a = {0} , b = {1}", a, b);
		changeValue(out a, out b);
		Console.WriteLine("a = {0} , b = {1}", a, b);
	}

	static void changeValue(out int c, out int d) {
		c = 100;
		d = 55;	
	}
}

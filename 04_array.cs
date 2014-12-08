using System;
class test {
	static void Main() {
		int [] a = {1,2,3,4,5};
		printArray(a);
		changeValueArray(a);
		printArray(a);
	}

	static void printArray(int [] arr) {
		for (int i = 0; i < arr.Length; i++) {
			Console.Write(arr[i] + " ");	
		}
		Console.WriteLine();
	}

	static void changeValueArray(int [] arr) {
		arr[4] = 1000;
		arr = new int [3];
		arr[0] = -1;
		arr[1] = -2;
		arr[2] = -3;
		printArray(arr);
	}
}

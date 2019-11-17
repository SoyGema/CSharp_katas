using System;
using System.Collections.Generic;

public class InsertionSort
{
	public List<int> Sort (List<int> A) {
		for (int i=1; i < A.Count; i++){
			var key = A[i];
			var space = i-1;
			while (space >= 0 && key < A[space]){
				A[space + 1] = A[space];
				space -= 1;
			}
			A[space + 1] = key;
		
		}
		return A;
	}
	
	
	
		
	public static void Main()
	{
		var myValues = new List<int>() { 23, 32, 47, 2};
		var insertionSort = new InsertionSort() ;
		Console.WriteLine("Hello World");
		var sortedlist = insertionSort.Sort(myValues);
		
		for (int i=0; i < sortedlist.Count ; i++){
			Console.WriteLine(sortedlist[i]);
		}
	}
}

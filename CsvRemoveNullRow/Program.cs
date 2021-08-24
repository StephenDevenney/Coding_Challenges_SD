using System;
using System.Collections.Generic;
using Classes.Enums;
					
public class Program
{
	public static void Main()
	{
		/*
			Problem: Take a csv string and remove any row that contains
			a NULL value.

			Csv strings are fed in through an enum in the classes folder.
		*/

		// Call Solution
		foreach (CsvStringsEnum examples in Enum.GetValues(typeof(CsvStringsEnum)))
    	{
			Console.WriteLine(Solution(examples.ToDescriptionString()));
    	}
	}
	#region SOLUTION
	static string Solution(string S)
	{
		// Split String Into List (Items In List Are Treated As Rows);
		List<string> myList = new List<string>(S.Split('\n'));
		// Find And Remove Row Which Contains NULL Value;
		myList = RemoveNullRow(myList);
		// Re-Connect String And Return For Console Print
		return ConvertToString(myList);
	}
	static List<string> RemoveNullRow(List<string> tableList)
	{
		tableList.RemoveAll(u => u.Contains("NULL"));
		return tableList;
	}
	static string ConvertToString(List<string> tableList)
	{
		string newString = "";
		tableList.ForEach(item => newString += item + "\n");
		return newString;
	}
	#endregion
}
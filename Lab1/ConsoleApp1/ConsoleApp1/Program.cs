using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		string str = "abcd";
		string result = string.Join(" | ", str.ToCharArray());

		Console.WriteLine(result);

	}

	static string[] SplitTextIntoGroups(string text, int groupSize)
	{
		// Pad the text with spaces if necessary to make its length a multiple of the group size
		int paddingSize = (groupSize - text.Length % groupSize) % groupSize;
		text += new string(' ', paddingSize);

		// Split the text into groups of the specified size
		string[] groups = new string[text.Length / groupSize];
		for (int i = 0; i < groups.Length; i++)
		{
			groups[i] = text.Substring(i * groupSize, groupSize);
		}

		return groups;
	}

	static char GetRandomLetter(string alphabet)
	{
		Random random = new Random();
		int index = random.Next(alphabet.Length);
		return alphabet[index];
	}
	}

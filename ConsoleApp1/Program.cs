using System;
using System.Linq;

namespace ConsoleApp1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int[] items = Enumerable.Range(1, 10).ToArray();
			foreach (var item in items)
			{
				Console.Write(item + " ");
			}

			Console.WriteLine();

			int[] items2 = Enumerable.Range(10, 6).ToArray();
			foreach (var item in items2)
			{
				Console.Write(item + " ");
			}
		}
	}
}
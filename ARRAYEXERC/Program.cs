using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYEXERC
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("How many studens in your class");
			var studentcount = int.Parse(Console.ReadLine());

			var studentsname = new string[studentcount];
			var studentgrades = new int[studentcount];

			for (int i = 0; i < studentcount; i++)
			{
				Console.Write("studen name: ");
				studentsname[i] = Console.ReadLine();
				Console.Write("studen grade: ");
				studentgrades[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < studentcount; i++)
			{
				Console.WriteLine("student name: {0}, grade: {1} ", studentsname[i], studentgrades[i]);
			}
		}
	}
}

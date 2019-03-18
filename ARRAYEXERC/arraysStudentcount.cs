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

			var students = new List<Student>();
			

			
			var adding = true;
			while (adding)
			{

				var newStudent = new Student();
				//Console.Write("studen name: ");
				//newStudent.Name = (Console.ReadLine());
				newStudent.Name = util.Console.Ask("student name: ");

				//Console.Write("studen grade: ");
				//newStudent.Grade = int.Parse(Console.ReadLine());
				newStudent.Grade = int.Parse(util.Console.Ask("student Grade: "));

				//Console.WriteLine("Student Birthday");
				//newStudent.BIrthday = Console.ReadLine();
				newStudent.BIrthday = util.Console.Ask("Student Birthday: ");

				//Console.WriteLine("Student Address");
				//newStudent.Address = Console.ReadLine();
				newStudent.Address = util.Console.Ask("student Address: ");

				//Console.WriteLine("Student Phone");
				//newStudent.SetPhone(int.Parse(Console.ReadLine()));
				newStudent.Phone = int.Parse(util.Console.Ask("student Phone: "));

				students.Add(newStudent);
				Student.count++;
				Console.WriteLine("studen count is: {0}", Student.count);


				Console.WriteLine("add another y/n");
				if (Console.ReadLine() != "y")
				{
					adding = false;
				}
			}

			foreach (var Student in students)
			{

		
				Console.WriteLine("student name: {0}, grade: {1} ", Student.Name, Student.Grade);
			}
		}
	}

	class Student
	{
		public int Phone
		{
			set { phone = value; }
		}
		public void SetPhone(int number)
		{
			phone = number;
		}

		static public int count = 0;
		public string Name;
		public int Grade;
		public string BIrthday;
		public string Address;
		private int phone;


	}
}


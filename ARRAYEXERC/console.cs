﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace util

{
	class Console
	{
		static public string Ask(string question)
		{
			System.Console.Write(question);
			return System.Console.ReadLine();
		}
	}
}

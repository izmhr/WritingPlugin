using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomNumberManaged
{
	public class MyClass
	{
		public int GetRandom()
		{
			Random rand = new Random();
			return rand.Next();
		}
	}
}

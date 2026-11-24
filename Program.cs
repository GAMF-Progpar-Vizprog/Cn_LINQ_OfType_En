using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cn_LINQ_OfType_En
{
	class Program
	{
    static void Main(string[] args)
    {
			ArrayList A = new ArrayList() { 2, 4, "something", 5, 1, "nothing", 
        8, 5, "set", 7, 9.5, 13.5 };
			Console.WriteLine("All data: 2, 4, 'something', 5, 1,'nothing', " +
        "8, 5, 'set', 7, 9.5, 13.5");
      IEnumerable<int> I = A.OfType<int>();
      IEnumerable<int> E = from x in I
                           where x % 2 == 0
                           orderby x descending
                           select x;

      Console.Write("Even numbers in descending order: ");
      foreach (int i in E)
        Console.Write(i + ", ");
      Console.ReadLine();

      IEnumerable<string> Words = A.OfType<string>();

      Console.Write("Words: ");
      foreach (string s in Words)
        Console.Write(s + ", ");
      Console.ReadLine();
    }
  }
}

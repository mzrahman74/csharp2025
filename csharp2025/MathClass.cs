using System;
namespace csharp2025
{
	public class MathClass
	{
		public void Method_01()
		{
			Console.WriteLine(Math.Max(25, 200));
		}


		public void Method_02()
		{
			int myAge = 25;
			int votingAge = 18;

			if(myAge >= votingAge)
			{
				Console.WriteLine("Old enough to vote!");
			}
			else
			{
				Console.WriteLine("Not old enough to vote.");
			}
		}
	}

}
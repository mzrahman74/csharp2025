using System;
namespace csharp2025
{
	public class generalClass
	{
		static void Main(string[] args)
		{
			MathClass mathClass = new();
			ArrayClass arrayClass = new();
			PropClass propClass = new PropClass();
			propClass.Name = "Mohammad";
			Console.WriteLine(propClass.Name);
			propClass.Age = 51;
			Console.WriteLine(propClass.Age);
		}

		static void method_01()
		{
			string name = "Mohammad";
			int myAge = 51;
			bool myBool = true;

			Console.WriteLine(name + myAge);
			Console.WriteLine(myBool);
			Console.WriteLine("Enter your username:");

			string userName = Console.ReadLine();

			Console.WriteLine("Username is: " + userName);

			Console.WriteLine("Enter your age: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Your age is: " + age);
		}

		static void method_02()
		{
			string firstName = "Mohamamd";
			string lastName = "Rahman";

			int x = 10;
			int y = 12;

			string name = $"My full name is: {firstName} {lastName}";

			Console.WriteLine(name);
			Console.WriteLine(x < y);
		}
	}
}

	public class testClass
{
	public void SayHello()
	{
		Console.WriteLine("Hello from myClass!");
	}
}


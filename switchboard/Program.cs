using System;

namespace switchboard
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = "i am a local a variable";

			SwitchBoard.Switch("testswitch_a", () =>
			{
				Console.WriteLine($"testswitch_a is on! {a}");
			}, () =>
			{
				Console.WriteLine("testswitch_a is off!");
			}
			);
			Console.ReadLine();
		}
	}
}

using System;
using RobotWars.JAmes;

namespace RobotWars.Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if(args.Length == 0)
			{
				PrintHelp ();
				System.Console.ReadKey ();
				Environment.Exit (0);
			}

			new Game().Run (args[0]);

			System.Console.WriteLine ("GameOver!");
			System.Console.ReadKey ();
			Environment.Exit (0);
		}

		static void PrintHelp ()
		{
			System.Console.WriteLine ("Please provide instruction file path");
		}
	}
}

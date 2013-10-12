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
			System.Console.WriteLine ("3...2...1...Activate! (Press Enter)");
			System.Console.ReadKey ();

			var positions = new Game().Run (args[0]);

			foreach (Position p in positions) 
			{
				var facing = p._facing.ToString ().Substring (0, 1);
				var finalPosition = String.Format ("{0} {1} {2}", p._x, p._y, facing);
				System.Console.WriteLine (finalPosition);
			}

			System.Console.WriteLine ("GameOver!");
			//System.Console.ReadKey ();
			Environment.Exit (0);
		}

		static void PrintHelp ()
		{
			System.Console.WriteLine ("Please provide instruction file path");
			System.Console.WriteLine ("Try: InputFile.txt");
		}
	}
}

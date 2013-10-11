using System;

namespace RobotWars.JAmes
{
	public class InputReader
	{
		string _filePath;
		public InputReader (string filePath)
		{
			_filePath = filePath;
		}

		public WarsConfig Read(){
			var config = new WarsConfig();
			var file = System.IO.File.OpenText (_filePath);

			var areanSettings = file.ReadLine().Split(' ');
			config.arenaX = Convert.ToInt32(areanSettings [0]);
			config.arenaY = Convert.ToInt32(areanSettings [1]);

			var robotOneStartSettings = file.ReadLine().Split(' ');
			config.robotOneX = Convert.ToInt32 (robotOneStartSettings[0]);
			config.robotOneY = Convert.ToInt32 (robotOneStartSettings[1]);
			config.robotOneFacing = robotOneStartSettings [2];

			var robotOneActionsLine = file.ReadLine();
			config.robotOneActions = robotOneActionsLine.ToCharArray();

			var robotTwoStartLocationSettings = file.ReadLine().Split(' ');
			config.robotTwoX = Convert.ToInt32 (robotTwoStartLocationSettings[0]);
			config.robotTwoY = Convert.ToInt32 (robotTwoStartLocationSettings[1]);
			config.robotTwoFacing = robotTwoStartLocationSettings [2];

			var robotTwoActionsLine = file.ReadLine();
			config.robotTwoActions = robotTwoActionsLine.ToCharArray() ;

			return config;
		}
	}

}


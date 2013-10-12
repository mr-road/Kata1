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

		static Facing NewMethod (string[] robotStartSettings)
		{
	
			string facingString =  robotStartSettings [2];
			switch(facingString){
				case "N":
				return Facing.North;

				case "E":
				return Facing.East;

				case "S":
				return  Facing.South;

				case "W":
				return Facing.West;

			}
			return Facing.North;
		}

		static Position StartPosition (string[] robotStartSettings)
		{
			var x = Convert.ToInt32 (robotStartSettings [0]);
			var y = Convert.ToInt32 (robotStartSettings [1]);
			var facing =  NewMethod (robotStartSettings);
			return  new Position (x, y, facing);
		}

		public WarsConfig Read(){
			var config = new WarsConfig();
			var file = System.IO.File.OpenText (_filePath);

			var areanSettings = file.ReadLine().Split(' ');
			config.arenaX = Convert.ToInt32(areanSettings [0]);
			config.arenaY = Convert.ToInt32(areanSettings [1]);

			var robotOneStartSettings = file.ReadLine().Split(' ');
			config.robotOnePosition = StartPosition (robotOneStartSettings);


			var robotOneActionsLine = file.ReadLine();
			config.robotOneActions = robotOneActionsLine.ToCharArray();

			var robotTwoStartLocationSettings = file.ReadLine().Split(' ');
			config.robotTwoPosition = StartPosition (robotTwoStartLocationSettings);

			var robotTwoActionsLine = file.ReadLine();
			config.robotTwoActions = robotTwoActionsLine.ToCharArray() ;

			return config;
		}
	}

}


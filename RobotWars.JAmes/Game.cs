using System;
using System.Collections.Generic;

namespace RobotWars.JAmes
{
	public class Game
	{
		public Game ()
		{
		}

		public IList<Position> Run(string InstructionFilePath)
		{
			var list = new List<Position> ();
			var reader = new InputReader (InstructionFilePath);
			var config = reader.Read ();

			var remoteControlOne = new Remote (config.arenaX, config.arenaY);
			var RobotOne = new Robot (config.robotOnePosition, remoteControlOne);

			foreach (char action in config.robotOneActions) {
				RobotOne.Action (action);
			}

			var remoteControlTwo = new Remote (config.arenaX, config.arenaY);
			var RobotTwo = new Robot (config.robotTwoPosition, remoteControlTwo);

			foreach (char action in config.robotTwoActions) {
				RobotTwo.Action (action);
			}

			list.Add (RobotOne.GetPosition());
			list.Add (RobotTwo.GetPosition());

			return list; 
		}
	}


}


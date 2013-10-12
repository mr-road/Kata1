using System;

namespace RobotWars.JAmes
{

	public class WarsConfig
	{
		public int arenaX { get; set; }
		public int arenaY { get; set; }

		public Position robotOnePosition { get; set; }

		public char[] robotOneActions { get; set; }

		public Position robotTwoPosition { get; set; }

		public char[] robotTwoActions { get; set; }
	}
}

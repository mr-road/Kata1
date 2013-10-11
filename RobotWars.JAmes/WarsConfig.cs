using System;

namespace RobotWars.JAmes
{

	public class WarsConfig
	{
		public int arenaX { get; set; }
		public int arenaY { get; set; }

		public int robotOneX { get; set; }
		public int robotOneY { get; set; }
		public string robotOneFacing { get; set; }

		public char[] robotOneActions { get; set; }

		public int robotTwoX { get; set; }
		public int robotTwoY { get; set; }
		public string robotTwoFacing { get; set; }

		public char[] robotTwoActions { get; set; }
	}
}

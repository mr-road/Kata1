using System;

namespace RobotWars.JAmes
{
	public class Position
	{
		public int _x { get; set; }
		public int _y { get; set; }
		public Facing _facing { get; set; }

		public Position (int x, int y, Facing facing)
		{
			_x = x;
			_y = y;
			_facing = facing;
		}
	}
}


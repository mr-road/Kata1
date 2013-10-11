using System;

namespace RobotWars.JAmes
{
	public class Robot
	{
		Position _position;

		public Robot (int X, int Y, Facing facing)
		{
			_position = new Position (X, Y, facing);
		}

		public Position GetPosition ()
		{
			return _position;
		}

		public  void Action (char c)
		{
			_position = Remote.Control (c, _position);
		}
	}
}


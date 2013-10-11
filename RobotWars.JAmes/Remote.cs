using System;

namespace RobotWars.JAmes
{
	public class Remote
	{


		public static Position Control (char action, Position _position)
		{
			if (action == 'L') {
				TurnLeft (_position);
			}

			if (action == 'R') {
				TurnRight (_position);
			}

			if (action == 'M') 
			{

			}

			return _position;

		}

		static void TurnLeft (Position _position)
		{
			_position._facing = _position._facing - 1;
			if ((int)_position._facing < (int)Facing.North) {
				_position._facing = Facing.West;
			}
		}

		static void TurnRight (Position _position)
		{
			_position._facing = _position._facing + 1;
			if ((int)_position._facing > (int)Facing.West) {
				_position._facing = Facing.North;
			}
		}
	}

	public enum Facing { North, East, South, West }
}


using System;

namespace RobotWars.JAmes
{
	public class Remote
	{
		public static Position Control (char action, Position _position)
		{
			if (action == 'L') {
				_position._facing = _position._facing - 1;
				if ((int)_position._facing < (int)Facing.North) {
					_position._facing = Facing.West;
				}
			}

			if (action == 'R') {
				_position._facing = _position._facing + 1;
			}

			return _position;

		}
	}

	public enum Facing { North, East, South, West }
}


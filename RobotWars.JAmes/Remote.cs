using System;
using Microsoft.Build.Tasks;

namespace RobotWars.JAmes
{
	public class Remote
	{
		static int FORWARD = 1;
		readonly int MAX_X = 1;
		readonly int MAX_Y = 1;

		public Remote(int maxX, int maxY)
		{
			MAX_X = maxX;
			MAX_Y = maxY;
		}


		public Position Control (char action, Position _position)
		{
			if (action == 'L') {
				TurnLeft (_position);
			}

			if (action == 'R') {
				TurnRight (_position);
			}

			if (action == 'M') 
			{
				Move (_position, FORWARD);
			}

			return _position;

		}

		public  void Move(Position _position, int direction)
		{
			if (_position._facing == Facing.North) {
				_position._y += direction;
				_position._y = BoundCheck (_position._y, MAX_Y);
			}

			if (_position._facing == Facing.South) {
				_position._y -= direction;
				_position._y = BoundCheck (_position._y, MAX_Y);
			}

			if (_position._facing == Facing.East) {
				_position._x += direction;
				_position._x = BoundCheck (_position._x, MAX_X);
			}

			if (_position._facing == Facing.West) {
				_position._x -= direction;
				_position._x = BoundCheck (_position._x, MAX_X);
			}
		}

		int BoundCheck(int coordinate, int max){
			if (coordinate > max) {
				coordinate = max;
			}
			if (coordinate < 0) {
				coordinate = 0;
			}
			return coordinate;
		}

		 void TurnLeft (Position _position)
		{
			_position._facing = _position._facing - 1;
			if ((int)_position._facing < (int)Facing.North) {
				_position._facing = Facing.West;
			}
		}

		 void TurnRight (Position _position)
		{
			_position._facing = _position._facing + 1;
			if ((int)_position._facing > (int)Facing.West) {
				_position._facing = Facing.North;
			}
		}
	}

	public enum Facing { North, East, South, West }
}


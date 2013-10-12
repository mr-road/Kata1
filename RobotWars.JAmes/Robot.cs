using System;

namespace RobotWars.JAmes
{
	public class Robot
	{
		Position _position;
		Remote _remote;

		public Robot (Position position, Remote remote)
		{
			_remote = remote;
			_position = position;
		}

		public Position GetPosition ()
		{
			return _position;
		}

		public  void Action (char c)
		{
			_position = _remote.Control (c, _position);
		}
	}
}


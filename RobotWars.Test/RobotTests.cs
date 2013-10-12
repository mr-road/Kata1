using System;
using NUnit.Framework;
using RobotWars.JAmes;

namespace RobotWars.Test
{
	[TestFixture ()]
	public class RobotTests
	{

		//3 x x x
		//2 x > x
		//1 x x x
		//0 1 2 3


		[Test()]
		public void RobotSetupTest ()
		{
			var startPosition = new Position (2, 2, Facing.East);
			var arthur = new Robot(startPosition, new Remote(3,3));
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo(Facing.East));
		}

		[Test()]
		public void RobotLeftTurnTest ()
		{
			var startPosition = new Position (2, 2, Facing.East);
			var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('L');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo(Facing.North));
		}

		[Test()]
		public void RobotLeft_Left_LeftTurnTest ()
		{
			var startPosition = new Position (2, 2, Facing.East);
				var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('L');
			arthur.Action ('L');
			arthur.Action ('L');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo(Facing.South));
		}

		[Test()]
		public void RobotRightTurnTest ()
		{
			var startPosition = new Position (2, 2, Facing.East);
			var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('R');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo( Facing.South));
		}

		[Test()]
		public void RobotRight_Right_RightTurnTest ()
		{
			var startPosition = new Position (2, 2, Facing.East);
			var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('R');
			arthur.Action ('R');
			arthur.Action ('R');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo( Facing.North));
		}

		[Test()]
		public void RobotMoveEastTest ()
		{
			var startPosition = new Position (2, 2, Facing.East);
			var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(3));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo(Facing.East));
		}

		[Test()]
		public void RobotMoveNorthTest ()
		{var startPosition = new Position (2, 2, Facing.North);
			var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(3));
			Assert.That(position._facing, Is.EqualTo(Facing.North));
		}

		[Test()]
		public void RobotMoveSouthTest ()
		{var startPosition = new Position (2, 2, Facing.South);
			var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(1));
			Assert.That(position._facing, Is.EqualTo(Facing.South));
		}

		[Test()]
		public void RobotMoveWestTest ()
		{var startPosition = new Position (2, 2, Facing.West);
			var arthur = new Robot(startPosition, new Remote(3,3));
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(1));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo(Facing.West));
		}



	}
}


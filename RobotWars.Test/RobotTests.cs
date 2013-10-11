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
			var arthur = new Robot(2, 2, Facing.East);
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo(Facing.East));
		}

		[Test()]
		public void RobotLeftTurnTest ()
		{
			var arthur = new Robot(2, 2, Facing.East);
			arthur.Action ('L');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo(Facing.North));
		}

		[Test()]
		public void RobotLeft_Left_LeftTurnTest ()
		{
			var arthur = new Robot(2, 2, Facing.East);
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
			var arthur = new Robot(2, 2,  Facing.East);
			arthur.Action ('R');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo( Facing.South));
		}

		[Test()]
		public void RobotRight_Right_RightTurnTest ()
		{
			var arthur = new Robot(2, 2,  Facing.East);
			arthur.Action ('R');
			arthur.Action ('R');
			arthur.Action ('R');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo( Facing.North));
		}



	/*	[Test()]
		public void RobotMoveEastTest ()
		{
			var arthur = new Robot(2, 2, "E");
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(3));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo("E"));
		}

		[Test()]
		public void RobotMoveNorthTest ()
		{
			var arthur = new Robot(2, 2, "N");
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(3));
			Assert.That(position._facing, Is.EqualTo("N"));
		}

		[Test()]
		public void RobotMoveSouthTest ()
		{
			var arthur = new Robot(2, 2, "S");
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(2));
			Assert.That(position._y, Is.EqualTo(1));
			Assert.That(position._facing, Is.EqualTo("S"));
		}

		[Test()]
		public void RobotMoveWestTest ()
		{
			var arthur = new Robot(2, 2, "W");
			arthur.Action ('M');
			var position = arthur.GetPosition();
			Assert.That(position._x, Is.EqualTo(1));
			Assert.That(position._y, Is.EqualTo(2));
			Assert.That(position._facing, Is.EqualTo("W"));
		}

*/

	}
}


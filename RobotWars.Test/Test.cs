using NUnit.Framework;
using System;
using RobotWars.JAmes;

namespace RobotWars.Test
{
	[TestFixture()]
	public class GameTests
	{
		[Test()]
		public void  RunThrowsNoExceptions ()
		{
			new Game().Run ("TestOne.txt");
			Assert.True (true);
		}

		[Test()]
		public void  CanReadInTestFileAndMoveRobotOne ()
		{
			//x  x x x //x  x x x
			//x  x x x //<  = x x
			//1> x x x //=  # x x
			//x  x x x //x  x x x
			var positions = new Game().Run ("TestTwo.txt");
			Assert.That (positions [0]._facing, Is.EqualTo (Facing.West));
			Assert.That (positions [0]._x, Is.EqualTo (1));
			Assert.That (positions [0]._y, Is.EqualTo (3));
		}

		[Test()]
		public void  CanReadInTestFileAndMoveRobotTwo ()
		{              //>  V
			//x  < x x //^  < x x
			//x  x x x //x  x x x
			//x  x x x //x  x x x
			//x  x x x //x  x x x
			var positions = new Game().Run ("TestTwo.txt");
			Assert.That (positions [1]._facing, Is.EqualTo (Facing.South));
			Assert.That (positions [1]._x, Is.EqualTo (2));
			Assert.That (positions [1]._y, Is.EqualTo (4));
		}

		[Test()]
		public void  CanReadInTopTableFile ()
		{
			var positions = new Game().Run ("InputFile.txt");
			Assert.That (positions [0]._facing, Is.EqualTo (Facing.North));
			Assert.That (positions [0]._x, Is.EqualTo (1));
			Assert.That (positions [0]._y, Is.EqualTo (3));

			Assert.That (positions [1]._facing, Is.EqualTo (Facing.East));
			Assert.That (positions [1]._x, Is.EqualTo (5));
			Assert.That (positions [1]._y, Is.EqualTo (1));
		}
	}
}


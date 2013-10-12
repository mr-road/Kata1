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
		public void  CanReadInTestFileAndMove ()
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
	}
}


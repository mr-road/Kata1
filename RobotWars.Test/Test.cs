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

	}
}


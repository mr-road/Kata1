using NUnit.Framework;
using System;
using RobotWars.JAmes;

namespace RobotWars.Test
{
	[TestFixture ()]
	public class InputReaderTest
	{
		WarsConfig config1;

		[TestFixtureSetUp]
		public void Setup()
		{
			var testFile = "TestOne.txt";
			var reader = new InputReader (testFile);
			config1 = reader.Read ();
		}

		[Test ()]
		public void ReadInArenaConfig ()
		{
			Assert.That (config1.arenaX, Is.EqualTo (1));
			Assert.That (config1.arenaY, Is.EqualTo (2));
		}

		[Test ()]
		public void ReadInRobotOneConfig ()
		{
			Assert.That (config1.robotOneX, Is.EqualTo (5));
			Assert.That (config1.robotOneY, Is.EqualTo (6));
			Assert.That (config1.robotOneFacing, Is.EqualTo ("Q"));
		}

		[Test ()]
		public void ReadInRobotOneActions ()
		{
			Assert.That (config1.robotOneActions.Length, Is.EqualTo (6));
			Assert.That (config1.robotOneActions[0], Is.EqualTo('A'));
		}

		[Test ()]
		public void ReadInRobotTwoConfig ()
		{
			Assert.That (config1.robotTwoX, Is.EqualTo (4));
			Assert.That (config1.robotTwoY, Is.EqualTo (7));
			Assert.That (config1.robotTwoFacing, Is.EqualTo ("W"));
		}

		[Test ()]
		public void ReadInRobotTwoActions ()
		{
			Assert.That (config1.robotTwoActions.Length, Is.EqualTo (4), "robotOneActions length is not equal to 4");
			Assert.That (config1.robotTwoActions[0], Is.EqualTo('D'));
		}
	}
}


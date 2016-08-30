﻿using CSRogue;
using CSRogue.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSRogue.Item_Handling;

namespace RogueTests
{
	
	
	/// <summary>
	///This is a test class for ItemInfoTest and is intended
	///to contain all ItemInfoTest Unit Tests
	///</summary>
	[TestClass()]
	public class ItemInfoTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//Use ClassInitialize to run code before running the first test in the class
		[ClassInitialize()]
		public static void MyClassInitialize(TestContext testContext)
		{
		}
		#endregion
	}
}

using System;
using Xunit;

namespace TexasNIC.Tests
{
    public abstract class BinaryChopUtilTestBase
    {
		protected static IBinaryChopUtil _binaryChopUtil;

		[Theory]
		[InlineData(new int[] { 1 })]
		[InlineData(new int[] { 1, 2, 3 })]
		[InlineData(new int[] { 2, 4, 6, 8, 10, 12, 14 })]
		public void ChopShouldReturnIndex(int[] mockArray)
		{
			for (int i = 0; i < mockArray.Length; i++)
			{
				var searchIndex = _binaryChopUtil.Chop(mockArray[i], mockArray);
				Assert.True(searchIndex == i);
			}
		}

		[Fact]
		public void ChopShouldReturnNotFoundIndex()
		{
			// arrange
			var mockArray = new int[] { 12, 23, 174 };
			var mockTarget = 1337;

			// act
			var searchIndex = _binaryChopUtil.Chop(mockTarget, mockArray);

			// assert
			Assert.True(searchIndex == -1);
		}

		[Fact]
		public void ChopShouldThrowArgumentNullException()
		{
			// arrange
			var binaryChopUtil = new BinaryChopUtil();

			// assert
			var ex = Assert.Throws<ArgumentNullException>(() => binaryChopUtil.Chop(99, null));
			Assert.Contains("Parameter name: array", ex.Message);
		}
	}
}
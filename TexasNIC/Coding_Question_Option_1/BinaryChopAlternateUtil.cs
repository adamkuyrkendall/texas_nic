using System;

namespace TexasNIC
{
	public class BinaryChopAlternateUtil : IBinaryChopUtil
	{
		public int Chop(int target, int[] array)
		{
			if (array == null)
				throw new ArgumentNullException("array");

			return Array.FindIndex(array, element => element == target);
		}
	}
}

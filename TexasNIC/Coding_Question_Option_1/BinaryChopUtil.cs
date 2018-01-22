using System;

namespace TexasNIC
{
    public class BinaryChopUtil : IBinaryChopUtil
    {
		public int Chop(int target, int[] array)
		{
			if (array == null)
				throw new ArgumentNullException("array");

			return Array.IndexOf(array, target);
		}
    }
}

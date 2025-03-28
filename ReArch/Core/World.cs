using System.Collections.Generic;

namespace ReArch.Core
{
	public class World
	{
		public static World[] Worlds { get; private set; } = new World[4];
		private Queue<int> RecycledWorldIds = new(8);
		public static int WorldSize { get; private set; }

	}
}

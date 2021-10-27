using System;

namespace Singleton
{
	public sealed class LazySingletonPOC
	{
		private static readonly Lazy<LazySingletonPOC> lazy = new Lazy<LazySingletonPOC>(() => new LazySingletonPOC());
		public static LazySingletonPOC GetInstance()
		{
			return lazy.Value;
		}

		private LazySingletonPOC()
		{
		}
	}
}

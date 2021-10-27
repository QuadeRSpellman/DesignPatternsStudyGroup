using System;

namespace Singleton
{
	/// <summary>
	/// Bad. Not thread-safe. 
	/// </summary>
	public sealed class NaiveSingleton
	{
		private static NaiveSingleton instance = null;

		private NaiveSingleton()
		{
		}

		public static NaiveSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new NaiveSingleton();
				}
				return instance;
			}
		}
	}

	/// <summary>
	/// This implementation is thread-safe, but performance suffers since a lock is acquired every time the instance is requested.
	/// </summary>
	public sealed class SimpleThreadSafeSingleton
	{
		private static SimpleThreadSafeSingleton instance = null;
		private static readonly object padlock = new object();

		private SimpleThreadSafeSingleton()
		{
		}

		public static SimpleThreadSafeSingleton Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new SimpleThreadSafeSingleton();
					}
					return instance;
				}
			}
		}
	}

	/// <summary>
	/// Thread-safe and the extra check helps performance since no lock is acquired if the object has already been created.
	/// It may be necessary to mark the padlock variable as 'volatile'.  Generally more complicated and error-prone. 
	/// </summary>
	public sealed class DoubleCheckLockingSingleton
	{
		private static DoubleCheckLockingSingleton instance = null;
		private static readonly object padlock = new object();

		private DoubleCheckLockingSingleton()
		{
		}

		public static DoubleCheckLockingSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					lock (padlock)
					{
						if (instance == null)
						{
							instance = new DoubleCheckLockingSingleton();
						}
					}
				}
				return instance;
			}
		}
	}

	/// <summary>
	/// Simple, thread-safe, and performant.  The only downside here is it isn't as lazy as other implementations
	/// and if you have one static constructor which invokes another, which invokes the first again, you can have issues. 
	/// </summary>
	public sealed class StaticSingleton
	{
		private static readonly StaticSingleton instance = new StaticSingleton();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static StaticSingleton()
		{
		}

		private StaticSingleton()
		{
		}

		public static StaticSingleton Instance
		{
			get
			{
				return instance;
			}
		}
	}

	/// <summary>
	/// ThreadSafe, simple, and performant (only available in .NET 4+).
	/// </summary>
	public sealed class LazySingleton
	{
		private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());

		public static LazySingleton Instance
		{
			get
			{
				return lazy.Value;
			}
		}

		private LazySingleton()
		{
		}
	}



}

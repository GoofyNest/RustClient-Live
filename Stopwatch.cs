public class Stopwatch // TypeDefIndex: 2657
{	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }


	public static long GetTimestamp() { }

	public static Stopwatch StartNew() { }

	public void .ctor() { }

	public TimeSpan get_Elapsed() { }

	public long get_ElapsedMilliseconds() { }

	public long get_ElapsedTicks() { }

	public void Reset() { }

	public void Start() { }

	public void Stop() { }

	public void Restart() { }

	private static void .cctor() { }

}


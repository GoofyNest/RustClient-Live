public class Stopwatch // TypeDefIndex: 2657
{
	public static readonly long Frequency; 
	public static readonly bool IsHighResolution; 
	private long elapsed; 
	private long started; 
	private bool is_running; 

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


public abstract class TimeZone // TypeDefIndex: 401
{	private static TimeZone currentTimeZone; // 0x0
	private static object tz_lock; // 0x8
	private static long timezone_check; // 0x10

	public static TimeZone CurrentTimeZone { get; }


	protected void .ctor() { }

	public static TimeZone get_CurrentTimeZone() { }

	public abstract TimeSpan GetUtcOffset(DateTime time);

	private static void .cctor() { }

}


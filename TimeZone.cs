public abstract class TimeZone // TypeDefIndex: 401
{
	private static TimeZone currentTimeZone;
	private static object tz_lock;
	private static long timezone_check;

	public static TimeZone CurrentTimeZone { get; }


	protected void .ctor() { }

	public static TimeZone get_CurrentTimeZone() { }

	public abstract TimeSpan GetUtcOffset(DateTime time);

	private static void .cctor() { }

}


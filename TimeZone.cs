public abstract class TimeZone // TypeDefIndex: 401
{	// Fields
	private static TimeZone currentTimeZone; // 0x0
	private static object tz_lock; // 0x8
	private static long timezone_check; // 0x10

	// Properties
	public static TimeZone CurrentTimeZone { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x1615150 Offset: 0x1614550 VA: 0x181615150
	public static TimeZone get_CurrentTimeZone() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TimeSpan GetUtcOffset(DateTime time);

	// RVA: 0x16150F0 Offset: 0x16144F0 VA: 0x1816150F0
	private static void .cctor() { }

}


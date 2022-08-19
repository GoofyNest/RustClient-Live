internal class CurrentSystemTimeZone : TimeZone // TypeDefIndex: 402
{	// Fields
	private readonly TimeZoneInfo LocalTimeZone; // 0x10

	// Methods

	// RVA: 0x178CFB0 Offset: 0x178C3B0 VA: 0x18178CFB0
	internal void .ctor() { }

	// RVA: 0x178CF00 Offset: 0x178C300 VA: 0x18178CF00 Slot: 4
	public override TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x178CEF0 Offset: 0x178C2F0 VA: 0x18178CEF0
	public static bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted) { }

}


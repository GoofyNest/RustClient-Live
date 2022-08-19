public class TaiwanCalendar : Calendar // TypeDefIndex: 717
{	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x1381A60 Offset: 0x1380E60 VA: 0x181381A60
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x1381FE0 Offset: 0x13813E0 VA: 0x181381FE0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x1381F80 Offset: 0x1381380 VA: 0x181381F80 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x1381E50 Offset: 0x1381250 VA: 0x181381E50
	public void .ctor() { }

	// RVA: 0xE32BD0 Offset: 0xE31FD0 VA: 0x180E32BD0 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x137E4D0 Offset: 0x137D8D0 VA: 0x18137E4D0 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x137E490 Offset: 0x137D890 VA: 0x18137E490 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x137E4B0 Offset: 0x137D8B0 VA: 0x18137E4B0 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x137EAD0 Offset: 0x137DED0 VA: 0x18137EAD0 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x137EA90 Offset: 0x137DE90 VA: 0x18137EA90 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x137EAB0 Offset: 0x137DEB0 VA: 0x18137EAB0 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x137EAF0 Offset: 0x137DEF0 VA: 0x18137EAF0 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x137EB10 Offset: 0x137DF10 VA: 0x18137EB10 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x137EB50 Offset: 0x137DF50 VA: 0x18137EB50 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x137EEA0 Offset: 0x137E2A0 VA: 0x18137EEA0 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x137EF80 Offset: 0x137E380 VA: 0x18137EF80 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1381B60 Offset: 0x1380F60 VA: 0x181381B60 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1381CF0 Offset: 0x13810F0 VA: 0x181381CF0
	private static void .cctor() { }

}


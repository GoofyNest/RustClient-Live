public class GregorianCalendar : Calendar // TypeDefIndex: 702
{	// Fields
	internal GregorianCalendarTypes m_type; // 0x20
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }

	// Methods

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16EEC60 Offset: 0x16EE060 VA: 0x1816EEC60
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x16EF340 Offset: 0x16EE740 VA: 0x1816EF340 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x16EF2E0 Offset: 0x16EE6E0 VA: 0x1816EF2E0 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x16EE7E0 Offset: 0x16EDBE0 VA: 0x1816EE7E0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x16EF270 Offset: 0x16EE670 VA: 0x1816EF270
	public void .ctor() { }

	// RVA: 0x16EF140 Offset: 0x16EE540 VA: 0x1816EF140
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x16EE290 Offset: 0x16ED690 VA: 0x1816EE290 Slot: 28
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16EE480 Offset: 0x16ED880 VA: 0x1816EE480 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16EE4C0 Offset: 0x16ED8C0 VA: 0x1816EE4C0 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16EE510 Offset: 0x16ED910 VA: 0x1816EE510 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 14
	public override int GetEra(DateTime time) { }

	// RVA: 0x16EF280 Offset: 0x16EE680 VA: 0x1816EF280 Slot: 15
	public override int[] get_Eras() { }

	// RVA: 0x16EE8E0 Offset: 0x16EDCE0 VA: 0x1816EE8E0 Slot: 16
	public override int GetMonth(DateTime time) { }

	// RVA: 0x16EE920 Offset: 0x16EDD20 VA: 0x1816EE920 Slot: 17
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16EEA80 Offset: 0x16EDE80 VA: 0x1816EEA80 Slot: 18
	public override int GetYear(DateTime time) { }

	// RVA: 0x16EEAC0 Offset: 0x16EDEC0 VA: 0x1816EEAC0 Slot: 20
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x16EED30 Offset: 0x16EE130 VA: 0x1816EED30 Slot: 21
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16EEF80 Offset: 0x16EE380 VA: 0x1816EEF80 Slot: 22
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x16EF3A0 Offset: 0x16EE7A0 VA: 0x1816EF3A0 Slot: 26
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x16EEE20 Offset: 0x16EE220 VA: 0x1816EEE20 Slot: 27
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x16EF090 Offset: 0x16EE490 VA: 0x1816EF090
	private static void .cctor() { }

}


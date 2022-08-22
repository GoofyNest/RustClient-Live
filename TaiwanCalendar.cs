public class TaiwanCalendar : Calendar // TypeDefIndex: 717
{	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }


	internal static Calendar GetDefaultInstance() { }

	public override DateTime get_MinSupportedDateTime() { }

	public override DateTime get_MaxSupportedDateTime() { }

	public void .ctor() { }

	internal override int get_ID() { }

	public override int GetDaysInMonth(int year, int month, int era) { }

	public override int GetDayOfMonth(DateTime time) { }

	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	public override int GetMonthsInYear(int year, int era) { }

	public override int GetEra(DateTime time) { }

	public override int GetMonth(DateTime time) { }

	public override int GetYear(DateTime time) { }

	public override bool IsLeapYear(int year, int era) { }

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	public override int[] get_Eras() { }

	public override int get_TwoDigitYearMax() { }

	public override int ToFourDigitYear(int year) { }

	private static void .cctor() { }

}


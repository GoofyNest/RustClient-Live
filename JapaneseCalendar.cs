public class JapaneseCalendar : Calendar // TypeDefIndex: 712
{
	internal static readonly DateTime calendarMinValue;
	internal static EraInfo[] japaneseEraInfo;
	internal static Calendar s_defaultInstance;
	internal GregorianCalendarHelper helper;

	[ComVisibleAttribute]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }


	public override DateTime get_MinSupportedDateTime() { }

	public override DateTime get_MaxSupportedDateTime() { }

	internal static EraInfo[] GetEraInfo() { }

	private static EraInfo[] GetErasFromRegistry() { }

	internal static Calendar GetDefaultInstance() { }

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

	public override int ToFourDigitYear(int year) { }

	public override int[] get_Eras() { }

	internal static string[] EraNames() { }

	internal static string[] AbbrevEraNames() { }

	internal static string[] EnglishEraNames() { }

	internal override bool IsValidYear(int year, int era) { }

	public override int get_TwoDigitYearMax() { }

	private static void .cctor() { }

}


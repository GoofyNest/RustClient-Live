public class GregorianCalendar : Calendar // TypeDefIndex: 702
{
	internal GregorianCalendarTypes m_type;
	internal static readonly int[] DaysToMonth365;
	internal static readonly int[] DaysToMonth366;
	private static Calendar s_defaultInstance;

	[ComVisibleAttribute]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; }


	[OnDeserializedAttribute]
	private void OnDeserialized(StreamingContext ctx) { }

	public override DateTime get_MinSupportedDateTime() { }

	public override DateTime get_MaxSupportedDateTime() { }

	internal static Calendar GetDefaultInstance() { }

	public void .ctor() { }

	public void .ctor(GregorianCalendarTypes type) { }

	internal override int get_ID() { }

	internal virtual int GetDatePart(long ticks, int part) { }

	public override int GetDayOfMonth(DateTime time) { }

	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	public override int GetDaysInMonth(int year, int month, int era) { }

	public override int GetEra(DateTime time) { }

	public override int[] get_Eras() { }

	public override int GetMonth(DateTime time) { }

	public override int GetMonthsInYear(int year, int era) { }

	public override int GetYear(DateTime time) { }

	public override bool IsLeapYear(int year, int era) { }

	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	public override int get_TwoDigitYearMax() { }

	public override int ToFourDigitYear(int year) { }

	private static void .cctor() { }

}


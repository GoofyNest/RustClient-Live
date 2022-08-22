internal class GregorianCalendarHelper // TypeDefIndex: 704
{	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal int m_maxYear; // 0x10
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal int[] m_eras; // 0x28
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal DateTime m_minDate; // 0x30

	internal int MaxYear { get; }
	public int[] Eras { get; }


	internal int get_MaxYear() { }

	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	internal int GetGregorianYear(int year, int era) { }

	internal bool IsValidYear(int year, int era) { }

	internal virtual int GetDatePart(long ticks, int part) { }

	internal static long GetAbsoluteDate(int year, int month, int day) { }

	internal static long DateToTicks(int year, int month, int day) { }

	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	internal void CheckTicksRange(long ticks) { }

	public int GetDayOfMonth(DateTime time) { }

	public DayOfWeek GetDayOfWeek(DateTime time) { }

	public int GetDaysInMonth(int year, int month, int era) { }

	public int GetEra(DateTime time) { }

	public int[] get_Eras() { }

	public int GetMonth(DateTime time) { }

	public int GetMonthsInYear(int year, int era) { }

	public int GetYear(DateTime time) { }

	public bool IsLeapYear(int year, int era) { }

	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	private static void .cctor() { }

}


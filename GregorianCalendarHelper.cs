internal class GregorianCalendarHelper // TypeDefIndex: 704
{	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
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

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	internal int get_MaxYear() { }

	// RVA: 0x16EE060 Offset: 0x16ED460 VA: 0x1816EE060
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x16ED640 Offset: 0x16ECA40 VA: 0x1816ED640
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x16EDAA0 Offset: 0x16ECEA0 VA: 0x1816EDAA0
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x16ED0D0 Offset: 0x16EC4D0 VA: 0x1816ED0D0 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x16ECEC0 Offset: 0x16EC2C0 VA: 0x1816ECEC0
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x16ECE40 Offset: 0x16EC240 VA: 0x1816ECE40
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x16EDB50 Offset: 0x16ECF50 VA: 0x1816EDB50
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x16ECC80 Offset: 0x16EC080 VA: 0x1816ECC80
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x16ED2F0 Offset: 0x16EC6F0 VA: 0x1816ED2F0
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x16ED330 Offset: 0x16EC730 VA: 0x1816ED330
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x16ED3A0 Offset: 0x16EC7A0 VA: 0x1816ED3A0
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x16ED560 Offset: 0x16EC960 VA: 0x1816ED560
	public int GetEra(DateTime time) { }

	// RVA: 0x16EE140 Offset: 0x16ED540 VA: 0x1816EE140
	public int[] get_Eras() { }

	// RVA: 0x16ED8D0 Offset: 0x16ECCD0 VA: 0x1816ED8D0
	public int GetMonth(DateTime time) { }

	// RVA: 0x16ED910 Offset: 0x16ECD10 VA: 0x1816ED910
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x16ED930 Offset: 0x16ECD30 VA: 0x1816ED930
	public int GetYear(DateTime time) { }

	// RVA: 0x16EDA30 Offset: 0x16ECE30 VA: 0x1816EDA30
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x16EDCF0 Offset: 0x16ED0F0 VA: 0x1816EDCF0
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x16EDFB0 Offset: 0x16ED3B0 VA: 0x1816EDFB0
	private static void .cctor() { }

}


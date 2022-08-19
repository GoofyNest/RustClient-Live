public abstract class Calendar : ICloneable // TypeDefIndex: 687
{	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; }

	// Methods

	// RVA: 0x10CDBB0 Offset: 0x10CCFB0 VA: 0x1810CDBB0 Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x10CDB50 Offset: 0x10CCF50 VA: 0x1810CDB50 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x10CD930 Offset: 0x10CCD30 VA: 0x1810CD930
	protected void .ctor() { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x829900 Offset: 0x828D00 VA: 0x180829900 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x10CD450 Offset: 0x10CC850 VA: 0x1810CD450 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x9EFA00 Offset: 0x9EEE00 VA: 0x1809EFA00
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x10CD950 Offset: 0x10CCD50 VA: 0x1810CD950 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int[] get_Eras();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int GetMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetYear(DateTime time);

	// RVA: 0x10CD570 Offset: 0x10CC970 VA: 0x1810CD570 Slot: 19
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool IsLeapYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x10CD840 Offset: 0x10CCC40 VA: 0x1810CD840 Slot: 22
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x10CD6A0 Offset: 0x10CCAA0 VA: 0x1810CD6A0 Slot: 23
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x10CD620 Offset: 0x10CCA20 VA: 0x1810CD620 Slot: 24
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x10CD590 Offset: 0x10CC990 VA: 0x1810CD590 Slot: 25
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 26
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x10CD730 Offset: 0x10CCB30 VA: 0x1810CD730 Slot: 27
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x10CD520 Offset: 0x10CC920 VA: 0x1810CD520
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }

}


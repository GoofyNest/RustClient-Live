internal class CultureData // TypeDefIndex: 734
{	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal int ILANGUAGE { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x16D3C00 Offset: 0x16D3000 VA: 0x1816D3C00
	private void .ctor(string name) { }

	// RVA: 0x16D3DE0 Offset: 0x16D31E0 VA: 0x1816D3DE0
	public static CultureData get_Invariant() { }

	// RVA: 0x16D3420 Offset: 0x16D2820 VA: 0x1816D3420
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x16D34C0 Offset: 0x16D28C0 VA: 0x1816D34C0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	// RVA: 0x16D3C30 Offset: 0x16D3030 VA: 0x1816D3C30
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x16D32D0 Offset: 0x16D26D0 VA: 0x1816D32D0
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x1363480 Offset: 0x1362880 VA: 0x181363480
	internal string[] get_LongTimes() { }

	// RVA: 0x16D42C0 Offset: 0x16D36C0 VA: 0x1816D42C0
	internal string[] get_ShortTimes() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal string get_SAM1159() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string get_SPM2359() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal string get_TimeSeparator() { }

	// RVA: 0x16D3C50 Offset: 0x16D3050 VA: 0x1816D3C50
	internal int[] get_CalendarIds() { }

	// RVA: 0x16D4280 Offset: 0x16D3680 VA: 0x1816D4280
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal string get_CultureName() { }

	// RVA: 0x16D4290 Offset: 0x16D3690 VA: 0x1816D4290
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal string get_STEXTINFO() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	internal int get_ILANGUAGE() { }

	// RVA: 0xA2DBD0 Offset: 0xA2CFD0 VA: 0x180A2DBD0
	internal bool get_UseUserOverride() { }

	// RVA: 0x16D3290 Offset: 0x16D2690 VA: 0x1816D3290
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x16D3140 Offset: 0x16D2540 VA: 0x1816D3140
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x16D3180 Offset: 0x16D2580 VA: 0x1816D3180
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x16D3A30 Offset: 0x16D2E30 VA: 0x1816D3A30
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x16D39D0 Offset: 0x16D2DD0 VA: 0x1816D39D0
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x16D3BE0 Offset: 0x16D2FE0 VA: 0x1816D3BE0
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x16D3270 Offset: 0x16D2670 VA: 0x1816D3270
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x16D3160 Offset: 0x16D2560 VA: 0x1816D3160
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x16D3A10 Offset: 0x16D2E10 VA: 0x1816D3A10
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x16D32B0 Offset: 0x16D26B0 VA: 0x1816D32B0
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D31D0 Offset: 0x16D25D0 VA: 0x1816D31D0
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x16D31A0 Offset: 0x16D25A0 VA: 0x1816D31A0
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x16D39A0 Offset: 0x16D2DA0 VA: 0x1816D39A0
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x16D39F0 Offset: 0x16D2DF0 VA: 0x1816D39F0
	internal string MonthDay(int calendarId) { }

	// RVA: 0x16D31F0 Offset: 0x16D25F0 VA: 0x1816D31F0
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x16D35D0 Offset: 0x16D29D0 VA: 0x1816D35D0
	private static string GetDateSeparator(string format) { }

	// RVA: 0x16D36A0 Offset: 0x16D2AA0 VA: 0x1816D36A0
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x16D38B0 Offset: 0x16D2CB0 VA: 0x1816D38B0
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x16D3A50 Offset: 0x16D2E50 VA: 0x1816D3A50
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x16D3610 Offset: 0x16D2A10 VA: 0x1816D3610
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x16D3C40 Offset: 0x16D3040 VA: 0x1816D3C40
	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }

}


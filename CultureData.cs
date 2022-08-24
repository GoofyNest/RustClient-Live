internal class CultureData // TypeDefIndex: 734
{
	private string sAM1159; 
	private string sPM2359; 
	private string sTimeSeparator; 
	private string[] saLongTimes; 
	private string[] saShortTimes; 
	private int iFirstDayOfWeek; 
	private int iFirstWeekOfYear; 
	private int[] waCalendars; 
	private CalendarData[] calendars; 
	private string sISO639Language; 
	private readonly string sRealName; 
	private bool bUseOverrides; 
	private int calendarId; 
	private int numberIndex; 
	private int iDefaultAnsiCodePage; 
	private int iDefaultOemCodePage; 
	private int iDefaultMacCodePage; 
	private int iDefaultEbcdicCodePage; 
	private bool isRightToLeft; 
	private string sListSeparator; 
	private static CultureData s_Invariant; 

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


	private void .ctor(string name) { }

	public static CultureData get_Invariant() { }

	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	internal static CultureData GetCultureData(int culture, bool bUseUserOverride) { }

	private void fill_culture_data(int datetimeIndex) { }

	public CalendarData GetCalendar(int calendarId) { }

	internal string[] get_LongTimes() { }

	internal string[] get_ShortTimes() { }

	internal string get_SISO639LANGNAME() { }

	internal int get_IFIRSTDAYOFWEEK() { }

	internal int get_IFIRSTWEEKOFYEAR() { }

	internal string get_SAM1159() { }

	internal string get_SPM2359() { }

	internal string get_TimeSeparator() { }

	internal int[] get_CalendarIds() { }

	internal bool get_IsInvariantCulture() { }

	internal string get_CultureName() { }

	internal string get_SCOMPAREINFO() { }

	internal string get_STEXTINFO() { }

	internal int get_ILANGUAGE() { }

	internal bool get_UseUserOverride() { }

	internal string[] EraNames(int calendarId) { }

	internal string[] AbbrevEraNames(int calendarId) { }

	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	internal string[] ShortDates(int calendarId) { }

	internal string[] LongDates(int calendarId) { }

	internal string[] YearMonths(int calendarId) { }

	internal string[] DayNames(int calendarId) { }

	internal string[] AbbreviatedDayNames(int calendarId) { }

	internal string[] MonthNames(int calendarId) { }

	internal string[] GenitiveMonthNames(int calendarId) { }

	internal string[] AbbreviatedMonthNames(int calendarId) { }

	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	internal string[] LeapYearMonthNames(int calendarId) { }

	internal string MonthDay(int calendarId) { }

	internal string DateSeparator(int calendarId) { }

	private static string GetDateSeparator(string format) { }

	private static string GetSeparator(string format, string timeParts) { }

	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	private static string UnescapeNlsString(string str, int start, int end) { }

	internal static string[] ReescapeWin32Strings(string[] array) { }

	internal static string ReescapeWin32String(string str) { }

	internal void GetNFIValues(NumberFormatInfo nfi) { }

	private static void fill_number_data(NumberFormatInfo nfi, int numberIndex) { }

}


internal class CalendarData // TypeDefIndex: 688
{	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0


	private void .ctor() { }

	private static void .cctor() { }

	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	private void InitializeEraNames(string localeName, int calendarId) { }

	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	internal static CalendarData GetCalendarData(int calendarId) { }

	private static string CalendarIdToCultureName(int calendarId) { }

	public static int nativeGetTwoDigitYearMax(int calID) { }

	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

}


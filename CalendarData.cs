internal class CalendarData // TypeDefIndex: 688
{
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName;
	internal string[] saShortDates;
	internal string[] saYearMonths;
	internal string[] saLongDates;
	internal string sMonthDay;
	internal string[] saEraNames;
	internal string[] saAbbrevEraNames;
	internal string[] saAbbrevEnglishEraNames;
	internal string[] saDayNames;
	internal string[] saAbbrevDayNames;
	internal string[] saSuperShortDayNames;
	internal string[] saMonthNames;
	internal string[] saAbbrevMonthNames;
	internal string[] saMonthGenitiveNames;
	internal string[] saAbbrevMonthGenitiveNames;
	internal string[] saLeapYearMonthNames;
	internal int iTwoDigitYearMax;
	internal int iCurrentEra;
	internal bool bUseUserOverrides;
	internal static CalendarData Invariant;


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


internal class CalendarData // TypeDefIndex: 688
{	// Fields
	internal const int MAX_CALENDARS = 23;
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

	// Methods

	// RVA: 0x10CD3D0 Offset: 0x10CC7D0 VA: 0x1810CD3D0
	private void .ctor() { }

	// RVA: 0x10CB460 Offset: 0x10CA860 VA: 0x1810CB460
	private static void .cctor() { }

	// RVA: 0x10CCC70 Offset: 0x10CC070 VA: 0x1810CCC70
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x10CAC90 Offset: 0x10CA090 VA: 0x1810CAC90
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x10CA7E0 Offset: 0x10C9BE0 VA: 0x1810CA7E0
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x10CA660 Offset: 0x10C9A60 VA: 0x1810CA660
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x10CA540 Offset: 0x10C9940 VA: 0x1810CA540
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x10CD400 Offset: 0x10CC800 VA: 0x1810CD400
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x10CD3F0 Offset: 0x10CC7F0 VA: 0x1810CD3F0
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }

}


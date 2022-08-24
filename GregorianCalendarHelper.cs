internal class GregorianCalendarHelper // TypeDefIndex: 704
{
	internal static readonly int[] DaysToMonth365; 
	internal static readonly int[] DaysToMonth366; 
	[OptionalFieldAttribute] 
	internal int m_maxYear; 
	[OptionalFieldAttribute] 
	internal int m_minYear; 
	internal Calendar m_Cal; 
	[OptionalFieldAttribute] 
	internal EraInfo[] m_EraInfo; 
	[OptionalFieldAttribute] 
	internal int[] m_eras; 
	[OptionalFieldAttribute] 
	internal DateTime m_minDate; 

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


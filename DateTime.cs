public struct DateTime : IComparable, IFormattable, IConvertible, ISerializable, IComparable<DateTime>, IEquatable<DateTime> // TypeDefIndex: 197
{
private const long TicksPerMillisecond = 10000;
private const long TicksPerSecond = 10000000;
private const long TicksPerMinute = 600000000;
private const long TicksPerHour = 36000000000;
private const long TicksPerDay = 864000000000;
private const int MillisPerSecond = 1000;
private const int MillisPerMinute = 60000;
private const int MillisPerHour = 3600000;
private const int MillisPerDay = 86400000;
private const int DaysPerYear = 365;
private const int DaysPer4Years = 1461;
private const int DaysPer100Years = 36524;
private const int DaysPer400Years = 146097;
private const int DaysTo1601 = 584388;
private const int DaysTo1899 = 693593;
internal const int DaysTo1970 = 719162;
private const int DaysTo10000 = 3652059;
internal const long MinTicks = 0;
internal const long MaxTicks = 3155378975999999999;
private const long MaxMillis = 315537897600000;
private const long FileTimeOffset = 504911232000000000;
private const long DoubleDateOffset = 599264352000000000;
private const long OADateMinAsTicks = 31241376000000000;
private const double OADateMinAsDouble = -657435;
private const double OADateMaxAsDouble = 2958466;
private const int DatePartYear = 0;
private const int DatePartDayOfYear = 1;
private const int DatePartMonth = 2;
private const int DatePartDay = 3;
	private static readonly int[] DaysToMonth365; 
	private static readonly int[] DaysToMonth366; 
	public static readonly DateTime MinValue; 
	public static readonly DateTime MaxValue; 
private const ulong TicksMask = 4611686018427387903;
private const ulong FlagsMask = 13835058055282163712;
private const ulong LocalMask = 9223372036854775808;
private const long TicksCeiling = 4611686018427387904;
private const ulong KindUnspecified = 0;
private const ulong KindUtc = 4611686018427387904;
private const ulong KindLocal = 9223372036854775808;
private const ulong KindLocalAmbiguousDst = 13835058055282163712;
private const int KindShift = 62;
private const string TicksField = "ticks";
private const string DateDataField = "dateData";
	private ulong dateData; 

internal long InternalTicks { get; }
private ulong InternalKind { get; }
public DateTime Date { get; }
public int Day { get; }
public DayOfWeek DayOfWeek { get; }
public int Hour { get; }
public DateTimeKind Kind { get; }
public int Millisecond { get; }
public int Minute { get; }
public int Month { get; }
public static DateTime Now { get; }
public static DateTime UtcNow { get; }
public int Second { get; }
public long Ticks { get; }
public TimeSpan TimeOfDay { get; }
public int Year { get; }


public void .ctor(long ticks) { }

private void .ctor(ulong dateData) { }

public void .ctor(long ticks, DateTimeKind kind) { }

internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

public void .ctor(int year, int month, int day) { }

public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

private void .ctor(SerializationInfo info, StreamingContext context) { }

internal long get_InternalTicks() { }

private ulong get_InternalKind() { }

public DateTime Add(TimeSpan value) { }

private DateTime Add(double value, int scale) { }

public DateTime AddDays(double value) { }

public DateTime AddHours(double value) { }

public DateTime AddMilliseconds(double value) { }

public DateTime AddMonths(int months) { }

public DateTime AddSeconds(double value) { }

public DateTime AddTicks(long value) { }

public DateTime AddYears(int value) { }

public static int Compare(DateTime t1, DateTime t2) { }

public int CompareTo(object value) { }

public int CompareTo(DateTime value) { }

private static long DateToTicks(int year, int month, int day) { }

private static long TimeToTicks(int hour, int minute, int second) { }

public static int DaysInMonth(int year, int month) { }

internal static long DoubleDateToTicks(double value) { }

public override bool Equals(object value) { }

public bool Equals(DateTime value) { }

public static DateTime FromBinary(long dateData) { }

internal static DateTime FromBinaryRaw(long dateData) { }

public static DateTime FromFileTime(long fileTime) { }

public static DateTime FromFileTimeUtc(long fileTime) { }

public static DateTime FromOADate(double d) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

public long ToBinary() { }

internal long ToBinaryRaw() { }

public DateTime get_Date() { }

private int GetDatePart(int part) { }

public int get_Day() { }

public DayOfWeek get_DayOfWeek() { }

public override int GetHashCode() { }

public int get_Hour() { }

public DateTimeKind get_Kind() { }

public int get_Millisecond() { }

public int get_Minute() { }

public int get_Month() { }

public static DateTime get_Now() { }

public static DateTime get_UtcNow() { }

internal static long GetSystemTimeAsFileTime() { }

public int get_Second() { }

public long get_Ticks() { }

public TimeSpan get_TimeOfDay() { }

public int get_Year() { }

public static bool IsLeapYear(int year) { }

public static DateTime Parse(string s, IFormatProvider provider) { }

public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

public static DateTime ParseExact(string s, string format, IFormatProvider provider) { }

public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

public TimeSpan Subtract(DateTime value) { }

private static double TicksToOADate(long value) { }

public double ToOADate() { }

public long ToFileTime() { }

public long ToFileTimeUtc() { }

public DateTime ToLocalTime() { }

internal DateTime ToLocalTime(bool throwOnOverflow) { }

public string ToLongTimeString() { }

public string ToShortDateString() { }

public string ToShortTimeString() { }

public override string ToString() { }

public string ToString(string format) { }

public string ToString(IFormatProvider provider) { }

public string ToString(string format, IFormatProvider provider) { }

public DateTime ToUniversalTime() { }

public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

public static DateTime op_Addition(DateTime d, TimeSpan t) { }

public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

public static bool op_Equality(DateTime d1, DateTime d2) { }

public static bool op_Inequality(DateTime d1, DateTime d2) { }

public static bool op_LessThan(DateTime t1, DateTime t2) { }

public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

public TypeCode GetTypeCode() { }

private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

private char System.IConvertible.ToChar(IFormatProvider provider) { }

private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

private byte System.IConvertible.ToByte(IFormatProvider provider) { }

private short System.IConvertible.ToInt16(IFormatProvider provider) { }

private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

private int System.IConvertible.ToInt32(IFormatProvider provider) { }

private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

private long System.IConvertible.ToInt64(IFormatProvider provider) { }

private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

private float System.IConvertible.ToSingle(IFormatProvider provider) { }

private double System.IConvertible.ToDouble(IFormatProvider provider) { }

private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

private static void .cctor() { }

}

public enum DateTimeKind // TypeDefIndex: 198
{
	public int value__; 
public const DateTimeKind Unspecified = 0;
public const DateTimeKind Utc = 1;
public const DateTimeKind Local = 2;

}

public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset> // TypeDefIndex: 199
{
	public static readonly DateTimeOffset MinValue; 
	public static readonly DateTimeOffset MaxValue; 
	private DateTime m_dateTime; 
	private short m_offsetMinutes; 

public static DateTimeOffset Now { get; }
public static DateTimeOffset UtcNow { get; }
public DateTime DateTime { get; }
public DateTime UtcDateTime { get; }
public DateTime LocalDateTime { get; }
private DateTime ClockDateTime { get; }
public int Day { get; }
public int Hour { get; }
public int Minute { get; }
public int Month { get; }
public TimeSpan Offset { get; }
public int Second { get; }
public long Ticks { get; }
public int Year { get; }


public void .ctor(long ticks, TimeSpan offset) { }

public void .ctor(DateTime dateTime) { }

public void .ctor(DateTime dateTime, TimeSpan offset) { }

public static DateTimeOffset get_Now() { }

public static DateTimeOffset get_UtcNow() { }

public DateTime get_DateTime() { }

public DateTime get_UtcDateTime() { }

public DateTime get_LocalDateTime() { }

private DateTime get_ClockDateTime() { }

public int get_Day() { }

public int get_Hour() { }

public int get_Minute() { }

public int get_Month() { }

public TimeSpan get_Offset() { }

public int get_Second() { }

public long get_Ticks() { }

public int get_Year() { }

public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

private int System.IComparable.CompareTo(object obj) { }

public int CompareTo(DateTimeOffset other) { }

public override bool Equals(object obj) { }

public bool Equals(DateTimeOffset other) { }

private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

private void .ctor(SerializationInfo info, StreamingContext context) { }

public override int GetHashCode() { }

public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

public long ToUnixTimeSeconds() { }

public long ToUnixTimeMilliseconds() { }

public override string ToString() { }

public string ToString(IFormatProvider formatProvider) { }

public string ToString(string format, IFormatProvider formatProvider) { }

public DateTimeOffset ToUniversalTime() { }

public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

private static short ValidateOffset(TimeSpan offset) { }

private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

public static DateTimeOffset op_Implicit(DateTime dateTime) { }

public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

private static void .cctor() { }

}

internal static class DateTimeFormat // TypeDefIndex: 225
{
	internal static readonly TimeSpan NullOffset; 
	internal static char[] allStandardFormats; 
	internal static string[] fixedNumberFormats; 


internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

internal static int ParseRepeatPattern(string format, int pos, char patternChar) { }

private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

internal static int ParseQuoteString(string format, int pos, StringBuilder result) { }

internal static int ParseNextChar(string format, int pos) { }

private static bool IsUseGenitiveForm(string format, int index, int tokenLen, char patternToMatch) { }

private static string FormatCustomized(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, string format, int tokenLen, bool timeOnly, StringBuilder result) { }

private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

internal static string GetRealFormat(string format, DateTimeFormatInfo dtfi) { }

private static string ExpandPredefinedFormat(string format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi) { }

internal static string Format(DateTime dateTime, string format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

internal static void InvalidFormatForLocal(string format, DateTime dateTime) { }

internal static void InvalidFormatForUtc(string format, DateTime dateTime) { }

private static void .cctor() { }

}

internal static class DateTimeParse // TypeDefIndex: 226
{
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; 
	private static DateTimeParse.DS[][] dateParsingStates; 


internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

internal static DateTime ParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

internal static bool TryParseExact(string s, string format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

internal static DateTime ParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

internal static bool TryParseExactMultiple(string s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

private static bool MatchWord(ref __DTString str, string target) { }

private static bool GetTimeZoneName(ref __DTString str) { }

internal static bool IsDigit(char ch) { }

private static bool ParseFraction(ref __DTString str, out double result) { }

private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

private static bool VerifyValidPunctuation(ref __DTString str) { }

private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

private static bool GetTimeOfN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

private static bool GetTimeOfNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

private static bool GetTimeOfNNN(DateTimeFormatInfo dtfi, ref DateTimeResult result, ref DateTimeRawInfo raw) { }

private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

internal static bool ProcessTerminaltState(DateTimeParse.DS dps, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

internal static DateTime Parse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

internal static bool TryParse(string s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles) { }

private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

private static bool ParseSign(ref __DTString str, ref bool result) { }

private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

private static string ExpandPredefinedFormat(string format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

internal static bool TryParseQuoteString(string format, int pos, StringBuilder result, out int returnValue) { }

private static bool DoStrictParse(string s, string formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

private static void .cctor() { }

}

internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 227
{

public void .ctor(object object, IntPtr method) { }

public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

public virtual bool EndInvoke(ref __DTString str, out int result, IAsyncResult __result) { }

}

internal enum DateTimeParse.DTT // TypeDefIndex: 228
{
	public int value__; 
public const DateTimeParse.DTT End = 0;
public const DateTimeParse.DTT NumEnd = 1;
public const DateTimeParse.DTT NumAmpm = 2;
public const DateTimeParse.DTT NumSpace = 3;
public const DateTimeParse.DTT NumDatesep = 4;
public const DateTimeParse.DTT NumTimesep = 5;
public const DateTimeParse.DTT MonthEnd = 6;
public const DateTimeParse.DTT MonthSpace = 7;
public const DateTimeParse.DTT MonthDatesep = 8;
public const DateTimeParse.DTT NumDatesuff = 9;
public const DateTimeParse.DTT NumTimesuff = 10;
public const DateTimeParse.DTT DayOfWeek = 11;
public const DateTimeParse.DTT YearSpace = 12;
public const DateTimeParse.DTT YearDateSep = 13;
public const DateTimeParse.DTT YearEnd = 14;
public const DateTimeParse.DTT TimeZone = 15;
public const DateTimeParse.DTT Era = 16;
public const DateTimeParse.DTT NumUTCTimeMark = 17;
public const DateTimeParse.DTT Unk = 18;
public const DateTimeParse.DTT NumLocalTimeMark = 19;
public const DateTimeParse.DTT Max = 20;

}

internal enum DateTimeParse.TM // TypeDefIndex: 229
{
	public int value__; 
public const DateTimeParse.TM NotSet = -1;
public const DateTimeParse.TM AM = 0;
public const DateTimeParse.TM PM = 1;

}

internal enum DateTimeParse.DS // TypeDefIndex: 230
{
	public int value__; 
public const DateTimeParse.DS BEGIN = 0;
public const DateTimeParse.DS N = 1;
public const DateTimeParse.DS NN = 2;
public const DateTimeParse.DS D_Nd = 3;
public const DateTimeParse.DS D_NN = 4;
public const DateTimeParse.DS D_NNd = 5;
public const DateTimeParse.DS D_M = 6;
public const DateTimeParse.DS D_MN = 7;
public const DateTimeParse.DS D_NM = 8;
public const DateTimeParse.DS D_MNd = 9;
public const DateTimeParse.DS D_NDS = 10;
public const DateTimeParse.DS D_Y = 11;
public const DateTimeParse.DS D_YN = 12;
public const DateTimeParse.DS D_YNd = 13;
public const DateTimeParse.DS D_YM = 14;
public const DateTimeParse.DS D_YMd = 15;
public const DateTimeParse.DS D_S = 16;
public const DateTimeParse.DS T_S = 17;
public const DateTimeParse.DS T_Nt = 18;
public const DateTimeParse.DS T_NNt = 19;
public const DateTimeParse.DS ERROR = 20;
public const DateTimeParse.DS DX_NN = 21;
public const DateTimeParse.DS DX_NNN = 22;
public const DateTimeParse.DS DX_MN = 23;
public const DateTimeParse.DS DX_NM = 24;
public const DateTimeParse.DS DX_MNN = 25;
public const DateTimeParse.DS DX_DS = 26;
public const DateTimeParse.DS DX_DSN = 27;
public const DateTimeParse.DS DX_NDS = 28;
public const DateTimeParse.DS DX_NNDS = 29;
public const DateTimeParse.DS DX_YNN = 30;
public const DateTimeParse.DS DX_YMN = 31;
public const DateTimeParse.DS DX_YN = 32;
public const DateTimeParse.DS DX_YM = 33;
public const DateTimeParse.DS TX_N = 34;
public const DateTimeParse.DS TX_NN = 35;
public const DateTimeParse.DS TX_NNN = 36;
public const DateTimeParse.DS TX_TS = 37;
public const DateTimeParse.DS DX_NNY = 38;

}

internal struct DateTimeToken // TypeDefIndex: 234
{
	internal DateTimeParse.DTT dtt; 
	internal TokenType suffix; 
	internal int num; 

}

internal struct DateTimeRawInfo // TypeDefIndex: 235
{
	private int* num; 
	internal int numCount; 
	internal int month; 
	internal int year; 
	internal int dayOfWeek; 
	internal int era; 
	internal DateTimeParse.TM timeMark; 
	internal double fraction; 
	internal bool hasSameDateAndTimeSeparators; 
	internal bool timeZone; 


internal void Init(int* numberBuffer) { }

internal void AddNumber(int value) { }

internal int GetNumber(int index) { }

}

internal struct DateTimeResult // TypeDefIndex: 238
{
	internal int Year; 
	internal int Month; 
	internal int Day; 
	internal int Hour; 
	internal int Minute; 
	internal int Second; 
	internal double fraction; 
	internal int era; 
	internal ParseFlags flags; 
	internal TimeSpan timeZoneOffset; 
	internal Calendar calendar; 
	internal DateTime parsedDate; 
	internal ParseFailureKind failure; 
	internal string failureMessageID; 
	internal object failureMessageFormatArgument; 
	internal string failureArgumentName; 


internal void Init() { }

internal void SetDate(int year, int month, int day) { }

internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }

}

internal enum DateTimeFormatFlags // TypeDefIndex: 694
{
	public int value__; 
public const DateTimeFormatFlags None = 0;
public const DateTimeFormatFlags UseGenitiveMonth = 1;
public const DateTimeFormatFlags UseLeapYearMonth = 2;
public const DateTimeFormatFlags UseSpacesInMonthNames = 4;
public const DateTimeFormatFlags UseHebrewRule = 8;
public const DateTimeFormatFlags UseSpacesInDayNames = 16;
public const DateTimeFormatFlags UseDigitPrefixInTokens = 32;
public const DateTimeFormatFlags NotInitialized = -1;

}

public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 695
{
	private static DateTimeFormatInfo invariantInfo; 
	private CultureData m_cultureData; 
	[OptionalFieldAttribute] 
	internal string m_name; 
	private string m_langName; 
	private CompareInfo m_compareInfo; 
	private CultureInfo m_cultureInfo; 
	internal string amDesignator; 
	internal string pmDesignator; 
	[OptionalFieldAttribute] 
	internal string dateSeparator; 
	[OptionalFieldAttribute] 
	internal string generalShortTimePattern; 
	[OptionalFieldAttribute] 
	internal string generalLongTimePattern; 
	[OptionalFieldAttribute] 
	internal string timeSeparator; 
	internal string monthDayPattern; 
	[OptionalFieldAttribute] 
	internal string dateTimeOffsetPattern; 
internal const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
internal const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
internal const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	internal Calendar calendar; 
	internal int firstDayOfWeek; 
	internal int calendarWeekRule; 
	[OptionalFieldAttribute] 
	internal string fullDateTimePattern; 
	internal string[] abbreviatedDayNames; 
	[OptionalFieldAttribute] 
	internal string[] m_superShortDayNames; 
	internal string[] dayNames; 
	internal string[] abbreviatedMonthNames; 
	internal string[] monthNames; 
	[OptionalFieldAttribute] 
	internal string[] genitiveMonthNames; 
	[OptionalFieldAttribute] 
	internal string[] m_genitiveAbbreviatedMonthNames; 
	[OptionalFieldAttribute] 
	internal string[] leapYearMonthNames; 
	internal string longDatePattern; 
	internal string shortDatePattern; 
	internal string yearMonthPattern; 
	internal string longTimePattern; 
	internal string shortTimePattern; 
	[OptionalFieldAttribute] 
	private string[] allYearMonthPatterns; 
	internal string[] allShortDatePatterns; 
	internal string[] allLongDatePatterns; 
	internal string[] allShortTimePatterns; 
	internal string[] allLongTimePatterns; 
	internal string[] m_eraNames; 
	internal string[] m_abbrevEraNames; 
	internal string[] m_abbrevEnglishEraNames; 
	internal int[] optionalCalendars; 
private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool m_isReadOnly; 
	[OptionalFieldAttribute] 
	internal DateTimeFormatFlags formatFlags; 
	internal static bool preferExistingTokens; 
	[OptionalFieldAttribute] 
	private int CultureID; 
	[OptionalFieldAttribute] 
	private bool m_useUserOverride; 
	[OptionalFieldAttribute] 
	private bool bUseCalendarInfo; 
	[OptionalFieldAttribute] 
	private int nDataItem; 
	[OptionalFieldAttribute] 
	internal bool m_isDefaultCalendar; 
	[OptionalFieldAttribute] 
	private static Hashtable s_calendarNativeNames; 
	[OptionalFieldAttribute] 
	internal string[] m_dateWords; 
	private string m_fullTimeSpanPositivePattern; 
	private string m_fullTimeSpanNegativePattern; 
internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private TokenHashValue[] m_dtfiTokenHash; 
private const int TOKEN_HASH_SIZE = 199;
private const int SECOND_PRIME = 197;
private const string dateSeparatorOrTimeZoneOffset = "-";
private const string invariantDateSeparator = "/";
private const string invariantTimeSeparator = ":";
internal const string IgnorablePeriod = ".";
internal const string IgnorableComma = ",";
internal const string CJKYearSuff = "年";
internal const string CJKMonthSuff = "月";
internal const string CJKDaySuff = "日";
internal const string KoreanYearSuff = "년";
internal const string KoreanMonthSuff = "월";
internal const string KoreanDaySuff = "일";
internal const string KoreanHourSuff = "시";
internal const string KoreanMinuteSuff = "분";
internal const string KoreanSecondSuff = "초";
internal const string CJKHourSuff = "時";
internal const string ChineseHourSuff = "时";
internal const string CJKMinuteSuff = "分";
internal const string CJKSecondSuff = "秒";
internal const string LocalTimeMark = "T";
internal const string KoreanLangName = "ko";
internal const string JapaneseLangName = "ja";
internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; 
	private static DateTimeFormatInfo s_zhtwDTFI; 

private string CultureName { get; }
private CultureInfo Culture { get; }
private string LanguageName { get; }
public static DateTimeFormatInfo InvariantInfo { get; }
public static DateTimeFormatInfo CurrentInfo { get; }
public string AMDesignator { get; }
public Calendar Calendar { get; set; }
private int[] OptionalCalendars { get; }
internal string[] EraNames { get; }
internal string[] AbbreviatedEraNames { get; }
internal string[] AbbreviatedEnglishEraNames { get; }
public string DateSeparator { get; }
public string FullDateTimePattern { get; }
public string LongDatePattern { get; set; }
public string LongTimePattern { get; set; }
public string MonthDayPattern { get; }
public string PMDesignator { get; }
public string RFC1123Pattern { get; }
public string ShortDatePattern { get; set; }
public string ShortTimePattern { get; set; }
public string SortableDateTimePattern { get; }
internal string GeneralShortTimePattern { get; }
internal string GeneralLongTimePattern { get; }
internal string DateTimeOffsetPattern { get; }
public string TimeSeparator { get; }
public string UniversalSortableDateTimePattern { get; }
public string YearMonthPattern { get; set; }
public string[] AbbreviatedDayNames { get; }
public string[] DayNames { get; }
public string[] AbbreviatedMonthNames { get; }
public string[] MonthNames { get; }
internal bool HasSpacesInMonthNames { get; }
internal bool HasSpacesInDayNames { get; }
private string[] AllYearMonthPatterns { get; }
private string[] AllShortDatePatterns { get; }
private string[] AllShortTimePatterns { get; }
private string[] AllLongDatePatterns { get; }
private string[] AllLongTimePatterns { get; }
private string[] UnclonedYearMonthPatterns { get; }
private string[] UnclonedShortDatePatterns { get; }
private string[] UnclonedLongDatePatterns { get; }
private string[] UnclonedShortTimePatterns { get; }
private string[] UnclonedLongTimePatterns { get; }
public bool IsReadOnly { get; }
	[ComVisibleAttribute] 
public string[] MonthGenitiveNames { get; }
internal string FullTimeSpanPositivePattern { get; }
internal string FullTimeSpanNegativePattern { get; }
internal CompareInfo CompareInfo { get; }
internal DateTimeFormatFlags FormatFlags { get; }
internal bool HasForceTwoDigitYears { get; }
internal bool HasYearMonthAdjustment { get; }


private static bool InitPreferExistingTokens() { }

private string get_CultureName() { }

private CultureInfo get_Culture() { }

private string get_LanguageName() { }

private string[] internalGetAbbreviatedDayOfWeekNames() { }

private string[] internalGetDayOfWeekNames() { }

private string[] internalGetAbbreviatedMonthNames() { }

private string[] internalGetMonthNames() { }

public void .ctor() { }

internal void .ctor(CultureData cultureData, Calendar cal) { }

private void InitializeOverridableProperties(CultureData cultureData, int calendarID) { }

	[OnDeserializedAttribute] 
private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] 
private void OnSerializing(StreamingContext ctx) { }

public static DateTimeFormatInfo get_InvariantInfo() { }

public static DateTimeFormatInfo get_CurrentInfo() { }

public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

public object GetFormat(Type formatType) { }

public object Clone() { }

public string get_AMDesignator() { }

public Calendar get_Calendar() { }

public void set_Calendar(Calendar value) { }

private int[] get_OptionalCalendars() { }

internal string[] get_EraNames() { }

public string GetEraName(int era) { }

internal string[] get_AbbreviatedEraNames() { }

public string GetAbbreviatedEraName(int era) { }

internal string[] get_AbbreviatedEnglishEraNames() { }

public string get_DateSeparator() { }

public string get_FullDateTimePattern() { }

public string get_LongDatePattern() { }

public void set_LongDatePattern(string value) { }

public string get_LongTimePattern() { }

public void set_LongTimePattern(string value) { }

public string get_MonthDayPattern() { }

public string get_PMDesignator() { }

public string get_RFC1123Pattern() { }

public string get_ShortDatePattern() { }

public void set_ShortDatePattern(string value) { }

public string get_ShortTimePattern() { }

public void set_ShortTimePattern(string value) { }

public string get_SortableDateTimePattern() { }

internal string get_GeneralShortTimePattern() { }

internal string get_GeneralLongTimePattern() { }

internal string get_DateTimeOffsetPattern() { }

public string get_TimeSeparator() { }

public string get_UniversalSortableDateTimePattern() { }

public string get_YearMonthPattern() { }

public void set_YearMonthPattern(string value) { }

public string[] get_AbbreviatedDayNames() { }

public string[] get_DayNames() { }

public string[] get_AbbreviatedMonthNames() { }

public string[] get_MonthNames() { }

internal bool get_HasSpacesInMonthNames() { }

internal bool get_HasSpacesInDayNames() { }

internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

internal string[] internalGetLeapYearMonthNames() { }

public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

public string[] GetAllDateTimePatterns(char format) { }

public string GetDayName(DayOfWeek dayofweek) { }

public string GetAbbreviatedMonthName(int month) { }

public string GetMonthName(int month) { }

private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

private string[] get_AllYearMonthPatterns() { }

private string[] get_AllShortDatePatterns() { }

private string[] get_AllShortTimePatterns() { }

private string[] get_AllLongDatePatterns() { }

private string[] get_AllLongTimePatterns() { }

private string[] get_UnclonedYearMonthPatterns() { }

private string[] get_UnclonedShortDatePatterns() { }

private string[] get_UnclonedLongDatePatterns() { }

private string[] get_UnclonedShortTimePatterns() { }

private string[] get_UnclonedLongTimePatterns() { }

public bool get_IsReadOnly() { }

public string[] get_MonthGenitiveNames() { }

internal string get_FullTimeSpanPositivePattern() { }

internal string get_FullTimeSpanNegativePattern() { }

internal CompareInfo get_CompareInfo() { }

internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

internal DateTimeFormatFlags get_FormatFlags() { }

internal bool get_HasForceTwoDigitYears() { }

internal bool get_HasYearMonthAdjustment() { }

internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

private void ClearTokenHashTable() { }

internal TokenHashValue[] CreateTokenHashTable() { }

private void AddMonthNames(TokenHashValue[] temp, string monthPostfix) { }

private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

private static bool IsHebrewChar(char ch) { }

internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

private static void .cctor() { }

}

internal class DateTimeFormatInfoScanner // TypeDefIndex: 699
{
	internal List<string> m_dateWords; 
	private static Dictionary<string, string> s_knownWords; 
	private DateTimeFormatInfoScanner.FoundDatePattern m_ymdFlags; 

private static Dictionary<string, string> KnownWords { get; }


private static Dictionary<string, string> get_KnownWords() { }

internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

internal int AddDateWords(string pattern, int index, string formatPostfix) { }

internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

internal void AddIgnorableSymbols(string text) { }

internal void ScanDateWord(string pattern) { }

internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

private static bool EqualStringArrays(string[] array1, string[] array2) { }

private static bool ArrayElementsHaveSpace(string[] array) { }

private static bool ArrayElementsBeginWithDigit(string[] array) { }

public void .ctor() { }

}

private enum DateTimeFormatInfoScanner.FoundDatePattern // TypeDefIndex: 700
{
	public int value__; 
public const DateTimeFormatInfoScanner.FoundDatePattern None = 0;
public const DateTimeFormatInfoScanner.FoundDatePattern FoundYearPatternFlag = 1;
public const DateTimeFormatInfoScanner.FoundDatePattern FoundMonthPatternFlag = 2;
public const DateTimeFormatInfoScanner.FoundDatePattern FoundDayPatternFlag = 4;
public const DateTimeFormatInfoScanner.FoundDatePattern FoundYMDPatternFlag = 7;

}

public enum DateTimeStyles // TypeDefIndex: 701
{
	public int value__; 
public const DateTimeStyles None = 0;
public const DateTimeStyles AllowLeadingWhite = 1;
public const DateTimeStyles AllowTrailingWhite = 2;
public const DateTimeStyles AllowInnerWhite = 4;
public const DateTimeStyles AllowWhiteSpaces = 7;
public const DateTimeStyles NoCurrentDateDefault = 8;
public const DateTimeStyles AdjustToUniversal = 16;
public const DateTimeStyles AssumeLocal = 32;
public const DateTimeStyles AssumeUniversal = 64;
public const DateTimeStyles RoundtripKind = 128;

}

public sealed class DateTimeConstantAttribute : CustomConstantAttribute // TypeDefIndex: 1303
{
	private DateTime date; 

public override object Value { get; }


public override object get_Value() { }

}

internal sealed class DateTimeTypeInfo : TraceLoggingTypeInfo<DateTime> // TypeDefIndex: 1571
{

public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

public override void WriteData(TraceLoggingDataCollector collector, ref DateTime value) { }

public void .ctor() { }

}

internal sealed class DateTimeOffsetTypeInfo : TraceLoggingTypeInfo<DateTimeOffset> // TypeDefIndex: 1572
{

public override void WriteMetadata(TraceLoggingMetadataCollector collector, string name, EventFieldFormat format) { }

public override void WriteData(TraceLoggingDataCollector collector, ref DateTimeOffset value) { }

public void .ctor() { }

}

internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 2251
{

internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

public void .ctor() { }

}

internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 4384
{

internal sealed class DateTimeOffsetStorage : DataStorage 
	private static readonly DateTimeOffset s_defaultValue; 
	private DateTimeOffset[] _values; 


internal void .ctor(DataColumn column) { }

public override object Aggregate(int[] records, AggregateType kind) { }

public override int Compare(int recordNo1, int recordNo2) { }

public override int CompareValueTo(int recordNo, object value) { }

public override object ConvertValue(object value) { }

public override void Copy(int recordNo1, int recordNo2) { }

public override object Get(int record) { }

public override void Set(int record, object value) { }

public override void SetCapacity(int capacity) { }

public override object ConvertXmlToObject(string s) { }

public override string ConvertObjectToXml(object value) { }

protected override object GetEmptyStorage(int recordCount) { }

protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

protected override void SetStorage(object store, BitArray nullbits) { }

private static void .cctor() { }

}

internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 4385
{
	private static readonly DateTime s_defaultValue; 
	private DateTime[] _values; 


internal void .ctor(DataColumn column) { }

public override object Aggregate(int[] records, AggregateType kind) { }

public override int Compare(int recordNo1, int recordNo2) { }

public override int CompareValueTo(int recordNo, object value) { }

public override object ConvertValue(object value) { }

public override void Copy(int recordNo1, int recordNo2) { }

public override object Get(int record) { }

public override void Set(int record, object value) { }

public override void SetCapacity(int capacity) { }

public override object ConvertXmlToObject(string s) { }

public override string ConvertObjectToXml(object value) { }

protected override object GetEmptyStorage(int recordCount) { }

protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

protected override void SetStorage(object store, BitArray nullbits) { }

private static void .cctor() { }

}

public enum DateTimeZoneHandling // TypeDefIndex: 5867
{
	public int value__; 
public const DateTimeZoneHandling Local = 0;
public const DateTimeZoneHandling Utc = 1;
public const DateTimeZoneHandling Unspecified = 2;
public const DateTimeZoneHandling RoundtripKind = 3;

}

internal struct DateTimeParser // TypeDefIndex: 5916
{
	public int Year; 
	public int Month; 
	public int Day; 
	public int Hour; 
	public int Minute; 
	public int Second; 
	public int Fraction; 
	public int ZoneHour; 
	public int ZoneMinute; 
	public ParserTimeZone Zone; 
	private char[] _text; 
	private int _end; 
	private static readonly int[] Power10; 
	private static readonly int Lzyyyy; 
	private static readonly int Lzyyyy_; 
	private static readonly int Lzyyyy_MM; 
	private static readonly int Lzyyyy_MM_; 
	private static readonly int Lzyyyy_MM_dd; 
	private static readonly int Lzyyyy_MM_ddT; 
	private static readonly int LzHH; 
	private static readonly int LzHH_; 
	private static readonly int LzHH_mm; 
	private static readonly int LzHH_mm_; 
	private static readonly int LzHH_mm_ss; 
	private static readonly int Lz_; 
	private static readonly int Lz_zz; 


private static void .cctor() { }

public bool Parse(char[] text, int startIndex, int length) { }

private bool ParseDate(int start) { }

private bool ParseTimeAndZoneAndWhitespace(int start) { }

private bool ParseTime(ref int start) { }

private bool ParseZone(int start) { }

private bool Parse4Digit(int start, out int num) { }

private bool Parse2Digit(int start, out int num) { }

private bool ParseChar(int start, char ch) { }

}

internal static class DateTimeUtils // TypeDefIndex: 5949
{
	internal static readonly long InitialJavaScriptDateTicks; 
	private static readonly int[] DaysToMonth365; 
	private static readonly int[] DaysToMonth366; 


private static void .cctor() { }

	[ExtensionAttribute] 
public static TimeSpan GetUtcOffset(DateTime d) { }

public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

private static DateTime SwitchToLocalTime(DateTime value) { }

private static DateTime SwitchToUtcTime(DateTime value) { }

private static long ToUniversalTicks(DateTime dateTime) { }

private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

private static long UniversialTicksToJavaScriptTicks(long universialTicks) { }

internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }

}

public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 6101
{

public override bool CanConvert(Type objectType) { }

protected void .ctor() { }

}


public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 314
{
	private TimeSpan baseUtcOffset; 
	private string daylightDisplayName; 
	private string displayName; 
	private string id; 
	private static TimeZoneInfo local; 
	private List<KeyValuePair<DateTime, TimeType>> transitions; 
	private static bool readlinkNotFound; 
	private string standardDisplayName; 
	private bool supportsDaylightSavingTime; 
	private static TimeZoneInfo utc; 
	private static string timeZoneDirectory; 
	private TimeZoneInfo.AdjustmentRule[] adjustmentRules; 
	private static RegistryKey timeZoneKey; 
	private static RegistryKey localZoneKey; 
	private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones; 

	public TimeSpan BaseUtcOffset { get; }
	public string DisplayName { get; }
	public string Id { get; }
	public static TimeZoneInfo Local { get; }
	public bool SupportsDaylightSavingTime { get; }
	public static TimeZoneInfo Utc { get; }
	private static string TimeZoneDirectory { get; }
	private static bool IsWindows { get; }
	private static RegistryKey TimeZoneKey { get; }
	private static RegistryKey LocalZoneKey { get; }


	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	private static TimeZoneInfo CreateLocalUnity() { }

	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	internal static extern uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi) { }

	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	public TimeSpan get_BaseUtcOffset() { }

	public string get_DisplayName() { }

	public string get_Id() { }

	public static TimeZoneInfo get_Local() { }

	private static extern int readlink(string path, byte[] buffer, int buflen) { }

	private static string readlink(string path) { }

	private static bool TryGetNameFromPath(string path, out string name) { }

	private static TimeZoneInfo CreateLocal() { }

	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	public bool get_SupportsDaylightSavingTime() { }

	public static TimeZoneInfo get_Utc() { }

	private static string get_TimeZoneDirectory() { }

	private static bool get_IsWindows() { }

	private static string TrimSpecial(string str) { }

	private static RegistryKey get_TimeZoneKey() { }

	private static RegistryKey get_LocalZoneKey() { }

	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	public override bool Equals(object obj) { }

	public bool Equals(TimeZoneInfo other) { }

	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	private static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	public override int GetHashCode() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) { }

	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) { }

	public bool HasSameRules(TimeZoneInfo other) { }

	public bool IsAmbiguousTime(DateTime dateTime) { }

	private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime) { }

	private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year) { }

	public bool IsInvalidTime(DateTime dateTime) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	public override string ToString() { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) { }

	private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year) { }

	private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules) { }

	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	private static bool ValidTZFile(byte[] buffer, int length) { }

	private static int SwapInt32(int i) { }

	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	internal void .ctor() { }

}

public sealed class TimeZoneInfo.AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 315
{
	private DateTime m_dateStart; 
	private DateTime m_dateEnd; 
	private TimeSpan m_daylightDelta; 
	private TimeZoneInfo.TransitionTime m_daylightTransitionStart; 
	private TimeZoneInfo.TransitionTime m_daylightTransitionEnd; 
	private TimeSpan m_baseUtcOffsetDelta; 

	public DateTime DateStart { get; }
	public DateTime DateEnd { get; }
	public TimeSpan DaylightDelta { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionStart { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionEnd { get; }


	public DateTime get_DateStart() { }

	public DateTime get_DateEnd() { }

	public TimeSpan get_DaylightDelta() { }

	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	public override int GetHashCode() { }

	private void .ctor() { }

	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct TimeZoneInfo.TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 316
{
	private DateTime m_timeOfDay; 
	private byte m_month; 
	private byte m_week; 
	private byte m_day; 
	private DayOfWeek m_dayOfWeek; 
	private bool m_isFixedDateRule; 

	public DateTime TimeOfDay { get; }
	public int Month { get; }
	public int Week { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public bool IsFixedDateRule { get; }


	public DateTime get_TimeOfDay() { }

	public int get_Month() { }

	public int get_Week() { }

	public int get_Day() { }

	public DayOfWeek get_DayOfWeek() { }

	public bool get_IsFixedDateRule() { }

	public override bool Equals(object obj) { }

	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	public override int GetHashCode() { }

	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

}

internal struct TimeZoneInfo.SYSTEMTIME // TypeDefIndex: 317
{
	internal ushort wYear; 
	internal ushort wMonth; 
	internal ushort wDayOfWeek; 
	internal ushort wDay; 
	internal ushort wHour; 
	internal ushort wMinute; 
	internal ushort wSecond; 
	internal ushort wMilliseconds; 

}

internal struct TimeZoneInfo.TIME_ZONE_INFORMATION // TypeDefIndex: 318
{
	internal int Bias; 
	internal string StandardName; 
	internal TimeZoneInfo.SYSTEMTIME StandardDate; 
	internal int StandardBias; 
	internal string DaylightName; 
	internal TimeZoneInfo.SYSTEMTIME DaylightDate; 
	internal int DaylightBias; 

}

internal struct TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION // TypeDefIndex: 319
{
	internal TimeZoneInfo.TIME_ZONE_INFORMATION TZI; 
	internal string TimeZoneKeyName; 
	internal byte DynamicDaylightTimeDisabled; 

}

private sealed class TimeZoneInfo.<>c // TypeDefIndex: 320
{
	public static readonly TimeZoneInfo.<>c <>9; 
	public static Comparison<TimeZoneInfo.AdjustmentRule> <>9__19_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CreateLocalUnity>b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2) { }

}


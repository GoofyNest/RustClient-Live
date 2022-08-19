public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback // TypeDefIndex: 314
{	// Fields
	private TimeSpan baseUtcOffset; // 0x10
	private string daylightDisplayName; // 0x18
	private string displayName; // 0x20
	private string id; // 0x28
	private static TimeZoneInfo local; // 0x0
	private List<KeyValuePair<DateTime, TimeType>> transitions; // 0x30
	private static bool readlinkNotFound; // 0x8
	private string standardDisplayName; // 0x38
	private bool supportsDaylightSavingTime; // 0x40
	private static TimeZoneInfo utc; // 0x10
	private static string timeZoneDirectory; // 0x18
	private TimeZoneInfo.AdjustmentRule[] adjustmentRules; // 0x48
	private static RegistryKey timeZoneKey; // 0x20
	private static RegistryKey localZoneKey; // 0x28
	private static ReadOnlyCollection<TimeZoneInfo> systemTimeZones; // 0x30

	// Properties
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

	// Methods

	// RVA: 0x1613A00 Offset: 0x1612E00 VA: 0x181613A00
	internal static bool UtcOffsetOutOfRange(TimeSpan offset) { }

	// RVA: 0x160B9E0 Offset: 0x160ADE0 VA: 0x18160B9E0
	private static List<TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear) { }

	// RVA: 0x160C270 Offset: 0x160B670 VA: 0x18160C270
	private static TimeZoneInfo CreateLocalUnity() { }

	// RVA: 0x160DB30 Offset: 0x160CF30 VA: 0x18160DB30
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation) { }

	// RVA: 0x160ED50 Offset: 0x160E150 VA: 0x18160ED50
	internal static extern uint GetDynamicTimeZoneInformation(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x160EC30 Offset: 0x160E030 VA: 0x18160EC30
	internal static extern uint GetDynamicTimeZoneInformationWin32(out TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation) { }

	// RVA: 0x160EAE0 Offset: 0x160DEE0 VA: 0x18160EAE0
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear) { }

	// RVA: 0x1610160 Offset: 0x160F560 VA: 0x181610160
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out TimeZoneInfo.TIME_ZONE_INFORMATION ptzi) { }

	// RVA: 0x160B450 Offset: 0x160A850 VA: 0x18160B450
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset) { }

	// RVA: 0x16128C0 Offset: 0x1611CC0 VA: 0x1816128C0
	private static bool TransitionTimeFromTimeZoneInformation(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TimeZoneInfo.TransitionTime transitionTime, bool readStartDate) { }

	// RVA: 0x1612D80 Offset: 0x1612180 VA: 0x181612D80
	internal static TimeZoneInfo TryCreateTimeZone(TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation) { }

	// RVA: 0x160EF90 Offset: 0x160E390 VA: 0x18160EF90
	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback() { }

	// RVA: 0x160F190 Offset: 0x160E590 VA: 0x18160F190
	internal static string GetLocalTimeZoneKeyNameWin32Fallback() { }

	// RVA: 0x160DF30 Offset: 0x160D330 VA: 0x18160DF30
	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id) { }

	// RVA: 0x160FDE0 Offset: 0x160F1E0 VA: 0x18160FDE0
	internal static List<TimeZoneInfo> GetSystemTimeZonesWinRTFallback() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public TimeSpan get_BaseUtcOffset() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_DisplayName() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_Id() { }

	// RVA: 0x1614BC0 Offset: 0x1613FC0 VA: 0x181614BC0
	public static TimeZoneInfo get_Local() { }

	// RVA: 0x1615030 Offset: 0x1614430 VA: 0x181615030
	private static extern int readlink(string path, byte[] buffer, int buflen) { }

	// RVA: 0x1614E70 Offset: 0x1614270 VA: 0x181614E70
	private static string readlink(string path) { }

	// RVA: 0x1613450 Offset: 0x1612850 VA: 0x181613450
	private static bool TryGetNameFromPath(string path, out string name) { }

	// RVA: 0x160D580 Offset: 0x160C980 VA: 0x18160D580
	private static TimeZoneInfo CreateLocal() { }

	// RVA: 0x160DE70 Offset: 0x160D270 VA: 0x18160DE70
	private static TimeZoneInfo FindSystemTimeZoneByIdCore(string id) { }

	// RVA: 0x160F3A0 Offset: 0x160E7A0 VA: 0x18160F3A0
	private static void GetSystemTimeZonesCore(List<TimeZoneInfo> systemTimeZones) { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0
	public bool get_SupportsDaylightSavingTime() { }

	// RVA: 0x1614DE0 Offset: 0x16141E0 VA: 0x181614DE0
	public static TimeZoneInfo get_Utc() { }

	// RVA: 0x1614C70 Offset: 0x1614070 VA: 0x181614C70
	private static string get_TimeZoneDirectory() { }

	// RVA: 0x1614A70 Offset: 0x1613E70 VA: 0x181614A70
	private static bool get_IsWindows() { }

	// RVA: 0x1612AC0 Offset: 0x1611EC0 VA: 0x181612AC0
	private static string TrimSpecial(string str) { }

	// RVA: 0x1614CD0 Offset: 0x16140D0 VA: 0x181614CD0
	private static RegistryKey get_TimeZoneKey() { }

	// RVA: 0x1614AB0 Offset: 0x1613EB0 VA: 0x181614AB0
	private static RegistryKey get_LocalZoneKey() { }

	// RVA: 0x1612BF0 Offset: 0x1611FF0 VA: 0x181612BF0
	private static bool TryAddTicks(DateTime date, long ticks, out DateTime result, DateTimeKind kind = 0) { }

	// RVA: 0x160B1E0 Offset: 0x160A5E0 VA: 0x18160B1E0
	public static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x160AE20 Offset: 0x160A220 VA: 0x18160AE20
	private DateTime ConvertTimeFromUtc(DateTime dateTime) { }

	// RVA: 0x160ADA0 Offset: 0x160A1A0 VA: 0x18160ADA0
	public static DateTime ConvertTimeFromUtc(DateTime dateTime, TimeZoneInfo destinationTimeZone) { }

	// RVA: 0x160AFA0 Offset: 0x160A3A0 VA: 0x18160AFA0
	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x160B1D0 Offset: 0x160A5D0 VA: 0x18160B1D0
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone) { }

	// RVA: 0x160AFE0 Offset: 0x160A3E0 VA: 0x18160AFE0
	private static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfoOptions flags) { }

	// RVA: 0x160EA70 Offset: 0x160DE70 VA: 0x18160EA70
	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst) { }

	// RVA: 0x160C240 Offset: 0x160B640 VA: 0x18160C240
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName) { }

	// RVA: 0x160C210 Offset: 0x160B610 VA: 0x18160C210
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x160C150 Offset: 0x160B550 VA: 0x18160C150
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x160DC60 Offset: 0x160D060 VA: 0x18160DC60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x160DCF0 Offset: 0x160D0F0 VA: 0x18160DCF0 Slot: 4
	public bool Equals(TimeZoneInfo other) { }

	// RVA: 0x160E1E0 Offset: 0x160D5E0 VA: 0x18160E1E0
	public static TimeZoneInfo FindSystemTimeZoneById(string id) { }

	// RVA: 0x160DD40 Offset: 0x160D140 VA: 0x18160DD40
	private static TimeZoneInfo FindSystemTimeZoneByFileName(string id, string filepath) { }

	// RVA: 0x160E3F0 Offset: 0x160D7F0 VA: 0x18160E3F0
	private static TimeZoneInfo FromRegistryKey(string id, RegistryKey key) { }

	// RVA: 0x16112A0 Offset: 0x16106A0 VA: 0x1816112A0
	private static void ParseRegTzi(List<TimeZoneInfo.AdjustmentRule> adjustmentRules, int start_year, int end_year, byte[] buffer) { }

	// RVA: 0x160E820 Offset: 0x160DC20 VA: 0x18160E820
	public TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules() { }

	// RVA: 0x160EE70 Offset: 0x160E270 VA: 0x18160EE70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1612600 Offset: 0x1611A00 VA: 0x181612600 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1610090 Offset: 0x160F490 VA: 0x181610090
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones() { }

	// RVA: 0x1610780 Offset: 0x160FB80 VA: 0x181610780
	public TimeSpan GetUtcOffset(DateTime dateTime) { }

	// RVA: 0x16106A0 Offset: 0x160FAA0 VA: 0x1816106A0
	private TimeSpan GetUtcOffset(DateTime dateTime, out bool isDST) { }

	// RVA: 0x16103F0 Offset: 0x160F7F0 VA: 0x1816103F0
	private static TimeSpan GetUtcOffsetHelper(DateTime dateTime, TimeZoneInfo tz, out bool isDST) { }

	// RVA: 0x16107A0 Offset: 0x160FBA0 VA: 0x1816107A0
	public bool HasSameRules(TimeZoneInfo other) { }

	// RVA: 0x1610AC0 Offset: 0x160FEC0 VA: 0x181610AC0
	public bool IsAmbiguousTime(DateTime dateTime) { }

	// RVA: 0x1610EC0 Offset: 0x16102C0 VA: 0x181610EC0
	private bool IsInDST(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime) { }

	// RVA: 0x1610CE0 Offset: 0x16100E0 VA: 0x181610CE0
	private bool IsInDSTForYear(TimeZoneInfo.AdjustmentRule rule, DateTime dateTime, int year) { }

	// RVA: 0x1610F80 Offset: 0x1610380 VA: 0x181610F80
	public bool IsInvalidTime(DateTime dateTime) { }

	// RVA: 0x1612570 Offset: 0x1611970 VA: 0x181612570 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1613C50 Offset: 0x1613050 VA: 0x181613C50
	private static void Validate(string id, TimeSpan baseUtcOffset, TimeZoneInfo.AdjustmentRule[] adjustmentRules) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1614150 Offset: 0x1613550 VA: 0x181614150
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1614490 Offset: 0x1613890 VA: 0x181614490
	private void .ctor(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime) { }

	// RVA: 0x160E8B0 Offset: 0x160DCB0 VA: 0x18160E8B0
	private TimeZoneInfo.AdjustmentRule GetApplicableRule(DateTime dateTime) { }

	// RVA: 0x1613750 Offset: 0x1612B50 VA: 0x181613750
	private bool TryGetTransitionOffset(DateTime dateTime, out TimeSpan offset, out bool isDst) { }

	// RVA: 0x1612730 Offset: 0x1611B30 VA: 0x181612730
	private static DateTime TransitionPoint(TimeZoneInfo.TransitionTime transition, int year) { }

	// RVA: 0x1613B10 Offset: 0x1612F10 VA: 0x181613B10
	private static TimeZoneInfo.AdjustmentRule[] ValidateRules(List<TimeZoneInfo.AdjustmentRule> adjustmentRules) { }

	// RVA: 0x160ABC0 Offset: 0x1609FC0 VA: 0x18160ABC0
	private static TimeZoneInfo BuildFromStream(string id, Stream stream) { }

	// RVA: 0x1613A30 Offset: 0x1612E30 VA: 0x181613A30
	private static bool ValidTZFile(byte[] buffer, int length) { }

	// RVA: 0x1612540 Offset: 0x1611940 VA: 0x181612540
	private static int SwapInt32(int i) { }

	// RVA: 0x16124A0 Offset: 0x16118A0 VA: 0x1816124A0
	private static int ReadBigEndianInt32(byte[] buffer, int start) { }

	// RVA: 0x1611640 Offset: 0x1610A40 VA: 0x181611640
	private static TimeZoneInfo ParseTZBuffer(string id, byte[] buffer, int length) { }

	// RVA: 0x16110F0 Offset: 0x16104F0 VA: 0x1816110F0
	private static Dictionary<int, string> ParseAbbreviations(byte[] buffer, int index, int count) { }

	// RVA: 0x1612090 Offset: 0x1611490 VA: 0x181612090
	private static Dictionary<int, TimeType> ParseTimesTypes(byte[] buffer, int index, int count, Dictionary<int, string> abbreviations) { }

	// RVA: 0x1612290 Offset: 0x1611690 VA: 0x181612290
	private static List<KeyValuePair<DateTime, TimeType>> ParseTransitions(byte[] buffer, int index, int count, Dictionary<int, TimeType> time_types) { }

	// RVA: 0x160DAE0 Offset: 0x160CEE0 VA: 0x18160DAE0
	private static DateTime DateTimeFromUnixTime(long unix_time) { }

	// RVA: 0x160F360 Offset: 0x160E760 VA: 0x18160F360
	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1610780 Offset: 0x160FB80 VA: 0x181610780
	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags) { }

	// RVA: 0x1610380 Offset: 0x160F780 VA: 0x181610380
	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst) { }

	// RVA: 0x1614A40 Offset: 0x1613E40 VA: 0x181614A40
	internal void .ctor() { }

}

public sealed class TimeZoneInfo.AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 315
{	// Fields
	private DateTime m_dateStart; // 0x10
	private DateTime m_dateEnd; // 0x18
	private TimeSpan m_daylightDelta; // 0x20
	private TimeZoneInfo.TransitionTime m_daylightTransitionStart; // 0x28
	private TimeZoneInfo.TransitionTime m_daylightTransitionEnd; // 0x40
	private TimeSpan m_baseUtcOffsetDelta; // 0x58

	// Properties
	public DateTime DateStart { get; }
	public DateTime DateEnd { get; }
	public TimeSpan DaylightDelta { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionStart { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionEnd { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public DateTime get_DateStart() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public DateTime get_DateEnd() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public TimeSpan get_DaylightDelta() { }

	// RVA: 0x1600820 Offset: 0x15FFC20 VA: 0x181600820
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x1600800 Offset: 0x15FFC00 VA: 0x181600800
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x15FFD20 Offset: 0x15FF120 VA: 0x1815FFD20 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x15FFEA0 Offset: 0x15FF2A0 VA: 0x1815FFEA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x15FFB60 Offset: 0x15FEF60 VA: 0x1815FFB60
	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x15FFCB0 Offset: 0x15FF0B0 VA: 0x1815FFCB0
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta) { }

	// RVA: 0x1600100 Offset: 0x15FF500 VA: 0x181600100
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x15FFEB0 Offset: 0x15FF2B0 VA: 0x1815FFEB0 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x15FFF90 Offset: 0x15FF390 VA: 0x1815FFF90 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1600520 Offset: 0x15FF920 VA: 0x181600520
	private void .ctor(SerializationInfo info, StreamingContext context) { }

}

public struct TimeZoneInfo.TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 316
{	// Fields
	private DateTime m_timeOfDay; // 0x0
	private byte m_month; // 0x8
	private byte m_week; // 0x9
	private byte m_day; // 0xA
	private DayOfWeek m_dayOfWeek; // 0xC
	private bool m_isFixedDateRule; // 0x10

	// Properties
	public DateTime TimeOfDay { get; }
	public int Month { get; }
	public int Week { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public bool IsFixedDateRule { get; }

	// Methods

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public DateTime get_TimeOfDay() { }

	// RVA: 0x14B660 Offset: 0x14AA60 VA: 0x18014B660
	public int get_Month() { }

	// RVA: 0x1AE180 Offset: 0x1AD580 VA: 0x1801AE180
	public int get_Week() { }

	// RVA: 0x1AE120 Offset: 0x1AD520 VA: 0x1801AE120
	public int get_Day() { }

	// RVA: 0x1AE2C0 Offset: 0x1AD6C0 VA: 0x1801AE2C0
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x10A9E0 Offset: 0x109DE0 VA: 0x18010A9E0
	public bool get_IsFixedDateRule() { }

	// RVA: 0x1F6050 Offset: 0x1F5450 VA: 0x1801F6050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x16164F0 Offset: 0x16158F0 VA: 0x1816164F0
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x1F6020 Offset: 0x1F5420 VA: 0x1801F6020 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x1F60F0 Offset: 0x1F54F0 VA: 0x1801F60F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1615BC0 Offset: 0x1614FC0 VA: 0x181615BC0
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x1615C60 Offset: 0x1615060 VA: 0x181615C60
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x1615D10 Offset: 0x1615110 VA: 0x181615D10
	private static TimeZoneInfo.TransitionTime CreateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x1615FA0 Offset: 0x16153A0 VA: 0x181615FA0
	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	// RVA: 0x1F6100 Offset: 0x1F5500 VA: 0x1801F6100 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1F6110 Offset: 0x1F5510 VA: 0x1801F6110 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1F6230 Offset: 0x1F5630 VA: 0x1801F6230
	private void .ctor(SerializationInfo info, StreamingContext context) { }

}

internal struct TimeZoneInfo.SYSTEMTIME // TypeDefIndex: 317
{	// Fields
	internal ushort wYear; // 0x0
	internal ushort wMonth; // 0x2
	internal ushort wDayOfWeek; // 0x4
	internal ushort wDay; // 0x6
	internal ushort wHour; // 0x8
	internal ushort wMinute; // 0xA
	internal ushort wSecond; // 0xC
	internal ushort wMilliseconds; // 0xE

}

internal struct TimeZoneInfo.TIME_ZONE_INFORMATION // TypeDefIndex: 318
{	// Fields
	internal int Bias; // 0x0
	internal string StandardName; // 0x8
	internal TimeZoneInfo.SYSTEMTIME StandardDate; // 0x10
	internal int StandardBias; // 0x20
	internal string DaylightName; // 0x28
	internal TimeZoneInfo.SYSTEMTIME DaylightDate; // 0x30
	internal int DaylightBias; // 0x40

}

internal struct TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION // TypeDefIndex: 319
{	// Fields
	internal TimeZoneInfo.TIME_ZONE_INFORMATION TZI; // 0x0
	internal string TimeZoneKeyName; // 0x48
	internal byte DynamicDaylightTimeDisabled; // 0x50

}

private sealed class TimeZoneInfo.<>c // TypeDefIndex: 320
{	// Fields
	public static readonly TimeZoneInfo.<>c <>9; // 0x0
	public static Comparison<TimeZoneInfo.AdjustmentRule> <>9__19_0; // 0x8

	// Methods

	// RVA: 0x1616B50 Offset: 0x1615F50 VA: 0x181616B50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1616520 Offset: 0x1615920 VA: 0x181616520
	internal int <CreateLocalUnity>b__19_0(TimeZoneInfo.AdjustmentRule rule1, TimeZoneInfo.AdjustmentRule rule2) { }

}


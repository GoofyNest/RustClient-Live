public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 741
{	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	internal static readonly bool IsTaiwanSku; // 0x38

	// Properties
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	public bool IsReadOnly { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }
	internal bool HasInvariantCultureName { get; }

	// Methods

	// RVA: 0x16D88E0 Offset: 0x16D7CE0 VA: 0x1816D88E0
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x16D8530 Offset: 0x16D7930 VA: 0x1816D8530
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x16D8560 Offset: 0x16D7960 VA: 0x1816D8560
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x16D4710 Offset: 0x16D3B10 VA: 0x1816D4710
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x16D48A0 Offset: 0x16D3CA0 VA: 0x1816D48A0
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	internal string get_Territory() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230 Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x16D8320 Offset: 0x16D7720 VA: 0x1816D8320 Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x16D8A40 Offset: 0x16D7E40 VA: 0x1816D8A40 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x16D8C80 Offset: 0x16D8080 VA: 0x1816D8C80 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x16D4480 Offset: 0x16D3880 VA: 0x1816D4480 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x16D6C10 Offset: 0x16D6010 VA: 0x1816D6C10 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16D7120 Offset: 0x16D6520 VA: 0x1816D7120
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x16D7600 Offset: 0x16D6A00 VA: 0x1816D7600
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x16D75F0 Offset: 0x16D69F0 VA: 0x1816D75F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x16D83C0 Offset: 0x16D77C0 VA: 0x1816D83C0 Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x16D8950 Offset: 0x16D7D50 VA: 0x1816D8950 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void CheckNeutral() { }

	// RVA: 0x16D8990 Offset: 0x16D7D90 VA: 0x1816D8990 Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x16D9150 Offset: 0x16D8550 VA: 0x1816D9150 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x16D8590 Offset: 0x16D7990 VA: 0x1816D8590 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x16D9070 Offset: 0x16D8470 VA: 0x1816D9070 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x16D87B0 Offset: 0x16D7BB0 VA: 0x1816D87B0 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsReadOnly() { }

	// RVA: 0x16D74E0 Offset: 0x16D68E0 VA: 0x1816D74E0 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x16D4A70 Offset: 0x16D3E70 VA: 0x1816D4A70
	private void Construct() { }

	// RVA: 0x16D8260 Offset: 0x16D7660 VA: 0x1816D8260
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x16D8270 Offset: 0x16D7670 VA: 0x1816D8270
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x16D8ED0 Offset: 0x16D82D0 VA: 0x1816D8ED0
	private static string get_current_locale_name() { }

	// RVA: 0x16D9060 Offset: 0x16D8460 VA: 0x1816D9060
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x16D48F0 Offset: 0x16D3CF0 VA: 0x1816D48F0
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x16D6B90 Offset: 0x16D5F90 VA: 0x1816D6B90
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x16D7C80 Offset: 0x16D7080 VA: 0x1816D7C80
	public void .ctor(int culture) { }

	// RVA: 0x16D7C60 Offset: 0x16D7060 VA: 0x1816D7C60
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x16D7CA0 Offset: 0x16D70A0 VA: 0x1816D7CA0
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x16D7FB0 Offset: 0x16D73B0 VA: 0x1816D7FB0
	public void .ctor(string name) { }

	// RVA: 0x16D7F70 Offset: 0x16D7370 VA: 0x1816D7F70
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x16D7FD0 Offset: 0x16D73D0 VA: 0x1816D7FD0
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x16D7F90 Offset: 0x16D7390 VA: 0x1816D7F90
	private void .ctor() { }

	// RVA: 0x16D8EE0 Offset: 0x16D82E0 VA: 0x1816D8EE0
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x16D6CB0 Offset: 0x16D60B0 VA: 0x1816D6CB0
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x16D6EF0 Offset: 0x16D62F0 VA: 0x1816D6EF0
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x16D4C50 Offset: 0x16D4050 VA: 0x1816D4C50
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x16D6860 Offset: 0x16D5C60 VA: 0x1816D6860
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x16D4D60 Offset: 0x16D4160 VA: 0x1816D4D60
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x16D8280 Offset: 0x16D7680 VA: 0x1816D8280
	internal int get_CalendarType() { }

	// RVA: 0x16D4A90 Offset: 0x16D3E90 VA: 0x1816D4A90
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x16D4CE0 Offset: 0x16D40E0 VA: 0x1816D4CE0
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x16D86D0 Offset: 0x16D7AD0 VA: 0x1816D86D0
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x16D8740 Offset: 0x16D7B40 VA: 0x1816D8740
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal string get_SortName() { }

	// RVA: 0x16D8E40 Offset: 0x16D8240 VA: 0x1816D8E40
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x16D8DF0 Offset: 0x16D81F0 VA: 0x1816D8DF0
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x16D42E0 Offset: 0x16D36E0 VA: 0x1816D42E0
	internal static void CheckDomainSafetyObject(object obj, object container) { }

	// RVA: 0x16D87F0 Offset: 0x16D7BF0 VA: 0x1816D87F0
	internal bool get_HasInvariantCultureName() { }

	// RVA: 0x16D7620 Offset: 0x16D6A20 VA: 0x1816D7620
	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	// RVA: 0x16D7750 Offset: 0x16D6B50 VA: 0x1816D7750
	internal static bool VerifyCultureName(CultureInfo culture, bool throwException) { }

	// RVA: 0x16D7900 Offset: 0x16D6D00 VA: 0x1816D7900
	private static void .cctor() { }

}

private struct CultureInfo.Data // TypeDefIndex: 742
{	// Fields
	public int ansi; // 0x0
	public int ebcdic; // 0x4
	public int mac; // 0x8
	public int oem; // 0xC
	public bool right_to_left; // 0x10
	public byte list_sep; // 0x11

}


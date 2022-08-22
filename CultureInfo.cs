public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 741
{	private static CultureInfo invariant_culture_info; // 0x0
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


	public static CultureInfo get_InvariantCulture() { }

	public static CultureInfo get_CurrentCulture() { }

	public static CultureInfo get_CurrentUICulture() { }

	internal static CultureInfo ConstructCurrentCulture() { }

	internal static CultureInfo ConstructCurrentUICulture() { }

	internal string get_Territory() { }

	public virtual int get_LCID() { }

	public virtual string get_Name() { }

	public virtual Calendar get_Calendar() { }

	public virtual CultureInfo get_Parent() { }

	public virtual TextInfo get_TextInfo() { }

	public virtual object Clone() { }

	public override bool Equals(object value) { }

	public static CultureInfo[] GetCultures(CultureTypes types) { }

	private CultureInfo.Data GetTextInfoData() { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public virtual CompareInfo get_CompareInfo() { }

	public virtual bool get_IsNeutralCulture() { }

	private void CheckNeutral() { }

	public virtual NumberFormatInfo get_NumberFormat() { }

	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	public virtual string get_EnglishName() { }

	public bool get_IsReadOnly() { }

	public virtual object GetFormat(Type formatType) { }

	private void Construct() { }

	private bool construct_internal_locale_from_lcid(int lcid) { }

	private bool construct_internal_locale_from_name(string name) { }

	private static string get_current_locale_name() { }

	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	private void ConstructInvariant(bool read_only) { }

	private TextInfo CreateTextInfo(bool readOnly) { }

	public void .ctor(int culture) { }

	public void .ctor(int culture, bool useUserOverride) { }

	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	public void .ctor(string name) { }

	public void .ctor(string name, bool useUserOverride) { }

	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	private void .ctor() { }

	private static void insert_into_shared_tables(CultureInfo c) { }

	public static CultureInfo GetCultureInfo(int culture) { }

	public static CultureInfo GetCultureInfo(string name) { }

	internal static CultureInfo CreateCulture(string name, bool reference) { }

	public static CultureInfo CreateSpecificCulture(string name) { }

	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	internal int get_CalendarType() { }

	private static Calendar CreateCalendar(int calendarType) { }

	private static Exception CreateNotFoundException(string name) { }

	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	internal string get_SortName() { }

	internal static CultureInfo get_UserDefaultUICulture() { }

	internal static CultureInfo get_UserDefaultCulture() { }

	internal static void CheckDomainSafetyObject(object obj, object container) { }

	internal bool get_HasInvariantCultureName() { }

	internal static bool VerifyCultureName(string cultureName, bool throwException) { }

	internal static bool VerifyCultureName(CultureInfo culture, bool throwException) { }

	private static void .cctor() { }

}

private struct CultureInfo.Data // TypeDefIndex: 742
{	public int ansi; // 0x0
	public int ebcdic; // 0x4
	public int mac; // 0x8
	public int oem; // 0xC
	public bool right_to_left; // 0x10
	public byte list_sep; // 0x11

}


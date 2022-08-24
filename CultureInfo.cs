public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 741
{
	private static CultureInfo invariant_culture_info; 
	private static object shared_table_lock; 
	private static CultureInfo default_current_culture; 
	private bool m_isReadOnly; 
	private int cultureID; 
	private int parent_lcid; 
	private int datetime_index; 
	private int number_index; 
	private int default_calendar_type; 
	private bool m_useUserOverride; 
	internal NumberFormatInfo numInfo; 
	internal DateTimeFormatInfo dateTimeInfo; 
	private TextInfo textInfo; 
	internal string m_name; 
	private string englishname; 
	private string nativename; 
	private string iso3lang; 
	private string iso2lang; 
	private string win3lang; 
	private string territory; 
	private string[] native_calendar_names; 
	private CompareInfo compareInfo; 
	private readonly void* textinfo_data; 
	private int m_dataItem; 
	private Calendar calendar; 
	private CultureInfo parent_culture; 
	private bool constructed; 
	internal byte[] cached_serialized_form; 
	internal CultureData m_cultureData; 
	internal bool m_isInherited; 
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; 
	private static CultureInfo s_DefaultThreadCurrentCulture; 
	private static Dictionary<int, CultureInfo> shared_by_number; 
	private static Dictionary<string, CultureInfo> shared_by_name; 
	internal static readonly bool IsTaiwanSku; 

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
{
	public int ansi; 
	public int ebcdic; 
	public int mac; 
	public int oem; 
	public bool right_to_left; 
	public byte list_sep; 

}


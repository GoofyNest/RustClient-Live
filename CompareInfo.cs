public class CompareInfo : IDeserializationCallback // TypeDefIndex: 690
{	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_name; // 0x10
	private string m_sortName; // 0x18
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	private int win32LCID; // 0x20
	private int culture; // 0x24
	private const int LINGUISTIC_IGNORECASE = 16;
	private const int NORM_IGNORECASE = 1;
	private const int NORM_IGNOREKANATYPE = 65536;
	private const int LINGUISTIC_IGNOREDIACRITIC = 32;
	private const int NORM_IGNORENONSPACE = 2;
	private const int NORM_IGNORESYMBOLS = 4;
	private const int NORM_IGNOREWIDTH = 131072;
	private const int SORT_STRINGSORT = 4096;
	private const int COMPARE_OPTIONS_ORDINAL = 1073741824;
	internal const int NORM_LINGUISTIC_CASING = 134217728;
	private const int RESERVED_FIND_ASCII_STRING = 536870912;
	private const int SORT_VERSION_WHIDBEY = 4096;
	private const int SORT_VERSION_V4 = 393473;
	[OptionalFieldAttribute] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	private SortVersion m_SortVersion; // 0x28
	private SimpleCollator collator; // 0x30
	private static Dictionary<string, SimpleCollator> collators; // 0x0
	private static bool managedCollation; // 0x8
	private static bool managedCollationChecked; // 0x9

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }


	internal void .ctor(CultureInfo culture) { }

	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserializing(StreamingContext ctx) { }

	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnSerializing(StreamingContext ctx) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	public virtual string get_Name() { }

	public virtual int Compare(string string1, string string2) { }

	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	private SortKey CreateSortKey(string source, CompareOptions options) { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy) { }

	public override string ToString() { }

	private static bool get_UseManagedCollation() { }

	private SimpleCollator GetCollator() { }

	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	private void assign_sortkey(object key, string source, CompareOptions options) { }

	private int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	private int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first) { }

	internal void .ctor() { }

}


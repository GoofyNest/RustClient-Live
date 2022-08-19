public class CompareInfo : IDeserializationCallback // TypeDefIndex: 690
{	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
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

	// Properties
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x16D2BE0 Offset: 0x16D1FE0 VA: 0x1816D2BE0
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x16D1D10 Offset: 0x16D1110 VA: 0x1816D1D10
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE31A20 Offset: 0xE30E20 VA: 0x180E31A20
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x16D2A10 Offset: 0x16D1E10 VA: 0x1816D2A10
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16D2AE0 Offset: 0x16D1EE0 VA: 0x1816D2AE0
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x16D2AF0 Offset: 0x16D1EF0 VA: 0x1816D2AF0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x16D2AE0 Offset: 0x16D1EE0 VA: 0x1816D2AE0 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x16D2C70 Offset: 0x16D2070 VA: 0x1816D2C70 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x16D1230 Offset: 0x16D0630 VA: 0x1816D1230 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x16D1260 Offset: 0x16D0660 VA: 0x1816D1260 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x16D13D0 Offset: 0x16D07D0 VA: 0x1816D13D0 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D11D0 Offset: 0x16D05D0 VA: 0x1816D11D0
	private static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x16D23F0 Offset: 0x16D17F0 VA: 0x1816D23F0 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x16D25C0 Offset: 0x16D19C0 VA: 0x1816D25C0 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x16D20B0 Offset: 0x16D14B0 VA: 0x1816D20B0 Slot: 11
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x16D2170 Offset: 0x16D1570 VA: 0x1816D2170 Slot: 12
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D2790 Offset: 0x16D1B90 VA: 0x1816D2790 Slot: 13
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x16D1F20 Offset: 0x16D1320 VA: 0x1816D1F20 Slot: 14
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D1820 Offset: 0x16D0C20 VA: 0x1816D1820
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x16D19B0 Offset: 0x16D0DB0 VA: 0x1816D19B0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x16D1EE0 Offset: 0x16D12E0 VA: 0x1816D1EE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16D1DC0 Offset: 0x16D11C0 VA: 0x1816D1DC0
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x16D1DC0 Offset: 0x16D11C0 VA: 0x1816D1DC0
	internal int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x16D2B90 Offset: 0x16D1F90 VA: 0x1816D2B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x16D2CE0 Offset: 0x16D20E0 VA: 0x1816D2CE0
	private static bool get_UseManagedCollation() { }

	// RVA: 0x16D1A80 Offset: 0x16D0E80 VA: 0x1816D1A80
	private SimpleCollator GetCollator() { }

	// RVA: 0x16D1740 Offset: 0x16D0B40 VA: 0x1816D1740
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x16D3000 Offset: 0x16D2400 VA: 0x1816D3000
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D2E70 Offset: 0x16D2270 VA: 0x1816D2E70
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D2E10 Offset: 0x16D2210 VA: 0x1816D2E10
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D2F60 Offset: 0x16D2360 VA: 0x1816D2F60
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x16D2C60 Offset: 0x16D2060 VA: 0x1816D2C60
	private void assign_sortkey(object key, string source, CompareOptions options) { }

	// RVA: 0x16D2E00 Offset: 0x16D2200 VA: 0x1816D2E00
	private int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x16D2F50 Offset: 0x16D2350 VA: 0x1816D2F50
	private int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first) { }

	// RVA: 0x16D2C30 Offset: 0x16D2030 VA: 0x1816D2C30
	internal void .ctor() { }

}


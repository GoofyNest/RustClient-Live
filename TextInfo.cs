public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 719
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string m_listSeparator; // 0x10
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private bool m_isReadOnly; // 0x18
	[OptionalFieldAttribute] // RVA: 0xA9A10 Offset: 0xA8E10 VA: 0x1800A9A10
	private string m_cultureName; // 0x20
	private CultureData m_cultureData; // 0x28
	private string m_textInfoName; // 0x30
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x38
	internal static TextInfo s_Invariant; // 0x0
	[OptionalFieldAttribute] // RVA: 0x92E60 Offset: 0x92260 VA: 0x180092E60
	private string customCultureName; // 0x40
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal int m_nDataItem; // 0x48
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal bool m_useUserOverride; // 0x4C
	[OptionalFieldAttribute] // RVA: 0x96440 Offset: 0x95840 VA: 0x180096440
	internal int m_win32LangID; // 0x50
	private const int wordSeparatorMask = 536672256;

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x1384A20 Offset: 0x1383E20 VA: 0x181384A20
	internal static TextInfo get_Invariant() { }

	// RVA: 0x1384970 Offset: 0x1383D70 VA: 0x181384970
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13835A0 Offset: 0x13829A0 VA: 0x1813835A0
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1383460 Offset: 0x1382860 VA: 0x181383460
	private void OnDeserialized() { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1383590 Offset: 0x1382990 VA: 0x181383590
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13835E0 Offset: 0x13829E0 VA: 0x1813835E0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1382EB0 Offset: 0x13822B0 VA: 0x181382EB0
	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	// RVA: 0x1382D70 Offset: 0x1382170 VA: 0x181382D70
	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1382AA0 Offset: 0x1381EA0 VA: 0x181382AA0
	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	// RVA: 0x1382A90 Offset: 0x1381E90 VA: 0x181382A90
	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	// RVA: 0x1383100 Offset: 0x1382500 VA: 0x181383100
	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x13833A0 Offset: 0x13827A0 VA: 0x1813833A0
	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_CultureName() { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x13829C0 Offset: 0x1381DC0 VA: 0x1813829C0 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x1383DE0 Offset: 0x13831E0 VA: 0x181383DE0 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x1383E40 Offset: 0x1383240 VA: 0x181383E40 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x1383680 Offset: 0x1382A80 VA: 0x181383680
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x1384910 Offset: 0x1383D10 VA: 0x181384910 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x13847E0 Offset: 0x1383BE0 VA: 0x1813847E0 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x1383FC0 Offset: 0x13833C0 VA: 0x181383FC0
	private static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x1383390 Offset: 0x1382790 VA: 0x181383390
	private static bool IsAscii(char c) { }

	// RVA: 0x1384B20 Offset: 0x1383F20 VA: 0x181384B20
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x1382AE0 Offset: 0x1381EE0 VA: 0x181382AE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xE66350 Offset: 0xE65750 VA: 0x180E66350 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1383F70 Offset: 0x1383370 VA: 0x181383F70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1383590 Offset: 0x1382990 VA: 0x181383590 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1382D50 Offset: 0x1382150 VA: 0x181382D50
	internal int GetCaseInsensitiveHashCode(string str) { }

	// RVA: 0x1382B80 Offset: 0x1381F80 VA: 0x181382B80
	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	// RVA: 0x1382FE0 Offset: 0x13823E0 VA: 0x181382FE0
	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	// RVA: 0x13846F0 Offset: 0x1383AF0 VA: 0x1813846F0
	private string ToUpperInternal(string str) { }

	// RVA: 0x13836A0 Offset: 0x1382AA0 VA: 0x1813836A0
	private string ToLowerInternal(string str) { }

	// RVA: 0x1383FE0 Offset: 0x13833E0 VA: 0x181383FE0
	private char ToUpperInternal(char c) { }

	// RVA: 0x1383790 Offset: 0x1382B90 VA: 0x181383790
	private char ToLowerInternal(char c) { }

	// RVA: 0x13831D0 Offset: 0x13825D0 VA: 0x1813831D0
	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	// RVA: 0x13849F0 Offset: 0x1383DF0 VA: 0x1813849F0
	internal void .ctor() { }

}


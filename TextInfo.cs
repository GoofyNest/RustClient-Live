public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 719
{
	[OptionalFieldAttribute]
	private string m_listSeparator;
	[OptionalFieldAttribute]
	private bool m_isReadOnly;
	[OptionalFieldAttribute]
	private string m_cultureName;
	private CultureData m_cultureData;
	private string m_textInfoName;
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant;
	internal static TextInfo s_Invariant;
	[OptionalFieldAttribute]
	private string customCultureName;
	[OptionalFieldAttribute]
	internal int m_nDataItem;
	[OptionalFieldAttribute]
	internal bool m_useUserOverride;
	[OptionalFieldAttribute]
	internal int m_win32LangID;
	private const int wordSeparatorMask = 536672256;

	internal static TextInfo Invariant { get; }
	[ComVisibleAttribute]
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }


	internal static TextInfo get_Invariant() { }

	internal void .ctor(CultureData cultureData) { }

	[OnDeserializingAttribute]
	private void OnDeserializing(StreamingContext ctx) { }

	private void OnDeserialized() { }

	[OnDeserializedAttribute]
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializingAttribute]
	private void OnSerializing(StreamingContext ctx) { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	public string get_CultureName() { }

	[ComVisibleAttribute]
	public virtual object Clone() { }

	internal void SetReadOnlyState(bool readOnly) { }

	public virtual char ToLower(char c) { }

	public virtual string ToLower(string str) { }

	private static char ToLowerAsciiInvariant(char c) { }

	public virtual char ToUpper(char c) { }

	public virtual string ToUpper(string str) { }

	private static char ToUpperAsciiInvariant(char c) { }

	private static bool IsAscii(char c) { }

	private bool get_IsAsciiCasingSameAsInvariant() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	internal int GetCaseInsensitiveHashCode(string str) { }

	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	private string ToUpperInternal(string str) { }

	private string ToLowerInternal(string str) { }

	private char ToUpperInternal(char c) { }

	private char ToLowerInternal(char c) { }

	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	internal void .ctor() { }

}


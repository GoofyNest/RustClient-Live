public static class JsonUtility // TypeDefIndex: 4525
{

[NativeHeaderAttribute] 
public static class JsonUtility

	[ThreadSafeAttribute] 
	[FreeFunctionAttribute] 
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type) { }

	public static T FromJson<T>(string json) { }
	/* GenericInstMethod :
	|
	|-JsonUtility.FromJson<RandomUsernames.DataFile>
	|-JsonUtility.FromJson<object>
	*/

	public static object FromJson(string json, Type type) { }

}

internal enum JSONNodeType // TypeDefIndex: 5638
{
	public int value__; 
	public const JSONNodeType Array = 1;
	public const JSONNodeType Object = 2;
	public const JSONNodeType String = 3;
	public const JSONNodeType Number = 4;
	public const JSONNodeType NullValue = 5;
	public const JSONNodeType Boolean = 6;
	public const JSONNodeType None = 7;
	public const JSONNodeType Custom = 255;

}

internal enum JSONTextMode // TypeDefIndex: 5639
{
	public int value__; 
	public const JSONTextMode Compact = 0;
	public const JSONTextMode Indent = 1;

}

internal abstract class JSONNode // TypeDefIndex: 5640
{
	public static bool forceASCII; 
	public static bool longAsString; 
	[ThreadStaticAttribute] 
	private static StringBuilder m_EscapeBuilder; 

	public virtual JSONNode Item { get; }
	public virtual JSONNode Item { get; set; }
	public virtual string Value { get; }
	public virtual int Count { get; }
	public virtual bool IsNumber { get; }
	public virtual bool IsBoolean { get; }
	public virtual bool IsArray { get; }
	public virtual IEnumerable<JSONNode> Children { get; }
	public virtual double AsDouble { get; }
	public virtual int AsInt { get; }
	public virtual bool AsBool { get; }
	public virtual long AsLong { get; }
	public virtual JSONArray AsArray { get; }
	public virtual JSONObject AsObject { get; }
	internal static StringBuilder EscapeBuilder { get; }


	public virtual JSONNode get_Item(int aIndex) { }

	public virtual JSONNode get_Item(string aKey) { }

	public virtual void set_Item(string aKey, JSONNode value) { }

	public virtual string get_Value() { }

	public virtual int get_Count() { }

	public virtual bool get_IsNumber() { }

	public virtual bool get_IsBoolean() { }

	public virtual bool get_IsArray() { }

	public virtual void Add(string aKey, JSONNode aItem) { }

	public virtual void Add(JSONNode aItem) { }

	[IteratorStateMachineAttribute] 
	public virtual IEnumerable<JSONNode> get_Children() { }

	public override string ToString() { }

	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

	public abstract JSONNode.Enumerator GetEnumerator();

	public virtual double get_AsDouble() { }

	public virtual int get_AsInt() { }

	public virtual bool get_AsBool() { }

	public virtual long get_AsLong() { }

	public virtual JSONArray get_AsArray() { }

	public virtual JSONObject get_AsObject() { }

	public static JSONNode op_Implicit(string s) { }

	public static string op_Implicit(JSONNode d) { }

	public static JSONNode op_Implicit(double n) { }

	public static JSONNode op_Implicit(bool b) { }

	public static bool op_Equality(JSONNode a, object b) { }

	public static bool op_Inequality(JSONNode a, object b) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal static StringBuilder get_EscapeBuilder() { }

	internal static string Escape(string aText) { }

	private static JSONNode ParseElement(string token, bool quoted) { }

	public static JSONNode Parse(string aJSON) { }

	public abstract void SerializeBinary(BinaryWriter aWriter);

	public void SaveToBinaryStream(Stream aData) { }

	public string SaveToBinaryBase64() { }

	public static JSONNode DeserializeBinary(BinaryReader aReader) { }

	public static JSONNode LoadFromBinaryStream(Stream aData) { }

	public static JSONNode LoadFromBinaryBase64(string aBase64) { }

	protected void .ctor() { }

}

public struct JSONNode.Enumerator // TypeDefIndex: 5641
{
	private JSONNode.Enumerator.Type type; 
	private Dictionary.Enumerator<string, JSONNode> m_Object; 
	private List.Enumerator<JSONNode> m_Array; 

	public KeyValuePair<string, JSONNode> Current { get; }


	public void .ctor(List.Enumerator<JSONNode> aArrayEnum) { }

	public void .ctor(Dictionary.Enumerator<string, JSONNode> aDictEnum) { }

	public KeyValuePair<string, JSONNode> get_Current() { }

	public bool MoveNext() { }

}

private enum JSONNode.Enumerator.Type // TypeDefIndex: 5642
{
	public int value__; 
	public const JSONNode.Enumerator.Type None = 0;
	public const JSONNode.Enumerator.Type Array = 1;
	public const JSONNode.Enumerator.Type Object = 2;

}

private sealed class JSONNode.<get_Children>d__40 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5643
{
	private int <>1__state; 
	private JSONNode <>2__current; 
	private int <>l__initialThreadId; 

	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONArray : JSONNode // TypeDefIndex: 5644
{
	private List<JSONNode> m_List; 
	private bool inline; 

	public override bool IsArray { get; }
	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }


	public override bool get_IsArray() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override JSONNode get_Item(int aIndex) { }

	public override JSONNode get_Item(string aKey) { }

	public override void set_Item(string aKey, JSONNode value) { }

	public override int get_Count() { }

	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] 
	public override IEnumerable<JSONNode> get_Children() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

	public void .ctor() { }

}

private sealed class JSONArray.<get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5645
{
	private int <>1__state; 
	private JSONNode <>2__current; 
	private int <>l__initialThreadId; 
	public JSONArray <>4__this; 
	private List.Enumerator<JSONNode> <>7__wrap1; 

	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONObject : JSONNode // TypeDefIndex: 5646
{
	private Dictionary<string, JSONNode> m_Dict; 
	private bool inline; 

	public override JSONNode Item { get; set; }
	public override JSONNode Item { get; }
	public override int Count { get; }
	public override IEnumerable<JSONNode> Children { get; }


	public override JSONNode.Enumerator GetEnumerator() { }

	public override JSONNode get_Item(string aKey) { }

	public override void set_Item(string aKey, JSONNode value) { }

	public override JSONNode get_Item(int aIndex) { }

	public override int get_Count() { }

	public override void Add(string aKey, JSONNode aItem) { }

	[IteratorStateMachineAttribute] 
	public override IEnumerable<JSONNode> get_Children() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

	public void .ctor() { }

}

private sealed class JSONObject.<get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IDisposable, IEnumerator // TypeDefIndex: 5647
{
	private int <>1__state; 
	private JSONNode <>2__current; 
	private int <>l__initialThreadId; 
	public JSONObject <>4__this; 
	private Dictionary.Enumerator<string, JSONNode> <>7__wrap1; 

	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private JSONNode System.Collections.Generic.IEnumerator<GameAnalyticsSDK.Net.Utilities.JSONNode>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<GameAnalyticsSDK.Net.Utilities.JSONNode>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

internal class JSONString : JSONNode // TypeDefIndex: 5648
{
	private string m_Data; 

	public override string Value { get; }


	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public void .ctor(string aData) { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNumber : JSONNode // TypeDefIndex: 5649
{
	private double m_Data; 

	public override bool IsNumber { get; }
	public override string Value { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }


	public override bool get_IsNumber() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public override double get_AsDouble() { }

	public override long get_AsLong() { }

	public void .ctor(double aData) { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	private static bool IsNumeric(object value) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONBool : JSONNode // TypeDefIndex: 5650
{
	private bool m_Data; 

	public override bool IsBoolean { get; }
	public override string Value { get; }
	public override bool AsBool { get; }


	public override bool get_IsBoolean() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public override bool get_AsBool() { }

	public void .ctor(bool aData) { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal class JSONNull : JSONNode // TypeDefIndex: 5651
{
	private static JSONNull m_StaticInstance; 
	public static bool reuseSameInstance; 

	public override string Value { get; }
	public override bool AsBool { get; }


	public static JSONNull CreateOrGet() { }

	private void .ctor() { }

	public override JSONNode.Enumerator GetEnumerator() { }

	public override string get_Value() { }

	public override bool get_AsBool() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

	private static void .cctor() { }

}

internal class JSONLazyCreator : JSONNode // TypeDefIndex: 5652
{
	private JSONNode m_Node; 
	private string m_Key; 

	public override JSONNode Item { get; }
	public override JSONNode Item { get; set; }
	public override int AsInt { get; }
	public override double AsDouble { get; }
	public override long AsLong { get; }
	public override bool AsBool { get; }
	public override JSONArray AsArray { get; }
	public override JSONObject AsObject { get; }


	public override JSONNode.Enumerator GetEnumerator() { }

	public void .ctor(JSONNode aNode) { }

	public void .ctor(JSONNode aNode, string aKey) { }

	private T Set<T>(T aVal) { }
	/* GenericInstMethod :
	|
	|-JSONLazyCreator.Set<JSONArray>
	|-JSONLazyCreator.Set<JSONBool>
	|-JSONLazyCreator.Set<JSONNumber>
	|-JSONLazyCreator.Set<JSONObject>
	|-JSONLazyCreator.Set<JSONString>
	|-JSONLazyCreator.Set<object>
	*/

	public override JSONNode get_Item(int aIndex) { }

	public override JSONNode get_Item(string aKey) { }

	public override void set_Item(string aKey, JSONNode value) { }

	public override void Add(JSONNode aItem) { }

	public override void Add(string aKey, JSONNode aItem) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override int get_AsInt() { }

	public override double get_AsDouble() { }

	public override long get_AsLong() { }

	public override bool get_AsBool() { }

	public override JSONArray get_AsArray() { }

	public override JSONObject get_AsObject() { }

	internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	public override void SerializeBinary(BinaryWriter aWriter) { }

}

internal static class JSON // TypeDefIndex: 5653
{

	public static JSONNode Parse(string aJSON) { }

}

public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 5873
{

	public void .ctor() { }

}

public class JsonException : Exception // TypeDefIndex: 5875
{

	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 5876
{
	[CompilerGeneratedAttribute] 
	private bool <WriteData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <ReadData>k__BackingField; 

	public bool WriteData { get; set; }
	public bool ReadData { get; set; }


	[CompilerGeneratedAttribute] 
	public bool get_WriteData() { }

	[CompilerGeneratedAttribute] 
	public void set_WriteData(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_ReadData() { }

	[CompilerGeneratedAttribute] 
	public void set_ReadData(bool value) { }

	public void .ctor() { }

}

internal enum JsonContainerType // TypeDefIndex: 5877
{
	public int value__; 
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;

}

internal struct JsonPosition // TypeDefIndex: 5878
{
	private static readonly char[] SpecialCharacters; 
	internal JsonContainerType Type; 
	internal int Position; 
	internal string PropertyName; 
	internal bool HasIndex; 


	public void .ctor(JsonContainerType type) { }

	internal int CalculateLength() { }

	internal void WriteTo(StringBuilder sb) { }

	internal static bool TypeHasIndex(JsonContainerType type) { }

	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	private static void .cctor() { }

}

public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 5879
{

	public void .ctor() { }

}

public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 5885
{

	public void .ctor() { }

}

public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 5886
{
	[CompilerGeneratedAttribute] 
	private Type <ItemConverterType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object[] <ItemConverterParameters>k__BackingField; 
	internal Nullable<bool> _isReference; 
	internal Nullable<bool> _itemIsReference; 
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; 
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; 

	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }


	[CompilerGeneratedAttribute] 
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] 
	public object[] get_ItemConverterParameters() { }

	protected void .ctor() { }

}

public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 5888
{
	private readonly Type _converterType; 
	[CompilerGeneratedAttribute] 
	private object[] <ConverterParameters>k__BackingField; 

	public Type ConverterType { get; }
	public object[] ConverterParameters { get; }


	public Type get_ConverterType() { }

	[CompilerGeneratedAttribute] 
	public object[] get_ConverterParameters() { }

	public void .ctor(Type converterType) { }

}

public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 5889
{
	private MemberSerialization _memberSerialization; 
	internal Nullable<Required> _itemRequired; 

	public MemberSerialization MemberSerialization { get; }


	public MemberSerialization get_MemberSerialization() { }

	public void .ctor() { }

}

public class JsonSerializerSettings // TypeDefIndex: 5890
{
	internal static readonly StreamingContext DefaultContext; 
	internal static readonly CultureInfo DefaultCulture; 
	internal Nullable<Formatting> _formatting; 
	internal Nullable<DateFormatHandling> _dateFormatHandling; 
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; 
	internal Nullable<DateParseHandling> _dateParseHandling; 
	internal Nullable<FloatFormatHandling> _floatFormatHandling; 
	internal Nullable<FloatParseHandling> _floatParseHandling; 
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; 
	internal CultureInfo _culture; 
	internal Nullable<bool> _checkAdditionalContent; 
	internal Nullable<int> _maxDepth; 
	internal bool _maxDepthSet; 
	internal string _dateFormatString; 
	internal bool _dateFormatStringSet; 
	internal Nullable<FormatterAssemblyStyle> _typeNameAssemblyFormat; 
	internal Nullable<DefaultValueHandling> _defaultValueHandling; 
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; 
	internal Nullable<NullValueHandling> _nullValueHandling; 
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; 
	internal Nullable<MissingMemberHandling> _missingMemberHandling; 
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; 
	internal Nullable<StreamingContext> _context; 
	internal Nullable<ConstructorHandling> _constructorHandling; 
	internal Nullable<TypeNameHandling> _typeNameHandling; 
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; 
	[CompilerGeneratedAttribute] 
	private IList<JsonConverter> <Converters>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IContractResolver <ContractResolver>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IEqualityComparer <EqualityComparer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ITraceWriter <TraceWriter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private SerializationBinder <Binder>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; 

	public ReferenceLoopHandling ReferenceLoopHandling { get; }
	public MissingMemberHandling MissingMemberHandling { get; }
	public ObjectCreationHandling ObjectCreationHandling { get; }
	public NullValueHandling NullValueHandling { get; }
	public DefaultValueHandling DefaultValueHandling { get; }
	public IList<JsonConverter> Converters { get; set; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; }
	public TypeNameHandling TypeNameHandling { get; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; }
	public FormatterAssemblyStyle TypeNameAssemblyFormat { get; }
	public ConstructorHandling ConstructorHandling { get; }
	public IContractResolver ContractResolver { get; }
	public IEqualityComparer EqualityComparer { get; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; }
	public ITraceWriter TraceWriter { get; }
	public SerializationBinder Binder { get; }
	public EventHandler<ErrorEventArgs> Error { get; }
	public StreamingContext Context { get; }


	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	public MissingMemberHandling get_MissingMemberHandling() { }

	public ObjectCreationHandling get_ObjectCreationHandling() { }

	public NullValueHandling get_NullValueHandling() { }

	public DefaultValueHandling get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] 
	public IList<JsonConverter> get_Converters() { }

	[CompilerGeneratedAttribute] 
	public void set_Converters(IList<JsonConverter> value) { }

	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	public TypeNameHandling get_TypeNameHandling() { }

	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public FormatterAssemblyStyle get_TypeNameAssemblyFormat() { }

	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGeneratedAttribute] 
	public IContractResolver get_ContractResolver() { }

	[CompilerGeneratedAttribute] 
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGeneratedAttribute] 
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGeneratedAttribute] 
	public ITraceWriter get_TraceWriter() { }

	[CompilerGeneratedAttribute] 
	public SerializationBinder get_Binder() { }

	[CompilerGeneratedAttribute] 
	public EventHandler<ErrorEventArgs> get_Error() { }

	public StreamingContext get_Context() { }

	private static void .cctor() { }

	public void .ctor() { }

}

private sealed class JsonSerializerSettings.<>c__DisplayClass90_0 // TypeDefIndex: 5891
{

	public void .ctor() { }

}

public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5895
{
	private readonly TextReader _reader; 
	private char[] _chars; 
	private int _charsUsed; 
	private int _charPos; 
	private int _lineStartPos; 
	private int _lineNumber; 
	private bool _isEndOfFile; 
	private StringBuffer _stringBuffer; 
	private StringReference _stringReference; 
	private IArrayPool<char> _arrayPool; 
	internal PropertyNameTable NameTable; 

	public int LineNumber { get; }
	public int LinePosition { get; }


	public void .ctor(TextReader reader) { }

	private void EnsureBufferNotEmpty() { }

	private void OnNewLine(int pos) { }

	private void ParseString(char quote, ReadType readType) { }

	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	private void ShiftBufferIfNeeded() { }

	private int ReadData(bool append) { }

	private int ReadData(bool append, int charsRequired) { }

	private bool EnsureChars(int relativePosition, bool append) { }

	private bool ReadChars(int relativePosition, bool append) { }

	public override bool Read() { }

	public override Nullable<int> ReadAsInt32() { }

	public override Nullable<DateTime> ReadAsDateTime() { }

	public override string ReadAsString() { }

	public override byte[] ReadAsBytes() { }

	private object ReadStringValue(ReadType readType) { }

	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	public override Nullable<bool> ReadAsBoolean() { }

	private void ProcessValueComma() { }

	private object ReadNumberValue(ReadType readType) { }

	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public override Nullable<Decimal> ReadAsDecimal() { }

	public override Nullable<double> ReadAsDouble() { }

	private void HandleNull() { }

	private void ReadFinished() { }

	private bool ReadNullChar() { }

	private void EnsureBuffer() { }

	private void ReadStringIntoBuffer(char quote) { }

	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	private char ParseUnicode() { }

	private void ReadNumberIntoBuffer() { }

	private void ClearRecentString() { }

	private bool ParsePostValue() { }

	private bool ParseObject() { }

	private bool ParseProperty() { }

	private bool ValidIdentifierChar(char value) { }

	private void ParseUnquotedProperty() { }

	private bool ParseValue() { }

	private void ProcessLineFeed() { }

	private void ProcessCarriageReturn(bool append) { }

	private bool EatWhitespace(bool oneOrMore) { }

	private void ParseConstructor() { }

	private void ParseNumber(ReadType readType) { }

	private void ParseComment(bool setToken) { }

	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	private bool MatchValue(string value) { }

	private bool MatchValueWithTrailingSeparator(string value) { }

	private bool IsSeparator(char c) { }

	private void ParseTrue() { }

	private void ParseNull() { }

	private void ParseUndefined() { }

	private void ParseFalse() { }

	private object ParseNumberNegativeInfinity(ReadType readType) { }

	private object ParseNumberPositiveInfinity(ReadType readType) { }

	private object ParseNumberNaN(ReadType readType) { }

	public override void Close() { }

	public bool HasLineInfo() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

}

public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 5896
{
	internal Nullable<NullValueHandling> _nullValueHandling; 
	internal Nullable<DefaultValueHandling> _defaultValueHandling; 
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; 
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; 
	internal Nullable<TypeNameHandling> _typeNameHandling; 
	internal Nullable<bool> _isReference; 
	internal Nullable<int> _order; 
	internal Nullable<Required> _required; 
	internal Nullable<bool> _itemIsReference; 
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; 
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; 
	[CompilerGeneratedAttribute] 
	private Type <ItemConverterType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object[] <ItemConverterParameters>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <PropertyName>k__BackingField; 

	public Type ItemConverterType { get; }
	public object[] ItemConverterParameters { get; }
	public string PropertyName { get; set; }


	[CompilerGeneratedAttribute] 
	public Type get_ItemConverterType() { }

	[CompilerGeneratedAttribute] 
	public object[] get_ItemConverterParameters() { }

	[CompilerGeneratedAttribute] 
	public string get_PropertyName() { }

	[CompilerGeneratedAttribute] 
	public void set_PropertyName(string value) { }

	public void .ctor() { }

	public void .ctor(string propertyName) { }

}

public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 5897
{

	public void .ctor() { }

}

public class JsonTextWriter : JsonWriter // TypeDefIndex: 5898
{
	private readonly TextWriter _writer; 
	private Base64Encoder _base64Encoder; 
	private char _indentChar; 
	private int _indentation; 
	private char _quoteChar; 
	private bool _quoteName; 
	private bool[] _charEscapeFlags; 
	private char[] _writeBuffer; 
	private IArrayPool<char> _arrayPool; 
	private char[] _indentChars; 

	private Base64Encoder Base64Encoder { get; }
	public char QuoteChar { get; }


	private Base64Encoder get_Base64Encoder() { }

	public char get_QuoteChar() { }

	public void .ctor(TextWriter textWriter) { }

	public override void Close() { }

	public override void WriteStartObject() { }

	public override void WriteStartArray() { }

	public override void WriteStartConstructor(string name) { }

	protected override void WriteEnd(JsonToken token) { }

	public override void WritePropertyName(string name) { }

	public override void WritePropertyName(string name, bool escape) { }

	internal override void OnStringEscapeHandlingChanged() { }

	private void UpdateCharEscapeFlags() { }

	protected override void WriteIndent() { }

	protected override void WriteValueDelimiter() { }

	protected override void WriteIndentSpace() { }

	private void WriteValueInternal(string value, JsonToken token) { }

	public override void WriteValue(object value) { }

	public override void WriteNull() { }

	public override void WriteUndefined() { }

	public override void WriteRaw(string json) { }

	public override void WriteValue(string value) { }

	private void WriteEscapedString(string value, bool quote) { }

	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(uint value) { }

	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(ulong value) { }

	public override void WriteValue(float value) { }

	public override void WriteValue(Nullable<float> value) { }

	public override void WriteValue(double value) { }

	public override void WriteValue(Nullable<double> value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(ushort value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(sbyte value) { }

	public override void WriteValue(Decimal value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(byte[] value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(Uri value) { }

	public override void WriteComment(string text) { }

	private void EnsureWriteBuffer() { }

	private void WriteIntegerValue(long value) { }

	private void WriteIntegerValue(ulong uvalue) { }

}

public class JsonWriterException : JsonException // TypeDefIndex: 5899
{
	[CompilerGeneratedAttribute] 
	private string <Path>k__BackingField; 

	private string Path { set; }


	[CompilerGeneratedAttribute] 
	private void set_Path(string value) { }

	public void .ctor() { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(string message, Exception innerException, string path) { }

	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	internal static JsonWriterException Create(string path, string message, Exception ex) { }

}

public class JsonReaderException : JsonException // TypeDefIndex: 5900
{
	[CompilerGeneratedAttribute] 
	private int <LineNumber>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <LinePosition>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Path>k__BackingField; 

	private int LineNumber { set; }
	private int LinePosition { set; }
	private string Path { set; }


	[CompilerGeneratedAttribute] 
	private void set_LineNumber(int value) { }

	[CompilerGeneratedAttribute] 
	private void set_LinePosition(int value) { }

	[CompilerGeneratedAttribute] 
	private void set_Path(string value) { }

	public void .ctor() { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	internal void .ctor(string message, Exception innerException, string path, int lineNumber, int linePosition) { }

	internal static JsonReaderException Create(JsonReader reader, string message) { }

	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public abstract class JsonConverter // TypeDefIndex: 5901
{
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }


	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	public abstract bool CanConvert(Type objectType);

	public virtual bool get_CanRead() { }

	public virtual bool get_CanWrite() { }

	protected void .ctor() { }

}

public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 5902
{

	public void .ctor() { }

}

public abstract class JsonReader : IDisposable // TypeDefIndex: 5903
{
	private JsonToken _tokenType; 
	private object _value; 
	internal char _quoteChar; 
	internal JsonReader.State _currentState; 
	private JsonPosition _currentPosition; 
	private CultureInfo _culture; 
	private DateTimeZoneHandling _dateTimeZoneHandling; 
	private Nullable<int> _maxDepth; 
	private bool _hasExceededMaxDepth; 
	internal DateParseHandling _dateParseHandling; 
	internal FloatParseHandling _floatParseHandling; 
	private string _dateFormatString; 
	private List<JsonPosition> _stack; 
	[CompilerGeneratedAttribute] 
	private bool <CloseInput>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <SupportMultipleContent>k__BackingField; 

	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	public virtual string Path { get; }
	public CultureInfo Culture { get; set; }


	protected JsonReader.State get_CurrentState() { }

	[CompilerGeneratedAttribute] 
	public bool get_CloseInput() { }

	[CompilerGeneratedAttribute] 
	public void set_CloseInput(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_SupportMultipleContent() { }

	[CompilerGeneratedAttribute] 
	public void set_SupportMultipleContent(bool value) { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public DateParseHandling get_DateParseHandling() { }

	public void set_DateParseHandling(DateParseHandling value) { }

	public FloatParseHandling get_FloatParseHandling() { }

	public void set_FloatParseHandling(FloatParseHandling value) { }

	public string get_DateFormatString() { }

	public void set_DateFormatString(string value) { }

	public Nullable<int> get_MaxDepth() { }

	public void set_MaxDepth(Nullable<int> value) { }

	public virtual JsonToken get_TokenType() { }

	public virtual object get_Value() { }

	public virtual Type get_ValueType() { }

	public virtual int get_Depth() { }

	public virtual string get_Path() { }

	public CultureInfo get_Culture() { }

	public void set_Culture(CultureInfo value) { }

	internal JsonPosition GetPosition(int depth) { }

	protected void .ctor() { }

	private void Push(JsonContainerType value) { }

	private JsonContainerType Pop() { }

	private JsonContainerType Peek() { }

	public abstract bool Read();

	public virtual Nullable<int> ReadAsInt32() { }

	internal Nullable<int> ReadInt32String(string s) { }

	public virtual string ReadAsString() { }

	public virtual byte[] ReadAsBytes() { }

	internal byte[] ReadArrayIntoByteArray() { }

	public virtual Nullable<double> ReadAsDouble() { }

	internal Nullable<double> ReadDoubleString(string s) { }

	public virtual Nullable<bool> ReadAsBoolean() { }

	internal Nullable<bool> ReadBooleanString(string s) { }

	public virtual Nullable<Decimal> ReadAsDecimal() { }

	internal Nullable<Decimal> ReadDecimalString(string s) { }

	public virtual Nullable<DateTime> ReadAsDateTime() { }

	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	internal void ReaderReadAndAssert() { }

	internal JsonReaderException CreateUnexpectedEndException() { }

	internal void ReadIntoWrappedTypeObject() { }

	public void Skip() { }

	protected void SetToken(JsonToken newToken) { }

	protected void SetToken(JsonToken newToken, object value) { }

	internal void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	internal void SetPostValueState(bool updateIndex) { }

	private void UpdateScopeWithFinishedValue() { }

	private void ValidateEnd(JsonToken endToken) { }

	protected void SetStateBasedOnCurrent() { }

	private void SetFinished() { }

	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	private void System.IDisposable.Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Close() { }

	internal void ReadAndAssert() { }

	internal bool ReadAndMoveToContent() { }

	internal bool MoveToContent() { }

	private JsonToken GetContentToken() { }

}

public static class JsonConvert // TypeDefIndex: 5905
{
	[CompilerGeneratedAttribute] 
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; 
	public static readonly string True; 
	public static readonly string False; 
	public static readonly string Null; 
	public static readonly string Undefined; 
	public static readonly string PositiveInfinity; 
	public static readonly string NegativeInfinity; 
	public static readonly string NaN; 
	private static readonly JsonSerializerSettings InitialSerializerSettings; 

	public static Func<JsonSerializerSettings> DefaultSettings { get; set; }


	[CompilerGeneratedAttribute] 
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[CompilerGeneratedAttribute] 
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	private static void .cctor() { }

	internal static JsonSerializerSettings GetDefaultSettings() { }

	public static string ToString(bool value) { }

	public static string ToString(char value) { }

	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	private static string EnsureDecimalPlace(double value, string text) { }

	private static string EnsureDecimalPlace(string text) { }

	public static string ToString(Decimal value) { }

	public static string ToString(string value) { }

	public static string ToString(string value, char delimiter) { }

	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	public static string SerializeObject(object value) { }

	public static string SerializeObject(object value, Formatting formatting) { }

	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	public static object DeserializeObject(string value, Type type) { }

	public static T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-JsonConvert.DeserializeObject<ClientFrametimeRequest>
	|-JsonConvert.DeserializeObject<CompanionSubscription.Status>
	|-JsonConvert.DeserializeObject<Account.AccountJson>
	|-JsonConvert.DeserializeObject<BuildInfo>
	|-JsonConvert.DeserializeObject<AddResponse>
	|-JsonConvert.DeserializeObject<BaseResponse>
	|-JsonConvert.DeserializeObject<QueryResponse[]>
	|-JsonConvert.DeserializeObject<Entry[]>
	|-JsonConvert.DeserializeObject<Rank>
	|-JsonConvert.DeserializeObject<Manifest>
	|-JsonConvert.DeserializeObject<SteamInventoryCrafting.MarketPrice>
	|-JsonConvert.DeserializeObject<Skin.Manifest>
	|-JsonConvert.DeserializeObject<Dictionary<string, CameraMan.CameraState>>
	|-JsonConvert.DeserializeObject<Dictionary<string, int>>
	|-JsonConvert.DeserializeObject<Dictionary<string, string>>
	|-JsonConvert.DeserializeObject<Dictionary<ulong, Chat.MuteEntry>>
	|-JsonConvert.DeserializeObject<List<Admin.PlayerInfo>>
	|-JsonConvert.DeserializeObject<List<Admin.ServerConvarInfo>>
	|-JsonConvert.DeserializeObject<List<Admin.ServerUGCInfo>>
	|-JsonConvert.DeserializeObject<Telephone.CensoredNumbers>
	|-JsonConvert.DeserializeObject<object>
	|
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-JsonConvert.DeserializeObject<CorePropsFile>
	*/

	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-JsonConvert.DeserializeObject<CameraMan.CameraState>
	|
	|-JsonConvert.DeserializeObject<NoticeData>
	|
	|-JsonConvert.DeserializeObject<RCon.Command>
	|
	|-JsonConvert.DeserializeObject<CorePropsFile>
	|
	|-JsonConvert.DeserializeObject<object>
	*/

	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

}

public class JsonSerializationException : JsonException // TypeDefIndex: 5906
{

	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	public void .ctor(SerializationInfo info, StreamingContext context) { }

	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }

}

public class JsonSerializer // TypeDefIndex: 5907
{
	internal TypeNameHandling _typeNameHandling; 
	internal FormatterAssemblyStyle _typeNameAssemblyFormat; 
	internal PreserveReferencesHandling _preserveReferencesHandling; 
	internal ReferenceLoopHandling _referenceLoopHandling; 
	internal MissingMemberHandling _missingMemberHandling; 
	internal ObjectCreationHandling _objectCreationHandling; 
	internal NullValueHandling _nullValueHandling; 
	internal DefaultValueHandling _defaultValueHandling; 
	internal ConstructorHandling _constructorHandling; 
	internal MetadataPropertyHandling _metadataPropertyHandling; 
	internal JsonConverterCollection _converters; 
	internal IContractResolver _contractResolver; 
	internal ITraceWriter _traceWriter; 
	internal IEqualityComparer _equalityComparer; 
	internal SerializationBinder _binder; 
	internal StreamingContext _context; 
	private IReferenceResolver _referenceResolver; 
	private Nullable<Formatting> _formatting; 
	private Nullable<DateFormatHandling> _dateFormatHandling; 
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; 
	private Nullable<DateParseHandling> _dateParseHandling; 
	private Nullable<FloatFormatHandling> _floatFormatHandling; 
	private Nullable<FloatParseHandling> _floatParseHandling; 
	private Nullable<StringEscapeHandling> _stringEscapeHandling; 
	private CultureInfo _culture; 
	private Nullable<int> _maxDepth; 
	private bool _maxDepthSet; 
	private Nullable<bool> _checkAdditionalContent; 
	private string _dateFormatString; 
	private bool _dateFormatStringSet; 
	[CompilerGeneratedAttribute] 
	private EventHandler<ErrorEventArgs> Error; 

	public virtual IReferenceResolver ReferenceResolver { set; }
	public virtual SerializationBinder Binder { set; }
	public virtual ITraceWriter TraceWriter { get; set; }
	public virtual IEqualityComparer EqualityComparer { set; }
	public virtual TypeNameHandling TypeNameHandling { set; }
	public virtual FormatterAssemblyStyle TypeNameAssemblyFormat { set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { set; }
	public virtual MissingMemberHandling MissingMemberHandling { set; }
	public virtual NullValueHandling NullValueHandling { set; }
	public virtual DefaultValueHandling DefaultValueHandling { set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { get; set; }
	public virtual ConstructorHandling ConstructorHandling { set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Formatting Formatting { get; set; }
	public virtual bool CheckAdditionalContent { get; set; }


	[CompilerGeneratedAttribute] 
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGeneratedAttribute] 
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	public virtual void set_Binder(SerializationBinder value) { }

	public virtual ITraceWriter get_TraceWriter() { }

	public virtual void set_TraceWriter(ITraceWriter value) { }

	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	public virtual void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	public virtual void set_NullValueHandling(NullValueHandling value) { }

	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	public virtual ObjectCreationHandling get_ObjectCreationHandling() { }

	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public virtual JsonConverterCollection get_Converters() { }

	public virtual IContractResolver get_ContractResolver() { }

	public virtual void set_ContractResolver(IContractResolver value) { }

	public virtual StreamingContext get_Context() { }

	public virtual void set_Context(StreamingContext value) { }

	public virtual Formatting get_Formatting() { }

	public virtual void set_Formatting(Formatting value) { }

	public virtual bool get_CheckAdditionalContent() { }

	public virtual void set_CheckAdditionalContent(bool value) { }

	internal bool IsCheckAdditionalContentSet() { }

	public void .ctor() { }

	public static JsonSerializer Create() { }

	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	public static JsonSerializer CreateDefault() { }

	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	public void Populate(JsonReader reader, object target) { }

	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-JsonSerializer.Deserialize<Int32Enum>
	|-JsonSerializer.Deserialize<RegexOptions>
	|
	|-JsonSerializer.Deserialize<object>
	*/

	public object Deserialize(JsonReader reader, Type objectType) { }

	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	public void Serialize(JsonWriter jsonWriter, object value) { }

	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	internal IReferenceResolver GetReferenceResolver() { }

	internal JsonConverter GetMatchingConverter(Type type) { }

	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	internal void OnError(ErrorEventArgs e) { }

}

public enum JsonToken // TypeDefIndex: 5912
{
	public int value__; 
	public const JsonToken None = 0;
	public const JsonToken StartObject = 1;
	public const JsonToken StartArray = 2;
	public const JsonToken StartConstructor = 3;
	public const JsonToken PropertyName = 4;
	public const JsonToken Comment = 5;
	public const JsonToken Raw = 6;
	public const JsonToken Integer = 7;
	public const JsonToken Float = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
	public const JsonToken Undefined = 12;
	public const JsonToken EndObject = 13;
	public const JsonToken EndArray = 14;
	public const JsonToken EndConstructor = 15;
	public const JsonToken Date = 16;
	public const JsonToken Bytes = 17;

}

public abstract class JsonWriter : IDisposable // TypeDefIndex: 5913
{
	private static readonly JsonWriter.State[][] StateArray; 
	internal static readonly JsonWriter.State[][] StateArrayTempate; 
	private List<JsonPosition> _stack; 
	private JsonPosition _currentPosition; 
	private JsonWriter.State _currentState; 
	private Formatting _formatting; 
	[CompilerGeneratedAttribute] 
	private bool <CloseOutput>k__BackingField; 
	private DateFormatHandling _dateFormatHandling; 
	private DateTimeZoneHandling _dateTimeZoneHandling; 
	private StringEscapeHandling _stringEscapeHandling; 
	private FloatFormatHandling _floatFormatHandling; 
	private string _dateFormatString; 
	private CultureInfo _culture; 

	public bool CloseOutput { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }


	internal static JsonWriter.State[][] BuildStateArray() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] 
	public bool get_CloseOutput() { }

	[CompilerGeneratedAttribute] 
	public void set_CloseOutput(bool value) { }

	protected internal int get_Top() { }

	public WriteState get_WriteState() { }

	internal string get_ContainerPath() { }

	public string get_Path() { }

	public Formatting get_Formatting() { }

	public void set_Formatting(Formatting value) { }

	public DateFormatHandling get_DateFormatHandling() { }

	public void set_DateFormatHandling(DateFormatHandling value) { }

	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	public StringEscapeHandling get_StringEscapeHandling() { }

	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	internal virtual void OnStringEscapeHandlingChanged() { }

	public FloatFormatHandling get_FloatFormatHandling() { }

	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	public string get_DateFormatString() { }

	public void set_DateFormatString(string value) { }

	public CultureInfo get_Culture() { }

	public void set_Culture(CultureInfo value) { }

	protected void .ctor() { }

	internal void UpdateScopeWithFinishedValue() { }

	private void Push(JsonContainerType value) { }

	private JsonContainerType Pop() { }

	private JsonContainerType Peek() { }

	public virtual void Close() { }

	public virtual void WriteStartObject() { }

	public virtual void WriteEndObject() { }

	public virtual void WriteStartArray() { }

	public virtual void WriteEndArray() { }

	public virtual void WriteStartConstructor(string name) { }

	public virtual void WriteEndConstructor() { }

	public virtual void WritePropertyName(string name) { }

	public virtual void WritePropertyName(string name, bool escape) { }

	public virtual void WriteEnd() { }

	public void WriteToken(JsonReader reader) { }

	public void WriteToken(JsonReader reader, bool writeChildren) { }

	public void WriteToken(JsonToken token, object value) { }

	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	private void WriteConstructorDate(JsonReader reader) { }

	private void WriteEnd(JsonContainerType type) { }

	private void AutoCompleteAll() { }

	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	private void AutoCompleteClose(JsonContainerType type) { }

	protected virtual void WriteEnd(JsonToken token) { }

	protected virtual void WriteIndent() { }

	protected virtual void WriteValueDelimiter() { }

	protected virtual void WriteIndentSpace() { }

	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	public virtual void WriteNull() { }

	public virtual void WriteUndefined() { }

	public virtual void WriteRaw(string json) { }

	public virtual void WriteRawValue(string json) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteValue(int value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(uint value) { }

	public virtual void WriteValue(long value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(ulong value) { }

	public virtual void WriteValue(float value) { }

	public virtual void WriteValue(double value) { }

	public virtual void WriteValue(bool value) { }

	public virtual void WriteValue(short value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(ushort value) { }

	public virtual void WriteValue(char value) { }

	public virtual void WriteValue(byte value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(sbyte value) { }

	public virtual void WriteValue(Decimal value) { }

	public virtual void WriteValue(DateTime value) { }

	public virtual void WriteValue(DateTimeOffset value) { }

	public virtual void WriteValue(Guid value) { }

	public virtual void WriteValue(TimeSpan value) { }

	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(Nullable<uint> value) { }

	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(Nullable<ulong> value) { }

	public virtual void WriteValue(Nullable<float> value) { }

	public virtual void WriteValue(Nullable<double> value) { }

	public virtual void WriteValue(Nullable<bool> value) { }

	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(Nullable<ushort> value) { }

	public virtual void WriteValue(Nullable<char> value) { }

	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliantAttribute] 
	public virtual void WriteValue(Nullable<sbyte> value) { }

	public virtual void WriteValue(Nullable<Decimal> value) { }

	public virtual void WriteValue(Nullable<DateTime> value) { }

	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	public virtual void WriteValue(Nullable<Guid> value) { }

	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	public virtual void WriteValue(byte[] value) { }

	public virtual void WriteValue(Uri value) { }

	public virtual void WriteValue(object value) { }

	public virtual void WriteComment(string text) { }

	private void System.IDisposable.Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	internal void InternalWriteEnd(JsonContainerType container) { }

	internal void InternalWritePropertyName(string name) { }

	internal void InternalWriteRaw() { }

	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	internal void InternalWriteValue(JsonToken token) { }

	internal void InternalWriteComment() { }

}

internal enum JsonWriter.State // TypeDefIndex: 5914
{
	public int value__; 
	public const JsonWriter.State Start = 0;
	public const JsonWriter.State Property = 1;
	public const JsonWriter.State ObjectStart = 2;
	public const JsonWriter.State Object = 3;
	public const JsonWriter.State ArrayStart = 4;
	public const JsonWriter.State Array = 5;
	public const JsonWriter.State ConstructorStart = 6;
	public const JsonWriter.State Constructor = 7;
	public const JsonWriter.State Closed = 8;
	public const JsonWriter.State Error = 9;

}

internal static class JsonTokenUtils // TypeDefIndex: 5919
{

	internal static bool IsEndToken(JsonToken token) { }

	internal static bool IsStartToken(JsonToken token) { }

	internal static bool IsPrimitiveToken(JsonToken token) { }

}

public class JsonContainerContract : JsonContract // TypeDefIndex: 5978
{
	private JsonContract _itemContract; 
	private JsonContract _finalItemContract; 
	[CompilerGeneratedAttribute] 
	private JsonConverter <ItemConverter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<bool> <ItemIsReference>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; 

	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }


	internal JsonContract get_ItemContract() { }

	internal void set_ItemContract(JsonContract value) { }

	internal JsonContract get_FinalItemContract() { }

	[CompilerGeneratedAttribute] 
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	internal void .ctor(Type underlyingType) { }

}

internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 5981
{
	private readonly JsonReader _innerReader; 
	private readonly JsonTextWriter _textWriter; 
	private readonly StringWriter _sw; 

	public override int Depth { get; }
	public override string Path { get; }
	public override JsonToken TokenType { get; }
	public override object Value { get; }
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }


	public void .ctor(JsonReader innerReader) { }

	public string GetDeserializedJsonMessage() { }

	public override bool Read() { }

	public override Nullable<int> ReadAsInt32() { }

	public override string ReadAsString() { }

	public override byte[] ReadAsBytes() { }

	public override Nullable<Decimal> ReadAsDecimal() { }

	public override Nullable<double> ReadAsDouble() { }

	public override Nullable<bool> ReadAsBoolean() { }

	public override Nullable<DateTime> ReadAsDateTime() { }

	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	public override int get_Depth() { }

	public override string get_Path() { }

	public override JsonToken get_TokenType() { }

	public override object get_Value() { }

	public override Type get_ValueType() { }

	public override void Close() { }

	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

}

internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 5982
{
	private readonly JsonWriter _innerWriter; 
	private readonly JsonTextWriter _textWriter; 
	private readonly StringWriter _sw; 


	public void .ctor(JsonWriter innerWriter) { }

	public string GetSerializedJsonMessage() { }

	public override void WriteValue(Decimal value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(byte value) { }

	public override void WriteValue(Nullable<byte> value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(byte[] value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(double value) { }

	public override void WriteUndefined() { }

	public override void WriteNull() { }

	public override void WriteValue(float value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(int value) { }

	public override void WriteValue(long value) { }

	public override void WriteValue(object value) { }

	public override void WriteValue(sbyte value) { }

	public override void WriteValue(short value) { }

	public override void WriteValue(string value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(uint value) { }

	public override void WriteValue(ulong value) { }

	public override void WriteValue(Uri value) { }

	public override void WriteValue(ushort value) { }

	public override void WriteComment(string text) { }

	public override void WriteStartArray() { }

	public override void WriteEndArray() { }

	public override void WriteStartConstructor(string name) { }

	public override void WriteEndConstructor() { }

	public override void WritePropertyName(string name) { }

	public override void WritePropertyName(string name, bool escape) { }

	public override void WriteStartObject() { }

	public override void WriteEndObject() { }

	public override void WriteRawValue(string json) { }

	public override void WriteRaw(string json) { }

	public override void Close() { }

}

internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 5983
{
	private readonly JsonSerializerInternalReader _reader; 
	private readonly JsonISerializableContract _contract; 
	private readonly JsonProperty _member; 


	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-JsonFormatterConverter.GetTokenValue<object>
	|-JsonFormatterConverter.GetTokenValue<string>
	|
	|-JsonFormatterConverter.GetTokenValue<float>
	*/

	public object Convert(object value, Type type) { }

	public bool ToBoolean(object value) { }

	public int ToInt32(object value) { }

	public long ToInt64(object value) { }

	public float ToSingle(object value) { }

	public string ToString(object value) { }

}

public class JsonLinqContract : JsonContract // TypeDefIndex: 5985
{

	public void .ctor(Type underlyingType) { }

}

public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 5986
{
	[CompilerGeneratedAttribute] 
	private PrimitiveTypeCode <TypeCode>k__BackingField; 
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; 

	internal PrimitiveTypeCode TypeCode { get; set; }


	[CompilerGeneratedAttribute] 
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] 
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	public void .ctor(Type underlyingType) { }

	private static void .cctor() { }

}

public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 6006
{
	[CompilerGeneratedAttribute] 
	private Type <CollectionItemType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsMultidimensionalArray>k__BackingField; 
	private readonly Type _genericCollectionDefinitionType; 
	private Type _genericWrapperType; 
	private ObjectConstructor<object> _genericWrapperCreator; 
	private Func<object> _genericTemporaryCollectionCreator; 
	[CompilerGeneratedAttribute] 
	private bool <IsArray>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <ShouldCreateWrapper>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <CanDeserialize>k__BackingField; 
	private readonly ConstructorInfo _parameterizedConstructor; 
	private ObjectConstructor<object> _parameterizedCreator; 
	private ObjectConstructor<object> _overrideCreator; 
	[CompilerGeneratedAttribute] 
	private bool <HasParameterizedCreator>k__BackingField; 

	public Type CollectionItemType { get; set; }
	public bool IsMultidimensionalArray { get; set; }
	internal bool IsArray { get; set; }
	internal bool ShouldCreateWrapper { get; set; }
	internal bool CanDeserialize { get; set; }
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }


	[CompilerGeneratedAttribute] 
	public Type get_CollectionItemType() { }

	[CompilerGeneratedAttribute] 
	private void set_CollectionItemType(Type value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsMultidimensionalArray() { }

	[CompilerGeneratedAttribute] 
	private void set_IsMultidimensionalArray(bool value) { }

	[CompilerGeneratedAttribute] 
	internal bool get_IsArray() { }

	[CompilerGeneratedAttribute] 
	private void set_IsArray(bool value) { }

	[CompilerGeneratedAttribute] 
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGeneratedAttribute] 
	private void set_ShouldCreateWrapper(bool value) { }

	[CompilerGeneratedAttribute] 
	internal bool get_CanDeserialize() { }

	[CompilerGeneratedAttribute] 
	private void set_CanDeserialize(bool value) { }

	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	public ObjectConstructor<object> get_OverrideCreator() { }

	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGeneratedAttribute] 
	public bool get_HasParameterizedCreator() { }

	[CompilerGeneratedAttribute] 
	public void set_HasParameterizedCreator(bool value) { }

	internal bool get_HasParameterizedCreatorInternal() { }

	public void .ctor(Type underlyingType) { }

	internal IWrappedCollection CreateWrapper(object list) { }

	internal IList CreateTemporaryCollection() { }

}

internal enum JsonContractType // TypeDefIndex: 6007
{
	public int value__; 
	public const JsonContractType None = 0;
	public const JsonContractType Object = 1;
	public const JsonContractType Array = 2;
	public const JsonContractType Primitive = 3;
	public const JsonContractType String = 4;
	public const JsonContractType Dictionary = 5;
	public const JsonContractType Dynamic = 6;
	public const JsonContractType Serializable = 7;
	public const JsonContractType Linq = 8;

}

public abstract class JsonContract // TypeDefIndex: 6012
{
	internal bool IsNullable; 
	internal bool IsConvertable; 
	internal bool IsEnum; 
	internal Type NonNullableUnderlyingType; 
	internal ReadType InternalReadType; 
	internal JsonContractType ContractType; 
	internal bool IsReadOnlyOrFixedSize; 
	internal bool IsSealed; 
	internal bool IsInstantiable; 
	private List<SerializationCallback> _onDeserializedCallbacks; 
	private IList<SerializationCallback> _onDeserializingCallbacks; 
	private IList<SerializationCallback> _onSerializedCallbacks; 
	private IList<SerializationCallback> _onSerializingCallbacks; 
	private IList<SerializationErrorCallback> _onErrorCallbacks; 
	private Type _createdType; 
	[CompilerGeneratedAttribute] 
	private Type <UnderlyingType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<bool> <IsReference>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private JsonConverter <Converter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private JsonConverter <InternalConverter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Func<object> <DefaultCreator>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <DefaultCreatorNonPublic>k__BackingField; 

	public Type UnderlyingType { get; set; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	public JsonConverter Converter { get; set; }
	internal JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }


	[CompilerGeneratedAttribute] 
	public Type get_UnderlyingType() { }

	[CompilerGeneratedAttribute] 
	private void set_UnderlyingType(Type value) { }

	public Type get_CreatedType() { }

	public void set_CreatedType(Type value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] 
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] 
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] 
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] 
	internal JsonConverter get_InternalConverter() { }

	[CompilerGeneratedAttribute] 
	internal void set_InternalConverter(JsonConverter value) { }

	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGeneratedAttribute] 
	public Func<object> get_DefaultCreator() { }

	[CompilerGeneratedAttribute] 
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGeneratedAttribute] 
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGeneratedAttribute] 
	public void set_DefaultCreatorNonPublic(bool value) { }

	internal void .ctor(Type underlyingType) { }

	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }

}

private sealed class JsonContract.<>c__DisplayClass73_0 // TypeDefIndex: 6013
{
	public MethodInfo callbackMethodInfo; 


	public void .ctor() { }

	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }

}

private sealed class JsonContract.<>c__DisplayClass74_0 // TypeDefIndex: 6014
{
	public MethodInfo callbackMethodInfo; 


	public void .ctor() { }

	internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }

}

public class JsonProperty // TypeDefIndex: 6016
{
	internal Nullable<Required> _required; 
	internal bool _hasExplicitDefaultValue; 
	private object _defaultValue; 
	private bool _hasGeneratedDefaultValue; 
	private string _propertyName; 
	internal bool _skipPropertyNameEscape; 
	private Type _propertyType; 
	[CompilerGeneratedAttribute] 
	private JsonContract <PropertyContract>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Type <DeclaringType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<int> <Order>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <UnderlyingName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IValueProvider <ValueProvider>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IAttributeProvider <AttributeProvider>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private JsonConverter <Converter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private JsonConverter <MemberConverter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Ignored>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Readable>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Writable>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <HasMemberAttribute>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<bool> <IsReference>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Predicate<object> <ShouldSerialize>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Predicate<object> <ShouldDeserialize>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Predicate<object> <GetIsSpecified>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action<object, object> <SetIsSpecified>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private JsonConverter <ItemConverter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<bool> <ItemIsReference>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; 

	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	public JsonConverter MemberConverter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	public Predicate<object> ShouldSerialize { get; set; }
	public Predicate<object> ShouldDeserialize { get; }
	public Predicate<object> GetIsSpecified { get; set; }
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }


	[CompilerGeneratedAttribute] 
	internal JsonContract get_PropertyContract() { }

	[CompilerGeneratedAttribute] 
	internal void set_PropertyContract(JsonContract value) { }

	public string get_PropertyName() { }

	public void set_PropertyName(string value) { }

	[CompilerGeneratedAttribute] 
	public Type get_DeclaringType() { }

	[CompilerGeneratedAttribute] 
	public void set_DeclaringType(Type value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<int> get_Order() { }

	[CompilerGeneratedAttribute] 
	public void set_Order(Nullable<int> value) { }

	[CompilerGeneratedAttribute] 
	public string get_UnderlyingName() { }

	[CompilerGeneratedAttribute] 
	public void set_UnderlyingName(string value) { }

	[CompilerGeneratedAttribute] 
	public IValueProvider get_ValueProvider() { }

	[CompilerGeneratedAttribute] 
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGeneratedAttribute] 
	public void set_AttributeProvider(IAttributeProvider value) { }

	public Type get_PropertyType() { }

	public void set_PropertyType(Type value) { }

	[CompilerGeneratedAttribute] 
	public JsonConverter get_Converter() { }

	[CompilerGeneratedAttribute] 
	public void set_Converter(JsonConverter value) { }

	[CompilerGeneratedAttribute] 
	public JsonConverter get_MemberConverter() { }

	[CompilerGeneratedAttribute] 
	public void set_MemberConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Ignored() { }

	[CompilerGeneratedAttribute] 
	public void set_Ignored(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Readable() { }

	[CompilerGeneratedAttribute] 
	public void set_Readable(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Writable() { }

	[CompilerGeneratedAttribute] 
	public void set_Writable(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_HasMemberAttribute() { }

	[CompilerGeneratedAttribute] 
	public void set_HasMemberAttribute(bool value) { }

	public object get_DefaultValue() { }

	public void set_DefaultValue(object value) { }

	internal object GetResolvedDefaultValue() { }

	public Required get_Required() { }

	[CompilerGeneratedAttribute] 
	public Nullable<bool> get_IsReference() { }

	[CompilerGeneratedAttribute] 
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] 
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGeneratedAttribute] 
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGeneratedAttribute] 
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGeneratedAttribute] 
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGeneratedAttribute] 
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGeneratedAttribute] 
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGeneratedAttribute] 
	public void set_SetIsSpecified(Action<object, object> value) { }

	public override string ToString() { }

	[CompilerGeneratedAttribute] 
	public JsonConverter get_ItemConverter() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	internal void WritePropertyName(JsonWriter writer) { }

	public void .ctor() { }

}

public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 6017
{
	private readonly Type _type; 
	private readonly List<JsonProperty> _list; 


	public void .ctor(Type type) { }

	protected override string GetKeyForItem(JsonProperty item) { }

	public void AddProperty(JsonProperty property) { }

	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	private bool TryGetValue(string key, out JsonProperty item) { }

	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }

}

public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 6019
{
	[CompilerGeneratedAttribute] 
	private MemberSerialization <MemberSerialization>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<Required> <ItemRequired>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private JsonPropertyCollection <Properties>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; 
	internal bool ExtensionDataIsJToken; 
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; 
	private ConstructorInfo _parametrizedConstructor; 
	private ConstructorInfo _overrideConstructor; 
	private ObjectConstructor<object> _overrideCreator; 
	private ObjectConstructor<object> _parameterizedCreator; 
	private JsonPropertyCollection _creatorParameters; 
	private Type _extensionDataValueType; 

	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public JsonPropertyCollection Properties { get; set; }
	public JsonPropertyCollection CreatorParameters { get; }
	[ObsoleteAttribute] 
	public ConstructorInfo OverrideConstructor { set; }
	[ObsoleteAttribute] 
	public ConstructorInfo ParametrizedConstructor { set; }
	public ObjectConstructor<object> OverrideCreator { get; }
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }


	[CompilerGeneratedAttribute] 
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGeneratedAttribute] 
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGeneratedAttribute] 
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGeneratedAttribute] 
	public JsonPropertyCollection get_Properties() { }

	[CompilerGeneratedAttribute] 
	private void set_Properties(JsonPropertyCollection value) { }

	public JsonPropertyCollection get_CreatorParameters() { }

	public void set_OverrideConstructor(ConstructorInfo value) { }

	public void set_ParametrizedConstructor(ConstructorInfo value) { }

	public ObjectConstructor<object> get_OverrideCreator() { }

	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	[CompilerGeneratedAttribute] 
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGeneratedAttribute] 
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGeneratedAttribute] 
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGeneratedAttribute] 
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	public void set_ExtensionDataValueType(Type value) { }

	internal bool get_HasRequiredOrDefaultValueProperties() { }

	public void .ctor(Type underlyingType) { }

	internal object GetUninitializedObject() { }

}

internal abstract class JsonSerializerInternalBase // TypeDefIndex: 6020
{
	private ErrorContext _currentErrorContext; 
	private BidirectionalDictionary<string, object> _mappings; 
	internal readonly JsonSerializer Serializer; 
	internal readonly ITraceWriter TraceWriter; 
	protected JsonSerializerProxy InternalSerializer; 

	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }


	protected void .ctor(JsonSerializer serializer) { }

	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	protected void ClearErrorContext() { }

	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }

}

private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 6021
{

	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	public void .ctor() { }

}

internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 6022
{

	public void .ctor(JsonSerializer serializer) { }

	public void Populate(JsonReader reader, object target) { }

	private JsonContract GetContractSafe(Type type) { }

	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	private JsonSerializerProxy GetInternalSerializer() { }

	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	private JToken CreateJObject(JsonReader reader) { }

	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	internal string GetExpectedDescription(JsonContract contract) { }

	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	private bool HasNoDefinedType(JsonContract contract) { }

	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue) { }

	private void AddReference(JsonReader reader, string id, object value) { }

	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	private bool ShouldSetPropertyValue(JsonProperty property, object value) { }

	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter) { }

	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }

}

internal enum JsonSerializerInternalReader.PropertyPresence // TypeDefIndex: 6023
{
	public int value__; 
	public const JsonSerializerInternalReader.PropertyPresence None = 0;
	public const JsonSerializerInternalReader.PropertyPresence Null = 1;
	public const JsonSerializerInternalReader.PropertyPresence Value = 2;

}

internal class JsonSerializerInternalReader.CreatorPropertyContext // TypeDefIndex: 6024
{
	public string Name; 
	public JsonProperty Property; 
	public JsonProperty ConstructorProperty; 
	public Nullable<JsonSerializerInternalReader.PropertyPresence> Presence; 
	public object Value; 
	public bool Used; 


	public void .ctor() { }

}

private sealed class JsonSerializerInternalReader.<>c__DisplayClass36_0 // TypeDefIndex: 6025
{
	public JsonProperty property; 


	public void .ctor() { }

	internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p) { }

}

private sealed class JsonSerializerInternalReader.<>c // TypeDefIndex: 6026
{
	public static readonly JsonSerializerInternalReader.<>c <>9; 
	public static Func<JsonProperty, string> <>9__36_0; 
	public static Func<JsonProperty, string> <>9__36_2; 
	public static Func<JsonProperty, JsonProperty> <>9__41_0; 
	public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__41_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p) { }

	internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p) { }

	internal JsonProperty <PopulateObject>b__41_0(JsonProperty m) { }

	internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__41_1(JsonProperty m) { }

}

internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 6027
{
	private Type _rootType; 
	private int _rootLevel; 
	private readonly List<object> _serializeStack; 


	public void .ctor(JsonSerializer serializer) { }

	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	private JsonSerializerProxy GetInternalSerializer() { }

	private JsonContract GetContractSafe(object value) { }

	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool ShouldWriteProperty(object memberValue, JsonProperty property) { }

	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void WriteReference(JsonWriter writer, object value) { }

	private string GetReference(JsonWriter writer, object value) { }

	internal static bool TryConvertToString(object value, Type type, out string s) { }

	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	private void HandleError(JsonWriter writer, int initialDepth) { }

	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }

}

internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 6028
{
	private readonly JsonSerializerInternalReader _serializerReader; 
	private readonly JsonSerializerInternalWriter _serializerWriter; 
	private readonly JsonSerializer _serializer; 

	public override IReferenceResolver ReferenceResolver { set; }
	public override ITraceWriter TraceWriter { get; set; }
	public override IEqualityComparer EqualityComparer { set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { set; }
	public override NullValueHandling NullValueHandling { set; }
	public override ObjectCreationHandling ObjectCreationHandling { get; set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { set; }
	public override TypeNameHandling TypeNameHandling { set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public override FormatterAssemblyStyle TypeNameAssemblyFormat { set; }
	public override ConstructorHandling ConstructorHandling { set; }
	public override SerializationBinder Binder { set; }
	public override StreamingContext Context { get; set; }
	public override Formatting Formatting { get; set; }
	public override bool CheckAdditionalContent { get; set; }


	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	public override void set_ReferenceResolver(IReferenceResolver value) { }

	public override ITraceWriter get_TraceWriter() { }

	public override void set_TraceWriter(ITraceWriter value) { }

	public override void set_EqualityComparer(IEqualityComparer value) { }

	public override JsonConverterCollection get_Converters() { }

	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	public override IContractResolver get_ContractResolver() { }

	public override void set_ContractResolver(IContractResolver value) { }

	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	public override void set_NullValueHandling(NullValueHandling value) { }

	public override ObjectCreationHandling get_ObjectCreationHandling() { }

	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	public override void set_TypeNameHandling(TypeNameHandling value) { }

	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	public override void set_TypeNameAssemblyFormat(FormatterAssemblyStyle value) { }

	public override void set_ConstructorHandling(ConstructorHandling value) { }

	public override void set_Binder(SerializationBinder value) { }

	public override StreamingContext get_Context() { }

	public override void set_Context(StreamingContext value) { }

	public override Formatting get_Formatting() { }

	public override void set_Formatting(Formatting value) { }

	public override bool get_CheckAdditionalContent() { }

	public override void set_CheckAdditionalContent(bool value) { }

	internal JsonSerializerInternalBase GetInternalSerializer() { }

	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	internal override void PopulateInternal(JsonReader reader, object target) { }

	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }

}

public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 6029
{

	public void .ctor(Type underlyingType) { }

}

internal static class JsonTypeReflector // TypeDefIndex: 6030
{
	private static Nullable<bool> _fullyTrusted; 
	private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache; 
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; 
	private static ReflectionObject _metadataTypeAttributeReflectionObject; 

	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }


	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-JsonTypeReflector.GetCachedAttribute<JsonContainerAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonConverterAttribute>
	|-JsonTypeReflector.GetCachedAttribute<JsonObjectAttribute>
	|-JsonTypeReflector.GetCachedAttribute<object>
	|-JsonTypeReflector.GetCachedAttribute<SerializableAttribute>
	*/

	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs) { }

	private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType) { }

	public static TypeConverter GetTypeConverter(Type type) { }

	private static Type GetAssociatedMetadataType(Type type) { }

	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-JsonTypeReflector.GetAttribute<object>
	*/

	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-JsonTypeReflector.GetAttribute<object>
	*/

	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-JsonTypeReflector.GetAttribute<JsonExtensionDataAttribute>
	|-JsonTypeReflector.GetAttribute<JsonIgnoreAttribute>
	|-JsonTypeReflector.GetAttribute<JsonPropertyAttribute>
	|-JsonTypeReflector.GetAttribute<JsonRequiredAttribute>
	|-JsonTypeReflector.GetAttribute<DefaultValueAttribute>
	|-JsonTypeReflector.GetAttribute<NonSerializedAttribute>
	|-JsonTypeReflector.GetAttribute<object>
	|-JsonTypeReflector.GetAttribute<DataMemberAttribute>
	*/

	public static bool get_FullyTrusted() { }

	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	private static void .cctor() { }

}

private sealed class JsonTypeReflector.<>c__DisplayClass18_0 // TypeDefIndex: 6031
{
	public Type converterType; 
	public Func<object> defaultConstructor; 


	public void .ctor() { }

	internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters) { }

}

private sealed class JsonTypeReflector.<>c // TypeDefIndex: 6032
{
	public static readonly JsonTypeReflector.<>c <>9; 
	public static Func<object, Type> <>9__18_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal Type <GetJsonConverterCreator>b__18_1(object param) { }

}

public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 6039
{
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }


	public void .ctor(string name) { }

	private static JObject CastInstance(object instance) { }

	public override object GetValue(object component) { }

	public override void SetValue(object component, object value) { }

	public override bool ShouldSerializeValue(object component) { }

	public override Type get_ComponentType() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	protected override int get_NameHashCode() { }

}

internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 6040
{
	private static readonly IEqualityComparer<string> Comparer; 
	private Dictionary<string, JToken> _dictionary; 

	public ICollection<string> Keys { get; }


	public void .ctor() { }

	private void AddKey(string key, JToken item) { }

	protected override void ClearItems() { }

	public bool Contains(string key) { }

	private void EnsureDictionary() { }

	private string GetKeyForItem(JToken item) { }

	protected override void InsertItem(int index, JToken item) { }

	protected override void RemoveItem(int index) { }

	private void RemoveKey(string key) { }

	protected override void SetItem(int index, JToken item) { }

	public bool TryGetValue(string key, out JToken value) { }

	public ICollection<string> get_Keys() { }

	public int IndexOfReference(JToken t) { }

	public bool Compare(JPropertyKeyedCollection other) { }

	private static void .cctor() { }

}

public class JsonLoadSettings // TypeDefIndex: 6041
{
	private CommentHandling _commentHandling; 
	private LineInfoHandling _lineInfoHandling; 

	public CommentHandling CommentHandling { get; }
	public LineInfoHandling LineInfoHandling { get; }


	public CommentHandling get_CommentHandling() { }

	public LineInfoHandling get_LineInfoHandling() { }

	public void .ctor() { }

}

public class JsonMergeSettings // TypeDefIndex: 6042
{

	public void .ctor() { }

}

public class JTokenEqualityComparer : IEqualityComparer<JToken> // TypeDefIndex: 6047
{

[PreserveAttribute] 
public class JTokenEqualityComparer : IEqualityComparer<JToken>

	public bool Equals(JToken x, JToken y) { }

	public int GetHashCode(JToken obj) { }

	public void .ctor() { }

}

public class JConstructor : JContainer // TypeDefIndex: 6057
{

[PreserveAttribute] 
[DefaultMemberAttribute] 
public class JConstructor : JContainer
	private string _name; 
	private readonly List<JToken> _values; 

	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public override JTokenType Type { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	internal override int IndexOfItem(JToken item) { }

	public string get_Name() { }

	public override JTokenType get_Type() { }

	public void .ctor() { }

	public void .ctor(JConstructor other) { }

	public void .ctor(string name) { }

	internal override bool DeepEquals(JToken node) { }

	internal override JToken CloneToken() { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	internal override int GetDeepHashCode() { }

	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

}

public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, IList, ICollection // TypeDefIndex: 6058
{
	internal ListChangedEventHandler _listChanged; 
	private object _syncRoot; 
	private bool _busy; 

	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	public override JToken First { get; }
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }


	protected abstract IList<JToken> get_ChildrenTokens();

	internal void .ctor() { }

	internal void .ctor(JContainer other) { }

	internal void CheckReentrancy() { }

	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	public override bool get_HasValues() { }

	internal bool ContentsEqual(JContainer container) { }

	public override JToken get_First() { }

	public override JToken get_Last() { }

	public override JEnumerable<JToken> Children() { }

	internal bool IsMultiContent(object content) { }

	internal JToken EnsureParentToken(JToken item, bool skipParentCheck) { }

	internal abstract int IndexOfItem(JToken item);

	internal virtual void InsertItem(int index, JToken item, bool skipParentCheck) { }

	internal virtual void RemoveItemAt(int index) { }

	internal virtual bool RemoveItem(JToken item) { }

	internal virtual JToken GetItem(int index) { }

	internal virtual void SetItem(int index, JToken item) { }

	internal virtual void ClearItems() { }

	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	internal virtual bool ContainsItem(JToken item) { }

	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	internal virtual void ValidateToken(JToken o, JToken existing) { }

	public virtual void Add(object content) { }

	internal void AddAndSkipParentCheck(JToken token) { }

	internal void AddInternal(int index, object content, bool skipParentCheck) { }

	internal static JToken CreateFromContent(object content) { }

	public void RemoveAll() { }

	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	internal int ContentsHashCode() { }

	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	private JToken EnsureValue(object value) { }

	private int System.Collections.IList.Add(object value) { }

	private void System.Collections.IList.Clear() { }

	private bool System.Collections.IList.Contains(object value) { }

	private int System.Collections.IList.IndexOf(object value) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private bool System.Collections.IList.get_IsFixedSize() { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.RemoveAt(int index) { }

	private object System.Collections.IList.get_Item(int index) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	public int get_Count() { }

	private object System.Collections.ICollection.get_SyncRoot() { }

}

public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, ICustomTypeDescriptor, INotifyPropertyChanging // TypeDefIndex: 6061
{
	private readonly JPropertyKeyedCollection _properties; 
	[CompilerGeneratedAttribute] 
	private PropertyChangedEventHandler PropertyChanged; 
	[CompilerGeneratedAttribute] 
	private PropertyChangingEventHandler PropertyChanging; 

	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get; }
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	public void .ctor() { }

	public void .ctor(JObject other) { }

	internal override bool DeepEquals(JToken node) { }

	internal override int IndexOfItem(JToken item) { }

	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	internal override void ValidateToken(JToken o, JToken existing) { }

	internal void InternalPropertyChanged(JProperty childProperty) { }

	internal void InternalPropertyChanging(JProperty childProperty) { }

	internal override JToken CloneToken() { }

	public override JTokenType get_Type() { }

	public JProperty Property(string name) { }

	public JToken get_Item(string propertyName) { }

	public void set_Item(string propertyName, JToken value) { }

	public static JObject Load(JsonReader reader) { }

	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	public void Add(string propertyName, JToken value) { }

	private bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { }

	private ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Keys() { }

	public bool Remove(string propertyName) { }

	public bool TryGetValue(string propertyName, out JToken value) { }

	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	internal override int GetDeepHashCode() { }

	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	protected virtual void OnPropertyChanged(string propertyName) { }

	protected virtual void OnPropertyChanging(string propertyName) { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

private sealed class JObject.<>c // TypeDefIndex: 6062
{
	public static readonly JObject.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

}

private sealed class JObject.<GetEnumerator>d__58 : IEnumerator<KeyValuePair<string, JToken>>, IDisposable, IEnumerator // TypeDefIndex: 6063
{
	private int <>1__state; 
	private KeyValuePair<string, JToken> <>2__current; 
	public JObject <>4__this; 
	private IEnumerator<JToken> <>7__wrap1; 

	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6064
{
	private readonly List<JToken> _values; 

	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	public override JTokenType get_Type() { }

	public void .ctor() { }

	public void .ctor(JArray other) { }

	public void .ctor(object content) { }

	internal override bool DeepEquals(JToken node) { }

	internal override JToken CloneToken() { }

	public static JArray Load(JsonReader reader) { }

	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	public JToken get_Item(int index) { }

	public void set_Item(int index, JToken value) { }

	internal override int IndexOfItem(JToken item) { }

	public int IndexOf(JToken item) { }

	public void Insert(int index, JToken item) { }

	public void RemoveAt(int index) { }

	public IEnumerator<JToken> GetEnumerator() { }

	public void Add(JToken item) { }

	public void Clear() { }

	public bool Contains(JToken item) { }

	public void CopyTo(JToken[] array, int arrayIndex) { }

	public bool get_IsReadOnly() { }

	public bool Remove(JToken item) { }

	internal override int GetDeepHashCode() { }

}

public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6065
{
	private readonly JToken _root; 
	private string _initialPath; 
	private JToken _parent; 
	private JToken _current; 

	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }


	public JToken get_CurrentToken() { }

	public void .ctor(JToken token) { }

	public override bool Read() { }

	private bool ReadOver(JToken t) { }

	private bool ReadToEnd() { }

	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	private bool ReadInto(JContainer c) { }

	private bool SetEnd(JContainer c) { }

	private void SetToken(JToken token) { }

	private string SafeToString(object value) { }

	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	public override string get_Path() { }

}

public class JTokenWriter : JsonWriter // TypeDefIndex: 6066
{
	private JContainer _token; 
	private JContainer _parent; 
	private JValue _value; 
	private JToken _current; 

	public JToken Token { get; }


	public JToken get_Token() { }

	public void .ctor() { }

	public override void Close() { }

	public override void WriteStartObject() { }

	private void AddParent(JContainer container) { }

	private void RemoveParent() { }

	public override void WriteStartArray() { }

	public override void WriteStartConstructor(string name) { }

	protected override void WriteEnd(JsonToken token) { }

	public override void WritePropertyName(string name) { }

	private void AddValue(object value, JsonToken token) { }

	internal void AddValue(JValue value, JsonToken token) { }

	public override void WriteValue(object value) { }

	public override void WriteNull() { }

	public override void WriteUndefined() { }

	public override void WriteRaw(string json) { }

	public override void WriteComment(string text) { }

	public override void WriteValue(string value) { }

	public override void WriteValue(int value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(uint value) { }

	public override void WriteValue(long value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(ulong value) { }

	public override void WriteValue(float value) { }

	public override void WriteValue(double value) { }

	public override void WriteValue(bool value) { }

	public override void WriteValue(short value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(ushort value) { }

	public override void WriteValue(char value) { }

	public override void WriteValue(byte value) { }

	[CLSCompliantAttribute] 
	public override void WriteValue(sbyte value) { }

	public override void WriteValue(Decimal value) { }

	public override void WriteValue(DateTime value) { }

	public override void WriteValue(DateTimeOffset value) { }

	public override void WriteValue(byte[] value) { }

	public override void WriteValue(TimeSpan value) { }

	public override void WriteValue(Guid value) { }

	public override void WriteValue(Uri value) { }

	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

}

public abstract class JToken : IJEnumerable<JToken>, IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable // TypeDefIndex: 6067
{
	private JContainer _parent; 
	private JToken _previous; 
	private JToken _next; 
	private object _annotations; 
	private static readonly JTokenType[] BooleanTypes; 
	private static readonly JTokenType[] NumberTypes; 
	private static readonly JTokenType[] StringTypes; 
	private static readonly JTokenType[] GuidTypes; 
	private static readonly JTokenType[] TimeSpanTypes; 
	private static readonly JTokenType[] UriTypes; 
	private static readonly JTokenType[] CharTypes; 
	private static readonly JTokenType[] DateTimeTypes; 
	private static readonly JTokenType[] BytesTypes; 

	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	public JToken Next { get; set; }
	public JToken Previous { get; set; }
	public string Path { get; }
	public virtual JToken First { get; }
	public virtual JToken Last { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }


	[DebuggerStepThroughAttribute] 
	public JContainer get_Parent() { }

	internal void set_Parent(JContainer value) { }

	public JToken get_Root() { }

	internal abstract JToken CloneToken();

	internal abstract bool DeepEquals(JToken node);

	public abstract JTokenType get_Type();

	public abstract bool get_HasValues();

	public static bool DeepEquals(JToken t1, JToken t2) { }

	public JToken get_Next() { }

	internal void set_Next(JToken value) { }

	public JToken get_Previous() { }

	internal void set_Previous(JToken value) { }

	public string get_Path() { }

	internal void .ctor() { }

	public virtual JToken get_First() { }

	public virtual JToken get_Last() { }

	public virtual JEnumerable<JToken> Children() { }

	public void Remove() { }

	public void Replace(JToken value) { }

	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	public override string ToString() { }

	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	private static JValue EnsureValue(JToken value) { }

	private static string GetType(JToken token) { }

	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	public static bool op_Explicit(JToken value) { }

	public static DateTimeOffset op_Explicit(JToken value) { }

	public static Nullable<bool> op_Explicit(JToken value) { }

	public static long op_Explicit(JToken value) { }

	public static Nullable<DateTime> op_Explicit(JToken value) { }

	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	public static Nullable<Decimal> op_Explicit(JToken value) { }

	public static Nullable<double> op_Explicit(JToken value) { }

	public static Nullable<char> op_Explicit(JToken value) { }

	public static int op_Explicit(JToken value) { }

	public static short op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static char op_Explicit(JToken value) { }

	public static byte op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static sbyte op_Explicit(JToken value) { }

	public static Nullable<int> op_Explicit(JToken value) { }

	public static Nullable<short> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static Nullable<ushort> op_Explicit(JToken value) { }

	public static Nullable<byte> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	public static DateTime op_Explicit(JToken value) { }

	public static Nullable<long> op_Explicit(JToken value) { }

	public static Nullable<float> op_Explicit(JToken value) { }

	public static Decimal op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static Nullable<uint> op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static Nullable<ulong> op_Explicit(JToken value) { }

	public static double op_Explicit(JToken value) { }

	public static float op_Explicit(JToken value) { }

	public static string op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static uint op_Explicit(JToken value) { }

	[CLSCompliantAttribute] 
	public static ulong op_Explicit(JToken value) { }

	public static Guid op_Explicit(JToken value) { }

	public static Nullable<Guid> op_Explicit(JToken value) { }

	public static TimeSpan op_Explicit(JToken value) { }

	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	public static Uri op_Explicit(JToken value) { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	internal abstract int GetDeepHashCode();

	public JsonReader CreateReader() { }

	public T ToObject<T>() { }
	/* GenericInstMethod :
	|
	|-JToken.ToObject<UITwitchTrophy.TrophyPage>
	|-JToken.ToObject<object>
	*/

	public object ToObject(Type objectType) { }

	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	public static JToken ReadFrom(JsonReader reader) { }

	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	public static JToken Parse(string json) { }

	public static JToken Parse(string json, JsonLoadSettings settings) { }

	public static JToken Load(JsonReader reader, JsonLoadSettings settings) { }

	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	internal void SetLineInfo(int lineNumber, int linePosition) { }

	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	private object System.ICloneable.Clone() { }

	public JToken DeepClone() { }

	public void AddAnnotation(object annotation) { }

	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-JToken.Annotation<JToken.LineInfoAnnotation>
	|-JToken.Annotation<object>
	*/

	private static void .cctor() { }

}

private class JToken.LineInfoAnnotation // TypeDefIndex: 6068
{
	internal readonly int LineNumber; 
	internal readonly int LinePosition; 


	public void .ctor(int lineNumber, int linePosition) { }

}

public class JProperty : JContainer // TypeDefIndex: 6074
{

[CompilerGeneratedAttribute] 
private sealed class JToken.<AfterSelf>d__42

[CompilerGeneratedAttribute] 
private sealed class JToken.<BeforeSelf>d__43

[CompilerGeneratedAttribute] 
private sealed class JToken.<Annotations>d__171<T>

[CompilerGeneratedAttribute] 
private sealed class JToken.<Annotations>d__172

[PreserveAttribute] 
public class JProperty : JContainer
	private readonly JProperty.JPropertyList _content; 
	private readonly string _name; 

	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }


	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThroughAttribute] 
	public string get_Name() { }

	[DebuggerStepThroughAttribute] 
	public JToken get_Value() { }

	public void set_Value(JToken value) { }

	public void .ctor(JProperty other) { }

	internal override JToken GetItem(int index) { }

	internal override void SetItem(int index, JToken item) { }

	internal override bool RemoveItem(JToken item) { }

	internal override void RemoveItemAt(int index) { }

	internal override int IndexOfItem(JToken item) { }

	internal override void InsertItem(int index, JToken item, bool skipParentCheck) { }

	internal override bool ContainsItem(JToken item) { }

	internal override void ClearItems() { }

	internal override bool DeepEquals(JToken node) { }

	internal override JToken CloneToken() { }

	[DebuggerStepThroughAttribute] 
	public override JTokenType get_Type() { }

	internal void .ctor(string name) { }

	public void .ctor(string name, object content) { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	internal override int GetDeepHashCode() { }

	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }

}

private class JProperty.JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6075
{
	internal JToken _token; 

	public int Count { get; }
	public bool IsReadOnly { get; }
	public JToken Item { get; set; }


	public IEnumerator<JToken> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Add(JToken item) { }

	public void Clear() { }

	public bool Contains(JToken item) { }

	public void CopyTo(JToken[] array, int arrayIndex) { }

	public bool Remove(JToken item) { }

	public int get_Count() { }

	public bool get_IsReadOnly() { }

	public int IndexOf(JToken item) { }

	public void Insert(int index, JToken item) { }

	public void RemoveAt(int index) { }

	public JToken get_Item(int index) { }

	public void set_Item(int index, JToken value) { }

	public void .ctor() { }

}

private sealed class JProperty.JPropertyList.<GetEnumerator>d__1 : IEnumerator<JToken>, IDisposable, IEnumerator // TypeDefIndex: 6076
{
	private int <>1__state; 
	private JToken <>2__current; 
	public JProperty.JPropertyList <>4__this; 

	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public enum JTokenType // TypeDefIndex: 6077
{
	public int value__; 
	public const JTokenType None = 0;
	public const JTokenType Object = 1;
	public const JTokenType Array = 2;
	public const JTokenType Constructor = 3;
	public const JTokenType Property = 4;
	public const JTokenType Comment = 5;
	public const JTokenType Integer = 6;
	public const JTokenType Float = 7;
	public const JTokenType String = 8;
	public const JTokenType Boolean = 9;
	public const JTokenType Null = 10;
	public const JTokenType Undefined = 11;
	public const JTokenType Date = 12;
	public const JTokenType Raw = 13;
	public const JTokenType Bytes = 14;
	public const JTokenType Guid = 15;
	public const JTokenType Uri = 16;
	public const JTokenType TimeSpan = 17;

}

public class JValue : JToken, IFormattable, IComparable, IConvertible // TypeDefIndex: 6078
{
	private JTokenType _valueType; 
	private object _value; 

	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	public object Value { get; }


	internal void .ctor(object value, JTokenType type) { }

	public void .ctor(JValue other) { }

	public void .ctor(object value) { }

	internal override bool DeepEquals(JToken node) { }

	public override bool get_HasValues() { }

	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	private static int CompareFloat(object objA, object objB) { }

	internal override JToken CloneToken() { }

	public static JValue CreateComment(string value) { }

	public static JValue CreateNull() { }

	public static JValue CreateUndefined() { }

	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	public override JTokenType get_Type() { }

	public object get_Value() { }

	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	internal override int GetDeepHashCode() { }

	private static bool ValuesEquals(JValue v1, JValue v2) { }

	public bool Equals(JValue other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public string ToString(IFormatProvider formatProvider) { }

	public string ToString(string format, IFormatProvider formatProvider) { }

	private int System.IComparable.CompareTo(object obj) { }

	private TypeCode System.IConvertible.GetTypeCode() { }

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

	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }

}

public static class JSON // TypeDefIndex: 13274
{
	private static readonly Type includeAttrType; 
	private static readonly Type excludeAttrType; 
	private static readonly Type decodeAliasAttrType; 
	private static readonly Dictionary<string, Type> typeCache; 
	private const BindingFlags instanceBindingFlags = 52;
	private const BindingFlags staticBindingFlags = 56;
	private static readonly MethodInfo decodeTypeMethod; 
	private static readonly MethodInfo decodeListMethod; 
	private static readonly MethodInfo decodeDictionaryMethod; 
	private static readonly MethodInfo decodeArrayMethod; 
	private static readonly MethodInfo decodeMultiRankArrayMethod; 


	public static Variant Load(string json) { }

	public static string Dump(object data) { }

	public static string Dump(object data, EncodeOptions options) { }

	public static void MakeInto<T>(Variant data, out T item) { }
	/* GenericInstMethod :
	|
	|-JSON.MakeInto<object>
	*/

	private static Type FindType(string fullName) { }

	[PreserveAttribute] 
	private static T DecodeType<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-JSON.DecodeType<bool>
	|
	|-JSON.DecodeType<Decimal>
	|
	|-JSON.DecodeType<double>
	|
	|-JSON.DecodeType<short>
	|
	|-JSON.DecodeType<int>
	|
	|-JSON.DecodeType<long>
	|
	|-JSON.DecodeType<object>
	|
	|-JSON.DecodeType<float>
	|
	|-JSON.DecodeType<ushort>
	|
	|-JSON.DecodeType<uint>
	|
	|-JSON.DecodeType<ulong>
	*/

	[PreserveAttribute] 
	private static List<T> DecodeList<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-JSON.DecodeList<bool>
	|
	|-JSON.DecodeList<Decimal>
	|
	|-JSON.DecodeList<double>
	|
	|-JSON.DecodeList<short>
	|
	|-JSON.DecodeList<int>
	|
	|-JSON.DecodeList<long>
	|
	|-JSON.DecodeList<object>
	|
	|-JSON.DecodeList<float>
	|
	|-JSON.DecodeList<ushort>
	|
	|-JSON.DecodeList<uint>
	|
	|-JSON.DecodeList<ulong>
	*/

	[PreserveAttribute] 
	private static Dictionary<TKey, TValue> DecodeDictionary<TKey, TValue>(Variant data) { }
	/* GenericInstMethod :
	|
	|-JSON.DecodeDictionary<bool, bool>
	|
	|-JSON.DecodeDictionary<bool, Decimal>
	|
	|-JSON.DecodeDictionary<bool, double>
	|
	|-JSON.DecodeDictionary<bool, short>
	|
	|-JSON.DecodeDictionary<bool, int>
	|
	|-JSON.DecodeDictionary<bool, long>
	|
	|-JSON.DecodeDictionary<bool, object>
	|
	|-JSON.DecodeDictionary<bool, float>
	|
	|-JSON.DecodeDictionary<bool, ushort>
	|
	|-JSON.DecodeDictionary<bool, uint>
	|
	|-JSON.DecodeDictionary<bool, ulong>
	|
	|-JSON.DecodeDictionary<Decimal, bool>
	|
	|-JSON.DecodeDictionary<Decimal, Decimal>
	|
	|-JSON.DecodeDictionary<Decimal, double>
	|
	|-JSON.DecodeDictionary<Decimal, short>
	|
	|-JSON.DecodeDictionary<Decimal, int>
	|
	|-JSON.DecodeDictionary<Decimal, long>
	|
	|-JSON.DecodeDictionary<Decimal, object>
	|
	|-JSON.DecodeDictionary<Decimal, float>
	|
	|-JSON.DecodeDictionary<Decimal, ushort>
	|
	|-JSON.DecodeDictionary<Decimal, uint>
	|
	|-JSON.DecodeDictionary<Decimal, ulong>
	|
	|-JSON.DecodeDictionary<double, bool>
	|
	|-JSON.DecodeDictionary<double, Decimal>
	|
	|-JSON.DecodeDictionary<double, double>
	|
	|-JSON.DecodeDictionary<double, short>
	|
	|-JSON.DecodeDictionary<double, int>
	|
	|-JSON.DecodeDictionary<double, long>
	|
	|-JSON.DecodeDictionary<double, object>
	|
	|-JSON.DecodeDictionary<double, float>
	|
	|-JSON.DecodeDictionary<double, ushort>
	|
	|-JSON.DecodeDictionary<double, uint>
	|
	|-JSON.DecodeDictionary<double, ulong>
	|
	|-JSON.DecodeDictionary<short, bool>
	|
	|-JSON.DecodeDictionary<short, Decimal>
	|
	|-JSON.DecodeDictionary<short, double>
	|
	|-JSON.DecodeDictionary<short, short>
	|
	|-JSON.DecodeDictionary<short, int>
	|
	|-JSON.DecodeDictionary<short, long>
	|
	|-JSON.DecodeDictionary<short, object>
	|
	|-JSON.DecodeDictionary<short, float>
	|
	|-JSON.DecodeDictionary<short, ushort>
	|
	|-JSON.DecodeDictionary<short, uint>
	|
	|-JSON.DecodeDictionary<short, ulong>
	|
	|-JSON.DecodeDictionary<int, bool>
	|
	|-JSON.DecodeDictionary<int, Decimal>
	|
	|-JSON.DecodeDictionary<int, double>
	|
	|-JSON.DecodeDictionary<int, short>
	|
	|-JSON.DecodeDictionary<int, int>
	|
	|-JSON.DecodeDictionary<int, long>
	|
	|-JSON.DecodeDictionary<int, object>
	|
	|-JSON.DecodeDictionary<int, float>
	|
	|-JSON.DecodeDictionary<int, ushort>
	|
	|-JSON.DecodeDictionary<int, uint>
	|
	|-JSON.DecodeDictionary<int, ulong>
	|
	|-JSON.DecodeDictionary<long, bool>
	|
	|-JSON.DecodeDictionary<long, Decimal>
	|
	|-JSON.DecodeDictionary<long, double>
	|
	|-JSON.DecodeDictionary<long, short>
	|
	|-JSON.DecodeDictionary<long, int>
	|
	|-JSON.DecodeDictionary<long, long>
	|
	|-JSON.DecodeDictionary<long, object>
	|
	|-JSON.DecodeDictionary<long, float>
	|
	|-JSON.DecodeDictionary<long, ushort>
	|
	|-JSON.DecodeDictionary<long, uint>
	|
	|-JSON.DecodeDictionary<long, ulong>
	|
	|-JSON.DecodeDictionary<object, bool>
	|
	|-JSON.DecodeDictionary<object, Decimal>
	|
	|-JSON.DecodeDictionary<object, double>
	|
	|-JSON.DecodeDictionary<object, short>
	|
	|-JSON.DecodeDictionary<object, int>
	|
	|-JSON.DecodeDictionary<object, long>
	|
	|-JSON.DecodeDictionary<object, object>
	|
	|-JSON.DecodeDictionary<object, float>
	|
	|-JSON.DecodeDictionary<object, ushort>
	|
	|-JSON.DecodeDictionary<object, uint>
	|
	|-JSON.DecodeDictionary<object, ulong>
	|
	|-JSON.DecodeDictionary<float, bool>
	|
	|-JSON.DecodeDictionary<float, Decimal>
	|
	|-JSON.DecodeDictionary<float, double>
	|
	|-JSON.DecodeDictionary<float, short>
	|
	|-JSON.DecodeDictionary<float, int>
	|
	|-JSON.DecodeDictionary<float, long>
	|
	|-JSON.DecodeDictionary<float, object>
	|
	|-JSON.DecodeDictionary<float, float>
	|
	|-JSON.DecodeDictionary<float, ushort>
	|
	|-JSON.DecodeDictionary<float, uint>
	|
	|-JSON.DecodeDictionary<float, ulong>
	|
	|-JSON.DecodeDictionary<ushort, bool>
	|
	|-JSON.DecodeDictionary<ushort, Decimal>
	|
	|-JSON.DecodeDictionary<ushort, double>
	|
	|-JSON.DecodeDictionary<ushort, short>
	|
	|-JSON.DecodeDictionary<ushort, int>
	|
	|-JSON.DecodeDictionary<ushort, long>
	|
	|-JSON.DecodeDictionary<ushort, object>
	|
	|-JSON.DecodeDictionary<ushort, float>
	|
	|-JSON.DecodeDictionary<ushort, ushort>
	|
	|-JSON.DecodeDictionary<ushort, uint>
	|
	|-JSON.DecodeDictionary<ushort, ulong>
	|
	|-JSON.DecodeDictionary<uint, bool>
	|
	|-JSON.DecodeDictionary<uint, Decimal>
	|
	|-JSON.DecodeDictionary<uint, double>
	|
	|-JSON.DecodeDictionary<uint, short>
	|
	|-JSON.DecodeDictionary<uint, int>
	|
	|-JSON.DecodeDictionary<uint, long>
	|
	|-JSON.DecodeDictionary<uint, object>
	|
	|-JSON.DecodeDictionary<uint, float>
	|
	|-JSON.DecodeDictionary<uint, ushort>
	|
	|-JSON.DecodeDictionary<uint, uint>
	|
	|-JSON.DecodeDictionary<uint, ulong>
	|
	|-JSON.DecodeDictionary<ulong, bool>
	|
	|-JSON.DecodeDictionary<ulong, Decimal>
	|
	|-JSON.DecodeDictionary<ulong, double>
	|
	|-JSON.DecodeDictionary<ulong, short>
	|
	|-JSON.DecodeDictionary<ulong, int>
	|
	|-JSON.DecodeDictionary<ulong, long>
	|
	|-JSON.DecodeDictionary<ulong, object>
	|
	|-JSON.DecodeDictionary<ulong, float>
	|
	|-JSON.DecodeDictionary<ulong, ushort>
	|
	|-JSON.DecodeDictionary<ulong, uint>
	|
	|-JSON.DecodeDictionary<ulong, ulong>
	*/

	[PreserveAttribute] 
	private static T[] DecodeArray<T>(Variant data) { }
	/* GenericInstMethod :
	|
	|-JSON.DecodeArray<bool>
	|
	|-JSON.DecodeArray<Decimal>
	|
	|-JSON.DecodeArray<double>
	|
	|-JSON.DecodeArray<short>
	|
	|-JSON.DecodeArray<int>
	|
	|-JSON.DecodeArray<long>
	|
	|-JSON.DecodeArray<object>
	|
	|-JSON.DecodeArray<float>
	|
	|-JSON.DecodeArray<ushort>
	|
	|-JSON.DecodeArray<uint>
	|
	|-JSON.DecodeArray<ulong>
	*/

	[PreserveAttribute] 
	private static void DecodeMultiRankArray<T>(ProxyArray arrayData, Array array, int arrayRank, int[] indices) { }
	/* GenericInstMethod :
	|
	|-JSON.DecodeMultiRankArray<object>
	*/

	[PreserveAttribute] 
	public static void SupportTypeForAOT<T>() { }
	/* GenericInstMethod :
	|
	|-JSON.SupportTypeForAOT<bool>
	|
	|-JSON.SupportTypeForAOT<Decimal>
	|
	|-JSON.SupportTypeForAOT<double>
	|
	|-JSON.SupportTypeForAOT<short>
	|
	|-JSON.SupportTypeForAOT<int>
	|
	|-JSON.SupportTypeForAOT<long>
	|
	|-JSON.SupportTypeForAOT<object>
	|-JSON.SupportTypeForAOT<string>
	|
	|-JSON.SupportTypeForAOT<float>
	|
	|-JSON.SupportTypeForAOT<ushort>
	|
	|-JSON.SupportTypeForAOT<uint>
	|
	|-JSON.SupportTypeForAOT<ulong>
	*/

	[PreserveAttribute] 
	private static void SupportValueTypesForAOT() { }

	private static void .cctor() { }

}


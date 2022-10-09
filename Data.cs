public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 201
{
	public static readonly DBNull Value; 


	private void .ctor() { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public TypeCode GetTypeCode() { }

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

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	private static void .cctor() { }

}

internal struct DataCollector // TypeDefIndex: 1509
{
	[ThreadStaticAttribute] 
	internal static DataCollector ThreadInstance; 
	private byte* scratchEnd; 
	private EventSource.EventData* datasEnd; 
	private GCHandle* pinsEnd; 
	private EventSource.EventData* datasStart; 
	private byte* scratch; 
	private EventSource.EventData* datas; 
	private GCHandle* pins; 
	private byte[] buffer; 
	private int bufferPos; 
	private int bufferNesting; 
	private bool writingScalars; 


	internal void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount) { }

	internal void Disable() { }

	internal EventSource.EventData* Finish() { }

	internal void AddScalar(void* value, int size) { }

	internal void AddBinary(string value, int size) { }

	internal void AddBinary(Array value, int size) { }

	internal void AddArray(Array value, int length, int itemSize) { }

	internal int BeginBufferedArray() { }

	internal void EndBufferedArray(int bookmark, int count) { }

	internal void BeginBuffered() { }

	internal void EndBuffered() { }

	private void EnsureBuffer() { }

	private void EnsureBuffer(int additionalSize) { }

	private void GrowBuffer(int required) { }

	private void PinArray(object value, int size) { }

	private void ScalarsBegin() { }

	private void ScalarsEnd() { }

}

internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 2179
{
	private XmlSchemaDatatypeVariety variety; 
	private RestrictionFacets restriction; 
	private DatatypeImplementation baseType; 
	private XmlValueConverter valueConverter; 
	private XmlSchemaType parentSchemaType; 
	private static Hashtable builtinTypes; 
	private static XmlSchemaSimpleType[] enumToTypeCode; 
	private static XmlSchemaSimpleType anySimpleType; 
	private static XmlSchemaSimpleType anyAtomicType; 
	private static XmlSchemaSimpleType untypedAtomicType; 
	private static XmlSchemaSimpleType yearMonthDurationType; 
	private static XmlSchemaSimpleType dayTimeDurationType; 
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; 
	private static XmlSchemaSimpleType tokenTypeV1Compat; 
	internal static XmlQualifiedName QnAnySimpleType; 
	internal static XmlQualifiedName QnAnyType; 
	internal static FacetsChecker stringFacetsChecker; 
	internal static FacetsChecker miscFacetsChecker; 
	internal static FacetsChecker numeric2FacetsChecker; 
	internal static FacetsChecker binaryFacetsChecker; 
	internal static FacetsChecker dateTimeFacetsChecker; 
	internal static FacetsChecker durationFacetsChecker; 
	internal static FacetsChecker listFacetsChecker; 
	internal static FacetsChecker qnameFacetsChecker; 
	internal static FacetsChecker unionFacetsChecker; 
	private static readonly DatatypeImplementation c_anySimpleType; 
	private static readonly DatatypeImplementation c_anyURI; 
	private static readonly DatatypeImplementation c_base64Binary; 
	private static readonly DatatypeImplementation c_boolean; 
	private static readonly DatatypeImplementation c_byte; 
	private static readonly DatatypeImplementation c_char; 
	private static readonly DatatypeImplementation c_date; 
	private static readonly DatatypeImplementation c_dateTime; 
	private static readonly DatatypeImplementation c_dateTimeNoTz; 
	private static readonly DatatypeImplementation c_dateTimeTz; 
	private static readonly DatatypeImplementation c_day; 
	private static readonly DatatypeImplementation c_decimal; 
	private static readonly DatatypeImplementation c_double; 
	private static readonly DatatypeImplementation c_doubleXdr; 
	private static readonly DatatypeImplementation c_duration; 
	private static readonly DatatypeImplementation c_ENTITY; 
	private static readonly DatatypeImplementation c_ENTITIES; 
	private static readonly DatatypeImplementation c_ENUMERATION; 
	private static readonly DatatypeImplementation c_fixed; 
	private static readonly DatatypeImplementation c_float; 
	private static readonly DatatypeImplementation c_floatXdr; 
	private static readonly DatatypeImplementation c_hexBinary; 
	private static readonly DatatypeImplementation c_ID; 
	private static readonly DatatypeImplementation c_IDREF; 
	private static readonly DatatypeImplementation c_IDREFS; 
	private static readonly DatatypeImplementation c_int; 
	private static readonly DatatypeImplementation c_integer; 
	private static readonly DatatypeImplementation c_language; 
	private static readonly DatatypeImplementation c_long; 
	private static readonly DatatypeImplementation c_month; 
	private static readonly DatatypeImplementation c_monthDay; 
	private static readonly DatatypeImplementation c_Name; 
	private static readonly DatatypeImplementation c_NCName; 
	private static readonly DatatypeImplementation c_negativeInteger; 
	private static readonly DatatypeImplementation c_NMTOKEN; 
	private static readonly DatatypeImplementation c_NMTOKENS; 
	private static readonly DatatypeImplementation c_nonNegativeInteger; 
	private static readonly DatatypeImplementation c_nonPositiveInteger; 
	private static readonly DatatypeImplementation c_normalizedString; 
	private static readonly DatatypeImplementation c_NOTATION; 
	private static readonly DatatypeImplementation c_positiveInteger; 
	private static readonly DatatypeImplementation c_QName; 
	private static readonly DatatypeImplementation c_QNameXdr; 
	private static readonly DatatypeImplementation c_short; 
	private static readonly DatatypeImplementation c_string; 
	private static readonly DatatypeImplementation c_time; 
	private static readonly DatatypeImplementation c_timeNoTz; 
	private static readonly DatatypeImplementation c_timeTz; 
	private static readonly DatatypeImplementation c_token; 
	private static readonly DatatypeImplementation c_unsignedByte; 
	private static readonly DatatypeImplementation c_unsignedInt; 
	private static readonly DatatypeImplementation c_unsignedLong; 
	private static readonly DatatypeImplementation c_unsignedShort; 
	private static readonly DatatypeImplementation c_uuid; 
	private static readonly DatatypeImplementation c_year; 
	private static readonly DatatypeImplementation c_yearMonth; 
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; 
	internal static readonly DatatypeImplementation c_tokenV1Compat; 
	private static readonly DatatypeImplementation c_anyAtomicType; 
	private static readonly DatatypeImplementation c_dayTimeDuration; 
	private static readonly DatatypeImplementation c_untypedAtomicType; 
	private static readonly DatatypeImplementation c_yearMonthDuration; 
	private static readonly DatatypeImplementation[] c_tokenizedTypes; 
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; 
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; 
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; 

	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal override bool HasLexicalFacets { get; }
	internal override bool HasValueFacets { get; }
	protected DatatypeImplementation Base { get; }
	internal abstract Type ListValueType { get; }
	internal abstract RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }


	private static void .cctor() { }

	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	internal static DatatypeImplementation FromXdrName(string name) { }

	private static DatatypeImplementation FromTypeName(string name) { }

	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	internal static void CreateBuiltinTypes() { }

	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	internal override bool IsEqual(object o1, object o2) { }

	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	internal override XmlValueConverter get_ValueConverter() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public override Type get_ValueType() { }

	public override XmlSchemaDatatypeVariety get_Variety() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override RestrictionFacets get_Restriction() { }

	internal override bool get_HasLexicalFacets() { }

	internal override bool get_HasValueFacets() { }

	protected DatatypeImplementation get_Base() { }

	internal abstract Type get_ListValueType();

	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	internal string GetTypeName() { }

	protected int Compare(byte[] value1, byte[] value2) { }

	protected void .ctor() { }

}

private class DatatypeImplementation.SchemaDatatypeMap : IComparable // TypeDefIndex: 2180
{
	private string name; 
	private DatatypeImplementation type; 
	private int parentIndex; 

	public string Name { get; }
	public int ParentIndex { get; }


	internal void .ctor(string name, DatatypeImplementation type) { }

	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	public string get_Name() { }

	public int get_ParentIndex() { }

	public int CompareTo(object obj) { }

}

internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 2181
{
	private DatatypeImplementation itemType; 
	private int minListSize; 

	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	public override XmlTokenizedType get_TokenizedType() { }

	internal override Type get_ListValueType() { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 2182
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private XmlSchemaSimpleType[] types; 

	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal void .ctor(XmlSchemaSimpleType[] types) { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override FacetsChecker get_FacetsChecker() { }

	internal override Type get_ListValueType() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	internal bool HasAtomicMembers() { }

	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	private static void .cctor() { }

}

internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 2183
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override Type get_ValueType() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override Type get_ListValueType() { }

	public override XmlTokenizedType get_TokenizedType() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 2184
{
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 2185
{
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 2186
{
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

}

internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 2187
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 2188
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 2189
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 2190
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 2191
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 2192
{
	public override XmlTypeCode TypeCode { get; }


	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 2193
{
	public override XmlTypeCode TypeCode { get; }


	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 2194
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private XsdDateTimeFlags dateTimeFlags; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	private static void .cctor() { }

}

internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2195
{

	internal void .ctor() { }

}

internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2196
{

	internal void .ctor() { }

}

internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 2197
{

	internal void .ctor() { }

}

internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2198
{

	internal void .ctor() { }

}

internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2199
{

	internal void .ctor() { }

}

internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 2200
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 2201
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 2202
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 2203
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 2204
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 2205
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 2206
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 2207
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 2208
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 2209
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override Type get_ValueType() { }

	internal override bool get_HasValueFacets() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 2210
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 2211
{
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override bool get_HasValueFacets() { }

	public void .ctor() { }

}

internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 2212
{
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override bool get_HasValueFacets() { }

	public void .ctor() { }

}

internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 2213
{
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public void .ctor() { }

}

internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 2214
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_language : Datatype_token // TypeDefIndex: 2215
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 2216
{
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_Name : Datatype_token // TypeDefIndex: 2217
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 2218
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

}

internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 2219
{
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 2220
{
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 2221
{
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 2222
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 2223
{
	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

}

internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 2224
{
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override bool get_HasValueFacets() { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 2225
{
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_long : Datatype_integer // TypeDefIndex: 2226
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	internal override bool get_HasValueFacets() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_int : Datatype_long // TypeDefIndex: 2227
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_short : Datatype_int // TypeDefIndex: 2228
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_byte : Datatype_short // TypeDefIndex: 2229
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 2230
{
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override bool get_HasValueFacets() { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 2231
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 2232
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 2233
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 2234
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	internal override int Compare(object value1, object value2) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 2235
{
	private static readonly FacetsChecker numeric10FacetsChecker; 

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 2236
{

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	public void .ctor() { }

}

internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 2237
{

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	public void .ctor() { }

}

internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 2238
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }


	public override XmlTokenizedType get_TokenizedType() { }

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 2239
{
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 2240
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 2241
{

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

}

internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 2242
{
	private static readonly Type atomicValueType; 
	private static readonly Type listValueType; 

	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }


	public override Type get_ValueType() { }

	internal override Type get_ListValueType() { }

	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	internal override int Compare(object value1, object value2) { }

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public sealed class DataUtility // TypeDefIndex: 3578
{

	public static Vector4 GetInnerUV(Sprite sprite) { }

	public static Vector4 GetOuterUV(Sprite sprite) { }

	public static Vector4 GetPadding(Sprite sprite) { }

	public static Vector2 GetMinSize(Sprite sprite) { }

}

internal class DataCommonEventSource : EventSource // TypeDefIndex: 4174
{
	internal static readonly DataCommonEventSource Log; 
	private static long s_nextScopeId; 


	[EventAttribute] 
	internal void Trace(string message) { }

	[NonEventAttribute] 
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<Exception>
	|-DataCommonEventSource.Trace<object>
	|
	|-DataCommonEventSource.Trace<int>
	*/

	[NonEventAttribute] 
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-DataCommonEventSource.Trace<int, ListChangedType>
	|-DataCommonEventSource.Trace<int, MappingType>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-DataCommonEventSource.Trace<int, int>
	|
	|-DataCommonEventSource.Trace<int, long>
	|
	|-DataCommonEventSource.Trace<int, object>
	|-DataCommonEventSource.Trace<int, string>
	|
	|-DataCommonEventSource.Trace<object, object>
	*/

	[NonEventAttribute] 
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-DataCommonEventSource.Trace<int, int, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, DataViewRowState>
	|
	|-DataCommonEventSource.Trace<int, object, object>
	|-DataCommonEventSource.Trace<int, string, string>
	|
	|-DataCommonEventSource.Trace<object, object, object>
	*/

	[NonEventAttribute] 
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, string, DataViewRowState>
	|-DataCommonEventSource.Trace<int, string, string, MappingType>
	|
	|-DataCommonEventSource.Trace<object, object, object, object>
	*/

	[NonEventAttribute] 
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|-DataCommonEventSource.Trace<int, string, int, int, bool>
	|
	|-DataCommonEventSource.Trace<object, object, object, object, object>
	*/

	[NonEventAttribute] 
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-DataCommonEventSource.Trace<object, object, object, object, object, object, object>
	*/

	[EventAttribute] 
	internal long EnterScope(string message) { }

	[NonEventAttribute] 
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.EnterScope<int>
	|
	|-DataCommonEventSource.EnterScope<object>
	*/

	[NonEventAttribute] 
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-DataCommonEventSource.EnterScope<int, SchemaFormat>
	|-DataCommonEventSource.EnterScope<int, XmlReadMode>
	|-DataCommonEventSource.EnterScope<int, XmlWriteMode>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-DataCommonEventSource.EnterScope<int, object>
	|-DataCommonEventSource.EnterScope<int, string>
	|
	|-DataCommonEventSource.EnterScope<object, object>
	*/

	[NonEventAttribute] 
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.EnterScope<int, XmlReadMode, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-DataCommonEventSource.EnterScope<int, int, object>
	|-DataCommonEventSource.EnterScope<int, int, string>
	|
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|-DataCommonEventSource.EnterScope<int, string, bool>
	|
	|-DataCommonEventSource.EnterScope<object, object, object>
	*/

	[NonEventAttribute] 
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.EnterScope<int, int, bool, MissingSchemaAction>
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-DataCommonEventSource.EnterScope<object, object, object, object>
	*/

	[EventAttribute] 
	internal void ExitScope(long scopeId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class DataColumn : MarshalByValueComponent // TypeDefIndex: 4184
{
	private bool _allowNull; 
	private string _caption; 
	private string _columnName; 
	private Type _dataType; 
	private StorageType _storageType; 
	internal object _defaultValue; 
	private DataSetDateTime _dateTimeMode; 
	private DataExpression _expression; 
	private int _maxLength; 
	private int _ordinal; 
	private bool _readOnly; 
	internal Index _sortIndex; 
	internal DataTable _table; 
	private bool _unique; 
	internal MappingType _columnMapping; 
	internal int _hashCode; 
	internal int _errors; 
	private bool _isSqlType; 
	private bool _implementsINullable; 
	private bool _implementsIChangeTracking; 
	private bool _implementsIRevertibleChangeTracking; 
	private bool _implementsIXMLSerializable; 
	private bool _defaultValueIsNull; 
	internal List<DataColumn> _dependentColumns; 
	internal PropertyCollection _extendedProperties; 
	private DataStorage _storage; 
	private AutoIncrementValue _autoInc; 
	internal string _columnUri; 
	private string _columnPrefix; 
	internal string _encodedColumnName; 
	internal SimpleType _simpleType; 
	private static int s_objectTypeCount; 
	private readonly int _objectID; 
	[CompilerGeneratedAttribute] 
	private string <XmlDataType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PropertyChangedEventHandler PropertyChanging; 

	[DefaultValueAttribute] 
	public bool AllowDBNull { get; set; }
	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValueAttribute] 
	public long AutoIncrementSeed { get; set; }
	[DefaultValueAttribute] 
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValueAttribute] 
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
	[TypeConverterAttribute] 
	public Type DataType { get; set; }
	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverterAttribute] 
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
	public string Expression { get; set; }
	[BrowsableAttribute] 
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValueAttribute] 
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	public int Ordinal { get; }
	[DefaultValueAttribute] 
	public bool ReadOnly { get; set; }
	[DebuggerBrowsableAttribute] 
	private Index SortIndex { get; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibilityAttribute] 
	[DefaultValueAttribute] 
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValueAttribute] 
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }


	public void .ctor() { }

	public void .ctor(string columnName, Type dataType) { }

	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	private void UpdateColumnType(Type type, StorageType typeCode) { }

	public bool get_AllowDBNull() { }

	public void set_AllowDBNull(bool value) { }

	public bool get_AutoIncrement() { }

	public void set_AutoIncrement(bool value) { }

	internal object get_AutoIncrementCurrent() { }

	internal void set_AutoIncrementCurrent(object value) { }

	internal AutoIncrementValue get_AutoInc() { }

	public long get_AutoIncrementSeed() { }

	public void set_AutoIncrementSeed(long value) { }

	public long get_AutoIncrementStep() { }

	public void set_AutoIncrementStep(long value) { }

	public string get_Caption() { }

	public void set_Caption(string value) { }

	public string get_ColumnName() { }

	public void set_ColumnName(string value) { }

	internal string get_EncodedColumnName() { }

	internal IFormatProvider get_FormatProvider() { }

	internal CultureInfo get_Locale() { }

	internal int get_ObjectID() { }

	public string get_Prefix() { }

	public void set_Prefix(string value) { }

	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	internal bool get_Computed() { }

	internal DataExpression get_DataExpression() { }

	public Type get_DataType() { }

	public void set_DataType(Type value) { }

	public DataSetDateTime get_DateTimeMode() { }

	public void set_DateTimeMode(DataSetDateTime value) { }

	public object get_DefaultValue() { }

	public void set_DefaultValue(object value) { }

	internal bool get_DefaultValueIsNull() { }

	public string get_Expression() { }

	public void set_Expression(string value) { }

	public PropertyCollection get_ExtendedProperties() { }

	internal bool get_HasData() { }

	internal bool get_ImplementsINullable() { }

	internal bool get_ImplementsIChangeTracking() { }

	internal bool get_ImplementsIRevertibleChangeTracking() { }

	internal bool get_IsValueType() { }

	internal bool get_IsSqlType() { }

	private void SetMaxLengthSimpleType() { }

	public int get_MaxLength() { }

	public void set_MaxLength(int value) { }

	public string get_Namespace() { }

	public void set_Namespace(string value) { }

	public int get_Ordinal() { }

	internal void SetOrdinalInternal(int ordinal) { }

	public bool get_ReadOnly() { }

	public void set_ReadOnly(bool value) { }

	private Index get_SortIndex() { }

	public DataTable get_Table() { }

	internal void SetTable(DataTable table) { }

	private DataRow GetDataRow(int index) { }

	internal object get_Item(int record) { }

	internal void set_Item(int record, object value) { }

	internal void InitializeRecord(int record) { }

	internal void SetValue(int record, object value) { }

	internal void FreeRecord(int record) { }

	public bool get_Unique() { }

	public void set_Unique(bool value) { }

	internal void InternalUnique(bool value) { }

	[CompilerGeneratedAttribute] 
	internal string get_XmlDataType() { }

	[CompilerGeneratedAttribute] 
	internal void set_XmlDataType(string value) { }

	internal SimpleType get_SimpleType() { }

	internal void set_SimpleType(SimpleType value) { }

	public virtual MappingType get_ColumnMapping() { }

	public virtual void set_ColumnMapping(MappingType value) { }

	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	internal bool CheckMaxLength() { }

	internal void CheckMaxLength(DataRow dr) { }

	protected internal void CheckNotAllowNull() { }

	internal void CheckNullable(DataRow row) { }

	protected void CheckUnique() { }

	internal int Compare(int record1, int record2) { }

	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	internal int CompareValueTo(int record1, object value) { }

	internal object ConvertValue(object value) { }

	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	internal DataColumn Clone() { }

	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	private int GetStringLength(int record) { }

	internal void Init(int record) { }

	internal static bool IsAutoIncrementType(Type dataType) { }

	internal bool get_IsCustomType() { }

	internal bool IsValueCustomTypeInstance(object value) { }

	internal bool get_ImplementsIXMLSerializable() { }

	internal bool IsNull(int record) { }

	internal bool IsInRelation() { }

	internal bool IsMaxLengthViolated() { }

	internal bool IsNotAllowDBNullViolated() { }

	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	protected internal void RaisePropertyChanging(string name) { }

	private void InsureStorage() { }

	internal void SetCapacity(int capacity) { }

	internal void OnSetDataSet() { }

	public override string ToString() { }

	internal object ConvertXmlToObject(string s) { }

	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	internal string ConvertObjectToXml(object value) { }

	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	internal object GetEmptyColumnStore(int recordCount) { }

	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	internal void SetStorage(object store, BitArray nullbits) { }

	internal void AddDependentColumn(DataColumn expressionColumn) { }

	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 4188
{
	private DataColumn _column; 
	[CompilerGeneratedAttribute] 
	private readonly DataRow <Row>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ProposedValue>k__BackingField; 

	public object ProposedValue { get; set; }


	internal void .ctor(DataRow row) { }

	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGeneratedAttribute] 
	public object get_ProposedValue() { }

	[CompilerGeneratedAttribute] 
	public void set_ProposedValue(object value) { }

	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 4189
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataColumnChangeEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 4190
{
	private readonly DataTable _table; 
	private readonly ArrayList _list; 
	private int _defaultNameIndex; 
	private DataColumn[] _delayedAddRangeColumns; 
	private readonly Dictionary<string, DataColumn> _columnFromName; 
	private bool _fInClear; 
	private DataColumn[] _columnsImplementingIChangeTracking; 
	private int _nColumnsImplementingIChangeTracking; 
	private int _nColumnsImplementingIRevertibleChangeTracking; 
	[CompilerGeneratedAttribute] 
	private CollectionChangeEventHandler CollectionChanged; 
	[CompilerGeneratedAttribute] 
	private CollectionChangeEventHandler CollectionChanging; 
	[CompilerGeneratedAttribute] 
	private CollectionChangeEventHandler ColumnPropertyChanged; 

	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }


	internal void .ctor(DataTable table) { }

	protected override ArrayList get_List() { }

	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	public DataColumn get_Item(int index) { }

	public DataColumn get_Item(string name) { }

	internal DataColumn get_Item(string name, string ns) { }

	public void Add(DataColumn column) { }

	internal void AddAt(int index, DataColumn column) { }

	public DataColumn Add(string columnName, Type type) { }

	[CompilerGeneratedAttribute] 
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] 
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] 
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] 
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	private void ArrayAdd(DataColumn column) { }

	private void ArrayAdd(int index, DataColumn column) { }

	private void ArrayRemove(DataColumn column) { }

	internal string AssignName() { }

	private void BaseAdd(DataColumn column) { }

	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	private void BaseRemove(DataColumn column) { }

	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	private void CheckIChangeTracking(DataColumn column) { }

	public void Clear() { }

	public bool Contains(string name) { }

	internal bool Contains(string name, bool caseSensitive) { }

	public int IndexOf(string columnName) { }

	internal int IndexOfCaseInsensitive(string name) { }

	private string MakeName(int index) { }

	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	internal void RegisterColumnName(string name, DataColumn column) { }

	internal bool CanRegisterName(string name) { }

	public void Remove(DataColumn column) { }

	internal void UnregisterName(string name) { }

	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4191
{
	[CompilerGeneratedAttribute] 
	private readonly DataColumn <Column>k__BackingField; 

	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }


	internal void .ctor(DataColumn dataColumn) { }

	public override AttributeCollection get_Attributes() { }

	[CompilerGeneratedAttribute] 
	internal DataColumn get_Column() { }

	public override Type get_ComponentType() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	public override bool Equals(object other) { }

	public override int GetHashCode() { }

	public override object GetValue(object component) { }

	public override void SetValue(object component, object value) { }

	public override bool ShouldSerializeValue(object component) { }

}

internal sealed class DataError // TypeDefIndex: 4192
{
	private string _rowError; 
	private int _count; 
	private DataError.ColumnError[] _errorList; 

	internal string Text { get; set; }
	internal bool HasErrors { get; }


	internal void .ctor() { }

	internal void .ctor(string rowError) { }

	internal string get_Text() { }

	internal void set_Text(string value) { }

	internal bool get_HasErrors() { }

	internal void SetColumnError(DataColumn column, string error) { }

	internal string GetColumnError(DataColumn column) { }

	internal void Clear(DataColumn column) { }

	internal void Clear() { }

	internal DataColumn[] GetColumnsInError() { }

	private void SetText(string errorText) { }

	internal int IndexOf(DataColumn column) { }

}

internal struct DataError.ColumnError // TypeDefIndex: 4193
{
	internal DataColumn _column; 
	internal string _error; 

}

public class DataException : SystemException // TypeDefIndex: 4194
{

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public void .ctor() { }

	public void .ctor(string s) { }

	public void .ctor(string s, Exception innerException) { }

}

internal struct DataKey // TypeDefIndex: 4205
{
	private readonly DataColumn[] _columns; 

	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }


	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	internal DataColumn[] get_ColumnsReference() { }

	internal bool get_HasValue() { }

	internal DataTable get_Table() { }

	internal void CheckState() { }

	internal bool ColumnsEqual(DataKey key) { }

	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	internal bool ContainsColumn(DataColumn column) { }

	public override int GetHashCode() { }

	public override bool Equals(object value) { }

	internal bool Equals(DataKey value) { }

	internal IndexField[] GetIndexDesc() { }

	internal object[] GetKeyValues(int record) { }

	internal Index GetSortIndex() { }

	internal Index GetSortIndex(DataViewRowState recordStates) { }

	internal bool RecordsEqual(int record1, int record2) { }

	internal DataColumn[] ToArray() { }

}

public class DataRelation // TypeDefIndex: 4206
{
	private DataSet _dataSet; 
	internal PropertyCollection _extendedProperties; 
	internal string _relationName; 
	private DataKey _childKey; 
	private DataKey _parentKey; 
	private UniqueConstraint _parentKeyConstraint; 
	private ForeignKeyConstraint _childKeyConstraint; 
	internal bool _nested; 
	internal bool _createConstraints; 
	private bool _checkMultipleNested; 
	private static int s_objectTypeCount; 
	private readonly int _objectID; 
	[CompilerGeneratedAttribute] 
	private PropertyChangedEventHandler PropertyChanging; 

	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public virtual DataSet DataSet { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValueAttribute] 
	public virtual string RelationName { get; }
	[DefaultValueAttribute] 
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[BrowsableAttribute] 
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }


	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	public virtual DataColumn[] get_ChildColumns() { }

	internal DataColumn[] get_ChildColumnsReference() { }

	internal DataKey get_ChildKey() { }

	public virtual DataTable get_ChildTable() { }

	public virtual DataSet get_DataSet() { }

	private static bool IsKeyNull(object[] values) { }

	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	internal void SetDataSet(DataSet dataSet) { }

	public virtual DataColumn[] get_ParentColumns() { }

	internal DataColumn[] get_ParentColumnsReference() { }

	internal DataKey get_ParentKey() { }

	public virtual DataTable get_ParentTable() { }

	public virtual string get_RelationName() { }

	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	internal void CheckNestedRelations() { }

	public virtual bool get_Nested() { }

	public virtual void set_Nested(bool value) { }

	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	public PropertyCollection get_ExtendedProperties() { }

	internal bool get_CheckMultipleNested() { }

	internal void set_CheckMultipleNested(bool value) { }

	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	internal void CheckState() { }

	protected void CheckStateForProperty() { }

	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	internal DataRelation Clone(DataSet destination) { }

	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	protected internal void RaisePropertyChanging(string name) { }

	public override string ToString() { }

	internal void ValidateMultipleNestedRelations() { }

	private bool IsAutoGenerated(DataColumn col) { }

	internal int get_ObjectID() { }

}

public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 4207
{
	private DataRelation _inTransition; 
	private int _defaultNameIndex; 
	private CollectionChangeEventHandler _onCollectionChangedDelegate; 
	private CollectionChangeEventHandler _onCollectionChangingDelegate; 
	private static int s_objectTypeCount; 
	private readonly int _objectID; 

	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }


	internal int get_ObjectID() { }

	public abstract DataRelation get_Item(int index);

	public abstract DataRelation get_Item(string name);

	public void Add(DataRelation relation) { }

	protected virtual void AddCore(DataRelation relation) { }

	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	internal string AssignName() { }

	public virtual void Clear() { }

	public virtual bool Contains(string name) { }

	internal int InternalIndexOf(string name) { }

	protected abstract DataSet GetDataSet();

	private string MakeName(int index) { }

	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	internal void RegisterName(string name) { }

	public void Remove(DataRelation relation) { }

	public void RemoveAt(int index) { }

	protected virtual void RemoveCore(DataRelation relation) { }

	internal void UnregisterName(string name) { }

	protected void .ctor() { }

}

internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 4208
{
	private readonly DataTable _table; 
	private readonly ArrayList _relations; 
	private readonly bool _fParentCollection; 
	[CompilerGeneratedAttribute] 
	private CollectionChangeEventHandler RelationPropertyChanged; 

	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }


	internal void .ctor(DataTable table, bool fParentCollection) { }

	protected override ArrayList get_List() { }

	private void EnsureDataSet() { }

	protected override DataSet GetDataSet() { }

	public override DataRelation get_Item(int index) { }

	public override DataRelation get_Item(string name) { }

	[CompilerGeneratedAttribute] 
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] 
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	private void AddCache(DataRelation relation) { }

	protected override void AddCore(DataRelation relation) { }

	private void RemoveCache(DataRelation relation) { }

	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 4209
{
	private readonly DataSet _dataSet; 
	private readonly ArrayList _relations; 
	private DataRelation[] _delayLoadingRelations; 

	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }


	internal void .ctor(DataSet dataSet) { }

	protected override ArrayList get_List() { }

	public override void Clear() { }

	protected override DataSet GetDataSet() { }

	public override DataRelation get_Item(int index) { }

	public override DataRelation get_Item(string name) { }

	protected override void AddCore(DataRelation relation) { }

	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4210
{
	[CompilerGeneratedAttribute] 
	private readonly DataRelation <Relation>k__BackingField; 

	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }


	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGeneratedAttribute] 
	internal DataRelation get_Relation() { }

	public override Type get_ComponentType() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	public override bool Equals(object other) { }

	public override int GetHashCode() { }

	public override object GetValue(object component) { }

	public override void SetValue(object component, object value) { }

	public override bool ShouldSerializeValue(object component) { }

}

public class DataRow // TypeDefIndex: 4211
{
	private readonly DataTable _table; 
	private readonly DataColumnCollection _columns; 
	internal int _oldRecord; 
	internal int _newRecord; 
	internal int _tempRecord; 
	internal long _rowID; 
	internal DataRowAction _action; 
	internal bool _inChangingEvent; 
	internal bool _inDeletingEvent; 
	internal bool _inCascade; 
	private DataColumn _lastChangedColumn; 
	private int _countColumnChange; 
	private DataError _error; 
	private int _rbTreeNodeId; 
	private static int s_objectTypeCount; 
	internal readonly int _objectID; 

	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public object Item { get; set; }
	public object Item { get; set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { get; set; }
	public bool HasErrors { get; }


	protected internal void .ctor(DataRowBuilder builder) { }

	internal DataColumn get_LastChangedColumn() { }

	internal void set_LastChangedColumn(DataColumn value) { }

	internal bool get_HasPropertyChanged() { }

	internal int get_RBTreeNodeId() { }

	internal void set_RBTreeNodeId(int value) { }

	public string get_RowError() { }

	public void set_RowError(string value) { }

	private void RowErrorChanged() { }

	internal long get_rowID() { }

	internal void set_rowID(long value) { }

	public DataRowState get_RowState() { }

	public DataTable get_Table() { }

	public object get_Item(int columnIndex) { }

	public void set_Item(int columnIndex, object value) { }

	internal void CheckForLoops(DataRelation rel) { }

	internal int GetNestedParentCount() { }

	public object get_Item(string columnName) { }

	public void set_Item(string columnName, object value) { }

	public object get_Item(DataColumn column) { }

	public void set_Item(DataColumn column, object value) { }

	public object get_Item(DataColumn column, DataRowVersion version) { }

	public object[] get_ItemArray() { }

	public void set_ItemArray(object[] value) { }

	public void AcceptChanges() { }

	[EditorBrowsableAttribute] 
	public void BeginEdit() { }

	private bool BeginEditInternal() { }

	[EditorBrowsableAttribute] 
	public void CancelEdit() { }

	private void CheckColumn(DataColumn column) { }

	internal void CheckInTable() { }

	public void Delete() { }

	[EditorBrowsableAttribute] 
	public void EndEdit() { }

	public void SetColumnError(int columnIndex, string error) { }

	public void SetColumnError(DataColumn column, string error) { }

	public string GetColumnError(DataColumn column) { }

	public void ClearErrors() { }

	internal void ClearError(DataColumn column) { }

	public bool get_HasErrors() { }

	public DataColumn[] GetColumnsInError() { }

	public DataRow[] GetChildRows(DataRelation relation) { }

	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	internal DataColumn GetDataColumn(string columnName) { }

	public DataRow GetParentRow(DataRelation relation) { }

	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	public DataRow[] GetParentRows(DataRelation relation) { }

	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	internal object[] GetColumnValues(DataColumn[] columns) { }

	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	internal object[] GetKeyValues(DataKey key) { }

	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	internal int GetCurrentRecordNo() { }

	internal int GetDefaultRecord() { }

	internal int GetOriginalRecordNo() { }

	private int GetProposedRecordNo() { }

	internal int GetRecordFromVersion(DataRowVersion version) { }

	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	internal DataViewRowState GetRecordState(int record) { }

	internal bool HasKeyChanged(DataKey key) { }

	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	public bool HasVersion(DataRowVersion version) { }

	internal bool HaveValuesChanged(DataColumn[] columns) { }

	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	public bool IsNull(string columnName) { }

	public void RejectChanges() { }

	internal void ResetLastChangedColumn() { }

	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	internal void SetParentRowToDBNull() { }

	internal void SetParentRowToDBNull(DataRelation relation) { }

	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

public sealed class DataRowBuilder // TypeDefIndex: 4212
{
	internal readonly DataTable _table; 
	internal int _record; 


	internal void .ctor(DataTable table, int record) { }

}

public enum DataRowAction // TypeDefIndex: 4213
{
	public int value__; 
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;

}

public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 4214
{
	[CompilerGeneratedAttribute] 
	private readonly DataRow <Row>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly DataRowAction <Action>k__BackingField; 


	public void .ctor(DataRow row, DataRowAction action) { }

}

public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 4215
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataRowChangeEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 4216
{
	private readonly DataTable _table; 
	private readonly DataRowCollection.DataRowTree _list; 
	internal int _nullInList; 

	public override int Count { get; }
	public DataRow Item { get; }


	internal void .ctor(DataTable table) { }

	public override int get_Count() { }

	public DataRow get_Item(int index) { }

	public void Add(DataRow row) { }

	internal void DiffInsertAt(DataRow row, int pos) { }

	public int IndexOf(DataRow row) { }

	internal DataRow AddWithColumnEvents(object[] values) { }

	public DataRow Add(object[] values) { }

	internal void ArrayAdd(DataRow row) { }

	internal void ArrayInsert(DataRow row, int pos) { }

	internal void ArrayClear() { }

	internal void ArrayRemove(DataRow row) { }

	public override void CopyTo(Array ar, int index) { }

	public void CopyTo(DataRow[] array, int index) { }

	public override IEnumerator GetEnumerator() { }

	public void Remove(DataRow row) { }

	public void RemoveAt(int index) { }

}

private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 4217
{

	internal void .ctor() { }

	protected override int CompareNode(DataRow record1, DataRow record2) { }

	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 4218
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataRow r) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataRow r, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 4219
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataTable table) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataTable table, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum DataRowState // TypeDefIndex: 4220
{
	public int value__; 
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;

}

public enum DataRowVersion // TypeDefIndex: 4221
{
	public int value__; 
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;

}

public class DataRowView : ICustomTypeDescriptor // TypeDefIndex: 4222
{
	private readonly DataView _dataView; 
	private readonly DataRow _row; 
	private bool _delayBeginEdit; 
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; 
	[CompilerGeneratedAttribute] 
	private PropertyChangedEventHandler PropertyChanged; 

	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }


	internal void .ctor(DataView dataView, DataRow row) { }

	public override bool Equals(object other) { }

	public override int GetHashCode() { }

	public DataView get_DataView() { }

	private DataRowVersion get_RowVersionDefault() { }

	internal int GetRecord() { }

	internal bool HasRecord() { }

	internal object GetColumnValue(DataColumn column) { }

	internal void SetColumnValue(DataColumn column, object value) { }

	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	public DataView CreateChildView(DataRelation relation) { }

	public DataRow get_Row() { }

	public void EndEdit() { }

	public bool get_IsNew() { }

	internal void RaisePropertyChangedEvent(string propName) { }

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	private static void .cctor() { }

}

public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 4224
{
	private DataViewManager _defaultViewManager; 
	private readonly DataTableCollection _tableCollection; 
	private readonly DataRelationCollection _relationCollection; 
	internal PropertyCollection _extendedProperties; 
	private string _dataSetName; 
	private string _datasetPrefix; 
	internal string _namespaceURI; 
	private bool _enforceConstraints; 
	private bool _caseSensitive; 
	private CultureInfo _culture; 
	private bool _cultureUserSet; 
	internal bool _fInReadXml; 
	internal bool _fInLoadDiffgram; 
	internal bool _fTopLevelTable; 
	internal bool _fInitInProgress; 
	internal bool _fEnableCascading; 
	internal bool _fIsSchemaLoading; 
	internal string _mainTableName; 
	private SerializationFormat _remotingFormat; 
	private object _defaultViewManagerLock; 
	private static int s_objectTypeCount; 
	private readonly int _objectID; 
	private static XmlSchemaComplexType s_schemaTypeForWSDL; 
	internal bool _useDataSetSchemaOnly; 
	internal bool _udtIsWrapped; 
	[CompilerGeneratedAttribute] 
	private PropertyChangedEventHandler PropertyChanging; 
	[CompilerGeneratedAttribute] 
	private MergeFailedEventHandler MergeFailed; 
	[CompilerGeneratedAttribute] 
	private DataRowCreatedEventHandler DataRowCreated; 
	[CompilerGeneratedAttribute] 
	private DataSetClearEventhandler ClearFunctionCalled; 

	[DefaultValueAttribute] 
	public SerializationFormat RemotingFormat { get; set; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValueAttribute] 
	public bool CaseSensitive { get; set; }
	[DefaultValueAttribute] 
	public bool EnforceConstraints { get; set; }
	[DefaultValueAttribute] 
	public string DataSetName { get; set; }
	[DefaultValueAttribute] 
	public string Namespace { get; set; }
	[DefaultValueAttribute] 
	public string Prefix { get; set; }
	[BrowsableAttribute] 
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public override ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] 
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibilityAttribute] 
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }


	public void .ctor() { }

	public void .ctor(string dataSetName) { }

	public SerializationFormat get_RemotingFormat() { }

	public void set_RemotingFormat(SerializationFormat value) { }

	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	protected virtual void InitializeDerivedDataSet() { }

	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	internal void FailedEnableConstraints() { }

	public bool get_CaseSensitive() { }

	public void set_CaseSensitive(bool value) { }

	public bool get_EnforceConstraints() { }

	public void set_EnforceConstraints(bool value) { }

	internal void RestoreEnforceConstraints(bool value) { }

	internal void EnableConstraints() { }

	public string get_DataSetName() { }

	public void set_DataSetName(string value) { }

	public string get_Namespace() { }

	public void set_Namespace(string value) { }

	public string get_Prefix() { }

	public void set_Prefix(string value) { }

	public PropertyCollection get_ExtendedProperties() { }

	public CultureInfo get_Locale() { }

	public void set_Locale(CultureInfo value) { }

	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	internal bool ShouldSerializeLocale() { }

	public override ISite get_Site() { }

	public DataRelationCollection get_Relations() { }

	public DataTableCollection get_Tables() { }

	public void Clear() { }

	public virtual DataSet Clone() { }

	internal int EstimatedXmlStringSize() { }

	internal string GetRemotingDiffGram(DataTable table) { }

	internal string GetXmlSchemaForRemoting(DataTable table) { }

	public void ReadXmlSchema(XmlReader reader) { }

	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	internal bool MoveToElement(XmlReader reader, int depth) { }

	private static void MoveToElement(XmlReader reader) { }

	internal void ReadEndElement(XmlReader reader) { }

	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	internal void ReadXDRSchema(XmlReader reader) { }

	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	public XmlReadMode ReadXml(XmlReader reader) { }

	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	private bool IsEmpty() { }

	private void ReadXmlDiffgram(XmlReader reader) { }

	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	public void Merge(DataSet dataSet) { }

	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	internal void OnDataRowCreated(DataRow row) { }

	internal void OnClearFunctionCalled(DataTable table) { }

	protected internal virtual void OnRemoveTable(DataTable table) { }

	internal void OnRemovedTable(DataTable table) { }

	protected virtual void OnRemoveRelation(DataRelation relation) { }

	internal void OnRemoveRelationHack(DataRelation relation) { }

	protected internal void RaisePropertyChanging(string name) { }

	internal DataTable[] TopLevelTables() { }

	internal DataTable[] TopLevelTables(bool forSchema) { }

	public virtual void Reset() { }

	internal bool ValidateCaseConstraint() { }

	internal bool ValidateLocaleConstraint() { }

	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	internal string get_MainTableName() { }

	internal void set_MainTableName(string value) { }

	internal int get_ObjectID() { }

}

public enum DataSetDateTime // TypeDefIndex: 4225
{
	public int value__; 
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;

}

public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 4226
{
	private DataSet _dataSet; 
	private DataView _defaultView; 
	internal long _nextRowID; 
	internal readonly DataRowCollection _rowCollection; 
	internal readonly DataColumnCollection _columnCollection; 
	private readonly ConstraintCollection _constraintCollection; 
	private int _elementColumnCount; 
	internal DataRelationCollection _parentRelationsCollection; 
	internal DataRelationCollection _childRelationsCollection; 
	internal readonly RecordManager _recordManager; 
	internal readonly List<Index> _indexes; 
	private List<Index> _shadowIndexes; 
	private int _shadowCount; 
	internal PropertyCollection _extendedProperties; 
	private string _tableName; 
	internal string _tableNamespace; 
	private string _tablePrefix; 
	internal DataExpression _displayExpression; 
	internal bool _fNestedInDataset; 
	private CultureInfo _culture; 
	private bool _cultureUserSet; 
	private CompareInfo _compareInfo; 
	private CompareOptions _compareFlags; 
	private IFormatProvider _formatProvider; 
	private StringComparer _hashCodeProvider; 
	private bool _caseSensitive; 
	private bool _caseSensitiveUserSet; 
	internal string _encodedTableName; 
	internal DataColumn _xmlText; 
	internal DataColumn _colUnique; 
	internal Decimal _minOccurs; 
	internal Decimal _maxOccurs; 
	internal bool _repeatableElement; 
	private object _typeName; 
	internal UniqueConstraint _primaryKey; 
	internal IndexField[] _primaryIndex; 
	private DataColumn[] _delayedSetPrimaryKey; 
	private Index _loadIndex; 
	private Index _loadIndexwithOriginalAdded; 
	private Index _loadIndexwithCurrentDeleted; 
	private int _suspendIndexEvents; 
	private bool _savedEnforceConstraints; 
	private bool _inDataLoad; 
	private bool _initialLoad; 
	private bool _schemaLoading; 
	private bool _enforceConstraints; 
	internal bool _suspendEnforceConstraints; 
	protected internal bool fInitInProgress; 
	private bool _inLoad; 
	internal bool _fInLoadDiffgram; 
	private byte _isTypedDataTable; 
	private DataRow[] _emptyDataRowArray; 
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; 
	private DataRelation[] _nestedParentRelations; 
	internal List<DataColumn> _dependentColumns; 
	private bool _mergingData; 
	private DataRowChangeEventHandler _onRowChangedDelegate; 
	private DataRowChangeEventHandler _onRowChangingDelegate; 
	private DataRowChangeEventHandler _onRowDeletingDelegate; 
	private DataRowChangeEventHandler _onRowDeletedDelegate; 
	private DataColumnChangeEventHandler _onColumnChangedDelegate; 
	private DataColumnChangeEventHandler _onColumnChangingDelegate; 
	private DataTableClearEventHandler _onTableClearingDelegate; 
	private DataTableClearEventHandler _onTableClearedDelegate; 
	private DataTableNewRowEventHandler _onTableNewRowDelegate; 
	private PropertyChangedEventHandler _onPropertyChangingDelegate; 
	private readonly DataRowBuilder _rowBuilder; 
	internal readonly List<DataView> _delayedViews; 
	private readonly List<DataViewListener> _dataViewListeners; 
	internal Hashtable _rowDiffId; 
	internal readonly ReaderWriterLockSlim _indexesLock; 
	internal int _ukColumnPositionForInference; 
	private SerializationFormat _remotingFormat; 
	private static int s_objectTypeCount; 
	private readonly int _objectID; 

	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsableAttribute] 
	internal List<Index> LiveIndexes { get; }
	[DefaultValueAttribute] 
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibilityAttribute] 
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibilityAttribute] 
	public ConstraintCollection Constraints { get; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DataSet DataSet { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[BrowsableAttribute] 
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValueAttribute] 
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverterAttribute] 
	public DataColumn[] PrimaryKey { get; set; }
	[BrowsableAttribute] 
	public DataRowCollection Rows { get; }
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValueAttribute] 
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public override ISite Site { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }


	public void .ctor() { }

	public void .ctor(string tableName) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	public bool get_CaseSensitive() { }

	public void set_CaseSensitive(bool value) { }

	internal bool get_AreIndexEventsSuspended() { }

	internal void RestoreIndexEvents(bool forceReset) { }

	internal void SuspendIndexEvents() { }

	private bool get_IsTypedDataTable() { }

	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	internal bool ShouldSerializeCaseSensitive() { }

	internal bool get_SelfNested() { }

	internal List<Index> get_LiveIndexes() { }

	public SerializationFormat get_RemotingFormat() { }

	public void set_RemotingFormat(SerializationFormat value) { }

	internal int get_UKColumnPositionForInference() { }

	internal void set_UKColumnPositionForInference(int value) { }

	public DataRelationCollection get_ChildRelations() { }

	public DataColumnCollection get_Columns() { }

	private CompareInfo get_CompareInfo() { }

	public ConstraintCollection get_Constraints() { }

	private void ResetConstraints() { }

	public DataSet get_DataSet() { }

	internal void SetDataSet(DataSet dataSet) { }

	internal string get_DisplayExpressionInternal() { }

	internal bool get_EnforceConstraints() { }

	internal void set_EnforceConstraints(bool value) { }

	internal bool get_SuspendEnforceConstraints() { }

	internal void set_SuspendEnforceConstraints(bool value) { }

	internal void EnableConstraints() { }

	public PropertyCollection get_ExtendedProperties() { }

	internal IFormatProvider get_FormatProvider() { }

	public CultureInfo get_Locale() { }

	public void set_Locale(CultureInfo value) { }

	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	internal bool ShouldSerializeLocale() { }

	public int get_MinimumCapacity() { }

	public void set_MinimumCapacity(int value) { }

	internal int get_RecordCapacity() { }

	internal int get_ElementColumnCount() { }

	internal void set_ElementColumnCount(int value) { }

	public DataRelationCollection get_ParentRelations() { }

	internal bool get_MergingData() { }

	internal void set_MergingData(bool value) { }

	internal DataRelation[] get_NestedParentRelations() { }

	internal bool get_SchemaLoading() { }

	internal void CacheNestedParent() { }

	private DataRelation[] FindNestedParentRelations() { }

	internal int get_NestedParentsCount() { }

	public DataColumn[] get_PrimaryKey() { }

	public void set_PrimaryKey(DataColumn[] value) { }

	public DataRowCollection get_Rows() { }

	public string get_TableName() { }

	public void set_TableName(string value) { }

	internal string get_EncodedTableName() { }

	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	public string get_Namespace() { }

	public void set_Namespace(string value) { }

	internal bool IsNamespaceInherited() { }

	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	internal void DoRaiseNamespaceChange() { }

	public string get_Prefix() { }

	public void set_Prefix(string value) { }

	internal DataColumn get_XmlText() { }

	internal void set_XmlText(DataColumn value) { }

	internal Decimal get_MaxOccurs() { }

	internal void set_MaxOccurs(Decimal value) { }

	internal Decimal get_MinOccurs() { }

	internal void set_MinOccurs(Decimal value) { }

	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	internal DataRow FindByIndex(Index ndx, object[] key) { }

	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	public void AcceptChanges() { }

	protected virtual DataTable CreateInstance() { }

	public virtual DataTable Clone() { }

	internal DataTable Clone(DataSet cloneDS) { }

	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	public override ISite get_Site() { }

	internal void AddRow(DataRow row, int proposedID) { }

	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	internal void CheckNotModifying(DataRow row) { }

	public void Clear() { }

	internal void Clear(bool clearAll) { }

	internal void CascadeAll(DataRow row, DataRowAction action) { }

	internal void CommitRow(DataRow row) { }

	internal int Compare(string s1, string s2) { }

	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	internal int IndexOf(string s1, string s2) { }

	internal bool IsSuffix(string s1, string s2) { }

	internal void DeleteRow(DataRow row) { }

	internal string FormatSortString(IndexField[] indexDesc) { }

	internal void FreeRecord(ref int record) { }

	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	internal List<DataViewListener> GetListeners() { }

	internal int GetSpecialHashCode(string name) { }

	internal void InsertRow(DataRow row, long proposedID) { }

	internal int NewRecord() { }

	internal int NewUninitializedRecord() { }

	internal int NewRecordFromArray(object[] value) { }

	internal int NewRecord(int sourceRecord) { }

	internal DataRow NewEmptyRow() { }

	private DataRow NewUninitializedRow() { }

	public DataRow NewRow() { }

	internal DataRow CreateEmptyRow() { }

	private void NewRowCreated(DataRow row) { }

	internal DataRow NewRow(int record) { }

	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	protected virtual Type GetRowType() { }

	protected internal DataRow[] NewRowArray(int size) { }

	internal bool get_NeedColumnChangeEvents() { }

	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	internal void OnRemoveColumnInternal(DataColumn column) { }

	protected virtual void OnRemoveColumn(DataColumn column) { }

	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	internal IndexField[] ParseSortString(string sortString) { }

	internal void RaisePropertyChanging(string name) { }

	internal void RecordChanged(int record) { }

	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	internal void RemoveRow(DataRow row, bool check) { }

	public virtual void Reset() { }

	internal void ResetIndexes() { }

	internal void ResetInternalIndexes(DataColumn column) { }

	internal void RollbackRow(DataRow row) { }

	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates) { }

	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	private void RestoreShadowIndexes() { }

	private void SetShadowIndexes() { }

	internal void ShadowIndexCopy() { }

	public override string ToString() { }

	public void BeginLoadData() { }

	public void EndLoadData() { }

	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	internal DataColumn AddUniqueKey(int position) { }

	internal DataColumn AddUniqueKey() { }

	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	internal void UpdatePropertyDescriptorCollectionCache() { }

	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	internal XmlQualifiedName get_TypeName() { }

	internal void set_TypeName(XmlQualifiedName value) { }

	public void Merge(DataTable table) { }

	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	public XmlReadMode ReadXml(TextReader reader) { }

	private void RestoreConstraint(bool originalEnforceConstraint) { }

	private bool IsEmptyXml(XmlReader reader) { }

	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	internal void ReadEndElement(XmlReader reader) { }

	internal void ReadXDRSchema(XmlReader reader) { }

	internal bool MoveToElement(XmlReader reader, int depth) { }

	private void ReadXmlDiffgram(XmlReader reader) { }

	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	protected virtual XmlSchema GetSchema() { }

	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	internal Hashtable get_RowDiffId() { }

	internal int get_ObjectID() { }

	internal void AddDependentColumn(DataColumn expressionColumn) { }

	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	internal void EvaluateExpressions() { }

	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	internal void EvaluateExpressions(DataColumn column) { }

	internal void EvaluateDependentExpressions(DataColumn column) { }

	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

}

internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 4227
{
	private DataTable _targetTable; 


	internal void Prepare(DataTable table) { }

}

internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 4228
{
	private DataSet _targetDS; 


	internal void Prepare(DataSet ds) { }

}

public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 4229
{
	[CompilerGeneratedAttribute] 
	private readonly DataTable <Table>k__BackingField; 


	public void .ctor(DataTable dataTable) { }

}

public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 4230
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataTableClearEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 4231
{
	private readonly DataSet _dataSet; 
	private readonly ArrayList _list; 
	private int _defaultNameIndex; 
	private DataTable[] _delayedAddRangeTables; 
	private CollectionChangeEventHandler _onCollectionChangedDelegate; 
	private CollectionChangeEventHandler _onCollectionChangingDelegate; 
	private static int s_objectTypeCount; 
	private readonly int _objectID; 

	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }


	internal void .ctor(DataSet dataSet) { }

	protected override ArrayList get_List() { }

	internal int get_ObjectID() { }

	public DataTable get_Item(int index) { }

	public DataTable get_Item(string name) { }

	public DataTable get_Item(string name, string tableNamespace) { }

	internal DataTable GetTable(string name, string ns) { }

	internal DataTable GetTableSmart(string name, string ns) { }

	public void Add(DataTable table) { }

	private void ArrayAdd(DataTable table) { }

	internal string AssignName() { }

	private void BaseAdd(DataTable table) { }

	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	private void BaseRemove(DataTable table) { }

	internal bool CanRemove(DataTable table, bool fThrowException) { }

	public void Clear() { }

	public bool Contains(string name) { }

	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	internal bool Contains(string name, bool caseSensitive) { }

	public int IndexOf(DataTable table) { }

	public int IndexOf(string tableName) { }

	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	internal void ReplaceFromInference(List<DataTable> tableList) { }

	internal int InternalIndexOf(string tableName) { }

	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	private string MakeName(int index) { }

	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	internal void RegisterName(string name, string tbNamespace) { }

	public void Remove(DataTable table) { }

	internal void UnregisterName(string name) { }

}

public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 4232
{
	[CompilerGeneratedAttribute] 
	private readonly DataRow <Row>k__BackingField; 


	public void .ctor(DataRow dataRow) { }

}

public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 4233
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataTableNewRowEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4235
{

[DefaultEventAttribute] 
[DefaultPropertyAttribute] 
[DefaultMemberAttribute] 
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable
	private DataViewManager _dataViewManager; 
	private DataTable _table; 
	private bool _locked; 
	private Index _index; 
	private Dictionary<string, Index> _findIndexes; 
	private string _sort; 
	private Comparison<DataRow> _comparison; 
	private IFilter _rowFilter; 
	private DataViewRowState _recordStates; 
	private bool _shouldOpen; 
	private bool _open; 
	private bool _allowNew; 
	private bool _allowEdit; 
	private bool _allowDelete; 
	private bool _applyDefaultSort; 
	internal DataRow _addNewRow; 
	private ListChangedEventArgs _addNewMoved; 
	private ListChangedEventHandler _onListChanged; 
	internal static ListChangedEventArgs s_resetEventArgs; 
	private DataViewRowState _delayedRecordStates; 
	private bool _fEndInitInProgress; 
	private Dictionary<DataRow, DataRowView> _rowViewCache; 
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; 
	private DataViewListener _dvListener; 
	private static int s_objectTypeCount; 
	private readonly int _objectID; 

	[DefaultValueAttribute] 
	public bool AllowDelete { get; }
	[DefaultValueAttribute] 
	public bool AllowNew { get; }
	[BrowsableAttribute] 
	public int Count { get; }
	private int CountFromIndex { get; }
	[BrowsableAttribute] 
	public DataViewManager DataViewManager { get; }
	[BrowsableAttribute] 
	protected bool IsOpen { get; }
	[DefaultValueAttribute] 
	public DataViewRowState RowStateFilter { get; }
	[DefaultValueAttribute] 
	public string Sort { get; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
	[TypeConverterAttribute] 
	public DataTable Table { get; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	internal int ObjectID { get; }


	internal void .ctor(DataTable table, bool locked) { }

	public bool get_AllowDelete() { }

	public bool get_AllowNew() { }

	public int get_Count() { }

	private int get_CountFromIndex() { }

	public DataViewManager get_DataViewManager() { }

	protected bool get_IsOpen() { }

	public DataViewRowState get_RowStateFilter() { }

	public string get_Sort() { }

	internal Comparison<DataRow> get_SortComparison() { }

	private object System.Collections.ICollection.get_SyncRoot() { }

	public DataTable get_Table() { }

	private object System.Collections.IList.get_Item(int recordIndex) { }

	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	public DataRowView get_Item(int recordIndex) { }

	public virtual DataRowView AddNew() { }

	private void CheckOpen() { }

	protected void Close() { }

	public void CopyTo(Array array, int index) { }

	private void CopyTo(DataRowView[] array, int index) { }

	public void Delete(int index) { }

	internal void Delete(DataRow row) { }

	protected override void Dispose(bool disposing) { }

	internal void FinishAddNew(bool success) { }

	public IEnumerator GetEnumerator() { }

	private bool System.Collections.IList.get_IsReadOnly() { }

	private bool System.Collections.IList.get_IsFixedSize() { }

	private int System.Collections.IList.Add(object value) { }

	private void System.Collections.IList.Clear() { }

	private bool System.Collections.IList.Contains(object value) { }

	private int System.Collections.IList.IndexOf(object value) { }

	internal int IndexOf(DataRowView rowview) { }

	private int IndexOfDataRowView(DataRowView rowview) { }

	private void System.Collections.IList.Insert(int index, object value) { }

	private void System.Collections.IList.Remove(object value) { }

	private void System.Collections.IList.RemoveAt(int index) { }

	internal virtual IFilter GetFilter() { }

	private int GetRecord(int recordIndex) { }

	internal DataRow GetRow(int index) { }

	private DataRowView GetRowView(int record) { }

	private DataRowView GetRowView(DataRow dr) { }

	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	protected void Reset() { }

	internal void ResetRowViewCache() { }

	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	protected void UpdateIndex() { }

	protected virtual void UpdateIndex(bool force) { }

	internal void UpdateIndex(bool force, bool fireEvent) { }

	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	internal int get_ObjectID() { }

	private static void .cctor() { }

}

private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 4236
{
	internal static readonly DataView.DataRowReferenceComparer s_default; 


	private void .ctor() { }

	public bool Equals(DataRow x, DataRow y) { }

	public int GetHashCode(DataRow obj) { }

	private static void .cctor() { }

}

internal sealed class DataViewListener // TypeDefIndex: 4237
{
	private readonly WeakReference _dvWeak; 
	private DataTable _table; 
	private Index _index; 
	internal readonly int _objectID; 


	internal void .ctor(DataView dv) { }

	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	internal void IndexListChanged(ListChangedEventArgs e) { }

	internal void RegisterMetaDataEvents(DataTable table) { }

	internal void UnregisterMetaDataEvents() { }

	private void UnregisterMetaDataEvents(bool updateListeners) { }

	internal void RegisterListChangedEvent(Index index) { }

	internal void UnregisterListChangedEvent() { }

	private void CleanUp(bool updateListeners) { }

	private void RegisterListener(DataTable table) { }

}

public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 4238
{
	private DataViewSettingCollection _dataViewSettingsCollection; 
	internal int _nViews; 
	private static NotSupportedException s_notSupported; 

	[DesignerSerializationVisibilityAttribute] 
	public DataViewSettingCollection DataViewSettings { get; }


	public DataViewSettingCollection get_DataViewSettings() { }

	private static void .cctor() { }

}

public enum DataViewRowState // TypeDefIndex: 4239
{
	public int value__; 
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;

}

public class DataViewSetting // TypeDefIndex: 4240
{
	private DataViewManager _dataViewManager; 
	private DataTable _table; 
	private string _sort; 
	private string _rowFilter; 
	private DataViewRowState _rowStateFilter; 
	private bool _applyDefaultSort; 

	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }


	internal void .ctor() { }

	public bool get_ApplyDefaultSort() { }

	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	internal void SetDataTable(DataTable table) { }

	public string get_RowFilter() { }

	public DataViewRowState get_RowStateFilter() { }

	public string get_Sort() { }

}

public class DataViewSettingCollection // TypeDefIndex: 4241
{
	private readonly DataViewManager _dataViewManager; 
	private readonly Hashtable _list; 

	public virtual DataViewSetting Item { get; set; }


	public virtual DataViewSetting get_Item(DataTable table) { }

	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	internal void Remove(DataTable table) { }

}

public enum DbType // TypeDefIndex: 4242
{
	public int value__; 
	public const DbType AnsiString = 0;
	public const DbType Binary = 1;
	public const DbType Byte = 2;
	public const DbType Boolean = 3;
	public const DbType Currency = 4;
	public const DbType Date = 5;
	public const DbType DateTime = 6;
	public const DbType Decimal = 7;
	public const DbType Double = 8;
	public const DbType Guid = 9;
	public const DbType Int16 = 10;
	public const DbType Int32 = 11;
	public const DbType Int64 = 12;
	public const DbType Object = 13;
	public const DbType SByte = 14;
	public const DbType Single = 15;
	public const DbType String = 16;
	public const DbType Time = 17;
	public const DbType UInt16 = 18;
	public const DbType UInt32 = 19;
	public const DbType UInt64 = 20;
	public const DbType VarNumeric = 21;
	public const DbType AnsiStringFixedLength = 22;
	public const DbType StringFixedLength = 23;
	public const DbType Xml = 25;
	public const DbType DateTime2 = 26;
	public const DbType DateTimeOffset = 27;

}

internal sealed class DataExpression : IFilter // TypeDefIndex: 4250
{
	internal string _originalExpression; 
	private bool _parsed; 
	private bool _bound; 
	private ExpressionNode _expr; 
	private DataTable _table; 
	private readonly StorageType _storageType; 
	private readonly Type _dataType; 
	private DataColumn[] _dependency; 

	internal string Expression { get; }
	internal ExpressionNode ExpressionNode { get; }
	internal bool HasValue { get; }


	internal void .ctor(DataTable table, string expression) { }

	internal void .ctor(DataTable table, string expression, Type type) { }

	internal string get_Expression() { }

	internal ExpressionNode get_ExpressionNode() { }

	internal bool get_HasValue() { }

	internal void Bind(DataTable table) { }

	internal bool DependsOn(DataColumn column) { }

	internal object Evaluate() { }

	internal object Evaluate(DataRow row, DataRowVersion version) { }

	public bool Invoke(DataRow row, DataRowVersion version) { }

	internal DataColumn[] GetDependency() { }

	internal bool IsTableAggregate() { }

	internal static bool IsUnknown(object value) { }

	internal bool HasLocalAggregate() { }

	internal bool HasRemoteAggregate() { }

	internal static bool ToBoolean(object value) { }

}

internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 4336
{
	private XmlWriter _xmltextWriter; 

	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }


	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	private void .ctor(XmlWriter w) { }

	internal Stream get_BaseStream() { }

	public override void WriteStartDocument() { }

	public override void WriteStartDocument(bool standalone) { }

	public override void WriteEndDocument() { }

	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public override void WriteStartElement(string prefix, string localName, string ns) { }

	public override void WriteEndElement() { }

	public override void WriteFullEndElement() { }

	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	public override void WriteEndAttribute() { }

	public override void WriteCData(string text) { }

	public override void WriteComment(string text) { }

	public override void WriteProcessingInstruction(string name, string text) { }

	public override void WriteEntityRef(string name) { }

	public override void WriteCharEntity(char ch) { }

	public override void WriteWhitespace(string ws) { }

	public override void WriteString(string text) { }

	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public override void WriteChars(char[] buffer, int index, int count) { }

	public override void WriteRaw(char[] buffer, int index, int count) { }

	public override void WriteRaw(string data) { }

	public override void WriteBase64(byte[] buffer, int index, int count) { }

	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	public override WriteState get_WriteState() { }

	public override void Close() { }

	public override void Flush() { }

	public override string LookupPrefix(string ns) { }

}

internal sealed class DataTextReader : XmlReader // TypeDefIndex: 4337
{
	private XmlReader _xmlreader; 

	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }


	internal static XmlReader CreateReader(XmlReader xr) { }

	private void .ctor(XmlReader input) { }

	public override XmlReaderSettings get_Settings() { }

	public override XmlNodeType get_NodeType() { }

	public override string get_Name() { }

	public override string get_LocalName() { }

	public override string get_NamespaceURI() { }

	public override string get_Prefix() { }

	public override string get_Value() { }

	public override int get_Depth() { }

	public override string get_BaseURI() { }

	public override bool get_IsEmptyElement() { }

	public override bool get_IsDefault() { }

	public override char get_QuoteChar() { }

	public override XmlSpace get_XmlSpace() { }

	public override string get_XmlLang() { }

	public override int get_AttributeCount() { }

	public override string GetAttribute(string name) { }

	public override string GetAttribute(string localName, string namespaceURI) { }

	public override string GetAttribute(int i) { }

	public override bool MoveToAttribute(string name) { }

	public override void MoveToAttribute(int i) { }

	public override bool MoveToFirstAttribute() { }

	public override bool MoveToNextAttribute() { }

	public override bool MoveToElement() { }

	public override bool ReadAttributeValue() { }

	public override bool Read() { }

	public override bool get_EOF() { }

	public override void Close() { }

	public override ReadState get_ReadState() { }

	public override void Skip() { }

	public override XmlNameTable get_NameTable() { }

	public override string LookupNamespace(string prefix) { }

	public override bool get_CanResolveEntity() { }

	public override void ResolveEntity() { }

	public override bool get_CanReadValueChunk() { }

	public override string ReadString() { }

}

public abstract class DbCommandBuilder : Component // TypeDefIndex: 4372
{
	private DbDataAdapter _dataAdapter; 
	private DbCommand _insertCommand; 
	private DbCommand _updateCommand; 
	private DbCommand _deleteCommand; 
	private MissingMappingAction _missingMappingAction; 
	private ConflictOption _conflictDetection; 
	private bool _setAllValues; 
	private bool _hasPartialPrimaryKey; 
	private DataTable _dbSchemaTable; 
	private DbSchemaRow[] _dbSchemaRows; 
	private string[] _sourceColumnNames; 
	private DbCommandBuilder.ParameterNames _parameterNames; 
	private string _quotedBaseTableName; 
	private CatalogLocation _catalogLocation; 
	private string _catalogSeparator; 
	private string _schemaSeparator; 
	private string _quotePrefix; 
	private string _quoteSuffix; 
	private string _parameterNamePattern; 
	private string _parameterMarkerFormat; 
	private int _parameterNameMaxLength; 

	[DefaultValueAttribute] 
	public virtual ConflictOption ConflictOption { get; }
	[DefaultValueAttribute] 
	public virtual CatalogLocation CatalogLocation { get; }
	[DefaultValueAttribute] 
	public virtual string CatalogSeparator { get; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	public DbDataAdapter DataAdapter { get; set; }
	internal int ParameterNameMaxLength { get; }
	internal string ParameterNamePattern { get; }
	private string QuotedBaseTableName { get; }
	[DefaultValueAttribute] 
	public virtual string QuotePrefix { get; set; }
	[DefaultValueAttribute] 
	public virtual string QuoteSuffix { get; set; }
	[DefaultValueAttribute] 
	public virtual string SchemaSeparator { get; }
	[DefaultValueAttribute] 
	public bool SetAllValues { get; }
	private DbCommand InsertCommand { get; set; }
	private DbCommand UpdateCommand { get; set; }
	private DbCommand DeleteCommand { get; set; }


	protected void .ctor() { }

	public virtual ConflictOption get_ConflictOption() { }

	public virtual CatalogLocation get_CatalogLocation() { }

	public virtual string get_CatalogSeparator() { }

	public DbDataAdapter get_DataAdapter() { }

	public void set_DataAdapter(DbDataAdapter value) { }

	internal int get_ParameterNameMaxLength() { }

	internal string get_ParameterNamePattern() { }

	private string get_QuotedBaseTableName() { }

	public virtual string get_QuotePrefix() { }

	public virtual void set_QuotePrefix(string value) { }

	public virtual string get_QuoteSuffix() { }

	public virtual void set_QuoteSuffix(string value) { }

	public virtual string get_SchemaSeparator() { }

	public bool get_SetAllValues() { }

	private DbCommand get_InsertCommand() { }

	private void set_InsertCommand(DbCommand value) { }

	private DbCommand get_UpdateCommand() { }

	private void set_UpdateCommand(DbCommand value) { }

	private DbCommand get_DeleteCommand() { }

	private void set_DeleteCommand(DbCommand value) { }

	private void BuildCache(bool closeConnection, DataRow dataRow, bool useColumnsForParameterNames) { }

	protected virtual DataTable GetSchemaTable(DbCommand sourceCommand) { }

	private void BuildInformation(DataTable schemaTable) { }

	private DbCommand BuildDeleteCommand(DataTableMapping mappings, DataRow dataRow) { }

	private DbCommand BuildInsertCommand(DataTableMapping mappings, DataRow dataRow) { }

	private DbCommand BuildUpdateCommand(DataTableMapping mappings, DataRow dataRow) { }

	private int BuildWhereClause(DataTableMapping mappings, DataRow dataRow, StringBuilder builder, DbCommand command, int parameterCount, bool isUpdate) { }

	private string CreateParameterForNullTest(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	private string CreateParameterForValue(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	protected override void Dispose(bool disposing) { }

	private string GetBaseParameterName(int index) { }

	private string GetOriginalParameterName(int index) { }

	private string GetNullParameterName(int index) { }

	private DbCommand GetSelectCommand() { }

	private object GetColumnValue(DataRow row, string columnName, DataTableMapping mappings, DataRowVersion version) { }

	private object GetColumnValue(DataRow row, DataColumn column, DataRowVersion version) { }

	private DataColumn GetDataColumn(string columnName, DataTableMapping tablemapping, DataRow row) { }

	private static DbParameter GetNextParameter(DbCommand command, int pcount) { }

	private bool IncludeInInsertValues(DbSchemaRow row) { }

	private bool IncludeInUpdateSet(DbSchemaRow row) { }

	private bool IncludeInWhereClause(DbSchemaRow row, bool isUpdate) { }

	private bool IncrementWhereCount(DbSchemaRow row) { }

	protected virtual DbCommand InitializeCommand(DbCommand command) { }

	private string QuotedColumn(string column) { }

	public virtual string QuoteIdentifier(string unquotedIdentifier) { }

	public virtual void RefreshSchema() { }

	private static void RemoveExtraParameters(DbCommand command, int usedParameterCount) { }

	protected void RowUpdatingHandler(RowUpdatingEventArgs rowUpdatingEvent) { }

	private void RowUpdatingHandlerBuilder(RowUpdatingEventArgs rowUpdatingEvent) { }

	public virtual string UnquoteIdentifier(string quotedIdentifier) { }

	protected abstract void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause);

	protected abstract string GetParameterName(int parameterOrdinal);

	protected abstract string GetParameterName(string parameterName);

	protected abstract string GetParameterPlaceholder(int parameterOrdinal);

	protected abstract void SetRowUpdatingHandler(DbDataAdapter adapter);

}

private class DbCommandBuilder.ParameterNames // TypeDefIndex: 4373
{
	private string _originalPrefix; 
	private string _isNullPrefix; 
	private Regex _parameterNameParser; 
	private DbCommandBuilder _dbCommandBuilder; 
	private string[] _baseParameterNames; 
	private string[] _originalParameterNames; 
	private string[] _nullParameterNames; 
	private bool[] _isMutatedName; 
	private int _count; 
	private int _genericParameterCount; 
	private int _adjustedParameterNameMaxLength; 


	internal void .ctor(DbCommandBuilder dbCommandBuilder, DbSchemaRow[] schemaRows) { }

	private void SetAndValidateNamePrefixes() { }

	private void ApplyProviderSpecificFormat() { }

	private void EliminateConflictingNames() { }

	internal void GenerateMissingNames(DbSchemaRow[] schemaRows) { }

	private int GetAdjustedParameterNameMaxLength() { }

	private string GetNextGenericParameterName() { }

	internal string GetBaseParameterName(int index) { }

	internal string GetOriginalParameterName(int index) { }

	internal string GetNullParameterName(int index) { }

}

internal sealed class DbSchemaRow // TypeDefIndex: 4374
{
	private DbSchemaTable _schemaTable; 
	private DataRow _dataRow; 

	internal DataRow DataRow { get; }
	internal string ColumnName { get; }
	internal string BaseColumnName { get; }
	internal string BaseServerName { get; }
	internal string BaseCatalogName { get; }
	internal string BaseSchemaName { get; }
	internal string BaseTableName { get; }
	internal bool IsAutoIncrement { get; }
	internal bool IsUnique { get; }
	internal bool IsRowVersion { get; }
	internal bool IsKey { get; }
	internal bool IsExpression { get; }
	internal bool IsHidden { get; }
	internal bool IsLong { get; }
	internal bool IsReadOnly { get; }
	internal bool AllowDBNull { get; }


	internal static DbSchemaRow[] GetSortedSchemaRows(DataTable dataTable, bool returnProviderSpecificTypes) { }

	internal void .ctor(DbSchemaTable schemaTable, DataRow dataRow) { }

	internal DataRow get_DataRow() { }

	internal string get_ColumnName() { }

	internal string get_BaseColumnName() { }

	internal string get_BaseServerName() { }

	internal string get_BaseCatalogName() { }

	internal string get_BaseSchemaName() { }

	internal string get_BaseTableName() { }

	internal bool get_IsAutoIncrement() { }

	internal bool get_IsUnique() { }

	internal bool get_IsRowVersion() { }

	internal bool get_IsKey() { }

	internal bool get_IsExpression() { }

	internal bool get_IsHidden() { }

	internal bool get_IsLong() { }

	internal bool get_IsReadOnly() { }

	internal bool get_AllowDBNull() { }

}

internal sealed class DbSchemaTable // TypeDefIndex: 4375
{
	private static readonly string[] s_DBCOLUMN_NAME; 
	internal DataTable _dataTable; 
	private DataColumnCollection _columns; 
	private DataColumn[] _columnCache; 
	private bool _returnProviderSpecificTypes; 

	internal DataColumn ColumnName { get; }
	internal DataColumn BaseServerName { get; }
	internal DataColumn BaseColumnName { get; }
	internal DataColumn BaseTableName { get; }
	internal DataColumn BaseCatalogName { get; }
	internal DataColumn BaseSchemaName { get; }
	internal DataColumn IsAutoIncrement { get; }
	internal DataColumn IsUnique { get; }
	internal DataColumn IsKey { get; }
	internal DataColumn IsRowVersion { get; }
	internal DataColumn AllowDBNull { get; }
	internal DataColumn IsExpression { get; }
	internal DataColumn IsHidden { get; }
	internal DataColumn IsLong { get; }
	internal DataColumn IsReadOnly { get; }


	internal void .ctor(DataTable dataTable, bool returnProviderSpecificTypes) { }

	internal DataColumn get_ColumnName() { }

	internal DataColumn get_BaseServerName() { }

	internal DataColumn get_BaseColumnName() { }

	internal DataColumn get_BaseTableName() { }

	internal DataColumn get_BaseCatalogName() { }

	internal DataColumn get_BaseSchemaName() { }

	internal DataColumn get_IsAutoIncrement() { }

	internal DataColumn get_IsUnique() { }

	internal DataColumn get_IsKey() { }

	internal DataColumn get_IsRowVersion() { }

	internal DataColumn get_AllowDBNull() { }

	internal DataColumn get_IsExpression() { }

	internal DataColumn get_IsHidden() { }

	internal DataColumn get_IsLong() { }

	internal DataColumn get_IsReadOnly() { }

	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column) { }

	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column, DbSchemaTable.ColumnEnum column2) { }

	private static void .cctor() { }

}

private enum DbSchemaTable.ColumnEnum // TypeDefIndex: 4376
{
	public int value__; 
	public const DbSchemaTable.ColumnEnum ColumnName = 0;
	public const DbSchemaTable.ColumnEnum ColumnOrdinal = 1;
	public const DbSchemaTable.ColumnEnum ColumnSize = 2;
	public const DbSchemaTable.ColumnEnum BaseServerName = 3;
	public const DbSchemaTable.ColumnEnum BaseCatalogName = 4;
	public const DbSchemaTable.ColumnEnum BaseColumnName = 5;
	public const DbSchemaTable.ColumnEnum BaseSchemaName = 6;
	public const DbSchemaTable.ColumnEnum BaseTableName = 7;
	public const DbSchemaTable.ColumnEnum IsAutoIncrement = 8;
	public const DbSchemaTable.ColumnEnum IsUnique = 9;
	public const DbSchemaTable.ColumnEnum IsKey = 10;
	public const DbSchemaTable.ColumnEnum IsRowVersion = 11;
	public const DbSchemaTable.ColumnEnum DataType = 12;
	public const DbSchemaTable.ColumnEnum ProviderSpecificDataType = 13;
	public const DbSchemaTable.ColumnEnum AllowDBNull = 14;
	public const DbSchemaTable.ColumnEnum ProviderType = 15;
	public const DbSchemaTable.ColumnEnum IsExpression = 16;
	public const DbSchemaTable.ColumnEnum IsHidden = 17;
	public const DbSchemaTable.ColumnEnum IsLong = 18;
	public const DbSchemaTable.ColumnEnum IsReadOnly = 19;
	public const DbSchemaTable.ColumnEnum SchemaMappingUnsortedIndex = 20;

}

public class DataAdapter : Component // TypeDefIndex: 4377
{
	private static readonly object s_eventFillError; 
	private MissingMappingAction _missingMappingAction; 

	[DefaultValueAttribute] 
	public MissingMappingAction MissingMappingAction { get; }


	public MissingMappingAction get_MissingMappingAction() { }

	private static void .cctor() { }

}

public sealed class DataColumnMapping : MarshalByRefObject // TypeDefIndex: 4378
{
	private string _dataSetColumnName; 
	private string _sourceColumnName; 

	[DefaultValueAttribute] 
	public string DataSetColumn { get; }
	[DefaultValueAttribute] 
	public string SourceColumn { get; }


	public string get_DataSetColumn() { }

	public string get_SourceColumn() { }

	[EditorBrowsableAttribute] 
	public DataColumn GetDataColumnBySchemaAction(DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	[EditorBrowsableAttribute] 
	public static DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	internal static DataColumn CreateDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

}

public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4380
{

[DefaultMemberAttribute] 
public sealed class DataColumnMappingCollection : MarshalByRefObject
	private List<DataColumnMapping> _items; 

	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public int Count { get; }


	public int get_Count() { }

	public int IndexOf(string sourceColumn) { }

	[EditorBrowsableAttribute] 
	public static DataColumn GetDataColumn(DataColumnMappingCollection columnMappings, string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

internal sealed class DataRecordInternal : DbDataRecord, ICustomTypeDescriptor // TypeDefIndex: 4381
{
	private SchemaInfo[] _schemaInfo; 
	private object[] _values; 
	private PropertyDescriptorCollection _propertyDescriptors; 
	private FieldNameLookup _fieldNameLookup; 

	public override int FieldCount { get; }
	public override object Item { get; }


	internal void .ctor(SchemaInfo[] schemaInfo, object[] values, PropertyDescriptorCollection descriptors, FieldNameLookup fieldNameLookup) { }

	public override int get_FieldCount() { }

	public override int GetValues(object[] values) { }

	public override string GetName(int i) { }

	public override object GetValue(int i) { }

	public override string GetDataTypeName(int i) { }

	public override Type GetFieldType(int i) { }

	public override object get_Item(int i) { }

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

internal abstract class DataStorage // TypeDefIndex: 4384
{
	private static readonly Type[] s_storageClassType; 
	internal readonly DataColumn _column; 
	internal readonly DataTable _table; 
	internal readonly Type _dataType; 
	internal readonly StorageType _storageTypeCode; 
	private BitArray _dbNullBits; 
	private readonly object _defaultValue; 
	internal readonly object _nullValue; 
	internal readonly bool _isCloneable; 
	internal readonly bool _isCustomDefinedType; 
	internal readonly bool _isStringType; 
	internal readonly bool _isValueType; 
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; 
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; 

	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }


	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	internal DataSetDateTime get_DateTimeMode() { }

	internal IFormatProvider get_FormatProvider() { }

	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	public object AggregateCount(int[] recordNos) { }

	protected int CompareBits(int recordNo1, int recordNo2) { }

	public abstract int Compare(int recordNo1, int recordNo2);

	public abstract int CompareValueTo(int recordNo1, object value);

	public virtual object ConvertValue(object value) { }

	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	public abstract void Copy(int recordNo1, int recordNo2);

	public abstract object Get(int recordNo);

	protected object GetBits(int recordNo) { }

	public virtual int GetStringLength(int record) { }

	protected bool HasValue(int recordNo) { }

	public virtual bool IsNull(int recordNo) { }

	public abstract void Set(int recordNo, object value);

	protected void SetNullBit(int recordNo, bool flag) { }

	public virtual void SetCapacity(int capacity) { }

	public abstract object ConvertXmlToObject(string s);

	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	public abstract string ConvertObjectToXml(object value);

	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	internal static StorageType GetStorageType(Type dataType) { }

	internal static Type GetTypeStorage(StorageType storageType) { }

	internal static bool IsTypeCustomType(Type type) { }

	internal static bool IsTypeCustomType(StorageType typeCode) { }

	internal static bool IsSqlType(StorageType storageType) { }

	public static bool IsSqlType(Type dataType) { }

	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	public static bool IsObjectNull(object value) { }

	public static bool IsObjectSqlNull(object value) { }

	internal object GetEmptyStorageInternal(int recordCount) { }

	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	internal void SetStorageInternal(object store, BitArray nullbits) { }

	protected abstract object GetEmptyStorage(int recordCount);

	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	protected abstract void SetStorage(object store, BitArray nullbits);

	protected void SetNullStorage(BitArray nullbits) { }

	internal static Type GetType(string value) { }

	internal static string GetQualifiedName(Type type) { }

	private static void .cctor() { }

}

public sealed class DataTableMapping : MarshalByRefObject // TypeDefIndex: 4385
{
	private DataColumnMappingCollection _columnMappings; 


	[EditorBrowsableAttribute] 
	public DataColumn GetDataColumn(string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

public abstract class DbCommand : Component, IDbCommand, IDisposable // TypeDefIndex: 4389
{
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
	public abstract string CommandText { get; set; }
	public abstract int CommandTimeout { get; set; }
	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
	public abstract CommandType CommandType { set; }
	[DefaultValueAttribute] 
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DbConnection Connection { get; set; }
	protected abstract DbConnection DbConnection { get; set; }
	protected abstract DbParameterCollection DbParameterCollection { get; }
	protected abstract DbTransaction DbTransaction { get; set; }
	[EditorBrowsableAttribute] 
	[DefaultValueAttribute] 
	[DesignOnlyAttribute] 
	[BrowsableAttribute] 
	public abstract bool DesignTimeVisible { get; set; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	public DbParameterCollection Parameters { get; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	[DefaultValueAttribute] 
	public DbTransaction Transaction { get; set; }
	[DefaultValueAttribute] 
	public abstract UpdateRowSource UpdatedRowSource { get; set; }


	protected void .ctor() { }

	public abstract string get_CommandText();

	public abstract void set_CommandText(string value);

	public abstract int get_CommandTimeout();

	public abstract void set_CommandTimeout(int value);

	public abstract void set_CommandType(CommandType value);

	public DbConnection get_Connection() { }

	public void set_Connection(DbConnection value) { }

	protected abstract DbConnection get_DbConnection();

	protected abstract void set_DbConnection(DbConnection value);

	protected abstract DbParameterCollection get_DbParameterCollection();

	protected abstract DbTransaction get_DbTransaction();

	protected abstract void set_DbTransaction(DbTransaction value);

	public abstract bool get_DesignTimeVisible();

	public abstract void set_DesignTimeVisible(bool value);

	public DbParameterCollection get_Parameters() { }

	public DbTransaction get_Transaction() { }

	public void set_Transaction(DbTransaction value) { }

	public abstract UpdateRowSource get_UpdatedRowSource();

	public abstract void set_UpdatedRowSource(UpdateRowSource value);

	public DbParameter CreateParameter() { }

	protected abstract DbParameter CreateDbParameter();

	protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);

	public abstract int ExecuteNonQuery();

	public DbDataReader ExecuteReader(CommandBehavior behavior) { }

	public abstract void Prepare();

}

public abstract class DbConnection : Component, IDisposable // TypeDefIndex: 4390
{
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
	[RecommendedAsConfigurableAttribute] 
	[SettingsBindableAttribute] 
	public abstract string ConnectionString { get; set; }
	[BrowsableAttribute] 
	public abstract ConnectionState State { get; }


	protected void .ctor() { }

	public abstract string get_ConnectionString();

	public abstract void set_ConnectionString(string value);

	public abstract ConnectionState get_State();

	protected abstract DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);

	public abstract void Close();

	public DbCommand CreateCommand() { }

	protected abstract DbCommand CreateDbCommand();

	public virtual void EnlistTransaction(Transaction transaction) { }

	public virtual DataTable GetSchema(string collectionName) { }

	public virtual DataTable GetSchema(string collectionName, string[] restrictionValues) { }

	public abstract void Open();

}

public abstract class DbDataAdapter : DataAdapter // TypeDefIndex: 4391
{
	internal static readonly object s_parameterValueNonNullValue; 
	internal static readonly object s_parameterValueNullValue; 

	private IDbDataAdapter _IDbDataAdapter { get; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DbCommand DeleteCommand { get; set; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DbCommand InsertCommand { get; set; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public DbCommand SelectCommand { get; }
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	public DbCommand UpdateCommand { get; set; }


	private IDbDataAdapter get__IDbDataAdapter() { }

	public DbCommand get_DeleteCommand() { }

	public void set_DeleteCommand(DbCommand value) { }

	public DbCommand get_InsertCommand() { }

	public void set_InsertCommand(DbCommand value) { }

	public DbCommand get_SelectCommand() { }

	public DbCommand get_UpdateCommand() { }

	public void set_UpdateCommand(DbCommand value) { }

	private static void .cctor() { }

}

public abstract class DbDataReader : MarshalByRefObject, IDataReader, IDisposable, IDataRecord, IEnumerable // TypeDefIndex: 4392
{
	public abstract int FieldCount { get; }
	public abstract int RecordsAffected { get; }
	public virtual int VisibleFieldCount { get; }
	public abstract object Item { get; }


	protected void .ctor() { }

	public abstract int get_FieldCount();

	public abstract int get_RecordsAffected();

	public virtual int get_VisibleFieldCount() { }

	public abstract object get_Item(int ordinal);

	public virtual void Close() { }

	[EditorBrowsableAttribute] 
	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract string GetDataTypeName(int ordinal);

	[EditorBrowsableAttribute] 
	public abstract IEnumerator GetEnumerator();

	public abstract Type GetFieldType(int ordinal);

	public abstract string GetName(int ordinal);

	public virtual DataTable GetSchemaTable() { }

	public abstract bool GetBoolean(int ordinal);

	public abstract int GetInt32(int ordinal);

	public abstract long GetInt64(int ordinal);

	public abstract string GetString(int ordinal);

	public abstract object GetValue(int ordinal);

	public abstract int GetValues(object[] values);

	public abstract bool IsDBNull(int ordinal);

	public abstract bool NextResult();

	public abstract bool Read();

}

public abstract class DbDataRecord : ICustomTypeDescriptor, IDataRecord // TypeDefIndex: 4393
{
	public abstract int FieldCount { get; }
	public abstract object Item { get; }


	protected void .ctor() { }

	public abstract int get_FieldCount();

	public abstract object get_Item(int i);

	public abstract string GetDataTypeName(int i);

	public abstract Type GetFieldType(int i);

	public abstract string GetName(int i);

	public abstract object GetValue(int i);

	public abstract int GetValues(object[] values);

	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

public class DbEnumerator : IEnumerator // TypeDefIndex: 4394
{
	internal IDataReader _reader; 
	internal DbDataRecord _current; 
	internal SchemaInfo[] _schemaInfo; 
	internal PropertyDescriptorCollection _descriptors; 
	private FieldNameLookup _fieldNameLookup; 
	private bool _closeReader; 

	public object Current { get; }


	public void .ctor(IDataReader reader, bool closeReader) { }

	public void .ctor(DbDataReader reader, bool closeReader) { }

	public object get_Current() { }

	public bool MoveNext() { }

	[EditorBrowsableAttribute] 
	public void Reset() { }

	private void BuildSchemaInfo() { }

}

private sealed class DbEnumerator.DbColumnDescriptor : PropertyDescriptor // TypeDefIndex: 4395
{
	private int _ordinal; 
	private Type _type; 

	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }


	internal void .ctor(int ordinal, string name, Type type) { }

	public override Type get_ComponentType() { }

	public override bool get_IsReadOnly() { }

	public override Type get_PropertyType() { }

	public override object GetValue(object component) { }

	public override void SetValue(object component, object value) { }

	public override bool ShouldSerializeValue(object component) { }

}

public abstract class DbException : ExternalException // TypeDefIndex: 4396
{

	protected void .ctor() { }

	protected void .ctor(string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public static class DbMetaDataCollectionNames // TypeDefIndex: 4397
{
	public static readonly string MetaDataCollections; 
	public static readonly string DataSourceInformation; 
	public static readonly string DataTypes; 
	public static readonly string Restrictions; 
	public static readonly string ReservedWords; 


	private static void .cctor() { }

}

public static class DbMetaDataColumnNames // TypeDefIndex: 4398
{
	public static readonly string CollectionName; 
	public static readonly string ColumnSize; 
	public static readonly string CompositeIdentifierSeparatorPattern; 
	public static readonly string CreateFormat; 
	public static readonly string CreateParameters; 
	public static readonly string DataSourceProductName; 
	public static readonly string DataSourceProductVersion; 
	public static readonly string DataType; 
	public static readonly string DataSourceProductVersionNormalized; 
	public static readonly string GroupByBehavior; 
	public static readonly string IdentifierCase; 
	public static readonly string IdentifierPattern; 
	public static readonly string IsAutoIncrementable; 
	public static readonly string IsBestMatch; 
	public static readonly string IsCaseSensitive; 
	public static readonly string IsConcurrencyType; 
	public static readonly string IsFixedLength; 
	public static readonly string IsFixedPrecisionScale; 
	public static readonly string IsLiteralSupported; 
	public static readonly string IsLong; 
	public static readonly string IsNullable; 
	public static readonly string IsSearchable; 
	public static readonly string IsSearchableWithLike; 
	public static readonly string IsUnsigned; 
	public static readonly string LiteralPrefix; 
	public static readonly string LiteralSuffix; 
	public static readonly string MaximumScale; 
	public static readonly string MinimumScale; 
	public static readonly string NumberOfIdentifierParts; 
	public static readonly string NumberOfRestrictions; 
	public static readonly string OrderByColumnsInSelect; 
	public static readonly string ParameterMarkerFormat; 
	public static readonly string ParameterMarkerPattern; 
	public static readonly string ParameterNameMaxLength; 
	public static readonly string ParameterNamePattern; 
	public static readonly string ProviderDbType; 
	public static readonly string QuotedIdentifierCase; 
	public static readonly string QuotedIdentifierPattern; 
	public static readonly string ReservedWord; 
	public static readonly string StatementSeparatorPattern; 
	public static readonly string StringLiteralPattern; 
	public static readonly string SupportedJoinOperators; 
	public static readonly string TypeName; 


	private static void .cctor() { }

}

public abstract class DbParameter : MarshalByRefObject // TypeDefIndex: 4399
{
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	[RefreshPropertiesAttribute] 
	public abstract DbType DbType { get; set; }
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
	public abstract ParameterDirection Direction { get; set; }
	[DesignOnlyAttribute] 
	[BrowsableAttribute] 
	[EditorBrowsableAttribute] 
	public abstract bool IsNullable { get; set; }
	[DefaultValueAttribute] 
	public abstract string ParameterName { get; set; }
	public abstract int Size { set; }
	[DefaultValueAttribute] 
	public abstract string SourceColumn { get; set; }
	[EditorBrowsableAttribute] 
	[DefaultValueAttribute] 
	[RefreshPropertiesAttribute] 
	public abstract bool SourceColumnNullMapping { set; }
	[DefaultValueAttribute] 
	public virtual DataRowVersion SourceVersion { get; set; }
	[RefreshPropertiesAttribute] 
	[DefaultValueAttribute] 
	public abstract object Value { get; set; }


	protected void .ctor() { }

	public abstract DbType get_DbType();

	public abstract void set_DbType(DbType value);

	public abstract ParameterDirection get_Direction();

	public abstract void set_Direction(ParameterDirection value);

	public abstract bool get_IsNullable();

	public abstract void set_IsNullable(bool value);

	public abstract string get_ParameterName();

	public abstract void set_ParameterName(string value);

	public abstract void set_Size(int value);

	public abstract string get_SourceColumn();

	public abstract void set_SourceColumn(string value);

	public abstract void set_SourceColumnNullMapping(bool value);

	public virtual DataRowVersion get_SourceVersion() { }

	public virtual void set_SourceVersion(DataRowVersion value) { }

	public abstract object get_Value();

	public abstract void set_Value(object value);

}

public abstract class DbParameterCollection : MarshalByRefObject, IList, ICollection, IEnumerable // TypeDefIndex: 4400
{
	[DesignerSerializationVisibilityAttribute] 
	[BrowsableAttribute] 
	public abstract int Count { get; }
	[EditorBrowsableAttribute] 
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public virtual bool IsFixedSize { get; }
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	[EditorBrowsableAttribute] 
	public virtual bool IsReadOnly { get; }
	[EditorBrowsableAttribute] 
	[BrowsableAttribute] 
	[DesignerSerializationVisibilityAttribute] 
	public abstract object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	public DbParameter Item { get; }


	protected void .ctor() { }

	public abstract int get_Count();

	public virtual bool get_IsFixedSize() { }

	public virtual bool get_IsReadOnly() { }

	public abstract object get_SyncRoot();

	private object System.Collections.IList.get_Item(int index) { }

	private void System.Collections.IList.set_Item(int index, object value) { }

	public DbParameter get_Item(int index) { }

	public abstract int Add(object value);

	public abstract bool Contains(object value);

	public abstract void CopyTo(Array array, int index);

	public abstract void Clear();

	[EditorBrowsableAttribute] 
	public abstract IEnumerator GetEnumerator();

	protected abstract DbParameter GetParameter(int index);

	public abstract int IndexOf(object value);

	public abstract int IndexOf(string parameterName);

	public abstract void Insert(int index, object value);

	public abstract void Remove(object value);

	public abstract void RemoveAt(int index);

	protected abstract void SetParameter(int index, DbParameter value);

}

public abstract class DbProviderFactory // TypeDefIndex: 4401
{

	protected void .ctor() { }

}

public sealed class DbProviderSpecificTypePropertyAttribute : Attribute // TypeDefIndex: 4402
{
	[CompilerGeneratedAttribute] 
	private readonly bool <IsProviderSpecificTypeProperty>k__BackingField; 


	public void .ctor(bool isProviderSpecificTypeProperty) { }

}

public abstract class DbTransaction : MarshalByRefObject, IDisposable // TypeDefIndex: 4403
{

	protected void .ctor() { }

	public abstract void Commit();

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract void Rollback();

}

public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5709
{

[AttributeUsageAttribute] 
public sealed class DataContractAttribute : Attribute
	private bool isReference; 

	public bool IsReference { get; }


	public bool get_IsReference() { }

}

public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 5710
{
	private string name; 
	private int order; 
	private bool isRequired; 
	private bool emitDefaultValue; 

	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }


	public string get_Name() { }

	public int get_Order() { }

	public bool get_IsRequired() { }

	public bool get_EmitDefaultValue() { }

}

public static class Database // TypeDefIndex: 6185
{

	public static void Insert(string parent, object contents, Action<bool> onFinished) { }

	public static void Insert(string parent, object contents, Action<bool, string> onFinished) { }

	public static void Remove(string parent, string id, Action<bool> onFinished) { }

	public static Result<T> Query<T>(string parent, int limit, Action<Result<T>> onFinished) { }
	/* GenericInstMethod :
	|
	|-Database.Query<object>
	*/

	public static void Count(string parent, Action<int> onResult) { }

}

private sealed class Database.<>c__DisplayClass0_0 // TypeDefIndex: 6186
{
	public Action<bool> onFinished; 


	public void .ctor() { }

	internal void <Insert>b__0(bool success, string id) { }

}

private sealed class Database.<>c__DisplayClass1_0 // TypeDefIndex: 6187
{
	public Action<bool, string> onFinished; 


	public void .ctor() { }

	internal void <Insert>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass2_0 // TypeDefIndex: 6188
{
	public Action<bool> onFinished; 


	public void .ctor() { }

	internal void <Remove>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass3_0<T> // TypeDefIndex: 6189
{
	public Result<T> result; 
	public Action<Result<T>> onFinished; 
	public Action <>9__1; 


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Database.<>c__DisplayClass3_0<object>..ctor
	*/

	internal void <Query>b__0(object s, DownloadStringCompletedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__0
	*/

	internal void <Query>b__1() { }
	/* GenericInstMethod :
	|
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__1
	*/

}

private sealed class Database.<>c__3<T> // TypeDefIndex: 6190
{
	public static readonly Database.<>c__3<T> <>9; 
	public static Func<QueryResponse, Result.Entry<T>> <>9__3_2; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-Database.<>c__3<object>..cctor
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Database.<>c__3<object>..ctor
	*/

	internal Result.Entry<T> <Query>b__3_2(QueryResponse x) { }
	/* GenericInstMethod :
	|
	|-Database.<>c__3<object>.<Query>b__3_2
	*/

}

private sealed class Database.<>c__DisplayClass4_0 // TypeDefIndex: 6191
{
	public Action<int> onResult; 


	public void .ctor() { }

	internal void <Count>b__0(object s, DownloadStringCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass4_1 // TypeDefIndex: 6192
{
	public int count; 
	public Database.<>c__DisplayClass4_0 CS$<>8__locals1; 


	public void .ctor() { }

	internal void <Count>b__1() { }

}

public class Database // TypeDefIndex: 7363
{

public class Database
	private IntPtr _connection; 
	[CompilerGeneratedAttribute] 
	private bool <IsConnectionOpen>k__BackingField; 

	private bool IsConnectionOpen { get; set; }
	public int AffectedRows { get; }


	[CompilerGeneratedAttribute] 
	private bool get_IsConnectionOpen() { }

	[CompilerGeneratedAttribute] 
	private void set_IsConnectionOpen(bool value) { }

	public void Open(string path, bool fastMode = False) { }

	public bool TableExists(string name) { }

	public bool IndexExists(string tableName, string indexName) { }

	public bool ColumnExists(string tableName, string columnName) { }

	public void Close() { }

	public int get_AffectedRows() { }

	public void Execute(string query) { }

	public void Execute<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-Database.Execute<int>
	|
	|-Database.Execute<object>
	*/

	public void Execute<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-Database.Execute<int, int>
	|
	|-Database.Execute<object, object>
	*/

	public void Execute<T1, T2, T3>(string query, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-Database.Execute<int, int, int>
	|
	|-Database.Execute<object, object, object>
	*/

	public void Execute<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-Database.Execute<int, int, int, int>
	|
	|-Database.Execute<object, object, object, object>
	*/

	public void Execute<T1, T2, T3, T4, T5>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-Database.Execute<int, byte[], int, int, int>
	|-Database.Execute<int, object, int, int, int>
	|
	|-Database.Execute<object, object, object, object, object>
	*/

	protected static void Bind<T>(IntPtr stmHandle, int index, T value) { }
	/* GenericInstMethod :
	|
	|-Database.Bind<int>
	|
	|-Database.Bind<object>
	*/

	protected static T GetColumnValue<T>(IntPtr stmHandle, int i) { }
	/* GenericInstMethod :
	|
	|-Database.GetColumnValue<int>
	|
	|-Database.GetColumnValue<long>
	|
	|-Database.GetColumnValue<object>
	*/

	public int QueryInt(string query) { }

	public int QueryInt<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-Database.QueryInt<object>
	|-Database.QueryInt<string>
	*/

	public int QueryInt<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-Database.QueryInt<object, object>
	|-Database.QueryInt<string, string>
	*/

	public long QueryLong(string query) { }

	public string QueryString<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-Database.QueryString<object>
	*/

	public byte[] QueryBlob<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-Database.QueryBlob<object>
	*/

	public byte[] QueryBlob<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-Database.QueryBlob<int, int, int, int>
	|
	|-Database.QueryBlob<object, object, object, object>
	*/

	public void BeginTransaction() { }

	public void Commit() { }

	public void Rollback() { }

	protected void ExecuteQuery(IntPtr stmHandle, bool finalize = True) { }

	protected T ExecuteAndReadQueryResult<T>(IntPtr stmHandle, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-Database.ExecuteAndReadQueryResult<byte[]>
	|-Database.ExecuteAndReadQueryResult<object>
	|-Database.ExecuteAndReadQueryResult<string>
	|
	|-Database.ExecuteAndReadQueryResult<int>
	|
	|-Database.ExecuteAndReadQueryResult<long>
	*/

	[IteratorStateMachineAttribute] 
	protected IEnumerable<T> ExecuteAndReadQueryResults<T>(IntPtr stmHandle, Func<IntPtr, T> rowReader, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-Database.ExecuteAndReadQueryResults<object>
	*/

	protected IntPtr Prepare(string query) { }

	private void FinalizeOrReset(IntPtr stmHandle, bool finalize = True) { }

	protected void Finalize(IntPtr stmHandle) { }

	protected void Reset(IntPtr stmHandle) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	internal static Exception <GetColumnValue>g__TypeError|19_0<T>(ref Database.<>c__DisplayClass19_0<T> ) { }
	/* GenericInstMethod :
	|
	|-Database.<GetColumnValue>g__TypeError|19_0<int>
	|
	|-Database.<GetColumnValue>g__TypeError|19_0<long>
	|
	|-Database.<GetColumnValue>g__TypeError|19_0<object>
	*/

}

private struct Database.<>c__DisplayClass19_0<T> // TypeDefIndex: 7364
{
	public int type; 

}

private sealed class Database.<ExecuteAndReadQueryResults>d__32<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 7365
{
	private int <>1__state; 
	private T <>2__current; 
	private int <>l__initialThreadId; 
	private Func<IntPtr, T> rowReader; 
	public Func<IntPtr, T> <>3__rowReader; 
	private IntPtr stmHandle; 
	public IntPtr <>3__stmHandle; 
	public Database <>4__this; 
	private bool finalize; 
	public bool <>3__finalize; 

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>..ctor
	*/

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] 
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal static class DataTypesUtilities // TypeDefIndex: 7629
{

	public static ushort Combine(SevenBitNumber head, SevenBitNumber tail) { }

	public static ushort CombineAsSevenBitNumbers(byte head, byte tail) { }

	[ExtensionAttribute] 
	public static FourBitNumber GetTail(byte number) { }

	[ExtensionAttribute] 
	public static SevenBitNumber GetTail(ushort number) { }

	[ExtensionAttribute] 
	public static byte GetTail(short number) { }

	[ExtensionAttribute] 
	public static FourBitNumber GetHead(byte number) { }

	[ExtensionAttribute] 
	public static SevenBitNumber GetHead(ushort number) { }

	[ExtensionAttribute] 
	public static byte GetHead(short number) { }

}

internal abstract class DbcsEncoding : MonoEncoding // TypeDefIndex: 7832
{
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }


	public void .ctor(int codePage) { }

	public void .ctor(int codePage, int windowsCodePage) { }

	internal abstract DbcsConvert GetConvert();

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override bool get_IsBrowserDisplay() { }

	public override bool get_IsBrowserSave() { }

	public override bool get_IsMailNewsDisplay() { }

	public override bool get_IsMailNewsSave() { }

}

internal abstract class DbcsEncoding.DbcsDecoder : Decoder // TypeDefIndex: 7833
{
	protected DbcsConvert convert; 


	public void .ctor(DbcsConvert convert) { }

	internal void CheckRange(byte[] bytes, int index, int count) { }

	internal void CheckRange(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

internal class DbcsConvert // TypeDefIndex: 7834
{
	public byte[] n2u; 
	public byte[] u2n; 
	internal static readonly DbcsConvert Gb2312; 
	internal static readonly DbcsConvert Big5; 
	internal static readonly DbcsConvert KS; 


	internal void .ctor(string fileName) { }

	private static void .cctor() { }

}

public struct DataRecord // TypeDefIndex: 8815
{
	[CompilerGeneratedAttribute] 
	private Utf8String <Key>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Value>k__BackingField; 

	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_Key() { }

	[CompilerGeneratedAttribute] 
	public void set_Key(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Value() { }

	[CompilerGeneratedAttribute] 
	public void set_Value(Utf8String value) { }

	internal void Set(ref DataRecordInternal other) { }

}

internal struct DataRecordInternal : IGettable<DataRecord>, ISettable<DataRecord>, IDisposable // TypeDefIndex: 8816
{
	private int m_ApiVersion; 
	private IntPtr m_Key; 
	private IntPtr m_Value; 

	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }


	public Utf8String get_Key() { }

	public void set_Key(Utf8String value) { }

	public Utf8String get_Value() { }

	public void set_Value(Utf8String value) { }

	public void Set(ref DataRecord other) { }

	public void Set(ref Nullable<DataRecord> other) { }

	public void Dispose() { }

	public void Get(out DataRecord output) { }

}

public class Data : ConsoleSystem // TypeDefIndex: 13635
{

	[ServerVar] 
	[ClientVar] 
	public static void export(ConsoleSystem.Arg args) { }

	public void .ctor() { }

}


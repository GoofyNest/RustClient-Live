public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 201
{	public static readonly DBNull Value; // 0x2B0AA90


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
{	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static DataCollector ThreadInstance; // 0x80000000
	private byte* scratchEnd; // 0x0
	private EventSource.EventData* datasEnd; // 0x8
	private GCHandle* pinsEnd; // 0x10
	private EventSource.EventData* datasStart; // 0x18
	private byte* scratch; // 0x20
	private EventSource.EventData* datas; // 0x28
	private GCHandle* pins; // 0x30
	private byte[] buffer; // 0x38
	private int bufferPos; // 0x40
	private int bufferNesting; // 0x44
	private bool writingScalars; // 0x48


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
{	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

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
{	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

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
{	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 2185
{	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }


	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 2186
{	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	public override XmlTypeCode TypeCode { get; }


	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 2193
{	public override XmlTypeCode TypeCode { get; }


	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 2194
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

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
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 2201
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 2202
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 2203
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 2204
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 2205
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 2206
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal void .ctor() { }

}

internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 2207
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal override bool get_HasValueFacets() { }

	public void .ctor() { }

}

internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 2212
{	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override bool get_HasValueFacets() { }

	public void .ctor() { }

}

internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 2213
{	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public void .ctor() { }

}

internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 2214
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_language : Datatype_token // TypeDefIndex: 2215
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 2216
{	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_Name : Datatype_token // TypeDefIndex: 2217
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

}

internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 2218
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

}

internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 2219
{	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 2220
{	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 2221
{	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTypeCode get_TypeCode() { }

	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 2222
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	public override XmlTypeCode TypeCode { get; }


	public override XmlTypeCode get_TypeCode() { }

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	public void .ctor() { }

}

internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 2224
{	private static readonly FacetsChecker numeric10FacetsChecker; // 0x1356E

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
{	private static readonly FacetsChecker numeric10FacetsChecker; // 0x2B0AF6C

	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }


	internal override FacetsChecker get_FacetsChecker() { }

	public override XmlTypeCode get_TypeCode() { }

	public void .ctor() { }

	private static void .cctor() { }

}

internal class Datatype_long : Datatype_integer // TypeDefIndex: 2226
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly FacetsChecker numeric10FacetsChecker; // 0x13570

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

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
{	private static readonly FacetsChecker numeric10FacetsChecker; // 0x135C8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	public override XmlTokenizedType TokenizedType { get; }


	public override XmlTokenizedType get_TokenizedType() { }

	public void .ctor() { }

}

internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 2240
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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
{	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

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

public sealed class DataUtility // TypeDefIndex: 3576
{
	public static Vector4 GetInnerUV(Sprite sprite) { }

	public static Vector4 GetOuterUV(Sprite sprite) { }

	public static Vector4 GetPadding(Sprite sprite) { }

	public static Vector2 GetMinSize(Sprite sprite) { }

}

internal class DataCommonEventSource : EventSource // TypeDefIndex: 4171
{	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8


	[EventAttribute] // RVA: 0x9AAF0 Offset: 0x99EF0 VA: 0x18009AAF0
	internal void Trace(string message) { }

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<Exception>
	|-DataCommonEventSource.Trace<object>
	|
	|-DataCommonEventSource.Trace<int>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|-DataCommonEventSource.Trace<int, string, int, int, bool>
	|
	|-DataCommonEventSource.Trace<object, object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-DataCommonEventSource.Trace<object, object, object, object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B0A0 Offset: 0x9A4A0 VA: 0x18009B0A0
	internal long EnterScope(string message) { }

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.EnterScope<int>
	|
	|-DataCommonEventSource.EnterScope<object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-DataCommonEventSource.EnterScope<int, int, bool, MissingSchemaAction>
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-DataCommonEventSource.EnterScope<object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B3E0 Offset: 0x9A7E0 VA: 0x18009B3E0
	internal void ExitScope(long scopeId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class DataColumn : MarshalByValueComponent // TypeDefIndex: 4181
{	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	[DefaultValueAttribute] // RVA: 0x9D4D0 Offset: 0x9C8D0 VA: 0x18009D4D0
	public bool AllowDBNull { get; set; }
	[DefaultValueAttribute] // RVA: 0x9D520 Offset: 0x9C920 VA: 0x18009D520
	[RefreshPropertiesAttribute] // RVA: 0x9D520 Offset: 0x9C920 VA: 0x18009D520
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValueAttribute] // RVA: 0x9DA20 Offset: 0x9CE20 VA: 0x18009DA20
	public long AutoIncrementSeed { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DAB0 Offset: 0x9CEB0 VA: 0x18009DAB0
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DB40 Offset: 0x9CF40 VA: 0x18009DB40
	[RefreshPropertiesAttribute] // RVA: 0x9DB40 Offset: 0x9CF40 VA: 0x18009DB40
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[RefreshPropertiesAttribute] // RVA: 0x9DC30 Offset: 0x9D030 VA: 0x18009DC30
	[DefaultValueAttribute] // RVA: 0x9DC30 Offset: 0x9D030 VA: 0x18009DC30
	[TypeConverterAttribute] // RVA: 0x9DC30 Offset: 0x9D030 VA: 0x18009DC30
	public Type DataType { get; set; }
	[DefaultValueAttribute] // RVA: 0x9DEC0 Offset: 0x9D2C0 VA: 0x18009DEC0
	[RefreshPropertiesAttribute] // RVA: 0x9DEC0 Offset: 0x9D2C0 VA: 0x18009DEC0
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverterAttribute] // RVA: 0x9E080 Offset: 0x9D480 VA: 0x18009E080
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[DefaultValueAttribute] // RVA: 0x9DB40 Offset: 0x9CF40 VA: 0x18009DB40
	[RefreshPropertiesAttribute] // RVA: 0x9DB40 Offset: 0x9CF40 VA: 0x18009DB40
	public string Expression { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValueAttribute] // RVA: 0x9E5D0 Offset: 0x9D9D0 VA: 0x18009E5D0
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	[BrowsableAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	public int Ordinal { get; }
	[DefaultValueAttribute] // RVA: 0x9E700 Offset: 0x9DB00 VA: 0x18009E700
	public bool ReadOnly { get; set; }
	[DebuggerBrowsableAttribute] // RVA: 0x9E7F0 Offset: 0x9DBF0 VA: 0x18009E7F0
	private Index SortIndex { get; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E910 Offset: 0x9DD10 VA: 0x18009E910
	[DefaultValueAttribute] // RVA: 0x9E910 Offset: 0x9DD10 VA: 0x18009E910
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValueAttribute] // RVA: 0x9EA20 Offset: 0x9DE20 VA: 0x18009EA20
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal string get_XmlDataType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 4185
{	private DataColumn _column; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object <ProposedValue>k__BackingField; // 0x20

	public object ProposedValue { get; set; }


	internal void .ctor(DataRow row) { }

	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public object get_ProposedValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ProposedValue(object value) { }

	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 4186
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataColumnChangeEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 4187
{	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4188
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataColumn <Column>k__BackingField; // 0x88

	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }


	internal void .ctor(DataColumn dataColumn) { }

	public override AttributeCollection get_Attributes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

internal sealed class DataError // TypeDefIndex: 4189
{	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

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

internal struct DataError.ColumnError // TypeDefIndex: 4190
{	internal DataColumn _column; // 0x0
	internal string _error; // 0x8

}

public class DataException : SystemException // TypeDefIndex: 4191
{
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public void .ctor() { }

	public void .ctor(string s) { }

	public void .ctor(string s, Exception innerException) { }

}

internal struct DataKey // TypeDefIndex: 4202
{	private readonly DataColumn[] _columns; // 0x0

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

public class DataRelation // TypeDefIndex: 4203
{	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal bool _nested; // 0x48
	internal bool _createConstraints; // 0x49
	private bool _checkMultipleNested; // 0x4A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertyChangedEventHandler PropertyChanging; // 0x50

	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public virtual DataSet DataSet { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public virtual string RelationName { get; }
	[DefaultValueAttribute] // RVA: 0x9E700 Offset: 0x9DB00 VA: 0x18009E700
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
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

public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 4204
{	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

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

internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 4205
{	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }


	internal void .ctor(DataTable table, bool fParentCollection) { }

	protected override ArrayList get_List() { }

	private void EnsureDataSet() { }

	protected override DataSet GetDataSet() { }

	public override DataRelation get_Item(int index) { }

	public override DataRelation get_Item(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	private void AddCache(DataRelation relation) { }

	protected override void AddCore(DataRelation relation) { }

	private void RemoveCache(DataRelation relation) { }

	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 4206
{	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

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

internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4207
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }


	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public class DataRow // TypeDefIndex: 4208
{	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

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

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public void BeginEdit() { }

	private bool BeginEditInternal() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public void CancelEdit() { }

	private void CheckColumn(DataColumn column) { }

	internal void CheckInTable() { }

	public void Delete() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
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

public sealed class DataRowBuilder // TypeDefIndex: 4209
{	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18


	internal void .ctor(DataTable table, int record) { }

}

public enum DataRowAction // TypeDefIndex: 4210
{	public int value__; // 0x0
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;

}

public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 4211
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRowAction <Action>k__BackingField; // 0x18


	public void .ctor(DataRow row, DataRowAction action) { }

}

public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 4212
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataRowChangeEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 4213
{	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

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

private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 4214
{
	internal void .ctor() { }

	protected override int CompareNode(DataRow record1, DataRow record2) { }

	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 4215
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataRow r) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataRow r, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 4216
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataTable table) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataTable table, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum DataRowState // TypeDefIndex: 4217
{	public int value__; // 0x0
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;

}

public enum DataRowVersion // TypeDefIndex: 4218
{	public int value__; // 0x0
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;

}

public class DataRowView : ICustomTypeDescriptor // TypeDefIndex: 4219
{	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertyChangedEventHandler PropertyChanged; // 0x28

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

public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 4221
{	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8

	[DefaultValueAttribute] // RVA: 0xA2A00 Offset: 0xA1E00 VA: 0x1800A2A00
	public SerializationFormat RemotingFormat { get; set; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValueAttribute] // RVA: 0x9E700 Offset: 0x9DB00 VA: 0x18009E700
	public bool CaseSensitive { get; set; }
	[DefaultValueAttribute] // RVA: 0x9D4D0 Offset: 0x9C8D0 VA: 0x18009D4D0
	public bool EnforceConstraints { get; set; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string DataSetName { get; set; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string Prefix { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public override ISite Site { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
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

public enum DataSetDateTime // TypeDefIndex: 4222
{	public int value__; // 0x0
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;

}

public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 4223
{	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _savedEnforceConstraints; // 0x16C
	private bool _inDataLoad; // 0x16D
	private bool _initialLoad; // 0x16E
	private bool _schemaLoading; // 0x16F
	private bool _enforceConstraints; // 0x170
	internal bool _suspendEnforceConstraints; // 0x171
	protected internal bool fInitInProgress; // 0x172
	private bool _inLoad; // 0x173
	internal bool _fInLoadDiffgram; // 0x174
	private byte _isTypedDataTable; // 0x175
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private readonly DataRowBuilder _rowBuilder; // 0x1F0
	internal readonly List<DataView> _delayedViews; // 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; // 0x200
	internal Hashtable _rowDiffId; // 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x210
	internal int _ukColumnPositionForInference; // 0x218
	private SerializationFormat _remotingFormat; // 0x21C
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x220

	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsableAttribute] // RVA: 0x9E7F0 Offset: 0x9DBF0 VA: 0x18009E7F0
	internal List<Index> LiveIndexes { get; }
	[DefaultValueAttribute] // RVA: 0xA3360 Offset: 0xA2760 VA: 0x1800A3360
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public ConstraintCollection Constraints { get; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public DataSet DataSet { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValueAttribute] // RVA: 0xA3740 Offset: 0xA2B40 VA: 0x1800A3740
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverterAttribute] // RVA: 0xA3930 Offset: 0xA2D30 VA: 0x1800A3930
	public DataColumn[] PrimaryKey { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public DataRowCollection Rows { get; }
	[RefreshPropertiesAttribute] // RVA: 0xA3AE0 Offset: 0xA2EE0 VA: 0x1800A3AE0
	[DefaultValueAttribute] // RVA: 0xA3AE0 Offset: 0xA2EE0 VA: 0x1800A3AE0
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
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

internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 4224
{	private DataTable _targetTable; // 0x0


	internal void Prepare(DataTable table) { }

}

internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 4225
{	private DataSet _targetDS; // 0x0


	internal void Prepare(DataSet ds) { }

}

public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 4226
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataTable <Table>k__BackingField; // 0x10


	public void .ctor(DataTable dataTable) { }

}

public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 4227
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataTableClearEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 4228
{	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

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

public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 4229
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRow <Row>k__BackingField; // 0x10


	public void .ctor(DataRow dataRow) { }

}

public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 4230
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DataTableNewRowEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4232
{
[DefaultEventAttribute] // RVA: 0xA4320 Offset: 0xA3720 VA: 0x1800A4320
[DefaultPropertyAttribute] // RVA: 0xA4320 Offset: 0xA3720 VA: 0x1800A4320
[DefaultMemberAttribute] // RVA: 0xA4320 Offset: 0xA3720 VA: 0x1800A4320
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4232
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private DataViewRowState _delayedRecordStates; // 0x88
	private bool _fEndInitInProgress; // 0x8C
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0x90
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0x98
	private DataViewListener _dvListener; // 0xA0
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xA8

	[DefaultValueAttribute] // RVA: 0x9D4D0 Offset: 0x9C8D0 VA: 0x18009D4D0
	public bool AllowDelete { get; }
	[DefaultValueAttribute] // RVA: 0x9D4D0 Offset: 0x9C8D0 VA: 0x18009D4D0
	public bool AllowNew { get; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public int Count { get; }
	private int CountFromIndex { get; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public DataViewManager DataViewManager { get; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	protected bool IsOpen { get; }
	[DefaultValueAttribute] // RVA: 0xA49F0 Offset: 0xA3DF0 VA: 0x1800A49F0
	public DataViewRowState RowStateFilter { get; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string Sort { get; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[RefreshPropertiesAttribute] // RVA: 0xA4C30 Offset: 0xA4030 VA: 0x1800A4C30
	[DefaultValueAttribute] // RVA: 0xA4C30 Offset: 0xA4030 VA: 0x1800A4C30
	[TypeConverterAttribute] // RVA: 0xA4C30 Offset: 0xA4030 VA: 0x1800A4C30
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

private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 4233
{	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x2B0AC04


	private void .ctor() { }

	public bool Equals(DataRow x, DataRow y) { }

	public int GetHashCode(DataRow obj) { }

	private static void .cctor() { }

}

internal sealed class DataViewListener // TypeDefIndex: 4234
{	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28


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

public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 4235
{	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	internal int _nViews; // 0x28
	private static NotSupportedException s_notSupported; // 0x0

	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public DataViewSettingCollection DataViewSettings { get; }


	public DataViewSettingCollection get_DataViewSettings() { }

	private static void .cctor() { }

}

public enum DataViewRowState // TypeDefIndex: 4236
{	public int value__; // 0x0
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;

}

public class DataViewSetting // TypeDefIndex: 4237
{	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

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

public class DataViewSettingCollection // TypeDefIndex: 4238
{	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	public virtual DataViewSetting Item { get; set; }


	public virtual DataViewSetting get_Item(DataTable table) { }

	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	internal void Remove(DataTable table) { }

}

public enum DbType // TypeDefIndex: 4239
{	public int value__; // 0x0
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

internal sealed class DataExpression : IFilter // TypeDefIndex: 4247
{	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

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

internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 4333
{	private XmlWriter _xmltextWriter; // 0x18

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

internal sealed class DataTextReader : XmlReader // TypeDefIndex: 4334
{	private XmlReader _xmlreader; // 0x10

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

public abstract class DbCommandBuilder : Component // TypeDefIndex: 4369
{	private DbDataAdapter _dataAdapter; // 0x28
	private DbCommand _insertCommand; // 0x30
	private DbCommand _updateCommand; // 0x38
	private DbCommand _deleteCommand; // 0x40
	private MissingMappingAction _missingMappingAction; // 0x48
	private ConflictOption _conflictDetection; // 0x4C
	private bool _setAllValues; // 0x50
	private bool _hasPartialPrimaryKey; // 0x51
	private DataTable _dbSchemaTable; // 0x58
	private DbSchemaRow[] _dbSchemaRows; // 0x60
	private string[] _sourceColumnNames; // 0x68
	private DbCommandBuilder.ParameterNames _parameterNames; // 0x70
	private string _quotedBaseTableName; // 0x78
	private CatalogLocation _catalogLocation; // 0x80
	private string _catalogSeparator; // 0x88
	private string _schemaSeparator; // 0x90
	private string _quotePrefix; // 0x98
	private string _quoteSuffix; // 0xA0
	private string _parameterNamePattern; // 0xA8
	private string _parameterMarkerFormat; // 0xB0
	private int _parameterNameMaxLength; // 0xB8

	[DefaultValueAttribute] // RVA: 0xA96E0 Offset: 0xA8AE0 VA: 0x1800A96E0
	public virtual ConflictOption ConflictOption { get; }
	[DefaultValueAttribute] // RVA: 0xA9850 Offset: 0xA8C50 VA: 0x1800A9850
	public virtual CatalogLocation CatalogLocation { get; }
	[DefaultValueAttribute] // RVA: 0xA98F0 Offset: 0xA8CF0 VA: 0x1800A98F0
	public virtual string CatalogSeparator { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	[BrowsableAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	public DbDataAdapter DataAdapter { get; set; }
	internal int ParameterNameMaxLength { get; }
	internal string ParameterNamePattern { get; }
	private string QuotedBaseTableName { get; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public virtual string QuotePrefix { get; set; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public virtual string QuoteSuffix { get; set; }
	[DefaultValueAttribute] // RVA: 0xA98F0 Offset: 0xA8CF0 VA: 0x1800A98F0
	public virtual string SchemaSeparator { get; }
	[DefaultValueAttribute] // RVA: 0x9E700 Offset: 0x9DB00 VA: 0x18009E700
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

private class DbCommandBuilder.ParameterNames // TypeDefIndex: 4370
{	private string _originalPrefix; // 0x10
	private string _isNullPrefix; // 0x18
	private Regex _parameterNameParser; // 0x20
	private DbCommandBuilder _dbCommandBuilder; // 0x28
	private string[] _baseParameterNames; // 0x30
	private string[] _originalParameterNames; // 0x38
	private string[] _nullParameterNames; // 0x40
	private bool[] _isMutatedName; // 0x48
	private int _count; // 0x50
	private int _genericParameterCount; // 0x54
	private int _adjustedParameterNameMaxLength; // 0x58


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

internal sealed class DbSchemaRow // TypeDefIndex: 4371
{	private DbSchemaTable _schemaTable; // 0x10
	private DataRow _dataRow; // 0x18

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

internal sealed class DbSchemaTable // TypeDefIndex: 4372
{	private static readonly string[] s_DBCOLUMN_NAME; // 0x0
	internal DataTable _dataTable; // 0x10
	private DataColumnCollection _columns; // 0x18
	private DataColumn[] _columnCache; // 0x20
	private bool _returnProviderSpecificTypes; // 0x28

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

private enum DbSchemaTable.ColumnEnum // TypeDefIndex: 4373
{	public int value__; // 0x0
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

public class DataAdapter : Component // TypeDefIndex: 4374
{	private static readonly object s_eventFillError; // 0x0
	private MissingMappingAction _missingMappingAction; // 0x28

	[DefaultValueAttribute] // RVA: 0xA9C10 Offset: 0xA9010 VA: 0x1800A9C10
	public MissingMappingAction MissingMappingAction { get; }


	public MissingMappingAction get_MissingMappingAction() { }

	private static void .cctor() { }

}

public sealed class DataColumnMapping : MarshalByRefObject // TypeDefIndex: 4375
{	private string _dataSetColumnName; // 0x18
	private string _sourceColumnName; // 0x20

	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string DataSetColumn { get; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string SourceColumn { get; }


	public string get_DataSetColumn() { }

	public string get_SourceColumn() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public DataColumn GetDataColumnBySchemaAction(DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public static DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	internal static DataColumn CreateDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

}

public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
{
[DefaultMemberAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
	private List<DataColumnMapping> _items; // 0x18

	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public int Count { get; }


	public int get_Count() { }

	public int IndexOf(string sourceColumn) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public static DataColumn GetDataColumn(DataColumnMappingCollection columnMappings, string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

internal sealed class DataRecordInternal : DbDataRecord, ICustomTypeDescriptor // TypeDefIndex: 4378
{	private SchemaInfo[] _schemaInfo; // 0x10
	private object[] _values; // 0x18
	private PropertyDescriptorCollection _propertyDescriptors; // 0x20
	private FieldNameLookup _fieldNameLookup; // 0x28

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

internal abstract class DataStorage // TypeDefIndex: 4381
{	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

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

public sealed class DataTableMapping : MarshalByRefObject // TypeDefIndex: 4382
{	private DataColumnMappingCollection _columnMappings; // 0x18


	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public DataColumn GetDataColumn(string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

public abstract class DbCommand : Component, IDbCommand, IDisposable // TypeDefIndex: 4386
{	[RefreshPropertiesAttribute] // RVA: 0xA3AE0 Offset: 0xA2EE0 VA: 0x1800A3AE0
	[DefaultValueAttribute] // RVA: 0xA3AE0 Offset: 0xA2EE0 VA: 0x1800A3AE0
	public abstract string CommandText { get; set; }
	public abstract int CommandTimeout { get; set; }
	[DefaultValueAttribute] // RVA: 0xAA4F0 Offset: 0xA98F0 VA: 0x1800AA4F0
	[RefreshPropertiesAttribute] // RVA: 0xAA4F0 Offset: 0xA98F0 VA: 0x1800AA4F0
	public abstract CommandType CommandType { set; }
	[DefaultValueAttribute] // RVA: 0xAA760 Offset: 0xA9B60 VA: 0x1800AA760
	[BrowsableAttribute] // RVA: 0xAA760 Offset: 0xA9B60 VA: 0x1800AA760
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAA760 Offset: 0xA9B60 VA: 0x1800AA760
	public DbConnection Connection { get; set; }
	protected abstract DbConnection DbConnection { get; set; }
	protected abstract DbParameterCollection DbParameterCollection { get; }
	protected abstract DbTransaction DbTransaction { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xAA8A0 Offset: 0xA9CA0 VA: 0x1800AA8A0
	[DefaultValueAttribute] // RVA: 0xAA8A0 Offset: 0xA9CA0 VA: 0x1800AA8A0
	[DesignOnlyAttribute] // RVA: 0xAA8A0 Offset: 0xA9CA0 VA: 0x1800AA8A0
	[BrowsableAttribute] // RVA: 0xAA8A0 Offset: 0xA9CA0 VA: 0x1800AA8A0
	public abstract bool DesignTimeVisible { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	[BrowsableAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	public DbParameterCollection Parameters { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAAC10 Offset: 0xAA010 VA: 0x1800AAC10
	[BrowsableAttribute] // RVA: 0xAAC10 Offset: 0xAA010 VA: 0x1800AAC10
	[DefaultValueAttribute] // RVA: 0xAAC10 Offset: 0xAA010 VA: 0x1800AAC10
	public DbTransaction Transaction { get; set; }
	[DefaultValueAttribute] // RVA: 0xAADC0 Offset: 0xAA1C0 VA: 0x1800AADC0
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

public abstract class DbConnection : Component, IDisposable // TypeDefIndex: 4387
{	[RefreshPropertiesAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	[DefaultValueAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	[RecommendedAsConfigurableAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	[SettingsBindableAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	public abstract string ConnectionString { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
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

public abstract class DbDataAdapter : DataAdapter // TypeDefIndex: 4388
{	internal static readonly object s_parameterValueNonNullValue; // 0x0
	internal static readonly object s_parameterValueNullValue; // 0x8

	private IDbDataAdapter _IDbDataAdapter { get; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public DbCommand DeleteCommand { get; set; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public DbCommand InsertCommand { get; set; }
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public DbCommand SelectCommand { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	[BrowsableAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
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

public abstract class DbDataReader : MarshalByRefObject, IDataReader, IDisposable, IDataRecord, IEnumerable // TypeDefIndex: 4389
{	public abstract int FieldCount { get; }
	public abstract int RecordsAffected { get; }
	public virtual int VisibleFieldCount { get; }
	public abstract object Item { get; }


	protected void .ctor() { }

	public abstract int get_FieldCount();

	public abstract int get_RecordsAffected();

	public virtual int get_VisibleFieldCount() { }

	public abstract object get_Item(int ordinal);

	public virtual void Close() { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract string GetDataTypeName(int ordinal);

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
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

public abstract class DbDataRecord : ICustomTypeDescriptor, IDataRecord // TypeDefIndex: 4390
{	public abstract int FieldCount { get; }
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

public class DbEnumerator : IEnumerator // TypeDefIndex: 4391
{	internal IDataReader _reader; // 0x10
	internal DbDataRecord _current; // 0x18
	internal SchemaInfo[] _schemaInfo; // 0x20
	internal PropertyDescriptorCollection _descriptors; // 0x28
	private FieldNameLookup _fieldNameLookup; // 0x30
	private bool _closeReader; // 0x38

	public object Current { get; }


	public void .ctor(IDataReader reader, bool closeReader) { }

	public void .ctor(DbDataReader reader, bool closeReader) { }

	public object get_Current() { }

	public bool MoveNext() { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public void Reset() { }

	private void BuildSchemaInfo() { }

}

private sealed class DbEnumerator.DbColumnDescriptor : PropertyDescriptor // TypeDefIndex: 4392
{	private int _ordinal; // 0x88
	private Type _type; // 0x90

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

public abstract class DbException : ExternalException // TypeDefIndex: 4393
{
	protected void .ctor() { }

	protected void .ctor(string message) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public static class DbMetaDataCollectionNames // TypeDefIndex: 4394
{	public static readonly string MetaDataCollections; // 0x0
	public static readonly string DataSourceInformation; // 0x8
	public static readonly string DataTypes; // 0x10
	public static readonly string Restrictions; // 0x18
	public static readonly string ReservedWords; // 0x20


	private static void .cctor() { }

}

public static class DbMetaDataColumnNames // TypeDefIndex: 4395
{	public static readonly string CollectionName; // 0x0
	public static readonly string ColumnSize; // 0x8
	public static readonly string CompositeIdentifierSeparatorPattern; // 0x10
	public static readonly string CreateFormat; // 0x18
	public static readonly string CreateParameters; // 0x20
	public static readonly string DataSourceProductName; // 0x28
	public static readonly string DataSourceProductVersion; // 0x30
	public static readonly string DataType; // 0x38
	public static readonly string DataSourceProductVersionNormalized; // 0x40
	public static readonly string GroupByBehavior; // 0x48
	public static readonly string IdentifierCase; // 0x50
	public static readonly string IdentifierPattern; // 0x58
	public static readonly string IsAutoIncrementable; // 0x60
	public static readonly string IsBestMatch; // 0x68
	public static readonly string IsCaseSensitive; // 0x70
	public static readonly string IsConcurrencyType; // 0x78
	public static readonly string IsFixedLength; // 0x80
	public static readonly string IsFixedPrecisionScale; // 0x88
	public static readonly string IsLiteralSupported; // 0x90
	public static readonly string IsLong; // 0x98
	public static readonly string IsNullable; // 0xA0
	public static readonly string IsSearchable; // 0xA8
	public static readonly string IsSearchableWithLike; // 0xB0
	public static readonly string IsUnsigned; // 0xB8
	public static readonly string LiteralPrefix; // 0xC0
	public static readonly string LiteralSuffix; // 0xC8
	public static readonly string MaximumScale; // 0xD0
	public static readonly string MinimumScale; // 0xD8
	public static readonly string NumberOfIdentifierParts; // 0xE0
	public static readonly string NumberOfRestrictions; // 0xE8
	public static readonly string OrderByColumnsInSelect; // 0xF0
	public static readonly string ParameterMarkerFormat; // 0xF8
	public static readonly string ParameterMarkerPattern; // 0x100
	public static readonly string ParameterNameMaxLength; // 0x108
	public static readonly string ParameterNamePattern; // 0x110
	public static readonly string ProviderDbType; // 0x118
	public static readonly string QuotedIdentifierCase; // 0x120
	public static readonly string QuotedIdentifierPattern; // 0x128
	public static readonly string ReservedWord; // 0x130
	public static readonly string StatementSeparatorPattern; // 0x138
	public static readonly string StringLiteralPattern; // 0x140
	public static readonly string SupportedJoinOperators; // 0x148
	public static readonly string TypeName; // 0x150


	private static void .cctor() { }

}

public abstract class DbParameter : MarshalByRefObject // TypeDefIndex: 4396
{	[BrowsableAttribute] // RVA: 0xABBE0 Offset: 0xAAFE0 VA: 0x1800ABBE0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xABBE0 Offset: 0xAAFE0 VA: 0x1800ABBE0
	[RefreshPropertiesAttribute] // RVA: 0xABBE0 Offset: 0xAAFE0 VA: 0x1800ABBE0
	public abstract DbType DbType { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xABD20 Offset: 0xAB120 VA: 0x1800ABD20
	[DefaultValueAttribute] // RVA: 0xABD20 Offset: 0xAB120 VA: 0x1800ABD20
	public abstract ParameterDirection Direction { get; set; }
	[DesignOnlyAttribute] // RVA: 0xABE00 Offset: 0xAB200 VA: 0x1800ABE00
	[BrowsableAttribute] // RVA: 0xABE00 Offset: 0xAB200 VA: 0x1800ABE00
	[EditorBrowsableAttribute] // RVA: 0xABE00 Offset: 0xAB200 VA: 0x1800ABE00
	public abstract bool IsNullable { get; set; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public abstract string ParameterName { get; set; }
	public abstract int Size { set; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public abstract string SourceColumn { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xAC090 Offset: 0xAB490 VA: 0x1800AC090
	[DefaultValueAttribute] // RVA: 0xAC090 Offset: 0xAB490 VA: 0x1800AC090
	[RefreshPropertiesAttribute] // RVA: 0xAC090 Offset: 0xAB490 VA: 0x1800AC090
	public abstract bool SourceColumnNullMapping { set; }
	[DefaultValueAttribute] // RVA: 0xAC270 Offset: 0xAB670 VA: 0x1800AC270
	public virtual DataRowVersion SourceVersion { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xAC370 Offset: 0xAB770 VA: 0x1800AC370
	[DefaultValueAttribute] // RVA: 0xAC370 Offset: 0xAB770 VA: 0x1800AC370
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

public abstract class DbParameterCollection : MarshalByRefObject, IList, ICollection, IEnumerable // TypeDefIndex: 4397
{	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	[BrowsableAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
	public abstract int Count { get; }
	[EditorBrowsableAttribute] // RVA: 0xAC8F0 Offset: 0xABCF0 VA: 0x1800AC8F0
	[BrowsableAttribute] // RVA: 0xAC8F0 Offset: 0xABCF0 VA: 0x1800AC8F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAC8F0 Offset: 0xABCF0 VA: 0x1800AC8F0
	public virtual bool IsFixedSize { get; }
	[BrowsableAttribute] // RVA: 0xABBE0 Offset: 0xAAFE0 VA: 0x1800ABBE0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xABBE0 Offset: 0xAAFE0 VA: 0x1800ABBE0
	[EditorBrowsableAttribute] // RVA: 0xABBE0 Offset: 0xAAFE0 VA: 0x1800ABBE0
	public virtual bool IsReadOnly { get; }
	[EditorBrowsableAttribute] // RVA: 0xAC8F0 Offset: 0xABCF0 VA: 0x1800AC8F0
	[BrowsableAttribute] // RVA: 0xAC8F0 Offset: 0xABCF0 VA: 0x1800AC8F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0xAC8F0 Offset: 0xABCF0 VA: 0x1800AC8F0
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

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	public abstract IEnumerator GetEnumerator();

	protected abstract DbParameter GetParameter(int index);

	public abstract int IndexOf(object value);

	public abstract int IndexOf(string parameterName);

	public abstract void Insert(int index, object value);

	public abstract void Remove(object value);

	public abstract void RemoveAt(int index);

	protected abstract void SetParameter(int index, DbParameter value);

}

public abstract class DbProviderFactory // TypeDefIndex: 4398
{
	protected void .ctor() { }

}

public sealed class DbProviderSpecificTypePropertyAttribute : Attribute // TypeDefIndex: 4399
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsProviderSpecificTypeProperty>k__BackingField; // 0x10


	public void .ctor(bool isProviderSpecificTypeProperty) { }

}

public abstract class DbTransaction : MarshalByRefObject, IDisposable // TypeDefIndex: 4400
{
	protected void .ctor() { }

	public abstract void Commit();

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract void Rollback();

}

public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5705
{
[AttributeUsageAttribute] // RVA: 0xC9A30 Offset: 0xC8E30 VA: 0x1800C9A30
public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5705
	private bool isReference; // 0x10

	public bool IsReference { get; }


	public bool get_IsReference() { }

}

public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 5706
{	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }


	public string get_Name() { }

	public int get_Order() { }

	public bool get_IsRequired() { }

	public bool get_EmitDefaultValue() { }

}

public static class Database // TypeDefIndex: 6181
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

private sealed class Database.<>c__DisplayClass0_0 // TypeDefIndex: 6182
{	public Action<bool> onFinished; // 0x10


	public void .ctor() { }

	internal void <Insert>b__0(bool success, string id) { }

}

private sealed class Database.<>c__DisplayClass1_0 // TypeDefIndex: 6183
{	public Action<bool, string> onFinished; // 0x10


	public void .ctor() { }

	internal void <Insert>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass2_0 // TypeDefIndex: 6184
{	public Action<bool> onFinished; // 0x10


	public void .ctor() { }

	internal void <Remove>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass3_0<T> // TypeDefIndex: 6185
{	public Result<T> result; // 0x0
	public Action<Result<T>> onFinished; // 0x0
	public Action <>9__1; // 0x0


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

private sealed class Database.<>c__3<T> // TypeDefIndex: 6186
{	public static readonly Database.<>c__3<T> <>9; // 0x0
	public static Func<QueryResponse, Result.Entry<T>> <>9__3_2; // 0x0


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

private sealed class Database.<>c__DisplayClass4_0 // TypeDefIndex: 6187
{	public Action<int> onResult; // 0x10


	public void .ctor() { }

	internal void <Count>b__0(object s, DownloadStringCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass4_1 // TypeDefIndex: 6188
{	public int count; // 0x10
	public Database.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18


	public void .ctor() { }

	internal void <Count>b__1() { }

}

public class Database // TypeDefIndex: 7356
{
public class Database // TypeDefIndex: 7356
	private IntPtr _connection; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsConnectionOpen>k__BackingField; // 0x18

	private bool IsConnectionOpen { get; set; }
	public int AffectedRows { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool get_IsConnectionOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[IteratorStateMachineAttribute] // RVA: 0x9A570 Offset: 0x99970 VA: 0x18009A570
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

private struct Database.<>c__DisplayClass19_0<T> // TypeDefIndex: 7357
{	public int type; // 0x0

}

private sealed class Database.<ExecuteAndReadQueryResults>d__32<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 7358
{	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<IntPtr, T> rowReader; // 0x0
	public Func<IntPtr, T> <>3__rowReader; // 0x0
	private IntPtr stmHandle; // 0x0
	public IntPtr <>3__stmHandle; // 0x0
	public Database <>4__this; // 0x0
	private bool finalize; // 0x0
	public bool <>3__finalize; // 0x0

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal static class DataTypesUtilities // TypeDefIndex: 7622
{
	public static ushort Combine(SevenBitNumber head, SevenBitNumber tail) { }

	public static ushort CombineAsSevenBitNumbers(byte head, byte tail) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static FourBitNumber GetTail(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static SevenBitNumber GetTail(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static byte GetTail(short number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static FourBitNumber GetHead(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static SevenBitNumber GetHead(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static byte GetHead(short number) { }

}

internal abstract class DbcsEncoding : MonoEncoding // TypeDefIndex: 7825
{	public override bool IsBrowserDisplay { get; }
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

internal abstract class DbcsEncoding.DbcsDecoder : Decoder // TypeDefIndex: 7826
{	protected DbcsConvert convert; // 0x20


	public void .ctor(DbcsConvert convert) { }

	internal void CheckRange(byte[] bytes, int index, int count) { }

	internal void CheckRange(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

internal class DbcsConvert // TypeDefIndex: 7827
{	public byte[] n2u; // 0x10
	public byte[] u2n; // 0x18
	internal static readonly DbcsConvert Gb2312; // 0x0
	internal static readonly DbcsConvert Big5; // 0x8
	internal static readonly DbcsConvert KS; // 0x10


	internal void .ctor(string fileName) { }

	private static void .cctor() { }

}

public class Data : ConsoleSystem // TypeDefIndex: 11894
{
	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	public static void export(ConsoleSystem.Arg args) { }

	public void .ctor() { }

}


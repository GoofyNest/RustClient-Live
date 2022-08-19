public sealed class DBNull : ISerializable, IConvertible // TypeDefIndex: 201
{	// Fields
	public static readonly DBNull Value; // 0x2B0AA90

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x178D7D0 Offset: 0x178CBD0 VA: 0x18178D7D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x178D020 Offset: 0x178C420 VA: 0x18178D020 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x178D730 Offset: 0x178CB30 VA: 0x18178D730 Slot: 3
	public override string ToString() { }

	// RVA: 0x178D6F0 Offset: 0x178CAF0 VA: 0x18178D6F0 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x178D050 Offset: 0x178C450 VA: 0x18178D050 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x178D130 Offset: 0x178C530 VA: 0x18178D130 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x178D440 Offset: 0x178C840 VA: 0x18178D440 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x178D0C0 Offset: 0x178C4C0 VA: 0x18178D0C0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x178D2F0 Offset: 0x178C6F0 VA: 0x18178D2F0 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x178D5A0 Offset: 0x178C9A0 VA: 0x18178D5A0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x178D360 Offset: 0x178C760 VA: 0x18178D360 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x178D610 Offset: 0x178CA10 VA: 0x18178D610 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x178D3D0 Offset: 0x178C7D0 VA: 0x18178D3D0 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x178D680 Offset: 0x178CA80 VA: 0x18178D680 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x178D4B0 Offset: 0x178C8B0 VA: 0x18178D4B0 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x178D280 Offset: 0x178C680 VA: 0x18178D280 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x178D210 Offset: 0x178C610 VA: 0x18178D210 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x178D1A0 Offset: 0x178C5A0 VA: 0x18178D1A0 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x178D520 Offset: 0x178C920 VA: 0x18178D520 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x178D770 Offset: 0x178CB70 VA: 0x18178D770
	private static void .cctor() { }

}

internal struct DataCollector // TypeDefIndex: 1509
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Methods

	// RVA: 0x120980 Offset: 0x11FD80 VA: 0x180120980
	internal void Enable(byte* scratch, int scratchSize, EventSource.EventData* datas, int dataCount, GCHandle* pins, int pinCount) { }

	// RVA: 0x120960 Offset: 0x11FD60 VA: 0x180120960
	internal void Disable() { }

	// RVA: 0x120B20 Offset: 0x11FF20 VA: 0x180120B20
	internal EventSource.EventData* Finish() { }

	// RVA: 0x120900 Offset: 0x11FD00 VA: 0x180120900
	internal void AddScalar(void* value, int size) { }

	// RVA: 0x1208C0 Offset: 0x11FCC0 VA: 0x1801208C0
	internal void AddBinary(string value, int size) { }

	// RVA: 0x1208D0 Offset: 0x11FCD0 VA: 0x1801208D0
	internal void AddBinary(Array value, int size) { }

	// RVA: 0x1208B0 Offset: 0x11FCB0 VA: 0x1801208B0
	internal void AddArray(Array value, int length, int itemSize) { }

	// RVA: 0x120910 Offset: 0x11FD10 VA: 0x180120910
	internal int BeginBufferedArray() { }

	// RVA: 0x1209D0 Offset: 0x11FDD0 VA: 0x1801209D0
	internal void EndBufferedArray(int bookmark, int count) { }

	// RVA: 0x120940 Offset: 0x11FD40 VA: 0x180120940
	internal void BeginBuffered() { }

	// RVA: 0x120AA0 Offset: 0x11FEA0 VA: 0x180120AA0
	internal void EndBuffered() { }

	// RVA: 0x120B00 Offset: 0x11FF00 VA: 0x180120B00
	private void EnsureBuffer() { }

	// RVA: 0x120B10 Offset: 0x11FF10 VA: 0x180120B10
	private void EnsureBuffer(int additionalSize) { }

	// RVA: 0x120B40 Offset: 0x11FF40 VA: 0x180120B40
	private void GrowBuffer(int required) { }

	// RVA: 0x120BA0 Offset: 0x11FFA0 VA: 0x180120BA0
	private void PinArray(object value, int size) { }

	// RVA: 0x120BB0 Offset: 0x11FFB0 VA: 0x180120BB0
	private void ScalarsBegin() { }

	// RVA: 0x120BC0 Offset: 0x11FFC0 VA: 0x180120BC0
	private void ScalarsEnd() { }

}

internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 2179
{	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0x151DDD0 Offset: 0x151D1D0 VA: 0x18151DDD0
	private static void .cctor() { }

	// RVA: 0x15239C0 Offset: 0x1522DC0 VA: 0x1815239C0
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x1523AC0 Offset: 0x1522EC0 VA: 0x181523AC0
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x151C8B0 Offset: 0x151BCB0 VA: 0x18151C8B0
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x151C820 Offset: 0x151BC20 VA: 0x18151C820
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x151C730 Offset: 0x151BB30 VA: 0x18151C730
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x151C640 Offset: 0x151BA40 VA: 0x18151C640
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x151D9F0 Offset: 0x151CDF0 VA: 0x18151D9F0
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x151C390 Offset: 0x151B790 VA: 0x18151C390
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x151AD10 Offset: 0x151A110 VA: 0x18151AD10
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x151CD70 Offset: 0x151C170 VA: 0x18151CD70
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x151CE00 Offset: 0x151C200 VA: 0x18151CE00
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x151C9A0 Offset: 0x151BDA0 VA: 0x18151C9A0
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x151CED0 Offset: 0x151C2D0 VA: 0x18151CED0
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x151C940 Offset: 0x151BD40 VA: 0x18151C940
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x151CC00 Offset: 0x151C000 VA: 0x18151CC00
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x151C100 Offset: 0x151B500 VA: 0x18151C100 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x151C0F0 Offset: 0x151B4F0 VA: 0x18151C0F0 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x151BDC0 Offset: 0x151B1C0 VA: 0x18151BDC0
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x151C250 Offset: 0x151B650 VA: 0x18151C250
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x151D2B0 Offset: 0x151C6B0 VA: 0x18151D2B0 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x151D5F0 Offset: 0x151C9F0 VA: 0x18151D5F0 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x151D1B0 Offset: 0x151C5B0 VA: 0x18151D1B0 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1523A20 Offset: 0x1522E20 VA: 0x181523A20 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1523B20 Offset: 0x1522F20 VA: 0x181523B20 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0xB9AAF0 Offset: 0xB99EF0 VA: 0x180B9AAF0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1523B60 Offset: 0x1522F60 VA: 0x181523B60 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x1523A80 Offset: 0x1522E80 VA: 0x181523A80 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x1523AA0 Offset: 0x1522EA0 VA: 0x181523AA0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x151D7C0 Offset: 0x151CBC0 VA: 0x18151D7C0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x151D610 Offset: 0x151CA10 VA: 0x18151D610 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x151DAC0 Offset: 0x151CEC0 VA: 0x18151DAC0 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x151D130 Offset: 0x151C530 VA: 0x18151D130
	internal string GetTypeName() { }

	// RVA: 0x151AC90 Offset: 0x151A090 VA: 0x18151AC90
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	protected void .ctor() { }

}

private class DatatypeImplementation.SchemaDatatypeMap : IComparable // TypeDefIndex: 2180
{	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Properties
	public string Name { get; }
	public int ParentIndex { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x1380A40 Offset: 0x137FE40 VA: 0x181380A40
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x14EF1B0 Offset: 0x14EE5B0 VA: 0x1814EF1B0
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public int get_ParentIndex() { }

	// RVA: 0x1536DE0 Offset: 0x15361E0 VA: 0x181536DE0 Slot: 4
	public int CompareTo(object obj) { }

}

internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 2181
{	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1523F10 Offset: 0x1523310 VA: 0x181523F10 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1524C90 Offset: 0x1524090 VA: 0x181524C90
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x1523C00 Offset: 0x1523000 VA: 0x181523C00 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0xFC61D0 Offset: 0xFC55D0 VA: 0x180FC61D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1524DE0 Offset: 0x15241E0 VA: 0x181524DE0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1524DB0 Offset: 0x15241B0 VA: 0x181524DB0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1524D50 Offset: 0x1524150 VA: 0x181524D50 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1524E10 Offset: 0x1524210 VA: 0x181524E10 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1524E40 Offset: 0x1524240 VA: 0x181524E40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1524270 Offset: 0x1523670 VA: 0x181524270 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x15247D0 Offset: 0x1523BD0 VA: 0x1815247D0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 2182
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x152C0A0 Offset: 0x152B4A0 VA: 0x18152C0A0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x152C920 Offset: 0x152BD20 VA: 0x18152C920
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x152BFA0 Offset: 0x152B3A0 VA: 0x18152BFA0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152CA90 Offset: 0x152BE90 VA: 0x18152CA90 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152C9D0 Offset: 0x152BDD0 VA: 0x18152C9D0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152CA30 Offset: 0x152BE30 VA: 0x18152CA30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xE84F30 Offset: 0xE84330 VA: 0x180E84F30 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x152C0B0 Offset: 0x152B4B0 VA: 0x18152C0B0
	internal bool HasAtomicMembers() { }

	// RVA: 0x152C150 Offset: 0x152B550 VA: 0x18152C150
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x152C210 Offset: 0x152B610 VA: 0x18152C210 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152C480 Offset: 0x152B880 VA: 0x18152C480 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152C880 Offset: 0x152BC80 VA: 0x18152C880
	private static void .cctor() { }

}

internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 2183
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1525FD0 Offset: 0x15253D0 VA: 0x181525FD0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1526160 Offset: 0x1525560 VA: 0x181526160 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1526220 Offset: 0x1525620 VA: 0x181526220 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15261C0 Offset: 0x15255C0 VA: 0x1815261C0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0xB9AAF0 Offset: 0xB99EF0 VA: 0x180B9AAF0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1525F60 Offset: 0x1525360 VA: 0x181525F60 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1526030 Offset: 0x1525430 VA: 0x181526030 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1526100 Offset: 0x1525500 VA: 0x181526100
	public void .ctor() { }

	// RVA: 0x1526060 Offset: 0x1525460 VA: 0x181526060
	private static void .cctor() { }

}

internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 2184
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1525E70 Offset: 0x1525270 VA: 0x181525E70 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1525ED0 Offset: 0x15252D0 VA: 0x181525ED0
	public void .ctor() { }

}

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 2185
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152DF00 Offset: 0x152D300 VA: 0x18152DF00 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x11B5960 Offset: 0x11B4D60 VA: 0x1811B5960 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152DF60 Offset: 0x152D360 VA: 0x18152DF60
	public void .ctor() { }

}

internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 2186
{	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x152BC50 Offset: 0x152B050 VA: 0x18152BC50 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x152BE10 Offset: 0x152B210 VA: 0x18152BE10 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xB9AAF0 Offset: 0xB99EF0 VA: 0x180B9AAF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1524E40 Offset: 0x1524240 VA: 0x181524E40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x152BC60 Offset: 0x152B060 VA: 0x18152BC60 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152BD80 Offset: 0x152B180 VA: 0x18152BD80
	public void .ctor() { }

}

internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 2187
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1526DA0 Offset: 0x15261A0 VA: 0x181526DA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1527000 Offset: 0x1526400 VA: 0x181527000 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1326F00 Offset: 0x1326300 VA: 0x181326F00 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15270C0 Offset: 0x15264C0 VA: 0x1815270C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1527060 Offset: 0x1526460 VA: 0x181527060 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0xE84F70 Offset: 0xE84370 VA: 0x180E84F70 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1526D20 Offset: 0x1526120 VA: 0x181526D20 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1526DB0 Offset: 0x15261B0 VA: 0x181526DB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1526F70 Offset: 0x1526370 VA: 0x181526F70
	public void .ctor() { }

	// RVA: 0x1526ED0 Offset: 0x15262D0 VA: 0x181526ED0
	private static void .cctor() { }

}

internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 2188
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1528D30 Offset: 0x1528130 VA: 0x181528D30 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1529EE0 Offset: 0x15292E0 VA: 0x181529EE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x10DFA70 Offset: 0x10DEE70 VA: 0x1810DFA70 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1529FA0 Offset: 0x15293A0 VA: 0x181529FA0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1529F40 Offset: 0x1529340 VA: 0x181529F40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x15280C0 Offset: 0x15274C0 VA: 0x1815280C0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1529BA0 Offset: 0x1528FA0 VA: 0x181529BA0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1529C20 Offset: 0x1529020 VA: 0x181529C20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1529E50 Offset: 0x1529250 VA: 0x181529E50
	public void .ctor() { }

	// RVA: 0x1529DB0 Offset: 0x15291B0 VA: 0x181529DB0
	private static void .cctor() { }

}

internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 2189
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1528D30 Offset: 0x1528130 VA: 0x181528D30 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1529000 Offset: 0x1528400 VA: 0x181529000 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xE84F40 Offset: 0xE84340 VA: 0x180E84F40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15290C0 Offset: 0x15284C0 VA: 0x1815290C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1529060 Offset: 0x1528460 VA: 0x181529060 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x15280C0 Offset: 0x15274C0 VA: 0x1815280C0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1528CB0 Offset: 0x15280B0 VA: 0x181528CB0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1528D40 Offset: 0x1528140 VA: 0x181528D40 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1528F70 Offset: 0x1528370 VA: 0x181528F70
	public void .ctor() { }

	// RVA: 0x1528ED0 Offset: 0x15282D0 VA: 0x181528ED0
	private static void .cctor() { }

}

internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 2190
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x15285F0 Offset: 0x15279F0 VA: 0x1815285F0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1528970 Offset: 0x1527D70 VA: 0x181528970 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xBA0670 Offset: 0xB9FA70 VA: 0x180BA0670 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1528A40 Offset: 0x1527E40 VA: 0x181528A40 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x15289D0 Offset: 0x1527DD0 VA: 0x1815289D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1528A30 Offset: 0x1527E30 VA: 0x181528A30 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1528570 Offset: 0x1527970 VA: 0x181528570 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1528600 Offset: 0x1527A00 VA: 0x181528600 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15288E0 Offset: 0x1527CE0 VA: 0x1815288E0
	public void .ctor() { }

	// RVA: 0x1528790 Offset: 0x1527B90 VA: 0x181528790
	private static void .cctor() { }

}

internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 2191
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1524FA0 Offset: 0x15243A0 VA: 0x181524FA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x15294C0 Offset: 0x15288C0 VA: 0x1815294C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xE5C8E0 Offset: 0xE5BCE0 VA: 0x180E5C8E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1529580 Offset: 0x1528980 VA: 0x181529580 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1529520 Offset: 0x1528920 VA: 0x181529520 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x15280C0 Offset: 0x15274C0 VA: 0x1815280C0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1529120 Offset: 0x1528520 VA: 0x181529120 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15291A0 Offset: 0x15285A0 VA: 0x1815291A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1529430 Offset: 0x1528830 VA: 0x181529430
	public void .ctor() { }

	// RVA: 0x1529390 Offset: 0x1528790 VA: 0x181529390
	private static void .cctor() { }

}

internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 2192
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152E3C0 Offset: 0x152D7C0 VA: 0x18152E3C0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152E610 Offset: 0x152DA10 VA: 0x18152E610 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152E5B0 Offset: 0x152D9B0 VA: 0x18152E5B0
	public void .ctor() { }

}

internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 2193
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x15282B0 Offset: 0x15276B0 VA: 0x1815282B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1528500 Offset: 0x1527900 VA: 0x181528500 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15284A0 Offset: 0x15278A0 VA: 0x1815284A0
	public void .ctor() { }

}

internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 2194
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1527B50 Offset: 0x1526F50 VA: 0x181527B50 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1527FF0 Offset: 0x15273F0 VA: 0x181527FF0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15280B0 Offset: 0x15274B0 VA: 0x1815280B0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1527F50 Offset: 0x1527350 VA: 0x181527F50
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x15280D0 Offset: 0x15274D0 VA: 0x1815280D0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1528050 Offset: 0x1527450 VA: 0x181528050 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x15280C0 Offset: 0x15274C0 VA: 0x1815280C0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1527A50 Offset: 0x1526E50 VA: 0x181527A50 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1527B60 Offset: 0x1526F60 VA: 0x181527B60 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1527EB0 Offset: 0x15272B0 VA: 0x181527EB0
	private static void .cctor() { }

}

internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2195
{	// Methods

	// RVA: 0x1528130 Offset: 0x1527530 VA: 0x181528130
	internal void .ctor() { }

}

internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2196
{	// Methods

	// RVA: 0x1528190 Offset: 0x1527590 VA: 0x181528190
	internal void .ctor() { }

}

internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 2197
{	// Methods

	// RVA: 0x15281F0 Offset: 0x15275F0 VA: 0x1815281F0
	internal void .ctor() { }

}

internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2198
{	// Methods

	// RVA: 0x152BE70 Offset: 0x152B270 VA: 0x18152BE70
	internal void .ctor() { }

}

internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 2199
{	// Methods

	// RVA: 0x152BED0 Offset: 0x152B2D0 VA: 0x18152BED0
	internal void .ctor() { }

}

internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 2200
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152BF90 Offset: 0x152B390 VA: 0x18152BF90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152BF30 Offset: 0x152B330 VA: 0x18152BF30
	internal void .ctor() { }

}

internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 2201
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xE84EF0 Offset: 0xE842F0 VA: 0x180E84EF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1528250 Offset: 0x1527650 VA: 0x181528250
	internal void .ctor() { }

}

internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 2202
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152E680 Offset: 0x152DA80 VA: 0x18152E680 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152E620 Offset: 0x152DA20 VA: 0x18152E620
	internal void .ctor() { }

}

internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 2203
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152E6F0 Offset: 0x152DAF0 VA: 0x18152E6F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152E690 Offset: 0x152DA90 VA: 0x18152E690
	internal void .ctor() { }

}

internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 2204
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152B070 Offset: 0x152A470 VA: 0x18152B070 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152B010 Offset: 0x152A410 VA: 0x18152B010
	internal void .ctor() { }

}

internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 2205
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xE84F30 Offset: 0xE84330 VA: 0x180E84F30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1528510 Offset: 0x1527910 VA: 0x181528510
	internal void .ctor() { }

}

internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 2206
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x49AAE0 Offset: 0x499EE0 VA: 0x18049AAE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152B080 Offset: 0x152A480 VA: 0x18152B080
	internal void .ctor() { }

}

internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 2207
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1524FA0 Offset: 0x15243A0 VA: 0x181524FA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x152A3E0 Offset: 0x15297E0 VA: 0x18152A3E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152A4A0 Offset: 0x15298A0 VA: 0x18152A4A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152A4B0 Offset: 0x15298B0 VA: 0x18152A4B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152A440 Offset: 0x1529840 VA: 0x18152A440 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1524E40 Offset: 0x1524240 VA: 0x181524E40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x152A000 Offset: 0x1529400 VA: 0x18152A000 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152A130 Offset: 0x1529530 VA: 0x18152A130 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152A350 Offset: 0x1529750 VA: 0x18152A350
	public void .ctor() { }

	// RVA: 0x152A2B0 Offset: 0x15296B0 VA: 0x18152A2B0
	private static void .cctor() { }

}

internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 2208
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1524FA0 Offset: 0x15243A0 VA: 0x181524FA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1526BF0 Offset: 0x1525FF0 VA: 0x181526BF0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1526CB0 Offset: 0x15260B0 VA: 0x181526CB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1526CC0 Offset: 0x15260C0 VA: 0x181526CC0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1526C50 Offset: 0x1526050 VA: 0x181526C50 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1524E40 Offset: 0x1524240 VA: 0x181524E40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1526810 Offset: 0x1525C10 VA: 0x181526810 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1526940 Offset: 0x1525D40 VA: 0x181526940 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1526B60 Offset: 0x1525F60 VA: 0x181526B60
	public void .ctor() { }

	// RVA: 0x1526AC0 Offset: 0x1525EC0 VA: 0x181526AC0
	private static void .cctor() { }

}

internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 2209
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1524FA0 Offset: 0x15243A0 VA: 0x181524FA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x15266F0 Offset: 0x1525AF0 VA: 0x1815266F0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xE84F10 Offset: 0xE84310 VA: 0x180E84F10 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x15267B0 Offset: 0x1525BB0 VA: 0x1815267B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1526750 Offset: 0x1525B50 VA: 0x181526750 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1524E40 Offset: 0x1524240 VA: 0x181524E40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1526280 Offset: 0x1525680 VA: 0x181526280 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15263B0 Offset: 0x15257B0 VA: 0x1815263B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1526660 Offset: 0x1525A60 VA: 0x181526660
	public void .ctor() { }

	// RVA: 0x15265C0 Offset: 0x15259C0 VA: 0x1815265C0
	private static void .cctor() { }

}

internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 2210
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1524FA0 Offset: 0x15243A0 VA: 0x181524FA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1525D40 Offset: 0x1525140 VA: 0x181525D40 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1525E00 Offset: 0x1525200 VA: 0x181525E00 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1524E40 Offset: 0x1524240 VA: 0x181524E40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1525E10 Offset: 0x1525210 VA: 0x181525E10 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1525DA0 Offset: 0x15251A0 VA: 0x181525DA0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1525A20 Offset: 0x1524E20 VA: 0x181525A20 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1525CB0 Offset: 0x15250B0 VA: 0x181525CB0
	public void .ctor() { }

	// RVA: 0x1525C10 Offset: 0x1525010 VA: 0x181525C10
	private static void .cctor() { }

}

internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 2211
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x152B590 Offset: 0x152A990 VA: 0x18152B590 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 2212
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x152B590 Offset: 0x152A990 VA: 0x18152B590 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 2213
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0xE84F20 Offset: 0xE84320 VA: 0x180E84F20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 2214
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xE84F20 Offset: 0xE84320 VA: 0x180E84F20 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_language : Datatype_token // TypeDefIndex: 2215
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152ABA0 Offset: 0x1529FA0 VA: 0x18152ABA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 2216
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xB9FAD0 Offset: 0xB9EED0 VA: 0x180B9FAD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x8E3F40 Offset: 0x8E3340 VA: 0x1808E3F40 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_Name : Datatype_token // TypeDefIndex: 2217
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1525660 Offset: 0x1524A60 VA: 0x181525660 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 2218
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xE84FB0 Offset: 0xE843B0 VA: 0x180E84FB0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1524E50 Offset: 0x1524250 VA: 0x181524E50 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 2219
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1523BF0 Offset: 0x1522FF0 VA: 0x181523BF0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 2220
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1523BE0 Offset: 0x1522FE0 VA: 0x181523BE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 2221
{	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1523BD0 Offset: 0x1522FD0 VA: 0x181523BD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0xE32BD0 Offset: 0xE31FD0 VA: 0x180E32BD0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 2222
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1524FA0 Offset: 0x15243A0 VA: 0x181524FA0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1525530 Offset: 0x1524930 VA: 0x181525530 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15255F0 Offset: 0x15249F0 VA: 0x1815255F0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1524E40 Offset: 0x1524240 VA: 0x181524E40 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1525600 Offset: 0x1524A00 VA: 0x181525600 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1525590 Offset: 0x1524990 VA: 0x181525590 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1524FB0 Offset: 0x15243B0 VA: 0x181524FB0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x15251A0 Offset: 0x15245A0 VA: 0x1815251A0 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x15254A0 Offset: 0x15248A0 VA: 0x1815254A0
	public void .ctor() { }

	// RVA: 0x1525400 Offset: 0x1524800 VA: 0x181525400
	private static void .cctor() { }

}

internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 2223
{	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0xE84F70 Offset: 0xE84370 VA: 0x180E84F70 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152A9F0 Offset: 0x1529DF0 VA: 0x18152A9F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152AB40 Offset: 0x1529F40 VA: 0x18152AB40
	public void .ctor() { }

}

internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 2224
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x1356E

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x152B520 Offset: 0x152A920 VA: 0x18152B520 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152B580 Offset: 0x152A980 VA: 0x18152B580 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x152AB40 Offset: 0x1529F40 VA: 0x18152AB40
	public void .ctor() { }

	// RVA: 0x152B430 Offset: 0x152A830 VA: 0x18152B430
	private static void .cctor() { }

}

internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 2225
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x2B0AF6C

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152B260 Offset: 0x152A660 VA: 0x18152B260 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152B2C0 Offset: 0x152A6C0 VA: 0x18152B2C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152B1D0 Offset: 0x152A5D0 VA: 0x18152B1D0
	public void .ctor() { }

	// RVA: 0x152B0E0 Offset: 0x152A4E0 VA: 0x18152B0E0
	private static void .cctor() { }

}

internal class Datatype_long : Datatype_integer // TypeDefIndex: 2226
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x152AEE0 Offset: 0x152A2E0 VA: 0x18152AEE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x152AFA0 Offset: 0x152A3A0 VA: 0x18152AFA0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152ABB0 Offset: 0x1529FB0 VA: 0x18152ABB0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152AFB0 Offset: 0x152A3B0 VA: 0x18152AFB0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152AF40 Offset: 0x152A340 VA: 0x18152AF40 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x152AC30 Offset: 0x152A030 VA: 0x18152AC30 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152AB40 Offset: 0x1529F40 VA: 0x18152AB40
	public void .ctor() { }

	// RVA: 0x152ADB0 Offset: 0x152A1B0 VA: 0x18152ADB0
	private static void .cctor() { }

}

internal class Datatype_int : Datatype_long // TypeDefIndex: 2227
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x152A8D0 Offset: 0x1529CD0 VA: 0x18152A8D0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0xE84F00 Offset: 0xE84300 VA: 0x180E84F00 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152A510 Offset: 0x1529910 VA: 0x18152A510 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152A990 Offset: 0x1529D90 VA: 0x18152A990 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152A930 Offset: 0x1529D30 VA: 0x18152A930 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x152A590 Offset: 0x1529990 VA: 0x18152A590 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152A840 Offset: 0x1529C40 VA: 0x18152A840
	public void .ctor() { }

	// RVA: 0x152A710 Offset: 0x1529B10 VA: 0x18152A710
	private static void .cctor() { }

}

internal class Datatype_short : Datatype_int // TypeDefIndex: 2228
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x152BB20 Offset: 0x152AF20 VA: 0x18152BB20 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152BBE0 Offset: 0x152AFE0 VA: 0x18152BBE0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152B790 Offset: 0x152AB90 VA: 0x18152B790 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152BBF0 Offset: 0x152AFF0 VA: 0x18152BBF0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152BB80 Offset: 0x152AF80 VA: 0x18152BB80 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x152B810 Offset: 0x152AC10 VA: 0x18152B810 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152BAC0 Offset: 0x152AEC0 VA: 0x18152BAC0
	public void .ctor() { }

	// RVA: 0x152B990 Offset: 0x152AD90 VA: 0x18152B990
	private static void .cctor() { }

}

internal class Datatype_byte : Datatype_short // TypeDefIndex: 2229
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x15274E0 Offset: 0x15268E0 VA: 0x1815274E0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x15275A0 Offset: 0x15269A0 VA: 0x1815275A0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1527120 Offset: 0x1526520 VA: 0x181527120 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x15275B0 Offset: 0x15269B0 VA: 0x1815275B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1527540 Offset: 0x1526940 VA: 0x181527540 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x15271A0 Offset: 0x15265A0 VA: 0x1815271A0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1527450 Offset: 0x1526850 VA: 0x181527450
	public void .ctor() { }

	// RVA: 0x1527320 Offset: 0x1526720 VA: 0x181527320
	private static void .cctor() { }

}

internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 2230
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x13570

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x152B3C0 Offset: 0x152A7C0 VA: 0x18152B3C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152B420 Offset: 0x152A820 VA: 0x18152B420 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x152AB40 Offset: 0x1529F40 VA: 0x18152AB40
	public void .ctor() { }

	// RVA: 0x152B2D0 Offset: 0x152A6D0 VA: 0x18152B2D0
	private static void .cctor() { }

}

internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 2231
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x152D8D0 Offset: 0x152CCD0 VA: 0x18152D8D0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x7F2080 Offset: 0x7F1480 VA: 0x1807F2080 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152D4A0 Offset: 0x152C8A0 VA: 0x18152D4A0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152D990 Offset: 0x152CD90 VA: 0x18152D990 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152D930 Offset: 0x152CD30 VA: 0x18152D930 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x152D520 Offset: 0x152C920 VA: 0x18152D520 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152D840 Offset: 0x152CC40 VA: 0x18152D840
	public void .ctor() { }

	// RVA: 0x152D6F0 Offset: 0x152CAF0 VA: 0x18152D6F0
	private static void .cctor() { }

}

internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 2232
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x152D370 Offset: 0x152C770 VA: 0x18152D370 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152D430 Offset: 0x152C830 VA: 0x18152D430 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152CFC0 Offset: 0x152C3C0 VA: 0x18152CFC0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152D440 Offset: 0x152C840 VA: 0x18152D440 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152D3D0 Offset: 0x152C7D0 VA: 0x18152D3D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x152D040 Offset: 0x152C440 VA: 0x18152D040 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152D310 Offset: 0x152C710 VA: 0x18152D310
	public void .ctor() { }

	// RVA: 0x152D1C0 Offset: 0x152C5C0 VA: 0x18152D1C0
	private static void .cctor() { }

}

internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 2233
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x152DDD0 Offset: 0x152D1D0 VA: 0x18152DDD0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152DE90 Offset: 0x152D290 VA: 0x18152DE90 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152D9F0 Offset: 0x152CDF0 VA: 0x18152D9F0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152DEA0 Offset: 0x152D2A0 VA: 0x18152DEA0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152DE30 Offset: 0x152D230 VA: 0x18152DE30 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x152DA70 Offset: 0x152CE70 VA: 0x18152DA70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152DD40 Offset: 0x152D140 VA: 0x18152DD40
	public void .ctor() { }

	// RVA: 0x152DBF0 Offset: 0x152CFF0 VA: 0x18152DBF0
	private static void .cctor() { }

}

internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 2234
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x152CEA0 Offset: 0x152C2A0 VA: 0x18152CEA0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x527A50 Offset: 0x526E50 VA: 0x180527A50 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152CAF0 Offset: 0x152BEF0 VA: 0x18152CAF0 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152CF60 Offset: 0x152C360 VA: 0x18152CF60 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152CF00 Offset: 0x152C300 VA: 0x18152CF00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x152CB70 Offset: 0x152BF70 VA: 0x18152CB70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152CE40 Offset: 0x152C240 VA: 0x18152CE40
	public void .ctor() { }

	// RVA: 0x152CCF0 Offset: 0x152C0F0 VA: 0x18152CCF0
	private static void .cctor() { }

}

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 2235
{	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x135C8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x152B720 Offset: 0x152AB20 VA: 0x18152B720 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x152B780 Offset: 0x152AB80 VA: 0x18152B780 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x152B690 Offset: 0x152AA90 VA: 0x18152B690
	public void .ctor() { }

	// RVA: 0x152B5A0 Offset: 0x152A9A0 VA: 0x18152B5A0
	private static void .cctor() { }

}

internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 2236
{	// Methods

	// RVA: 0x1528AA0 Offset: 0x1527EA0 VA: 0x181528AA0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1528C50 Offset: 0x1528050 VA: 0x181528C50
	public void .ctor() { }

}

internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 2237
{	// Methods

	// RVA: 0x15299D0 Offset: 0x1528DD0 VA: 0x1815299D0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1529B40 Offset: 0x1528F40 VA: 0x181529B40
	public void .ctor() { }

}

internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 2238
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x4A2F20 Offset: 0x4A2320 VA: 0x1804A2F20 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1525670 Offset: 0x1524A70 VA: 0x181525670 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15259C0 Offset: 0x1524DC0 VA: 0x1815259C0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1525960 Offset: 0x1524D60 VA: 0x181525960 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x15258D0 Offset: 0x1524CD0 VA: 0x1815258D0
	public void .ctor() { }

	// RVA: 0x1525830 Offset: 0x1524C30 VA: 0x181525830
	private static void .cctor() { }

}

internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 2239
{	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0xE61370 Offset: 0xE60770 VA: 0x180E61370 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1523BC0 Offset: 0x1522FC0 VA: 0x181523BC0
	public void .ctor() { }

}

internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 2240
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x15279F0 Offset: 0x1526DF0 VA: 0x1815279F0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1527990 Offset: 0x1526D90 VA: 0x181527990 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1527610 Offset: 0x1526A10 VA: 0x181527610 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1527690 Offset: 0x1526A90 VA: 0x181527690 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15277B0 Offset: 0x1526BB0 VA: 0x1815277B0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1527900 Offset: 0x1526D00 VA: 0x181527900
	public void .ctor() { }

	// RVA: 0x1527860 Offset: 0x1526C60 VA: 0x181527860
	private static void .cctor() { }

}

internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 2241
{	// Methods

	// RVA: 0x15295E0 Offset: 0x15289E0 VA: 0x1815295E0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x15297E0 Offset: 0x1528BE0 VA: 0x1815297E0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1529970 Offset: 0x1528D70 VA: 0x181529970
	public void .ctor() { }

}

internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 2242
{	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x152E360 Offset: 0x152D760 VA: 0x18152E360 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x152E300 Offset: 0x152D700 VA: 0x18152E300 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x152DF70 Offset: 0x152D370 VA: 0x18152DF70 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x152E000 Offset: 0x152D400 VA: 0x18152E000 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x152E120 Offset: 0x152D520 VA: 0x18152E120 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x152E270 Offset: 0x152D670 VA: 0x18152E270
	public void .ctor() { }

	// RVA: 0x152E1D0 Offset: 0x152D5D0 VA: 0x18152E1D0
	private static void .cctor() { }

}

public sealed class DataUtility // TypeDefIndex: 3576
{	// Methods

	// RVA: 0x19A4BD0 Offset: 0x19A3FD0 VA: 0x1819A4BD0
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x19A4D50 Offset: 0x19A4150 VA: 0x1819A4D50
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x19A4DC0 Offset: 0x19A41C0 VA: 0x1819A4DC0
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x19A4C40 Offset: 0x19A4040 VA: 0x1819A4C40
	public static Vector2 GetMinSize(Sprite sprite) { }

}

internal class DataCommonEventSource : EventSource // TypeDefIndex: 4171
{	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[EventAttribute] // RVA: 0x9AAF0 Offset: 0x99EF0 VA: 0x18009AAF0
	// RVA: 0x122EA00 Offset: 0x122DE00 VA: 0x18122EA00
	internal void Trace(string message) { }

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFCED0 Offset: 0xDFC2D0 VA: 0x180DFCED0
	|-DataCommonEventSource.Trace<Exception>
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0xDFC3F0 Offset: 0xDFB7F0 VA: 0x180DFC3F0
	|-DataCommonEventSource.Trace<int>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFA9D0 Offset: 0xDF9DD0 VA: 0x180DFA9D0
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0xDFAB00 Offset: 0xDF9F00 VA: 0x180DFAB00
	|-DataCommonEventSource.Trace<int, ListChangedType>
	|-DataCommonEventSource.Trace<int, MappingType>
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0xDFB840 Offset: 0xDFAC40 VA: 0x180DFB840
	|-DataCommonEventSource.Trace<int, int>
	|
	|-RVA: 0xDFB970 Offset: 0xDFAD70 VA: 0x180DFB970
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0xDFC300 Offset: 0xDFB700 VA: 0x180DFC300
	|-DataCommonEventSource.Trace<int, object>
	|-DataCommonEventSource.Trace<int, string>
	|
	|-RVA: 0xDFCE10 Offset: 0xDFC210 VA: 0x180DFCE10
	|-DataCommonEventSource.Trace<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFAC30 Offset: 0xDFA030 VA: 0x180DFAC30
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0xDFB560 Offset: 0xDFA960 VA: 0x180DFB560
	|-DataCommonEventSource.Trace<int, int, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0xDFB6D0 Offset: 0xDFAAD0 VA: 0x180DFB6D0
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-RVA: 0xDFBAA0 Offset: 0xDFAEA0 VA: 0x180DFBAA0
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, DataViewRowState>
	|
	|-RVA: 0xDFC200 Offset: 0xDFB600 VA: 0x180DFC200
	|-DataCommonEventSource.Trace<int, object, object>
	|-DataCommonEventSource.Trace<int, string, string>
	|
	|-RVA: 0xDFCD40 Offset: 0xDFC140 VA: 0x180DFCD40
	|-DataCommonEventSource.Trace<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFB250 Offset: 0xDFA650 VA: 0x180DFB250
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xDFBF50 Offset: 0xDFB350 VA: 0x180DFBF50
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|-DataCommonEventSource.Trace<int, string, string, DataViewRowState>
	|-DataCommonEventSource.Trace<int, string, string, MappingType>
	|
	|-RVA: 0xDFCAF0 Offset: 0xDFBEF0 VA: 0x180DFCAF0
	|-DataCommonEventSource.Trace<object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFBBE0 Offset: 0xDFAFE0 VA: 0x180DFBBE0
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|-DataCommonEventSource.Trace<int, string, int, int, bool>
	|
	|-RVA: 0xDFC840 Offset: 0xDFBC40 VA: 0x180DFC840
	|-DataCommonEventSource.Trace<object, object, object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFADA0 Offset: 0xDFA1A0 VA: 0x180DFADA0
	|-DataCommonEventSource.Trace<int, int, DataViewRowState, DataViewRowState, int, DataViewRowState, DataViewRowState>
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0xDFC4E0 Offset: 0xDFB8E0 VA: 0x180DFC4E0
	|-DataCommonEventSource.Trace<object, object, object, object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B0A0 Offset: 0x9A4A0 VA: 0x18009B0A0
	// RVA: 0x122E910 Offset: 0x122DD10 VA: 0x18122E910
	internal long EnterScope(string message) { }

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7DDA0 Offset: 0xE7D1A0 VA: 0x180E7DDA0
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0xE7E270 Offset: 0xE7D670 VA: 0x180E7E270
	|-DataCommonEventSource.EnterScope<object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7D030 Offset: 0xE7C430 VA: 0x180E7D030
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0xE7D2F0 Offset: 0xE7C6F0 VA: 0x180E7D2F0
	|-DataCommonEventSource.EnterScope<int, SchemaFormat>
	|-DataCommonEventSource.EnterScope<int, XmlReadMode>
	|-DataCommonEventSource.EnterScope<int, XmlWriteMode>
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0xE7DA20 Offset: 0xE7CE20 VA: 0x180E7DA20
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-RVA: 0xE7DCB0 Offset: 0xE7D0B0 VA: 0x180E7DCB0
	|-DataCommonEventSource.EnterScope<int, object>
	|-DataCommonEventSource.EnterScope<int, string>
	|
	|-RVA: 0xE7E1B0 Offset: 0xE7D5B0 VA: 0x180E7E1B0
	|-DataCommonEventSource.EnterScope<object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7D170 Offset: 0xE7C570 VA: 0x180E7D170
	|-DataCommonEventSource.EnterScope<int, XmlReadMode, bool>
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0xE7D750 Offset: 0xE7CB50 VA: 0x180E7D750
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-RVA: 0xE7D8D0 Offset: 0xE7CCD0 VA: 0x180E7D8D0
	|-DataCommonEventSource.EnterScope<int, int, object>
	|-DataCommonEventSource.EnterScope<int, int, string>
	|
	|-RVA: 0xE7DB60 Offset: 0xE7CF60 VA: 0x180E7DB60
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|-DataCommonEventSource.EnterScope<int, string, bool>
	|
	|-RVA: 0xE7E0E0 Offset: 0xE7D4E0 VA: 0x180E7E0E0
	|-DataCommonEventSource.EnterScope<object, object, object>
	*/

	[NonEventAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7D430 Offset: 0xE7C830 VA: 0x180E7D430
	|-DataCommonEventSource.EnterScope<int, int, bool, MissingSchemaAction>
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0xE7DE90 Offset: 0xE7D290 VA: 0x180E7DE90
	|-DataCommonEventSource.EnterScope<object, object, object, object>
	*/

	[EventAttribute] // RVA: 0x9B3E0 Offset: 0x9A7E0 VA: 0x18009B3E0
	// RVA: 0x122E9F0 Offset: 0x122DDF0 VA: 0x18122E9F0
	internal void ExitScope(long scopeId) { }

	// RVA: 0x122EAC0 Offset: 0x122DEC0 VA: 0x18122EAC0
	public void .ctor() { }

	// RVA: 0x122EA10 Offset: 0x122DE10 VA: 0x18122EA10
	private static void .cctor() { }

}

public class DataColumn : MarshalByValueComponent // TypeDefIndex: 4181
{	// Fields
	private bool _allowNull; // 0x20
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

	// Properties
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

	// Methods

	// RVA: 0x122A870 Offset: 0x1229C70 VA: 0x18122A870
	public void .ctor() { }

	// RVA: 0x122AC30 Offset: 0x122A030 VA: 0x18122AC30
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x122A900 Offset: 0x1229D00 VA: 0x18122A900
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x122A750 Offset: 0x1229B50 VA: 0x18122A750
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	public bool get_AllowDBNull() { }

	// RVA: 0x122B460 Offset: 0x122A860 VA: 0x18122B460
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x122AE00 Offset: 0x122A200 VA: 0x18122AE00
	public bool get_AutoIncrement() { }

	// RVA: 0x122B960 Offset: 0x122AD60 VA: 0x18122B960
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x122AD40 Offset: 0x122A140 VA: 0x18122AD40
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x122B5E0 Offset: 0x122A9E0 VA: 0x18122B5E0
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x122AC60 Offset: 0x122A060 VA: 0x18122AC60
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x122ADB0 Offset: 0x122A1B0 VA: 0x18122ADB0
	public long get_AutoIncrementSeed() { }

	// RVA: 0x122B790 Offset: 0x122AB90 VA: 0x18122B790
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x122ADD0 Offset: 0x122A1D0 VA: 0x18122ADD0
	public long get_AutoIncrementStep() { }

	// RVA: 0x122B870 Offset: 0x122AC70 VA: 0x18122B870
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x122AE20 Offset: 0x122A220 VA: 0x18122AE20
	public string get_Caption() { }

	// RVA: 0x122BB10 Offset: 0x122AF10 VA: 0x18122BB10
	public void set_Caption(string value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_ColumnName() { }

	// RVA: 0x122BE80 Offset: 0x122B280 VA: 0x18122BE80
	public void set_ColumnName(string value) { }

	// RVA: 0x122AFB0 Offset: 0x122A3B0 VA: 0x18122AFB0
	internal string get_EncodedColumnName() { }

	// RVA: 0x122B120 Offset: 0x122A520 VA: 0x18122B120
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x122B280 Offset: 0x122A680 VA: 0x18122B280
	internal CultureInfo get_Locale() { }

	// RVA: 0x104B320 Offset: 0x104A720 VA: 0x18104B320
	internal int get_ObjectID() { }

	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public string get_Prefix() { }

	// RVA: 0x122DDC0 Offset: 0x122D1C0 VA: 0x18122DDC0
	public void set_Prefix(string value) { }

	// RVA: 0x1229120 Offset: 0x1228520 VA: 0x181229120
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x122AE30 Offset: 0x122A230 VA: 0x18122AE30
	internal bool get_Computed() { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal DataExpression get_DataExpression() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Type get_DataType() { }

	// RVA: 0x122C280 Offset: 0x122B680 VA: 0x18122C280
	public void set_DataType(Type value) { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x122CC00 Offset: 0x122C000 VA: 0x18122CC00
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x122AE50 Offset: 0x122A250 VA: 0x18122AE50
	public object get_DefaultValue() { }

	// RVA: 0x122CD50 Offset: 0x122C150 VA: 0x18122CD50
	public void set_DefaultValue(object value) { }

	// RVA: 0x122AE40 Offset: 0x122A240 VA: 0x18122AE40
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x122B030 Offset: 0x122A430 VA: 0x18122B030
	public string get_Expression() { }

	// RVA: 0x122D020 Offset: 0x122C420 VA: 0x18122D020
	public void set_Expression(string value) { }

	// RVA: 0x122B0A0 Offset: 0x122A4A0 VA: 0x18122B0A0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x122B190 Offset: 0x122A590 VA: 0x18122B190
	internal bool get_HasData() { }

	// RVA: 0x1183070 Offset: 0x1182470 VA: 0x181183070
	internal bool get_ImplementsINullable() { }

	// RVA: 0x122B1A0 Offset: 0x122A5A0 VA: 0x18122B1A0
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xE61360 Offset: 0xE60760 VA: 0x180E61360
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x122B230 Offset: 0x122A630 VA: 0x18122B230
	internal bool get_IsValueType() { }

	// RVA: 0x1183060 Offset: 0x1182460 VA: 0x181183060
	internal bool get_IsSqlType() { }

	// RVA: 0x122A200 Offset: 0x1229600 VA: 0x18122A200
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public int get_MaxLength() { }

	// RVA: 0x122D8E0 Offset: 0x122CCE0 VA: 0x18122D8E0
	public void set_MaxLength(int value) { }

	// RVA: 0x122B2F0 Offset: 0x122A6F0 VA: 0x18122B2F0
	public string get_Namespace() { }

	// RVA: 0x122DC90 Offset: 0x122D090 VA: 0x18122DC90
	public void set_Namespace(string value) { }

	// RVA: 0x58DBF0 Offset: 0x58CFF0 VA: 0x18058DBF0
	public int get_Ordinal() { }

	// RVA: 0x122A300 Offset: 0x1229700 VA: 0x18122A300
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	public bool get_ReadOnly() { }

	// RVA: 0x122DF10 Offset: 0x122D310 VA: 0x18122DF10
	public void set_ReadOnly(bool value) { }

	// RVA: 0x122B360 Offset: 0x122A760 VA: 0x18122B360
	private Index get_SortIndex() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public DataTable get_Table() { }

	// RVA: 0x122A4A0 Offset: 0x12298A0 VA: 0x18122A4A0
	internal void SetTable(DataTable table) { }

	// RVA: 0x1229210 Offset: 0x1228610 VA: 0x181229210
	private DataRow GetDataRow(int index) { }

	// RVA: 0x122B250 Offset: 0x122A650 VA: 0x18122B250
	internal object get_Item(int record) { }

	// RVA: 0x122D750 Offset: 0x122CB50 VA: 0x18122D750
	internal void set_Item(int record, object value) { }

	// RVA: 0x12295C0 Offset: 0x12289C0 VA: 0x1812295C0
	internal void InitializeRecord(int record) { }

	// RVA: 0x122A580 Offset: 0x1229980 VA: 0x18122A580
	internal void SetValue(int record, object value) { }

	// RVA: 0x1229010 Offset: 0x1228410 VA: 0x181229010
	internal void FreeRecord(int record) { }

	// RVA: 0x122B450 Offset: 0x122A850 VA: 0x18122B450
	public bool get_Unique() { }

	// RVA: 0x122E040 Offset: 0x122D440 VA: 0x18122E040
	public void set_Unique(bool value) { }

	// RVA: 0x7ACC50 Offset: 0x7AC050 VA: 0x1807ACC50
	internal void InternalUnique(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	internal string get_XmlDataType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD50 Offset: 0x4EB150 VA: 0x1804EBD50
	internal void set_XmlDataType(string value) { }

	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	internal SimpleType get_SimpleType() { }

	// RVA: 0x122DFD0 Offset: 0x122D3D0 VA: 0x18122DFD0
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x104B3C0 Offset: 0x104A7C0 VA: 0x18104B3C0 Slot: 10
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x122BC00 Offset: 0x122B000 VA: 0x18122BC00 Slot: 11
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x1227EC0 Offset: 0x12272C0 VA: 0x181227EC0
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x12280A0 Offset: 0x12274A0 VA: 0x1812280A0
	internal bool CheckMaxLength() { }

	// RVA: 0x1228000 Offset: 0x1227400 VA: 0x181228000
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x1228310 Offset: 0x1227710 VA: 0x181228310
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x12285F0 Offset: 0x12279F0 VA: 0x1812285F0
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x12286A0 Offset: 0x1227AA0 VA: 0x1812286A0
	protected void CheckUnique() { }

	// RVA: 0x1228DE0 Offset: 0x12281E0 VA: 0x181228DE0
	internal int Compare(int record1, int record2) { }

	// RVA: 0x1228BE0 Offset: 0x1227FE0 VA: 0x181228BE0
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x1228BB0 Offset: 0x1227FB0 VA: 0x181228BB0
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x1228ED0 Offset: 0x12282D0 VA: 0x181228ED0
	internal object ConvertValue(object value) { }

	// RVA: 0x1228FE0 Offset: 0x12283E0 VA: 0x181228FE0
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x1228720 Offset: 0x1227B20 VA: 0x181228720
	internal DataColumn Clone() { }

	// RVA: 0x1229040 Offset: 0x1228440 VA: 0x181229040
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x1229280 Offset: 0x1228680 VA: 0x181229280
	private int GetStringLength(int record) { }

	// RVA: 0x1229510 Offset: 0x1228910 VA: 0x181229510
	internal void Init(int record) { }

	// RVA: 0x12296B0 Offset: 0x1228AB0 VA: 0x1812296B0
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x122B1C0 Offset: 0x122A5C0 VA: 0x18122B1C0
	internal bool get_IsCustomType() { }

	// RVA: 0x1229FD0 Offset: 0x12293D0 VA: 0x181229FD0
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x122B1B0 Offset: 0x122A5B0 VA: 0x18122B1B0
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x1229FA0 Offset: 0x12293A0 VA: 0x181229FA0
	internal bool IsNull(int record) { }

	// RVA: 0x1229950 Offset: 0x1228D50 VA: 0x181229950
	internal bool IsInRelation() { }

	// RVA: 0x1229AE0 Offset: 0x1228EE0 VA: 0x181229AE0
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x1229E40 Offset: 0x1229240 VA: 0x181229E40
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x100DDC0 Offset: 0x100D1C0 VA: 0x18100DDC0 Slot: 12
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x122A0A0 Offset: 0x12294A0 VA: 0x18122A0A0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1229610 Offset: 0x1228A10 VA: 0x181229610
	private void InsureStorage() { }

	// RVA: 0x122A1B0 Offset: 0x12295B0 VA: 0x18122A1B0
	internal void SetCapacity(int capacity) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	internal void OnSetDataSet() { }

	// RVA: 0x122A680 Offset: 0x1229A80 VA: 0x18122A680 Slot: 3
	public override string ToString() { }

	// RVA: 0x1228F00 Offset: 0x1228300 VA: 0x181228F00
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x1228F50 Offset: 0x1228350 VA: 0x181228F50
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1228E10 Offset: 0x1228210 VA: 0x181228E10
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x1228E60 Offset: 0x1228260 VA: 0x181228E60
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1229240 Offset: 0x1228640 VA: 0x181229240
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x1228FB0 Offset: 0x12283B0 VA: 0x181228FB0
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x122A450 Offset: 0x1229850 VA: 0x18122A450
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1227E00 Offset: 0x1227200 VA: 0x181227E00
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x122A120 Offset: 0x1229520 VA: 0x18122A120
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x12292B0 Offset: 0x12286B0 VA: 0x1812292B0
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 4185
{	// Fields
	private DataColumn _column; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x12243C0 Offset: 0x12237C0 VA: 0x1812243C0
	internal void .ctor(DataRow row) { }

	// RVA: 0x1224310 Offset: 0x1223710 VA: 0x181224310
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public object get_ProposedValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_ProposedValue(object value) { }

	// RVA: 0x12242D0 Offset: 0x12236D0 VA: 0x1812242D0
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 4186
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataColumnChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 4187
{	// Fields
	private readonly DataTable _table; // 0x10
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

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x1227260 Offset: 0x1226660 VA: 0x181227260
	internal void .ctor(DataTable table) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x1227690 Offset: 0x1226A90 VA: 0x181227690
	public DataColumn get_Item(int index) { }

	// RVA: 0x1227540 Offset: 0x1226940 VA: 0x181227540
	public DataColumn get_Item(string name) { }

	// RVA: 0x1227490 Offset: 0x1226890 VA: 0x181227490
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x12248D0 Offset: 0x1223CD0 VA: 0x1812248D0
	public void Add(DataColumn column) { }

	// RVA: 0x1224430 Offset: 0x1223830 VA: 0x181224430
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0x12248E0 Offset: 0x1223CE0 VA: 0x1812248E0
	public DataColumn Add(string columnName, Type type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1227350 Offset: 0x1226750 VA: 0x181227350
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1227770 Offset: 0x1226B70 VA: 0x181227770
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12273F0 Offset: 0x12267F0 VA: 0x1812273F0
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1227810 Offset: 0x1226C10 VA: 0x181227810
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x12249F0 Offset: 0x1223DF0 VA: 0x1812249F0
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x1224980 Offset: 0x1223D80 VA: 0x181224980
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x1224A80 Offset: 0x1223E80 VA: 0x181224A80
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x1224DB0 Offset: 0x12241B0 VA: 0x181224DB0
	internal string AssignName() { }

	// RVA: 0x1224EC0 Offset: 0x12242C0 VA: 0x181224EC0
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x12252F0 Offset: 0x12246F0 VA: 0x1812252F0
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x1225640 Offset: 0x1224A40 VA: 0x181225640
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x1225810 Offset: 0x1224C10 VA: 0x181225810
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x1226100 Offset: 0x1225500 VA: 0x181226100
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x1226150 Offset: 0x1225550 VA: 0x181226150
	public void Clear() { }

	// RVA: 0x1226690 Offset: 0x1225A90 VA: 0x181226690
	public bool Contains(string name) { }

	// RVA: 0x1226720 Offset: 0x1225B20 VA: 0x181226720
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1226980 Offset: 0x1225D80 VA: 0x181226980
	public int IndexOf(string columnName) { }

	// RVA: 0x12267E0 Offset: 0x1225BE0 VA: 0x1812267E0
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x1226A80 Offset: 0x1225E80 VA: 0x181226A80
	private string MakeName(int index) { }

	// RVA: 0x1226B10 Offset: 0x1225F10 VA: 0x181226B10
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1226BB0 Offset: 0x1225FB0 VA: 0x181226BB0
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1226BD0 Offset: 0x1225FD0 VA: 0x181226BD0
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1226C20 Offset: 0x1226020 VA: 0x181226C20
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x12257B0 Offset: 0x1224BB0 VA: 0x1812257B0
	internal bool CanRegisterName(string name) { }

	// RVA: 0x1226F40 Offset: 0x1226340 VA: 0x181226F40
	public void Remove(DataColumn column) { }

	// RVA: 0x12270B0 Offset: 0x12264B0 VA: 0x1812270B0
	internal void UnregisterName(string name) { }

	// RVA: 0x12247E0 Offset: 0x1223BE0 VA: 0x1812247E0
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x1226E20 Offset: 0x1226220 VA: 0x181226E20
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4188
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1227B50 Offset: 0x1226F50 VA: 0x181227B50
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x1227BA0 Offset: 0x1226FA0 VA: 0x181227BA0 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal DataColumn get_Column() { }

	// RVA: 0x1227D60 Offset: 0x1227160 VA: 0x181227D60 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1227DC0 Offset: 0x12271C0 VA: 0x181227DC0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1227DE0 Offset: 0x12271E0 VA: 0x181227DE0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x12278B0 Offset: 0x1226CB0 VA: 0x1812278B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xADFA00 Offset: 0xADEE00 VA: 0x180ADFA00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1227940 Offset: 0x1226D40 VA: 0x181227940 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x1227A20 Offset: 0x1226E20 VA: 0x181227A20 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

internal sealed class DataError // TypeDefIndex: 4189
{	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x122F3A0 Offset: 0x122E7A0 VA: 0x18122F3A0
	internal void .ctor() { }

	// RVA: 0x122F2F0 Offset: 0x122E6F0 VA: 0x18122F2F0
	internal void .ctor(string rowError) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal string get_Text() { }

	// RVA: 0x122F420 Offset: 0x122E820 VA: 0x18122F420
	internal void set_Text(string value) { }

	// RVA: 0x122F3F0 Offset: 0x122E7F0 VA: 0x18122F3F0
	internal bool get_HasErrors() { }

	// RVA: 0x122EFA0 Offset: 0x122E3A0 VA: 0x18122EFA0
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x122EC80 Offset: 0x122E080 VA: 0x18122EC80
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x122EBC0 Offset: 0x122DFC0 VA: 0x18122EBC0
	internal void Clear(DataColumn column) { }

	// RVA: 0x122EB20 Offset: 0x122DF20 VA: 0x18122EB20
	internal void Clear() { }

	// RVA: 0x122ED30 Offset: 0x122E130 VA: 0x18122ED30
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x122F290 Offset: 0x122E690 VA: 0x18122F290
	private void SetText(string errorText) { }

	// RVA: 0x122EE40 Offset: 0x122E240 VA: 0x18122EE40
	internal int IndexOf(DataColumn column) { }

}

internal struct DataError.ColumnError // TypeDefIndex: 4190
{	// Fields
	internal DataColumn _column; // 0x0
	internal string _error; // 0x8

}

public class DataException : SystemException // TypeDefIndex: 4191
{	// Methods

	// RVA: 0x122F480 Offset: 0x122E880 VA: 0x18122F480
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x122F500 Offset: 0x122E900 VA: 0x18122F500
	public void .ctor() { }

	// RVA: 0x122F550 Offset: 0x122E950 VA: 0x18122F550
	public void .ctor(string s) { }

	// RVA: 0x1175130 Offset: 0x1174530 VA: 0x181175130
	public void .ctor(string s, Exception innerException) { }

}

internal struct DataKey // TypeDefIndex: 4202
{	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1D2AB0 Offset: 0x1D1EB0 VA: 0x1801D2AB0
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF48A0 Offset: 0xF3CA0 VA: 0x1800F48A0
	internal bool get_HasValue() { }

	// RVA: 0x1D2AC0 Offset: 0x1D1EC0 VA: 0x1801D2AC0
	internal DataTable get_Table() { }

	// RVA: 0x1D2670 Offset: 0x1D1A70 VA: 0x1801D2670
	internal void CheckState() { }

	// RVA: 0x1D2680 Offset: 0x1D1A80 VA: 0x1801D2680
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x1230130 Offset: 0x122F530 VA: 0x181230130
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x1D2690 Offset: 0x1D1A90 VA: 0x1801D2690
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1D2780 Offset: 0x1D1B80 VA: 0x1801D2780 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2700 Offset: 0x1D1B00 VA: 0x1801D2700 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1D26F0 Offset: 0x1D1AF0 VA: 0x1801D26F0
	internal bool Equals(DataKey value) { }

	// RVA: 0x1D27E0 Offset: 0x1D1BE0 VA: 0x1801D27E0
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x1D27F0 Offset: 0x1D1BF0 VA: 0x1801D27F0
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x1D2970 Offset: 0x1D1D70 VA: 0x1801D2970
	internal Index GetSortIndex() { }

	// RVA: 0x1D2960 Offset: 0x1D1D60 VA: 0x1801D2960
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x1D29E0 Offset: 0x1D1DE0 VA: 0x1801D29E0
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x1D2AA0 Offset: 0x1D1EA0 VA: 0x1801D2AA0
	internal DataColumn[] ToArray() { }

}

public class DataRelation // TypeDefIndex: 4203
{	// Fields
	private DataSet _dataSet; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0x1232CD0 Offset: 0x12320D0 VA: 0x181232CD0
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x1232FD0 Offset: 0x12323D0 VA: 0x181232FD0
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1232F10 Offset: 0x1232310 VA: 0x181232F10
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1233010 Offset: 0x1232410 VA: 0x181233010 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x1232FF0 Offset: 0x12323F0 VA: 0x181232FF0
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x1232FF0 Offset: 0x12323F0 VA: 0x181232FF0
	internal DataKey get_ChildKey() { }

	// RVA: 0x1233050 Offset: 0x1232450 VA: 0x181233050 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x12330A0 Offset: 0x12324A0 VA: 0x1812330A0 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x1232630 Offset: 0x1231A30 VA: 0x181232630
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x1232110 Offset: 0x1231510 VA: 0x181232110
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x1232390 Offset: 0x1231790 VA: 0x181232390
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x12321F0 Offset: 0x12315F0 VA: 0x1812321F0
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1232890 Offset: 0x1231C90 VA: 0x181232890
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1233150 Offset: 0x1232550 VA: 0x181233150 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x1233190 Offset: 0x1232590 VA: 0x181233190
	internal DataKey get_ParentKey() { }

	// RVA: 0x12331B0 Offset: 0x12325B0 VA: 0x1812331B0 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x1233200 Offset: 0x1232600 VA: 0x181233200 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x1230D00 Offset: 0x1230100 VA: 0x181230D00
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x1230F70 Offset: 0x1230370 VA: 0x181230F70
	internal void CheckNestedRelations() { }

	// RVA: 0x1233130 Offset: 0x1232530 VA: 0x181233130 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x1233230 Offset: 0x1232630 VA: 0x181233230 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x1233170 Offset: 0x1232570 VA: 0x181233170 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x1233030 Offset: 0x1232430 VA: 0x181233030 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x12330C0 Offset: 0x12324C0 VA: 0x1812330C0
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xB9D220 Offset: 0xB9C620 VA: 0x180B9D220
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x1233220 Offset: 0x1232620 VA: 0x181233220
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x1231450 Offset: 0x1230850 VA: 0x181231450
	internal void CheckState() { }

	// RVA: 0x1231330 Offset: 0x1230730 VA: 0x181231330
	protected void CheckStateForProperty() { }

	// RVA: 0x1231E10 Offset: 0x1231210 VA: 0x181231E10
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1231780 Offset: 0x1230B80 VA: 0x181231780
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x12326F0 Offset: 0x1231AF0 VA: 0x1812326F0
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x12327A0 Offset: 0x1231BA0 VA: 0x1812327A0
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x4BF560 Offset: 0x4BE960 VA: 0x1804BF560 Slot: 3
	public override string ToString() { }

	// RVA: 0x12328B0 Offset: 0x1231CB0 VA: 0x1812328B0
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x1232470 Offset: 0x1231870 VA: 0x181232470
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0
	internal int get_ObjectID() { }

}

public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 4204
{	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(string name);

	// RVA: 0xADE760 Offset: 0xADDB60 VA: 0x180ADE760
	public void Add(DataRelation relation) { }

	// RVA: 0xADE4B0 Offset: 0xADD8B0 VA: 0x180ADE4B0 Slot: 14
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xADF7D0 Offset: 0xADEBD0 VA: 0x180ADF7D0
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xADF8A0 Offset: 0xADECA0 VA: 0x180ADF8A0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xADE9A0 Offset: 0xADDDA0 VA: 0x180ADE9A0
	internal string AssignName() { }

	// RVA: 0xADE9C0 Offset: 0xADDDC0 VA: 0x180ADE9C0 Slot: 15
	public virtual void Clear() { }

	// RVA: 0xADEC00 Offset: 0xADE000 VA: 0x180ADEC00 Slot: 16
	public virtual bool Contains(string name) { }

	// RVA: 0xADEC20 Offset: 0xADE020 VA: 0x180ADEC20
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DataSet GetDataSet();

	// RVA: 0xADEDE0 Offset: 0xADE1E0 VA: 0x180ADEDE0
	private string MakeName(int index) { }

	// RVA: 0xADEE70 Offset: 0xADE270 VA: 0x180ADEE70 Slot: 18
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xADEF20 Offset: 0xADE320 VA: 0x180ADEF20 Slot: 19
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xADEFD0 Offset: 0xADE3D0 VA: 0x180ADEFD0
	internal void RegisterName(string name) { }

	// RVA: 0xADF3F0 Offset: 0xADE7F0 VA: 0x180ADF3F0
	public void Remove(DataRelation relation) { }

	// RVA: 0xADF1A0 Offset: 0xADE5A0 VA: 0x180ADF1A0
	public void RemoveAt(int index) { }

	// RVA: 0xADF230 Offset: 0xADE630 VA: 0x180ADF230 Slot: 20
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xADF5B0 Offset: 0xADE9B0 VA: 0x180ADF5B0
	internal void UnregisterName(string name) { }

	// RVA: 0xADF760 Offset: 0xADEB60 VA: 0x180ADF760
	protected void .ctor() { }

}

internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 4205
{	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0xAF26B0 Offset: 0xAF1AB0 VA: 0x180AF26B0
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAF2310 Offset: 0xAF1710 VA: 0x180AF2310
	private void EnsureDataSet() { }

	// RVA: 0xAF2370 Offset: 0xAF1770 VA: 0x180AF2370 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAF2910 Offset: 0xAF1D10 VA: 0x180AF2910 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAF2800 Offset: 0xAF1C00 VA: 0x180AF2800 Slot: 13
	public override DataRelation get_Item(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAF2760 Offset: 0xAF1B60 VA: 0x180AF2760
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAF2A10 Offset: 0xAF1E10 VA: 0x180AF2A10
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xAF2190 Offset: 0xAF1590 VA: 0x180AF2190
	private void AddCache(DataRelation relation) { }

	// RVA: 0xAF21F0 Offset: 0xAF15F0 VA: 0x180AF21F0 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAF23D0 Offset: 0xAF17D0 VA: 0x180AF23D0
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xAF24E0 Offset: 0xAF18E0 VA: 0x180AF24E0 Slot: 20
	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 4206
{	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0xAE66F0 Offset: 0xAE5AF0 VA: 0x180AE66F0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0xAE63A0 Offset: 0xAE57A0 VA: 0x180AE63A0 Slot: 15
	public override void Clear() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 17
	protected override DataSet GetDataSet() { }

	// RVA: 0xAE6790 Offset: 0xAE5B90 VA: 0x180AE6790 Slot: 12
	public override DataRelation get_Item(int index) { }

	// RVA: 0xAE6890 Offset: 0xAE5C90 VA: 0x180AE6890 Slot: 13
	public override DataRelation get_Item(string name) { }

	// RVA: 0xAE5CC0 Offset: 0xAE50C0 VA: 0x180AE5CC0 Slot: 14
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xAE63F0 Offset: 0xAE57F0 VA: 0x180AE63F0 Slot: 20
	protected override void RemoveCore(DataRelation relation) { }

}

internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4207
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0xADFB20 Offset: 0xADEF20 VA: 0x180ADFB20
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	internal DataRelation get_Relation() { }

	// RVA: 0xADFB80 Offset: 0xADEF80 VA: 0x180ADFB80 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0xADFBE0 Offset: 0xADEFE0 VA: 0x180ADFBE0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0xADF970 Offset: 0xADED70 VA: 0x180ADF970 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xADFA00 Offset: 0xADEE00 VA: 0x180ADFA00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xADFA30 Offset: 0xADEE30 VA: 0x180ADFA30 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

public class DataRow // TypeDefIndex: 4208
{	// Fields
	private readonly DataTable _table; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0xAE49C0 Offset: 0xAE3DC0 VA: 0x180AE49C0
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xAE4F60 Offset: 0xAE4360 VA: 0x180AE4F60
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xAE5A80 Offset: 0xAE4E80 VA: 0x180AE5A80
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xAE4A90 Offset: 0xAE3E90 VA: 0x180AE4A90
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xAE4F70 Offset: 0xAE4370 VA: 0x180AE4F70
	internal int get_RBTreeNodeId() { }

	// RVA: 0xAE5A90 Offset: 0xAE4E90 VA: 0x180AE5A90
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xAE4F80 Offset: 0xAE4380 VA: 0x180AE4F80
	public string get_RowError() { }

	// RVA: 0xAE5B30 Offset: 0xAE4F30 VA: 0x180AE5B30
	public void set_RowError(string value) { }

	// RVA: 0xAE3B80 Offset: 0xAE2F80 VA: 0x180AE3B80
	private void RowErrorChanged() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal long get_rowID() { }

	// RVA: 0xAE5C80 Offset: 0xAE5080 VA: 0x180AE5C80
	internal void set_rowID(long value) { }

	// RVA: 0xAE4FD0 Offset: 0xAE43D0 VA: 0x180AE4FD0
	public DataRowState get_RowState() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public DataTable get_Table() { }

	// RVA: 0xAE4C30 Offset: 0xAE4030 VA: 0x180AE4C30
	public object get_Item(int columnIndex) { }

	// RVA: 0xAE5A30 Offset: 0xAE4E30 VA: 0x180AE5A30
	public void set_Item(int columnIndex, object value) { }

	// RVA: 0xAE1D10 Offset: 0xAE1110 VA: 0x180AE1D10
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xAE2B20 Offset: 0xAE1F20 VA: 0x180AE2B20
	internal int GetNestedParentCount() { }

	// RVA: 0xAE4DF0 Offset: 0xAE41F0 VA: 0x180AE4DF0
	public object get_Item(string columnName) { }

	// RVA: 0xAE59F0 Offset: 0xAE4DF0 VA: 0x180AE59F0
	public void set_Item(string columnName, object value) { }

	// RVA: 0xAE4CD0 Offset: 0xAE40D0 VA: 0x180AE4CD0
	public object get_Item(DataColumn column) { }

	// RVA: 0xAE55E0 Offset: 0xAE49E0 VA: 0x180AE55E0
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xAE4E80 Offset: 0xAE4280 VA: 0x180AE4E80
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xAE4AA0 Offset: 0xAE3EA0 VA: 0x180AE4AA0
	public object[] get_ItemArray() { }

	// RVA: 0xAE5180 Offset: 0xAE4580 VA: 0x180AE5180
	public void set_ItemArray(object[] value) { }

	// RVA: 0xAE1720 Offset: 0xAE0B20 VA: 0x180AE1720
	public void AcceptChanges() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0xAE1BB0 Offset: 0xAE0FB0 VA: 0x180AE1BB0
	public void BeginEdit() { }

	// RVA: 0xAE1AD0 Offset: 0xAE0ED0 VA: 0x180AE1AD0
	private bool BeginEditInternal() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0xAE1BC0 Offset: 0xAE0FC0 VA: 0x180AE1BC0
	public void CancelEdit() { }

	// RVA: 0xAE1C50 Offset: 0xAE1050 VA: 0x180AE1C50
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xAE1E20 Offset: 0xAE1220 VA: 0x180AE1E20
	internal void CheckInTable() { }

	// RVA: 0xAE22D0 Offset: 0xAE16D0 VA: 0x180AE22D0
	public void Delete() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0xAE23B0 Offset: 0xAE17B0 VA: 0x180AE23B0
	public void EndEdit() { }

	// RVA: 0xAE3BD0 Offset: 0xAE2FD0 VA: 0x180AE3BD0
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xAE3C60 Offset: 0xAE3060 VA: 0x180AE3C60
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xAE2660 Offset: 0xAE1A60 VA: 0x180AE2660
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xAE1ED0 Offset: 0xAE12D0 VA: 0x180AE1ED0
	public void ClearErrors() { }

	// RVA: 0xAE1E70 Offset: 0xAE1270 VA: 0x180AE1E70
	internal void ClearError(DataColumn column) { }

	// RVA: 0xAE4A70 Offset: 0xAE3E70 VA: 0x180AE4A70
	public bool get_HasErrors() { }

	// RVA: 0xAE28A0 Offset: 0xAE1CA0 VA: 0x180AE28A0
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xAE24D0 Offset: 0xAE18D0 VA: 0x180AE24D0
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xAE24E0 Offset: 0xAE18E0 VA: 0x180AE24E0
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE2940 Offset: 0xAE1D40 VA: 0x180AE2940
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xAE2EA0 Offset: 0xAE22A0 VA: 0x180AE2EA0
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xAE2D30 Offset: 0xAE2130 VA: 0x180AE2D30
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE2C00 Offset: 0xAE2000 VA: 0x180AE2C00
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xAE3030 Offset: 0xAE2430 VA: 0x180AE3030
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xAE2EB0 Offset: 0xAE22B0 VA: 0x180AE2EB0
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xAE2790 Offset: 0xAE1B90 VA: 0x180AE2790
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xAE2840 Offset: 0xAE1C40 VA: 0x180AE2840
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xAE2A70 Offset: 0xAE1E70 VA: 0x180AE2A70
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xAE2AF0 Offset: 0xAE1EF0 VA: 0x180AE2AF0
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xAE28F0 Offset: 0xAE1CF0 VA: 0x180AE28F0
	internal int GetCurrentRecordNo() { }

	// RVA: 0xAE29D0 Offset: 0xAE1DD0 VA: 0x180AE29D0
	internal int GetDefaultRecord() { }

	// RVA: 0xAE2CE0 Offset: 0xAE20E0 VA: 0x180AE2CE0
	internal int GetOriginalRecordNo() { }

	// RVA: 0xAE3040 Offset: 0xAE2440 VA: 0x180AE3040
	private int GetProposedRecordNo() { }

	// RVA: 0xAE3090 Offset: 0xAE2490 VA: 0x180AE3090
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xAE2A40 Offset: 0xAE1E40 VA: 0x180AE2A40
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xAE3230 Offset: 0xAE2630 VA: 0x180AE3230
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xAE3280 Offset: 0xAE2680 VA: 0x180AE3280
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xAE32B0 Offset: 0xAE26B0 VA: 0x180AE32B0
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE3350 Offset: 0xAE2750 VA: 0x180AE3350
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xAE35C0 Offset: 0xAE29C0 VA: 0x180AE35C0
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xAE3410 Offset: 0xAE2810 VA: 0x180AE3410
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xAE35F0 Offset: 0xAE29F0 VA: 0x180AE35F0
	public bool IsNull(string columnName) { }

	// RVA: 0xAE3680 Offset: 0xAE2A80 VA: 0x180AE3680
	public void RejectChanges() { }

	// RVA: 0xAE3B50 Offset: 0xAE2F50 VA: 0x180AE3B50
	internal void ResetLastChangedColumn() { }

	// RVA: 0xAE3F20 Offset: 0xAE3320 VA: 0x180AE3F20
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xAE4070 Offset: 0xAE3470 VA: 0x180AE4070
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xAE4480 Offset: 0xAE3880 VA: 0x180AE4480
	internal void SetParentRowToDBNull() { }

	// RVA: 0xAE4810 Offset: 0xAE3C10 VA: 0x180AE4810
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xAE1F30 Offset: 0xAE1330 VA: 0x180AE1F30
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

public sealed class DataRowBuilder // TypeDefIndex: 4209
{	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xADFC40 Offset: 0xADF040 VA: 0x180ADFC40
	internal void .ctor(DataTable table, int record) { }

}

public enum DataRowAction // TypeDefIndex: 4210
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0xADFC90 Offset: 0xADF090 VA: 0x180ADFC90
	public void .ctor(DataRow row, DataRowAction action) { }

}

public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 4212
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataRowChangeEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 4213
{	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0xAE0CF0 Offset: 0xAE00F0 VA: 0x180AE0CF0
	internal void .ctor(DataTable table) { }

	// RVA: 0xAE0DC0 Offset: 0xAE01C0 VA: 0x180AE0DC0 Slot: 8
	public override int get_Count() { }

	// RVA: 0xAE0E10 Offset: 0xAE0210 VA: 0x180AE0E10
	public DataRow get_Item(int index) { }

	// RVA: 0xAE0340 Offset: 0xADF740 VA: 0x180AE0340
	public void Add(DataRow row) { }

	// RVA: 0xAE06B0 Offset: 0xADFAB0 VA: 0x180AE06B0
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xAE0950 Offset: 0xADFD50 VA: 0x180AE0950
	public int IndexOf(DataRow row) { }

	// RVA: 0xAE0230 Offset: 0xADF630 VA: 0x180AE0230
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xAE0380 Offset: 0xADF780 VA: 0x180AE0380
	public DataRow Add(object[] values) { }

	// RVA: 0xAE0400 Offset: 0xADF800 VA: 0x180AE0400
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xAE04C0 Offset: 0xADF8C0 VA: 0x180AE04C0
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xAE0470 Offset: 0xADF870 VA: 0x180AE0470
	internal void ArrayClear() { }

	// RVA: 0xAE0540 Offset: 0xADF940 VA: 0x180AE0540
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xAE0640 Offset: 0xADFA40 VA: 0x180AE0640 Slot: 9
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xAE05D0 Offset: 0xADF9D0 VA: 0x180AE05D0
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xAE0900 Offset: 0xADFD00 VA: 0x180AE0900 Slot: 10
	public override IEnumerator GetEnumerator() { }

	// RVA: 0xAE0B80 Offset: 0xADFF80 VA: 0x180AE0B80
	public void Remove(DataRow row) { }

	// RVA: 0xAE09E0 Offset: 0xADFDE0 VA: 0x180AE09E0
	public void RemoveAt(int index) { }

}

private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 4214
{	// Methods

	// RVA: 0xAE0EF0 Offset: 0xAE02F0 VA: 0x180AE0EF0
	internal void .ctor() { }

	// RVA: 0xAE0E70 Offset: 0xAE0270 VA: 0x180AE0E70 Slot: 5
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xAE0EB0 Offset: 0xAE02B0 VA: 0x180AE0EB0 Slot: 6
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 4215
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, DataRow r) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataRow r, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 4216
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, DataTable table) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataTable table, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public enum DataRowState // TypeDefIndex: 4217
{	// Fields
	public int value__; // 0x0
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;

}

public enum DataRowVersion // TypeDefIndex: 4218
{	// Fields
	public int value__; // 0x0
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;

}

public class DataRowView : ICustomTypeDescriptor // TypeDefIndex: 4219
{	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xAE1170 Offset: 0xAE0570 VA: 0x180AE1170 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xAE1200 Offset: 0xAE0600 VA: 0x180AE1200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public DataView get_DataView() { }

	// RVA: 0xAE16C0 Offset: 0xAE0AC0 VA: 0x180AE16C0
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xAE1230 Offset: 0xAE0630 VA: 0x180AE1230
	internal int GetRecord() { }

	// RVA: 0xAE12B0 Offset: 0xAE06B0 VA: 0x180AE12B0
	internal bool HasRecord() { }

	// RVA: 0xAE1180 Offset: 0xAE0580 VA: 0x180AE1180
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xAE13C0 Offset: 0xAE07C0 VA: 0x180AE13C0
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xAE0F30 Offset: 0xAE0330 VA: 0x180AE0F30
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xAE1110 Offset: 0xAE0510 VA: 0x180AE1110
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public DataRow get_Row() { }

	// RVA: 0xAE1120 Offset: 0xAE0520 VA: 0x180AE1120 Slot: 9
	public void EndEdit() { }

	// RVA: 0xAE1690 Offset: 0xAE0A90 VA: 0x180AE1690
	public bool get_IsNew() { }

	// RVA: 0xAE1330 Offset: 0xAE0730 VA: 0x180AE1330
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xAE1490 Offset: 0xAE0890 VA: 0x180AE1490 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xAE14E0 Offset: 0xAE08E0 VA: 0x180AE14E0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xAE1590 Offset: 0xAE0990 VA: 0x180AE1590 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xAE1630 Offset: 0xAE0A30 VA: 0x180AE1630
	private static void .cctor() { }

}

public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 4221
{	// Fields
	private DataViewManager _defaultViewManager; // 0x20
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

	// Properties
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

	// Methods

	// RVA: 0xAF1000 Offset: 0xAF0400 VA: 0x180AF1000
	public void .ctor() { }

	// RVA: 0xAF1280 Offset: 0xAF0680 VA: 0x180AF1280
	public void .ctor(string dataSetName) { }

	// RVA: 0xAF14F0 Offset: 0xAF08F0 VA: 0x180AF14F0
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xAF2050 Offset: 0xAF1450 VA: 0x180AF2050
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 14
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xAF0FD0 Offset: 0xAF03D0 VA: 0x180AF0FD0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAF12B0 Offset: 0xAF06B0 VA: 0x180AF12B0
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xAE9680 Offset: 0xAE8A80 VA: 0x180AE9680 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xAEE790 Offset: 0xAEDB90 VA: 0x180AEE790
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAE83B0 Offset: 0xAE77B0 VA: 0x180AE83B0
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAE7E20 Offset: 0xAE7220 VA: 0x180AE7E20
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xAE7A70 Offset: 0xAE6E70 VA: 0x180AE7A70
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xAEE630 Offset: 0xAEDA30 VA: 0x180AEE630
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAE7C10 Offset: 0xAE7010 VA: 0x180AE7C10
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAEEF70 Offset: 0xAEE370 VA: 0x180AEEF70
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAE8580 Offset: 0xAE7980 VA: 0x180AE8580
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAE93C0 Offset: 0xAE87C0 VA: 0x180AE93C0
	internal void FailedEnableConstraints() { }

	// RVA: 0xAF1470 Offset: 0xAF0870 VA: 0x180AF1470
	public bool get_CaseSensitive() { }

	// RVA: 0xAF1500 Offset: 0xAF0900 VA: 0x180AF1500
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_EnforceConstraints() { }

	// RVA: 0xAF18D0 Offset: 0xAF0CD0 VA: 0x180AF18D0
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xAE8C60 Offset: 0xAE8060 VA: 0x180AE8C60
	internal void EnableConstraints() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_DataSetName() { }

	// RVA: 0xAF1790 Offset: 0xAF0B90 VA: 0x180AF1790
	public void set_DataSetName(string value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_Namespace() { }

	// RVA: 0xAF1BD0 Offset: 0xAF0FD0 VA: 0x180AF1BD0
	public void set_Namespace(string value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public string get_Prefix() { }

	// RVA: 0xAF1F30 Offset: 0xAF1330 VA: 0x180AF1F30
	public void set_Prefix(string value) { }

	// RVA: 0xAF1480 Offset: 0xAF0880 VA: 0x180AF1480
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public CultureInfo get_Locale() { }

	// RVA: 0xAF1A40 Offset: 0xAF0E40 VA: 0x180AF1A40
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xAEF480 Offset: 0xAEE880 VA: 0x180AEF480
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public DataRelationCollection get_Relations() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public DataTableCollection get_Tables() { }

	// RVA: 0xAE69A0 Offset: 0xAE5DA0 VA: 0x180AE69A0
	public void Clear() { }

	// RVA: 0xAE6B90 Offset: 0xAE5F90 VA: 0x180AE6B90 Slot: 17
	public virtual DataSet Clone() { }

	// RVA: 0xAE9270 Offset: 0xAE8670 VA: 0x180AE9270
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xAE96B0 Offset: 0xAE8AB0 VA: 0x180AE96B0
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xAE97D0 Offset: 0xAE8BD0 VA: 0x180AE97D0
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xAEBA60 Offset: 0xAEAE60 VA: 0x180AEBA60
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xAEBA70 Offset: 0xAEAE70 VA: 0x180AEBA70
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEA1D0 Offset: 0xAE95D0 VA: 0x180AEA1D0
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xAEA290 Offset: 0xAE9690 VA: 0x180AEA290
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xAEA5B0 Offset: 0xAE99B0 VA: 0x180AEA5B0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xAEA7C0 Offset: 0xAE9BC0 VA: 0x180AEA7C0
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAEA660 Offset: 0xAE9A60 VA: 0x180AEA660
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAF0BD0 Offset: 0xAEFFD0 VA: 0x180AF0BD0
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0xAEC5C0 Offset: 0xAEB9C0 VA: 0x180AEC5C0
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xAEC5F0 Offset: 0xAEB9F0 VA: 0x180AEC5F0
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAE9950 Offset: 0xAE8D50 VA: 0x180AE9950
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xAE9C00 Offset: 0xAE9000 VA: 0x180AE9C00
	private bool IsEmpty() { }

	// RVA: 0xAEAA30 Offset: 0xAE9E30 VA: 0x180AEAA30
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xAEC5D0 Offset: 0xAEB9D0 VA: 0x180AEC5D0
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xAED6A0 Offset: 0xAECAA0 VA: 0x180AED6A0
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAF0DE0 Offset: 0xAF01E0 VA: 0x180AF0DE0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xAEA060 Offset: 0xAE9460 VA: 0x180AEA060
	public void Merge(DataSet dataSet) { }

	// RVA: 0xAE9E30 Offset: 0xAE9230 VA: 0x180AE9E30
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEA3D0 Offset: 0xAE97D0 VA: 0x180AEA3D0 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xAEA350 Offset: 0xAE9750 VA: 0x180AEA350
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xAEA440 Offset: 0xAE9840 VA: 0x180AEA440
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xAEA330 Offset: 0xAE9730 VA: 0x180AEA330
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xAEA310 Offset: 0xAE9710 VA: 0x180AEA310
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 19
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xAEA410 Offset: 0xAE9810 VA: 0x180AEA410
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xAEA3F0 Offset: 0xAE97F0 VA: 0x180AEA3F0
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xAEA530 Offset: 0xAE9930 VA: 0x180AEA530
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xAF0310 Offset: 0xAEF710 VA: 0x180AF0310
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xAF0120 Offset: 0xAEF520 VA: 0x180AF0120
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xAEE390 Offset: 0xAED790 VA: 0x180AEE390 Slot: 21
	public virtual void Reset() { }

	// RVA: 0xAF0320 Offset: 0xAEF720 VA: 0x180AF0320
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xAF0730 Offset: 0xAEFB30 VA: 0x180AF0730
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xAEC310 Offset: 0xAEB710 VA: 0x180AEC310 Slot: 22
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xAE9410 Offset: 0xAE8810 VA: 0x180AE9410
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xAEFDF0 Offset: 0xAEF1F0 VA: 0x180AEFDF0 Slot: 10
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xAEFF80 Offset: 0xAEF380 VA: 0x180AEFF80 Slot: 11
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xAF00D0 Offset: 0xAEF4D0 VA: 0x180AF00D0 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	internal string get_MainTableName() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	internal void set_MainTableName(string value) { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	internal int get_ObjectID() { }

}

public enum DataSetDateTime // TypeDefIndex: 4222
{	// Fields
	public int value__; // 0x0
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;

}

public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 4223
{	// Fields
	private DataSet _dataSet; // 0x20
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

	// Properties
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

	// Methods

	// RVA: 0xB091B0 Offset: 0xB085B0 VA: 0x180B091B0
	public void .ctor() { }

	// RVA: 0xB09620 Offset: 0xB08A20 VA: 0x180B09620
	public void .ctor(string tableName) { }

	// RVA: 0xB09690 Offset: 0xB08A90 VA: 0x180B09690
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xAFC230 Offset: 0xAFB630 VA: 0x180AFC230 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB056E0 Offset: 0xB04AE0 VA: 0x180B056E0
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xAF78C0 Offset: 0xAF6CC0 VA: 0x180AF78C0
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xB061E0 Offset: 0xB055E0 VA: 0x180B061E0
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xAF8A00 Offset: 0xAF7E00 VA: 0x180AF8A00
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xB04F30 Offset: 0xB04330 VA: 0x180B04F30
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xAF6DF0 Offset: 0xAF61F0 VA: 0x180AF6DF0
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xB05A50 Offset: 0xB04E50 VA: 0x180B05A50
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAF7BD0 Offset: 0xAF6FD0 VA: 0x180AF7BD0
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xB05BC0 Offset: 0xB04FC0 VA: 0x180B05BC0
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAF7D50 Offset: 0xAF7150 VA: 0x180AF7D50
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xAF63A0 Offset: 0xAF57A0 VA: 0x180AF63A0
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xAFC5F0 Offset: 0xAFB9F0 VA: 0x180AFC5F0
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xAF6010 Offset: 0xAF5410 VA: 0x180AF6010
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xB09820 Offset: 0xB08C20 VA: 0x180B09820
	public bool get_CaseSensitive() { }

	// RVA: 0xB0A560 Offset: 0xB09960 VA: 0x180B0A560
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xB09810 Offset: 0xB08C10 VA: 0x180B09810
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xB04A80 Offset: 0xB03E80 VA: 0x180B04A80
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xB087F0 Offset: 0xB07BF0 VA: 0x180B087F0
	internal void SuspendIndexEvents() { }

	// RVA: 0xB09BB0 Offset: 0xB08FB0 VA: 0x180B09BB0
	private bool get_IsTypedDataTable() { }

	// RVA: 0xB06D80 Offset: 0xB06180 VA: 0x180B06D80
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xB08630 Offset: 0xB07A30 VA: 0x180B08630
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xB0A290 Offset: 0xB09690 VA: 0x180B0A290
	internal bool get_SelfNested() { }

	// RVA: 0xB09C60 Offset: 0xB09060 VA: 0x180B09C60
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0xB0A1F0 Offset: 0xB095F0 VA: 0x180B0A1F0
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xB0B370 Offset: 0xB0A770 VA: 0x180B0B370
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x805390 Offset: 0x804790 VA: 0x180805390
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x805410 Offset: 0x804810 VA: 0x180805410
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xB09830 Offset: 0xB08C30 VA: 0x180B09830
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public DataColumnCollection get_Columns() { }

	// RVA: 0xB09900 Offset: 0xB08D00 VA: 0x180B09900
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xB04510 Offset: 0xB03910 VA: 0x180B04510
	private void ResetConstraints() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public DataSet get_DataSet() { }

	// RVA: 0xB07010 Offset: 0xB06410 VA: 0x180B07010
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xB09960 Offset: 0xB08D60 VA: 0x180B09960
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xB09A50 Offset: 0xB08E50 VA: 0x180B09A50
	internal bool get_EnforceConstraints() { }

	// RVA: 0xB0A6A0 Offset: 0xB09AA0 VA: 0x180B0A6A0
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xB0A490 Offset: 0xB09890 VA: 0x180B0A490
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xB0B3F0 Offset: 0xB0A7F0 VA: 0x180B0B3F0
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xAF9B00 Offset: 0xAF8F00 VA: 0x180AF9B00
	internal void EnableConstraints() { }

	// RVA: 0xB09A80 Offset: 0xB08E80 VA: 0x180B09A80
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xB09B00 Offset: 0xB08F00 VA: 0x180B09B00
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public CultureInfo get_Locale() { }

	// RVA: 0xB0A6E0 Offset: 0xB09AE0 VA: 0x180B0A6E0
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xB07180 Offset: 0xB06580 VA: 0x180B07180
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x588350 Offset: 0x587750 VA: 0x180588350
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xB09D50 Offset: 0xB09150 VA: 0x180B09D50
	public int get_MinimumCapacity() { }

	// RVA: 0xB0AB10 Offset: 0xB09F10 VA: 0x180B0AB10
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xB0A1D0 Offset: 0xB095D0 VA: 0x180B0A1D0
	internal int get_RecordCapacity() { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	internal int get_ElementColumnCount() { }

	// RVA: 0xB0A640 Offset: 0xB09A40 VA: 0x180B0A640
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xB0A0A0 Offset: 0xB094A0 VA: 0x180B0A0A0
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xB09D30 Offset: 0xB09130 VA: 0x180B09D30
	internal bool get_MergingData() { }

	// RVA: 0xB0AAF0 Offset: 0xB09EF0 VA: 0x180B0AAF0
	internal void set_MergingData(bool value) { }

	// RVA: 0xB09E20 Offset: 0xB09220 VA: 0x180B09E20
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xB0A280 Offset: 0xB09680 VA: 0x180B0A280
	internal bool get_SchemaLoading() { }

	// RVA: 0xAF3400 Offset: 0xAF2800 VA: 0x180AF3400
	internal void CacheNestedParent() { }

	// RVA: 0xAFB7D0 Offset: 0xAFABD0 VA: 0x180AFB7D0
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xB09E30 Offset: 0xB09230 VA: 0x180B09E30
	internal int get_NestedParentsCount() { }

	// RVA: 0xB0A170 Offset: 0xB09570 VA: 0x180B0A170
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xB0AF10 Offset: 0xB0A310 VA: 0x180B0AF10
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public DataRowCollection get_Rows() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public string get_TableName() { }

	// RVA: 0xB0B400 Offset: 0xB0A800 VA: 0x180B0B400
	public void set_TableName(string value) { }

	// RVA: 0xB099C0 Offset: 0xB08DC0 VA: 0x180B099C0
	internal string get_EncodedTableName() { }

	// RVA: 0xAFBFE0 Offset: 0xAFB3E0 VA: 0x180AFBFE0
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0xB09D70 Offset: 0xB09170 VA: 0x180B09D70
	public string get_Namespace() { }

	// RVA: 0xB0AB40 Offset: 0xB09F40 VA: 0x180B0AB40
	public void set_Namespace(string value) { }

	// RVA: 0xAFDAD0 Offset: 0xAFCED0 VA: 0x180AFDAD0
	internal bool IsNamespaceInherited() { }

	// RVA: 0xAF3500 Offset: 0xAF2900 VA: 0x180AF3500
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xAF3E10 Offset: 0xAF3210 VA: 0x180AF3E10
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xAF3BC0 Offset: 0xAF2FC0 VA: 0x180AF3BC0
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xAF9650 Offset: 0xAF8A50 VA: 0x180AF9650
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public string get_Prefix() { }

	// RVA: 0xB0ADC0 Offset: 0xB0A1C0 VA: 0x180B0ADC0
	public void set_Prefix(string value) { }

	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	internal DataColumn get_XmlText() { }

	// RVA: 0xB0B910 Offset: 0xB0AD10 VA: 0x180B0B910
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xB09D20 Offset: 0xB09120 VA: 0x180B09D20
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xB0AAE0 Offset: 0xB09EE0 VA: 0x180B0AAE0
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xB09D40 Offset: 0xB09140 VA: 0x180B09D40
	internal Decimal get_MinOccurs() { }

	// RVA: 0xB0AB00 Offset: 0xB09F00 VA: 0x180B0AB00
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xB070E0 Offset: 0xB064E0 VA: 0x180B070E0
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xAFB650 Offset: 0xAFAA50 VA: 0x180AFB650
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xAFB6E0 Offset: 0xAFAAE0 VA: 0x180AFB6E0
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xB07740 Offset: 0xB06B40 VA: 0x180B07740
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xAFDB90 Offset: 0xAFCF90 VA: 0x180AFDB90
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xAF2AB0 Offset: 0xAF1EB0 VA: 0x180AF2AB0
	public void AcceptChanges() { }

	// RVA: 0xAF6730 Offset: 0xAF5B30 VA: 0x180AF6730 Slot: 15
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xAF59F0 Offset: 0xAF4DF0 VA: 0x180AF59F0 Slot: 16
	public virtual DataTable Clone() { }

	// RVA: 0xAF5A00 Offset: 0xAF4E00 VA: 0x180AF5A00
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xAFCC50 Offset: 0xAFC050 VA: 0x180AFCC50
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xAF4960 Offset: 0xAF3D60 VA: 0x180AF4960
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xAF4D20 Offset: 0xAF4120 VA: 0x180AF4D20
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0xAF2EA0 Offset: 0xAF22A0 VA: 0x180AF2EA0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xAFD140 Offset: 0xAFC540 VA: 0x180AFD140
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xAFD570 Offset: 0xAFC970 VA: 0x180AFD570
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0xAF4110 Offset: 0xAF3510 VA: 0x180AF4110
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xAF4140 Offset: 0xAF3540 VA: 0x180AF4140
	public void Clear() { }

	// RVA: 0xAF4150 Offset: 0xAF3550 VA: 0x180AF4150
	internal void Clear(bool clearAll) { }

	// RVA: 0xAF3430 Offset: 0xAF2830 VA: 0x180AF3430
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xAF5BE0 Offset: 0xAF4FE0 VA: 0x180AF5BE0
	internal void CommitRow(DataRow row) { }

	// RVA: 0xAF5EB0 Offset: 0xAF52B0 VA: 0x180AF5EB0
	internal int Compare(string s1, string s2) { }

	// RVA: 0xAF5D20 Offset: 0xAF5120 VA: 0x180AF5D20
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xAFCED0 Offset: 0xAFC2D0 VA: 0x180AFCED0
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xAFDAE0 Offset: 0xAFCEE0 VA: 0x180AFDAE0
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xAF6D60 Offset: 0xAF6160 VA: 0x180AF6D60
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xAFBA60 Offset: 0xAFAE60 VA: 0x180AFBA60
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xAFBB80 Offset: 0xAFAF80 VA: 0x180AFBB80
	internal void FreeRecord(ref int record) { }

	// RVA: 0xAFBF90 Offset: 0xAFB390 VA: 0x180AFBF90
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xAFBDC0 Offset: 0xAFB1C0 VA: 0x180AFBDC0
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x778790 Offset: 0x777B90 VA: 0x180778790
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0xAFCB40 Offset: 0xAFBF40 VA: 0x180AFCB40
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xAFD160 Offset: 0xAFC560 VA: 0x180AFD160
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0xAFE780 Offset: 0xAFDB80 VA: 0x180AFE780
	internal int NewRecord() { }

	// RVA: 0xAFED60 Offset: 0xAFE160 VA: 0x180AFED60
	internal int NewUninitializedRecord() { }

	// RVA: 0xAFE500 Offset: 0xAFD900 VA: 0x180AFE500
	internal int NewRecordFromArray(object[] value) { }

	// RVA: 0xAFE820 Offset: 0xAFDC20 VA: 0x180AFE820
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xAFE490 Offset: 0xAFD890 VA: 0x180AFE490
	internal DataRow NewEmptyRow() { }

	// RVA: 0xAFED80 Offset: 0xAFE180 VA: 0x180AFED80
	private DataRow NewUninitializedRow() { }

	// RVA: 0xAFEC60 Offset: 0xAFE060 VA: 0x180AFEC60
	public DataRow NewRow() { }

	// RVA: 0xAF6490 Offset: 0xAF5890 VA: 0x180AF6490
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xAFEA60 Offset: 0xAFDE60 VA: 0x180AFEA60
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xAFEBB0 Offset: 0xAFDFB0 VA: 0x180AFEBB0
	internal DataRow NewRow(int record) { }

	// RVA: 0xAFEAE0 Offset: 0xAFDEE0 VA: 0x180AFEAE0 Slot: 17
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xAFC950 Offset: 0xAFBD50 VA: 0x180AFC950 Slot: 18
	protected virtual Type GetRowType() { }

	// RVA: 0xAFE910 Offset: 0xAFDD10 VA: 0x180AFE910
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xB09DE0 Offset: 0xB091E0 VA: 0x180B09DE0
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xAFEE80 Offset: 0xAFE280 VA: 0x180AFEE80 Slot: 19
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xAFEDC0 Offset: 0xAFE1C0 VA: 0x180AFEDC0 Slot: 20
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xAFEF40 Offset: 0xAFE340 VA: 0x180AFEF40 Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xAFF000 Offset: 0xAFE400 VA: 0x180AFF000
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 22
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xAFF020 Offset: 0xAFE420 VA: 0x180AFF020
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xAFF190 Offset: 0xAFE590 VA: 0x180AFF190
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xAFF0D0 Offset: 0xAFE4D0 VA: 0x180AFF0D0 Slot: 23
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xAFF240 Offset: 0xAFE640 VA: 0x180AFF240 Slot: 24
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xAFF3C0 Offset: 0xAFE7C0 VA: 0x180AFF3C0 Slot: 25
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xAFF300 Offset: 0xAFE700 VA: 0x180AFF300 Slot: 26
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xAFF480 Offset: 0xAFE880 VA: 0x180AFF480 Slot: 27
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xAFF540 Offset: 0xAFE940 VA: 0x180AFF540 Slot: 28
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xAFF600 Offset: 0xAFEA00 VA: 0x180AFF600 Slot: 29
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xAFF6C0 Offset: 0xAFEAC0 VA: 0x180AFF6C0
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xAFFA00 Offset: 0xAFEE00 VA: 0x180AFFA00
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xB038C0 Offset: 0xB02CC0 VA: 0x180B038C0
	internal void RecordChanged(int record) { }

	// RVA: 0xB03A30 Offset: 0xB02E30 VA: 0x180B03A30
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xB03C10 Offset: 0xB03010 VA: 0x180B03C10
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xB03DA0 Offset: 0xB031A0 VA: 0x180B03DA0
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xB04030 Offset: 0xB03430 VA: 0x180B04030
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xAFCF80 Offset: 0xAFC380 VA: 0x180AFCF80
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xB08640 Offset: 0xB07A40 VA: 0x180B08640
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xB04250 Offset: 0xB03650 VA: 0x180B04250
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xB04720 Offset: 0xB03B20 VA: 0x180B04720 Slot: 30
	public virtual void Reset() { }

	// RVA: 0xB04530 Offset: 0xB03930 VA: 0x180B04530
	internal void ResetIndexes() { }

	// RVA: 0xB04540 Offset: 0xB03940 VA: 0x180B04540
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xB04DC0 Offset: 0xB041C0 VA: 0x180B04DC0
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xAFFA80 Offset: 0xAFEE80 VA: 0x180AFFA80
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xAFFCC0 Offset: 0xAFF0C0 VA: 0x180AFFCC0
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xAFFF50 Offset: 0xAFF350 VA: 0x180AFFF50
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xB04E20 Offset: 0xB04220 VA: 0x180B04E20
	public DataRow[] Select(string filterExpression, string sort, DataViewRowState recordStates) { }

	// RVA: 0xB080F0 Offset: 0xB074F0 VA: 0x180B080F0
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0xB07800 Offset: 0xB06C00 VA: 0x180B07800
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0xB081B0 Offset: 0xB075B0 VA: 0x180B081B0
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xB04DA0 Offset: 0xB041A0 VA: 0x180B04DA0
	private void RestoreShadowIndexes() { }

	// RVA: 0xB08550 Offset: 0xB07950 VA: 0x180B08550
	private void SetShadowIndexes() { }

	// RVA: 0xB085B0 Offset: 0xB079B0 VA: 0x180B085B0
	internal void ShadowIndexCopy() { }

	// RVA: 0xB089D0 Offset: 0xB07DD0 VA: 0x180B089D0 Slot: 3
	public override string ToString() { }

	// RVA: 0xAF31C0 Offset: 0xAF25C0 VA: 0x180AF31C0
	public void BeginLoadData() { }

	// RVA: 0xAFA010 Offset: 0xAF9410 VA: 0x180AFA010
	public void EndLoadData() { }

	// RVA: 0xB08AA0 Offset: 0xB07EA0 VA: 0x180B08AA0
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xAF2EE0 Offset: 0xAF22E0 VA: 0x180AF2EE0
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xAF2ED0 Offset: 0xAF22D0 VA: 0x180AF2ED0
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xAF2DE0 Offset: 0xAF21E0 VA: 0x180AF2DE0
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xB08A80 Offset: 0xB07E80 VA: 0x180B08A80
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xAFC320 Offset: 0xAFB720 VA: 0x180AFC320
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xB0A4A0 Offset: 0xB098A0 VA: 0x180B0A4A0
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x71B010 Offset: 0x71A410 VA: 0x18071B010
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xAFE240 Offset: 0xAFD640 VA: 0x180AFE240
	public void Merge(DataTable table) { }

	// RVA: 0xAFE260 Offset: 0xAFD660 VA: 0x180AFE260
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xB08E30 Offset: 0xB08230 VA: 0x180B08E30
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xAF3B10 Offset: 0xAF2F10 VA: 0x180AF3B10
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xAF37B0 Offset: 0xAF2BB0 VA: 0x180AF37B0
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0xB08AD0 Offset: 0xB07ED0 VA: 0x180B08AD0
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xB03820 Offset: 0xB02C20 VA: 0x180B03820
	public XmlReadMode ReadXml(TextReader reader) { }

	// RVA: 0xB04A20 Offset: 0xB03E20 VA: 0x180B04A20
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xAFD8F0 Offset: 0xAFCCF0 VA: 0x180AFD8F0
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xB02A70 Offset: 0xB01E70 VA: 0x180B02A70
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB01C60 Offset: 0xB01060 VA: 0x180B01C60
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xAEA5B0 Offset: 0xAE99B0 VA: 0x180AEA5B0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xB00110 Offset: 0xAFF510 VA: 0x180B00110
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xAEA1D0 Offset: 0xAE95D0 VA: 0x180AEA1D0
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xB002D0 Offset: 0xAFF6D0 VA: 0x180B002D0
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xB00180 Offset: 0xAFF580 VA: 0x180B00180
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xB00BA0 Offset: 0xAFFFA0 VA: 0x180B00BA0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xAF6AD0 Offset: 0xAF5ED0 VA: 0x180AF6AD0
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0xAF67C0 Offset: 0xAF5BC0 VA: 0x180AF67C0
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0xAFBBA0 Offset: 0xAFAFA0 VA: 0x180AFBBA0
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xB08890 Offset: 0xB07C90 VA: 0x180B08890 Slot: 11
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xAFC9B0 Offset: 0xAFBDB0 VA: 0x180AFC9B0 Slot: 31
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xB088B0 Offset: 0xB07CB0 VA: 0x180B088B0 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xB08980 Offset: 0xB07D80 VA: 0x180B08980 Slot: 13
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xB01C40 Offset: 0xB01040 VA: 0x180B01C40 Slot: 32
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xB0A200 Offset: 0xB09600 VA: 0x180B0A200
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xB0A090 Offset: 0xB09490 VA: 0x180B0A090
	internal int get_ObjectID() { }

	// RVA: 0xAF2D20 Offset: 0xAF2120 VA: 0x180AF2D20
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xB03FB0 Offset: 0xB033B0 VA: 0x180B03FB0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xAFABD0 Offset: 0xAF9FD0 VA: 0x180AFABD0
	internal void EvaluateExpressions() { }

	// RVA: 0xAFB100 Offset: 0xAFA500 VA: 0x180AFB100
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0xAFAE60 Offset: 0xAFA260 VA: 0x180AFAE60
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xAFA240 Offset: 0xAF9640 VA: 0x180AFA240
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xAFA370 Offset: 0xAF9770 VA: 0x180AFA370
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }

}

internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 4224
{	// Fields
	private DataTable _targetTable; // 0x0

	// Methods

	// RVA: 0x1EF0A0 Offset: 0x1EE4A0 VA: 0x1801EF0A0
	internal void Prepare(DataTable table) { }

}

internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 4225
{	// Fields
	private DataSet _targetDS; // 0x0

	// Methods

	// RVA: 0x1EEF60 Offset: 0x1EE360 VA: 0x1801EEF60
	internal void Prepare(DataSet ds) { }

}

public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 4226
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13CA3E0 Offset: 0x13C97E0 VA: 0x1813CA3E0
	public void .ctor(DataTable dataTable) { }

}

public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 4227
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataTableClearEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 4228
{	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x13CCA30 Offset: 0x13CBE30 VA: 0x1813CCA30
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 11
	protected override ArrayList get_List() { }

	// RVA: 0x5F7C80 Offset: 0x5F7080 VA: 0x1805F7C80
	internal int get_ObjectID() { }

	// RVA: 0x13CCD80 Offset: 0x13CC180 VA: 0x1813CCD80
	public DataTable get_Item(int index) { }

	// RVA: 0x13CCC80 Offset: 0x13CC080 VA: 0x1813CCC80
	public DataTable get_Item(string name) { }

	// RVA: 0x13CCB60 Offset: 0x13CBF60 VA: 0x1813CCB60
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x13CBAF0 Offset: 0x13CAEF0 VA: 0x1813CBAF0
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x13CB980 Offset: 0x13CAD80 VA: 0x1813CB980
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x13CA450 Offset: 0x13C9850 VA: 0x1813CA450
	public void Add(DataTable table) { }

	// RVA: 0x13CA6B0 Offset: 0x13C9AB0 VA: 0x1813CA6B0
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x13CA6E0 Offset: 0x13C9AE0 VA: 0x1813CA6E0
	internal string AssignName() { }

	// RVA: 0x13CA7A0 Offset: 0x13C9BA0 VA: 0x1813CA7A0
	private void BaseAdd(DataTable table) { }

	// RVA: 0x13CA9C0 Offset: 0x13C9DC0 VA: 0x1813CA9C0
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x13CAB80 Offset: 0x13C9F80 VA: 0x1813CAB80
	private void BaseRemove(DataTable table) { }

	// RVA: 0x13CAD80 Offset: 0x13CA180 VA: 0x1813CAD80
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x13CB200 Offset: 0x13CA600 VA: 0x1813CB200
	public void Clear() { }

	// RVA: 0x13CB7E0 Offset: 0x13CABE0 VA: 0x1813CB7E0
	public bool Contains(string name) { }

	// RVA: 0x13CB620 Offset: 0x13CAA20 VA: 0x1813CB620
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x13CB800 Offset: 0x13CAC00 VA: 0x1813CB800
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x13CBC40 Offset: 0x13CB040 VA: 0x1813CBC40
	public int IndexOf(DataTable table) { }

	// RVA: 0x13CBD40 Offset: 0x13CB140 VA: 0x1813CBD40
	public int IndexOf(string tableName) { }

	// RVA: 0x13CBD60 Offset: 0x13CB160 VA: 0x1813CBD60
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x13CC850 Offset: 0x13CBC50 VA: 0x1813CC850
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x13CBFE0 Offset: 0x13CB3E0 VA: 0x1813CBFE0
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x13CBE20 Offset: 0x13CB220 VA: 0x1813CBE20
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x13CC220 Offset: 0x13CB620 VA: 0x1813CC220
	private string MakeName(int index) { }

	// RVA: 0x13CC2B0 Offset: 0x13CB6B0 VA: 0x1813CC2B0
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13CC360 Offset: 0x13CB760 VA: 0x1813CC360
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x13CC410 Offset: 0x13CB810 VA: 0x1813CC410
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x13CC690 Offset: 0x13CBA90 VA: 0x1813CC690
	public void Remove(DataTable table) { }

	// RVA: 0x13CC8B0 Offset: 0x13CBCB0 VA: 0x1813CC8B0
	internal void UnregisterName(string name) { }

}

public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 4229
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x13CCE60 Offset: 0x13CC260 VA: 0x1813CCE60
	public void .ctor(DataRow dataRow) { }

}

public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 4230
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, DataTableNewRowEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4232
{
// Namespace: System.Data
[DefaultEventAttribute] // RVA: 0xA4320 Offset: 0xA3720 VA: 0x1800A4320
[DefaultPropertyAttribute] // RVA: 0xA4320 Offset: 0xA3720 VA: 0x1800A4320
[DefaultMemberAttribute] // RVA: 0xA4320 Offset: 0xA3720 VA: 0x1800A4320
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4232
	// Fields
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

	// Properties
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

	// Methods

	// RVA: 0x13D13D0 Offset: 0x13D07D0 VA: 0x1813D13D0
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	public bool get_AllowDelete() { }

	// RVA: 0x1081440 Offset: 0x1080840 VA: 0x181081440
	public bool get_AllowNew() { }

	// RVA: 0x13D16F0 Offset: 0x13D0AF0 VA: 0x1813D16F0 Slot: 22
	public int get_Count() { }

	// RVA: 0x13D16C0 Offset: 0x13D0AC0 VA: 0x1813D16C0
	private int get_CountFromIndex() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x7AC250 Offset: 0x7AB650 VA: 0x1807AC250
	protected bool get_IsOpen() { }

	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x13D1740 Offset: 0x13D0B40 VA: 0x1813D1740
	public string get_Sort() { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 23
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public DataTable get_Table() { }

	// RVA: 0x13D0F40 Offset: 0x13D0340 VA: 0x1813D0F40 Slot: 10
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x13D0FA0 Offset: 0x13D03A0 VA: 0x1813D0FA0 Slot: 11
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x13D0F40 Offset: 0x13D0340 VA: 0x1813D0F40
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x13CE6F0 Offset: 0x13CDAF0 VA: 0x1813CE6F0 Slot: 25
	public virtual DataRowView AddNew() { }

	// RVA: 0x13CE9B0 Offset: 0x13CDDB0 VA: 0x1813CE9B0
	private void CheckOpen() { }

	// RVA: 0x13CEC40 Offset: 0x13CE040 VA: 0x1813CEC40
	protected void Close() { }

	// RVA: 0x13CF0F0 Offset: 0x13CE4F0 VA: 0x1813CF0F0 Slot: 21
	public void CopyTo(Array array, int index) { }

	// RVA: 0x13CEEE0 Offset: 0x13CE2E0 VA: 0x1813CEEE0
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x13CF250 Offset: 0x13CE650 VA: 0x1813CF250
	public void Delete(int index) { }

	// RVA: 0x13CF280 Offset: 0x13CE680 VA: 0x1813CF280
	internal void Delete(DataRow row) { }

	// RVA: 0x13CF460 Offset: 0x13CE860 VA: 0x1813CF460 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13CF4C0 Offset: 0x13CE8C0 VA: 0x1813CF4C0
	internal void FinishAddNew(bool success) { }

	// RVA: 0x13CF690 Offset: 0x13CEA90 VA: 0x1813CF690 Slot: 24
	public IEnumerator GetEnumerator() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 15
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 16
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x13D0BF0 Offset: 0x13CFFF0 VA: 0x1813D0BF0 Slot: 12
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x13D0C90 Offset: 0x13D0090 VA: 0x1813D0C90 Slot: 14
	private void System.Collections.IList.Clear() { }

	// RVA: 0x13D0CD0 Offset: 0x13D00D0 VA: 0x1813D0CD0 Slot: 13
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x13D0D60 Offset: 0x13D0160 VA: 0x1813D0D60 Slot: 17
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x13CFBE0 Offset: 0x13CEFE0 VA: 0x1813CFBE0
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x13CFB80 Offset: 0x13CEF80 VA: 0x1813CFB80
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x13D0DE0 Offset: 0x13D01E0 VA: 0x1813D0DE0 Slot: 18
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x13D0E20 Offset: 0x13D0220 VA: 0x1813D0E20 Slot: 19
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x13CF250 Offset: 0x13CE650 VA: 0x1813CF250 Slot: 20
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 26
	internal virtual IFilter GetFilter() { }

	// RVA: 0x13CF730 Offset: 0x13CEB30 VA: 0x1813CF730
	private int GetRecord(int recordIndex) { }

	// RVA: 0x13CF8C0 Offset: 0x13CECC0 VA: 0x1813CF8C0
	internal DataRow GetRow(int index) { }

	// RVA: 0x13CF7F0 Offset: 0x13CEBF0 VA: 0x1813CF7F0
	private DataRowView GetRowView(int record) { }

	// RVA: 0x13CF860 Offset: 0x13CEC60 VA: 0x1813CF860
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x13CFB00 Offset: 0x13CEF00 VA: 0x1813CFB00 Slot: 27
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x13CFA30 Offset: 0x13CEE30 VA: 0x1813CFA30
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x13CFD40 Offset: 0x13CF140 VA: 0x1813CFD40
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13CFFF0 Offset: 0x13CF3F0 VA: 0x1813CFFF0 Slot: 28
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13D0780 Offset: 0x13CFB80 VA: 0x1813D0780
	protected void Reset() { }

	// RVA: 0x13D0550 Offset: 0x13CF950 VA: 0x1813D0550
	internal void ResetRowViewCache() { }

	// RVA: 0x13D07B0 Offset: 0x13CFBB0 VA: 0x1813D07B0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13D0BD0 Offset: 0x13CFFD0 VA: 0x1813D0BD0 Slot: 29
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x13D09C0 Offset: 0x13CFDC0 VA: 0x1813D09C0
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x13D1340 Offset: 0x13D0740 VA: 0x1813D1340
	protected void UpdateIndex() { }

	// RVA: 0x13D1360 Offset: 0x13D0760 VA: 0x1813D1360 Slot: 30
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x13D0FE0 Offset: 0x13D03E0 VA: 0x1813D0FE0
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x13CEA00 Offset: 0x13CDE00 VA: 0x1813CEA00
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13D0310 Offset: 0x13CF710 VA: 0x1813D0310
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13CECA0 Offset: 0x13CE0A0 VA: 0x1813CECA0 Slot: 31
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13CEC80 Offset: 0x13CE080 VA: 0x1813CEC80
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1074C60 Offset: 0x1074060 VA: 0x181074C60
	internal int get_ObjectID() { }

	// RVA: 0x13D1370 Offset: 0x13D0770 VA: 0x1813D1370
	private static void .cctor() { }

}

private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 4233
{	// Fields
	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x2B0AC04

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x13CA350 Offset: 0x13C9750 VA: 0x1813CA350 Slot: 4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0x13CA360 Offset: 0x13C9760 VA: 0x1813CA360 Slot: 5
	public int GetHashCode(DataRow obj) { }

	// RVA: 0x13CA380 Offset: 0x13C9780 VA: 0x1813CA380
	private static void .cctor() { }

}

internal sealed class DataViewListener // TypeDefIndex: 4234
{	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x13CE300 Offset: 0x13CD700 VA: 0x1813CE300
	internal void .ctor(DataView dv) { }

	// RVA: 0x13CD600 Offset: 0x13CCA00 VA: 0x1813CD600
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13CDA70 Offset: 0x13CCE70 VA: 0x1813CDA70
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13CD710 Offset: 0x13CCB10 VA: 0x1813CD710
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x13CD980 Offset: 0x13CCD80 VA: 0x1813CD980
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x13CD800 Offset: 0x13CCC00 VA: 0x1813CD800
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x13CDDC0 Offset: 0x13CD1C0 VA: 0x1813CDDC0
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x13CE070 Offset: 0x13CD470 VA: 0x1813CE070
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x13CE080 Offset: 0x13CD480 VA: 0x1813CE080
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x13CDB60 Offset: 0x13CCF60 VA: 0x1813CDB60
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x13CDF90 Offset: 0x13CD390 VA: 0x1813CDF90
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x13CD6F0 Offset: 0x13CCAF0 VA: 0x1813CD6F0
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x13CDC30 Offset: 0x13CD030 VA: 0x1813CDC30
	private void RegisterListener(DataTable table) { }

}

public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 4235
{	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	internal int _nViews; // 0x28
	private static NotSupportedException s_notSupported; // 0x0

	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	public DataViewSettingCollection DataViewSettings { get; }

	// Methods

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x13CE390 Offset: 0x13CD790 VA: 0x1813CE390
	private static void .cctor() { }

}

public enum DataViewRowState // TypeDefIndex: 4236
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x13CE670 Offset: 0x13CDA70 VA: 0x1813CE670
	internal void .ctor() { }

	// RVA: 0xB9D210 Offset: 0xB9C610 VA: 0x180B9D210
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x1232890 Offset: 0x1231C90 VA: 0x181232890
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x13CE650 Offset: 0x13CDA50 VA: 0x1813CE650
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_RowFilter() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Sort() { }

}

public class DataViewSettingCollection // TypeDefIndex: 4238
{	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }

	// Methods

	// RVA: 0x13CE420 Offset: 0x13CD820 VA: 0x1813CE420 Slot: 4
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x13CE590 Offset: 0x13CD990 VA: 0x1813CE590 Slot: 5
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x13CE3F0 Offset: 0x13CD7F0 VA: 0x1813CE3F0
	internal void Remove(DataTable table) { }

}

public enum DbType // TypeDefIndex: 4239
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal ExpressionNode ExpressionNode { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x122FFC0 Offset: 0x122F3C0 VA: 0x18122FFC0
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x122FD60 Offset: 0x122F160 VA: 0x18122FD60
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x122FFE0 Offset: 0x122F3E0 VA: 0x18122FFE0
	internal string get_Expression() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal ExpressionNode get_ExpressionNode() { }

	// RVA: 0x1230020 Offset: 0x122F420 VA: 0x181230020
	internal bool get_HasValue() { }

	// RVA: 0x122F570 Offset: 0x122E970 VA: 0x18122F570
	internal void Bind(DataTable table) { }

	// RVA: 0x122F6A0 Offset: 0x122EAA0 VA: 0x18122F6A0
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x122F8C0 Offset: 0x122ECC0 VA: 0x18122F8C0
	internal object Evaluate() { }

	// RVA: 0x122F6C0 Offset: 0x122EAC0 VA: 0x18122F6C0
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x122F910 Offset: 0x122ED10 VA: 0x18122F910 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal DataColumn[] GetDependency() { }

	// RVA: 0x122F9F0 Offset: 0x122EDF0 VA: 0x18122F9F0
	internal bool IsTableAggregate() { }

	// RVA: 0x122FA10 Offset: 0x122EE10 VA: 0x18122FA10
	internal static bool IsUnknown(object value) { }

	// RVA: 0x122F8D0 Offset: 0x122ECD0 VA: 0x18122F8D0
	internal bool HasLocalAggregate() { }

	// RVA: 0x122F8F0 Offset: 0x122ECF0 VA: 0x18122F8F0
	internal bool HasRemoteAggregate() { }

	// RVA: 0x122FA70 Offset: 0x122EE70 VA: 0x18122FA70
	internal static bool ToBoolean(object value) { }

}

internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 4333
{	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x13CD070 Offset: 0x13CC470 VA: 0x1813CD070
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x13CD520 Offset: 0x13CC920 VA: 0x1813CD520
	private void .ctor(XmlWriter w) { }

	// RVA: 0x13CD550 Offset: 0x13CC950 VA: 0x1813CD550
	internal Stream get_BaseStream() { }

	// RVA: 0x13CD430 Offset: 0x13CC830 VA: 0x1813CD430 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x13CD400 Offset: 0x13CC800 VA: 0x1813CD400 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x13CD2B0 Offset: 0x13CC6B0 VA: 0x1813CD2B0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x13CD250 Offset: 0x13CC650 VA: 0x1813CD250 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x13CD460 Offset: 0x13CC860 VA: 0x1813CD460 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1314F90 Offset: 0x1314390 VA: 0x181314F90 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x13CD310 Offset: 0x13CC710 VA: 0x1813CD310 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x13CD3D0 Offset: 0x13CC7D0 VA: 0x1813CD3D0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x13CD280 Offset: 0x13CC680 VA: 0x1813CD280 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x13CD190 Offset: 0x13CC590 VA: 0x1813CD190 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x13CD220 Offset: 0x13CC620 VA: 0x1813CD220 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x13CD340 Offset: 0x13CC740 VA: 0x1813CD340 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x13CD2E0 Offset: 0x13CC6E0 VA: 0x1813CD2E0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x13CD1C0 Offset: 0x13CC5C0 VA: 0x1813CD1C0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x13CD4F0 Offset: 0x13CC8F0 VA: 0x1813CD4F0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x13CD490 Offset: 0x13CC890 VA: 0x1813CD490 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x13CD4C0 Offset: 0x13CC8C0 VA: 0x1813CD4C0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x13CD1F0 Offset: 0x13CC5F0 VA: 0x1813CD1F0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x13CD370 Offset: 0x13CC770 VA: 0x1813CD370 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x13CD3A0 Offset: 0x13CC7A0 VA: 0x1813CD3A0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x13CD130 Offset: 0x13CC530 VA: 0x1813CD130 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x13CD160 Offset: 0x13CC560 VA: 0x1813CD160 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x13CD5D0 Offset: 0x13CC9D0 VA: 0x1813CD5D0 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x13CD040 Offset: 0x13CC440 VA: 0x1813CD040 Slot: 28
	public override void Close() { }

	// RVA: 0x13CD0D0 Offset: 0x13CC4D0 VA: 0x1813CD0D0 Slot: 29
	public override void Flush() { }

	// RVA: 0x13CD100 Offset: 0x13CC500 VA: 0x1813CD100 Slot: 30
	public override string LookupPrefix(string ns) { }

}

internal sealed class DataTextReader : XmlReader // TypeDefIndex: 4334
{	// Fields
	private XmlReader _xmlreader; // 0x10

	// Properties
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

	// Methods

	// RVA: 0x13CCED0 Offset: 0x13CC2D0 VA: 0x1813CCED0
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x13CCF70 Offset: 0x13CC370 VA: 0x1813CCF70
	private void .ctor(XmlReader input) { }

	// RVA: 0x132A150 Offset: 0x1329550 VA: 0x18132A150 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xB14680 Offset: 0xB13A80 VA: 0x180B14680 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xBC4280 Offset: 0xBC3680 VA: 0x180BC4280 Slot: 7
	public override string get_Name() { }

	// RVA: 0xBC4220 Offset: 0xBC3620 VA: 0x180BC4220 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0xBC42E0 Offset: 0xBC36E0 VA: 0x180BC42E0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0xBC4350 Offset: 0xBC3750 VA: 0x180BC4350 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0xBC43B0 Offset: 0xBC37B0 VA: 0x180BC43B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0xBC40D0 Offset: 0xBC34D0 VA: 0x180BC40D0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0xBC40A0 Offset: 0xBC34A0 VA: 0x180BC40A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0xBC4190 Offset: 0xBC3590 VA: 0x180BC4190 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0xBC4160 Offset: 0xBC3560 VA: 0x180BC4160 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0xBC4380 Offset: 0xBC3780 VA: 0x180BC4380 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0xBC4410 Offset: 0xBC3810 VA: 0x180BC4410 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xBC43E0 Offset: 0xBC37E0 VA: 0x180BC43E0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0xBC3920 Offset: 0xBC2D20 VA: 0x180BC3920 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0xBC3950 Offset: 0xBC2D50 VA: 0x180BC3950 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xBC3980 Offset: 0xBC2D80 VA: 0x180BC3980 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0xBC3A20 Offset: 0xBC2E20 VA: 0x180BC3A20 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xBC39F0 Offset: 0xBC2DF0 VA: 0x180BC39F0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0xBC3A80 Offset: 0xBC2E80 VA: 0x180BC3A80 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xBC3AB0 Offset: 0xBC2EB0 VA: 0x180BC3AB0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0xBC3A50 Offset: 0xBC2E50 VA: 0x180BC3A50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0xBC3AE0 Offset: 0xBC2EE0 VA: 0x180BC3AE0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0xBC3B40 Offset: 0xBC2F40 VA: 0x180BC3B40 Slot: 31
	public override bool Read() { }

	// RVA: 0xBC4130 Offset: 0xBC3530 VA: 0x180BC4130 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0xB9A5D0 Offset: 0xB999D0 VA: 0x180B9A5D0 Slot: 33
	public override void Close() { }

	// RVA: 0xB9A640 Offset: 0xB99A40 VA: 0x180B9A640 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0xBC3BA0 Offset: 0xBC2FA0 VA: 0x180BC3BA0 Slot: 35
	public override void Skip() { }

	// RVA: 0xBC4250 Offset: 0xBC3650 VA: 0x180BC4250 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xBC3C10 Offset: 0xBC3010 VA: 0x180BC3C10 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x13CD010 Offset: 0x13CC410 VA: 0x1813CD010 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0xBC3B70 Offset: 0xBC2F70 VA: 0x180BC3B70 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x13CCFE0 Offset: 0x13CC3E0 VA: 0x1813CCFE0 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xB9A000 Offset: 0xB99400 VA: 0x180B9A000 Slot: 42
	public override string ReadString() { }

}

public abstract class DbCommandBuilder : Component // TypeDefIndex: 4369
{	// Fields
	private DbDataAdapter _dataAdapter; // 0x28
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

	// Properties
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

	// Methods

	// RVA: 0x12796A0 Offset: 0x1278AA0 VA: 0x1812796A0
	protected void .ctor() { }

	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0 Slot: 12
	public virtual ConflictOption get_ConflictOption() { }

	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0 Slot: 13
	public virtual CatalogLocation get_CatalogLocation() { }

	// RVA: 0x1279770 Offset: 0x1278B70 VA: 0x181279770 Slot: 14
	public virtual string get_CatalogSeparator() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public DbDataAdapter get_DataAdapter() { }

	// RVA: 0x12798B0 Offset: 0x1278CB0 VA: 0x1812798B0
	public void set_DataAdapter(DbDataAdapter value) { }

	// RVA: 0x1074D10 Offset: 0x1074110 VA: 0x181074D10
	internal int get_ParameterNameMaxLength() { }

	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	internal string get_ParameterNamePattern() { }

	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	private string get_QuotedBaseTableName() { }

	// RVA: 0x12797C0 Offset: 0x1278BC0 VA: 0x1812797C0 Slot: 15
	public virtual string get_QuotePrefix() { }

	// RVA: 0x1279950 Offset: 0x1278D50 VA: 0x181279950 Slot: 16
	public virtual void set_QuotePrefix(string value) { }

	// RVA: 0x1279810 Offset: 0x1278C10 VA: 0x181279810 Slot: 17
	public virtual string get_QuoteSuffix() { }

	// RVA: 0x12799E0 Offset: 0x1278DE0 VA: 0x1812799E0 Slot: 18
	public virtual void set_QuoteSuffix(string value) { }

	// RVA: 0x1279860 Offset: 0x1278C60 VA: 0x181279860 Slot: 19
	public virtual string get_SchemaSeparator() { }

	// RVA: 0x778E40 Offset: 0x778240 VA: 0x180778E40
	public bool get_SetAllValues() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	private DbCommand get_InsertCommand() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_InsertCommand(DbCommand value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	private DbCommand get_UpdateCommand() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	private void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	private DbCommand get_DeleteCommand() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	private void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x1275900 Offset: 0x1274D00 VA: 0x181275900
	private void BuildCache(bool closeConnection, DataRow dataRow, bool useColumnsForParameterNames) { }

	// RVA: 0x1278410 Offset: 0x1277810 VA: 0x181278410 Slot: 20
	protected virtual DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x1276060 Offset: 0x1275460 VA: 0x181276060
	private void BuildInformation(DataTable schemaTable) { }

	// RVA: 0x1275EC0 Offset: 0x12752C0 VA: 0x181275EC0
	private DbCommand BuildDeleteCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x1276960 Offset: 0x1275D60 VA: 0x181276960
	private DbCommand BuildInsertCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x1276ED0 Offset: 0x12762D0 VA: 0x181276ED0
	private DbCommand BuildUpdateCommand(DataTableMapping mappings, DataRow dataRow) { }

	// RVA: 0x1277360 Offset: 0x1276760 VA: 0x181277360
	private int BuildWhereClause(DataTableMapping mappings, DataRow dataRow, StringBuilder builder, DbCommand command, int parameterCount, bool isUpdate) { }

	// RVA: 0x1277990 Offset: 0x1276D90 VA: 0x181277990
	private string CreateParameterForNullTest(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x1277DA0 Offset: 0x12771A0 VA: 0x181277DA0
	private string CreateParameterForValue(DbCommand command, string parameterName, string sourceColumn, DataRowVersion version, int parameterCount, object value, DbSchemaRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x1278080 Offset: 0x1277480 VA: 0x181278080 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1278100 Offset: 0x1277500 VA: 0x181278100
	private string GetBaseParameterName(int index) { }

	// RVA: 0x12783C0 Offset: 0x12777C0 VA: 0x1812783C0
	private string GetOriginalParameterName(int index) { }

	// RVA: 0x1278370 Offset: 0x1277770 VA: 0x181278370
	private string GetNullParameterName(int index) { }

	// RVA: 0x1278590 Offset: 0x1277990 VA: 0x181278590
	private DbCommand GetSelectCommand() { }

	// RVA: 0x1278150 Offset: 0x1277550 VA: 0x181278150
	private object GetColumnValue(DataRow row, string columnName, DataTableMapping mappings, DataRowVersion version) { }

	// RVA: 0x1278200 Offset: 0x1277600 VA: 0x181278200
	private object GetColumnValue(DataRow row, DataColumn column, DataRowVersion version) { }

	// RVA: 0x1278240 Offset: 0x1277640 VA: 0x181278240
	private DataColumn GetDataColumn(string columnName, DataTableMapping tablemapping, DataRow row) { }

	// RVA: 0x12782D0 Offset: 0x12776D0 VA: 0x1812782D0
	private static DbParameter GetNextParameter(DbCommand command, int pcount) { }

	// RVA: 0x1278690 Offset: 0x1277A90 VA: 0x181278690
	private bool IncludeInInsertValues(DbSchemaRow row) { }

	// RVA: 0x1278810 Offset: 0x1277C10 VA: 0x181278810
	private bool IncludeInUpdateSet(DbSchemaRow row) { }

	// RVA: 0x1278870 Offset: 0x1277C70 VA: 0x181278870
	private bool IncludeInWhereClause(DbSchemaRow row, bool isUpdate) { }

	// RVA: 0x12789D0 Offset: 0x1277DD0 VA: 0x1812789D0
	private bool IncrementWhereCount(DbSchemaRow row) { }

	// RVA: 0x1278B10 Offset: 0x1277F10 VA: 0x181278B10 Slot: 21
	protected virtual DbCommand InitializeCommand(DbCommand command) { }

	// RVA: 0x1278C70 Offset: 0x1278070 VA: 0x181278C70
	private string QuotedColumn(string column) { }

	// RVA: 0x1278C10 Offset: 0x1278010 VA: 0x181278C10 Slot: 22
	public virtual string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x1278D10 Offset: 0x1278110 VA: 0x181278D10 Slot: 23
	public virtual void RefreshSchema() { }

	// RVA: 0x1279020 Offset: 0x1278420 VA: 0x181279020
	private static void RemoveExtraParameters(DbCommand command, int usedParameterCount) { }

	// RVA: 0x1279200 Offset: 0x1278600 VA: 0x181279200
	protected void RowUpdatingHandler(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x12790C0 Offset: 0x12784C0 VA: 0x1812790C0
	private void RowUpdatingHandlerBuilder(RowUpdatingEventArgs rowUpdatingEvent) { }

	// RVA: 0x1279640 Offset: 0x1278A40 VA: 0x181279640 Slot: 24
	public virtual string UnquoteIdentifier(string quotedIdentifier) { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause);

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract string GetParameterName(int parameterOrdinal);

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract string GetParameterName(string parameterName);

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract string GetParameterPlaceholder(int parameterOrdinal);

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void SetRowUpdatingHandler(DbDataAdapter adapter);

}

private class DbCommandBuilder.ParameterNames // TypeDefIndex: 4370
{	// Fields
	private string _originalPrefix; // 0x10
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

	// Methods

	// RVA: 0x127D060 Offset: 0x127C460 VA: 0x18127D060
	internal void .ctor(DbCommandBuilder dbCommandBuilder, DbSchemaRow[] schemaRows) { }

	// RVA: 0x127CEE0 Offset: 0x127C2E0 VA: 0x18127CEE0
	private void SetAndValidateNamePrefixes() { }

	// RVA: 0x127C730 Offset: 0x127BB30 VA: 0x18127C730
	private void ApplyProviderSpecificFormat() { }

	// RVA: 0x127C940 Offset: 0x127BD40 VA: 0x18127C940
	private void EliminateConflictingNames() { }

	// RVA: 0x127CAE0 Offset: 0x127BEE0 VA: 0x18127CAE0
	internal void GenerateMissingNames(DbSchemaRow[] schemaRows) { }

	// RVA: 0x127CCB0 Offset: 0x127C0B0 VA: 0x18127CCB0
	private int GetAdjustedParameterNameMaxLength() { }

	// RVA: 0x127CD80 Offset: 0x127C180 VA: 0x18127CD80
	private string GetNextGenericParameterName() { }

	// RVA: 0xEA9000 Offset: 0xEA8400 VA: 0x180EA9000
	internal string GetBaseParameterName(int index) { }

	// RVA: 0x127CEA0 Offset: 0x127C2A0 VA: 0x18127CEA0
	internal string GetOriginalParameterName(int index) { }

	// RVA: 0x127CE60 Offset: 0x127C260 VA: 0x18127CE60
	internal string GetNullParameterName(int index) { }

}

internal sealed class DbSchemaRow // TypeDefIndex: 4371
{	// Fields
	private DbSchemaTable _schemaTable; // 0x10
	private DataRow _dataRow; // 0x18

	// Properties
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

	// Methods

	// RVA: 0x127B350 Offset: 0x127A750 VA: 0x18127B350
	internal static DbSchemaRow[] GetSortedSchemaRows(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	internal void .ctor(DbSchemaTable schemaTable, DataRow dataRow) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal DataRow get_DataRow() { }

	// RVA: 0x127BD20 Offset: 0x127B120 VA: 0x18127BD20
	internal string get_ColumnName() { }

	// RVA: 0x127B860 Offset: 0x127AC60 VA: 0x18127B860
	internal string get_BaseColumnName() { }

	// RVA: 0x127BAC0 Offset: 0x127AEC0 VA: 0x18127BAC0
	internal string get_BaseServerName() { }

	// RVA: 0x127B730 Offset: 0x127AB30 VA: 0x18127B730
	internal string get_BaseCatalogName() { }

	// RVA: 0x127B990 Offset: 0x127AD90 VA: 0x18127B990
	internal string get_BaseSchemaName() { }

	// RVA: 0x127BBF0 Offset: 0x127AFF0 VA: 0x18127BBF0
	internal string get_BaseTableName() { }

	// RVA: 0x127BE30 Offset: 0x127B230 VA: 0x18127BE30
	internal bool get_IsAutoIncrement() { }

	// RVA: 0x127C610 Offset: 0x127BA10 VA: 0x18127C610
	internal bool get_IsUnique() { }

	// RVA: 0x127C4F0 Offset: 0x127B8F0 VA: 0x18127C4F0
	internal bool get_IsRowVersion() { }

	// RVA: 0x127C190 Offset: 0x127B590 VA: 0x18127C190
	internal bool get_IsKey() { }

	// RVA: 0x127BF50 Offset: 0x127B350 VA: 0x18127BF50
	internal bool get_IsExpression() { }

	// RVA: 0x127C070 Offset: 0x127B470 VA: 0x18127C070
	internal bool get_IsHidden() { }

	// RVA: 0x127C2B0 Offset: 0x127B6B0 VA: 0x18127C2B0
	internal bool get_IsLong() { }

	// RVA: 0x127C3D0 Offset: 0x127B7D0 VA: 0x18127C3D0
	internal bool get_IsReadOnly() { }

	// RVA: 0x127B610 Offset: 0x127AA10 VA: 0x18127B610
	internal bool get_AllowDBNull() { }

}

internal sealed class DbSchemaTable // TypeDefIndex: 4372
{	// Fields
	private static readonly string[] s_DBCOLUMN_NAME; // 0x0
	internal DataTable _dataTable; // 0x10
	private DataColumnCollection _columns; // 0x18
	private DataColumn[] _columnCache; // 0x20
	private bool _returnProviderSpecificTypes; // 0x28

	// Properties
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

	// Methods

	// RVA: 0x17C8820 Offset: 0x17C7C20 VA: 0x1817C8820
	internal void .ctor(DataTable dataTable, bool returnProviderSpecificTypes) { }

	// RVA: 0x17C8960 Offset: 0x17C7D60 VA: 0x1817C8960
	internal DataColumn get_ColumnName() { }

	// RVA: 0x17C8940 Offset: 0x17C7D40 VA: 0x1817C8940
	internal DataColumn get_BaseServerName() { }

	// RVA: 0x17C8920 Offset: 0x17C7D20 VA: 0x1817C8920
	internal DataColumn get_BaseColumnName() { }

	// RVA: 0x17C8950 Offset: 0x17C7D50 VA: 0x1817C8950
	internal DataColumn get_BaseTableName() { }

	// RVA: 0x17C8910 Offset: 0x17C7D10 VA: 0x1817C8910
	internal DataColumn get_BaseCatalogName() { }

	// RVA: 0x17C8930 Offset: 0x17C7D30 VA: 0x1817C8930
	internal DataColumn get_BaseSchemaName() { }

	// RVA: 0x17C8970 Offset: 0x17C7D70 VA: 0x1817C8970
	internal DataColumn get_IsAutoIncrement() { }

	// RVA: 0x17C89E0 Offset: 0x17C7DE0 VA: 0x1817C89E0
	internal DataColumn get_IsUnique() { }

	// RVA: 0x17C89A0 Offset: 0x17C7DA0 VA: 0x1817C89A0
	internal DataColumn get_IsKey() { }

	// RVA: 0x17C89D0 Offset: 0x17C7DD0 VA: 0x1817C89D0
	internal DataColumn get_IsRowVersion() { }

	// RVA: 0x17C8900 Offset: 0x17C7D00 VA: 0x1817C8900
	internal DataColumn get_AllowDBNull() { }

	// RVA: 0x17C8980 Offset: 0x17C7D80 VA: 0x1817C8980
	internal DataColumn get_IsExpression() { }

	// RVA: 0x17C8990 Offset: 0x17C7D90 VA: 0x1817C8990
	internal DataColumn get_IsHidden() { }

	// RVA: 0x17C89B0 Offset: 0x17C7DB0 VA: 0x1817C89B0
	internal DataColumn get_IsLong() { }

	// RVA: 0x17C89C0 Offset: 0x17C7DC0 VA: 0x1817C89C0
	internal DataColumn get_IsReadOnly() { }

	// RVA: 0x17C7CD0 Offset: 0x17C70D0 VA: 0x1817C7CD0
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column) { }

	// RVA: 0x17C7CE0 Offset: 0x17C70E0 VA: 0x1817C7CE0
	private DataColumn CachedDataColumn(DbSchemaTable.ColumnEnum column, DbSchemaTable.ColumnEnum column2) { }

	// RVA: 0x17C7ED0 Offset: 0x17C72D0 VA: 0x1817C7ED0
	private static void .cctor() { }

}

private enum DbSchemaTable.ColumnEnum // TypeDefIndex: 4373
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	private static readonly object s_eventFillError; // 0x0
	private MissingMappingAction _missingMappingAction; // 0x28

	// Properties
	[DefaultValueAttribute] // RVA: 0xA9C10 Offset: 0xA9010 VA: 0x1800A9C10
	public MissingMappingAction MissingMappingAction { get; }

	// Methods

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 12
	public MissingMappingAction get_MissingMappingAction() { }

	// RVA: 0x126F240 Offset: 0x126E640 VA: 0x18126F240
	private static void .cctor() { }

}

public sealed class DataColumnMapping : MarshalByRefObject // TypeDefIndex: 4375
{	// Fields
	private string _dataSetColumnName; // 0x18
	private string _sourceColumnName; // 0x20

	// Properties
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string DataSetColumn { get; }
	[DefaultValueAttribute] // RVA: 0x91A80 Offset: 0x90E80 VA: 0x180091A80
	public string SourceColumn { get; }

	// Methods

	// RVA: 0x126FCF0 Offset: 0x126F0F0 VA: 0x18126FCF0 Slot: 6
	public string get_DataSetColumn() { }

	// RVA: 0x126FD40 Offset: 0x126F140 VA: 0x18126FD40 Slot: 7
	public string get_SourceColumn() { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x126FC20 Offset: 0x126F020 VA: 0x18126FC20
	public DataColumn GetDataColumnBySchemaAction(DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x126F900 Offset: 0x126ED00 VA: 0x18126F900
	public static DataColumn GetDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

	// RVA: 0x126F7C0 Offset: 0x126EBC0 VA: 0x18126F7C0
	internal static DataColumn CreateDataColumnBySchemaAction(string sourceColumn, string dataSetColumn, DataTable dataTable, Type dataType, MissingSchemaAction schemaAction) { }

}

public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
{
// Namespace: System.Data.Common
[DefaultMemberAttribute] // RVA: 0x70A90 Offset: 0x6FE90 VA: 0x180070A90
public sealed class DataColumnMappingCollection : MarshalByRefObject // TypeDefIndex: 4377
	// Fields
	private List<DataColumnMapping> _items; // 0x18

	// Properties
	[BrowsableAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E810 Offset: 0x9DC10 VA: 0x18009E810
	public int Count { get; }

	// Methods

	// RVA: 0x126F780 Offset: 0x126EB80 VA: 0x18126F780 Slot: 6
	public int get_Count() { }

	// RVA: 0x126F600 Offset: 0x126EA00 VA: 0x18126F600 Slot: 7
	public int IndexOf(string sourceColumn) { }

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x126F2A0 Offset: 0x126E6A0 VA: 0x18126F2A0
	public static DataColumn GetDataColumn(DataColumnMappingCollection columnMappings, string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

internal sealed class DataRecordInternal : DbDataRecord, ICustomTypeDescriptor // TypeDefIndex: 4378
{	// Fields
	private SchemaInfo[] _schemaInfo; // 0x10
	private object[] _values; // 0x18
	private PropertyDescriptorCollection _propertyDescriptors; // 0x20
	private FieldNameLookup _fieldNameLookup; // 0x28

	// Properties
	public override int FieldCount { get; }
	public override object Item { get; }

	// Methods

	// RVA: 0x10DF720 Offset: 0x10DEB20 VA: 0x1810DF720
	internal void .ctor(SchemaInfo[] schemaInfo, object[] values, PropertyDescriptorCollection descriptors, FieldNameLookup fieldNameLookup) { }

	// RVA: 0xA4F990 Offset: 0xA4ED90 VA: 0x180A4F990 Slot: 15
	public override int get_FieldCount() { }

	// RVA: 0x126FE90 Offset: 0x126F290 VA: 0x18126FE90 Slot: 21
	public override int GetValues(object[] values) { }

	// RVA: 0x126FE10 Offset: 0x126F210 VA: 0x18126FE10 Slot: 19
	public override string GetName(int i) { }

	// RVA: 0x126FE50 Offset: 0x126F250 VA: 0x18126FE50 Slot: 20
	public override object GetValue(int i) { }

	// RVA: 0x126FD90 Offset: 0x126F190 VA: 0x18126FD90 Slot: 17
	public override string GetDataTypeName(int i) { }

	// RVA: 0x126FDD0 Offset: 0x126F1D0 VA: 0x18126FDD0 Slot: 18
	public override Type GetFieldType(int i) { }

	// RVA: 0xAEA3F0 Offset: 0xAE97F0 VA: 0x180AEA3F0 Slot: 16
	public override object get_Item(int i) { }

	// RVA: 0x126FFF0 Offset: 0x126F3F0 VA: 0x18126FFF0 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x12700B0 Offset: 0x126F4B0 VA: 0x1812700B0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1270040 Offset: 0x126F440 VA: 0x181270040 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

internal abstract class DataStorage // TypeDefIndex: 4381
{	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
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

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x1272C80 Offset: 0x1272080 VA: 0x181272C80
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x1272C50 Offset: 0x1272050 VA: 0x181272C50
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x1272D30 Offset: 0x1272130 VA: 0x181272D30
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x1272EE0 Offset: 0x12722E0 VA: 0x181272EE0
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1272F00 Offset: 0x1272300 VA: 0x181272F00
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x12701B0 Offset: 0x126F5B0 VA: 0x1812701B0 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x12700F0 Offset: 0x126F4F0 VA: 0x1812700F0
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x1270280 Offset: 0x126F680 VA: 0x181270280
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x1270390 Offset: 0x126F790 VA: 0x181270390
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x1270F60 Offset: 0x1270360 VA: 0x181270F60
	protected object GetBits(int recordNo) { }

	// RVA: 0x1271190 Offset: 0x1270590 VA: 0x181271190 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x1271330 Offset: 0x1270730 VA: 0x181271330
	protected bool HasValue(int recordNo) { }

	// RVA: 0x12716D0 Offset: 0x1270AD0 VA: 0x1812716D0 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x1271A90 Offset: 0x1270E90 VA: 0x181271A90
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1271A00 Offset: 0x1270E00 VA: 0x181271A00 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x1270340 Offset: 0x126F740 VA: 0x181270340 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x1270300 Offset: 0x126F700 VA: 0x181270300 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1270400 Offset: 0x126F800 VA: 0x181270400
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x1271030 Offset: 0x1270430 VA: 0x181271030
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x12711A0 Offset: 0x12705A0 VA: 0x1812711A0
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x1271980 Offset: 0x1270D80 VA: 0x181271980
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x12719F0 Offset: 0x1270DF0 VA: 0x1812719F0
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x1271970 Offset: 0x1270D70 VA: 0x181271970
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x1271830 Offset: 0x1270C30 VA: 0x181271830
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x1270ED0 Offset: 0x12702D0 VA: 0x181270ED0
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x1271420 Offset: 0x1270820 VA: 0x181271420
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x1271560 Offset: 0x1270960 VA: 0x181271560
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x1271360 Offset: 0x1270760 VA: 0x181271360
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x12716F0 Offset: 0x1270AF0 VA: 0x1812716F0
	public static bool IsObjectNull(object value) { }

	// RVA: 0x12717D0 Offset: 0x1270BD0 VA: 0x1812717D0
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x1270FA0 Offset: 0x12703A0 VA: 0x181270FA0
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x12703E0 Offset: 0x126F7E0 VA: 0x1812703E0
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1271AB0 Offset: 0x1270EB0 VA: 0x181271AB0
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x1271230 Offset: 0x1270630 VA: 0x181271230
	internal static Type GetType(string value) { }

	// RVA: 0x1270FC0 Offset: 0x12703C0 VA: 0x181270FC0
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x1271AD0 Offset: 0x1270ED0 VA: 0x181271AD0
	private static void .cctor() { }

}

public sealed class DataTableMapping : MarshalByRefObject // TypeDefIndex: 4382
{	// Fields
	private DataColumnMappingCollection _columnMappings; // 0x18

	// Methods

	[EditorBrowsableAttribute] // RVA: 0x8CB80 Offset: 0x8BF80 VA: 0x18008CB80
	// RVA: 0x1272F20 Offset: 0x1272320 VA: 0x181272F20
	public DataColumn GetDataColumn(string sourceColumn, Type dataType, DataTable dataTable, MissingMappingAction mappingAction, MissingSchemaAction schemaAction) { }

}

public abstract class DbCommand : Component, IDbCommand, IDisposable // TypeDefIndex: 4386
{	// Properties
	[RefreshPropertiesAttribute] // RVA: 0xA3AE0 Offset: 0xA2EE0 VA: 0x1800A3AE0
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

	// Methods

	// RVA: 0x1279A90 Offset: 0x1278E90 VA: 0x181279A90
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_CommandText();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_CommandText(string value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int get_CommandTimeout();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_CommandTimeout(int value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_CommandType(CommandType value);

	// RVA: 0x1279AF0 Offset: 0x1278EF0 VA: 0x181279AF0
	public DbConnection get_Connection() { }

	// RVA: 0x1270FA0 Offset: 0x12703A0 VA: 0x181270FA0
	public void set_Connection(DbConnection value) { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DbConnection get_DbConnection();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void set_DbConnection(DbConnection value);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract DbParameterCollection get_DbParameterCollection();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract DbTransaction get_DbTransaction();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void set_DbTransaction(DbTransaction value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool get_DesignTimeVisible();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_DesignTimeVisible(bool value);

	// RVA: 0x11CD1D0 Offset: 0x11CC5D0 VA: 0x1811CD1D0
	public DbParameterCollection get_Parameters() { }

	// RVA: 0x1279B10 Offset: 0x1278F10 VA: 0x181279B10
	public DbTransaction get_Transaction() { }

	// RVA: 0xE27F00 Offset: 0xE27300 VA: 0x180E27F00
	public void set_Transaction(DbTransaction value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract UpdateRowSource get_UpdatedRowSource();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_UpdatedRowSource(UpdateRowSource value);

	// RVA: 0xFC61D0 Offset: 0xFC55D0 VA: 0x180FC61D0
	public DbParameter CreateParameter() { }

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract DbParameter CreateDbParameter();

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int ExecuteNonQuery();

	// RVA: 0x1279A70 Offset: 0x1278E70 VA: 0x181279A70
	public DbDataReader ExecuteReader(CommandBehavior behavior) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Prepare();

}

public abstract class DbConnection : Component, IDisposable // TypeDefIndex: 4387
{	// Properties
	[RefreshPropertiesAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	[DefaultValueAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	[RecommendedAsConfigurableAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	[SettingsBindableAttribute] // RVA: 0xAAF50 Offset: 0xAA350 VA: 0x1800AAF50
	public abstract string ConnectionString { get; set; }
	[BrowsableAttribute] // RVA: 0x9A790 Offset: 0x99B90 VA: 0x18009A790
	public abstract ConnectionState State { get; }

	// Methods

	// RVA: 0x1279C50 Offset: 0x1279050 VA: 0x181279C50
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_ConnectionString();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_ConnectionString(string value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ConnectionState get_State();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Close();

	// RVA: 0x1279AF0 Offset: 0x1278EF0 VA: 0x181279AF0
	public DbCommand CreateCommand() { }

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract DbCommand CreateDbCommand();

	// RVA: 0x1279B30 Offset: 0x1278F30 VA: 0x181279B30 Slot: 18
	public virtual void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x1279BF0 Offset: 0x1278FF0 VA: 0x181279BF0 Slot: 19
	public virtual DataTable GetSchema(string collectionName) { }

	// RVA: 0x1279B90 Offset: 0x1278F90 VA: 0x181279B90 Slot: 20
	public virtual DataTable GetSchema(string collectionName, string[] restrictionValues) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Open();

}

public abstract class DbDataAdapter : DataAdapter // TypeDefIndex: 4388
{	// Fields
	internal static readonly object s_parameterValueNonNullValue; // 0x0
	internal static readonly object s_parameterValueNullValue; // 0x8

	// Properties
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

	// Methods

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	private IDbDataAdapter get__IDbDataAdapter() { }

	// RVA: 0x1279D40 Offset: 0x1279140 VA: 0x181279D40
	public DbCommand get_DeleteCommand() { }

	// RVA: 0x1279FC0 Offset: 0x12793C0 VA: 0x181279FC0
	public void set_DeleteCommand(DbCommand value) { }

	// RVA: 0x1279DE0 Offset: 0x12791E0 VA: 0x181279DE0
	public DbCommand get_InsertCommand() { }

	// RVA: 0x127A020 Offset: 0x1279420 VA: 0x18127A020
	public void set_InsertCommand(DbCommand value) { }

	// RVA: 0x1279E80 Offset: 0x1279280 VA: 0x181279E80
	public DbCommand get_SelectCommand() { }

	// RVA: 0x1279F20 Offset: 0x1279320 VA: 0x181279F20
	public DbCommand get_UpdateCommand() { }

	// RVA: 0x127A080 Offset: 0x1279480 VA: 0x18127A080
	public void set_UpdateCommand(DbCommand value) { }

	// RVA: 0x1279CB0 Offset: 0x12790B0 VA: 0x181279CB0
	private static void .cctor() { }

}

public abstract class DbDataReader : MarshalByRefObject, IDataReader, IDisposable, IDataRecord, IEnumerable // TypeDefIndex: 4389
{	// Properties
	public abstract int FieldCount { get; }
	public abstract int RecordsAffected { get; }
	public virtual int VisibleFieldCount { get; }
	public abstract object Item { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_FieldCount();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int get_RecordsAffected();

	// RVA: 0x1279AF0 Offset: 0x1278EF0 VA: 0x181279AF0 Slot: 19
	public virtual int get_VisibleFieldCount() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object get_Item(int ordinal);

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 21
	public virtual void Close() { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: 0x127A0E0 Offset: 0x12794E0 VA: 0x18127A0E0 Slot: 9
	public void Dispose() { }

	// RVA: 0x127A100 Offset: 0x1279500 VA: 0x18127A100 Slot: 22
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetDataTypeName(int ordinal);

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: -1 Offset: -1 Slot: 24
	public abstract IEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Type GetFieldType(int ordinal);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string GetName(int ordinal);

	// RVA: 0x127A120 Offset: 0x1279520 VA: 0x18127A120 Slot: 27
	public virtual DataTable GetSchemaTable() { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool GetBoolean(int ordinal);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int GetInt32(int ordinal);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract long GetInt64(int ordinal);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string GetString(int ordinal);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract object GetValue(int ordinal);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int GetValues(object[] values);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract bool IsDBNull(int ordinal);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract bool NextResult();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract bool Read();

}

public abstract class DbDataRecord : ICustomTypeDescriptor, IDataRecord // TypeDefIndex: 4390
{	// Properties
	public abstract int FieldCount { get; }
	public abstract object Item { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_FieldCount();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract object get_Item(int i);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract string GetDataTypeName(int i);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Type GetFieldType(int i);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object GetValue(int i);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int GetValues(object[] values);

	// RVA: 0x127A170 Offset: 0x1279570 VA: 0x18127A170 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x127A1C0 Offset: 0x12795C0 VA: 0x18127A1C0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x127A200 Offset: 0x1279600 VA: 0x18127A200 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

public class DbEnumerator : IEnumerator // TypeDefIndex: 4391
{	// Fields
	internal IDataReader _reader; // 0x10
	internal DbDataRecord _current; // 0x18
	internal SchemaInfo[] _schemaInfo; // 0x20
	internal PropertyDescriptorCollection _descriptors; // 0x28
	private FieldNameLookup _fieldNameLookup; // 0x30
	private bool _closeReader; // 0x38

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x127AA50 Offset: 0x1279E50 VA: 0x18127AA50
	public void .ctor(IDataReader reader, bool closeReader) { }

	// RVA: 0x127AA50 Offset: 0x1279E50 VA: 0x18127AA50
	public void .ctor(DbDataReader reader, bool closeReader) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	public object get_Current() { }

	// RVA: 0x127A810 Offset: 0x1279C10 VA: 0x18127A810 Slot: 4
	public bool MoveNext() { }

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: 0x127A9F0 Offset: 0x1279DF0 VA: 0x18127A9F0 Slot: 6
	public void Reset() { }

	// RVA: 0x127A250 Offset: 0x1279650 VA: 0x18127A250
	private void BuildSchemaInfo() { }

}

private sealed class DbEnumerator.DbColumnDescriptor : PropertyDescriptor // TypeDefIndex: 4392
{	// Fields
	private int _ordinal; // 0x88
	private Type _type; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1275850 Offset: 0x1274C50 VA: 0x181275850
	internal void .ctor(int ordinal, string name, Type type) { }

	// RVA: 0x12758A0 Offset: 0x1274CA0 VA: 0x1812758A0 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x12756D0 Offset: 0x1274AD0 VA: 0x1812756D0 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x12757F0 Offset: 0x1274BF0 VA: 0x1812757F0 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

}

public abstract class DbException : ExternalException // TypeDefIndex: 4393
{	// Methods

	// RVA: 0x127AB10 Offset: 0x1279F10 VA: 0x18127AB10
	protected void .ctor() { }

	// RVA: 0x127AB00 Offset: 0x1279F00 VA: 0x18127AB00
	protected void .ctor(string message) { }

	// RVA: 0x127AB20 Offset: 0x1279F20 VA: 0x18127AB20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public static class DbMetaDataCollectionNames // TypeDefIndex: 4394
{	// Fields
	public static readonly string MetaDataCollections; // 0x0
	public static readonly string DataSourceInformation; // 0x8
	public static readonly string DataTypes; // 0x10
	public static readonly string Restrictions; // 0x18
	public static readonly string ReservedWords; // 0x20

	// Methods

	// RVA: 0x127ABA0 Offset: 0x1279FA0 VA: 0x18127ABA0
	private static void .cctor() { }

}

public static class DbMetaDataColumnNames // TypeDefIndex: 4395
{	// Fields
	public static readonly string CollectionName; // 0x0
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

	// Methods

	// RVA: 0x127AC70 Offset: 0x127A070 VA: 0x18127AC70
	private static void .cctor() { }

}

public abstract class DbParameter : MarshalByRefObject // TypeDefIndex: 4396
{	// Properties
	[BrowsableAttribute] // RVA: 0xABBE0 Offset: 0xAAFE0 VA: 0x1800ABBE0
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

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract DbType get_DbType();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_DbType(DbType value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract ParameterDirection get_Direction();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_Direction(ParameterDirection value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsNullable();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void set_IsNullable(bool value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string get_ParameterName();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_ParameterName(string value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void set_Size(int value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string get_SourceColumn();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void set_SourceColumn(string value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void set_SourceColumnNullMapping(bool value);

	// RVA: 0x127B340 Offset: 0x127A740 VA: 0x18127B340 Slot: 18
	public virtual DataRowVersion get_SourceVersion() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 19
	public virtual void set_SourceVersion(DataRowVersion value) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void set_Value(object value);

}

public abstract class DbParameterCollection : MarshalByRefObject, IList, ICollection, IEnumerable // TypeDefIndex: 4397
{	// Properties
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E670 Offset: 0x9DA70 VA: 0x18009E670
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

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_Count();

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 22
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 23
	public virtual bool get_IsReadOnly() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract object get_SyncRoot();

	// RVA: 0x127B270 Offset: 0x127A670 VA: 0x18127B270 Slot: 6
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x127B290 Offset: 0x127A690 VA: 0x18127B290 Slot: 7
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x127B270 Offset: 0x127A670 VA: 0x18127B270
	public DbParameter get_Item(int index) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void Clear();

	[EditorBrowsableAttribute] // RVA: 0x7D5E0 Offset: 0x7C9E0 VA: 0x18007D5E0
	// RVA: -1 Offset: -1 Slot: 29
	public abstract IEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract DbParameter GetParameter(int index);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int IndexOf(string parameterName);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void RemoveAt(int index);

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract void SetParameter(int index, DbParameter value);

}

public abstract class DbProviderFactory // TypeDefIndex: 4398
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public sealed class DbProviderSpecificTypePropertyAttribute : Attribute // TypeDefIndex: 4399
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsProviderSpecificTypeProperty>k__BackingField; // 0x10

	// Methods

	// RVA: 0xFD7A30 Offset: 0xFD6E30 VA: 0x180FD7A30
	public void .ctor(bool isProviderSpecificTypeProperty) { }

}

public abstract class DbTransaction : MarshalByRefObject, IDisposable // TypeDefIndex: 4400
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Commit();

	// RVA: 0x1629790 Offset: 0x1628B90 VA: 0x181629790 Slot: 6
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Rollback();

}

public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5705
{
// Namespace: System.Runtime.Serialization
[AttributeUsageAttribute] // RVA: 0xC9A30 Offset: 0xC8E30 VA: 0x1800C9A30
public sealed class DataContractAttribute : Attribute // TypeDefIndex: 5705
	// Fields
	private bool isReference; // 0x10

	// Properties
	public bool IsReference { get; }

	// Methods

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsReference() { }

}

public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 5706
{	// Fields
	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	// Properties
	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Order() { }

	// RVA: 0x7E8DD0 Offset: 0x7E81D0 VA: 0x1807E8DD0
	public bool get_IsRequired() { }

	// RVA: 0x7E8DC0 Offset: 0x7E81C0 VA: 0x1807E8DC0
	public bool get_EmitDefaultValue() { }

}

public static class Database // TypeDefIndex: 6181
{	// Methods

	// RVA: 0x14E2E50 Offset: 0x14E2250 VA: 0x1814E2E50
	public static void Insert(string parent, object contents, Action<bool> onFinished) { }

	// RVA: 0x14E2BA0 Offset: 0x14E1FA0 VA: 0x1814E2BA0
	public static void Insert(string parent, object contents, Action<bool, string> onFinished) { }

	// RVA: 0x14E2F20 Offset: 0x14E2320 VA: 0x1814E2F20
	public static void Remove(string parent, string id, Action<bool> onFinished) { }

	// RVA: -1 Offset: -1
	public static Result<T> Query<T>(string parent, int limit, Action<Result<T>> onFinished) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12575D0 Offset: 0x12569D0 VA: 0x1812575D0
	|-Database.Query<object>
	*/

	// RVA: 0x14E29F0 Offset: 0x14E1DF0 VA: 0x1814E29F0
	public static void Count(string parent, Action<int> onResult) { }

}

private sealed class Database.<>c__DisplayClass0_0 // TypeDefIndex: 6182
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F3EF0 Offset: 0x14F32F0 VA: 0x1814F3EF0
	internal void <Insert>b__0(bool success, string id) { }

}

private sealed class Database.<>c__DisplayClass1_0 // TypeDefIndex: 6183
{	// Fields
	public Action<bool, string> onFinished; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F3FE0 Offset: 0x14F33E0 VA: 0x1814F3FE0
	internal void <Insert>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass2_0 // TypeDefIndex: 6184
{	// Fields
	public Action<bool> onFinished; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F4160 Offset: 0x14F3560 VA: 0x1814F4160
	internal void <Remove>b__0(object s, UploadValuesCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass3_0<T> // TypeDefIndex: 6185
{	// Fields
	public Result<T> result; // 0x0
	public Action<Result<T>> onFinished; // 0x0
	public Action <>9__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Database.<>c__DisplayClass3_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__0(object s, DownloadStringCompletedEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3E80 Offset: 0x15E3280 VA: 0x1815E3E80
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <Query>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E4210 Offset: 0x15E3610 VA: 0x1815E4210
	|-Database.<>c__DisplayClass3_0<object>.<Query>b__1
	*/

}

private sealed class Database.<>c__3<T> // TypeDefIndex: 6186
{	// Fields
	public static readonly Database.<>c__3<T> <>9; // 0x0
	public static Func<QueryResponse, Result.Entry<T>> <>9__3_2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD602E0 Offset: 0xD5F6E0 VA: 0x180D602E0
	|-Database.<>c__3<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-Database.<>c__3<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Result.Entry<T> <Query>b__3_2(QueryResponse x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3CD0 Offset: 0x15E30D0 VA: 0x1815E3CD0
	|-Database.<>c__3<object>.<Query>b__3_2
	*/

}

private sealed class Database.<>c__DisplayClass4_0 // TypeDefIndex: 6187
{	// Fields
	public Action<int> onResult; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F4250 Offset: 0x14F3650 VA: 0x1814F4250
	internal void <Count>b__0(object s, DownloadStringCompletedEventArgs e) { }

}

private sealed class Database.<>c__DisplayClass4_1 // TypeDefIndex: 6188
{	// Fields
	public int count; // 0x10
	public Database.<>c__DisplayClass4_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F43E0 Offset: 0x14F37E0 VA: 0x1814F43E0
	internal void <Count>b__1() { }

}

public class Database // TypeDefIndex: 7356
{
// Namespace: Facepunch.Sqlite
public class Database // TypeDefIndex: 7356
	// Fields
	private IntPtr _connection; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsConnectionOpen>k__BackingField; // 0x18

	// Properties
	private bool IsConnectionOpen { get; set; }
	public int AffectedRows { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	private bool get_IsConnectionOpen() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	private void set_IsConnectionOpen(bool value) { }

	// RVA: 0x23185A0 Offset: 0x23179A0 VA: 0x1823185A0
	public void Open(string path, bool fastMode = False) { }

	// RVA: 0x2318CF0 Offset: 0x23180F0 VA: 0x182318CF0
	public bool TableExists(string name) { }

	// RVA: 0x2318530 Offset: 0x2317930 VA: 0x182318530
	public bool IndexExists(string tableName, string indexName) { }

	// RVA: 0x2317D60 Offset: 0x2317160 VA: 0x182317D60
	public bool ColumnExists(string tableName, string columnName) { }

	// RVA: 0x2317C90 Offset: 0x2317090 VA: 0x182317C90
	public void Close() { }

	// RVA: 0x2318D50 Offset: 0x2318150 VA: 0x182318D50
	public int get_AffectedRows() { }

	// RVA: 0x2318060 Offset: 0x2317460 VA: 0x182318060
	public void Execute(string query) { }

	// RVA: -1 Offset: -1
	public void Execute<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153FEA0 Offset: 0x153F2A0 VA: 0x18153FEA0
	|-Database.Execute<int>
	|
	|-RVA: 0x1540240 Offset: 0x153F640 VA: 0x181540240
	|-Database.Execute<object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153FD10 Offset: 0x153F110 VA: 0x18153FD10
	|-Database.Execute<int, int>
	|
	|-RVA: 0x15401A0 Offset: 0x153F5A0 VA: 0x1815401A0
	|-Database.Execute<object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3>(string query, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153FC50 Offset: 0x153F050 VA: 0x18153FC50
	|-Database.Execute<int, int, int>
	|
	|-RVA: 0x15400E0 Offset: 0x153F4E0 VA: 0x1815400E0
	|-Database.Execute<object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153FB70 Offset: 0x153EF70 VA: 0x18153FB70
	|-Database.Execute<int, int, int, int>
	|
	|-RVA: 0x1540000 Offset: 0x153F400 VA: 0x181540000
	|-Database.Execute<object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void Execute<T1, T2, T3, T4, T5>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153FDB0 Offset: 0x153F1B0 VA: 0x18153FDB0
	|-Database.Execute<int, byte[], int, int, int>
	|-Database.Execute<int, object, int, int, int>
	|
	|-RVA: 0x153FF10 Offset: 0x153F310 VA: 0x18153FF10
	|-Database.Execute<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	protected static void Bind<T>(IntPtr stmHandle, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153EF60 Offset: 0x153E360 VA: 0x18153EF60
	|-Database.Bind<int>
	|
	|-RVA: 0x153F560 Offset: 0x153E960 VA: 0x18153F560
	|-Database.Bind<object>
	*/

	// RVA: -1 Offset: -1
	protected static T GetColumnValue<T>(IntPtr stmHandle, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E55A0 Offset: 0x5E49A0 VA: 0x1805E55A0
	|-Database.GetColumnValue<int>
	|
	|-RVA: 0x5E5D10 Offset: 0x5E5110 VA: 0x1805E5D10
	|-Database.GetColumnValue<long>
	|
	|-RVA: 0x5E6480 Offset: 0x5E5880 VA: 0x1805E6480
	|-Database.GetColumnValue<object>
	*/

	// RVA: 0x2318A50 Offset: 0x2317E50 VA: 0x182318A50
	public int QueryInt(string query) { }

	// RVA: -1 Offset: -1
	public int QueryInt<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11738E0 Offset: 0x1172CE0 VA: 0x1811738E0
	|-Database.QueryInt<object>
	|-Database.QueryInt<string>
	*/

	// RVA: -1 Offset: -1
	public int QueryInt<T1, T2>(string query, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1173810 Offset: 0x1172C10 VA: 0x181173810
	|-Database.QueryInt<object, object>
	|-Database.QueryInt<string, string>
	*/

	// RVA: 0x2318AB0 Offset: 0x2317EB0 VA: 0x182318AB0
	public long QueryLong(string query) { }

	// RVA: -1 Offset: -1
	public string QueryString<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7E330 Offset: 0xE7D730 VA: 0x180E7E330
	|-Database.QueryString<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1>(string query, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1564AD0 Offset: 0x1563ED0 VA: 0x181564AD0
	|-Database.QueryBlob<object>
	*/

	// RVA: -1 Offset: -1
	public byte[] QueryBlob<T1, T2, T3, T4>(string query, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA270 Offset: 0xBE9670 VA: 0x180BEA270
	|-Database.QueryBlob<int, int, int, int>
	|
	|-RVA: 0xBEA370 Offset: 0xBE9770 VA: 0x180BEA370
	|-Database.QueryBlob<object, object, object, object>
	*/

	// RVA: 0x2317C40 Offset: 0x2317040 VA: 0x182317C40
	public void BeginTransaction() { }

	// RVA: 0x2317DD0 Offset: 0x23171D0 VA: 0x182317DD0
	public void Commit() { }

	// RVA: 0x2318CA0 Offset: 0x23180A0 VA: 0x182318CA0
	public void Rollback() { }

	// RVA: 0x2317E20 Offset: 0x2317220 VA: 0x182317E20
	protected void ExecuteQuery(IntPtr stmHandle, bool finalize = True) { }

	// RVA: -1 Offset: -1
	protected T ExecuteAndReadQueryResult<T>(IntPtr stmHandle, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E5440 Offset: 0x5E4840 VA: 0x1805E5440
	|-Database.ExecuteAndReadQueryResult<byte[]>
	|-Database.ExecuteAndReadQueryResult<object>
	|-Database.ExecuteAndReadQueryResult<string>
	|
	|-RVA: 0x5E5190 Offset: 0x5E4590 VA: 0x1805E5190
	|-Database.ExecuteAndReadQueryResult<int>
	|
	|-RVA: 0x5E52E0 Offset: 0x5E46E0 VA: 0x1805E52E0
	|-Database.ExecuteAndReadQueryResult<long>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x9A570 Offset: 0x99970 VA: 0x18009A570
	// RVA: -1 Offset: -1
	protected IEnumerable<T> ExecuteAndReadQueryResults<T>(IntPtr stmHandle, Func<IntPtr, T> rowReader, bool finalize = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFA840 Offset: 0xCF9C40 VA: 0x180CFA840
	|-Database.ExecuteAndReadQueryResults<object>
	*/

	// RVA: 0x2318820 Offset: 0x2317C20 VA: 0x182318820
	protected IntPtr Prepare(string query) { }

	// RVA: 0x2318090 Offset: 0x2317490 VA: 0x182318090
	private void FinalizeOrReset(IntPtr stmHandle, bool finalize = True) { }

	// RVA: 0x23183A0 Offset: 0x23177A0 VA: 0x1823183A0
	protected void Finalize(IntPtr stmHandle) { }

	// RVA: 0x2318B10 Offset: 0x2317F10 VA: 0x182318B10
	protected void Reset(IntPtr stmHandle) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal static Exception <GetColumnValue>g__TypeError|19_0<T>(ref Database.<>c__DisplayClass19_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1B148D0 Offset: 0x1B13CD0 VA: 0x181B148D0
	|-Database.<GetColumnValue>g__TypeError|19_0<int>
	|
	|-RVA: 0x1B149D0 Offset: 0x1B13DD0 VA: 0x181B149D0
	|-Database.<GetColumnValue>g__TypeError|19_0<long>
	|
	|-RVA: 0x1B14AD0 Offset: 0x1B13ED0 VA: 0x181B14AD0
	|-Database.<GetColumnValue>g__TypeError|19_0<object>
	*/

}

private struct Database.<>c__DisplayClass19_0<T> // TypeDefIndex: 7357
{	// Fields
	public int type; // 0x0

}

private sealed class Database.<ExecuteAndReadQueryResults>d__32<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 7358
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Func<IntPtr, T> rowReader; // 0x0
	public Func<IntPtr, T> <>3__rowReader; // 0x0
	private IntPtr stmHandle; // 0x0
	public IntPtr <>3__stmHandle; // 0x0
	public Database <>4__this; // 0x0
	private bool finalize; // 0x0
	public bool <>3__finalize; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1446280 Offset: 0x1445680 VA: 0x181446280
	|-Database.<ExecuteAndReadQueryResults>d__32<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1445F40 Offset: 0x1445340 VA: 0x181445F40
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3610 Offset: 0x15E2A10 VA: 0x1815E3610
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3890 Offset: 0x15E2C90 VA: 0x1815E3890
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3840 Offset: 0x15E2C40 VA: 0x1815E3840
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3740 Offset: 0x15E2B40 VA: 0x1815E3740
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E3810 Offset: 0x15E2C10 VA: 0x1815E3810
	|-Database.<ExecuteAndReadQueryResults>d__32<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

internal static class DataTypesUtilities // TypeDefIndex: 7622
{	// Methods

	// RVA: 0x1392120 Offset: 0x1391520 VA: 0x181392120
	public static ushort Combine(SevenBitNumber head, SevenBitNumber tail) { }

	// RVA: 0x1392110 Offset: 0x1391510 VA: 0x181392110
	public static ushort CombineAsSevenBitNumbers(byte head, byte tail) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1392390 Offset: 0x1391790 VA: 0x181392390
	public static FourBitNumber GetTail(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x13922D0 Offset: 0x13916D0 VA: 0x1813922D0
	public static SevenBitNumber GetTail(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1256FF0 Offset: 0x12563F0 VA: 0x181256FF0
	public static byte GetTail(short number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1392180 Offset: 0x1391580 VA: 0x181392180
	public static FourBitNumber GetHead(byte number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1392230 Offset: 0x1391630 VA: 0x181392230
	public static SevenBitNumber GetHead(ushort number) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1392220 Offset: 0x1391620 VA: 0x181392220
	public static byte GetHead(short number) { }

}

internal abstract class DbcsEncoding : MonoEncoding // TypeDefIndex: 7825
{	// Properties
	public override bool IsBrowserDisplay { get; }
	public override bool IsBrowserSave { get; }
	public override bool IsMailNewsDisplay { get; }
	public override bool IsMailNewsSave { get; }

	// Methods

	// RVA: 0x2249690 Offset: 0x2248A90 VA: 0x182249690
	public void .ctor(int codePage) { }

	// RVA: 0x22496A0 Offset: 0x2248AA0 VA: 0x1822496A0
	public void .ctor(int codePage, int windowsCodePage) { }

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract DbcsConvert GetConvert();

	// RVA: 0x22490F0 Offset: 0x22484F0 VA: 0x1822490F0 Slot: 19
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x2249270 Offset: 0x2248670 VA: 0x182249270 Slot: 29
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x22493D0 Offset: 0x22487D0 VA: 0x1822493D0 Slot: 33
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x2249590 Offset: 0x2248990 VA: 0x182249590 Slot: 40
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x2249610 Offset: 0x2248A10 VA: 0x182249610 Slot: 41
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 12
	public override bool get_IsBrowserDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 13
	public override bool get_IsBrowserSave() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	public override bool get_IsMailNewsDisplay() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 15
	public override bool get_IsMailNewsSave() { }

}

internal abstract class DbcsEncoding.DbcsDecoder : Decoder // TypeDefIndex: 7826
{	// Fields
	protected DbcsConvert convert; // 0x20

	// Methods

	// RVA: 0x159B530 Offset: 0x159A930 VA: 0x18159B530
	public void .ctor(DbcsConvert convert) { }

	// RVA: 0x2248FD0 Offset: 0x22483D0 VA: 0x182248FD0
	internal void CheckRange(byte[] bytes, int index, int count) { }

	// RVA: 0x2248E10 Offset: 0x2248210 VA: 0x182248E10
	internal void CheckRange(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

}

internal class DbcsConvert // TypeDefIndex: 7827
{	// Fields
	public byte[] n2u; // 0x10
	public byte[] u2n; // 0x18
	internal static readonly DbcsConvert Gb2312; // 0x0
	internal static readonly DbcsConvert Big5; // 0x8
	internal static readonly DbcsConvert KS; // 0x10

	// Methods

	// RVA: 0x2248C80 Offset: 0x2248080 VA: 0x182248C80
	internal void .ctor(string fileName) { }

	// RVA: 0x2248BA0 Offset: 0x2247FA0 VA: 0x182248BA0
	private static void .cctor() { }

}

public class Data : ConsoleSystem // TypeDefIndex: 11894
{	// Methods

	[ServerVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	[ClientVar] // RVA: 0x8AA10 Offset: 0x89E10 VA: 0x18008AA10
	// RVA: 0x6D37B0 Offset: 0x6D2BB0 VA: 0x1806D37B0
	public static void export(ConsoleSystem.Arg args) { }

	// RVA: 0x6D3750 Offset: 0x6D2B50 VA: 0x1806D3750
	public void .ctor() { }

}


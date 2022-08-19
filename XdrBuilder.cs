internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 2291
{	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0xEF5B50 Offset: 0xEF4F50 VA: 0x180EF5B50
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0xEEF090 Offset: 0xEEE490 VA: 0x180EEF090 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0xEEEB90 Offset: 0xEEDF90 VA: 0x180EEEB90 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0xEF5DD0 Offset: 0xEF51D0 VA: 0x180EF5DD0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0xEEDF00 Offset: 0xEED300 VA: 0x180EEDF00
	private bool LoadSchema(string uri) { }

	// RVA: 0xEEDD30 Offset: 0xEED130 VA: 0x180EEDD30
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0xEEF2F0 Offset: 0xEEE6F0 VA: 0x180EEF2F0 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0xEEF010 Offset: 0xEEE410 VA: 0x180EEF010 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0xEEF820 Offset: 0xEEEC20 VA: 0x180EEF820 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0xEED1D0 Offset: 0xEEC5D0 VA: 0x180EED1D0 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0xEEF3C0 Offset: 0xEEE7C0 VA: 0x180EEF3C0
	private void Push() { }

	// RVA: 0xEEEB10 Offset: 0xEEDF10 VA: 0x180EEEB10
	private void Pop() { }

	// RVA: 0xEEF360 Offset: 0xEEE760 VA: 0x180EEF360
	private void PushGroupInfo() { }

	// RVA: 0xEEEA90 Offset: 0xEEDE90 VA: 0x180EEEA90
	private void PopGroupInfo() { }

	// RVA: 0xEF3880 Offset: 0xEF2C80 VA: 0x180EF3880
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0xEF1C90 Offset: 0xEF1090 VA: 0x180EF1C90
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0000 Offset: 0xEEF400 VA: 0x180EF0000
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0xEF2D70 Offset: 0xEF2170 VA: 0x180EF2D70
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0xEF34C0 Offset: 0xEF28C0 VA: 0x180EF34C0
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF13B0 Offset: 0xEF07B0 VA: 0x180EF13B0
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0C10 Offset: 0xEF0010 VA: 0x180EF0C10
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF1210 Offset: 0xEF0610 VA: 0x180EF1210
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF15A0 Offset: 0xEF09A0 VA: 0x180EF15A0
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0FF0 Offset: 0xEF03F0 VA: 0x180EF0FF0
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF1130 Offset: 0xEF0530 VA: 0x180EF1130
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0CD0 Offset: 0xEF00D0 VA: 0x180EF0CD0
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0E60 Offset: 0xEF0260 VA: 0x180EF0E60
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEEFD00 Offset: 0xEEF100 VA: 0x180EEFD00
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0xEF2360 Offset: 0xEF1760 VA: 0x180EF2360
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0xEF3230 Offset: 0xEF2630 VA: 0x180EF3230
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF0720 Offset: 0xEEFB20 VA: 0x180EF0720
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF09E0 Offset: 0xEEFDE0 VA: 0x180EF09E0
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF00E0 Offset: 0xEEF4E0 VA: 0x180EF00E0
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0430 Offset: 0xEEF830 VA: 0x180EF0430
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0640 Offset: 0xEEFA40 VA: 0x180EF0640
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0110 Offset: 0xEEF510 VA: 0x180EF0110
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF02A0 Offset: 0xEEF6A0 VA: 0x180EF02A0
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEEF850 Offset: 0xEEEC50 VA: 0x180EEF850
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF1F30 Offset: 0xEF1330 VA: 0x180EF1F30
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0xEF3640 Offset: 0xEF2A40 VA: 0x180EF3640
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0xEF1790 Offset: 0xEF0B90 VA: 0x180EF1790
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF1700 Offset: 0xEF0B00 VA: 0x180EF1700
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF1670 Offset: 0xEF0A70 VA: 0x180EF1670
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF2A50 Offset: 0xEF1E50 VA: 0x180EF2A50
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0xEF3340 Offset: 0xEF2740 VA: 0x180EF3340
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0xEF0B30 Offset: 0xEEFF30 VA: 0x180EF0B30
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0AA0 Offset: 0xEEFEA0 VA: 0x180EF0AA0
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF0A70 Offset: 0xEEFE70 VA: 0x180EF0A70
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEEF8F0 Offset: 0xEEECF0 VA: 0x180EEF8F0
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0xEF2210 Offset: 0xEF1610 VA: 0x180EF2210
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0xEF3720 Offset: 0xEF2B20 VA: 0x180EF3720
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0xEF1B70 Offset: 0xEF0F70 VA: 0x180EF1B70
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF1AE0 Offset: 0xEF0EE0 VA: 0x180EF1AE0
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF1A50 Offset: 0xEF0E50 VA: 0x180EF1A50
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0xEF2B70 Offset: 0xEF1F70 VA: 0x180EF2B70
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0xEF33D0 Offset: 0xEF27D0 VA: 0x180EF33D0
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF2240 Offset: 0xEF1640 VA: 0x180EF2240
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0xEF31A0 Offset: 0xEF25A0 VA: 0x180EF31A0
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0xEF1E30 Offset: 0xEF1230 VA: 0x180EF1E30
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0xEED5E0 Offset: 0xEEC9E0 VA: 0x180EED5E0
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0xEEDC10 Offset: 0xEED010 VA: 0x180EEDC10
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0xEEDA50 Offset: 0xEECE50 VA: 0x180EEDA50
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0xEED830 Offset: 0xEECC30 VA: 0x180EED830
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0xEECE00 Offset: 0xEEC200 VA: 0x180EECE00
	private void AddOrder() { }

	// RVA: 0xEEDDD0 Offset: 0xEED1D0 VA: 0x180EEDDD0
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0xEEE970 Offset: 0xEEDD70 VA: 0x180EEE970
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEEE830 Offset: 0xEEDC30 VA: 0x180EEE830
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0xEEDA10 Offset: 0xEECE10 VA: 0x180EEDA10
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0xEEE570 Offset: 0xEED970 VA: 0x180EEE570
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEEE6B0 Offset: 0xEEDAB0 VA: 0x180EEE6B0
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0xEED160 Offset: 0xEEC560 VA: 0x180EED160
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0xEEE7F0 Offset: 0xEEDBF0 VA: 0x180EEE7F0
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0xEF1D20 Offset: 0xEF1120 VA: 0x180EF1D20
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0xEEF7C0 Offset: 0xEEEBC0 VA: 0x180EEF7C0
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0xEED270 Offset: 0xEEC670 VA: 0x180EED270
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0xEED4B0 Offset: 0xEEC8B0 VA: 0x180EED4B0
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0xEECEB0 Offset: 0xEEC2B0 VA: 0x180EECEB0
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0xEED010 Offset: 0xEEC410 VA: 0x180EED010
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0xEEDA40 Offset: 0xEECE40 VA: 0x180EEDA40
	private bool IsGlobal(int flags) { }

	// RVA: 0xEEF6A0 Offset: 0xEEEAA0 VA: 0x180EEF6A0
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0xEEF530 Offset: 0xEEE930 VA: 0x180EEF530
	private void SendValidationEvent(string code) { }

	// RVA: 0xEEF420 Offset: 0xEEE820 VA: 0x180EEF420
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0xEEF590 Offset: 0xEEE990 VA: 0x180EEF590
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0xEF3900 Offset: 0xEF2D00 VA: 0x180EF3900
	private static void .cctor() { }

}

private sealed class XdrBuilder.DeclBaseInfo // TypeDefIndex: 2292
{	// Fields
	internal XmlQualifiedName _Name; // 0x10
	internal string _Prefix; // 0x18
	internal XmlQualifiedName _TypeName; // 0x20
	internal string _TypePrefix; // 0x28
	internal object _Default; // 0x30
	internal object _Revises; // 0x38
	internal uint _MaxOccurs; // 0x40
	internal uint _MinOccurs; // 0x44
	internal bool _Checking; // 0x48
	internal SchemaElementDecl _ElementDecl; // 0x50
	internal SchemaAttDef _Attdef; // 0x58
	internal XdrBuilder.DeclBaseInfo _Next; // 0x60

	// Methods

	// RVA: 0x1423D50 Offset: 0x1423150 VA: 0x181423D50
	internal void .ctor() { }

	// RVA: 0x1423C40 Offset: 0x1423040 VA: 0x181423C40
	internal void Reset() { }

}

private sealed class XdrBuilder.GroupContent // TypeDefIndex: 2293
{	// Fields
	internal uint _MinVal; // 0x10
	internal uint _MaxVal; // 0x14
	internal bool _HasMaxAttr; // 0x18
	internal bool _HasMinAttr; // 0x19
	internal int _Order; // 0x1C

	// Methods

	// RVA: 0x1423E60 Offset: 0x1423260 VA: 0x181423E60
	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	// RVA: 0x1423E90 Offset: 0x1423290 VA: 0x181423E90
	internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class XdrBuilder.ElementContent // TypeDefIndex: 2294
{	// Fields
	internal SchemaElementDecl _ElementDecl; // 0x10
	internal int _ContentAttr; // 0x18
	internal int _OrderAttr; // 0x1C
	internal bool _MasterGroupRequired; // 0x20
	internal bool _ExistTerminal; // 0x21
	internal bool _AllowDataType; // 0x22
	internal bool _HasDataType; // 0x23
	internal bool _HasType; // 0x24
	internal bool _EnumerationRequired; // 0x25
	internal uint _MinVal; // 0x28
	internal uint _MaxVal; // 0x2C
	internal uint _MaxLength; // 0x30
	internal uint _MinLength; // 0x34
	internal Hashtable _AttDefList; // 0x38

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class XdrBuilder.AttributeContent // TypeDefIndex: 2295
{	// Fields
	internal SchemaAttDef _AttDef; // 0x10
	internal XmlQualifiedName _Name; // 0x18
	internal string _Prefix; // 0x20
	internal bool _Required; // 0x28
	internal uint _MinVal; // 0x2C
	internal uint _MaxVal; // 0x30
	internal uint _MaxLength; // 0x34
	internal uint _MinLength; // 0x38
	internal bool _EnumerationRequired; // 0x3C
	internal bool _HasDataType; // 0x3D
	internal bool _Global; // 0x3E
	internal object _Default; // 0x40

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class XdrBuilder.XdrBuildFunction : MulticastDelegate // TypeDefIndex: 2296
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x14243E0 Offset: 0x14237E0 VA: 0x1814243E0 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x130A3E0 Offset: 0x13097E0 VA: 0x18130A3E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, string prefix, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 2297
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 2298
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1424130 Offset: 0x1423530 VA: 0x181424130 Slot: 12
	public virtual void Invoke(XdrBuilder builder) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrEndChildFunction : MulticastDelegate // TypeDefIndex: 2299
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1424130 Offset: 0x1423530 VA: 0x181424130 Slot: 12
	public virtual void Invoke(XdrBuilder builder) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrAttributeEntry // TypeDefIndex: 2300
{	// Fields
	internal SchemaNames.Token _Attribute; // 0x10
	internal int _SchemaFlags; // 0x14
	internal XmlSchemaDatatype _Datatype; // 0x18
	internal XdrBuilder.XdrBuildFunction _BuildFunc; // 0x20

	// Methods

	// RVA: 0x1424050 Offset: 0x1423450 VA: 0x181424050
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	// RVA: 0x14240C0 Offset: 0x14234C0 VA: 0x1814240C0
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build) { }

}

private sealed class XdrBuilder.XdrEntry // TypeDefIndex: 2301
{	// Fields
	internal SchemaNames.Token _Name; // 0x10
	internal int[] _NextStates; // 0x18
	internal XdrBuilder.XdrAttributeEntry[] _Attributes; // 0x20
	internal XdrBuilder.XdrInitFunction _InitFunc; // 0x28
	internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc; // 0x30
	internal XdrBuilder.XdrEndChildFunction _EndChildFunc; // 0x38
	internal bool _AllowText; // 0x40

	// Methods

	// RVA: 0x14248E0 Offset: 0x1423CE0 VA: 0x1814248E0
	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }

}


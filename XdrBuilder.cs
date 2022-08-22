internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 2291
{	private static readonly int[] S_XDR_Root_Element; // 0x0
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

	internal XmlResolver XmlResolver { set; }


	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	internal override bool ProcessElement(string prefix, string name, string ns) { }

	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	internal void set_XmlResolver(XmlResolver value) { }

	private bool LoadSchema(string uri) { }

	internal static bool IsXdrSchema(string uri) { }

	internal override bool IsContentParsed() { }

	internal override void ProcessMarkup(XmlNode[] markup) { }

	internal override void ProcessCData(string value) { }

	internal override void StartChildren() { }

	internal override void EndChildren() { }

	private void Push() { }

	private void Pop() { }

	private void PushGroupInfo() { }

	private void PopGroupInfo() { }

	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BeginRoot(XdrBuilder builder) { }

	private static void XDR_EndRoot(XdrBuilder builder) { }

	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BeginElementType(XdrBuilder builder) { }

	private static void XDR_EndElementType(XdrBuilder builder) { }

	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_EndElement(XdrBuilder builder) { }

	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	private static void XDR_EndAttribute(XdrBuilder builder) { }

	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	private static void XDR_EndGroup(XdrBuilder builder) { }

	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	private bool GetNextState(XmlQualifiedName qname) { }

	private bool IsSkipableElement(XmlQualifiedName qname) { }

	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	private int GetOrder(XmlQualifiedName qname) { }

	private void AddOrder() { }

	private static bool IsYes(object obj, XdrBuilder builder) { }

	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	private static bool ParseInteger(string str, ref uint n) { }

	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	private int GetContent(XmlQualifiedName qname) { }

	private bool GetModel(XmlQualifiedName qname) { }

	private XmlSchemaDatatype CheckDatatype(string str) { }

	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	private bool IsGlobal(int flags) { }

	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	private void SendValidationEvent(string code) { }

	private void SendValidationEvent(string code, string msg) { }

	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	private static void .cctor() { }

}

private sealed class XdrBuilder.DeclBaseInfo // TypeDefIndex: 2292
{	internal XmlQualifiedName _Name; // 0x10
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


	internal void .ctor() { }

	internal void Reset() { }

}

private sealed class XdrBuilder.GroupContent // TypeDefIndex: 2293
{	internal uint _MinVal; // 0x10
	internal uint _MaxVal; // 0x14
	internal bool _HasMaxAttr; // 0x18
	internal bool _HasMinAttr; // 0x19
	internal int _Order; // 0x1C


	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other) { }

	public void .ctor() { }

}

private sealed class XdrBuilder.ElementContent // TypeDefIndex: 2294
{	internal SchemaElementDecl _ElementDecl; // 0x10
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


	public void .ctor() { }

}

private sealed class XdrBuilder.AttributeContent // TypeDefIndex: 2295
{	internal SchemaAttDef _AttDef; // 0x10
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


	public void .ctor() { }

}

private sealed class XdrBuilder.XdrBuildFunction : MulticastDelegate // TypeDefIndex: 2296
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }

	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, string prefix, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 2297
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(XdrBuilder builder, object obj) { }

	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, object obj, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 2298
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(XdrBuilder builder) { }

	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrEndChildFunction : MulticastDelegate // TypeDefIndex: 2299
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(XdrBuilder builder) { }

	public virtual IAsyncResult BeginInvoke(XdrBuilder builder, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class XdrBuilder.XdrAttributeEntry // TypeDefIndex: 2300
{	internal SchemaNames.Token _Attribute; // 0x10
	internal int _SchemaFlags; // 0x14
	internal XmlSchemaDatatype _Datatype; // 0x18
	internal XdrBuilder.XdrBuildFunction _BuildFunc; // 0x20


	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build) { }

}

private sealed class XdrBuilder.XdrEntry // TypeDefIndex: 2301
{	internal SchemaNames.Token _Name; // 0x10
	internal int[] _NextStates; // 0x18
	internal XdrBuilder.XdrAttributeEntry[] _Attributes; // 0x20
	internal XdrBuilder.XdrInitFunction _InitFunc; // 0x28
	internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc; // 0x30
	internal XdrBuilder.XdrEndChildFunction _EndChildFunc; // 0x38
	internal bool _AllowText; // 0x40


	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }

}


internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 2291
{
	private static readonly int[] S_XDR_Root_Element; 
	private static readonly int[] S_XDR_Root_SubElements; 
	private static readonly int[] S_XDR_ElementType_SubElements; 
	private static readonly int[] S_XDR_AttributeType_SubElements; 
	private static readonly int[] S_XDR_Group_SubElements; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; 
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; 
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; 
	private SchemaInfo _SchemaInfo; 
	private string _TargetNamespace; 
	private XmlReader _reader; 
	private PositionInfo positionInfo; 
	private ParticleContentValidator _contentValidator; 
	private XdrBuilder.XdrEntry _CurState; 
	private XdrBuilder.XdrEntry _NextState; 
	private HWStack _StateHistory; 
	private HWStack _GroupStack; 
	private string _XdrName; 
	private string _XdrPrefix; 
	private XdrBuilder.ElementContent _ElementDef; 
	private XdrBuilder.GroupContent _GroupDef; 
	private XdrBuilder.AttributeContent _AttributeDef; 
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; 
	private XdrBuilder.DeclBaseInfo _BaseDecl; 
	private XmlNameTable _NameTable; 
	private SchemaNames _SchemaNames; 
	private XmlNamespaceManager _CurNsMgr; 
	private string _Text; 
	private ValidationEventHandler validationEventHandler; 
	private Hashtable _UndeclaredElements; 
	private XmlResolver xmlResolver; 

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
{
	internal XmlQualifiedName _Name; 
	internal string _Prefix; 
	internal XmlQualifiedName _TypeName; 
	internal string _TypePrefix; 
	internal object _Default; 
	internal object _Revises; 
	internal uint _MaxOccurs; 
	internal uint _MinOccurs; 
	internal bool _Checking; 
	internal SchemaElementDecl _ElementDecl; 
	internal SchemaAttDef _Attdef; 
	internal XdrBuilder.DeclBaseInfo _Next; 


internal void .ctor() { }

internal void Reset() { }

}

private sealed class XdrBuilder.GroupContent // TypeDefIndex: 2293
{
	internal uint _MinVal; 
	internal uint _MaxVal; 
	internal bool _HasMaxAttr; 
	internal bool _HasMinAttr; 
	internal int _Order; 


internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other) { }

public void .ctor() { }

}

private sealed class XdrBuilder.ElementContent // TypeDefIndex: 2294
{
	internal SchemaElementDecl _ElementDecl; 
	internal int _ContentAttr; 
	internal int _OrderAttr; 
	internal bool _MasterGroupRequired; 
	internal bool _ExistTerminal; 
	internal bool _AllowDataType; 
	internal bool _HasDataType; 
	internal bool _HasType; 
	internal bool _EnumerationRequired; 
	internal uint _MinVal; 
	internal uint _MaxVal; 
	internal uint _MaxLength; 
	internal uint _MinLength; 
	internal Hashtable _AttDefList; 


public void .ctor() { }

}

private sealed class XdrBuilder.AttributeContent // TypeDefIndex: 2295
{
	internal SchemaAttDef _AttDef; 
	internal XmlQualifiedName _Name; 
	internal string _Prefix; 
	internal bool _Required; 
	internal uint _MinVal; 
	internal uint _MaxVal; 
	internal uint _MaxLength; 
	internal uint _MinLength; 
	internal bool _EnumerationRequired; 
	internal bool _HasDataType; 
	internal bool _Global; 
	internal object _Default; 


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
{
	internal SchemaNames.Token _Attribute; 
	internal int _SchemaFlags; 
	internal XmlSchemaDatatype _Datatype; 
	internal XdrBuilder.XdrBuildFunction _BuildFunc; 


internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build) { }

}

private sealed class XdrBuilder.XdrEntry // TypeDefIndex: 2301
{
	internal SchemaNames.Token _Name; 
	internal int[] _NextStates; 
	internal XdrBuilder.XdrAttributeEntry[] _Attributes; 
	internal XdrBuilder.XdrInitFunction _InitFunc; 
	internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc; 
	internal XdrBuilder.XdrEndChildFunction _EndChildFunc; 
	internal bool _AllowText; 


internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }

}


internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 2269
{	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }


	public void .ctor(XmlQualifiedName name, string prefix) { }

	public void .ctor(XmlQualifiedName name) { }

	private void .ctor() { }

	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	internal int get_LinePosition() { }

	internal void set_LinePosition(int value) { }

	internal int get_LineNumber() { }

	internal void set_LineNumber(int value) { }

	internal int get_ValueLinePosition() { }

	internal void set_ValueLinePosition(int value) { }

	internal int get_ValueLineNumber() { }

	internal void set_ValueLineNumber(int value) { }

	internal string get_DefaultValueExpanded() { }

	internal void set_DefaultValueExpanded(string value) { }

	internal XmlTokenizedType get_TokenizedType() { }

	internal void set_TokenizedType(XmlTokenizedType value) { }

	internal SchemaAttDef.Reserve get_Reserved() { }

	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	internal bool get_DefaultValueChecked() { }

	internal XmlSchemaAttribute get_SchemaAttribute() { }

	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	internal SchemaAttDef Clone() { }

	private static void .cctor() { }

}

internal enum SchemaAttDef.Reserve // TypeDefIndex: 2270
{	public int value__; // 0x0
	public const SchemaAttDef.Reserve None = 0;
	public const SchemaAttDef.Reserve XmlSpace = 1;
	public const SchemaAttDef.Reserve XmlLang = 2;

}


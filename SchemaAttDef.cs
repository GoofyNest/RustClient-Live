internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 2269
{	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
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

	// Methods

	// RVA: 0xB243B0 Offset: 0xB237B0 VA: 0x180B243B0
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xB243D0 Offset: 0xB237D0 VA: 0x180B243D0
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0xB243C0 Offset: 0xB237C0 VA: 0x180B243C0
	private void .ctor() { }

	// RVA: 0xB242E0 Offset: 0xB236E0 VA: 0x180B242E0 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0xB242C0 Offset: 0xB236C0 VA: 0x180B242C0 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x7E3980 Offset: 0x7E2D80 VA: 0x1807E3980 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x7E3960 Offset: 0x7E2D60 VA: 0x1807E3960 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0xB24280 Offset: 0xB23680 VA: 0x180B24280 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xB242B0 Offset: 0xB236B0 VA: 0x180B242B0 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0xB242F0 Offset: 0xB236F0 VA: 0x180B242F0 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x7E3970 Offset: 0x7E2D70 VA: 0x1807E3970 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0xB24340 Offset: 0xB23740 VA: 0x180B24340 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x7E3960 Offset: 0x7E2D60 VA: 0x1807E3960
	internal int get_LinePosition() { }

	// RVA: 0x7E3990 Offset: 0x7E2D90 VA: 0x1807E3990
	internal void set_LinePosition(int value) { }

	// RVA: 0x7E3980 Offset: 0x7E2D80 VA: 0x1807E3980
	internal int get_LineNumber() { }

	// RVA: 0x7E39B0 Offset: 0x7E2DB0 VA: 0x1807E39B0
	internal void set_LineNumber(int value) { }

	// RVA: 0xB24340 Offset: 0xB23740 VA: 0x180B24340
	internal int get_ValueLinePosition() { }

	// RVA: 0xB244A0 Offset: 0xB238A0 VA: 0x180B244A0
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x7E3970 Offset: 0x7E2D70 VA: 0x1807E3970
	internal int get_ValueLineNumber() { }

	// RVA: 0x7E39A0 Offset: 0x7E2DA0 VA: 0x1807E39A0
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0xB243E0 Offset: 0xB237E0 VA: 0x180B243E0
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0xB24430 Offset: 0xB23830 VA: 0x180B24430
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0xB24470 Offset: 0xB23870 VA: 0x180B24470
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0xAF14F0 Offset: 0xAF08F0 VA: 0x180AF14F0
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0xB24460 Offset: 0xB23860 VA: 0x180B24460
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x9619E0 Offset: 0x960DE0 VA: 0x1809619E0
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0xB23FE0 Offset: 0xB233E0 VA: 0x180B23FE0
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0xB24220 Offset: 0xB23620 VA: 0x180B24220
	internal SchemaAttDef Clone() { }

	// RVA: 0xB24350 Offset: 0xB23750 VA: 0x180B24350
	private static void .cctor() { }

}

internal enum SchemaAttDef.Reserve // TypeDefIndex: 2270
{	// Fields
	public int value__; // 0x0
	public const SchemaAttDef.Reserve None = 0;
	public const SchemaAttDef.Reserve XmlSpace = 1;
	public const SchemaAttDef.Reserve XmlLang = 2;

}


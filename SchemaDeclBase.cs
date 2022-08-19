internal abstract class SchemaDeclBase // TypeDefIndex: 2275
{	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0xEE10E0 Offset: 0xEE04E0 VA: 0x180EE10E0
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0xEE11B0 Offset: 0xEE05B0 VA: 0x180EE11B0
	protected void .ctor() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0xEE1280 Offset: 0xEE0680 VA: 0x180EE1280
	internal string get_Prefix() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_Prefix(string value) { }

	// RVA: 0xB0BB80 Offset: 0xB0AF80 VA: 0x180B0BB80
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x7D99E0 Offset: 0x7D8DE0 VA: 0x1807D99E0
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal long get_MaxLength() { }

	// RVA: 0xEE12D0 Offset: 0xEE06D0 VA: 0x180EE12D0
	internal void set_MaxLength(long value) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	internal long get_MinLength() { }

	// RVA: 0xEE12E0 Offset: 0xEE06E0 VA: 0x180EE12E0
	internal void set_MinLength(long value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0xEE0F30 Offset: 0xEE0330 VA: 0x180EE0F30
	internal void AddValue(string value) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	internal List<string> get_Values() { }

	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	internal void set_Values(List<string> value) { }

	// RVA: 0xEE1230 Offset: 0xEE0630 VA: 0x180EE1230
	internal string get_DefaultValueRaw() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal object get_DefaultValueTyped() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0xEE0FD0 Offset: 0xEE03D0 VA: 0x180EE0FD0
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0xEE1090 Offset: 0xEE0490 VA: 0x180EE1090
	internal bool CheckValue(object pVal) { }

}

internal enum SchemaDeclBase.Use // TypeDefIndex: 2276
{	// Fields
	public int value__; // 0x0
	public const SchemaDeclBase.Use Default = 0;
	public const SchemaDeclBase.Use Required = 1;
	public const SchemaDeclBase.Use Implied = 2;
	public const SchemaDeclBase.Use Fixed = 3;
	public const SchemaDeclBase.Use RequiredFixed = 4;

}


internal abstract class SchemaDeclBase // TypeDefIndex: 2275
{	protected XmlQualifiedName name; // 0x10
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


	protected void .ctor(XmlQualifiedName name, string prefix) { }

	protected void .ctor() { }

	internal XmlQualifiedName get_Name() { }

	internal void set_Name(XmlQualifiedName value) { }

	internal string get_Prefix() { }

	internal void set_Prefix(string value) { }

	internal bool get_IsDeclaredInExternal() { }

	internal void set_IsDeclaredInExternal(bool value) { }

	internal SchemaDeclBase.Use get_Presence() { }

	internal void set_Presence(SchemaDeclBase.Use value) { }

	internal long get_MaxLength() { }

	internal void set_MaxLength(long value) { }

	internal long get_MinLength() { }

	internal void set_MinLength(long value) { }

	internal XmlSchemaType get_SchemaType() { }

	internal void set_SchemaType(XmlSchemaType value) { }

	internal XmlSchemaDatatype get_Datatype() { }

	internal void set_Datatype(XmlSchemaDatatype value) { }

	internal void AddValue(string value) { }

	internal List<string> get_Values() { }

	internal void set_Values(List<string> value) { }

	internal string get_DefaultValueRaw() { }

	internal void set_DefaultValueRaw(string value) { }

	internal object get_DefaultValueTyped() { }

	internal void set_DefaultValueTyped(object value) { }

	internal bool CheckEnumeration(object pVal) { }

	internal bool CheckValue(object pVal) { }

}

internal enum SchemaDeclBase.Use // TypeDefIndex: 2276
{	public int value__; // 0x0
	public const SchemaDeclBase.Use Default = 0;
	public const SchemaDeclBase.Use Required = 1;
	public const SchemaDeclBase.Use Implied = 2;
	public const SchemaDeclBase.Use Fixed = 3;
	public const SchemaDeclBase.Use RequiredFixed = 4;

}


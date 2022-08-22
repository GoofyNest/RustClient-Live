internal sealed class SimpleType : ISerializable // TypeDefIndex: 4307
{	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }


	internal void .ctor(string baseType) { }

	internal void .ctor(XmlSchemaSimpleType node) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	internal bool IsPlainString() { }

	internal string get_BaseType() { }

	internal XmlQualifiedName get_XmlBaseType() { }

	internal string get_Name() { }

	internal string get_Namespace() { }

	internal int get_Length() { }

	internal int get_MaxLength() { }

	internal void set_MaxLength(int value) { }

	internal SimpleType get_BaseSimpleType() { }

	public string get_SimpleTypeQualifiedName() { }

	internal string QualifiedName(string name) { }

	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	internal static SimpleType CreateEnumeratedType(string values) { }

	internal static SimpleType CreateByteArrayType(string encoding) { }

	internal static SimpleType CreateLimitedStringType(int length) { }

	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	internal bool CanHaveMaxLength() { }

	internal void ConvertToAnnonymousSimpleType() { }

}


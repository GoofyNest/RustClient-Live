internal sealed class SimpleType : ISerializable // TypeDefIndex: 4307
{
	private string _baseType; 
	private SimpleType _baseSimpleType; 
	private XmlQualifiedName _xmlBaseType; 
	private string _name; 
	private int _length; 
	private int _minLength; 
	private int _maxLength; 
	private string _pattern; 
	private string _ns; 
	private string _maxExclusive; 
	private string _maxInclusive; 
	private string _minExclusive; 
	private string _minInclusive; 
	internal string _enumeration; 

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


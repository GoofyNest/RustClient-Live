internal sealed class SimpleType : ISerializable // TypeDefIndex: 4307
{	// Fields
	private string _baseType; // 0x10
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

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0xEAE9F0 Offset: 0xEADDF0 VA: 0x180EAE9F0
	internal void .ctor(string baseType) { }

	// RVA: 0xEAEB40 Offset: 0xEADF40 VA: 0x180EAEB40
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xEAE510 Offset: 0xEAD910 VA: 0x180EAE510 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEADC50 Offset: 0xEAD050 VA: 0x180EADC50
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xEADB40 Offset: 0xEACF40 VA: 0x180EADB40
	internal bool IsPlainString() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal string get_BaseType() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal string get_Name() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	internal string get_Namespace() { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	internal int get_Length() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	internal int get_MaxLength() { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	internal void set_MaxLength(int value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xEAED30 Offset: 0xEAE130 VA: 0x180EAED30
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xEAE4A0 Offset: 0xEAD8A0 VA: 0x180EAE4A0
	internal string QualifiedName(string name) { }

	// RVA: 0xEAE560 Offset: 0xEAD960 VA: 0x180EAE560
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xEAD8A0 Offset: 0xEACCA0 VA: 0x180EAD8A0
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xEAD850 Offset: 0xEACC50 VA: 0x180EAD850
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xEAD920 Offset: 0xEACD20 VA: 0x180EAD920
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xEAD990 Offset: 0xEACD90 VA: 0x180EAD990
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xEADA50 Offset: 0xEACE50 VA: 0x180EADA50
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xEAD710 Offset: 0xEACB10 VA: 0x180EAD710
	internal bool CanHaveMaxLength() { }

	// RVA: 0xEAD790 Offset: 0xEACB90 VA: 0x180EAD790
	internal void ConvertToAnnonymousSimpleType() { }

}


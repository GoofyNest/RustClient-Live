internal class ReflectionHelper // TypeDefIndex: 2057
{	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x10FE710 Offset: 0x10FDB10 VA: 0x1810FE710
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x10FE500 Offset: 0x10FD900 VA: 0x1810FE500
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x10FE5F0 Offset: 0x10FD9F0 VA: 0x1810FE5F0
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x10FE3D0 Offset: 0x10FD7D0 VA: 0x1810FE3D0
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x10FE050 Offset: 0x10FD450 VA: 0x1810FE050
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x10FE810 Offset: 0x10FDC10 VA: 0x1810FE810
	public void .ctor() { }

	// RVA: 0x10FE7C0 Offset: 0x10FDBC0 VA: 0x1810FE7C0
	private static void .cctor() { }

}


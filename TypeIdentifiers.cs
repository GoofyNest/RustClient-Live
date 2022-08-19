internal class TypeIdentifiers // TypeDefIndex: 409
{	// Methods

	// RVA: 0x21380D0 Offset: 0x21374D0 VA: 0x1821380D0
	internal static TypeIdentifier FromDisplay(string displayName) { }

}

private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 410
{	// Fields
	private string displayName; // 0x10
	private string internal_name; // 0x18

	// Properties
	public override string DisplayName { get; }
	public string InternalName { get; }

	// Methods

	// RVA: 0x13C3640 Offset: 0x13C2A40 VA: 0x1813C3640
	internal void .ctor(string displayName) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public override string get_DisplayName() { }

	// RVA: 0x2137D60 Offset: 0x2137160 VA: 0x182137D60 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x2137C80 Offset: 0x2137080 VA: 0x182137C80
	private string GetInternalName() { }

}


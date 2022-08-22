internal class TypeIdentifiers // TypeDefIndex: 409
{
	internal static TypeIdentifier FromDisplay(string displayName) { }

}

private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 410
{	private string displayName; // 0x10
	private string internal_name; // 0x18

	public override string DisplayName { get; }
	public string InternalName { get; }


	internal void .ctor(string displayName) { }

	public override string get_DisplayName() { }

	public string get_InternalName() { }

	private string GetInternalName() { }

}


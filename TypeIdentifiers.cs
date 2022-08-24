internal class TypeIdentifiers // TypeDefIndex: 409
{

	internal static TypeIdentifier FromDisplay(string displayName) { }

}

private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 410
{
	private string displayName; 
	private string internal_name; 

	public override string DisplayName { get; }
	public string InternalName { get; }


	internal void .ctor(string displayName) { }

	public override string get_DisplayName() { }

	public string get_InternalName() { }

	private string GetInternalName() { }

}


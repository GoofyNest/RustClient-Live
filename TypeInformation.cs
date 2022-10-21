internal sealed class TypeInformation // TypeDefIndex: 1111
{
	private string fullTypeName; 
	private string assemblyString; 
	private bool hasTypeForwardedFrom; 

	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }


	internal string get_FullTypeName() { }

	internal string get_AssemblyString() { }

	internal bool get_HasTypeForwardedFrom() { }

	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

}

internal class TypeInformation // TypeDefIndex: 5946
{
	[CompilerGeneratedAttribute] 
	private Type <Type>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private PrimitiveTypeCode <TypeCode>k__BackingField; 

	public Type Type { get; set; }
	public PrimitiveTypeCode TypeCode { get; set; }


	[CompilerGeneratedAttribute] 
	public Type get_Type() { }

	[CompilerGeneratedAttribute] 
	public void set_Type(Type value) { }

	[CompilerGeneratedAttribute] 
	public PrimitiveTypeCode get_TypeCode() { }

	[CompilerGeneratedAttribute] 
	public void set_TypeCode(PrimitiveTypeCode value) { }

	public void .ctor() { }

}

